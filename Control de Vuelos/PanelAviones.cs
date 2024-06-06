using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Control_de_Vuelos
{
    public partial class PanelAviones : Form
    {
        DatabaseConnection conexion;

        public PanelAviones()
        {
            InitializeComponent();
            conexion = new DatabaseConnection();
            this.buttonDeleteAirPlane.Visible = false;
            this.buttonModifyAirPlane.Visible = false;
            this.buttonModifyView.Visible = true;
            this.textBoxMatricula.Enabled = true;

            dataGridViewAirPlanes.CellClick += dataGridViewAirPlanes_CellContentClick;
        }

        private void buttonCreateAirPlane_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validation for empty fields
                if (string.IsNullOrWhiteSpace(textBoxMarcaAvion.Text) || string.IsNullOrWhiteSpace(textBoxMatricula.Text) || string.IsNullOrWhiteSpace(textBoxCantPasajeros.Text))
                {
                    textBoxMarcaAvion.Clear();
                    textBoxMatricula.Clear();
                    textBoxCantPasajeros.Clear();
                    MessageBox.Show("Please complete all fields to enter the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Regular expression to allow only letters and spaces for brand
                string brandPattern = @"^[a-zA-Z\s]+$";
                Regex brandRegex = new Regex(brandPattern);

                // Validate brand
                if (!brandRegex.IsMatch(textBoxMarcaAvion.Text))
                {
                    throw new ArgumentException("The brand can only contain letters and spaces.");
                }

                // Get data from input controls
                string brand = textBoxMarcaAvion.Text.Trim();
                string matricula = textBoxMatricula.Text.Trim();
                int numbersOfPeople;

                // Try to parse the value of the passenger count TextBox to an integer
                if (!int.TryParse(textBoxCantPasajeros.Text, out numbersOfPeople))
                {
                    MessageBox.Show("Please enter a valid number for the passenger count.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update data in the database using the stored procedure
                if (conexion.ConnectDB.State == ConnectionState.Open)
                {
                    conexion.close();
                }

                using (SqlCommand cmd = new SqlCommand("Crear_Aviones", conexion.ConnectDB))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@matricula", matricula);
                    cmd.Parameters.AddWithValue("@marca", brand);
                    cmd.Parameters.AddWithValue("@cantidadPasajeros", numbersOfPeople);

                    conexion.open();
                    cmd.ExecuteNonQuery();
                    conexion.close();

                    MessageBox.Show("The airplane has been successfully registered.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update the DataGridView
                    CargarAviones();
                }
            }
            catch (ArgumentException ex)
            {
                // Capture and display specific validation errors
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Capture and display any other unexpected errors
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonModifyAirPlane_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewAirPlanes.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the first selected row (in case of multiple selections, the first one is taken)
                    DataGridViewRow row = dataGridViewAirPlanes.SelectedRows[0];

                    // Get the ID of the selected matricula
                    string matricula = row.Cells["Matricula"].Value.ToString();

                    // Get the new data from the TextBoxes
                    string newBranch = textBoxMarcaAvion.Text.Trim();
                    int numbersOfPeople;

                    // Try to parse the value of the passenger count TextBox to an integer
                    if (!int.TryParse(textBoxCantPasajeros.Text, out numbersOfPeople))
                    {
                        MessageBox.Show("Please enter a valid number for the passenger count.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update the data in the database using the stored procedure
                    if (conexion.ConnectDB.State == ConnectionState.Open)
                    {
                        conexion.close();
                    }

                    using (SqlCommand cmd = new SqlCommand("Actualizar_Aviones", conexion.ConnectDB))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@matricula", matricula);
                        cmd.Parameters.AddWithValue("@marca", newBranch);
                        cmd.Parameters.AddWithValue("@cantidadPasajeros", numbersOfPeople);

                        conexion.open();
                        cmd.ExecuteNonQuery();
                        conexion.close();

                        MessageBox.Show("The airplane has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Update the DataGridView to reflect changes
                        CargarAviones();
                    }

                    // Deselect the selected row in the DataGridView
                    dataGridViewAirPlanes.ClearSelection();

                    // Clear and disable the TextBoxes
                    textBoxCantPasajeros.Clear();
                    textBoxMarcaAvion.Clear();
                    textBoxMatricula.Clear();

                    // Button visibility
                    this.buttonDeleteAirPlane.Visible = false;
                    this.buttonModifyAirPlane.Visible = false;
                    this.buttonCreateAirPlane.Visible = true;
                    this.buttonModifyView.Visible = true;
                    this.textBoxMatricula.Enabled = true;
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("The selected row is null. Please select a valid airplane from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (SqlException ex)
                {
                    // Check if the error is due to the duplicate name
                    if (ex.Number == 50000) // 50000 is the error number used in RAISERROR
                    {
                        MessageBox.Show(ex.Message, "Error: Duplicated name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while updating the airplane: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an airplane from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonDeleteAirPlane_Click_1(object sender, EventArgs e)
        {
            // Verifica si alguna fila está seleccionada en el DataGridView
            if (dataGridViewAirPlanes.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtiene la primera fila seleccionada (en caso de selecciones múltiples, se toma la primera)
                    DataGridViewRow row = dataGridViewAirPlanes.SelectedRows[0];

                    // Obtiene la matrícula del avión seleccionado
                    string matricula = row.Cells["Matricula"].Value.ToString();

                    // Confirmación para eliminar el avión
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this Airplane?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Conexión a la base de datos
                        if (conexion.ConnectDB.State == ConnectionState.Open)
                        {
                            conexion.close();
                        }

                        // Ejecuta el procedimiento almacenado para desactivar el avión
                        using (SqlCommand cmd = new SqlCommand("Desactivar_Aviones", conexion.ConnectDB))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@matricula", matricula);

                            conexion.open();
                            cmd.ExecuteNonQuery();
                            conexion.close();

                            MessageBox.Show("The airplane with this code '" + matricula + "' has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Limpiar y deshabilitar los TextBoxes
                            textBoxMatricula.Clear();
                            textBoxMarcaAvion.Clear();
                            textBoxCantPasajeros.Clear();

                            // Actualizar el DataGridView
                            CargarAviones();
                        }

                        // Visibilidad de los botones
                        this.buttonDeleteAirPlane.Visible = false;
                        this.buttonModifyAirPlane.Visible = false;
                        this.buttonCreateAirPlane.Visible = true;
                        this.buttonModifyView.Visible = true;
                        this.textBoxMatricula.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the airplane: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an airplane from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonModifyView_Click_1(object sender, EventArgs e)
        {
            this.buttonDeleteAirPlane.Visible = true;
            this.buttonModifyAirPlane.Visible = true;
            this.buttonCreateAirPlane.Visible = false;
            this.buttonModifyView.Visible = false;
            this.textBoxMatricula.Enabled = false;
        }

        private void dataGridViewAirPlanes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda seleccionada es válida y no es la cabecera de la fila
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = dataGridViewAirPlanes.Rows[e.RowIndex];

                // Extrae los datos de la fila y los asigna a los TextBox correspondientes
                textBoxMatricula.Text = row.Cells["Matricula"].Value.ToString();
                textBoxMarcaAvion.Text = row.Cells["Marca"].Value.ToString();
                textBoxCantPasajeros.Text = row.Cells["Capacidad"].Value.ToString();
            }
        }

     

        private void PanelAviones_Load(object sender, EventArgs e)
        {
            CargarAviones();
        }

        private void CargarAviones()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerAviones", conexion.ConnectDB))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable tablaAviones = new DataTable();
                    adaptador.Fill(tablaAviones);

                    // Modifica el nombre de las columnas en el DataTable
                    tablaAviones.Columns["matricula"].ColumnName = "Matricula";
                    tablaAviones.Columns["marca"].ColumnName = "Marca";
                    tablaAviones.Columns["capacidadPasajeros"].ColumnName = "Capacidad";
                    tablaAviones.Columns["estado"].ColumnName = "Estado binario";

                    // Agrega una nueva columna 'Estado' al DataTable con valores 'Activo' o 'Inactivo'
                    tablaAviones.Columns.Add("Estado", typeof(string));
                    foreach (DataRow row in tablaAviones.Rows)
                    {
                        // Obtiene el valor del estado y asigna 'Activo' o 'Inactivo' a la nueva columna
                        int estado = Convert.ToInt32(row["Estado binario"]);
                        row["Estado"] = (estado == 1) ? "Activo" : "Inactivo";
                    }

                    // Asigna los datos al DataGridView
                    dataGridViewAirPlanes.DataSource = tablaAviones;

                    // Oculta la columna 'Estado binario' y cambia el encabezado de la columna 'Estado'
                    dataGridViewAirPlanes.Columns["Estado binario"].Visible = false;
                    dataGridViewAirPlanes.Columns["Estado"].HeaderText = "Estado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los aviones registrados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

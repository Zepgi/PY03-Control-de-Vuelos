using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Vuelos
{
    public partial class PanelAerolineas : Form
    {
        DatabaseConnection conexion;

		public PanelAerolineas()
        {
            conexion = new DatabaseConnection();

			InitializeComponent();
            // Vincula el evento CellClick al DataGridView
            dataGridViewAirlines.CellClick += dataGridViewAerolineas_CellClick;
            this.buttonDeleteAirline.Visible = false;
            this.buttonModifyAirline.Visible = false;
        }

        private void PanelAerolineas_Load(object sender, EventArgs e)
        {
            CargarAerolineas();
        }

        /// <summary>
        /// Registra el nombre y el lema de una aerolinea creada
        /// </summary>
        private void buttonCreateAirline_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation for empty fields
                if (string.IsNullOrWhiteSpace(textBoxNombreAerolinea.Text) || string.IsNullOrWhiteSpace(textBoxLemaAerolinea.Text))
                {
                    textBoxNombreAerolinea.Clear();
                    textBoxLemaAerolinea.Clear();
                    MessageBox.Show("Please complete all fields to enter the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Regular expression to allow only letters and spaces
                string pattern = @"^[a-zA-Z\s]+$";
                Regex regex = new Regex(pattern);

                // Validate airline name
                if (!regex.IsMatch(textBoxNombreAerolinea.Text))
                {
                    throw new ArgumentException("The airline name can only contain letters and spaces.");
                }

                // Validate airline slogan
                if (!regex.IsMatch(textBoxLemaAerolinea.Text))
                {
                    throw new ArgumentException("The airline slogan can only contain letters and spaces.");
                }

                // Get data from input controls
                string airlineName = textBoxNombreAerolinea.Text.Trim();
                string airlineSlogan = textBoxLemaAerolinea.Text.Trim();

                // Update data in the database using the stored procedure
                if (conexion.ConnectDB.State == ConnectionState.Open)
                {
                    conexion.close();
                }

                using (SqlCommand cmd = new SqlCommand("Crear_Aerolinea", conexion.ConnectDB))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", airlineName);
                    cmd.Parameters.AddWithValue("@lema", airlineSlogan);

                    conexion.open();
                    cmd.ExecuteNonQuery();
                    conexion.close();

                    MessageBox.Show("The airline has been successfully registered.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update the DataGridView
                    CargarAerolineas();
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

        /// <summary>
        /// Carga las aerolíneas registradas en el DataGridView.
        /// </summary>
        private void CargarAerolineas()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerAerolineas", conexion.ConnectDB))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable tablaAerolineas = new DataTable();
                    adaptador.Fill(tablaAerolineas);

                    // Modifica el nombre de la columna 'estado' en el DataTable
                    tablaAerolineas.Columns["idAerolinea"].ColumnName = "Codigo";
                    tablaAerolineas.Columns["nombre"].ColumnName = "Nombre";
                    tablaAerolineas.Columns["lema"].ColumnName = "Lema";
                    tablaAerolineas.Columns["estado"].ColumnName = "Estado binario";

                    // Agrega una nueva columna 'Estado' al DataTable con valores 'Activo' o 'Inactivo'
                    tablaAerolineas.Columns.Add("Estado", typeof(string));
                    foreach (DataRow row in tablaAerolineas.Rows)
                    {
                        // Obtiene el valor del estado y asignar 'Activo' o 'Inactivo' a la nueva columna
                        int estado = Convert.ToInt32(row["Estado binario"]);
                        row["Estado"] = (estado == 1) ? "Activo" : "Inactivo";
                    }

                    // Asignar los datos al DataGridView
                    dataGridViewAirlines.DataSource = tablaAerolineas;

                    // Ocultar la columna 'Estado binario' y cambiar el encabezado de la columna 'Estado'
                    dataGridViewAirlines.Columns["Estado binario"].Visible = false;
                    dataGridViewAirlines.Columns["Estado"].HeaderText = "Estado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las aerolíneas registradas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dataGridViewAerolineas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda seleccionada es válida y no es la cabecera de la fila
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = dataGridViewAirlines.Rows[e.RowIndex];

                // Extrae los datos de la fila y los asigna a los TextBox correspondientes
                textBoxNombreAerolinea.Text = row.Cells["nombre"].Value.ToString();
                textBoxLemaAerolinea.Text = row.Cells["lema"].Value.ToString();
            }
        }



        //
        private void buttonModifyAirline_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (dataGridViewAirlines.SelectedRows.Count > 0)
            {
                // Get the first selected row (in case of multiple selections, the first one is taken)
                DataGridViewRow row = dataGridViewAirlines.SelectedRows[0];

                // Get the ID of the selected airline
                int idAirline = Convert.ToInt32(row.Cells["Codigo"].Value);

                // Get the new data from the TextBoxes
                string newName = textBoxNombreAerolinea.Text.Trim();
                string newSlogan = textBoxLemaAerolinea.Text.Trim();

                try
                {
                    // Update the data in the database using the stored procedure
                    if (conexion.ConnectDB.State == ConnectionState.Open)
                    {
                        conexion.close();
                    }

                    using (SqlCommand cmd = new SqlCommand("Actualizar_Aerolinea", conexion.ConnectDB))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idAerolinea", idAirline);
                        cmd.Parameters.AddWithValue("@nombre", newName);
                        cmd.Parameters.AddWithValue("@lema", newSlogan);

                        conexion.open();
                        cmd.ExecuteNonQuery();
                        conexion.close();

                        MessageBox.Show("The airline has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Update the DataGridView to reflect changes
                        CargarAerolineas();
                    }

                    // Deselect the selected row in the DataGridView
                    dataGridViewAirlines.ClearSelection();

                    // Clear and disable the TextBoxes
                    textBoxNombreAerolinea.Clear();
                    textBoxLemaAerolinea.Clear();

                    // Button visibility
                    this.buttonDeleteAirline.Visible = false;
                    this.buttonModifyAirline.Visible = false;
                    this.buttonCreateAirline.Visible = true;
                    this.buttonModifyView.Visible = true;
                }
                catch (SqlException ex)
                {
                    // Check if the error is due to the duplicate name
                    if (ex.Number == 50000) // 50000 is the error number used in RAISERROR
                    {
                        MessageBox.Show(ex.Message, "Error: Duplicaded name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while updating the airline: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an airline from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void buttonDeleteAirline_Click(object sender, EventArgs e)
        {
            // Verify if any row is selected in the DataGridView
            if (dataGridViewAirlines.SelectedRows.Count > 0)
            {
                // Get the first selected row (in case of multiple selections, the first one is taken)
                DataGridViewRow row = dataGridViewAirlines.SelectedRows[0];

                // Get the ID of the selected airline
                int idAirline = Convert.ToInt32(row.Cells["Codigo"].Value);

                // Confirmation to delete the airline
                DialogResult result = MessageBox.Show("Are you sure you want to delete this airline?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Connection to the database
                        if (conexion.ConnectDB.State == ConnectionState.Open)
                        {
                            conexion.close();
                        }

                        // Execute the stored procedure to delete the airline
                        using (SqlCommand cmd = new SqlCommand("Desactivar_Aerolinea", conexion.ConnectDB))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idAerolinea", idAirline);

                            conexion.open();
                            cmd.ExecuteNonQuery();
                            conexion.close();

                            MessageBox.Show("The airline has been successfully deactivated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear and disable the TextBoxes
                            textBoxNombreAerolinea.Clear();
                            textBoxLemaAerolinea.Clear();

                            // Update the DataGridView
                            CargarAerolineas();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deactivating the airline: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Button visibility
                    this.buttonDeleteAirline.Visible = false;
                    this.buttonModifyAirline.Visible = false;
                    this.buttonCreateAirline.Visible = true;
                    this.buttonModifyView.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please select an airline from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Button visibility
            this.buttonDeleteAirline.Visible = false;
            this.buttonModifyAirline.Visible = false;
            this.buttonCreateAirline.Visible = true;
            this.buttonModifyView.Visible = true;
        }

        private void buttonModifyView_Click(object sender, EventArgs e)
        {
            this.buttonDeleteAirline.Visible = true;
            this.buttonModifyAirline.Visible = true;
            this.buttonCreateAirline.Visible = false;
            this.buttonModifyView.Visible = false;
        }

    }




}

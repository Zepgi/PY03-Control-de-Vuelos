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
        public PanelAerolineas()
        {
            InitializeComponent();
            // Vincula el evento CellClick al DataGridView
            dataGridViewAerolineas.CellClick += dataGridViewAerolineas_CellClick;
        }

        private void PanelAerolineas_Load(object sender, EventArgs e)
        {
            CargarAerolineas();
        }

        /// <summary>
        /// Registra el nombre y el lema de una aerolinea creada
        /// </summary>
        private void buttonCrearAerolinea_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación para campos vacíos
                if (string.IsNullOrWhiteSpace(textBoxNombreAerolinea.Text) || string.IsNullOrWhiteSpace(textBoxLemaAerolinea.Text))
                {
                    textBoxNombreAerolinea.Clear();
                    textBoxLemaAerolinea.Clear();
                    MessageBox.Show("Por favor, complete todos los campos para ingresar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Expresión regular para solo permitir letras y espacios
                string pattern = @"^[a-zA-Z\s]+$";
                Regex regex = new Regex(pattern);

                // Validar nombre de aerolínea
                if (!regex.IsMatch(textBoxNombreAerolinea.Text))
                {
                    throw new ArgumentException("El nombre de la aerolínea solo puede contener letras y espacios.");
                }

                // Validar lema de aerolínea
                if (!regex.IsMatch(textBoxLemaAerolinea.Text))
                {
                    throw new ArgumentException("El lema de la aerolínea solo puede contener letras y espacios.");
                }

                // Obtenemos los datos de los controles de entrada
                string nombreAerolineas = textBoxNombreAerolinea.Text.Trim();
                string lemaAerolinea = textBoxLemaAerolinea.Text.Trim();

                // Actualizar los datos en la base de datos utilizando el stored procedure
                Conexion conexion = new Conexion();
                if (conexion.SQLConexionBD.State == ConnectionState.Open)
                {
                    conexion.SQLConexionBD.Close();
                }

                using (SqlCommand cmd = new SqlCommand("Crear_Aerolinea", conexion.SQLConexionBD))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombreAerolineas);
                    cmd.Parameters.AddWithValue("@lema", lemaAerolinea);

                    conexion.SQLConexionBD.Open();
                    cmd.ExecuteNonQuery();
                    conexion.SQLConexionBD.Close();

                    MessageBox.Show("La aerolínea se ha registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualizar el DataGridView
                    CargarAerolineas();
                }
            }
            catch (ArgumentException ex)
            {
                // Captura y muestra errores específicos de validación
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Captura y muestra cualquier otro error no previsto
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga las aerolíneas registradas en el DataGridView.
        /// </summary>
       private void CargarAerolineas()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (SqlCommand cmd = new SqlCommand("ObtenerAerolineas", conexion.SQLConexionBD))
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
                    dataGridViewAerolineas.DataSource = tablaAerolineas;

                    // Ocultar la columna 'Estado binario' y cambiar el encabezado de la columna 'Estado'
                    dataGridViewAerolineas.Columns["Estado binario"].Visible = false;
                    dataGridViewAerolineas.Columns["Estado"].HeaderText = "Estado";
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
                DataGridViewRow row = dataGridViewAerolineas.Rows[e.RowIndex];

                // Extrae los datos de la fila y los asigna a los TextBox correspondientes
                textBoxNombreAerolinea.Text = row.Cells["nombre"].Value.ToString();
                textBoxLemaAerolinea.Text = row.Cells["lema"].Value.ToString();
            }
        }
        private void buttonModificarAerolinea_Click(object sender, EventArgs e)
        {

            // Verifica si alguna fila está seleccionada en el DataGridView
            if (dataGridViewAerolineas.SelectedRows.Count > 0)
            {
                // Obtiene la primera fila seleccionada (en caso de múltiples selecciones, se toma la primera)
                DataGridViewRow row = dataGridViewAerolineas.SelectedRows[0];

                // Obtiene el ID de la aerolínea seleccionada
                int idAerolinea = Convert.ToInt32(row.Cells["idAerolinea"].Value);

                MessageBox.Show("id: " + idAerolinea);
                // Obtiene los nuevos datos de los TextBox
                string nuevoNombre = textBoxNombreAerolinea.Text.Trim();
                string nuevoLema = textBoxLemaAerolinea.Text.Trim();

                // Actualiza los datos en la base de datos utilizando el stored procedure
                Conexion conexion = new Conexion();
                if (conexion.SQLConexionBD.State == ConnectionState.Open)
                {
                    conexion.SQLConexionBD.Close();
                }

                using (SqlCommand cmd = new SqlCommand("Actualizar_Aerolinea", conexion.SQLConexionBD))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idAerolinea", idAerolinea);
                    cmd.Parameters.AddWithValue("@nombre", nuevoNombre);
                    cmd.Parameters.AddWithValue("@lema", nuevoLema);

                    conexion.SQLConexionBD.Open();
                    cmd.ExecuteNonQuery();
                    conexion.SQLConexionBD.Close();

                    MessageBox.Show("La aerolínea se ha actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualiza el DataGridView para reflejar los cambios
                    CargarAerolineas();
                }

                // Deselecciona la fila seleccionada en el DataGridView
                dataGridViewAerolineas.ClearSelection();

                // Limpia los TextBox y los deshabilita
                textBoxNombreAerolinea.Clear();
                textBoxLemaAerolinea.Clear();
               
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una aerolínea de la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEliminarAerolinea_Click(object sender, EventArgs e)
        {
            // Verifica si alguna fila está seleccionada en el DataGridView
            if (dataGridViewAerolineas.SelectedRows.Count > 0)
            {
                // Obtiene la primera fila seleccionada (en caso de múltiples selecciones, se toma la primera)
                DataGridViewRow row = dataGridViewAerolineas.SelectedRows[0];

                // Obtiene el ID de la aerolínea seleccionada
                int idAerolinea = Convert.ToInt32(row.Cells["Codigo"].Value);

                // Confirmación para eliminar la aerolínea
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta aerolínea?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Conexión a la base de datos
                        Conexion conexion = new Conexion();
                        if (conexion.SQLConexionBD.State == ConnectionState.Open)
                        {
                            conexion.SQLConexionBD.Close();
                        }

                        // Ejecutar el procedimiento almacenado para eliminar la aerolínea
                        using (SqlCommand cmd = new SqlCommand("Eliminar_Aerolinea", conexion.SQLConexionBD))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idAerolinea", idAerolinea);

                            conexion.SQLConexionBD.Open();
                            cmd.ExecuteNonQuery();
                            conexion.SQLConexionBD.Close();

                            MessageBox.Show("La aerolínea se ha eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Limpia los TextBox y los deshabilita
                            textBoxNombreAerolinea.Clear();
                            textBoxLemaAerolinea.Clear();


                            // Actualizar el DataGridView
                            CargarAerolineas();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la aerolínea: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una aerolínea de la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }




}

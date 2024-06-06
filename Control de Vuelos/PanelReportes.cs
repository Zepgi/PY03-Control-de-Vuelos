using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Vuelos
{
    public partial class PanelReportes : Form
    {
        DatabaseConnection conexion;
        public PanelReportes()
        {
            InitializeComponent();
            conexion = new DatabaseConnection();
        }

        private void PanelReportes_Load(object sender, EventArgs e)
        {
            CargarAviones();
        }

        private void dataGridViewAirPlanes_AirLines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarAviones()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("Aviones_Aerolineas", conexion.ConnectDB))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable tablaAviones = new DataTable();
                    adaptador.Fill(tablaAviones);

                    // Modifica el nombre de las columnas en el DataTable
                    tablaAviones.Columns["NombreAerolinea"].ColumnName = "Nombre";
                    tablaAviones.Columns["MarcaAvion"].ColumnName = "Marca";
                    tablaAviones.Columns["MatriculaAvion"].ColumnName = "Matrícula";
                    tablaAviones.Columns["CapacidadPasajeros"].ColumnName = "Capacidad Pasajeros";
                    tablaAviones.Columns["EstadoAvion"].ColumnName = "Estado Binario";

                    // Agrega una nueva columna 'Estado' al DataTable con valores 'Activo' o 'Inactivo'
                    tablaAviones.Columns.Add("Estado", typeof(string));
                    foreach (DataRow row in tablaAviones.Rows)
                    {
                        // Obtiene el valor del estado y asigna 'Activo' o 'Inactivo' a la nueva columna
                        int estado = Convert.ToInt32(row["Estado Binario"]);
                        row["Estado"] = (estado == 1) ? "Activo" : "Inactivo";
                    }

                    // Asigna los datos al DataGridView
                    dataGridViewAirPlanes_AirLines.DataSource = tablaAviones;

                    // Oculta la columna 'Estado Binario' y cambia el encabezado de la columna 'Estado'
                    dataGridViewAirPlanes_AirLines.Columns["Estado Binario"].Visible = false;
                    dataGridViewAirPlanes_AirLines.Columns["Estado"].HeaderText = "Estado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading registered airplanes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}


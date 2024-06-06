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
            CargarVuelos();
        }

        private void dataGridViewAirPlanes_AirLines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarAviones()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("Airplanes_Airlines", conexion.ConnectDB))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable airplanesTable = new DataTable();
                    adapter.Fill(airplanesTable);

                    // Rename columns in the DataTable
                    airplanesTable.Columns["AirlineName"].ColumnName = "Nombre de la Aerolinea";
                    airplanesTable.Columns["AirplaneBrand"].ColumnName = "Marca Avión";
                    airplanesTable.Columns["AirplaneRegistration"].ColumnName = "Matrícula Avión";
                    airplanesTable.Columns["PassengerCapacity"].ColumnName = "Capacidad Pasajeros";
                    airplanesTable.Columns["AirplaneStatus"].ColumnName = "Estado Avión";

                    // Add a new 'Estado' column to the DataTable with 'Activo' or 'Inactivo' values
                    airplanesTable.Columns.Add("Estado", typeof(string));
                    foreach (DataRow row in airplanesTable.Rows)
                    {
                        // Get the status value and assign 'Activo' or 'Inactivo' to the new column
                        int estado = Convert.ToInt32(row["Estado Avión"]);
                        row["Estado"] = (estado == 1) ? "Activo" : "Inactivo";
                    }

                    // Bind data to the DataGridView
                    dataGridViewAirPlanes_AirLines.DataSource = airplanesTable;

                    // Hide the 'Estado Binario' column and change the header of the 'Estado' column
                    dataGridViewAirPlanes_AirLines.Columns["Estado Avión"].Visible = false;
                    dataGridViewAirPlanes_AirLines.Columns["Estado"].HeaderText = "Estado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading registered airplanes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dataGridViewAire8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void CargarVuelos()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetFlightDetails", conexion.ConnectDB))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable tablaVuelos = new DataTable();
                    adaptador.Fill(tablaVuelos);

                    // Modifica el nombre de las columnas en el DataTable
                    tablaVuelos.Columns["AirlineName"].ColumnName = "Nombre Aerolínea";
                    tablaVuelos.Columns["FlightId"].ColumnName = "ID Vuelo";
                    tablaVuelos.Columns["OriginCity"].ColumnName = "Ciudad Origen";
                    tablaVuelos.Columns["DestinationCity"].ColumnName = "Ciudad Destino";
                    tablaVuelos.Columns["DepartureTime"].ColumnName = "Hora Salida";
                    tablaVuelos.Columns["ArrivalTime"].ColumnName = "Hora Llegada";

                    // Asigna los datos al DataGridView
                    dataGridViewAire8.DataSource = tablaVuelos;

                    // Ajusta los encabezados de las columnas en el DataGridView si es necesario
                    dataGridViewAire8.Columns["Nombre Aerolínea"].HeaderText = "Nombre Aerolínea";
                    dataGridViewAire8.Columns["ID Vuelo"].HeaderText = "ID Vuelo";
                    dataGridViewAire8.Columns["Ciudad Origen"].HeaderText = "Ciudad Origen";
                    dataGridViewAire8.Columns["Ciudad Destino"].HeaderText = "Ciudad Destino";
                    dataGridViewAire8.Columns["Hora Salida"].HeaderText = "Hora Salida";
                    dataGridViewAire8.Columns["Hora Llegada"].HeaderText = "Hora Llegada";
                }
            }
            catch (Exception ex)
            {
                // Capturar y mostrar cualquier error inesperado
                MessageBox.Show("Error al cargar los vuelos registrados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void guna2ButtonAir8_Click(object sender, EventArgs e)
{
    try
    {
        // Validar que el campo no esté vacío
        if (string.IsNullOrWhiteSpace(guna2TextBoxAir8.Text))
        {
            CargarVuelos();
            return;
        }

        // Obtener el nombre de la aerolínea desde el cuadro de texto
        string airlineName = guna2TextBoxAir8.Text.Trim();

        // Conectar y ejecutar el procedimiento almacenado
        if (conexion.ConnectDB.State == ConnectionState.Open)
        {
            conexion.close();
        }

        using (SqlCommand cmd = new SqlCommand("GetAirlineFlightsByNames", conexion.ConnectDB))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", airlineName);

            conexion.open();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable tablaVuelos = new DataTable();
            adaptador.Fill(tablaVuelos);

            if (tablaVuelos.Rows.Count > 0)
            {
                // Limpiar columnas existentes en el DataGridView
                dataGridViewAire8.Columns.Clear();

                // Asigna los datos al DataGridView
                dataGridViewAire8.DataSource = tablaVuelos;

                // Ajusta los encabezados de las columnas en el DataGridView
                dataGridViewAire8.Columns["AirlineName"].HeaderText = "Nombre Aerolínea";
                dataGridViewAire8.Columns["FlightId"].HeaderText = "ID Vuelo";
                dataGridViewAire8.Columns["OriginCity"].HeaderText = "Ciudad Origen";
                dataGridViewAire8.Columns["DestinationCity"].HeaderText = "Ciudad Destino";
                dataGridViewAire8.Columns["DepartureTime"].HeaderText = "Hora Salida";
                dataGridViewAire8.Columns["ArrivalTime"].HeaderText = "Hora Llegada";

                // Limpiar el cuadro de texto después de cargar los datos
                guna2TextBoxAir8.Clear();
            }
            else
            {
                MessageBox.Show("No se encontraron vuelos para la aerolínea proporcionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guna2TextBoxAir8.Clear();
            }

            conexion.close();
        }
    }
    catch (Exception ex)
    {
        // Captura y muestra cualquier error inesperado
        MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}



        private void airline3_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el campo no esté vacío
                if (string.IsNullOrWhiteSpace(searchAirLine3.Text))
                {
                    CargarAviones();
                    return;
                }

                // Obtener el nombre de la aerolínea desde el cuadro de texto
                string airlineName = searchAirLine3.Text.Trim();

                // Conectar y ejecutar el procedimiento almacenado
                if (conexion.ConnectDB.State == ConnectionState.Open)
                {
                    conexion.close();
                }

                using (SqlCommand cmd = new SqlCommand("GetAirplanesByAirlineName", conexion.ConnectDB))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AirlineName", airlineName);

                    conexion.open();
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable tablaAviones = new DataTable();
                    adaptador.Fill(tablaAviones);

                    if (tablaAviones.Rows.Count > 0)
                    {
                        // Cambia el nombre de las columnas en el DataTable si es necesario
                        // Asegúrate de que los nombres coincidan exactamente con los devueltos por el procedimiento almacenado
                        tablaAviones.Columns["AirlineName"].ColumnName = "Nombre de la Aerolinea";
                        tablaAviones.Columns["AirplaneBrand"].ColumnName = "Marca Avión";
                        tablaAviones.Columns["AirplaneRegistration"].ColumnName = "Matrícula Avión";
                        tablaAviones.Columns["PassengerCapacity"].ColumnName = "Capacidad Pasajeros";
                        tablaAviones.Columns["AirplaneStatus"].ColumnName = "Estado Avión";

                        // Agregar una nueva columna 'Estado' al DataTable con valores 'Activo' o 'Inactivo'
                        tablaAviones.Columns.Add("Estado", typeof(string));
                        foreach (DataRow row in tablaAviones.Rows)
                        {
                            // Obtener el valor del estado y asignar 'Activo' o 'Inactivo' a la nueva columna
                            int estado = Convert.ToInt32(row["Estado Avión"]);
                            row["Estado"] = (estado == 1) ? "Activo" : "Inactivo";
                        }

                        // Asigna los datos al DataGridView
                        dataGridViewAirPlanes_AirLines.DataSource = tablaAviones;

                        // Oculta la columna 'Estado Avión' y cambia el encabezado de la columna 'Estado'
                        dataGridViewAirPlanes_AirLines.Columns["Estado Avión"].Visible = false;
                        dataGridViewAirPlanes_AirLines.Columns["Estado"].HeaderText = "Estado";

                        // Limpiar el cuadro de búsqueda después de cargar los datos
                        searchAirLine3.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron aviones para la aerolínea proporcionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        searchAirLine3.Clear();
                    }

                    conexion.close();
                }
            }
            catch (Exception ex)
            {
                // Captura y muestra cualquier error inesperado
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCheckFlys1_Click(object sender, EventArgs e)
        {

        }
    }
}


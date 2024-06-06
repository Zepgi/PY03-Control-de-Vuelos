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
            cloumnsFligthPerPassenger();
            loadFligthsPerPassenger();
            CargarAvionesInactivos();

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

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        //Creates the columns for the Fligth per passanger report
        private void cloumnsFligthPerPassenger()
        {
            // Create the columns on the DataGrid
            fligthPerPassengerGrid.Columns.Add("idColumn", "ID");
            fligthPerPassengerGrid.Columns.Add("airlineColumn", "Aerolinea");
            fligthPerPassengerGrid.Columns.Add("airplaneColumn", "Avion");
            fligthPerPassengerGrid.Columns.Add("identityColumn", "Cedula Pasajero");
            fligthPerPassengerGrid.Columns.Add("dateHourDColumn", "Fecha y Hora Partida");
            fligthPerPassengerGrid.Columns.Add("dateHourAColumn", "Fecha y Hora Llegada");
            fligthPerPassengerGrid.Columns.Add("cityDColumn", "Cuidad Partida");
            fligthPerPassengerGrid.Columns.Add("cityAColumn", "Cuidad Llegada");

            fligthPerPassengerGrid.AutoGenerateColumns = false;  // Disable automatic column generation
            fligthPerPassengerGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        //Load the grid for the Fligth per passanger report
        private void loadFligthsPerPassenger()
        {
            try
            {
                // Open connection
                conexion.open();

                SqlCommand data = new SqlCommand("Get_Pilots_Data", conexion.ConnectDB);
                data.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(data);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                // Map columns explicitly
                fligthPerPassengerGrid.Columns["idColumn"].DataPropertyName = "idVuelo";
                fligthPerPassengerGrid.Columns["airlineColumn"].DataPropertyName = "nombre";
                fligthPerPassengerGrid.Columns["airplaneColumn"].DataPropertyName = "matricula";
                fligthPerPassengerGrid.Columns["identityColumn"].DataPropertyName = "cedulaPasajero";
                fligthPerPassengerGrid.Columns["dateHourDColumn"].DataPropertyName = "fechaHoraPartida";
                fligthPerPassengerGrid.Columns["dateHourAColumn"].DataPropertyName = "fechaHoraLlegada";
                fligthPerPassengerGrid.Columns["cityDColumn"].DataPropertyName = "codigoCiudadPartida";
                fligthPerPassengerGrid.Columns["cityAColumn"].DataPropertyName = "codigoCiudadDestino";

                // Assign data to DataGridView
                fligthPerPassengerGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close connection
                conexion.close();
            }


        }

        private void passengerInfo(DataGridViewRow row)
        {
            //Abrir ventana con info del pasajero
        }

        //Selected all the row
        private void fligthPerPassengerGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (fligthPerPassengerGrid.SelectedCells.Count == 0)
                return;

            fligthPerPassengerGrid.ClearSelection();

            foreach (DataGridViewCell cell in fligthPerPassengerGrid.SelectedCells)
            {
                if (cell != null && cell.OwningRow != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    row.Selected = true;
                    break;
                }
            }

        }

        private void fligthPerPassengerGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Left)
            {
                fligthPerPassengerGrid.ClearSelection();
                DataGridViewRow row = fligthPerPassengerGrid.Rows[e.RowIndex];
                row.Selected = true;

                passengerInfo(row);
            }

        }

        private void buttonCheckFlys1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validar que el campo de fecha no esté vacío
                if (dtDepartureDate1.Value == null)
                {
                    MessageBox.Show("Por favor, seleccione una fecha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener la fecha seleccionada desde el DateTimePicker
                DateTime selectedDate = dtDepartureDate1.Value;

                // Conectar y ejecutar el procedimiento almacenado
                if (conexion.ConnectDB.State == ConnectionState.Open)
                {
                    conexion.close();
                }

                using (SqlCommand cmd = new SqlCommand("GetActiveFlightsByDate", conexion.ConnectDB))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Date", selectedDate);

                    conexion.open();
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable tablaVuelos = new DataTable();
                    adaptador.Fill(tablaVuelos);

                    if (tablaVuelos.Rows.Count > 0)
                    {
                        // Asigna los datos al DataGridView
                        dataGridViewAir1.DataSource = tablaVuelos;

                        // Cambia el nombre de las columnas en el DataTable
                        tablaVuelos.Columns["FlightId"].ColumnName = "ID Vuelo";
                        tablaVuelos.Columns["AirlineName"].ColumnName = "Nombre Aerolínea";
                        tablaVuelos.Columns["AirplaneBrand"].ColumnName = "Marca Avión";
                        tablaVuelos.Columns["PilotName"].ColumnName = "Nombre Piloto";
                        tablaVuelos.Columns["OriginCity"].ColumnName = "Ciudad Origen";
                        tablaVuelos.Columns["DestinationCity"].ColumnName = "Ciudad Destino";
                        tablaVuelos.Columns["DepartureTime"].ColumnName = "Hora Salida";
                        tablaVuelos.Columns["ArrivalTime"].ColumnName = "Hora Llegada";
                        tablaVuelos.Columns["FlightStatus"].ColumnName = "Estado del Vuelo";

                        // Convertir el estado del vuelo a "Activo" o "Inactivo"
                        tablaVuelos.Columns.Add("Estado", typeof(string));
                        foreach (DataRow row in tablaVuelos.Rows)
                        {
                            int estado = Convert.ToInt32(row["Estado del Vuelo"]);
                            row["Estado"] = (estado == 1) ? "Activo" : "Inactivo";
                        }

                        // Oculta la columna 'Estado del Vuelo' y cambia el encabezado de la columna 'Estado'
                        dataGridViewAir1.Columns["Estado del Vuelo"].Visible = false;
                        dataGridViewAir1.Columns["Estado"].HeaderText = "Estado";

                        // Ajusta los encabezados de las columnas en el DataGridView si es necesario
                        dataGridViewAir1.Columns["ID Vuelo"].HeaderText = "ID Vuelo";
                        dataGridViewAir1.Columns["Nombre Aerolínea"].HeaderText = "Nombre Aerolínea";
                        dataGridViewAir1.Columns["Marca Avión"].HeaderText = "Marca Avión";
                        dataGridViewAir1.Columns["Nombre Piloto"].HeaderText = "Nombre Piloto";
                        dataGridViewAir1.Columns["Ciudad Origen"].HeaderText = "Ciudad Origen";
                        dataGridViewAir1.Columns["Ciudad Destino"].HeaderText = "Ciudad Destino";
                        dataGridViewAir1.Columns["Hora Salida"].HeaderText = "Hora Salida";
                        dataGridViewAir1.Columns["Hora Llegada"].HeaderText = "Hora Llegada";
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron vuelos activos para la fecha proporcionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void butonjose_Click(object sender, EventArgs e)
        {

            try
            {
                // Validar que el campo no esté vacío
                if (string.IsNullOrWhiteSpace(textboxjose.Text))
                {
                    CargarAvionesInactivos();
                    return;
                }

                // Obtener el nombre de la aerolínea desde el cuadro de texto
                string airlineName = searchAirLine3.Text.Trim();

                // Conectar y ejecutar el procedimiento almacenado
                if (conexion.ConnectDB.State == ConnectionState.Open)
                {
                    conexion.close();
                }

                using (SqlCommand cmd = new SqlCommand("GetAirplanesByAirlinesInactiveState", conexion.ConnectDB))
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
                        tablaAviones.Columns["AirlineName"].ColumnName = "Nombre de la Aerolínea";
                        tablaAviones.Columns["AirplaneBrand"].ColumnName = "Marca del Avión";
                        tablaAviones.Columns["AirplaneRegistration"].ColumnName = "Matrícula del Avión";
                        tablaAviones.Columns["PassengerCapacity"].ColumnName = "Capacidad de Pasajeros";



                      
                        // Asigna los datos al DataGridView
                        dataGridJose.DataSource = tablaAviones;



                        // Limpiar el cuadro de búsqueda después de cargar los datos
                        textboxjose.Clear();
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



        private void CargarAvionesInactivos()
        {
            try
            {
                // Limpiar el DataGridView antes de cargar los datos
                dataGridJose.DataSource = null;
                dataGridJose.Columns.Clear();

                using (SqlCommand cmd = new SqlCommand("AirplanesByAirlinesInactiveState", conexion.ConnectDB))
                {
                    // Configurar el comando para llamar al stored procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Crear un adaptador de datos para llenar un DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asignar los datos al DataGridView
                    dataGridJose.DataSource = dataTable;

                    // Opcional: Personalizar los encabezados de las columnas si es necesario
                    dataGridJose.Columns["AirlineName"].HeaderText = "Nombre de la Aerolínea";
                    dataGridJose.Columns["AirplaneBrand"].HeaderText = "Marca del Avión";
                    dataGridJose.Columns["AirplaneRegistration"].HeaderText = "Matrícula del Avión";
                    dataGridJose.Columns["PassengerCapacity"].HeaderText = "Capacidad de Pasajeros";

                    // Ocultar la columna 'AirplaneStatus'
                    dataGridJose.Columns["AirplaneStatus"].Visible = false;

                    // Cerrar la conexión si fuera necesario (no se ve en el código proporcionado)
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar aviones inactivos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



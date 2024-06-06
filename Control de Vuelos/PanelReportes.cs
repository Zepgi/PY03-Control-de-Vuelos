using Guna.UI2.WinForms;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Control_de_Vuelos
{
    public partial class PanelReportes : Form
    {
        DatabaseConnection conexion;
        private int idAirline;
        public PanelReportes(int pIdAirline)
        {
            this.idAirline = pIdAirline;
            InitializeComponent();
            this.lbAirline.Visible = false;
            this.cbAirlines.Visible = false;
            conexion = new DatabaseConnection();
            top3Days();
            CargarAvionesInactivos();
            cloumnsFligthPerPassenger();
            loadFligthsPerPassenger();
            cloumnsCancelledFligths();
            loadCancelledFligths();
            columnsPassengersConfirm();
            loadPassengersConfirm();


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

        ////////////////////           EYDEN
        private void button_ClickHandler(object sender, EventArgs e) { 
            Guna2Button b = (Guna2Button)sender;
            switch (b.Name) {
				case "btPlanesByCity":
                    this.lbAirline.Visible = true;
                    this.cbAirlines.Visible = true;
                    this.cbAirlines.Items.Clear();
                    getAirlines();
					setPlanesByCity();
					break;
				case "btDifferentPlanes":
					this.lbAirline.Visible = false;
					this.cbAirlines.Visible = false;
					setDifferentPlanes();
					break;
				case "btTopCity":
					this.lbAirline.Visible = false;
					this.cbAirlines.Visible = false;
					setTopCities();
					break;
				default: 
                    break;
			}
        }


		// todos usan tbPlanes
		private void setPlanesByCity() {
			try {
				this.conexion.open();
				SqlCommand cmd = new SqlCommand("Planes_By_City", this.conexion.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@idAerolinea", this.idAirline);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				tbPlanes.DataSource = dt;
			} catch (Exception ex) {
				MessageBox.Show("Error: " + ex.Message, "Error al obtener aviones por ciudad", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				if (this.conexion.ConnectDB.State == ConnectionState.Open) {
					this.conexion.close();
				}
			}
		}

		private void setDifferentPlanes() {
			try {
				this.conexion.open();
				SqlCommand cmd = new SqlCommand("Distinct_Planes", this.conexion.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				tbPlanes.DataSource = dt;
				tbPlanes.Columns["Aviones"].HeaderText = "Cantidad de Aviones";
				tbPlanes.Columns["Partida"].HeaderText = "Ciudad de Partida";
				tbPlanes.Columns["Destino"].HeaderText = "Ciudad de Destino";
			} catch (Exception ex) {
				MessageBox.Show("Error: " + ex.Message, "Error al obtener aviones distintos", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				if (this.conexion.ConnectDB.State == ConnectionState.Open) {
					this.conexion.close();
				}
			}
		}

		private void setTopCities() {
			try {
				this.conexion.open();
				SqlCommand cmd = new SqlCommand("Top_City", this.conexion.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				tbPlanes.DataSource = dt;
				tbPlanes.Columns["Aviones"].HeaderText = "Cantidad de Aviones";
				tbPlanes.Columns["Vuelos"].HeaderText = "Cantidad de Vuelos";
				tbPlanes.Columns["Ciudad"].HeaderText = "Ciudad de Destino";
			} catch (Exception ex) {
				MessageBox.Show("Error: " + ex.Message, "Error al obtener las ciudades top", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				if (this.conexion.ConnectDB.State == ConnectionState.Open) {
					this.conexion.close();
				}
			}
		}


		private void cbAirlines_IndexChanged(object sender, EventArgs e) {
			if (this.cbAirlines.SelectedIndex != -1) {
				this.idAirline = Convert.ToInt32(this.cbAirlines.SelectedItem.ToString().Split('-')[0].Trim());
				this.setPlanesByCity();
			}
		}

		private void getAirlines() {
			try {
				this.conexion.open();

				SqlCommand cmd = new SqlCommand("GetAirlineByName", this.conexion.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Name", "");

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read()) {
					string idAerolinea = reader["idAerolinea"].ToString();
					string nombre = reader["nombre"].ToString();
					this.cbAirlines.Items.Add(idAerolinea + " - " + nombre);
				}

				reader.Close();
			} catch (SqlException ex) {
				MessageBox.Show("Error: " + ex.Message, "Error al cargar aerolíneas", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				if (this.conexion.ConnectDB.State == ConnectionState.Open) {
					this.conexion.close();
				}
			}
		}

		private void top3Days() {
			chartTopDays.Series.Clear();
			chartTopDays.Titles.Clear();
			chartTopDays.ChartAreas.Clear();

			ChartArea chartArea = new ChartArea();
			chartTopDays.ChartAreas.Add(chartArea);

			Series series = new Series();
			series.ChartType = SeriesChartType.Pie;
			series.IsValueShownAsLabel = true;

			try {
				conexion.open();
				SqlCommand cmd = new SqlCommand("TopDaysWithMostPassengers", conexion.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				foreach (DataRow row in dt.Rows) {
					series.Points.AddXY(row["Fecha del Vuelo"].ToString(), Convert.ToInt32(row["Cantidad de Pasajeros"]));
				}

				chartTopDays.Series.Add(series);

				chartTopDays.Titles.Add("Top 3 Días con Más Pasajeros");

				chartTopDays.DataBind();
				
			} catch (Exception ex) {
				MessageBox.Show("Error: " + ex.Message, "Error al obtener los días con más pasajeros", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
            conexion.close();
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

        private void cloumnsFligthPerPassenger()
        {
            fligthPerPassengerGrid.Columns.Add("idColumn", "ID");
            fligthPerPassengerGrid.Columns.Add("airlineColumn", "Aerolinea");
            fligthPerPassengerGrid.Columns.Add("airplaneColumn", "Avion");
            fligthPerPassengerGrid.Columns.Add("identityColumn", "Cedula Pasajero");
            fligthPerPassengerGrid.Columns.Add("dateHourDColumn", "Fecha y Hora Partida");
            fligthPerPassengerGrid.Columns.Add("dateHourAColumn", "Fecha y Hora Llegada");
            fligthPerPassengerGrid.Columns.Add("cityDColumn", "Ciudad Partida");
            fligthPerPassengerGrid.Columns.Add("cityAColumn", "Ciudad Llegada");

            fligthPerPassengerGrid.AutoGenerateColumns = false;  // Deshabilitar la generación automática de columnas
            fligthPerPassengerGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        //Load the grid for the Fligth per passanger report
        private void loadFligthsPerPassenger()
        {
            try
            {
                conexion.open();

                SqlCommand data = new SqlCommand("Fligth_per_Passenger", conexion.ConnectDB);
                data.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(data);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Maps the columns
                fligthPerPassengerGrid.Columns["idColumn"].DataPropertyName = "idVuelo";
                fligthPerPassengerGrid.Columns["airlineColumn"].DataPropertyName = "nombre";
                fligthPerPassengerGrid.Columns["airplaneColumn"].DataPropertyName = "matricula";
                fligthPerPassengerGrid.Columns["identityColumn"].DataPropertyName = "cedulaPasajero";
                fligthPerPassengerGrid.Columns["dateHourDColumn"].DataPropertyName = "fechaHoraPartida";
                fligthPerPassengerGrid.Columns["dateHourAColumn"].DataPropertyName = "fechaHoraLlegada";
                fligthPerPassengerGrid.Columns["cityDColumn"].DataPropertyName = "codigoCiudadPartida";
                fligthPerPassengerGrid.Columns["cityAColumn"].DataPropertyName = "codigoCiudadDestino";

                // Asignes the dat ato the grid
                fligthPerPassengerGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.close();
            }
        }


        private void passengerInfo(int id, String identity)
        {
            PassangerFligthInfo infoPassanger = new PassangerFligthInfo(id, identity);
            infoPassanger.Show();
        }

        private void fligthPerPassengerGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Left)
            {
                fligthPerPassengerGrid.ClearSelection();
                DataGridViewRow row = fligthPerPassengerGrid.Rows[e.RowIndex];
                row.Selected = true;

                int idV = (int)row.Cells["idColumn"].Value;

                passengerInfo(idV, row.Cells["identityColumn"].Value.ToString());
            }
        }

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

        //Creates the columns for the cancelled fligths report
        private void cloumnsCancelledFligths()
        {
            cancelledFligthsGrid.Columns.Add("idColumn", "ID");
            cancelledFligthsGrid.Columns.Add("airlineColumn", "Aerolinea");
            cancelledFligthsGrid.Columns.Add("airplaneColumn", "Avion");
            cancelledFligthsGrid.Columns.Add("identityColumn", "Cedula Pasajero");
            cancelledFligthsGrid.Columns.Add("dateHourDColumn", "Fecha y Hora Partida");
            cancelledFligthsGrid.Columns.Add("dateHourAColumn", "Fecha y Hora Llegada");
            cancelledFligthsGrid.Columns.Add("cityDColumn", "Ciudad Partida");
            cancelledFligthsGrid.Columns.Add("cityAColumn", "Ciudad Llegada");

            cancelledFligthsGrid.AutoGenerateColumns = false;  // Deshabilitar la generación automática de columnas
            cancelledFligthsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        //Load the grid for the cancelled fligths report
        private void loadCancelledFligths()
        {
            try
            {
                conexion.open();

                SqlCommand dataCancelled = new SqlCommand("Fligth_Cancelled", conexion.ConnectDB);
                dataCancelled.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(dataCancelled);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                //Maps the columns
                cancelledFligthsGrid.Columns["idColumn"].DataPropertyName = "idVuelo";
                cancelledFligthsGrid.Columns["airlineColumn"].DataPropertyName = "nombre";
                cancelledFligthsGrid.Columns["airplaneColumn"].DataPropertyName = "matricula";
                cancelledFligthsGrid.Columns["dateHourDColumn"].DataPropertyName = "fechaHoraPartida";
                cancelledFligthsGrid.Columns["dateHourAColumn"].DataPropertyName = "fechaHoraLlegada";
                cancelledFligthsGrid.Columns["cityDColumn"].DataPropertyName = "codigoCiudadPartida";
                cancelledFligthsGrid.Columns["cityAColumn"].DataPropertyName = "codigoCiudadDestino";

                // Asignes the dat ato the grid
                cancelledFligthsGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.close();
            }
        }


        //Creates the columns for the passanger confirm report
        private void columnsPassengersConfirm()
        {
            // Crear las columnas en el DataGrid
            passengersConfirmGrid.Columns.Add("idColumn", "ID");
            passengersConfirmGrid.Columns.Add("identityColumn", "Cedula Pasajero");
            passengersConfirmGrid.Columns.Add("nameColumn", "Nombre Pasajero");
            passengersConfirmGrid.Columns.Add("sitColumn", "Asiento");

            passengersConfirmGrid.AutoGenerateColumns = false;  // Deshabilitar la generación automática de columnas
            passengersConfirmGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }



        //Load the grid for the passengers confirm report
        private void loadPassengersConfirm()
        {
            try
            {
                conexion.open();

                SqlCommand dt = new SqlCommand("Passengers_Confirm", conexion.ConnectDB);
                dt.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(dt);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Asegúrate de que las columnas están creadas
                columnsPassengersConfirm();

                // Mapear columnas explícitamente
                passengersConfirmGrid.Columns["idColumn"].DataPropertyName = "id";
                passengersConfirmGrid.Columns["identityColumn"].DataPropertyName = "cedulaPasajero";
                passengersConfirmGrid.Columns["nameColumn"].DataPropertyName = "nombrePasajero";
                passengersConfirmGrid.Columns["sitColumn"].DataPropertyName = "asiento";

                // Asignar los datos al DataGridView
                passengersConfirmGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.close();
            }
        }


        private void passengerConfirmInfo(int id, String identity)
        {
            PassangerConfimFligth infoFligth = new PassangerConfimFligth(id, identity);
            infoFligth.Show();
        }

        private void passengersConfirmGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Left)
            {
                passengersConfirmGrid.ClearSelection();
                DataGridViewRow row = passengersConfirmGrid.Rows[e.RowIndex];
                row.Selected = true;

                int idV = (int)row.Cells["idColumn"].Value;

                passengerConfirmInfo(idV, row.Cells["identityColumn"].Value.ToString());
            }
        }

        private void passengersConfirmGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (passengersConfirmGrid.SelectedCells.Count == 0)
                return;

            passengersConfirmGrid.ClearSelection();

            foreach (DataGridViewCell cell in passengersConfirmGrid.SelectedCells)
            {
                if (cell != null && cell.OwningRow != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    row.Selected = true;
                    break;
                }
            }
        }
    }
}


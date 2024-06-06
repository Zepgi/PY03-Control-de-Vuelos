using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Windows.Forms;

namespace Control_de_Vuelos {
	public partial class FlightsPanel : Form {

		private List<int> permissions;
		public List<int> actualSeats;
		int idAirline;
		public int selectedFlight;
		private string idUser;
		private DatabaseConnection conn;
		private Dictionary<string, int> passengerSeats = new Dictionary<string, int>();

		public FlightsPanel(int pIdAirline, string pIdUser, List<int> pPermissions) {
			this.conn = new DatabaseConnection();
			this.idAirline = pIdAirline;
			this.idUser = pIdUser;
			this.permissions = pPermissions;
			this.actualSeats = new List<int>();
			InitializeComponent();
			this.btBottomOption.Visible = false;
			this.lbAirline.Visible = false;
			this.cbAirlines.Visible = false;
			this.setView();
			this.setTableData("Vuelos");
		}

		private void button_Click(object sender, EventArgs e) {
			this.btRightOption.FillColor = Color.FromArgb(19, 216, 143);
			this.btLeftOption.FillColor = Color.FromArgb(19, 216, 143);
			this.lbSelectOpt.Visible = false;
			this.btLeftOption.Visible = true;
			this.btRightOption.Visible = true;
			Guna2Button b = (Guna2Button)sender;
			if (b.Text.Equals("Vuelos")) {
				this.loadPanel(new ManageFlightsPanel(idAirline));
				this.btRightOption.Text = "Agregar Vuelo";
				this.btLeftOption.Text = "Modificar Vuelo";
				this.btBottomOption.Visible = false;
				setTableData("Vuelos");

			} else {
				this.loadPanel(new ManageFlightPassengersPanel(idAirline, this));
				this.btRightOption.Text = "Agregar Pasajero";
				this.btLeftOption.Text = "Modificar Pasajero";
				this.btBottomOption.Text = "Confirmar tiquetes";
				this.btBottomOption.Visible = false;
				setTableData("Vuelos");
			}
		}

		private void setTableData(string pOption) {
			string sp;
			if (pOption.Equals("Vuelos")) {
				sp = "Get_Flights";
			} else {
				sp = "Get_Passengers";
			}

			DataTable dt = new DataTable();
			try {
				conn.open();
				SqlCommand cmd = new SqlCommand(sp, conn.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;

				if (pOption.Equals("Vuelos")) {
					cmd.Parameters.AddWithValue("@idAerolinea", this.idAirline);
				}

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				this.tbFlights.DataSource = dt;
			} catch (Exception ex) {
				MessageBox.Show("Error: " + ex.Message);
			} finally {
				if (conn.ConnectDB.State == ConnectionState.Open) {
					conn.close();
				}
			}
		}


		private void setView() {
			if (permissions.IndexOf(1) != -1) {
				this.lbAirline.Visible = true;
				this.cbAirlines.Visible = true;
			}
			if (permissions.IndexOf(3) != -1) {
				this.btRightOption.Visible = false;
				this.btLeftOption.Visible = false;
			} else {
				this.btFlights.Visible = false;
				this.btPassengers.Visible = false;
				this.loadPanel(new ManageFlightPassengersPanel(idAirline, this));
				this.btRightOption.Text = "Agregar Pasajero";
				this.btLeftOption.Text = "Modificar Pasajero";
				setTableData("Vuelos");
			}
		}

		private void btRightOption_Click(object sender, EventArgs e) {
			this.btRightOption.FillColor = Color.FromArgb(19, 216, 143);
			this.btLeftOption.FillColor = Color.FromArgb(19, 216, 143);
			if (this.btRightOption.Text.Equals("Agregar Pasajero") && !this.pInputArea.Controls[0].Name.Equals("ManagePassengersPanel")) {
				this.loadPanel(new ManagePassengersPanel(this));
				this.setTableData("Pasajeros");

			} else if (this.btRightOption.Text.Equals("Agregar Pasajero") && this.pInputArea.Controls[0].Name.Equals("ManagePassengersPanel")) {
				ManagePassengersPanel flightPassengersPanel = this.pInputArea.Controls[0] as ManagePassengersPanel;
				flightPassengersPanel.addPassenger();
			} else if (this.btRightOption.Text.Equals("Agregar Vuelo")) {
				addFlight();
			} else if (this.btRightOption.Text.Equals("Modificar") && pInputArea.Controls[0].Name.Equals("ManagePassengersPanel")) {
				modPassenger();
			} else if (this.btRightOption.Text.Equals("Modificar") && pInputArea.Controls[0].Name.Equals("ManageFlightsPanel")) {
				modFlight();
			} else {
				MessageBox.Show("No ha sido implementado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
		}
		private void btLeftOption_Click(object sender, EventArgs e) {
			if (this.btLeftOption.Text.Equals("Modificar Pasajero")) {
				this.loadPanel(new ManagePassengersPanel(this));
				this.setTableData("Pasajeros");
				this.btRightOption.Text = "Modificar";
				this.btRightOption.FillColor = Color.FromKnownColor(KnownColor.HotTrack);
				this.btLeftOption.Text = "Cancelar";
				this.btLeftOption.FillColor = System.Drawing.Color.Red;
			} else if (this.btLeftOption.Text.Equals("Modificar Vuelo")) {
				modFlightView();
			} else if (this.btLeftOption.Text.Equals("Cancelar") && pInputArea.Controls[0].Name.Equals("ManageFlightsPanel")) {
				cancelFlight();
			} else if (this.btLeftOption.Text.Equals("Cancelar") && pInputArea.Controls[0].Name.Equals("ManagePassengersPanel")) {
				this.loadPanel(new ManageFlightPassengersPanel(this.idAirline, this));
				setTableData("Vuelos");
				this.btRightOption.Text = "Agregar Pasajero";
				this.btLeftOption.Text = "Modificar Pasajero";
				this.btRightOption.FillColor = Color.FromArgb(19, 216, 143);
				this.btLeftOption.FillColor = Color.FromArgb(19, 216, 143);
			} else {
				MessageBox.Show("No ha sido implementado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
		}

		private void btBottomOption_Click(object sender, EventArgs e) {
			if (this.btBottomOption.Text.Equals("Agregar Pasajero")) {
				try {
					ManagePassengersPanel flightPassengersPanel = this.pInputArea.Controls[0] as ManagePassengersPanel;
					if (flightPassengersPanel.addPassenger()) {
						string idPassenger = flightPassengersPanel.txtIdPassenger.Text;
						int seat = actualSeats[0];
						int flight = this.selectedFlight;

						passengerSeats.Add(idPassenger, seat);

						actualSeats = actualSeats.Skip(1).ToList();


						if (actualSeats.Count <= 0) {
							conn.open();
							foreach (var passenger in passengerSeats) {
								using (SqlCommand cmd = new SqlCommand("Add_Passenger_To_List", conn.ConnectDB)) {
									cmd.CommandType = CommandType.StoredProcedure;
									cmd.Parameters.AddWithValue("@cedulaPasajero", passenger.Key);
									cmd.Parameters.AddWithValue("@idVuelo", flight);
									cmd.Parameters.AddWithValue("@asiento", passenger.Value);
									cmd.ExecuteNonQuery();
								}
							}
							setView();
							MessageBox.Show("Tiquetes registrados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				} catch (Exception ex) {
					MessageBox.Show("Error: " + ex.Message, "Error al agregar pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}



		public void addPassengers(List<int> pSeats) {
			this.btLeftOption.Visible = false;
			this.btRightOption.Visible = false;
			this.btBottomOption.Text = "Agregar Pasajero";
			this.btBottomOption.Visible = true;
			actualSeats = pSeats;
			this.loadPanel(new ManagePassengersPanel(this));
		}

		private void modFlightView() {
			this.btRightOption.Text = "Modificar";
			this.btRightOption.FillColor = Color.FromKnownColor(KnownColor.HotTrack);
			this.btLeftOption.Text = "Cancelar";
			this.btLeftOption.FillColor = System.Drawing.Color.Red;
		}

		private void modPassenger() {
			ManagePassengersPanel inputPanel = this.pInputArea.Controls[0] as ManagePassengersPanel;
			if (inputPanel == null) {
				return;
			}
			if (string.IsNullOrEmpty(inputPanel.txtIdPassenger.Text) &&
							string.IsNullOrEmpty(inputPanel.txtPassengerName.Text) &&
							string.IsNullOrEmpty(inputPanel.txtCountry.Text) &&
							string.IsNullOrEmpty(inputPanel.txtCanton.Text) &&
							string.IsNullOrEmpty(inputPanel.txtDistrict.Text) &&
							string.IsNullOrEmpty(inputPanel.txtCity.Text)) {
				MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (!inputPanel.isValidText(inputPanel.txtPassengerName.Text)) {
				MessageBox.Show("El nombre del pasajero no puede contener números.", "Nombre incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!inputPanel.isValidText(inputPanel.txtCountry.Text)) {
				MessageBox.Show("El país no puede contener números.", "Nombre incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			try {
				this.conn.open();
				SqlCommand cmd = new SqlCommand("Update_Passenger", this.conn.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@cedulaPasajero", Convert.ToInt32(inputPanel.txtIdPassenger.Text));
				cmd.Parameters.AddWithValue("@nombre", inputPanel.txtPassengerName.Text.Split(' ')[0]);
				cmd.Parameters.AddWithValue("@apellidoPat", inputPanel.txtPassengerName.Text.Split(' ')[1]);
				cmd.Parameters.AddWithValue("@apellidoMat", inputPanel.txtPassengerName.Text.Split(' ')[2]);
				cmd.Parameters.AddWithValue("@pais", inputPanel.txtCountry.Text);
				cmd.Parameters.AddWithValue("@canton", inputPanel.txtCanton.Text);
				cmd.Parameters.AddWithValue("@distrito", inputPanel.txtDistrict.Text);
				cmd.Parameters.AddWithValue("@ciudad", inputPanel.txtCity.Text);

				cmd.ExecuteNonQuery();
				MessageBox.Show("El pasajero ha sido actualizado exitosamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.setTableData("Vuelos");
				setView();
			} catch (SqlException ex) {
				if (ex.Number == 50000) {
					MessageBox.Show("Debe modificar al menos un dato.", "Error en la actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					MessageBox.Show("Error: " + ex.Message, "Error al actualizar pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} finally {
				if (this.conn.ConnectDB.State == ConnectionState.Open) {
					this.conn.close();
				}
			}
		}

		private void modFlight() {
			ManageFlightsPanel flightPanel = this.pInputArea.Controls[0] as ManageFlightsPanel;
			if (flightPanel == null) {
				return;
			}
			if (flightPanel.cbArrivalHours.SelectedIndex == -1 &&
				flightPanel.cbDepartureHours.SelectedIndex == -1 &&
				flightPanel.cbArrivalCities.SelectedIndex == -1 &&
				flightPanel.cbDepartureCities.SelectedIndex == -1 &&
				flightPanel.cbPlanes.SelectedIndex == -1 &&
				flightPanel.cbPilots.SelectedIndex == -1) {
				MessageBox.Show("Por favor, seleccione al menos un campo.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			DateTime arrivalDateTime = flightPanel.dtArrivalDate.Value.Date.Add(DateTime.Parse(flightPanel.cbArrivalHours.SelectedItem.ToString()).TimeOfDay);
			DateTime departureDateTime = flightPanel.dtDepartureDate.Value.Date.Add(DateTime.Parse(flightPanel.cbDepartureHours.SelectedItem.ToString()).TimeOfDay);

			DateTime now = DateTime.Now;
			if (departureDateTime <= now) {
				MessageBox.Show("La fecha y hora de partida debe ser posterior a la fecha y hora actuales.", "Error en las fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (arrivalDateTime <= departureDateTime) {
				MessageBox.Show("La fecha y hora de llegada debe ser posterior a la fecha y hora de partida.", "Error en las fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (flightPanel.cbDepartureCities.SelectedItem.ToString() == flightPanel.cbArrivalCities.SelectedItem.ToString()) {
				MessageBox.Show("La ciudad de partida no puede ser la misma que la ciudad de llegada.", "Error en las ciudades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try {
				this.conn.open();

				SqlCommand checkCmd = new SqlCommand("Search_Between_Dates", conn.ConnectDB);
				checkCmd.CommandType = CommandType.StoredProcedure;
				checkCmd.Parameters.AddWithValue("@fechaHoraPartida", departureDateTime);
				checkCmd.Parameters.AddWithValue("@fechaHoraLlegada", arrivalDateTime);

				SqlDataReader reader = checkCmd.ExecuteReader();
				while (reader.Read()) {
					string cedulaPiloto = reader["cedulaPiloto"].ToString();
					string matricula = reader["matricula"].ToString();
					int     flight  = (int) reader["idVuelo"];

					if ((cedulaPiloto.Equals(flightPanel.cbPilots.SelectedItem.ToString()) ||
						matricula == flightPanel.cbPlanes.SelectedItem.ToString()) && flight != this.selectedFlight) {
						MessageBox.Show("Conflicto de horario: el piloto o el avión ya están asignados a otro vuelo en este horario.", "Error de programación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						conn.close();
						return;
					}
				}
				reader.Close();

				SqlCommand cmd = new SqlCommand("Update_Flight", conn.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@idVuelo", this.selectedFlight);
				cmd.Parameters.AddWithValue("@idAerolinea", this.idAirline);
				cmd.Parameters.AddWithValue("@matricula", flightPanel.cbPlanes.SelectedItem.ToString());
				cmd.Parameters.AddWithValue("@cedulaPiloto", flightPanel.cbPilots.SelectedItem.ToString());
				cmd.Parameters.AddWithValue("@fechaHoraPartida", departureDateTime);
				cmd.Parameters.AddWithValue("@fechaHoraLlegada", arrivalDateTime);
				cmd.Parameters.AddWithValue("@codigoCiudadDestino", flightPanel.cbDepartureCities.SelectedItem.ToString().Split('|')[0].Trim());
				cmd.Parameters.AddWithValue("@codigoCiudadPartida", flightPanel.cbArrivalCities.SelectedItem.ToString().Split('|')[0].Trim());

				cmd.ExecuteNonQuery();
				MessageBox.Show("El vuelo ha sido actualizado exitosamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.setTableData("Vuelos");
				loadPanel(new ManageFlightPassengersPanel(this.idAirline, this));
				this.btRightOption.Text = "Agregar Pasajero";
				this.btLeftOption.Text = "Modificar Pasajero";
				this.btRightOption.FillColor = Color.FromArgb(19, 216, 143);
				this.btLeftOption.FillColor = Color.FromArgb(19, 216, 143);
			} catch (SqlException ex) {
				if (ex.Number == 50000) {
					MessageBox.Show("Debe modificar al menos un dato", "Error en la actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					MessageBox.Show("Error: " + ex.Message, "Error al cancelar vuelo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} finally {
				if (conn.ConnectDB.State == ConnectionState.Open) {
					conn.close();
				}
			}
		}

		private void cancelFlight() {
			if (tbFlights.SelectedRows.Count == 0) {
				MessageBox.Show("Por favor, seleccione un vuelo para cancelar.", "Selección vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			DataGridViewRow selectedRow = tbFlights.SelectedRows[0];
			int selectedFlight = (int)selectedRow.Cells["Vuelo"].Value;

			DialogResult result = MessageBox.Show("¿Está seguro de que desea cancelar este vuelo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes) {
				try {
					this.conn.open();
					SqlCommand cmd = new SqlCommand("Cancel_Flight", this.conn.ConnectDB);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@idVuelo", selectedFlight);
					cmd.ExecuteNonQuery();
					this.setTableData("Vuelos");
					MessageBox.Show("Vuelo cancelado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} catch (SqlException ex) {
					if (ex.Number == 50000) { // Número de error para RAISERROR
						MessageBox.Show(ex.Message, "Error al cancelar vuelo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					} else {
						MessageBox.Show("Error: " + ex.Message, "Error al cancelar vuelo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				} finally {
					if (this.conn.ConnectDB.State == ConnectionState.Open) {
						this.conn.close();
					}
				}
			}
		}

		private void addFlight() {
			ManageFlightsPanel flightPanel = this.pInputArea.Controls[0] as ManageFlightsPanel;
			if (flightPanel == null) {
				return;
			}
			if (flightPanel.cbArrivalHours.SelectedIndex == -1 ||
				flightPanel.cbDepartureHours.SelectedIndex == -1 ||
				flightPanel.cbArrivalCities.SelectedIndex == -1 ||
				flightPanel.cbDepartureCities.SelectedIndex == -1 ||
				flightPanel.cbPlanes.SelectedIndex == -1 ||
				flightPanel.cbPilots.SelectedIndex == -1) {
				MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			DateTime departureDateTime = flightPanel.dtArrivalDate.Value.Date.Add(DateTime.Parse(flightPanel.cbDepartureHours.SelectedItem.ToString()).TimeOfDay);
			DateTime arrivalDateTime = flightPanel.dtDepartureDate.Value.Date.Add(DateTime.Parse(flightPanel.cbArrivalHours.SelectedItem.ToString()).TimeOfDay);

			DateTime now = DateTime.Now;
			if (departureDateTime <= now) {
				MessageBox.Show("La fecha y hora de partida debe ser posterior a la fecha y hora actuales.", "Error en las fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (arrivalDateTime <= departureDateTime) {
				MessageBox.Show("La fecha y hora de llegada debe ser posterior a la fecha y hora de partida.", "Error en las fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (flightPanel.cbDepartureCities.SelectedItem.ToString() == flightPanel.cbArrivalCities.SelectedItem.ToString()) {
				MessageBox.Show("La ciudad de partida no puede ser la misma que la ciudad de llegada.", "Error en las ciudades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try {
				this.conn.open();

				SqlCommand checkCmd = new SqlCommand("Search_Between_Dates", this.conn.ConnectDB);
				checkCmd.CommandType = CommandType.StoredProcedure;
				checkCmd.Parameters.AddWithValue("@fechaHoraPartida", departureDateTime);
				checkCmd.Parameters.AddWithValue("@fechaHoraLlegada", arrivalDateTime);

				SqlDataReader reader = checkCmd.ExecuteReader();
				while (reader.Read()) {
					string cedulaPiloto = (string)reader["cedulaPiloto"];
					string matricula = reader["matricula"].ToString();

					if (cedulaPiloto == flightPanel.cbPilots.SelectedItem.ToString() ||
						matricula == flightPanel.cbPlanes.SelectedItem.ToString()) {
						MessageBox.Show("Conflicto de horario: el piloto o el avión ya están asignados a otro vuelo en este horario.", "Error de programación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						conn.close();
						return;
					}
				}
				reader.Close();

				SqlCommand cmd = new SqlCommand("Add_Flight", this.conn.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@idAerolinea", this.idAirline);
				cmd.Parameters.AddWithValue("@matricula", flightPanel.cbPlanes.SelectedItem.ToString());
				cmd.Parameters.AddWithValue("@cedulaPiloto", flightPanel.cbPilots.SelectedItem.ToString());
				cmd.Parameters.AddWithValue("@fechaHoraPartida", departureDateTime);
				cmd.Parameters.AddWithValue("@fechaHoraLlegada", arrivalDateTime);
				cmd.Parameters.AddWithValue("@codigoCiudadPartida", flightPanel.cbDepartureCities.SelectedItem.ToString().Split('|')[0].Trim());
				cmd.Parameters.AddWithValue("@codigoCiudadDestino", flightPanel.cbArrivalCities.SelectedItem.ToString().Split('|')[0].Trim());

				cmd.ExecuteNonQuery();
				this.setTableData("Vuelos");
				loadPanel(new ManageFlightPassengersPanel(this.idAirline, this));
				this.btRightOption.Text = "Agregar Pasajero";
				this.btLeftOption.Text = "Modificar Pasajero";
				this.btRightOption.FillColor = Color.FromArgb(19, 216, 143);
				this.btLeftOption.FillColor = Color.FromArgb(19, 216, 143);
				MessageBox.Show("Vuelo agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch (SqlException ex) {
				MessageBox.Show("Error: " + ex.Message, "Error al agregar vuelo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				if (this.conn.ConnectDB.State == ConnectionState.Open) {
					this.conn.close();
				}
			}
		}

		public void loadPanel(object panel) {

			if (this.pInputArea.Controls.Count > 0) {
				this.pInputArea.Controls.RemoveAt(0);
			}
			Form f = panel as Form;
			f.TopLevel = false;
			f.Dock = DockStyle.Fill;
			this.pInputArea.Controls.Add(f);
			this.pInputArea.Tag = f;
			f.Show();
		}

		private void tbFlights_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			if (e.RowIndex == -1) {
				return;
			}
			if (this.pInputArea.Controls.Count == 0) {
				return;
			}
			ManageFlightsPanel flightPanel = this.pInputArea.Controls[0] as ManageFlightsPanel;
			if (btRightOption.Text.Equals("Modificar") && pInputArea.Controls[0].Name.Equals("ManageFlightsPanel")) {
				DataGridViewRow selectedRow = this.tbFlights.Rows[e.RowIndex];
				if (selectedRow != null) {
					this.selectedFlight = (int) selectedRow.Cells["Vuelo"].Value;
					string departureCity = selectedRow.Cells["Ciudad de Partida"].Value.ToString();
					string arrivalCity = selectedRow.Cells["Ciudad de Destino"].Value.ToString();
					DateTime departureDate = (DateTime)selectedRow.Cells["Salida"].Value;
					DateTime arrivalDate = (DateTime)selectedRow.Cells["Llegada"].Value;
					string planePlate = (string) selectedRow.Cells["Avión"].Value;
					string pilotID = (string) selectedRow.Cells["Piloto"].Value;

					string departureHour = departureDate.ToString("h:mm tt");
					string arrivalHour = arrivalDate.ToString("h:mm tt");

					flightPanel.cbDepartureCities.SelectedItem = departureCity;
					flightPanel.cbArrivalCities.SelectedItem = arrivalCity;
					flightPanel.dtDepartureDate.Value = departureDate;
					flightPanel.dtArrivalDate.Value = arrivalDate;
					flightPanel.cbPlanes.SelectedItem = planePlate;
					flightPanel.cbDepartureHours.SelectedItem = departureHour;
					flightPanel.cbArrivalHours.SelectedItem = arrivalHour;
					flightPanel.cbPilots.SelectedItem = pilotID;
				}
			}

			if (pInputArea.Controls[0].Name.Equals("ManageFlightPassengersPanel")) {
				ManageFlightPassengersPanel inputPanel = pInputArea.Controls[0] as ManageFlightPassengersPanel;
				DataGridViewRow selectedRow = this.tbFlights.Rows[e.RowIndex];
				if (selectedRow != null) {
					this.selectedFlight = (int) selectedRow.Cells["Vuelo"].Value;
					bool estado = (bool) selectedRow.Cells["Estado"].Value;
					if (!estado) {
						return;
					}
					inputPanel.cbFlights.SelectedItem = this.selectedFlight.ToString();
				}
			}
			if (pInputArea.Controls[0].Name.Equals("ManagePassengersPanel")) {
				ManagePassengersPanel inputPanel = pInputArea.Controls[0] as ManagePassengersPanel;
				DataGridViewRow selectedRow = this.tbFlights.Rows[e.RowIndex];
				if (selectedRow != null) {
					if (this.btRightOption.Text.Equals("Agregar Pasajero")) {
						return;
					}
					string passengerId = (string) selectedRow.Cells["Cédula"].Value;
					try {

						this.conn.open();

						using (SqlCommand cmdSearchPassenger = new SqlCommand("Search_Passenger", this.conn.ConnectDB)) {
							cmdSearchPassenger.CommandType = CommandType.StoredProcedure;
							cmdSearchPassenger.Parameters.AddWithValue("@cedulaPasajero", passengerId);

							using (SqlDataReader reader = cmdSearchPassenger.ExecuteReader()) {
								if (reader.Read()) {
									inputPanel.txtIdPassenger.Text = reader["cedulaPasajero"].ToString();
									inputPanel.txtPassengerName.Text = reader["nombreCompleto"].ToString();
									inputPanel.txtCountry.Text = reader["pais"].ToString();
									inputPanel.txtCanton.Text = reader["canton"].ToString();
									inputPanel.txtDistrict.Text = reader["distrito"].ToString();
									inputPanel.txtCity.Text = reader["ciudad"].ToString();
								} else {
									inputPanel.txtPassengerName.Text = string.Empty;
									inputPanel.txtCountry.Text = string.Empty;
									inputPanel.txtCanton.Text = string.Empty;
									inputPanel.txtDistrict.Text = string.Empty;
									inputPanel.txtCity.Text = string.Empty;
								}
							}
						}

					} catch (Exception ex) {
						MessageBox.Show("Error: " + ex.Message, "Error al buscar pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
					} finally {
						if (this.conn.ConnectDB.State == ConnectionState.Open) {
							this.conn.close();
						}
					}
				}
			}
		}

	}
}

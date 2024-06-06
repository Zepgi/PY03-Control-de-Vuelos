using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Vuelos {
	public partial class FlightsPanel : Form {

		List<int> permissions;
		List<int> actualSeats;
		int idAirline;
		public int selectedFlight;
		string idUser;
		DatabaseConnection conn;
		private Dictionary<string, int> passengerSeats = new Dictionary<string, int>();

		public FlightsPanel(int pIdAirline, string pIdUser, List<int> pPermissions) {
			this.conn = new DatabaseConnection();
			this.idAirline = pIdAirline;
			this.idUser = pIdUser;
			this.permissions = pPermissions;
			InitializeComponent();
			this.btBottomOption.Visible = false;
			this.setView();
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
				this.btBottomOption.Visible = true;
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
			if (this.btRightOption.Text.Equals("Agregar Pasajero")) {
				this.loadPanel(new ManagePassengersPanel());
				this.setTableData("Pasajeros");
			} else if (this.btRightOption.Text.Equals("Agregar Vuelo")) {
				addFlight();
			} else if (this.btRightOption.Text.Equals("Modificar")) {
				modFlight();
			} else {
				MessageBox.Show("No ha sido implementado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
		}
		private void btLeftOption_Click(object sender, EventArgs e) {
			if (this.btLeftOption.Text.Equals("Modificar Pasajero")) {
				this.setTableData("Pasajeros");
			} else if (this.btLeftOption.Text.Equals("Modificar Vuelo")) {
				modFlightView();
			} else if (this.btLeftOption.Text.Equals("Cancelar")) {
				cancelFlight();
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

						// Agregar pasajero y asiento al diccionario
						passengerSeats.Add(idPassenger, seat);

						// Eliminar el primer asiento de la lista
						actualSeats = actualSeats.Skip(1).ToList();

						MessageBox.Show("Pasajero agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

						if (actualSeats.Count <= 0) {
							// Todos los pasajeros han sido agregados, insertar en la base de datos
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
						}
						passengerSeats.Clear(); // Limpiar el diccionario después de la inserción
						setView();
						MessageBox.Show("Todos los pasajeros han sido agregados.", "Proceso completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			this.loadPanel(new ManagePassengersPanel());
		}

		private void modFlightView() {
			this.btRightOption.Text = "Modificar";
			this.btRightOption.FillColor = Color.FromKnownColor(KnownColor.HotTrack);
			this.btLeftOption.Text = "Cancelar";
			this.btLeftOption.FillColor = System.Drawing.Color.Red;
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

			// verificar que no haya un vuelo con el mismo piloto en el  momento que se hace

			try {
				this.conn.open();
				SqlCommand cmd = new SqlCommand("Update_Flight", conn.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@idVuelo", this.selectedFlight);
				cmd.Parameters.AddWithValue("@idAerolinea", this.idAirline);
				cmd.Parameters.AddWithValue("@matricula", flightPanel.cbPlanes.SelectedItem.ToString());
				cmd.Parameters.AddWithValue("@cedulaPiloto", Int32.Parse(flightPanel.cbPilots.SelectedItem.ToString()));
				cmd.Parameters.AddWithValue("@fechaHoraPartida", departureDateTime);
				cmd.Parameters.AddWithValue("@fechaHoraLlegada", arrivalDateTime);
				cmd.Parameters.AddWithValue("@codigoCiudadPartida", flightPanel.cbDepartureCities.SelectedItem.ToString().Split('|')[0].Trim());
				cmd.Parameters.AddWithValue("@codigoCiudadDestino", flightPanel.cbArrivalCities.SelectedItem.ToString().Split('|')[0].Trim());

				cmd.ExecuteNonQuery();
				MessageBox.Show("El vuelo ha sido actualizado exitosamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.setTableData("Vuelos");
				flightPanel.clear();
				setView();
			} catch (SqlException ex) {
				if (ex.Number == 50000) {
					MessageBox.Show("Debe modificar al menos un dato", "Error en la actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);

				} else {
					MessageBox.Show("Error: " + ex.Message, "Error al cancelar vuelo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

			if (arrivalDateTime >= departureDateTime) {
				MessageBox.Show("La fecha y hora de llegada debe ser posterior a la fecha y hora de partida.", "Error en las fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (flightPanel.cbDepartureCities.SelectedItem.ToString() == flightPanel.cbArrivalCities.SelectedItem.ToString()) {
				MessageBox.Show("La ciudad de partida no puede ser la misma que la ciudad de llegada.", "Error en las ciudades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// verificar que no haya un vuelo con el mismo piloto en el  momento que se hace

			try {
				this.conn.open();
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
				flightPanel.clear();
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
			ManageFlightsPanel flightPanel = this.pInputArea.Controls[0] as ManageFlightsPanel;
			if (flightPanel == null) {
				return;
			}
			if (btRightOption.Text.Equals("Modificar")) {
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
		}

	}
}

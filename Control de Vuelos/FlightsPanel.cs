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
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Vuelos {
	public partial class FlightsPanel : Form {

		List<int> permissions;
		int idAirline;
		string idUser;
		DatabaseConnection conn;
		public FlightsPanel(int pIdAirline, string pIdUser, List<int> pPermissions) {
			this.conn = new DatabaseConnection();
			this.idAirline = pIdAirline;
			this.idUser = pIdUser;
			this.permissions = pPermissions;
			InitializeComponent();
			this.btConfirmPassengers.Visible = false;
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
				setTableData("Vuelos");

			} else {
				this.loadPanel(new ManageFlightPassengersPanel());
				this.btRightOption.Text = "Agregar Pasajero";
				this.btLeftOption.Text = "Modificar Pasajero";
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
				this.loadPanel(new ManageFlightPassengersPanel());
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
			}
		}
		private void btLeftOption_Click(object sender, EventArgs e) {
			if (this.btLeftOption.Text.Equals("Modificar Pasajero")) {
				this.setTableData("Pasajeros");
			} else if (this.btLeftOption.Text.Equals("Modificar Vuelo")) {
				modFlight();
			}
		}

		private void modFlight() {
			this.btRightOption.Text = "Modificar";
			this.btRightOption.FillColor = Color.FromKnownColor(KnownColor.HotTrack);
			this.btLeftOption.Text = "Eliminar";
			this.btLeftOption.FillColor = System.Drawing.Color.Red;
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
				SqlCommand cmd = new SqlCommand("Insertar_Vuelo", this.conn.ConnectDB);
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
			} catch (Exception ex) {
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
	}
}

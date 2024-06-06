using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Control_de_Vuelos {
	public partial class ManageFlightsPanel : Form {

		private readonly DatabaseConnection conn;
		private int idAerolinea;
		public ManageFlightsPanel(int pIdAerolinea) {
			this.idAerolinea = pIdAerolinea;
			this.conn = new DatabaseConnection();
			InitializeComponent();
			setCities();
			setHours();
			setPilots();
			setPlanes();
		}

		private void setCities() {
			this.cbArrivalCities.Items.Clear();
			this.cbDepartureCities.Items.Clear();
			try {
				this.conn.open();
				SqlCommand cmd = new SqlCommand("Get_Cities", this.conn.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read()) {
					string city = reader["codigoCiudad"].ToString() + " | " + reader["ciudad"].ToString();
					this.cbArrivalCities.Items.Add(city);
					this.cbDepartureCities.Items.Add(city);
				}
			} catch (Exception ex) {
				MessageBox.Show("Error: " + ex.Message);
			} finally {
				if (this.conn.ConnectDB.State == ConnectionState.Open) {
					conn.close();
				}
			}
		}

		private void setHours() {
			this.cbArrivalHours.Items.Clear();
			this.cbDepartureHours.Items.Clear();
			for (int hour = 0; hour < 24; hour++) {
				string time = new DateTime(1, 1, 1, hour, 0, 0).ToString("h:mm tt");
				this.cbArrivalHours.Items.Add(time);
				this.cbDepartureHours.Items.Add(time);
			}
		}

		private void setPlanes() {
			this.cbPlanes.Items.Clear();
			try {
				this.conn.open();
				SqlCommand cmd = new SqlCommand("Get_Planes", this.conn.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@idAerolinea", idAerolinea);

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read()) {
					string plane = reader["matricula"].ToString();
					this.cbPlanes.Items.Add(plane);
				}
			} catch (Exception ex) {
				MessageBox.Show("Error: " + ex.Message);
			} finally {
				if (this.conn.ConnectDB.State == ConnectionState.Open) {
					conn.close();
				}
			}
		}

		private void setPilots() {
			this.cbPilots.Items.Clear();
			try {
				this.conn.open();
				SqlCommand cmd = new SqlCommand("Get_Pilots", this.conn.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@idAerolinea", idAerolinea);

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read()) {
					string pilot = reader["cedulaPiloto"].ToString();
					this.cbPilots.Items.Add(pilot);
				}
			} catch (Exception ex) {
				MessageBox.Show("Error: " + ex.Message);
			} finally {
				if (this.conn.ConnectDB.State == ConnectionState.Open) {
					conn.close();
				}
			}
		}

		public void clear() {
			this.dtDepartureDate.ResetText();
			this.dtArrivalDate.ResetText();
			this.cbDepartureHours.SelectedIndex = -1;
			this.cbArrivalHours.SelectedIndex = -1;
			this.cbDepartureCities.SelectedIndex = -1;
			this.cbArrivalCities.SelectedIndex = -1;
			this.cbPlanes.SelectedIndex = -1;
			this.cbPilots.SelectedIndex = -1;
		}

		private void comboBox_KeyDown(object sender, KeyEventArgs e) {
			Guna2ComboBox comboBox = sender as Guna2ComboBox;
			if (comboBox != null && (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)) {
				comboBox.SelectedIndex = -1;
			}
		}

		private void hideFlightPanel() {
			this.lbArrivalDate.Visible = false;
			this.dtDepartureDate.Visible = false;
			this.lbDepartureHour.Visible = false;
			this.cbDepartureHours.Visible = false;
			this.lbArrivalHour.Visible = false;
			this.cbArrivalHours.Visible = false;
			this.lbDepartureCity.Visible = false;
			this.cbDepartureCities.Visible = false;
			this.lbArrivalCity.Visible = false;
			this.cbArrivalCities.Visible = false;
			this.lbPlane.Visible = false;
			this.cbPlanes.Visible = false;
			this.lbPilot.Visible = false;
			this.cbPilots.Visible = false;
		}

		private void showFlightPanel() {
			this.lbArrivalDate.Visible = true;
			this.dtDepartureDate.Visible = true;
			this.lbDepartureHour.Visible = true;
			this.cbDepartureHours.Visible = true;
			this.lbArrivalHour.Visible = true;
			this.cbArrivalHours.Visible = true;
			this.lbDepartureCity.Visible = true;
			this.cbDepartureCities.Visible = true;
			this.lbArrivalCity.Visible = true;
			this.cbArrivalCities.Visible = true;
			this.lbPlane.Visible = true;
			this.cbPlanes.Visible = true;
			this.lbPilot.Visible = true;
			this.cbPilots.Visible = true;
		}
	}
}

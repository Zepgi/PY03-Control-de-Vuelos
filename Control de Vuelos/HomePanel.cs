using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Control_de_Vuelos {
	public partial class HomePanel : Form {

		private DatabaseConnection conn;
		private int idAirline;
		private string idUsuario;
		private List<int> permissions;
		private Timer timer;

		public HomePanel(int pIdAerolinea, string pIdUsuario, List<int> pPermissions) {
			this.permissions = pPermissions;
			this.conn = new DatabaseConnection();
			this.idAirline = pIdAerolinea;
			this.idUsuario = pIdUsuario;
			InitializeComponent();
			setUserName();
			
			this.lbDate.Text = DateTime.Now.ToString("d 'de' MMMM 'de' yyyy");
			initializeTimer();
			if (permissions.IndexOf(1) == -1) {
				this.lbFlights.Visible = false;
				this.cbAirlines.Visible = false;
				setTableData();
			} else {
				getAirlines();
			}
		}

		private void getAirlines() {
			try {
				this.conn.open();

				SqlCommand cmd = new SqlCommand("GetAirlineByName", this.conn.ConnectDB);
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
				if (this.conn.ConnectDB.State == ConnectionState.Open) {
					this.conn.close();
				}
			}
		}

		private void setTableData() {

			DataTable dt = new DataTable();
			try {
				conn.open();
				SqlCommand cmd = new SqlCommand("Get_Flights", conn.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@idAerolinea", this.idAirline);


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

		private void cbAirlines_IndexChanged(object sender, EventArgs e) {
			if (this.cbAirlines.SelectedIndex != -1) {
				this.idAirline = Convert.ToInt32(this.cbAirlines.SelectedItem.ToString().Split('-')[0].Trim());
				this.setTableData();
			}
		}

		private void initializeTimer() {
			timer = new Timer();
			timer.Tick += timer_Tick;

			DateTime now = DateTime.Now;
			int secondsUntilNextMinute = 60 - now.Second;
			int initialInterval = secondsUntilNextMinute * 1000; 

			timer.Interval = initialInterval;
			timer.Start();

			updateTimeLabel();
		}

		private void timer_Tick(object sender, EventArgs e) {
			updateTimeLabel();
			timer.Interval = 60000;
		}

		private void updateTimeLabel() {
			this.lbHour.Text = DateTime.Now.ToString("h:mm tt", CultureInfo.InvariantCulture);
		}

		private void setUserName() {
			try {
				this.conn.open();
				SqlCommand cmd = new SqlCommand("Buscar_Usuario", this.conn.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read()) {
					string nombreCompleto = reader["nombreCompleto"].ToString();
					this.lbWelcome.Text = "¡Bienvenido, " + nombreCompleto + "!";
				} else {
					this.lbWelcome.Text = "User not found.";
				}
			} catch (Exception ex) {
				MessageBox.Show("Error: " + ex.Message);
			} finally {
				if (this.conn.ConnectDB.State == ConnectionState.Open) {
					conn.close();
				}
			}
		}
	}
}

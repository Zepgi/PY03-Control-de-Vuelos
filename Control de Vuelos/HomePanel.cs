using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Vuelos {
	public partial class HomePanel : Form {

		private DatabaseConnection conn;
		private int idAerolinea;
		private string idUsuario;
		private Timer timer;

		public HomePanel(int pIdAerolinea, string pIdUsuario) {
			this.conn = new DatabaseConnection();
			this.idAerolinea = pIdAerolinea;
			this.idUsuario = pIdUsuario;
			InitializeComponent();
			setUserName();
			
			this.lbDate.Text = DateTime.Now.ToString("d 'de' MMMM 'de' yyyy");
			initializeTimer();
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

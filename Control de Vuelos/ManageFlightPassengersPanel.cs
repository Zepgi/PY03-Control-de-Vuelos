using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace Control_de_Vuelos {
	public partial class ManageFlightPassengersPanel : Form {

		private readonly DatabaseConnection conn;
		private int airlineId;
		private FlightsPanel super;
		private bool canConfirm;
		public ManageFlightPassengersPanel(int pAirlineId, FlightsPanel pSuper) {
			this.conn = new DatabaseConnection();
			InitializeComponent();
			this.airlineId = pAirlineId;
			this.super = pSuper;
			this.canConfirm = false;
			setFlights();
		}

		private List<int> getOccupiedSeats() {
			List<int> occupiedSeatsList = new List<int>();

			try {
				this.conn.open();
				SqlCommand cmd = new SqlCommand("Get_Occupied_Seats", this.conn.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@idVuelo", Int32.Parse(cbFlights.SelectedItem.ToString()));

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read()) {
					occupiedSeatsList.Add(reader.GetInt32(0));
				}
				reader.Close();
			} catch (SqlException ex) {
				MessageBox.Show("Error: " + ex.Message, "Error al obtener los asientos ocupados", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				if (this.conn.ConnectDB.State == ConnectionState.Open) {
					this.conn.close();
				}
			}

			return occupiedSeatsList;
		}


		private void buttonGrid(int pY) {
			int x = 4;
			int y = pY / 4;

			int number = 1;
			int yPos = 60;
			int xPos = 40;

			List<int> occupiedSeats = getOccupiedSeats();

			foreach (Control control in Controls.OfType<CheckBox>().ToList()) {
				Controls.Remove(control);
				control.Dispose();
			}

			for (int i = 1; i <= y; i++) {
				int xPosition = xPos;
				for (int j = 1; j <= x; j++) {
					CheckBox checkBox = new CheckBox();
					checkBox.Text = number.ToString();
					checkBox.Size = new Size(38, 30);
					checkBox.FlatStyle = FlatStyle.Flat; 
					checkBox.Appearance = Appearance.Button;
					checkBox.BackColor = Color.White;
					checkBox.FlatAppearance.BorderSize = 2;
					checkBox.FlatAppearance.BorderColor = Color.LightGray;
					checkBox.Font = new Font("Century Gothic", 8.2f, FontStyle.Regular);
					if (occupiedSeats.IndexOf(number) != -1) {
						this.canConfirm = true;
						checkBox.Checked = true;
						checkBox.BackColor = Color.Red;
						checkBox.Enabled = false;
					}
					checkBox.Click += checkBox_Click;
					if (j == 3) {
						xPosition += 15;
					}
					checkBox.Location = new Point(xPosition + 39 * (j-1), yPos);

					Controls.Add(checkBox);
					number++;
				}
				yPos += 31;
			}
			this.planeimg.SendToBack();
		}

		private void buttonGridConfirm(int pY) {
			int x = 4;
			int y = pY / 4;

			int number = 1;
			int yPos = 60;
			int xPos = 40;

			List<int> occupiedSeats = getOccupiedSeats();

			foreach (Control control in Controls.OfType<CheckBox>().ToList()) {
				Controls.Remove(control);
				control.Dispose();
			}

			for (int i = 1; i <= y; i++) {
				int xPosition = xPos;
				for (int j = 1; j <= x; j++) {
					CheckBox checkBox = new CheckBox();
					checkBox.Text = number.ToString();
					checkBox.Size = new Size(38, 30);
					checkBox.FlatStyle = FlatStyle.Flat;
					checkBox.Appearance = Appearance.Button;
					checkBox.BackColor = Color.White;
					checkBox.FlatAppearance.BorderSize = 2;
					checkBox.FlatAppearance.BorderColor = Color.LightGray;
					checkBox.Font = new Font("Century Gothic", 8.2f, FontStyle.Regular);
					checkBox.BackColor = Color.Gray;
					checkBox.Enabled = false;
					if (occupiedSeats.IndexOf(number) != -1) {
						checkBox.Checked = false;
						checkBox.Enabled = true;
						checkBox.BackColor = Color.Gold;
					}
					checkBox.Click += checkBoxConfirm_Click;
					if (j == 3) {
						xPosition += 15;
					}
					checkBox.Location = new Point(xPosition + 39 * (j - 1), yPos);

					Controls.Add(checkBox);
					number++;
				}
				yPos += 31;
			}
			this.planeimg.SendToBack();
		}

		private void checkBoxConfirm_Click(object sender, EventArgs e) {
			CheckBox checkBox = (CheckBox)sender;
			if (!checkBox.Checked) {
				checkBox.BackColor = Color.Gold;
			} else {
				checkBox.BackColor = Color.Lime;
			}
		}
		private void checkBox_Click(object sender, EventArgs e) {
			CheckBox checkBox = (CheckBox)sender;
			if (!checkBox.Checked) {
				checkBox.BackColor = Color.White;
			} else {
				checkBox.BackColor = Color.FromArgb(19, 216, 143);
			}
		}

		private void setFlights() {
			this.cbFlights.Items.Clear();
			List<int> flightIds = new List<int>();
			List<string> flights = new List<string>();

			try {
				this.conn.open();
				SqlCommand cmd = new SqlCommand("Get_Flights", this.conn.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@idAerolinea", airlineId);

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read()) {
					int flightId = Convert.ToInt32(reader["Vuelo"]);
					string flight = reader["Vuelo"].ToString();

					flightIds.Add(flightId);
					flights.Add(flight);
				}
				reader.Close(); 

				for (int i = 0; i < flightIds.Count; i++) {
					int flightId = flightIds[i];

					bool isConfirmed = false;
					using (SqlCommand checkCmd = new SqlCommand("SELECT dbo.isFlightConfirmed(@idVuelo)", this.conn.ConnectDB)) {
						checkCmd.Parameters.AddWithValue("@idVuelo", flightId);
						isConfirmed = Convert.ToBoolean(checkCmd.ExecuteScalar());
					}
					if (!isConfirmed) {
						this.cbFlights.Items.Add(flights[i]);
					}
				}
			} catch (Exception ex) {
				MessageBox.Show("Error: " + ex.Message);
			} finally {
				if (this.conn.ConnectDB.State == ConnectionState.Open) {
					conn.close();
				}
			}
		}



		private void cbFlights_SelectedIndexChanged(object sender, EventArgs e) {
			int planeId = 0;
			int maxCapacity = 0;
			try {
				this.conn.open();
				SqlCommand cmd = new SqlCommand("Search_Active_Flights", this.conn.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@idVuelo", Convert.ToInt32(this.cbFlights.SelectedItem));

				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read()) {
					planeId = Convert.ToInt32(reader["idAvion"]);
				}
				reader.Close();

				SqlCommand cmd2 = new SqlCommand("Search_Active_Planes", this.conn.ConnectDB);
				cmd2.CommandType = CommandType.StoredProcedure;
				cmd2.Parameters.AddWithValue("@idAvion", planeId);

				SqlDataReader reader2 = cmd2.ExecuteReader();
				if (reader2.Read()) {
					maxCapacity = Convert.ToInt32(reader2["capacidadPasajeros"]);

				}
				reader2.Close();
				buttonGrid(maxCapacity);
			} catch (Exception ex) {
				MessageBox.Show("Error: " + ex.Message);
			} finally {
				if (this.conn.ConnectDB.State == ConnectionState.Open) {
					this.conn.close();
				}
			}
		}

		private void btBookTickets_Click(object sender, EventArgs e) {


			List<int> seats = new List<int>();

			foreach (Control control in Controls) {
				if (control is CheckBox checkBox && checkBox.Checked) {
					if (int.TryParse(checkBox.Text, out int seatNumber)) {
						if (!(checkBox.BackColor == Color.Red)) {
							seats.Add(seatNumber);

						}
					}
				}
			}
			if (seats.Count > 0) {
				
				string seatNumbers = string.Join(", ", seats.Select(s => s.ToString()));
				MessageBox.Show($"Asientos seleccionados: {seatNumbers}", "Asientos Confirmados", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.super.addPassengers(seats);
				this.super.selectedFlight = Convert.ToInt32(this.cbFlights.SelectedItem);
			} else {
				MessageBox.Show("No se han seleccionado asientos.", "Asientos no seleccionados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btConfirmPassengers_Click(object sender, EventArgs e) {
			if (!this.canConfirm) {
				MessageBox.Show("No hay asientos reservados.", "Vuelo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			int planeId = 0;
			int maxCapacity = 0;
			try {
				this.conn.open();
				SqlCommand cmd = new SqlCommand("Search_Active_Flights", this.conn.ConnectDB);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@idVuelo", Convert.ToInt32(this.cbFlights.SelectedItem));

				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read()) {
					planeId = Convert.ToInt32(reader["idAvion"]);
				}
				reader.Close();

				SqlCommand cmd2 = new SqlCommand("Search_Active_Planes", this.conn.ConnectDB);
				cmd2.CommandType = CommandType.StoredProcedure;
				cmd2.Parameters.AddWithValue("@idAvion", planeId);

				SqlDataReader reader2 = cmd2.ExecuteReader();
				if (reader2.Read()) {
					maxCapacity = Convert.ToInt32(reader2["capacidadPasajeros"]);

				}
				reader2.Close();
				buttonGridConfirm(maxCapacity);
				this.super.btBottomOption.Text = "Confirmar";
				this.super.btLeftOption.Visible = false;
				this.super.btRightOption.Visible = false;
				this.super.btBottomOption.Visible = true;
				this.btBookTickets.Visible = false;
				this.cbFlights.Visible = false;
				this.lbFlights.Visible = false;
				this.super.btBottomOption.FillColor = Color.Lime;
			} catch (Exception ex) {
				MessageBox.Show("Error: " + ex.Message);
			} finally {
				if (this.conn.ConnectDB.State == ConnectionState.Open) {
					this.conn.close();
				}
			}
		}
	}
}

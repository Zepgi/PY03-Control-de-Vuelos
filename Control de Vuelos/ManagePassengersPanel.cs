using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Vuelos {
	public partial class ManagePassengersPanel : Form {

		private DatabaseConnection conn;
		private FlightsPanel super;

		public ManagePassengersPanel(FlightsPanel pSuper) {
			this.conn = new DatabaseConnection();
			InitializeComponent();
			this.super = pSuper;
		}

		public bool addPassenger() {
			bool flag = false;
			if (string.IsNullOrEmpty(this.txtIdPassenger.Text) ||
				string.IsNullOrEmpty(this.txtPassengerName.Text) ||
				string.IsNullOrEmpty(this.txtCountry.Text) ||
				string.IsNullOrEmpty(this.txtCanton.Text) ||
				string.IsNullOrEmpty(this.txtDistrict.Text) ||
				string.IsNullOrEmpty(this.txtCity.Text)) {
				MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return flag;
			}

			string[] nameParts = this.txtPassengerName.Text.Split(' ');
			if (nameParts.Length < 3) {
				MessageBox.Show("Por favor, ingrese nombre y apellidos completos.", "Error en el nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return flag;
			}

			if (this.txtIdPassenger.Text.Length < 9) {
				MessageBox.Show("El número de identificación debe tener al menos 9 caracteres.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return flag;
			}

			if (!isValidText(this.txtPassengerName.Text)) {
				MessageBox.Show("El nombre del pasajero no puede contener números.", "Nombre incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return flag;
			}

			if (!isValidText(this.txtCountry.Text)) {
				MessageBox.Show("El país no puede contener números.", "Nombre incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return flag;
			}


			string nombre = nameParts[0];
			string apellidoPat = nameParts[1];
			string apellidoMat = nameParts[2];

			try {
				this.conn.open();

				bool passengerExists = false;
				using (SqlCommand cmdSearchPassenger = new SqlCommand("Search_Passenger", this.conn.ConnectDB)) {
					cmdSearchPassenger.CommandType = CommandType.StoredProcedure;
					cmdSearchPassenger.Parameters.AddWithValue("@cedulaPasajero", this.txtIdPassenger.Text);
					using (SqlDataReader reader = cmdSearchPassenger.ExecuteReader()) {
						if (reader.Read()) {
							passengerExists = true;
						}
					}
				}

				if (passengerExists && this.super.actualSeats.Count > 0) {
					return true;
				}
				else if (passengerExists) {
					MessageBox.Show("El pasajero ya está registrado.", "Error al registrar pasajero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return flag;
				}

				using (SqlCommand cmdCity = new SqlCommand("Add_City", this.conn.ConnectDB)) {
					cmdCity.CommandType = CommandType.StoredProcedure;
					cmdCity.Parameters.AddWithValue("@pais", this.txtCountry.Text);
					cmdCity.Parameters.AddWithValue("@canton", this.txtCanton.Text);
					cmdCity.Parameters.AddWithValue("@distrito", this.txtDistrict.Text);
					cmdCity.Parameters.AddWithValue("@ciudad", this.txtCity.Text);
					cmdCity.ExecuteNonQuery();
				}

				string codigoCiudad;
				using (SqlCommand cmdGetCityCode = new SqlCommand("Search_City", this.conn.ConnectDB)) {
					cmdGetCityCode.CommandType = CommandType.StoredProcedure;
					cmdGetCityCode.Parameters.AddWithValue("@pais", this.txtCountry.Text);
					cmdGetCityCode.Parameters.AddWithValue("@canton", this.txtCanton.Text);
					cmdGetCityCode.Parameters.AddWithValue("@distrito", this.txtDistrict.Text);
					cmdGetCityCode.Parameters.AddWithValue("@ciudad", this.txtCity.Text);
					codigoCiudad = cmdGetCityCode.ExecuteScalar().ToString();
				}

				using (SqlCommand cmdPassenger = new SqlCommand("Add_Passenger", this.conn.ConnectDB)) {
					cmdPassenger.CommandType = CommandType.StoredProcedure;
					cmdPassenger.Parameters.AddWithValue("@cedulaPasajero", this.txtIdPassenger.Text);
					cmdPassenger.Parameters.AddWithValue("@nombre", nombre);
					cmdPassenger.Parameters.AddWithValue("@apellidoPat", apellidoPat);
					cmdPassenger.Parameters.AddWithValue("@apellidoMat", apellidoMat);
					cmdPassenger.Parameters.AddWithValue("@codigoCiudad", codigoCiudad);
					cmdPassenger.ExecuteNonQuery();
				}
				flag = true;

			} catch (Exception ex) {
				MessageBox.Show("Error: " + ex.Message, "Error al registrar pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				if (this.conn.ConnectDB.State == ConnectionState.Open) {
					this.conn.close();
				}
			}
			return flag;
		}

		private void txtIdPassenger_Leave(object sender, EventArgs e) {
			if (this.super.btRightOption.Text.Equals("Agregar Pasajero")) {
				return;
			}
			try {
				this.conn.open();

				using (SqlCommand cmdSearchPassenger = new SqlCommand("Search_Passenger", this.conn.ConnectDB)) {
					cmdSearchPassenger.CommandType = CommandType.StoredProcedure;
					cmdSearchPassenger.Parameters.AddWithValue("@cedulaPasajero", this.txtIdPassenger.Text);

					using (SqlDataReader reader = cmdSearchPassenger.ExecuteReader()) {
						if (reader.Read()) {
							this.txtPassengerName.Text = reader["nombreCompleto"].ToString();
							this.txtCountry.Text = reader["pais"].ToString();
							this.txtCanton.Text = reader["canton"].ToString();
							this.txtDistrict.Text = reader["distrito"].ToString();
							this.txtCity.Text = reader["ciudad"].ToString();
						} else {
							this.txtPassengerName.Text = string.Empty;
							this.txtCountry.Text = string.Empty;
							this.txtCanton.Text = string.Empty;
							this.txtDistrict.Text = string.Empty;
							this.txtCity.Text = string.Empty;
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

		private void txtIdPassenger_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char) Keys.Enter) {
				try {
					this.conn.open();

					using (SqlCommand cmdSearchPassenger = new SqlCommand("Search_Passenger", this.conn.ConnectDB)) {
						cmdSearchPassenger.CommandType = CommandType.StoredProcedure;
						cmdSearchPassenger.Parameters.AddWithValue("@cedulaPasajero", this.txtIdPassenger.Text);

						using (SqlDataReader reader = cmdSearchPassenger.ExecuteReader()) {
							if (reader.Read()) {
								this.txtPassengerName.Text = reader["nombreCompleto"].ToString();
								this.txtCountry.Text = reader["pais"].ToString();
								this.txtCanton.Text = reader["canton"].ToString();
								this.txtDistrict.Text = reader["distrito"].ToString();
								this.txtCity.Text = reader["ciudad"].ToString();
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
		public bool isValidText(string text) {
			foreach (char c in text) {
				if (char.IsDigit(c)) {
					return false;
				}
			}
			return true;
		}
	}
}

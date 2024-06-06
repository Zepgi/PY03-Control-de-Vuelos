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

namespace Control_de_Vuelos {
	public partial class ManagePassengersPanel : Form {

		DatabaseConnection conn;

		public ManagePassengersPanel() {
			this.conn = new DatabaseConnection();
			InitializeComponent();
		}

		public bool addPassenger() {
			bool flag = false;
			// Verificar que todos los campos necesarios estén completos
			if (string.IsNullOrEmpty(this.txtIdPassenger.Text) ||
				string.IsNullOrEmpty(this.txtPassengerName.Text) ||
				string.IsNullOrEmpty(this.txtCountry.Text) ||
				string.IsNullOrEmpty(this.txtCanton.Text) ||
				string.IsNullOrEmpty(this.txtDistrict.Text) ||
				string.IsNullOrEmpty(this.txtCity.Text)) {
				MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return flag;
			}

			// Dividir el nombre completo en nombre y apellidos
			string[] nameParts = this.txtPassengerName.Text.Split(' ');
			if (nameParts.Length < 3) {
				MessageBox.Show("Por favor, ingrese nombre y apellidos completos.", "Error en el nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return flag;
			}

			string nombre = nameParts[0];
			string apellidoPat = nameParts[1];
			string apellidoMat = nameParts[2];

			try {
				this.conn.open();

				// Agregar la ciudad si no existe
				using (SqlCommand cmdCity = new SqlCommand("Add_City", this.conn.ConnectDB)) {
					cmdCity.CommandType = CommandType.StoredProcedure;
					cmdCity.Parameters.AddWithValue("@pais", this.txtCountry.Text);
					cmdCity.Parameters.AddWithValue("@canton", this.txtCanton.Text);
					cmdCity.Parameters.AddWithValue("@distrito", this.txtDistrict.Text);
					cmdCity.Parameters.AddWithValue("@ciudad", this.txtCity.Text);
					cmdCity.ExecuteNonQuery();
				}

				// Obtener el código de ciudad
				string codigoCiudad;
				using (SqlCommand cmdGetCityCode = new SqlCommand("Search_City", this.conn.ConnectDB)) {
					cmdGetCityCode.CommandType = CommandType.StoredProcedure;
					cmdGetCityCode.Parameters.AddWithValue("@pais", this.txtCountry.Text);
					cmdGetCityCode.Parameters.AddWithValue("@canton", this.txtCanton.Text);
					cmdGetCityCode.Parameters.AddWithValue("@distrito", this.txtDistrict.Text);
					cmdGetCityCode.Parameters.AddWithValue("@ciudad", this.txtCity.Text);
					codigoCiudad = cmdGetCityCode.ExecuteScalar().ToString();
				}

				// Agregar el pasajero
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

	}
}

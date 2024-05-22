using System;
using System.Data.SqlClient;

namespace Control_de_Vuelos {
	internal class DatabaseConnection {
		static readonly string cadena = "Data source=" + Environment.MachineName + "; Initial Catalog=AEROLINEAS; Integrated Security=True";

		public SqlConnection ConectarBD = new SqlConnection();

		public DatabaseConnection() {
			ConectarBD.ConnectionString = cadena;
		}

		public bool open() {
			try {
				ConectarBD.Open();
				return true;
			} catch (Exception) {
				return false;
			}
		}

		public void close() {
			ConectarBD.Close();
		}
	}
}


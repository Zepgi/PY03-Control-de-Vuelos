using System;
using System.Data.SqlClient;

namespace Control_de_Vuelos {
	internal class DatabaseConnection {
		static readonly string cadena = "Data source=" + Environment.MachineName + "; Initial Catalog=AEROLINEAS; Integrated Security=True";

		public SqlConnection ConnectDB = new SqlConnection();

		public DatabaseConnection() {
			ConnectDB.ConnectionString = cadena;
		}

		public bool open() {
			try {
				ConnectDB.Open();
				return true;
			} catch (Exception) {
				return false;
			}
		}

		public void close() {
			ConnectDB.Close();
		}
	}
}


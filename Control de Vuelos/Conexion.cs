using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;


namespace Control_de_Vuelos
{
    internal class Conexion
    {
        public SqlConnection SQLConexionBD;

        public Conexion()
        {
            try
            {
                SQLConexionBD = new SqlConnection("Data Source=joses_pc;Initial Catalog=AEROLINEAS;Integrated Security=True;");
                SQLConexionBD.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
            }

        }
    }
}
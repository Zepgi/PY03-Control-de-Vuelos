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
using static Guna.UI2.Native.WinApi;

namespace Control_de_Vuelos
{
    public partial class PassangerConfimFligth : Form
    {
        DatabaseConnection cnn;
        int id;
        String identity;

        public PassangerConfimFligth(int id, String identi)
        {
            InitializeComponent();
            this.cnn = new DatabaseConnection();
            this.id = id;
            this.identity = identi;
            loadFligthData();
        }

        private void loadFligthData()
        {
            try
            {
                // Open connection
                cnn.open();

                SqlCommand info = new SqlCommand("Fligth_Passenger_Confirm", cnn.ConnectDB);
                info.CommandType = CommandType.StoredProcedure;
                info.Parameters.AddWithValue("@id", this.id);
                info.Parameters.AddWithValue("@identity", this.identity);

                SqlDataAdapter adapter = new SqlDataAdapter(info);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                foreach (DataRow row in dataTable.Rows)
                {
                    fligthText.Text = row["idVuelo"].ToString();
                    dHDText.Text = row["fechaHoraPartida"].ToString();
                    dHAText.Text = row["fechaHoraLlegada"].ToString();
                    cityDText.Text = row["ciudadSalida"].ToString();
                    cityAText.Text = row["ciudadLlegada"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close connection
                cnn.close();
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

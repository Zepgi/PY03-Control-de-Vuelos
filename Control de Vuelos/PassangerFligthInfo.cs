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

namespace Control_de_Vuelos
{
    public partial class PassangerFligthInfo : Form
    {
        DatabaseConnection cnn;
        int idV;

        public PassangerFligthInfo(int id)
        {
            InitializeComponent();
            this.cnn = new DatabaseConnection();
            this.idV = id;
            loadPassangerData();
        }

        private void loadPassangerData()
        {
            try
            {
                // Open connection
                cnn.open();

                SqlCommand info = new SqlCommand("Fligth_Passenger_Info", cnn.ConnectDB);
                info.CommandType = CommandType.StoredProcedure;
                info.Parameters.AddWithValue("@id", this.idV);

                SqlDataAdapter adapter = new SqlDataAdapter(info);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                foreach (DataRow row in dataTable.Rows)
                {
                    fligthText.Text = row["idVuelo"].ToString();
                    completeNameText.Text = row["nombrePasajero"].ToString();
                    sitText.Text = row["asiento"].ToString();

                    bool con = (bool)row["confirmado"];
                    if (con)
                    {
                        confirmText.Text = "Si";
                    } else
                    {
                        confirmText.Text = "No";
                    }
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

using Guna.UI2.WinForms;
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
    public partial class SelectAirline : Form
    {
        DatabaseConnection conn;
        int idAirline;
        String airlineName;
        PilotPanel windowPilot;
        bool firstTime;

        public SelectAirline(PilotPanel window)
        {
            InitializeComponent();
            conn = new DatabaseConnection();
            this.windowPilot =window;
            this.firstTime = true;
            loadAirlinesData();
        }

        private void loadAirlinesData()
        {
            if (this.firstTime)
            {
                // Create the columns on the DataGrid  idAerolinea, nombre, lema, estado 
                airlineGrid.Columns.Add("idColumn", "ID");
                airlineGrid.Columns.Add("nameColumn", "Nombre");
                airlineGrid.Columns.Add("mottoColumn", "Lema");
                airlineGrid.Columns.Add("stateColumn", "Estado");

                airlineGrid.AutoGenerateColumns = false;  // Disable automatic column generation
                airlineGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                this.firstTime = false;
            }

            try
            {
                // Open connection
                conn.open();

                SqlCommand pilotsData = new SqlCommand("ObtenerAerolineas", conn.ConnectDB);
                pilotsData.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(pilotsData);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Check if dataTable has rows
                if (dataTable.Rows.Count > 0)
                {
                    searchPanel.Visible = true;
                }

                //Change the boolean value 0 or 1 to Inactivo or Activo
                changeValueState(dataTable);

                // Map columns explicitly
                airlineGrid.Columns["idColumn"].DataPropertyName = "idAerolinea";
                airlineGrid.Columns["nameColumn"].DataPropertyName = "nombre";
                airlineGrid.Columns["mottoColumn"].DataPropertyName = "lema";
                airlineGrid.Columns["stateColumn"].DataPropertyName = "estado";

                // Assign data to DataGridView
                airlineGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close connection
                conn.close();
            }
        }

        private void changeValueState(DataTable dT)
        {
            //Creates a new column type string
            dT.Columns.Add("estadoString", typeof(string));

            //Iterates through all the rows to change the value
            foreach (DataRow row in dT.Rows)
            {
                bool state = (bool)row["estado"];
                row["estadoString"] = state ? "Activo" : "Inactivo";
            }

            dT.Columns.Remove("estado");

            dT.Columns["estadoString"].ColumnName = "estado";


        }

        private void airlineGrid_RowPrePaint(object sender, System.Windows.Forms.DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = airlineGrid.Rows[e.RowIndex];

            if (row.Cells["stateColumn"] != null && row.Cells["stateColumn"].Value != null)
            {
                if (row.Cells["stateColumn"].Value.ToString() == "Inactivo")
                {
                    row.DefaultCellStyle.BackColor = Color.Gray;
                    row.DefaultCellStyle.ForeColor = Color.LightGray;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = airlineGrid.DefaultCellStyle.BackColor;
                    row.DefaultCellStyle.ForeColor = airlineGrid.DefaultCellStyle.ForeColor;
                }
            }
            else
            {
                row.DefaultCellStyle.BackColor = airlineGrid.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.ForeColor = airlineGrid.DefaultCellStyle.ForeColor;
            }
        }

        private void airlineGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Left)
            {
                DataGridViewRow row = airlineGrid.Rows[e.RowIndex];

                //No click in row with column value Inactivo
                if (row.Cells["stateColumn"].Value.ToString() == "Inactivo")
                {
                    airlineGrid.ClearSelection();
                    row.Selected = true;
                    airlineGrid[e.ColumnIndex, e.RowIndex].Selected = false;
                }
                else
                {
                    //Selects all the row of the cell the user selected
                    airlineGrid.Rows[e.RowIndex].Selected = true;

                    //Desable other rows to avoid errors
                    foreach (DataGridViewRow otherRow in airlineGrid.Rows)
                    {
                        if (otherRow != row)
                            otherRow.Selected = false;
                    }

                    this.idAirline = (int)row.Cells["idColumn"].Value;
                    this.airlineName = row.Cells["nameColumn"].Value.ToString();
                }
            }
        }

        private void airlineGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (airlineGrid.SelectedCells.Count == 0)
                return;

            foreach (DataGridViewCell cell in airlineGrid.SelectedCells)
            {
                if (cell == null || cell.OwningRow == null)
                    continue;

                DataGridViewRow row = cell.OwningRow;

                if (row.Cells["stateColumn"] != null && row.Cells["stateColumn"].Value != null && row.Cells["stateColumn"].Value.ToString() == "Inactivo")
                {
                    cell.Selected = false;
                }
            }
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            //If is empty shows all the airlines data
            if (string.IsNullOrEmpty(searchTB.Text))
            {
                loadAirlinesData();
            }
            else
            {
                try
                {
                    // Open connection
                    conn.open();

                    SqlCommand search = new SqlCommand("GetAirlineByName", conn.ConnectDB);
                    search.CommandType = CommandType.StoredProcedure;
                    search.Parameters.AddWithValue("@Name", searchTB.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(search);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    //Change the boolean value 0 or 1 to Inactivo or Activo
                    changeValueState(dataTable);

                    // Map columns explicitly
                    airlineGrid.Columns["idColumn"].DataPropertyName = "idAerolinea";
                    airlineGrid.Columns["nameColumn"].DataPropertyName = "nombre";
                    airlineGrid.Columns["mottoColumn"].DataPropertyName = "lema";
                    airlineGrid.Columns["stateColumn"].DataPropertyName = "estado";

                    // Assign data to DataGridView
                    airlineGrid.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close connection
                    conn.close();
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(this.windowPilot.getSelect())
            {
                this.windowPilot.setModify(true);
            }

            this.windowPilot.setIdAirline(this.idAirline, this.airlineName);
            this.Close();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

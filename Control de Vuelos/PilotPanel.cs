using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Control_de_Vuelos
{
    public partial class PilotPanel : Form
    {
        DatabaseConnection conn;
        bool firstTime;
        int idPilot;
        int idAirline;
        bool modify;
        bool selected;

        public PilotPanel()
        {
            InitializeComponent();
            conn = new DatabaseConnection();
            firstTime = true;
            selected = false;
            loadCountries();
            loadPilotsData();
        }

        //-----------------------------------Functions for the performance of the buttons------------------------------------------

        //Asignes a airline to the pilot
        private void airlineB_Click(object sender, EventArgs e)
        {
            SelectAirline airlines = new SelectAirline(this);
            airlines.Show();

        }

        //Adds the data of the pilots to the database
        private void btnAddPilot_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifications of the textBox
                nullValues();
                verifyLetters(nameTB.Text, lastName1TB.Text, lastName2TB.Text);
                verifyIdentity(identityTB.Text, 0);

                conn.open();
                //Insert the data inthe textBox to the database
                SqlCommand inserted = new SqlCommand("Insert_Pilot", conn.ConnectDB);
                inserted.CommandType = CommandType.StoredProcedure;
                inserted.Parameters.AddWithValue("@identity", identityTB.Text);
                inserted.Parameters.AddWithValue("@lastName1", lastName1TB.Text);
                inserted.Parameters.AddWithValue("@lastName2", lastName2TB.Text);
                inserted.Parameters.AddWithValue("@name", nameTB.Text);
                inserted.Parameters.AddWithValue("@country", countryCB.SelectedItem);
                inserted.Parameters.AddWithValue("@airline", this.idAirline);

                int rowsAffected = inserted.ExecuteNonQuery();

                if (rowsAffected <= 0)
                {
                    throw new Exception("No se pudo moodificar el piloto.");
                }

                //Reset the gridView
                loadPilotsData();

                //Message of congratulation
                MessageBox.Show("Se agregó el piloto exitosamente", "¡Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos\n: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.close();
            }
        }

        //Modify the information of a pilot
        private void btnModifyPilot_Click(object sender, EventArgs e)
        {

            try
            {
                //Verifications of the textBox
                nullValues();
                verifyLetters(nameTB.Text, lastName1TB.Text, lastName2TB.Text);
                verifyIdentity(identityTB.Text, this.idPilot);

                conn.open();
                //Updates the data inthe textBox to the database
                SqlCommand updated = new SqlCommand("Update_Pilot", conn.ConnectDB);
                updated.CommandType = CommandType.StoredProcedure;
                updated.Parameters.AddWithValue("@id", this.idPilot);
                updated.Parameters.AddWithValue("@identity", identityTB.Text);
                updated.Parameters.AddWithValue("@lastName1", lastName1TB.Text);
                updated.Parameters.AddWithValue("@lastName2", lastName2TB.Text);
                updated.Parameters.AddWithValue("@name", nameTB.Text);
                updated.Parameters.AddWithValue("@country", countryCB.SelectedItem);

                if(!modify)
                {
                    this.idAirline = getIdAirline(this.idPilot);
                }

                updated.Parameters.AddWithValue("@airline", this.idAirline);

                int rowsAffected = updated.ExecuteNonQuery();

                if (rowsAffected <= 0) {
                    throw new Exception("No se pudo moodificar el piloto.");
                }

                //Reset the gridView
                loadPilotsData();

                //Resets the textBoxs
                clearInputs();

                //Message of congratulation
                MessageBox.Show("Se modificó el piloto exitosamente", "¡Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.close();
            }
          
        }

        //Deletes the pilot
        private void btnDeletePilot_Click(object sender, EventArgs e)
		{

            //Ask if the user wants to delete the pilot
            DialogResult answer = MessageBox.Show("¿Está seguro de que desea eliminar al piloto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (answer == DialogResult.Yes)
            {
                try
                {
                    conn.open();
                    //Delete the pilot
                    SqlCommand delete = new SqlCommand("Delete_Pilot", conn.ConnectDB);
                    delete.CommandType = CommandType.StoredProcedure;
                    delete.Parameters.AddWithValue("@id", this.idPilot);

                    int rowsAffected = delete.ExecuteNonQuery();

                    if (rowsAffected <= 0)
                    {
                        throw new Exception("No se pudo eliminar el piloto.");
                    }

                    //Reset the gridView
                    loadPilotsData();

                    //Resets the textBoxs
                    clearInputs();

                    //Message of congratulation
                    MessageBox.Show("El piloto se eliminó correctamente", "¡Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al cargar los datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.close();
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            clearInputs();
        }

        //-------------------------Functions for the good performance of the gridView----------------------------

        //Changed the style of a row were the column Estado is Inactivo
        private void pilotsGrid_RowPrePaint_1(object sender, System.Windows.Forms.DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = pilotsGrid.Rows[e.RowIndex];

            if (row.Cells["stateColumn"] != null && row.Cells["stateColumn"].Value != null)
            {
                if (row.Cells["stateColumn"].Value.ToString() == "Inactivo")
                {
                    row.DefaultCellStyle.BackColor = Color.Gray;
                    row.DefaultCellStyle.ForeColor = Color.LightGray;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = pilotsGrid.DefaultCellStyle.BackColor;
                    row.DefaultCellStyle.ForeColor = pilotsGrid.DefaultCellStyle.ForeColor;
                }
            }
            else
            {
                row.DefaultCellStyle.BackColor = pilotsGrid.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.ForeColor = pilotsGrid.DefaultCellStyle.ForeColor;
            }
        }

        //Mange the event of selected in the data grid
        private void pilotsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (pilotsGrid.SelectedCells.Count == 0)
                return;

            foreach (DataGridViewCell cell in pilotsGrid.SelectedCells)
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

        //If the row is enable, prevents the selection
        private void pilotsGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Left)
            {
                DataGridViewRow row = pilotsGrid.Rows[e.RowIndex];

                //No click in row with column value Inactivo
                if (row.Cells["stateColumn"].Value.ToString() == "Inactivo")
                {
                    pilotsGrid.ClearSelection();
                    row.Selected = true;
                    pilotsGrid[e.ColumnIndex, e.RowIndex].Selected = false;
                }
                else
                {
                    //Selects all the row of the cell the user selected
                    pilotsGrid.Rows[e.RowIndex].Selected = true;

                    //Desable other rows to avoid errors
                    foreach (DataGridViewRow otherRow in pilotsGrid.Rows)
                    {
                        if (otherRow != row)
                            otherRow.Selected = false;
                    }

                    //Load the information of the pilot
                    loadPilotData(row);
                }
            }
        }

        //Makes the serach while the user changed the data
        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            //If is empty shows all the pilots data
            if (string.IsNullOrEmpty(searchTB.Text))
            {
                loadPilotsData();
            }
            else
            {
                try
                {
                    // Open connection
                    conn.open();

                    SqlCommand search = new SqlCommand("Search_Pilot", conn.ConnectDB);
                    search.CommandType = CommandType.StoredProcedure;
                    search.Parameters.AddWithValue("@searchValue", searchTB.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(search);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    //Change the boolean value 0 or 1 to Inactivo or Activo
                    changeValueState(dataTable);

                    // Map columns explicitly
                    pilotsGrid.Columns["idColumn"].DataPropertyName = "idPiloto";
                    pilotsGrid.Columns["identityColumn"].DataPropertyName = "cedulaPiloto";
                    pilotsGrid.Columns["nameColumn"].DataPropertyName = "nombreCompleto";
                    pilotsGrid.Columns["countryColumn"].DataPropertyName = "nacionalidad";
                    pilotsGrid.Columns["airlineColumn"].DataPropertyName = "nombre";
                    pilotsGrid.Columns["stateColumn"].DataPropertyName = "estado";

                    // Assign data to DataGridView
                    pilotsGrid.DataSource = dataTable;
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

        //---------------------------Auxiliary  functions for the data manipulation----------------------------

        //Load all the countries to the comboBox
        private void loadCountries()
        {
            List<string> countriesList = new List<string>();

            string[] countriesCode = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                                                .Select(x => (new RegionInfo(x.LCID)).TwoLetterISORegionName)
                                                .Distinct()
                                                .ToArray();

            foreach (string code in countriesCode)
            {
                RegionInfo region = new RegionInfo(code);
                countriesList.Add(region.DisplayName);
            }

            countriesList.Sort();

            countryCB.DataSource = countriesList;
            countryCB.SelectedIndex = -1;
        }

        //Loads the data of all the pilots in the database to the gridView
        private void loadPilotsData()
        {

            // Creates the columns one time
            if (this.firstTime)
            {
                // Create the columns on the DataGrid
                pilotsGrid.Columns.Add("idColumn", "ID");
                pilotsGrid.Columns.Add("identityColumn", "Cedula");
                pilotsGrid.Columns.Add("nameColumn", "Nombre Completo");
                pilotsGrid.Columns.Add("countryColumn", "Pais de Origen");
                pilotsGrid.Columns.Add("airlineColumn", "Aerolinea");
                pilotsGrid.Columns.Add("stateColumn", "Estado");
                this.firstTime = false;
            }

            pilotsGrid.AutoGenerateColumns = false;  // Disable automatic column generation
            pilotsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                // Open connection
                conn.open();

                SqlCommand pilotsData = new SqlCommand("Get_Pilots_Data", conn.ConnectDB);
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
                pilotsGrid.Columns["idColumn"].DataPropertyName = "idPiloto";
                pilotsGrid.Columns["identityColumn"].DataPropertyName = "cedulaPiloto";
                pilotsGrid.Columns["nameColumn"].DataPropertyName = "nombreCompleto";
                pilotsGrid.Columns["countryColumn"].DataPropertyName = "nacionalidad";
                pilotsGrid.Columns["airlineColumn"].DataPropertyName = "nombre";
                pilotsGrid.Columns["stateColumn"].DataPropertyName = "estado";

                // Assign data to DataGridView
                pilotsGrid.DataSource = dataTable;
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

        //Loads in the imputs the data of a pilot
        private void loadPilotData(DataGridViewRow row)
        {
            this.selected = true;

            //Shows the buttons of modify, return and delete
            this.btnModifyPilot.Visible = true;
            this.btnDeletePilot.Visible = true;
            this.btnReturn.Visible = true;
            this.btnAddPilot.Visible = false;

            //Separate the names
            String[] fullName = row.Cells["nameColumn"].Value.ToString().Split(' ');

            this.idPilot = (int)row.Cells["idColumn"].Value;
            identityTB.Text = row.Cells["identityColumn"].Value.ToString();
            nameTB.Text = fullName[0];
            lastName1TB.Text = fullName[1];
            lastName2TB.Text = fullName[2];
            countryCB.SelectedItem = row.Cells["countryColumn"].Value.ToString();
            airlineTB.Text = row.Cells["airlineColumn"].Value.ToString();
        }

        //Sets the input spaces to its default values
        private void clearInputs()
        {
            identityTB.ResetText();
            nameTB.ResetText();
            lastName1TB.ResetText();
            lastName2TB.ResetText();
            airlineTB.ResetText();
            countryCB.SelectedIndex = -1;

            //Shows the button of add 
            this.btnModifyPilot.Visible = false;
            this.btnDeletePilot.Visible = false;
            this.btnReturn.Visible = false;
            this.btnAddPilot.Visible = true;

            this.selected = false;
            this.modify = false;
        }

        //Check if the user wrote all the necessary information
        private void nullValues()
        {
            if (string.IsNullOrEmpty(identityTB.Text) || string.IsNullOrEmpty(nameTB.Text) || string.IsNullOrEmpty(lastName1TB.Text) || string.IsNullOrEmpty(lastName2TB.Text) || string.IsNullOrEmpty(airlineTB.Text) || (countryCB.SelectedIndex == -1))
            {
                throw new Exception("Porfavor, no deje espacios vacios.");
            }

        }

        //Verify if the name and last names tectBoxs contains only letters
        private void verifyLetters(String name, String lastName1, String lastName2)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ']+$") || !Regex.IsMatch(lastName1, @"^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ']+$") || !Regex.IsMatch(lastName2, @"^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ']+$"))
            {
                throw new Exception("El nombre y apellidos solo pueden estar compuestos por letras, tildes y apóstrofos.");
            }


        }

        //Checks if the identity already exists
        private void verifyIdentity(String identity, int idP)
        {
            //Makes the consult 
            conn.open();

            SqlCommand exist = new SqlCommand("Identity_Exist", conn.ConnectDB);
            exist.CommandType = CommandType.StoredProcedure;
            exist.Parameters.AddWithValue("@identity", identity);
            exist.Parameters.AddWithValue("@idPilot", idP);
            object result = exist.ExecuteScalar();


            if (result != null)
            {
                if (result.Equals(1))
                {
                    if (idP == 0)
                    {
                        throw new Exception("El piloto ya existe.");
                    } else
                    {
                        throw new Exception("La cedula puesta le pertenece a otro piloto.");
                    }
                }
            }
            
            conn.close();
        }

        //Gets the idAirline of the actual pilot
        private int getIdAirline(int id)
        {
            //Makes th consult
            SqlCommand exist = new SqlCommand("Get_IdAirline", conn.ConnectDB);
            exist.CommandType = CommandType.StoredProcedure;
            exist.Parameters.AddWithValue("@idPilot", id);
            object result = exist.ExecuteScalar();

            int resultId = result != null ? Convert.ToInt32(result) : 0;

            return resultId;
        }

        //Sets the idAirline
        public void setIdAirline(int id, String name)
        {
            this.idAirline = id;
            this.airlineTB.Text = name;
        }

        public void setModify(bool b)
        {
            this.modify = b;
        }

        public bool getSelect()
        {
            return this.selected;
        }

    }
}

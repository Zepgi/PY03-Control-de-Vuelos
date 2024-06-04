using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Vuelos {
	public partial class FlightsPanel : Form {

		List<int> permissions;
		int idAirline;
		string idUser;
		public FlightsPanel(int pIdAirline, string pIdUser, List<int> pPermissions) {
			this.idAirline = pIdAirline;
			this.idUser = pIdUser;
			this.permissions = pPermissions;
			InitializeComponent();
			this.setView();
		}

		

		private void button_Click(object sender, EventArgs e) {
			this.lbSelectOpt.Visible = false;
			this.btLeftOption.Visible = true;
			this.btRightOption.Visible = true;
			Guna2Button b = (Guna2Button)sender;
			if (b.Text.Equals("Vuelos")) {
				this.loadPanel(new ManageFlightsPanel());
				this.btRightOption.Text = "Agregar Vuelo";
				this.btLeftOption.Text = "Modificar Vuelo";
				//setTableData("Vuelos");

			} else {
				this.loadPanel(new ManagePassengersPanel());
				this.btRightOption.Text = "Agregar Pasajero";
				this.btLeftOption.Text = "Modificar Pasajero";
				//setTableData("Pasajeros");
			}
		}

		/* private void setTableData(string pOption) {
		 * string option = pOption;
		 * string sp = "";
		 * if (option.Equals("Vuelos") {
		 *		sp = "Get_Flights";
		 * else {
		 *		sp = "Get_Passengers";
		 *  }
		 *  INSERTAR DATOS EN LA TABLA (tbFlights) es GUNA2
		*/


		private void setView() {
			if (permissions.IndexOf(3) != -1) {
				this.btRightOption.Visible = false;
				this.btLeftOption.Visible = false;
			} else {
				this.btFlights.Visible = false;
				this.btPassengers.Visible = false;
			}
		}

		public void loadPanel(object panel) {
			
			if (this.pInputArea.Controls.Count > 0) {
				this.pInputArea.Controls.RemoveAt(0);
			}
			Form f = panel as Form;
			f.TopLevel = false;
			f.Dock = DockStyle.Fill;
			this.pInputArea.Controls.Add(f);
			this.pInputArea.Tag = f;
			f.Show();
		}
	}
}

using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
			this.hideFlightRegister();
			//this.setView();
		}

		private void hideFlightRegister() {
			this.lbFlightDate.Visible = false;
			this.dtFlightDate.Visible = false;
			this.lbDepartureHour.Visible = false;
			this.cbDepartureHours.Visible = false;
			this.lbArrivalHour.Visible = false;
			this.cbArrivalHours.Visible = false;
			this.lbDepartureCity.Visible = false;
			this.cbDepartureCities.Visible = false;
			this.lbArrivalCity.Visible = false;
			this.cbArrivalCities.Visible = false;
			this.lbPlane.Visible = false;
			this.cbPlanes.Visible = false;
			this.lbPilot.Visible = false;
			this.cbPilots.Visible = false;
		}

		private void showFlightRegister() {
			this.lbFlightDate.Visible = true;
			this.dtFlightDate.Visible = true;
			this.lbDepartureHour.Visible = true;
			this.cbDepartureHours.Visible = true;
			this.lbArrivalHour.Visible = true;
			this.cbArrivalHours.Visible = true;
			this.lbDepartureCity.Visible = true;
			this.cbDepartureCities.Visible = true;
			this.lbArrivalCity.Visible = true;
			this.cbArrivalCities.Visible = true;
			this.lbPlane.Visible = true;
			this.cbPlanes.Visible = true;
			this.lbPilot.Visible = true;
			this.cbPilots.Visible = true;
		}

		private void button_Click(object sender, EventArgs e) {
			this.lbSelectOpt.Visible = false;
			Guna2Button b = (Guna2Button)sender;
			if (b.Text.Equals("Registrar Vuelo")) {
				this.showFlightRegister();
			} else {
				this.hideFlightRegister();
			}
		}
	}
}

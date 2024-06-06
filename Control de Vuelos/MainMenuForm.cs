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
	public partial class MainMenuForm : Form {

		Panel p = new Panel();
		bool subMenuMan;
		string idUser;
		List<int> permissions;
		int idAirline;
		readonly LoginForm view;

		public MainMenuForm(LoginForm pView, string pIdUser, List<int> pPermissions, int pIdAirline) {
			this.view = pView;
			this.idUser = pIdUser;
			this.idAirline = pIdAirline;
			this.permissions = pPermissions;
			this.subMenuMan = false;
			InitializeComponent();
			this.btMaintenance.Enabled = false;
			this.btAirlines.Enabled	 = false;
			this.btReports.Enabled		 = false;
			this.btFlights.Enabled		 = false;
			loadPanel(new HomePanel(idAirline, idUser));
			managePermissions();
		}

		private void managePermissions() {

			if (permissions.IndexOf(1) != -1) {
				this.btAirlines.Enabled = true;
			}
			if (permissions.IndexOf(2) != -1) {
				this.btFlights.Enabled = true;
			}
			if (permissions.IndexOf(3) != -1) {
				this.btMaintenance.Enabled = true;
			}
			if (permissions.IndexOf(4) != -1) {
				this.btReports.Enabled = true;
			}
		}
		

		private void btMin_Click(object sender, MouseEventArgs e) {
			this.WindowState = FormWindowState.Minimized;
		}

		private void btExit_Click(object sender, MouseEventArgs e) {
			String msg = "¿Desea cerrar la aplicación?";
			DialogResult res = MessageBox.Show(msg, "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (res == DialogResult.Yes) {
				this.Close();
				this.view.Close();
				Application.Exit();
			}
		}

		private void btn_MouseEnter(object sender, EventArgs e) {
			Button btn = (Button)sender;
			if (!btn.Enabled) {
				return;
			}
			pMenu.Controls.Add(p);
			p.BackColor = Color.FromArgb(19, 216, 143);
			p.Size = new Size(180, 6);
			p.Location = new Point(btn.Location.X, btn.Location.Y + 40);
		}

		private void btn_MouseLeave(object sender, EventArgs e) {
			pMenu.Controls.Remove(p);
		}

		private void pMantenimiento_MouseEnter(object sender, EventArgs e) {
			subMenuMan = true;
		}

		private void pMantenimiento_MouseLeave(object sender, EventArgs e) {
			subMenuMan = false;
			hideSubMenu();
		}

		private void btMantenimiento_MouseEnter(object sender, EventArgs e) {
			Button btn = (Button)sender;
			if (!btn.Enabled) {
				return;
			}
			btn_MouseEnter(sender, e);
			subMenuMan = true;
			pMaintenance.Visible = true;
		}

		private void btMantenimiento_MouseLeave(object sender, EventArgs e) {
			btn_MouseLeave(sender, e);
			subMenuMan = false;
			hideSubMenu();
		}

		private async void hideSubMenu() {
			await Task.Delay(150);
			if (!subMenuMan) {
				pMaintenance.Visible = false;
			}
		}

		private void bt_Click(object sender, EventArgs e) {
			Button btn = sender as Button;

			if (btn != null) {
				switch (btn.Name) {
					case "btAirlines":
						loadPanel(new PanelAerolineas());
						break;
					case "btReports":
						loadPanel(new PanelReportes());
						break;
					case "btMaintenance":
						loadPanel(new PanelMantenimiento());
						break;
					case "btHome":
						loadPanel(new HomePanel(idAirline, idUser));
						break;
					case "btPlanes":
						loadPanel(new PanelAviones());
						break;
					case "btPilots":
						loadPanel(new PilotPanel());
						break;
					case "btFlights":
						loadPanel(new FlightsPanel(idAirline, idUser, permissions));
						break;
					default:
						MessageBox.Show("Botón no reconocido.");
						break;
				}
			}
		}

		public void loadPanel(object panel) {
			if (this.pMain.Controls.Count > 0) {
				this.pMain.Controls.RemoveAt(0);
			}
			Form f = panel as Form;
			f.TopLevel = false;
			f.Dock = DockStyle.Fill;
			this.pMain.Controls.Add(f);
			this.pMain.Tag = f;
			f.Show();
		}

	}
}

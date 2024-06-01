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
		List<int> permisos;
		int idAerolinea;
		LoginForm view;

		public MainMenuForm(LoginForm pView, string pIdUser, List<int> pPermisos, int pIdAerolinea) {
			this.view = pView;
			this.idUser = pIdUser;
			this.idAerolinea = pIdAerolinea;
			this.permisos = pPermisos;
			this.subMenuMan = false;
			InitializeComponent();
			this.btMantenimiento.Enabled = false;
			this.btAerolineas.Enabled	 = false;
			this.btReportes.Enabled		 = false;
			this.btVuelos.Enabled		 = false;
			loadPanel(new HomePanel());
			gestionarPermisos();
		}

		private void gestionarPermisos() {

			if (permisos.IndexOf(1) != -1) {
				this.btAerolineas.Enabled = true;
			}
			if (permisos.IndexOf(2) != -1) {
				this.btVuelos.Enabled = true;
			}
			if (permisos.IndexOf(3) != -1) {
				this.btMantenimiento.Enabled = true;
			}
			if (permisos.IndexOf(4) != -1) {
				this.btReportes.Enabled = true;
			}
		}
		

		private void btMin_Click(object sender, MouseEventArgs e) {
			this.WindowState = FormWindowState.Minimized;
		}

		private void btExit_Click(object sender, MouseEventArgs e) {
			String mensaje = "¿Desea cerrar la aplicación?";
			DialogResult resultado = MessageBox.Show(mensaje, "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (resultado == DialogResult.Yes) {
				this.Close();
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
			pMantenimiento.Visible = true;
		}

		private void btMantenimiento_MouseLeave(object sender, EventArgs e) {
			btn_MouseLeave(sender, e);
			subMenuMan = false;
			hideSubMenu();
		}

		private async void hideSubMenu() {
			await Task.Delay(150);
			if (!subMenuMan) {
				pMantenimiento.Visible = false;
			}
		}

		private void bt_Click(object sender, EventArgs e) {
			Button btn = sender as Button;

			if (btn != null) {
				switch (btn.Name) {
					case "btAerolineas":
						loadPanel(new PanelAerolineas());
						break;
					case "btReportes":
						loadPanel(new PanelReportes());
						break;
					case "btMantenimiento":
						loadPanel(new PanelMantenimiento());
						break;
					case "btInicio":
						loadPanel(new HomePanel());
						break;
					case "btAviones":
						loadPanel(new PanelAviones());
						break;
					case "btPilotos":
						loadPanel(new PanelPilotos());
						break;
					case "btVuelos":
						loadPanel(new FlightsPanel());
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

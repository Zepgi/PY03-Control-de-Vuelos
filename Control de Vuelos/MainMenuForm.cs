﻿using System;
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
		LoginForm view;

		public MainMenuForm(LoginForm pView, string pIdUser) {
			this.view = pView;
			this.idUser = pIdUser;
			this.subMenuMan = false;
			InitializeComponent();
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

		private void btAerolineas_Click(object sender, EventArgs e) {
			loadPanel(new PanelAerolineas());
		}

		private void btReportes_Click(object sender, EventArgs e) {
			loadPanel(new PanelReportes());
		}

		private void btMantenimiento_Click(object sender, EventArgs e) {
			loadPanel(new PanelMantenimiento());
		}

		private void btInicio_Click(object sender, EventArgs e) {
			loadPanel(new PanelInicio());
		}

		private void btAviones_Click(object sender, EventArgs e) {
			loadPanel(new PanelAviones());
		}

		private void btPilotos_Click(object sender, EventArgs e) {
			loadPanel(new PanelPilotos());
		}

		private void btVuelos_Click(object sender, EventArgs e) {
			loadPanel(new PanelVuelos());
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

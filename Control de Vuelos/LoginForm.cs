using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Vuelos {
	public partial class LoginForm : Form {

		DatabaseConnection conn;
		public LoginForm() {
			InitializeComponent();

			this.pLogin.Paint += new PaintEventHandler(createLines);
			conn = new DatabaseConnection();
		}

		public void createLines(object sender, PaintEventArgs e) {
			Pen pen = new Pen(Color.White, 1);
			PointF pnt1 = new PointF(35, this.txtAccount.Location.Y+22);
			PointF pnt2 = new PointF(265, this.txtAccount.Location.Y+22);
			e.Graphics.DrawLine(pen, pnt1, pnt2);

			PointF pnt4 = new PointF(35, this.txtPassword.Location.Y+22);
			PointF pnt3 = new PointF(265, this.txtPassword.Location.Y+22);
			e.Graphics.DrawLine(pen, pnt3, pnt4);
		}

		private void btLogin_Click(object sender, EventArgs e) {
			string email = Regex.Replace(txtAccount.Text, @"\s+", "");
			string contrasenia = Regex.Replace(txtPassword.Text, @"\s+", "");

			if (email == "" || email == null) {
				MessageBox.Show("Ingrese una cuenta. Inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (contrasenia == "" || contrasenia == null) {
				MessageBox.Show("Ingrese una contraseña. Inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			SqlCommand command = new SqlCommand("Verificar_Credenciales", conn.ConnectDB);
			command.CommandType = CommandType.StoredProcedure;
			command.Parameters.AddWithValue("@email", email);
			command.Parameters.AddWithValue("@contrasenia", contrasenia);

			try {
				conn.open();
				object idResult = command.ExecuteScalar();

				if (idResult != null) {
					this.Hide();

					string idUsuario = idResult.ToString();
					List<int> permisos = new List<int>();
					int idAerolinea = 0;

					SqlCommand listaPermisos = new SqlCommand("SELECT idPermiso, idAerolinea " +
															"FROM getPermisos(@idUsuario)", conn.ConnectDB);
					listaPermisos.Parameters.AddWithValue("@idUsuario", idUsuario);

					SqlDataAdapter adapter = new SqlDataAdapter(listaPermisos);
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);

					foreach (DataRow row in dataTable.Rows) {
						permisos.Add(Convert.ToInt32(row["idPermiso"]));
						if (row["idAerolinea"] == DBNull.Value) {
							continue;
						}
						idAerolinea = Convert.ToInt32(row["idAerolinea"]);
					}

					MainMenuForm mainMenu = new MainMenuForm(this, idResult.ToString(), permisos, idAerolinea);
					mainMenu.Show();
				} else {
					MessageBox.Show("Cuenta o contraseña incorrectos. Inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} catch (Exception ex) {
				MessageBox.Show("Ocurrió un error durante el inicio de sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				conn.close();
			}
		}

		private void txtAccount_Click(object sender, EventArgs e) {
			if (this.txtAccount.Text == "Usuario") {
				this.txtAccount.Text = "";
			}
		}

		private void txtAccount_Leave(object sender, EventArgs e) {
			if (this.txtAccount.Text == "") {
				this.txtAccount.Text = "Usuario";
			}
		}

		private void txtPassword_Click(object sender, EventArgs e) {
			if (this.txtPassword.Text == "Contraseña") {
				this.txtPassword.Text = "";
				this.txtPassword.UseSystemPasswordChar = true;
			}
		}

		private void txtPassword_Leave(object sender, EventArgs e) {
			if (this.txtPassword.Text == "") {
				this.txtPassword.UseSystemPasswordChar = false;
				this.txtPassword.Text = "Contraseña";
			}
		}
	}
}

using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace Control_de_Vuelos {
	partial class LoginForm {
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent() {
			this.btLogin = new Guna.UI2.WinForms.Guna2Button();
			this.lbLogin = new System.Windows.Forms.Label();
			this.pInputArea = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.pLogin = new System.Windows.Forms.Panel();
			this.txtAccount = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pInputArea.SuspendLayout();
			this.pLogin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btLogin
			// 
			this.btLogin.AutoRoundedCorners = true;
			this.btLogin.BackColor = System.Drawing.Color.Transparent;
			this.btLogin.BorderColor = System.Drawing.Color.White;
			this.btLogin.BorderRadius = 22;
			this.btLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btLogin.ForeColor = System.Drawing.Color.White;
			this.btLogin.Location = new System.Drawing.Point(144, 406);
			this.btLogin.Name = "btLogin";
			this.btLogin.PressedColor = System.Drawing.Color.Teal;
			this.btLogin.ShadowDecoration.BorderRadius = 0;
			this.btLogin.ShadowDecoration.Depth = 5;
			this.btLogin.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btLogin.Size = new System.Drawing.Size(120, 46);
			this.btLogin.TabIndex = 4;
			this.btLogin.Text = "Entrar";
			this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
			// 
			// lbLogin
			// 
			this.lbLogin.AutoSize = true;
			this.lbLogin.BackColor = System.Drawing.Color.Transparent;
			this.lbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbLogin.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLogin.ForeColor = System.Drawing.Color.Black;
			this.lbLogin.Location = new System.Drawing.Point(55, 137);
			this.lbLogin.Name = "lbLogin";
			this.lbLogin.Size = new System.Drawing.Size(299, 44);
			this.lbLogin.TabIndex = 0;
			this.lbLogin.Text = "Inicio de Sesión";
			// 
			// pInputArea
			// 
			this.pInputArea.BackColor = System.Drawing.Color.Transparent;
			this.pInputArea.Controls.Add(this.pictureBox1);
			this.pInputArea.Controls.Add(this.btLogin);
			this.pInputArea.Controls.Add(this.lbLogin);
			this.pInputArea.Controls.Add(this.pLogin);
			this.pInputArea.FillColor = System.Drawing.Color.White;
			this.pInputArea.Location = new System.Drawing.Point(420, 145);
			this.pInputArea.Name = "pInputArea";
			this.pInputArea.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pInputArea.ShadowDepth = 60;
			this.pInputArea.ShadowShift = 10;
			this.pInputArea.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pInputArea.Size = new System.Drawing.Size(420, 500);
			this.pInputArea.TabIndex = 8;
			// 
			// pLogin
			// 
			this.pLogin.Controls.Add(this.txtAccount);
			this.pLogin.Controls.Add(this.txtPassword);
			this.pLogin.Location = new System.Drawing.Point(25, 209);
			this.pLogin.Name = "pLogin";
			this.pLogin.Size = new System.Drawing.Size(358, 150);
			this.pLogin.TabIndex = 3;
			// 
			// txtAccount
			// 
			this.txtAccount.BackColor = System.Drawing.Color.White;
			this.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAccount.ForeColor = System.Drawing.Color.Black;
			this.txtAccount.Location = new System.Drawing.Point(30, 20);
			this.txtAccount.Name = "txtAccount";
			this.txtAccount.Size = new System.Drawing.Size(300, 25);
			this.txtAccount.TabIndex = 1;
			this.txtAccount.Text = "Cuenta";
			this.txtAccount.Enter += new System.EventHandler(this.txtAccount_Click);
			this.txtAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressedEnter_Listener);
			this.txtAccount.Leave += new System.EventHandler(this.txtAccount_Leave);
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.White;
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.ForeColor = System.Drawing.Color.Black;
			this.txtPassword.Location = new System.Drawing.Point(30, 80);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(300, 25);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.Text = "Contraseña";
			this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Click);
			this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressedEnter_Listener);
			this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Control_de_Vuelos.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(144, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 120);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.BackgroundImage = global::Control_de_Vuelos.Properties.Resources.bg_login;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1222, 798);
			this.Controls.Add(this.pInputArea);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.pInputArea.ResumeLayout(false);
			this.pInputArea.PerformLayout();
			this.pLogin.ResumeLayout(false);
			this.pLogin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Guna2Button  btLogin;
		private System.Windows.Forms.Label lbLogin;
		private Guna2ShadowPanel pInputArea;
		private System.Windows.Forms.Panel pLogin;
		private System.Windows.Forms.TextBox txtAccount;
		private System.Windows.Forms.TextBox txtPassword;
		private PictureBox pictureBox1;
	}
}


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
			this.label1 = new System.Windows.Forms.Label();
			this.pInput = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.pLogin = new System.Windows.Forms.Panel();
			this.txtAccount = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.pInput.SuspendLayout();
			this.pLogin.SuspendLayout();
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
			this.btLogin.ShadowDecoration.BorderRadius = 30;
			this.btLogin.ShadowDecoration.Depth = 5;
			this.btLogin.ShadowDecoration.Enabled = true;
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
			this.lbLogin.Location = new System.Drawing.Point(55, 118);
			this.lbLogin.Name = "lbLogin";
			this.lbLogin.Size = new System.Drawing.Size(299, 44);
			this.lbLogin.TabIndex = 0;
			this.lbLogin.Text = "Inicio de Sesión";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(163, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "[LOGO]";
			// 
			// pInput
			// 
			this.pInput.BackColor = System.Drawing.Color.Transparent;
			this.pInput.Controls.Add(this.btLogin);
			this.pInput.Controls.Add(this.lbLogin);
			this.pInput.Controls.Add(this.pLogin);
			this.pInput.Controls.Add(this.label1);
			this.pInput.FillColor = System.Drawing.Color.White;
			this.pInput.Location = new System.Drawing.Point(420, 145);
			this.pInput.Name = "pInput";
			this.pInput.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pInput.ShadowDepth = 60;
			this.pInput.ShadowShift = 10;
			this.pInput.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pInput.Size = new System.Drawing.Size(420, 500);
			this.pInput.TabIndex = 8;
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
			this.txtAccount.Text = "Usuario";
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
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.BackgroundImage = global::Control_de_Vuelos.Properties.Resources.bg_login;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1222, 798);
			this.Controls.Add(this.pInput);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.pInput.ResumeLayout(false);
			this.pInput.PerformLayout();
			this.pLogin.ResumeLayout(false);
			this.pLogin.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private Guna2Button  btLogin;
		private System.Windows.Forms.Label lbLogin;
		private System.Windows.Forms.Label label1;
		private Guna2ShadowPanel pInput;
		private System.Windows.Forms.Panel pLogin;
		private System.Windows.Forms.TextBox txtAccount;
		private System.Windows.Forms.TextBox txtPassword;
	}
}


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
			this.lbLogin = new System.Windows.Forms.Label();
			this.txtAccount = new System.Windows.Forms.TextBox();
			this.pLogin = new System.Windows.Forms.Panel();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btLogin = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pLogin.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbLogin
			// 
			this.lbLogin.AutoSize = true;
			this.lbLogin.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLogin.Location = new System.Drawing.Point(150, 200);
			this.lbLogin.Name = "lbLogin";
			this.lbLogin.Size = new System.Drawing.Size(299, 44);
			this.lbLogin.TabIndex = 0;
			this.lbLogin.Text = "Inicio de Sesión";
			// 
			// txtAccount
			// 
			this.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAccount.ForeColor = System.Drawing.Color.Silver;
			this.txtAccount.Location = new System.Drawing.Point(50, 20);
			this.txtAccount.Name = "txtAccount";
			this.txtAccount.Size = new System.Drawing.Size(300, 25);
			this.txtAccount.TabIndex = 1;
			this.txtAccount.Text = "Usuario";
			this.txtAccount.Enter += new System.EventHandler(this.txtAccount_Click);
			this.txtAccount.Leave += new System.EventHandler(this.txtAccount_Leave);
			// 
			// pLogin
			// 
			this.pLogin.Controls.Add(this.txtAccount);
			this.pLogin.Controls.Add(this.txtPassword);
			this.pLogin.Location = new System.Drawing.Point(100, 300);
			this.pLogin.Name = "pLogin";
			this.pLogin.Size = new System.Drawing.Size(400, 150);
			this.pLogin.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.ForeColor = System.Drawing.Color.Silver;
			this.txtPassword.Location = new System.Drawing.Point(50, 80);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(300, 25);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.Text = "Contraseña";
			this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Click);
			this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
			// 
			// btLogin
			// 
			this.btLogin.Location = new System.Drawing.Point(250, 500);
			this.btLogin.Name = "btLogin";
			this.btLogin.Size = new System.Drawing.Size(100, 30);
			this.btLogin.TabIndex = 4;
			this.btLogin.Text = "Entrar";
			this.btLogin.UseVisualStyleBackColor = true;
			this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(259, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "[LOGO]";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(582, 603);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btLogin);
			this.Controls.Add(this.pLogin);
			this.Controls.Add(this.lbLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.pLogin.ResumeLayout(false);
			this.pLogin.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbLogin;
		private System.Windows.Forms.TextBox txtAccount;
		private System.Windows.Forms.Panel pLogin;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btLogin;
		private System.Windows.Forms.Label label1;
	}
}


namespace Control_de_Vuelos {
	partial class PanelAviones {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewAirPlanes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.textBoxMatricula = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxMarcaAvion = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxCantPasajeros = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonDeleteAirPlane = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCreateAirPlane = new Guna.UI2.WinForms.Guna2Button();
            this.buttonModifyView = new Guna.UI2.WinForms.Guna2Button();
            this.buttonModifyAirPlane = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAirPlanes
            // 
            this.dataGridViewAirPlanes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAirPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAirPlanes.Location = new System.Drawing.Point(466, 47);
            this.dataGridViewAirPlanes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAirPlanes.Name = "dataGridViewAirPlanes";
            this.dataGridViewAirPlanes.RowHeadersWidth = 51;
            this.dataGridViewAirPlanes.RowTemplate.Height = 24;
            this.dataGridViewAirPlanes.Size = new System.Drawing.Size(447, 472);
            this.dataGridViewAirPlanes.TabIndex = 27;
            this.dataGridViewAirPlanes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAirPlanes_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(202, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label3.Location = new System.Drawing.Point(193, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Matricula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label1.Location = new System.Drawing.Point(180, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cant.Pasajeros";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.AutoRoundedCorners = true;
            this.textBoxMatricula.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.textBoxMatricula.BorderRadius = 16;
            this.textBoxMatricula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMatricula.DefaultText = "";
            this.textBoxMatricula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxMatricula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxMatricula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMatricula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMatricula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMatricula.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBoxMatricula.ForeColor = System.Drawing.Color.Black;
            this.textBoxMatricula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMatricula.Location = new System.Drawing.Point(125, 150);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.PasswordChar = '\0';
            this.textBoxMatricula.PlaceholderText = "";
            this.textBoxMatricula.SelectedText = "";
            this.textBoxMatricula.Size = new System.Drawing.Size(218, 35);
            this.textBoxMatricula.TabIndex = 33;
            // 
            // textBoxMarcaAvion
            // 
            this.textBoxMarcaAvion.AutoRoundedCorners = true;
            this.textBoxMarcaAvion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.textBoxMarcaAvion.BorderRadius = 16;
            this.textBoxMarcaAvion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMarcaAvion.DefaultText = "";
            this.textBoxMarcaAvion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxMarcaAvion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxMarcaAvion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMarcaAvion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMarcaAvion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMarcaAvion.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBoxMarcaAvion.ForeColor = System.Drawing.Color.Black;
            this.textBoxMarcaAvion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMarcaAvion.Location = new System.Drawing.Point(125, 226);
            this.textBoxMarcaAvion.Name = "textBoxMarcaAvion";
            this.textBoxMarcaAvion.PasswordChar = '\0';
            this.textBoxMarcaAvion.PlaceholderText = "";
            this.textBoxMarcaAvion.SelectedText = "";
            this.textBoxMarcaAvion.Size = new System.Drawing.Size(218, 35);
            this.textBoxMarcaAvion.TabIndex = 34;
            // 
            // textBoxCantPasajeros
            // 
            this.textBoxCantPasajeros.AutoRoundedCorners = true;
            this.textBoxCantPasajeros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.textBoxCantPasajeros.BorderRadius = 16;
            this.textBoxCantPasajeros.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCantPasajeros.DefaultText = "";
            this.textBoxCantPasajeros.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxCantPasajeros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxCantPasajeros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCantPasajeros.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCantPasajeros.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCantPasajeros.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBoxCantPasajeros.ForeColor = System.Drawing.Color.Black;
            this.textBoxCantPasajeros.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCantPasajeros.Location = new System.Drawing.Point(125, 305);
            this.textBoxCantPasajeros.Name = "textBoxCantPasajeros";
            this.textBoxCantPasajeros.PasswordChar = '\0';
            this.textBoxCantPasajeros.PlaceholderText = "";
            this.textBoxCantPasajeros.SelectedText = "";
            this.textBoxCantPasajeros.Size = new System.Drawing.Size(218, 35);
            this.textBoxCantPasajeros.TabIndex = 35;
            // 
            // buttonDeleteAirPlane
            // 
            this.buttonDeleteAirPlane.Animated = true;
            this.buttonDeleteAirPlane.AutoRoundedCorners = true;
            this.buttonDeleteAirPlane.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteAirPlane.BorderColor = System.Drawing.Color.White;
            this.buttonDeleteAirPlane.BorderRadius = 17;
            this.buttonDeleteAirPlane.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDeleteAirPlane.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDeleteAirPlane.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDeleteAirPlane.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDeleteAirPlane.FillColor = System.Drawing.Color.Red;
            this.buttonDeleteAirPlane.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteAirPlane.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteAirPlane.Location = new System.Drawing.Point(47, 369);
            this.buttonDeleteAirPlane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteAirPlane.Name = "buttonDeleteAirPlane";
            this.buttonDeleteAirPlane.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDeleteAirPlane.Size = new System.Drawing.Size(181, 37);
            this.buttonDeleteAirPlane.TabIndex = 36;
            this.buttonDeleteAirPlane.Text = "Eliminar";
            this.buttonDeleteAirPlane.Visible = false;
            this.buttonDeleteAirPlane.Click += new System.EventHandler(this.buttonDeleteAirPlane_Click_1);
            // 
            // buttonCreateAirPlane
            // 
            this.buttonCreateAirPlane.Animated = true;
            this.buttonCreateAirPlane.AutoRoundedCorners = true;
            this.buttonCreateAirPlane.BackColor = System.Drawing.Color.Transparent;
            this.buttonCreateAirPlane.BorderColor = System.Drawing.Color.White;
            this.buttonCreateAirPlane.BorderRadius = 17;
            this.buttonCreateAirPlane.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCreateAirPlane.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCreateAirPlane.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCreateAirPlane.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCreateAirPlane.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.buttonCreateAirPlane.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonCreateAirPlane.ForeColor = System.Drawing.Color.White;
            this.buttonCreateAirPlane.Location = new System.Drawing.Point(47, 369);
            this.buttonCreateAirPlane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateAirPlane.Name = "buttonCreateAirPlane";
            this.buttonCreateAirPlane.PressedColor = System.Drawing.Color.Teal;
            this.buttonCreateAirPlane.Size = new System.Drawing.Size(181, 37);
            this.buttonCreateAirPlane.TabIndex = 37;
            this.buttonCreateAirPlane.Text = "Crear Avión";
            this.buttonCreateAirPlane.Click += new System.EventHandler(this.buttonCreateAirPlane_Click_1);
            // 
            // buttonModifyView
            // 
            this.buttonModifyView.Animated = true;
            this.buttonModifyView.AutoRoundedCorners = true;
            this.buttonModifyView.BackColor = System.Drawing.Color.Transparent;
            this.buttonModifyView.BorderColor = System.Drawing.Color.White;
            this.buttonModifyView.BorderRadius = 17;
            this.buttonModifyView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonModifyView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonModifyView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonModifyView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonModifyView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.buttonModifyView.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonModifyView.ForeColor = System.Drawing.Color.White;
            this.buttonModifyView.Location = new System.Drawing.Point(242, 369);
            this.buttonModifyView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModifyView.Name = "buttonModifyView";
            this.buttonModifyView.PressedColor = System.Drawing.Color.Teal;
            this.buttonModifyView.Size = new System.Drawing.Size(181, 37);
            this.buttonModifyView.TabIndex = 38;
            this.buttonModifyView.Text = "Modificar";
            this.buttonModifyView.Visible = false;
            this.buttonModifyView.Click += new System.EventHandler(this.buttonModifyView_Click_1);
            // 
            // buttonModifyAirPlane
            // 
            this.buttonModifyAirPlane.Animated = true;
            this.buttonModifyAirPlane.AutoRoundedCorners = true;
            this.buttonModifyAirPlane.BackColor = System.Drawing.Color.Transparent;
            this.buttonModifyAirPlane.BorderColor = System.Drawing.Color.White;
            this.buttonModifyAirPlane.BorderRadius = 17;
            this.buttonModifyAirPlane.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonModifyAirPlane.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonModifyAirPlane.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonModifyAirPlane.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonModifyAirPlane.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.buttonModifyAirPlane.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonModifyAirPlane.ForeColor = System.Drawing.Color.White;
            this.buttonModifyAirPlane.Location = new System.Drawing.Point(242, 369);
            this.buttonModifyAirPlane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModifyAirPlane.Name = "buttonModifyAirPlane";
            this.buttonModifyAirPlane.PressedColor = System.Drawing.Color.Teal;
            this.buttonModifyAirPlane.Size = new System.Drawing.Size(181, 37);
            this.buttonModifyAirPlane.TabIndex = 39;
            this.buttonModifyAirPlane.Text = "Modificar Aviones";
            this.buttonModifyAirPlane.Visible = false;
            this.buttonModifyAirPlane.Click += new System.EventHandler(this.buttonModifyAirPlane_Click_1);
            // 
            // PanelAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(976, 582);
            this.Controls.Add(this.buttonModifyAirPlane);
            this.Controls.Add(this.buttonModifyView);
            this.Controls.Add(this.buttonCreateAirPlane);
            this.Controls.Add(this.buttonDeleteAirPlane);
            this.Controls.Add(this.textBoxCantPasajeros);
            this.Controls.Add(this.textBoxMarcaAvion);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAirPlanes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(976, 582);
            this.MinimumSize = new System.Drawing.Size(976, 582);
            this.Name = "PanelAviones";
            this.Text = "PanelAviones";
            this.Load += new System.EventHandler(this.PanelAviones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAirPlanes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxMatricula;
        private Guna.UI2.WinForms.Guna2TextBox textBoxMarcaAvion;
        private Guna.UI2.WinForms.Guna2TextBox textBoxCantPasajeros;
        private Guna.UI2.WinForms.Guna2Button buttonDeleteAirPlane;
        private Guna.UI2.WinForms.Guna2Button buttonCreateAirPlane;
        private Guna.UI2.WinForms.Guna2Button buttonModifyView;
        private Guna.UI2.WinForms.Guna2Button buttonModifyAirPlane;
    }
}
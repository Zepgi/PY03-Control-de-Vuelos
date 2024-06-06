namespace Control_de_Vuelos {
	partial class PanelAerolineas {
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
            this.dataGridViewAirlines = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.airlineB = new Guna.UI2.WinForms.Guna2Button();
            this.airlineLabel = new System.Windows.Forms.Label();
            this.searchAirLine = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxNombreAerolinea = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxLemaAerolinea = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonDeleteAirline = new Guna.UI2.WinForms.Guna2Button();
            this.buttonModifyView = new Guna.UI2.WinForms.Guna2Button();
            this.buttonModifyAirline = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCreateAirline = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirlines)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAirlines
            // 
            this.dataGridViewAirlines.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAirlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAirlines.Location = new System.Drawing.Point(556, 50);
            this.dataGridViewAirlines.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAirlines.Name = "dataGridViewAirlines";
            this.dataGridViewAirlines.RowHeadersWidth = 51;
            this.dataGridViewAirlines.RowTemplate.Height = 24;
            this.dataGridViewAirlines.Size = new System.Drawing.Size(370, 398);
            this.dataGridViewAirlines.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(85, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lema de la aerolinea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label3.Location = new System.Drawing.Point(85, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre de la aerolinea";
            // 
            // airlineB
            // 
            this.airlineB.Animated = true;
            this.airlineB.AutoRoundedCorners = true;
            this.airlineB.BackColor = System.Drawing.Color.Transparent;
            this.airlineB.BorderColor = System.Drawing.Color.White;
            this.airlineB.BorderRadius = 17;
            this.airlineB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.airlineB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.airlineB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.airlineB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.airlineB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.airlineB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.airlineB.ForeColor = System.Drawing.Color.White;
            this.airlineB.Location = new System.Drawing.Point(714, 495);
            this.airlineB.Margin = new System.Windows.Forms.Padding(2);
            this.airlineB.Name = "airlineB";
            this.airlineB.PressedColor = System.Drawing.Color.Teal;
            this.airlineB.Size = new System.Drawing.Size(39, 37);
            this.airlineB.TabIndex = 23;
            this.airlineB.Text = "🔍";
            this.airlineB.Click += new System.EventHandler(this.airlineB_Click);
            // 
            // airlineLabel
            // 
            this.airlineLabel.AutoSize = true;
            this.airlineLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.airlineLabel.Location = new System.Drawing.Point(553, 463);
            this.airlineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.airlineLabel.Name = "airlineLabel";
            this.airlineLabel.Size = new System.Drawing.Size(157, 19);
            this.airlineLabel.TabIndex = 21;
            this.airlineLabel.Text = "Nombre de aerolinea";
            // 
            // searchAirLine
            // 
            this.searchAirLine.AutoRoundedCorners = true;
            this.searchAirLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.searchAirLine.BorderRadius = 17;
            this.searchAirLine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchAirLine.DefaultText = "";
            this.searchAirLine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchAirLine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchAirLine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchAirLine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchAirLine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchAirLine.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.searchAirLine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchAirLine.Location = new System.Drawing.Point(556, 495);
            this.searchAirLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchAirLine.Name = "searchAirLine";
            this.searchAirLine.PasswordChar = '\0';
            this.searchAirLine.PlaceholderText = "";
            this.searchAirLine.SelectedText = "";
            this.searchAirLine.Size = new System.Drawing.Size(145, 36);
            this.searchAirLine.TabIndex = 24;
            // 
            // textBoxNombreAerolinea
            // 
            this.textBoxNombreAerolinea.AutoRoundedCorners = true;
            this.textBoxNombreAerolinea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.textBoxNombreAerolinea.BorderRadius = 16;
            this.textBoxNombreAerolinea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNombreAerolinea.DefaultText = "";
            this.textBoxNombreAerolinea.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNombreAerolinea.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNombreAerolinea.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNombreAerolinea.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNombreAerolinea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNombreAerolinea.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBoxNombreAerolinea.ForeColor = System.Drawing.Color.Black;
            this.textBoxNombreAerolinea.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNombreAerolinea.Location = new System.Drawing.Point(88, 168);
            this.textBoxNombreAerolinea.Name = "textBoxNombreAerolinea";
            this.textBoxNombreAerolinea.PasswordChar = '\0';
            this.textBoxNombreAerolinea.PlaceholderText = "";
            this.textBoxNombreAerolinea.SelectedText = "";
            this.textBoxNombreAerolinea.Size = new System.Drawing.Size(286, 35);
            this.textBoxNombreAerolinea.TabIndex = 25;
            // 
            // textBoxLemaAerolinea
            // 
            this.textBoxLemaAerolinea.AutoRoundedCorners = true;
            this.textBoxLemaAerolinea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.textBoxLemaAerolinea.BorderRadius = 16;
            this.textBoxLemaAerolinea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLemaAerolinea.DefaultText = "";
            this.textBoxLemaAerolinea.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxLemaAerolinea.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxLemaAerolinea.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLemaAerolinea.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLemaAerolinea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLemaAerolinea.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBoxLemaAerolinea.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLemaAerolinea.Location = new System.Drawing.Point(88, 265);
            this.textBoxLemaAerolinea.Name = "textBoxLemaAerolinea";
            this.textBoxLemaAerolinea.PasswordChar = '\0';
            this.textBoxLemaAerolinea.PlaceholderText = "";
            this.textBoxLemaAerolinea.SelectedText = "";
            this.textBoxLemaAerolinea.Size = new System.Drawing.Size(400, 35);
            this.textBoxLemaAerolinea.TabIndex = 26;
            // 
            // buttonDeleteAirline
            // 
            this.buttonDeleteAirline.Animated = true;
            this.buttonDeleteAirline.AutoRoundedCorners = true;
            this.buttonDeleteAirline.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteAirline.BorderColor = System.Drawing.Color.White;
            this.buttonDeleteAirline.BorderRadius = 17;
            this.buttonDeleteAirline.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDeleteAirline.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDeleteAirline.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDeleteAirline.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDeleteAirline.FillColor = System.Drawing.Color.Red;
            this.buttonDeleteAirline.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteAirline.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteAirline.Location = new System.Drawing.Point(86, 330);
            this.buttonDeleteAirline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteAirline.Name = "buttonDeleteAirline";
            this.buttonDeleteAirline.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDeleteAirline.Size = new System.Drawing.Size(181, 37);
            this.buttonDeleteAirline.TabIndex = 27;
            this.buttonDeleteAirline.Text = "Eliminar";
            this.buttonDeleteAirline.Visible = false;
            this.buttonDeleteAirline.Click += new System.EventHandler(this.buttonDeleteAirline_Click_1);
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
            this.buttonModifyView.Location = new System.Drawing.Point(307, 330);
            this.buttonModifyView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModifyView.Name = "buttonModifyView";
            this.buttonModifyView.PressedColor = System.Drawing.Color.Teal;
            this.buttonModifyView.Size = new System.Drawing.Size(181, 37);
            this.buttonModifyView.TabIndex = 28;
            this.buttonModifyView.Text = "Modificar";
            this.buttonModifyView.Visible = false;
            this.buttonModifyView.Click += new System.EventHandler(this.buttonModifyView_Click_1);
            // 
            // buttonModifyAirline
            // 
            this.buttonModifyAirline.Animated = true;
            this.buttonModifyAirline.AutoRoundedCorners = true;
            this.buttonModifyAirline.BackColor = System.Drawing.Color.Transparent;
            this.buttonModifyAirline.BorderColor = System.Drawing.Color.White;
            this.buttonModifyAirline.BorderRadius = 17;
            this.buttonModifyAirline.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonModifyAirline.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonModifyAirline.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonModifyAirline.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonModifyAirline.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.buttonModifyAirline.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonModifyAirline.ForeColor = System.Drawing.Color.White;
            this.buttonModifyAirline.Location = new System.Drawing.Point(307, 330);
            this.buttonModifyAirline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModifyAirline.Name = "buttonModifyAirline";
            this.buttonModifyAirline.PressedColor = System.Drawing.Color.Teal;
            this.buttonModifyAirline.Size = new System.Drawing.Size(181, 37);
            this.buttonModifyAirline.TabIndex = 29;
            this.buttonModifyAirline.Text = "Modificar Aerolinea";
            this.buttonModifyAirline.Visible = false;
            this.buttonModifyAirline.Click += new System.EventHandler(this.buttonModifyAirline_Click_1);
            // 
            // buttonCreateAirline
            // 
            this.buttonCreateAirline.Animated = true;
            this.buttonCreateAirline.AutoRoundedCorners = true;
            this.buttonCreateAirline.BackColor = System.Drawing.Color.Transparent;
            this.buttonCreateAirline.BorderColor = System.Drawing.Color.White;
            this.buttonCreateAirline.BorderRadius = 17;
            this.buttonCreateAirline.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCreateAirline.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCreateAirline.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCreateAirline.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCreateAirline.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.buttonCreateAirline.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonCreateAirline.ForeColor = System.Drawing.Color.White;
            this.buttonCreateAirline.Location = new System.Drawing.Point(86, 330);
            this.buttonCreateAirline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateAirline.Name = "buttonCreateAirline";
            this.buttonCreateAirline.PressedColor = System.Drawing.Color.Teal;
            this.buttonCreateAirline.Size = new System.Drawing.Size(181, 37);
            this.buttonCreateAirline.TabIndex = 30;
            this.buttonCreateAirline.Text = "Crear Aerolinea";
            this.buttonCreateAirline.Click += new System.EventHandler(this.buttonCreateAirline_Click_1);
            // 
            // PanelAerolineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 582);
            this.Controls.Add(this.buttonCreateAirline);
            this.Controls.Add(this.buttonModifyAirline);
            this.Controls.Add(this.buttonModifyView);
            this.Controls.Add(this.buttonDeleteAirline);
            this.Controls.Add(this.textBoxLemaAerolinea);
            this.Controls.Add(this.textBoxNombreAerolinea);
            this.Controls.Add(this.searchAirLine);
            this.Controls.Add(this.airlineB);
            this.Controls.Add(this.airlineLabel);
            this.Controls.Add(this.dataGridViewAirlines);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(976, 582);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(976, 582);
            this.Name = "PanelAerolineas";
            this.Text = "PanelAerolineas";
            this.Load += new System.EventHandler(this.PanelAerolineas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirlines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.DataGridView dataGridViewAirlines;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button airlineB;
        private System.Windows.Forms.Label airlineLabel;
        private Guna.UI2.WinForms.Guna2TextBox searchAirLine;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNombreAerolinea;
        private Guna.UI2.WinForms.Guna2TextBox textBoxLemaAerolinea;
        private Guna.UI2.WinForms.Guna2Button buttonDeleteAirline;
        private Guna.UI2.WinForms.Guna2Button buttonModifyView;
        private Guna.UI2.WinForms.Guna2Button buttonModifyAirline;
        private Guna.UI2.WinForms.Guna2Button buttonCreateAirline;
    }
}
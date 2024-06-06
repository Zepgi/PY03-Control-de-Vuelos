namespace Control_de_Vuelos {
	partial class PanelReportes {
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
            this.dataGridViewAirPlanes_AirLines = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewAire8 = new System.Windows.Forms.DataGridView();
            this.searchAirLine3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.airline3 = new Guna.UI2.WinForms.Guna2Button();
            this.airlineLabel = new System.Windows.Forms.Label();
            this.guna2TextBoxAir8 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ButtonAir8 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewAir1 = new System.Windows.Forms.DataGridView();
            this.dtDepartureDate1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.buttonCheckFlys1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirPlanes_AirLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAire8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAir1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAirPlanes_AirLines
            // 
            this.dataGridViewAirPlanes_AirLines.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAirPlanes_AirLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAirPlanes_AirLines.Location = new System.Drawing.Point(12, 791);
            this.dataGridViewAirPlanes_AirLines.Name = "dataGridViewAirPlanes_AirLines";
            this.dataGridViewAirPlanes_AirLines.Size = new System.Drawing.Size(370, 214);
            this.dataGridViewAirPlanes_AirLines.TabIndex = 10;
            this.dataGridViewAirPlanes_AirLines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAirPlanes_AirLines_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 750);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Aviones por aerolineas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 1208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Informacion general de los vuelos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(577, 1455);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 170);
            this.dataGridView1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Vuelos activos por fecha";
            // 
            // dataGridViewAire8
            // 
            this.dataGridViewAire8.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAire8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAire8.Location = new System.Drawing.Point(12, 1258);
            this.dataGridViewAire8.Name = "dataGridViewAire8";
            this.dataGridViewAire8.Size = new System.Drawing.Size(370, 225);
            this.dataGridViewAire8.TabIndex = 17;
            this.dataGridViewAire8.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAire8_CellContentClick);
            // 
            // searchAirLine3
            // 
            this.searchAirLine3.AutoRoundedCorners = true;
            this.searchAirLine3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.searchAirLine3.BorderRadius = 17;
            this.searchAirLine3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchAirLine3.DefaultText = "";
            this.searchAirLine3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchAirLine3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchAirLine3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchAirLine3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchAirLine3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchAirLine3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.searchAirLine3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchAirLine3.Location = new System.Drawing.Point(54, 1054);
            this.searchAirLine3.Margin = new System.Windows.Forms.Padding(4);
            this.searchAirLine3.Name = "searchAirLine3";
            this.searchAirLine3.PasswordChar = '\0';
            this.searchAirLine3.PlaceholderText = "";
            this.searchAirLine3.SelectedText = "";
            this.searchAirLine3.Size = new System.Drawing.Size(145, 36);
            this.searchAirLine3.TabIndex = 27;
            // 
            // airline3
            // 
            this.airline3.Animated = true;
            this.airline3.AutoRoundedCorners = true;
            this.airline3.BackColor = System.Drawing.Color.Transparent;
            this.airline3.BorderColor = System.Drawing.Color.White;
            this.airline3.BorderRadius = 17;
            this.airline3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.airline3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.airline3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.airline3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.airline3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.airline3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.airline3.ForeColor = System.Drawing.Color.White;
            this.airline3.Location = new System.Drawing.Point(212, 1054);
            this.airline3.Margin = new System.Windows.Forms.Padding(2);
            this.airline3.Name = "airline3";
            this.airline3.PressedColor = System.Drawing.Color.Teal;
            this.airline3.Size = new System.Drawing.Size(39, 37);
            this.airline3.TabIndex = 26;
            this.airline3.Text = "🔍";
            this.airline3.Click += new System.EventHandler(this.airline3_Click);
            // 
            // airlineLabel
            // 
            this.airlineLabel.AutoSize = true;
            this.airlineLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.airlineLabel.Location = new System.Drawing.Point(51, 1022);
            this.airlineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.airlineLabel.Name = "airlineLabel";
            this.airlineLabel.Size = new System.Drawing.Size(157, 19);
            this.airlineLabel.TabIndex = 25;
            this.airlineLabel.Text = "Nombre de aerolinea";
            // 
            // guna2TextBoxAir8
            // 
            this.guna2TextBoxAir8.AutoRoundedCorners = true;
            this.guna2TextBoxAir8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.guna2TextBoxAir8.BorderRadius = 17;
            this.guna2TextBoxAir8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxAir8.DefaultText = "";
            this.guna2TextBoxAir8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxAir8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxAir8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAir8.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAir8.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxAir8.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.guna2TextBoxAir8.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxAir8.Location = new System.Drawing.Point(12, 1540);
            this.guna2TextBoxAir8.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBoxAir8.Name = "guna2TextBoxAir8";
            this.guna2TextBoxAir8.PasswordChar = '\0';
            this.guna2TextBoxAir8.PlaceholderText = "";
            this.guna2TextBoxAir8.SelectedText = "";
            this.guna2TextBoxAir8.Size = new System.Drawing.Size(145, 36);
            this.guna2TextBoxAir8.TabIndex = 30;
            // 
            // guna2ButtonAir8
            // 
            this.guna2ButtonAir8.Animated = true;
            this.guna2ButtonAir8.AutoRoundedCorners = true;
            this.guna2ButtonAir8.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonAir8.BorderColor = System.Drawing.Color.White;
            this.guna2ButtonAir8.BorderRadius = 17;
            this.guna2ButtonAir8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAir8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAir8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonAir8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonAir8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.guna2ButtonAir8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonAir8.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonAir8.Location = new System.Drawing.Point(170, 1540);
            this.guna2ButtonAir8.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ButtonAir8.Name = "guna2ButtonAir8";
            this.guna2ButtonAir8.PressedColor = System.Drawing.Color.Teal;
            this.guna2ButtonAir8.Size = new System.Drawing.Size(39, 37);
            this.guna2ButtonAir8.TabIndex = 29;
            this.guna2ButtonAir8.Text = "🔍";
            this.guna2ButtonAir8.Click += new System.EventHandler(this.guna2ButtonAir8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label3.Location = new System.Drawing.Point(9, 1508);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre de aerolinea";
            // 
            // dataGridViewAir1
            // 
            this.dataGridViewAir1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAir1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAir1.Location = new System.Drawing.Point(12, 126);
            this.dataGridViewAir1.Name = "dataGridViewAir1";
            this.dataGridViewAir1.Size = new System.Drawing.Size(370, 214);
            this.dataGridViewAir1.TabIndex = 31;
            // 
            // dtDepartureDate1
            // 
            this.dtDepartureDate1.Animated = true;
            this.dtDepartureDate1.AutoRoundedCorners = true;
            this.dtDepartureDate1.BackColor = System.Drawing.Color.White;
            this.dtDepartureDate1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.dtDepartureDate1.BorderRadius = 15;
            this.dtDepartureDate1.Checked = true;
            this.dtDepartureDate1.FillColor = System.Drawing.Color.White;
            this.dtDepartureDate1.FocusedColor = System.Drawing.Color.Gainsboro;
            this.dtDepartureDate1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDepartureDate1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtDepartureDate1.Location = new System.Drawing.Point(24, 358);
            this.dtDepartureDate1.Margin = new System.Windows.Forms.Padding(2);
            this.dtDepartureDate1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDepartureDate1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDepartureDate1.Name = "dtDepartureDate1";
            this.dtDepartureDate1.Size = new System.Drawing.Size(232, 32);
            this.dtDepartureDate1.TabIndex = 32;
            this.dtDepartureDate1.Value = new System.DateTime(2024, 6, 3, 15, 3, 26, 864);
            // 
            // buttonCheckFlys1
            // 
            this.buttonCheckFlys1.Animated = true;
            this.buttonCheckFlys1.AutoRoundedCorners = true;
            this.buttonCheckFlys1.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheckFlys1.BorderColor = System.Drawing.Color.White;
            this.buttonCheckFlys1.BorderRadius = 15;
            this.buttonCheckFlys1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCheckFlys1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCheckFlys1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCheckFlys1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCheckFlys1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.buttonCheckFlys1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonCheckFlys1.ForeColor = System.Drawing.Color.White;
            this.buttonCheckFlys1.Location = new System.Drawing.Point(278, 358);
            this.buttonCheckFlys1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCheckFlys1.Name = "buttonCheckFlys1";
            this.buttonCheckFlys1.PressedColor = System.Drawing.Color.Teal;
            this.buttonCheckFlys1.Size = new System.Drawing.Size(42, 32);
            this.buttonCheckFlys1.TabIndex = 40;
            this.buttonCheckFlys1.Text = "✔️";
            this.buttonCheckFlys1.Visible = false;
            this.buttonCheckFlys1.Click += new System.EventHandler(this.buttonCheckFlys1_Click);
            // 
            // PanelReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(976, 582);
            this.Controls.Add(this.buttonCheckFlys1);
            this.Controls.Add(this.dtDepartureDate1);
            this.Controls.Add(this.dataGridViewAir1);
            this.Controls.Add(this.guna2TextBoxAir8);
            this.Controls.Add(this.guna2ButtonAir8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchAirLine3);
            this.Controls.Add(this.airline3);
            this.Controls.Add(this.airlineLabel);
            this.Controls.Add(this.dataGridViewAire8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAirPlanes_AirLines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(976, 582);
            this.MinimumSize = new System.Drawing.Size(976, 582);
            this.Name = "PanelReportes";
            this.Text = "PanelReportes";
            this.Load += new System.EventHandler(this.PanelReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirPlanes_AirLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAire8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAir1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.DataGridView dataGridViewAirPlanes_AirLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewAire8;
        private Guna.UI2.WinForms.Guna2TextBox searchAirLine3;
        private Guna.UI2.WinForms.Guna2Button airline3;
        private System.Windows.Forms.Label airlineLabel;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxAir8;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAir8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewAir1;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtDepartureDate1;
        private Guna.UI2.WinForms.Guna2Button buttonCheckFlys1;
    }
}
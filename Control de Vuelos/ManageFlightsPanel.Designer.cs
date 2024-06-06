namespace Control_de_Vuelos {
	partial class ManageFlightsPanel {
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
			this.lbPilot = new System.Windows.Forms.Label();
			this.lbPlane = new System.Windows.Forms.Label();
			this.cbArrivalCities = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbArrivalCity = new System.Windows.Forms.Label();
			this.lbDepartureCity = new System.Windows.Forms.Label();
			this.lbArrivalHour = new System.Windows.Forms.Label();
			this.lbDepartureHour = new System.Windows.Forms.Label();
			this.lbArrivalDate = new System.Windows.Forms.Label();
			this.cbPilots = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cbPlanes = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cbArrivalHours = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cbDepartureHours = new Guna.UI2.WinForms.Guna2ComboBox();
			this.dtDepartureDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.cbDepartureCities = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbDepartureDate = new System.Windows.Forms.Label();
			this.dtArrivalDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.SuspendLayout();
			// 
			// lbPilot
			// 
			this.lbPilot.AutoSize = true;
			this.lbPilot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPilot.Location = new System.Drawing.Point(258, 394);
			this.lbPilot.Name = "lbPilot";
			this.lbPilot.Size = new System.Drawing.Size(55, 21);
			this.lbPilot.TabIndex = 34;
			this.lbPilot.Text = "Piloto";
			// 
			// lbPlane
			// 
			this.lbPlane.AutoSize = true;
			this.lbPlane.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPlane.Location = new System.Drawing.Point(96, 394);
			this.lbPlane.Name = "lbPlane";
			this.lbPlane.Size = new System.Drawing.Size(58, 21);
			this.lbPlane.TabIndex = 33;
			this.lbPlane.Text = "Avión";
			// 
			// cbArrivalCities
			// 
			this.cbArrivalCities.BackColor = System.Drawing.Color.Transparent;
			this.cbArrivalCities.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.cbArrivalCities.BorderRadius = 15;
			this.cbArrivalCities.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbArrivalCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbArrivalCities.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbArrivalCities.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbArrivalCities.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbArrivalCities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbArrivalCities.ItemHeight = 30;
			this.cbArrivalCities.Location = new System.Drawing.Point(257, 334);
			this.cbArrivalCities.Name = "cbArrivalCities";
			this.cbArrivalCities.Size = new System.Drawing.Size(163, 36);
			this.cbArrivalCities.TabIndex = 32;
			this.cbArrivalCities.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
			// 
			// lbArrivalCity
			// 
			this.lbArrivalCity.AutoSize = true;
			this.lbArrivalCity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbArrivalCity.Location = new System.Drawing.Point(258, 310);
			this.lbArrivalCity.Name = "lbArrivalCity";
			this.lbArrivalCity.Size = new System.Drawing.Size(168, 21);
			this.lbArrivalCity.TabIndex = 31;
			this.lbArrivalCity.Text = "Ciudad de Destino";
			// 
			// lbDepartureCity
			// 
			this.lbDepartureCity.AutoSize = true;
			this.lbDepartureCity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDepartureCity.Location = new System.Drawing.Point(76, 310);
			this.lbDepartureCity.Name = "lbDepartureCity";
			this.lbDepartureCity.Size = new System.Drawing.Size(167, 21);
			this.lbDepartureCity.TabIndex = 30;
			this.lbDepartureCity.Text = "Ciudad de Partida";
			// 
			// lbArrivalHour
			// 
			this.lbArrivalHour.AutoSize = true;
			this.lbArrivalHour.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbArrivalHour.Location = new System.Drawing.Point(258, 226);
			this.lbArrivalHour.Name = "lbArrivalHour";
			this.lbArrivalHour.Size = new System.Drawing.Size(152, 21);
			this.lbArrivalHour.TabIndex = 29;
			this.lbArrivalHour.Text = "Hora de Llegada";
			// 
			// lbDepartureHour
			// 
			this.lbDepartureHour.AutoSize = true;
			this.lbDepartureHour.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDepartureHour.Location = new System.Drawing.Point(96, 226);
			this.lbDepartureHour.Name = "lbDepartureHour";
			this.lbDepartureHour.Size = new System.Drawing.Size(133, 21);
			this.lbDepartureHour.TabIndex = 28;
			this.lbDepartureHour.Text = "Hora de Salida";
			this.lbDepartureHour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbArrivalDate
			// 
			this.lbArrivalDate.AutoSize = true;
			this.lbArrivalDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbArrivalDate.Location = new System.Drawing.Point(96, 48);
			this.lbArrivalDate.Name = "lbArrivalDate";
			this.lbArrivalDate.Size = new System.Drawing.Size(156, 21);
			this.lbArrivalDate.TabIndex = 27;
			this.lbArrivalDate.Text = "Fecha de Partida";
			// 
			// cbPilots
			// 
			this.cbPilots.BackColor = System.Drawing.Color.Transparent;
			this.cbPilots.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.cbPilots.BorderRadius = 15;
			this.cbPilots.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbPilots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPilots.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbPilots.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbPilots.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPilots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbPilots.ItemHeight = 30;
			this.cbPilots.Location = new System.Drawing.Point(262, 418);
			this.cbPilots.Name = "cbPilots";
			this.cbPilots.Size = new System.Drawing.Size(147, 36);
			this.cbPilots.TabIndex = 26;
			this.cbPilots.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
			// 
			// cbPlanes
			// 
			this.cbPlanes.BackColor = System.Drawing.Color.Transparent;
			this.cbPlanes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.cbPlanes.BorderRadius = 15;
			this.cbPlanes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPlanes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbPlanes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbPlanes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPlanes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbPlanes.ItemHeight = 30;
			this.cbPlanes.Location = new System.Drawing.Point(95, 418);
			this.cbPlanes.Name = "cbPlanes";
			this.cbPlanes.Size = new System.Drawing.Size(148, 36);
			this.cbPlanes.TabIndex = 25;
			this.cbPlanes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
			// 
			// cbArrivalHours
			// 
			this.cbArrivalHours.BackColor = System.Drawing.Color.Transparent;
			this.cbArrivalHours.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.cbArrivalHours.BorderRadius = 15;
			this.cbArrivalHours.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbArrivalHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbArrivalHours.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbArrivalHours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbArrivalHours.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbArrivalHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbArrivalHours.ItemHeight = 30;
			this.cbArrivalHours.Location = new System.Drawing.Point(257, 250);
			this.cbArrivalHours.Name = "cbArrivalHours";
			this.cbArrivalHours.Size = new System.Drawing.Size(148, 36);
			this.cbArrivalHours.TabIndex = 24;
			this.cbArrivalHours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
			// 
			// cbDepartureHours
			// 
			this.cbDepartureHours.AutoRoundedCorners = true;
			this.cbDepartureHours.BackColor = System.Drawing.Color.Transparent;
			this.cbDepartureHours.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.cbDepartureHours.BorderRadius = 17;
			this.cbDepartureHours.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbDepartureHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDepartureHours.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbDepartureHours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbDepartureHours.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbDepartureHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbDepartureHours.ItemHeight = 30;
			this.cbDepartureHours.Location = new System.Drawing.Point(95, 250);
			this.cbDepartureHours.Name = "cbDepartureHours";
			this.cbDepartureHours.Size = new System.Drawing.Size(148, 36);
			this.cbDepartureHours.TabIndex = 23;
			this.cbDepartureHours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
			// 
			// dtDepartureDate
			// 
			this.dtDepartureDate.Animated = true;
			this.dtDepartureDate.AutoRoundedCorners = true;
			this.dtDepartureDate.BackColor = System.Drawing.Color.White;
			this.dtDepartureDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.dtDepartureDate.BorderRadius = 19;
			this.dtDepartureDate.Checked = true;
			this.dtDepartureDate.FillColor = System.Drawing.Color.White;
			this.dtDepartureDate.FocusedColor = System.Drawing.Color.Gainsboro;
			this.dtDepartureDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dtDepartureDate.Location = new System.Drawing.Point(95, 72);
			this.dtDepartureDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtDepartureDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtDepartureDate.Name = "dtDepartureDate";
			this.dtDepartureDate.Size = new System.Drawing.Size(310, 40);
			this.dtDepartureDate.TabIndex = 22;
			this.dtDepartureDate.Value = new System.DateTime(2024, 6, 3, 15, 3, 26, 864);
			// 
			// cbDepartureCities
			// 
			this.cbDepartureCities.BackColor = System.Drawing.Color.Transparent;
			this.cbDepartureCities.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.cbDepartureCities.BorderRadius = 15;
			this.cbDepartureCities.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbDepartureCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDepartureCities.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbDepartureCities.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbDepartureCities.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbDepartureCities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbDepartureCities.ItemHeight = 30;
			this.cbDepartureCities.Location = new System.Drawing.Point(80, 334);
			this.cbDepartureCities.Name = "cbDepartureCities";
			this.cbDepartureCities.Size = new System.Drawing.Size(163, 36);
			this.cbDepartureCities.TabIndex = 21;
			this.cbDepartureCities.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
			// 
			// lbDepartureDate
			// 
			this.lbDepartureDate.AutoSize = true;
			this.lbDepartureDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDepartureDate.Location = new System.Drawing.Point(96, 132);
			this.lbDepartureDate.Name = "lbDepartureDate";
			this.lbDepartureDate.Size = new System.Drawing.Size(164, 21);
			this.lbDepartureDate.TabIndex = 36;
			this.lbDepartureDate.Text = "Fecha de Llegada";
			// 
			// dtArrivalDate
			// 
			this.dtArrivalDate.Animated = true;
			this.dtArrivalDate.AutoRoundedCorners = true;
			this.dtArrivalDate.BackColor = System.Drawing.Color.White;
			this.dtArrivalDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.dtArrivalDate.BorderRadius = 19;
			this.dtArrivalDate.Checked = true;
			this.dtArrivalDate.FillColor = System.Drawing.Color.White;
			this.dtArrivalDate.FocusedColor = System.Drawing.Color.Gainsboro;
			this.dtArrivalDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dtArrivalDate.Location = new System.Drawing.Point(95, 156);
			this.dtArrivalDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtArrivalDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtArrivalDate.Name = "dtArrivalDate";
			this.dtArrivalDate.Size = new System.Drawing.Size(310, 40);
			this.dtArrivalDate.TabIndex = 35;
			this.dtArrivalDate.Value = new System.DateTime(2024, 6, 3, 15, 3, 26, 864);
			// 
			// ManageFlightsPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(500, 520);
			this.Controls.Add(this.lbDepartureDate);
			this.Controls.Add(this.dtArrivalDate);
			this.Controls.Add(this.lbPilot);
			this.Controls.Add(this.lbPlane);
			this.Controls.Add(this.cbArrivalCities);
			this.Controls.Add(this.lbArrivalCity);
			this.Controls.Add(this.lbDepartureCity);
			this.Controls.Add(this.lbArrivalHour);
			this.Controls.Add(this.lbDepartureHour);
			this.Controls.Add(this.lbArrivalDate);
			this.Controls.Add(this.cbPilots);
			this.Controls.Add(this.cbPlanes);
			this.Controls.Add(this.cbArrivalHours);
			this.Controls.Add(this.cbDepartureHours);
			this.Controls.Add(this.dtDepartureDate);
			this.Controls.Add(this.cbDepartureCities);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageFlightsPanel";
			this.Text = "ManageFlightsPanel";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbPilot;
		private System.Windows.Forms.Label lbPlane;
		public Guna.UI2.WinForms.Guna2ComboBox cbArrivalCities;
		private System.Windows.Forms.Label lbArrivalCity;
		private System.Windows.Forms.Label lbDepartureCity;
		private System.Windows.Forms.Label lbArrivalHour;
		private System.Windows.Forms.Label lbDepartureHour;
		private System.Windows.Forms.Label lbArrivalDate;
		public Guna.UI2.WinForms.Guna2ComboBox cbPilots;
		public Guna.UI2.WinForms.Guna2ComboBox cbPlanes;
		public Guna.UI2.WinForms.Guna2ComboBox cbArrivalHours;
		public Guna.UI2.WinForms.Guna2ComboBox cbDepartureHours;
		public Guna.UI2.WinForms.Guna2DateTimePicker dtDepartureDate;
		public Guna.UI2.WinForms.Guna2ComboBox cbDepartureCities;
		private System.Windows.Forms.Label lbDepartureDate;
		public Guna.UI2.WinForms.Guna2DateTimePicker dtArrivalDate;
	}
}
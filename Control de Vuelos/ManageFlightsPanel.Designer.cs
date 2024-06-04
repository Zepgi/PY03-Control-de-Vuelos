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
			this.lbFlightDate = new System.Windows.Forms.Label();
			this.cbPilots = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cbPlanes = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cbArrivalHours = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cbDepartureHours = new Guna.UI2.WinForms.Guna2ComboBox();
			this.dtFlightDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.cbDepartureCities = new Guna.UI2.WinForms.Guna2ComboBox();
			this.SuspendLayout();
			// 
			// lbPilot
			// 
			this.lbPilot.AutoSize = true;
			this.lbPilot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPilot.Location = new System.Drawing.Point(258, 304);
			this.lbPilot.Name = "lbPilot";
			this.lbPilot.Size = new System.Drawing.Size(55, 21);
			this.lbPilot.TabIndex = 34;
			this.lbPilot.Text = "Piloto";
			// 
			// lbPlane
			// 
			this.lbPlane.AutoSize = true;
			this.lbPlane.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPlane.Location = new System.Drawing.Point(96, 304);
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
			this.cbArrivalCities.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbArrivalCities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbArrivalCities.ItemHeight = 30;
			this.cbArrivalCities.Location = new System.Drawing.Point(257, 244);
			this.cbArrivalCities.Name = "cbArrivalCities";
			this.cbArrivalCities.Size = new System.Drawing.Size(163, 36);
			this.cbArrivalCities.TabIndex = 32;
			// 
			// lbArrivalCity
			// 
			this.lbArrivalCity.AutoSize = true;
			this.lbArrivalCity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbArrivalCity.Location = new System.Drawing.Point(258, 220);
			this.lbArrivalCity.Name = "lbArrivalCity";
			this.lbArrivalCity.Size = new System.Drawing.Size(168, 21);
			this.lbArrivalCity.TabIndex = 31;
			this.lbArrivalCity.Text = "Ciudad de Destino";
			// 
			// lbDepartureCity
			// 
			this.lbDepartureCity.AutoSize = true;
			this.lbDepartureCity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDepartureCity.Location = new System.Drawing.Point(76, 220);
			this.lbDepartureCity.Name = "lbDepartureCity";
			this.lbDepartureCity.Size = new System.Drawing.Size(167, 21);
			this.lbDepartureCity.TabIndex = 30;
			this.lbDepartureCity.Text = "Ciudad de Partida";
			// 
			// lbArrivalHour
			// 
			this.lbArrivalHour.AutoSize = true;
			this.lbArrivalHour.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbArrivalHour.Location = new System.Drawing.Point(258, 136);
			this.lbArrivalHour.Name = "lbArrivalHour";
			this.lbArrivalHour.Size = new System.Drawing.Size(152, 21);
			this.lbArrivalHour.TabIndex = 29;
			this.lbArrivalHour.Text = "Hora de Llegada";
			// 
			// lbDepartureHour
			// 
			this.lbDepartureHour.AutoSize = true;
			this.lbDepartureHour.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDepartureHour.Location = new System.Drawing.Point(96, 136);
			this.lbDepartureHour.Name = "lbDepartureHour";
			this.lbDepartureHour.Size = new System.Drawing.Size(133, 21);
			this.lbDepartureHour.TabIndex = 28;
			this.lbDepartureHour.Text = "Hora de Salida";
			this.lbDepartureHour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbFlightDate
			// 
			this.lbFlightDate.AutoSize = true;
			this.lbFlightDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFlightDate.Location = new System.Drawing.Point(96, 48);
			this.lbFlightDate.Name = "lbFlightDate";
			this.lbFlightDate.Size = new System.Drawing.Size(156, 21);
			this.lbFlightDate.TabIndex = 27;
			this.lbFlightDate.Text = "Fecha de Partida";
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
			this.cbPilots.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbPilots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbPilots.ItemHeight = 30;
			this.cbPilots.Location = new System.Drawing.Point(262, 328);
			this.cbPilots.Name = "cbPilots";
			this.cbPilots.Size = new System.Drawing.Size(147, 36);
			this.cbPilots.TabIndex = 26;
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
			this.cbPlanes.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbPlanes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbPlanes.ItemHeight = 30;
			this.cbPlanes.Location = new System.Drawing.Point(95, 328);
			this.cbPlanes.Name = "cbPlanes";
			this.cbPlanes.Size = new System.Drawing.Size(148, 36);
			this.cbPlanes.TabIndex = 25;
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
			this.cbArrivalHours.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbArrivalHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbArrivalHours.ItemHeight = 30;
			this.cbArrivalHours.Location = new System.Drawing.Point(257, 160);
			this.cbArrivalHours.Name = "cbArrivalHours";
			this.cbArrivalHours.Size = new System.Drawing.Size(148, 36);
			this.cbArrivalHours.TabIndex = 24;
			// 
			// cbDepartureHours
			// 
			this.cbDepartureHours.BackColor = System.Drawing.Color.Transparent;
			this.cbDepartureHours.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.cbDepartureHours.BorderRadius = 15;
			this.cbDepartureHours.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbDepartureHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDepartureHours.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbDepartureHours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbDepartureHours.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbDepartureHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbDepartureHours.ItemHeight = 30;
			this.cbDepartureHours.Location = new System.Drawing.Point(95, 160);
			this.cbDepartureHours.Name = "cbDepartureHours";
			this.cbDepartureHours.Size = new System.Drawing.Size(148, 36);
			this.cbDepartureHours.TabIndex = 23;
			// 
			// dtFlightDate
			// 
			this.dtFlightDate.Animated = true;
			this.dtFlightDate.AutoRoundedCorners = true;
			this.dtFlightDate.BackColor = System.Drawing.Color.White;
			this.dtFlightDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.dtFlightDate.BorderRadius = 19;
			this.dtFlightDate.Checked = true;
			this.dtFlightDate.FillColor = System.Drawing.Color.White;
			this.dtFlightDate.FocusedColor = System.Drawing.Color.Gainsboro;
			this.dtFlightDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFlightDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dtFlightDate.Location = new System.Drawing.Point(95, 72);
			this.dtFlightDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtFlightDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtFlightDate.Name = "dtFlightDate";
			this.dtFlightDate.Size = new System.Drawing.Size(310, 40);
			this.dtFlightDate.TabIndex = 22;
			this.dtFlightDate.Value = new System.DateTime(2024, 6, 3, 15, 3, 26, 864);
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
			this.cbDepartureCities.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbDepartureCities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbDepartureCities.ItemHeight = 30;
			this.cbDepartureCities.Location = new System.Drawing.Point(80, 244);
			this.cbDepartureCities.Name = "cbDepartureCities";
			this.cbDepartureCities.Size = new System.Drawing.Size(163, 36);
			this.cbDepartureCities.TabIndex = 21;
			// 
			// ManageFlightsPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(500, 420);
			this.Controls.Add(this.lbPilot);
			this.Controls.Add(this.lbPlane);
			this.Controls.Add(this.cbArrivalCities);
			this.Controls.Add(this.lbArrivalCity);
			this.Controls.Add(this.lbDepartureCity);
			this.Controls.Add(this.lbArrivalHour);
			this.Controls.Add(this.lbDepartureHour);
			this.Controls.Add(this.lbFlightDate);
			this.Controls.Add(this.cbPilots);
			this.Controls.Add(this.cbPlanes);
			this.Controls.Add(this.cbArrivalHours);
			this.Controls.Add(this.cbDepartureHours);
			this.Controls.Add(this.dtFlightDate);
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
		private Guna.UI2.WinForms.Guna2ComboBox cbArrivalCities;
		private System.Windows.Forms.Label lbArrivalCity;
		private System.Windows.Forms.Label lbDepartureCity;
		private System.Windows.Forms.Label lbArrivalHour;
		private System.Windows.Forms.Label lbDepartureHour;
		private System.Windows.Forms.Label lbFlightDate;
		private Guna.UI2.WinForms.Guna2ComboBox cbPilots;
		private Guna.UI2.WinForms.Guna2ComboBox cbPlanes;
		private Guna.UI2.WinForms.Guna2ComboBox cbArrivalHours;
		private Guna.UI2.WinForms.Guna2ComboBox cbDepartureHours;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtFlightDate;
		private Guna.UI2.WinForms.Guna2ComboBox cbDepartureCities;
	}
}
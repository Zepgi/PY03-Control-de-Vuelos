namespace Control_de_Vuelos {
	partial class FlightsPanel {
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
			this.tbFlights = new System.Windows.Forms.DataGridView();
			this.btAddFlight = new Guna.UI2.WinForms.Guna2Button();
			this.btModFlight = new Guna.UI2.WinForms.Guna2Button();
			this.btAddPassenger = new Guna.UI2.WinForms.Guna2Button();
			this.pInputArea = new System.Windows.Forms.Panel();
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
			this.lbSelectOpt = new System.Windows.Forms.Label();
			this.btConfirmPassenger = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.tbFlights)).BeginInit();
			this.pInputArea.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbFlights
			// 
			this.tbFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tbFlights.Location = new System.Drawing.Point(638, 70);
			this.tbFlights.Name = "tbFlights";
			this.tbFlights.RowHeadersWidth = 51;
			this.tbFlights.RowTemplate.Height = 24;
			this.tbFlights.Size = new System.Drawing.Size(550, 590);
			this.tbFlights.TabIndex = 4;
			// 
			// btAddFlight
			// 
			this.btAddFlight.Animated = true;
			this.btAddFlight.AutoRoundedCorners = true;
			this.btAddFlight.BackColor = System.Drawing.Color.Transparent;
			this.btAddFlight.BorderColor = System.Drawing.Color.White;
			this.btAddFlight.BorderRadius = 22;
			this.btAddFlight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btAddFlight.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btAddFlight.ForeColor = System.Drawing.Color.White;
			this.btAddFlight.Location = new System.Drawing.Point(40, 70);
			this.btAddFlight.Name = "btAddFlight";
			this.btAddFlight.PressedColor = System.Drawing.Color.Teal;
			this.btAddFlight.ShadowDecoration.BorderRadius = 0;
			this.btAddFlight.ShadowDecoration.Depth = 0;
			this.btAddFlight.ShadowDecoration.Enabled = true;
			this.btAddFlight.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btAddFlight.Size = new System.Drawing.Size(226, 46);
			this.btAddFlight.TabIndex = 6;
			this.btAddFlight.Text = "Registrar Vuelo";
			this.btAddFlight.Click += new System.EventHandler(this.button_Click);
			// 
			// btModFlight
			// 
			this.btModFlight.Animated = true;
			this.btModFlight.AutoRoundedCorners = true;
			this.btModFlight.BackColor = System.Drawing.Color.Transparent;
			this.btModFlight.BorderColor = System.Drawing.Color.White;
			this.btModFlight.BorderRadius = 22;
			this.btModFlight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btModFlight.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btModFlight.ForeColor = System.Drawing.Color.White;
			this.btModFlight.Location = new System.Drawing.Point(314, 70);
			this.btModFlight.Name = "btModFlight";
			this.btModFlight.PressedColor = System.Drawing.Color.Teal;
			this.btModFlight.ShadowDecoration.BorderRadius = 30;
			this.btModFlight.ShadowDecoration.Depth = 0;
			this.btModFlight.ShadowDecoration.Enabled = true;
			this.btModFlight.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btModFlight.Size = new System.Drawing.Size(226, 46);
			this.btModFlight.TabIndex = 7;
			this.btModFlight.Text = "Modificar Vuelo";
			this.btModFlight.Click += new System.EventHandler(this.button_Click);
			// 
			// btAddPassenger
			// 
			this.btAddPassenger.AutoRoundedCorners = true;
			this.btAddPassenger.BackColor = System.Drawing.Color.Transparent;
			this.btAddPassenger.BorderColor = System.Drawing.Color.White;
			this.btAddPassenger.BorderRadius = 22;
			this.btAddPassenger.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btAddPassenger.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btAddPassenger.ForeColor = System.Drawing.Color.White;
			this.btAddPassenger.Location = new System.Drawing.Point(40, 614);
			this.btAddPassenger.Name = "btAddPassenger";
			this.btAddPassenger.PressedColor = System.Drawing.Color.Teal;
			this.btAddPassenger.ShadowDecoration.BorderRadius = 30;
			this.btAddPassenger.ShadowDecoration.Depth = 0;
			this.btAddPassenger.ShadowDecoration.Enabled = true;
			this.btAddPassenger.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btAddPassenger.Size = new System.Drawing.Size(226, 46);
			this.btAddPassenger.TabIndex = 8;
			this.btAddPassenger.Text = "Registrar Pasajeros";
			this.btAddPassenger.Click += new System.EventHandler(this.button_Click);
			// 
			// pInputArea
			// 
			this.pInputArea.BackColor = System.Drawing.Color.Transparent;
			this.pInputArea.Controls.Add(this.lbPilot);
			this.pInputArea.Controls.Add(this.lbPlane);
			this.pInputArea.Controls.Add(this.cbArrivalCities);
			this.pInputArea.Controls.Add(this.lbArrivalCity);
			this.pInputArea.Controls.Add(this.lbDepartureCity);
			this.pInputArea.Controls.Add(this.lbArrivalHour);
			this.pInputArea.Controls.Add(this.lbDepartureHour);
			this.pInputArea.Controls.Add(this.lbFlightDate);
			this.pInputArea.Controls.Add(this.cbPilots);
			this.pInputArea.Controls.Add(this.cbPlanes);
			this.pInputArea.Controls.Add(this.cbArrivalHours);
			this.pInputArea.Controls.Add(this.cbDepartureHours);
			this.pInputArea.Controls.Add(this.dtFlightDate);
			this.pInputArea.Controls.Add(this.cbDepartureCities);
			this.pInputArea.Controls.Add(this.lbSelectOpt);
			this.pInputArea.Location = new System.Drawing.Point(40, 155);
			this.pInputArea.Name = "pInputArea";
			this.pInputArea.Size = new System.Drawing.Size(500, 420);
			this.pInputArea.TabIndex = 9;
			// 
			// lbPilot
			// 
			this.lbPilot.AutoSize = true;
			this.lbPilot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPilot.Location = new System.Drawing.Point(253, 297);
			this.lbPilot.Name = "lbPilot";
			this.lbPilot.Size = new System.Drawing.Size(55, 21);
			this.lbPilot.TabIndex = 20;
			this.lbPilot.Text = "Piloto";
			// 
			// lbPlane
			// 
			this.lbPlane.AutoSize = true;
			this.lbPlane.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPlane.Location = new System.Drawing.Point(98, 297);
			this.lbPlane.Name = "lbPlane";
			this.lbPlane.Size = new System.Drawing.Size(58, 21);
			this.lbPlane.TabIndex = 19;
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
			this.cbArrivalCities.Location = new System.Drawing.Point(250, 237);
			this.cbArrivalCities.Name = "cbArrivalCities";
			this.cbArrivalCities.Size = new System.Drawing.Size(163, 36);
			this.cbArrivalCities.TabIndex = 18;
			// 
			// lbArrivalCity
			// 
			this.lbArrivalCity.AutoSize = true;
			this.lbArrivalCity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbArrivalCity.Location = new System.Drawing.Point(253, 213);
			this.lbArrivalCity.Name = "lbArrivalCity";
			this.lbArrivalCity.Size = new System.Drawing.Size(168, 21);
			this.lbArrivalCity.TabIndex = 17;
			this.lbArrivalCity.Text = "Ciudad de Destino";
			// 
			// lbDepartureCity
			// 
			this.lbDepartureCity.AutoSize = true;
			this.lbDepartureCity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDepartureCity.Location = new System.Drawing.Point(73, 213);
			this.lbDepartureCity.Name = "lbDepartureCity";
			this.lbDepartureCity.Size = new System.Drawing.Size(167, 21);
			this.lbDepartureCity.TabIndex = 16;
			this.lbDepartureCity.Text = "Ciudad de Partida";
			// 
			// lbArrivalHour
			// 
			this.lbArrivalHour.AutoSize = true;
			this.lbArrivalHour.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbArrivalHour.Location = new System.Drawing.Point(253, 129);
			this.lbArrivalHour.Name = "lbArrivalHour";
			this.lbArrivalHour.Size = new System.Drawing.Size(152, 21);
			this.lbArrivalHour.TabIndex = 15;
			this.lbArrivalHour.Text = "Hora de Llegada";
			// 
			// lbDepartureHour
			// 
			this.lbDepartureHour.AutoSize = true;
			this.lbDepartureHour.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDepartureHour.Location = new System.Drawing.Point(98, 129);
			this.lbDepartureHour.Name = "lbDepartureHour";
			this.lbDepartureHour.Size = new System.Drawing.Size(133, 21);
			this.lbDepartureHour.TabIndex = 14;
			this.lbDepartureHour.Text = "Hora de Salida";
			this.lbDepartureHour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbFlightDate
			// 
			this.lbFlightDate.AutoSize = true;
			this.lbFlightDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFlightDate.Location = new System.Drawing.Point(93, 41);
			this.lbFlightDate.Name = "lbFlightDate";
			this.lbFlightDate.Size = new System.Drawing.Size(156, 21);
			this.lbFlightDate.TabIndex = 13;
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
			this.cbPilots.Location = new System.Drawing.Point(250, 321);
			this.cbPilots.Name = "cbPilots";
			this.cbPilots.Size = new System.Drawing.Size(147, 36);
			this.cbPilots.TabIndex = 11;
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
			this.cbPlanes.Location = new System.Drawing.Point(95, 321);
			this.cbPlanes.Name = "cbPlanes";
			this.cbPlanes.Size = new System.Drawing.Size(148, 36);
			this.cbPlanes.TabIndex = 10;
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
			this.cbArrivalHours.Location = new System.Drawing.Point(250, 153);
			this.cbArrivalHours.Name = "cbArrivalHours";
			this.cbArrivalHours.Size = new System.Drawing.Size(148, 36);
			this.cbArrivalHours.TabIndex = 9;
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
			this.cbDepartureHours.Location = new System.Drawing.Point(95, 153);
			this.cbDepartureHours.Name = "cbDepartureHours";
			this.cbDepartureHours.Size = new System.Drawing.Size(148, 36);
			this.cbDepartureHours.TabIndex = 8;
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
			this.dtFlightDate.Location = new System.Drawing.Point(95, 65);
			this.dtFlightDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtFlightDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtFlightDate.Name = "dtFlightDate";
			this.dtFlightDate.Size = new System.Drawing.Size(310, 40);
			this.dtFlightDate.TabIndex = 7;
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
			this.cbDepartureCities.Location = new System.Drawing.Point(80, 237);
			this.cbDepartureCities.Name = "cbDepartureCities";
			this.cbDepartureCities.Size = new System.Drawing.Size(163, 36);
			this.cbDepartureCities.TabIndex = 6;
			// 
			// lbSelectOpt
			// 
			this.lbSelectOpt.AutoSize = true;
			this.lbSelectOpt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSelectOpt.Location = new System.Drawing.Point(100, 175);
			this.lbSelectOpt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbSelectOpt.Name = "lbSelectOpt";
			this.lbSelectOpt.Size = new System.Drawing.Size(300, 54);
			this.lbSelectOpt.TabIndex = 4;
			this.lbSelectOpt.Text = "Seleccione una opción \r\npara mostrar información";
			this.lbSelectOpt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btConfirmPassenger
			// 
			this.btConfirmPassenger.AutoRoundedCorners = true;
			this.btConfirmPassenger.BackColor = System.Drawing.Color.Transparent;
			this.btConfirmPassenger.BorderColor = System.Drawing.Color.White;
			this.btConfirmPassenger.BorderRadius = 22;
			this.btConfirmPassenger.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btConfirmPassenger.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btConfirmPassenger.ForeColor = System.Drawing.Color.White;
			this.btConfirmPassenger.Location = new System.Drawing.Point(314, 614);
			this.btConfirmPassenger.Name = "btConfirmPassenger";
			this.btConfirmPassenger.PressedColor = System.Drawing.Color.Teal;
			this.btConfirmPassenger.ShadowDecoration.BorderRadius = 30;
			this.btConfirmPassenger.ShadowDecoration.Depth = 0;
			this.btConfirmPassenger.ShadowDecoration.Enabled = true;
			this.btConfirmPassenger.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btConfirmPassenger.Size = new System.Drawing.Size(226, 46);
			this.btConfirmPassenger.TabIndex = 10;
			this.btConfirmPassenger.Text = "Confirmar Pasajeros";
			this.btConfirmPassenger.Click += new System.EventHandler(this.button_Click);
			// 
			// FlightsPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1220, 727);
			this.Controls.Add(this.btConfirmPassenger);
			this.Controls.Add(this.btAddPassenger);
			this.Controls.Add(this.pInputArea);
			this.Controls.Add(this.btModFlight);
			this.Controls.Add(this.btAddFlight);
			this.Controls.Add(this.tbFlights);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(1220, 727);
			this.MinimumSize = new System.Drawing.Size(1220, 727);
			this.Name = "FlightsPanel";
			this.Text = "PanelVuelos";
			((System.ComponentModel.ISupportInitialize)(this.tbFlights)).EndInit();
			this.pInputArea.ResumeLayout(false);
			this.pInputArea.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView tbFlights;
		private Guna.UI2.WinForms.Guna2Button btAddFlight;
		private Guna.UI2.WinForms.Guna2Button btModFlight;
		private Guna.UI2.WinForms.Guna2Button btAddPassenger;
		private System.Windows.Forms.Panel pInputArea;
		private Guna.UI2.WinForms.Guna2Button btConfirmPassenger;
		private System.Windows.Forms.Label lbSelectOpt;
		private Guna.UI2.WinForms.Guna2ComboBox cbPilots;
		private Guna.UI2.WinForms.Guna2ComboBox cbPlanes;
		private Guna.UI2.WinForms.Guna2ComboBox cbArrivalHours;
		private Guna.UI2.WinForms.Guna2ComboBox cbDepartureHours;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtFlightDate;
		private Guna.UI2.WinForms.Guna2ComboBox cbDepartureCities;
		private System.Windows.Forms.Label lbArrivalHour;
		private System.Windows.Forms.Label lbDepartureHour;
		private System.Windows.Forms.Label lbFlightDate;
		private System.Windows.Forms.Label lbArrivalCity;
		private System.Windows.Forms.Label lbDepartureCity;
		private System.Windows.Forms.Label lbPlane;
		private Guna.UI2.WinForms.Guna2ComboBox cbArrivalCities;
		private System.Windows.Forms.Label lbPilot;
	}
}
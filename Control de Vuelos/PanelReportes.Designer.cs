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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.dataGridViewAirPlanes_AirLines = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
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
			this.tbPlanes = new Guna.UI2.WinForms.Guna2DataGridView();
			this.btPlanesByCity = new Guna.UI2.WinForms.Guna2Button();
			this.btDifferentPlanes = new Guna.UI2.WinForms.Guna2Button();
			this.btTopCity = new Guna.UI2.WinForms.Guna2Button();
			this.cbAirlines = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbAirline = new System.Windows.Forms.Label();
			this.chartTopDays = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirPlanes_AirLines)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAire8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAir1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbPlanes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartTopDays)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewAirPlanes_AirLines
			// 
			this.dataGridViewAirPlanes_AirLines.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewAirPlanes_AirLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAirPlanes_AirLines.Location = new System.Drawing.Point(15, 989);
			this.dataGridViewAirPlanes_AirLines.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridViewAirPlanes_AirLines.Name = "dataGridViewAirPlanes_AirLines";
			this.dataGridViewAirPlanes_AirLines.RowHeadersWidth = 51;
			this.dataGridViewAirPlanes_AirLines.Size = new System.Drawing.Size(462, 268);
			this.dataGridViewAirPlanes_AirLines.TabIndex = 10;
			this.dataGridViewAirPlanes_AirLines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAirPlanes_AirLines_CellContentClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 938);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(304, 32);
			this.label2.TabIndex = 12;
			this.label2.Text = "Aviones por aerolineas";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 1510);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(438, 32);
			this.label4.TabIndex = 15;
			this.label4.Text = "Informacion general de los vuelos";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(14, 110);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(323, 32);
			this.label5.TabIndex = 16;
			this.label5.Text = "Vuelos activos por fecha";
			// 
			// dataGridViewAire8
			// 
			this.dataGridViewAire8.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewAire8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAire8.Location = new System.Drawing.Point(15, 1572);
			this.dataGridViewAire8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridViewAire8.Name = "dataGridViewAire8";
			this.dataGridViewAire8.RowHeadersWidth = 51;
			this.dataGridViewAire8.Size = new System.Drawing.Size(462, 281);
			this.dataGridViewAire8.TabIndex = 17;
			this.dataGridViewAire8.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAire8_CellContentClick);
			// 
			// searchAirLine3
			// 
			this.searchAirLine3.AutoRoundedCorners = true;
			this.searchAirLine3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.searchAirLine3.BorderRadius = 21;
			this.searchAirLine3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.searchAirLine3.DefaultText = "";
			this.searchAirLine3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.searchAirLine3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.searchAirLine3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.searchAirLine3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.searchAirLine3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.searchAirLine3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
			this.searchAirLine3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.searchAirLine3.Location = new System.Drawing.Point(68, 1318);
			this.searchAirLine3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.searchAirLine3.Name = "searchAirLine3";
			this.searchAirLine3.PasswordChar = '\0';
			this.searchAirLine3.PlaceholderText = "";
			this.searchAirLine3.SelectedText = "";
			this.searchAirLine3.Size = new System.Drawing.Size(181, 45);
			this.searchAirLine3.TabIndex = 27;
			// 
			// airline3
			// 
			this.airline3.Animated = true;
			this.airline3.AutoRoundedCorners = true;
			this.airline3.BackColor = System.Drawing.Color.Transparent;
			this.airline3.BorderColor = System.Drawing.Color.White;
			this.airline3.BorderRadius = 22;
			this.airline3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.airline3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.airline3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.airline3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.airline3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.airline3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.airline3.ForeColor = System.Drawing.Color.White;
			this.airline3.Location = new System.Drawing.Point(265, 1318);
			this.airline3.Margin = new System.Windows.Forms.Padding(2);
			this.airline3.Name = "airline3";
			this.airline3.PressedColor = System.Drawing.Color.Teal;
			this.airline3.Size = new System.Drawing.Size(49, 46);
			this.airline3.TabIndex = 26;
			this.airline3.Text = "🔍";
			this.airline3.Click += new System.EventHandler(this.airline3_Click);
			// 
			// airlineLabel
			// 
			this.airlineLabel.AutoSize = true;
			this.airlineLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
			this.airlineLabel.Location = new System.Drawing.Point(64, 1278);
			this.airlineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.airlineLabel.Name = "airlineLabel";
			this.airlineLabel.Size = new System.Drawing.Size(188, 21);
			this.airlineLabel.TabIndex = 25;
			this.airlineLabel.Text = "Nombre de aerolinea";
			// 
			// guna2TextBoxAir8
			// 
			this.guna2TextBoxAir8.AutoRoundedCorners = true;
			this.guna2TextBoxAir8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.guna2TextBoxAir8.BorderRadius = 21;
			this.guna2TextBoxAir8.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBoxAir8.DefaultText = "";
			this.guna2TextBoxAir8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.guna2TextBoxAir8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.guna2TextBoxAir8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBoxAir8.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBoxAir8.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBoxAir8.Font = new System.Drawing.Font("Century Gothic", 10.2F);
			this.guna2TextBoxAir8.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBoxAir8.Location = new System.Drawing.Point(15, 1925);
			this.guna2TextBoxAir8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.guna2TextBoxAir8.Name = "guna2TextBoxAir8";
			this.guna2TextBoxAir8.PasswordChar = '\0';
			this.guna2TextBoxAir8.PlaceholderText = "";
			this.guna2TextBoxAir8.SelectedText = "";
			this.guna2TextBoxAir8.Size = new System.Drawing.Size(181, 45);
			this.guna2TextBoxAir8.TabIndex = 30;
			// 
			// guna2ButtonAir8
			// 
			this.guna2ButtonAir8.Animated = true;
			this.guna2ButtonAir8.AutoRoundedCorners = true;
			this.guna2ButtonAir8.BackColor = System.Drawing.Color.Transparent;
			this.guna2ButtonAir8.BorderColor = System.Drawing.Color.White;
			this.guna2ButtonAir8.BorderRadius = 22;
			this.guna2ButtonAir8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2ButtonAir8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2ButtonAir8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2ButtonAir8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2ButtonAir8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.guna2ButtonAir8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.guna2ButtonAir8.ForeColor = System.Drawing.Color.White;
			this.guna2ButtonAir8.Location = new System.Drawing.Point(212, 1925);
			this.guna2ButtonAir8.Margin = new System.Windows.Forms.Padding(2);
			this.guna2ButtonAir8.Name = "guna2ButtonAir8";
			this.guna2ButtonAir8.PressedColor = System.Drawing.Color.Teal;
			this.guna2ButtonAir8.Size = new System.Drawing.Size(49, 46);
			this.guna2ButtonAir8.TabIndex = 29;
			this.guna2ButtonAir8.Text = "🔍";
			this.guna2ButtonAir8.Click += new System.EventHandler(this.guna2ButtonAir8_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
			this.label3.Location = new System.Drawing.Point(11, 1885);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(188, 21);
			this.label3.TabIndex = 28;
			this.label3.Text = "Nombre de aerolinea";
			// 
			// dataGridViewAir1
			// 
			this.dataGridViewAir1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewAir1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAir1.Location = new System.Drawing.Point(15, 158);
			this.dataGridViewAir1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridViewAir1.Name = "dataGridViewAir1";
			this.dataGridViewAir1.RowHeadersWidth = 51;
			this.dataGridViewAir1.Size = new System.Drawing.Size(462, 268);
			this.dataGridViewAir1.TabIndex = 31;
			// 
			// dtDepartureDate1
			// 
			this.dtDepartureDate1.Animated = true;
			this.dtDepartureDate1.AutoRoundedCorners = true;
			this.dtDepartureDate1.BackColor = System.Drawing.Color.White;
			this.dtDepartureDate1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.dtDepartureDate1.BorderRadius = 19;
			this.dtDepartureDate1.Checked = true;
			this.dtDepartureDate1.FillColor = System.Drawing.Color.White;
			this.dtDepartureDate1.FocusedColor = System.Drawing.Color.Gainsboro;
			this.dtDepartureDate1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtDepartureDate1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dtDepartureDate1.Location = new System.Drawing.Point(30, 448);
			this.dtDepartureDate1.Margin = new System.Windows.Forms.Padding(2);
			this.dtDepartureDate1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtDepartureDate1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtDepartureDate1.Name = "dtDepartureDate1";
			this.dtDepartureDate1.Size = new System.Drawing.Size(290, 40);
			this.dtDepartureDate1.TabIndex = 32;
			this.dtDepartureDate1.Value = new System.DateTime(2024, 6, 3, 15, 3, 26, 864);
			// 
			// buttonCheckFlys1
			// 
			this.buttonCheckFlys1.Animated = true;
			this.buttonCheckFlys1.AutoRoundedCorners = true;
			this.buttonCheckFlys1.BackColor = System.Drawing.Color.Transparent;
			this.buttonCheckFlys1.BorderColor = System.Drawing.Color.White;
			this.buttonCheckFlys1.BorderRadius = 19;
			this.buttonCheckFlys1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.buttonCheckFlys1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.buttonCheckFlys1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.buttonCheckFlys1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.buttonCheckFlys1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.buttonCheckFlys1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.buttonCheckFlys1.ForeColor = System.Drawing.Color.White;
			this.buttonCheckFlys1.Location = new System.Drawing.Point(348, 448);
			this.buttonCheckFlys1.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCheckFlys1.Name = "buttonCheckFlys1";
			this.buttonCheckFlys1.PressedColor = System.Drawing.Color.Teal;
			this.buttonCheckFlys1.Size = new System.Drawing.Size(52, 40);
			this.buttonCheckFlys1.TabIndex = 40;
			this.buttonCheckFlys1.Text = "✔️";
			this.buttonCheckFlys1.Visible = false;
			this.buttonCheckFlys1.Click += new System.EventHandler(this.buttonCheckFlys1_Click);
			// 
			// tbPlanes
			// 
			this.tbPlanes.AllowUserToAddRows = false;
			this.tbPlanes.AllowUserToDeleteRows = false;
			this.tbPlanes.AllowUserToResizeColumns = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.tbPlanes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.tbPlanes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
			this.tbPlanes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.tbPlanes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.tbPlanes.ColumnHeadersHeight = 50;
			this.tbPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.tbPlanes.DefaultCellStyle = dataGridViewCellStyle3;
			this.tbPlanes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.tbPlanes.Location = new System.Drawing.Point(562, 1490);
			this.tbPlanes.Name = "tbPlanes";
			this.tbPlanes.ReadOnly = true;
			this.tbPlanes.RowHeadersVisible = false;
			this.tbPlanes.RowHeadersWidth = 51;
			this.tbPlanes.RowTemplate.Height = 50;
			this.tbPlanes.Size = new System.Drawing.Size(625, 363);
			this.tbPlanes.TabIndex = 41;
			this.tbPlanes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.tbPlanes.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.tbPlanes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.tbPlanes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.tbPlanes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.tbPlanes.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.tbPlanes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.tbPlanes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.tbPlanes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.tbPlanes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPlanes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.tbPlanes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.tbPlanes.ThemeStyle.HeaderStyle.Height = 50;
			this.tbPlanes.ThemeStyle.ReadOnly = true;
			this.tbPlanes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.tbPlanes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
			this.tbPlanes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPlanes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.tbPlanes.ThemeStyle.RowsStyle.Height = 50;
			this.tbPlanes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.tbPlanes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// btPlanesByCity
			// 
			this.btPlanesByCity.Animated = true;
			this.btPlanesByCity.AutoRoundedCorners = true;
			this.btPlanesByCity.BackColor = System.Drawing.Color.Transparent;
			this.btPlanesByCity.BorderColor = System.Drawing.Color.White;
			this.btPlanesByCity.BorderRadius = 29;
			this.btPlanesByCity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btPlanesByCity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btPlanesByCity.ForeColor = System.Drawing.Color.White;
			this.btPlanesByCity.Location = new System.Drawing.Point(562, 1859);
			this.btPlanesByCity.Name = "btPlanesByCity";
			this.btPlanesByCity.PressedColor = System.Drawing.Color.Teal;
			this.btPlanesByCity.ShadowDecoration.BorderRadius = 0;
			this.btPlanesByCity.ShadowDecoration.Depth = 0;
			this.btPlanesByCity.ShadowDecoration.Enabled = true;
			this.btPlanesByCity.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btPlanesByCity.Size = new System.Drawing.Size(204, 61);
			this.btPlanesByCity.TabIndex = 42;
			this.btPlanesByCity.Text = "Cantidad de Aviones por Ciudad";
			this.btPlanesByCity.Click += new System.EventHandler(this.button_ClickHandler);
			// 
			// btDifferentPlanes
			// 
			this.btDifferentPlanes.Animated = true;
			this.btDifferentPlanes.AutoRoundedCorners = true;
			this.btDifferentPlanes.BackColor = System.Drawing.Color.Transparent;
			this.btDifferentPlanes.BorderColor = System.Drawing.Color.White;
			this.btDifferentPlanes.BorderRadius = 29;
			this.btDifferentPlanes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btDifferentPlanes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btDifferentPlanes.ForeColor = System.Drawing.Color.White;
			this.btDifferentPlanes.Location = new System.Drawing.Point(772, 1859);
			this.btDifferentPlanes.Name = "btDifferentPlanes";
			this.btDifferentPlanes.PressedColor = System.Drawing.Color.Teal;
			this.btDifferentPlanes.ShadowDecoration.BorderRadius = 0;
			this.btDifferentPlanes.ShadowDecoration.Depth = 0;
			this.btDifferentPlanes.ShadowDecoration.Enabled = true;
			this.btDifferentPlanes.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btDifferentPlanes.Size = new System.Drawing.Size(204, 61);
			this.btDifferentPlanes.TabIndex = 43;
			this.btDifferentPlanes.Text = "Aviones Diferentes de ciudad a otra";
			this.btDifferentPlanes.Click += new System.EventHandler(this.button_ClickHandler);
			// 
			// btTopCity
			// 
			this.btTopCity.Animated = true;
			this.btTopCity.AutoRoundedCorners = true;
			this.btTopCity.BackColor = System.Drawing.Color.Transparent;
			this.btTopCity.BorderColor = System.Drawing.Color.White;
			this.btTopCity.BorderRadius = 29;
			this.btTopCity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btTopCity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btTopCity.ForeColor = System.Drawing.Color.White;
			this.btTopCity.Location = new System.Drawing.Point(982, 1859);
			this.btTopCity.Name = "btTopCity";
			this.btTopCity.PressedColor = System.Drawing.Color.Teal;
			this.btTopCity.ShadowDecoration.BorderRadius = 0;
			this.btTopCity.ShadowDecoration.Depth = 0;
			this.btTopCity.ShadowDecoration.Enabled = true;
			this.btTopCity.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btTopCity.Size = new System.Drawing.Size(204, 61);
			this.btTopCity.TabIndex = 44;
			this.btTopCity.Text = "ciudad mas viajada";
			this.btTopCity.Click += new System.EventHandler(this.button_ClickHandler);
			// 
			// cbAirlines
			// 
			this.cbAirlines.BackColor = System.Drawing.Color.Transparent;
			this.cbAirlines.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.cbAirlines.BorderRadius = 15;
			this.cbAirlines.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbAirlines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbAirlines.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbAirlines.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbAirlines.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAirlines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbAirlines.ItemHeight = 30;
			this.cbAirlines.Location = new System.Drawing.Point(843, 1427);
			this.cbAirlines.Name = "cbAirlines";
			this.cbAirlines.Size = new System.Drawing.Size(344, 36);
			this.cbAirlines.TabIndex = 45;
			this.cbAirlines.SelectedIndexChanged += new System.EventHandler(this.cbAirlines_IndexChanged);
			// 
			// lbAirline
			// 
			this.lbAirline.AutoSize = true;
			this.lbAirline.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAirline.Location = new System.Drawing.Point(713, 1436);
			this.lbAirline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbAirline.Name = "lbAirline";
			this.lbAirline.Size = new System.Drawing.Size(123, 27);
			this.lbAirline.TabIndex = 46;
			this.lbAirline.Text = "Aerolínea";
			this.lbAirline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chartTopDays
			// 
			chartArea1.Name = "chDays";
			this.chartTopDays.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartTopDays.Legends.Add(legend1);
			this.chartTopDays.Location = new System.Drawing.Point(562, 1121);
			this.chartTopDays.Name = "chartTopDays";
			series1.ChartArea = "chDays";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartTopDays.Series.Add(series1);
			this.chartTopDays.Size = new System.Drawing.Size(366, 300);
			this.chartTopDays.TabIndex = 47;
			this.chartTopDays.Text = "chart1";
			// 
			// PanelReportes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1220, 728);
			this.Controls.Add(this.chartTopDays);
			this.Controls.Add(this.lbAirline);
			this.Controls.Add(this.cbAirlines);
			this.Controls.Add(this.btTopCity);
			this.Controls.Add(this.btDifferentPlanes);
			this.Controls.Add(this.btPlanesByCity);
			this.Controls.Add(this.tbPlanes);
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
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridViewAirPlanes_AirLines);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximumSize = new System.Drawing.Size(1220, 728);
			this.MinimumSize = new System.Drawing.Size(1220, 728);
			this.Name = "PanelReportes";
			this.Text = "PanelReportes";
			this.Load += new System.EventHandler(this.PanelReportes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirPlanes_AirLines)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAire8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAir1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbPlanes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartTopDays)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAirPlanes_AirLines = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.tbFlights = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btPassengers = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.fligthsXPassengerLabel = new System.Windows.Forms.Label();
            this.fligthPerPassengerGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.buttonCheckFlys1 = new Guna.UI2.WinForms.Guna2Button();
            this.textboxjose = new Guna.UI2.WinForms.Guna2TextBox();
            this.butonjose = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridJose = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirPlanes_AirLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAire8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAir1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fligthPerPassengerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJose)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAirPlanes_AirLines
            // 
            this.dataGridViewAirPlanes_AirLines.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAirPlanes_AirLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAirPlanes_AirLines.Location = new System.Drawing.Point(12, 791);
            this.dataGridViewAirPlanes_AirLines.Name = "dataGridViewAirPlanes_AirLines";
            this.dataGridViewAirPlanes_AirLines.RowHeadersWidth = 51;
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
            this.dataGridViewAire8.RowHeadersWidth = 51;
            this.dataGridViewAire8.Size = new System.Drawing.Size(370, 225);
            this.dataGridViewAire8.TabIndex = 17;
    
            // /
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
            this.dataGridViewAir1.RowHeadersWidth = 51;
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
            // tbFlights
            // 
            this.tbFlights.AllowUserToAddRows = false;
            this.tbFlights.AllowUserToDeleteRows = false;
            this.tbFlights.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tbFlights.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbFlights.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.tbFlights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbFlights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbFlights.ColumnHeadersHeight = 50;
            this.tbFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbFlights.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbFlights.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tbFlights.Location = new System.Drawing.Point(450, 1171);
            this.tbFlights.Margin = new System.Windows.Forms.Padding(2);
            this.tbFlights.Name = "tbFlights";
            this.tbFlights.ReadOnly = true;
            this.tbFlights.RowHeadersVisible = false;
            this.tbFlights.RowHeadersWidth = 51;
            this.tbFlights.RowTemplate.Height = 50;
            this.tbFlights.Size = new System.Drawing.Size(500, 311);
            this.tbFlights.TabIndex = 41;
            this.tbFlights.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tbFlights.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tbFlights.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tbFlights.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tbFlights.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tbFlights.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tbFlights.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tbFlights.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.tbFlights.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tbFlights.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFlights.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbFlights.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tbFlights.ThemeStyle.HeaderStyle.Height = 50;
            this.tbFlights.ThemeStyle.ReadOnly = true;
            this.tbFlights.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbFlights.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.tbFlights.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFlights.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tbFlights.ThemeStyle.RowsStyle.Height = 50;
            this.tbFlights.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tbFlights.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btPassengers
            // 
            this.btPassengers.Animated = true;
            this.btPassengers.AutoRoundedCorners = true;
            this.btPassengers.BackColor = System.Drawing.Color.Transparent;
            this.btPassengers.BorderColor = System.Drawing.Color.White;
            this.btPassengers.BorderRadius = 17;
            this.btPassengers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.btPassengers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btPassengers.ForeColor = System.Drawing.Color.White;
            this.btPassengers.Location = new System.Drawing.Point(450, 1488);
            this.btPassengers.Margin = new System.Windows.Forms.Padding(2);
            this.btPassengers.Name = "btPassengers";
            this.btPassengers.PressedColor = System.Drawing.Color.Teal;
            this.btPassengers.ShadowDecoration.BorderRadius = 0;
            this.btPassengers.ShadowDecoration.Depth = 0;
            this.btPassengers.ShadowDecoration.Enabled = true;
            this.btPassengers.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
            this.btPassengers.Size = new System.Drawing.Size(181, 37);
            this.btPassengers.TabIndex = 42;
            this.btPassengers.Text = "Pasajeros";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(769, 1488);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Teal;
            this.guna2Button1.ShadowDecoration.BorderRadius = 0;
            this.guna2Button1.ShadowDecoration.Depth = 0;
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
            this.guna2Button1.Size = new System.Drawing.Size(181, 37);
            this.guna2Button1.TabIndex = 43;
            this.guna2Button1.Text = "Pasajeros";
            // 
            // fligthsXPassengerLabel
            // 
            this.fligthsXPassengerLabel.AutoSize = true;
            this.fligthsXPassengerLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fligthsXPassengerLabel.Location = new System.Drawing.Point(497, 33);
            this.fligthsXPassengerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fligthsXPassengerLabel.Name = "fligthsXPassengerLabel";
            this.fligthsXPassengerLabel.Size = new System.Drawing.Size(199, 25);
            this.fligthsXPassengerLabel.TabIndex = 44;
            this.fligthsXPassengerLabel.Text = "Vuelos x Pasajero";
            // 
            // fligthPerPassengerGrid
            // 
            this.fligthPerPassengerGrid.AllowUserToAddRows = false;
            this.fligthPerPassengerGrid.AllowUserToDeleteRows = false;
            this.fligthPerPassengerGrid.AllowUserToResizeColumns = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.fligthPerPassengerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.fligthPerPassengerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.fligthPerPassengerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.fligthPerPassengerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fligthPerPassengerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.fligthPerPassengerGrid.ColumnHeadersHeight = 50;
            this.fligthPerPassengerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fligthPerPassengerGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.fligthPerPassengerGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.fligthPerPassengerGrid.Location = new System.Drawing.Point(502, 73);
            this.fligthPerPassengerGrid.Margin = new System.Windows.Forms.Padding(2);
            this.fligthPerPassengerGrid.Name = "fligthPerPassengerGrid";
            this.fligthPerPassengerGrid.ReadOnly = true;
            this.fligthPerPassengerGrid.RowHeadersVisible = false;
            this.fligthPerPassengerGrid.RowHeadersWidth = 51;
            this.fligthPerPassengerGrid.RowTemplate.Height = 50;
            this.fligthPerPassengerGrid.Size = new System.Drawing.Size(397, 268);
            this.fligthPerPassengerGrid.TabIndex = 45;
            this.fligthPerPassengerGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.fligthPerPassengerGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.fligthPerPassengerGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.fligthPerPassengerGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.fligthPerPassengerGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.fligthPerPassengerGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.fligthPerPassengerGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.fligthPerPassengerGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.fligthPerPassengerGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.fligthPerPassengerGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fligthPerPassengerGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.fligthPerPassengerGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.fligthPerPassengerGrid.ThemeStyle.HeaderStyle.Height = 50;
            this.fligthPerPassengerGrid.ThemeStyle.ReadOnly = true;
            this.fligthPerPassengerGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.fligthPerPassengerGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.fligthPerPassengerGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fligthPerPassengerGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.fligthPerPassengerGrid.ThemeStyle.RowsStyle.Height = 50;
            this.fligthPerPassengerGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.fligthPerPassengerGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.fligthPerPassengerGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.fligthPerPassengerGrid_CellMouseDown);
            this.fligthPerPassengerGrid.SelectionChanged += new System.EventHandler(this.fligthPerPassengerGrid_SelectionChanged);
            // 
            // buttonCheckFlys1
            // 
            this.buttonCheckFlys1.Animated = true;
            this.buttonCheckFlys1.AutoRoundedCorners = true;
            this.buttonCheckFlys1.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheckFlys1.BorderColor = System.Drawing.Color.White;
            this.buttonCheckFlys1.BorderRadius = 17;
            this.buttonCheckFlys1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCheckFlys1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCheckFlys1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCheckFlys1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCheckFlys1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.buttonCheckFlys1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonCheckFlys1.ForeColor = System.Drawing.Color.White;
            this.buttonCheckFlys1.Location = new System.Drawing.Point(273, 358);
            this.buttonCheckFlys1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCheckFlys1.Name = "buttonCheckFlys1";
            this.buttonCheckFlys1.PressedColor = System.Drawing.Color.Teal;
            this.buttonCheckFlys1.Size = new System.Drawing.Size(39, 37);
            this.buttonCheckFlys1.TabIndex = 46;
            this.buttonCheckFlys1.Text = "🔍";
            this.buttonCheckFlys1.Click += new System.EventHandler(this.buttonCheckFlys1_Click_1);
            // 
            // textboxjose
            // 
            this.textboxjose.AutoRoundedCorners = true;
            this.textboxjose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.textboxjose.BorderRadius = 17;
            this.textboxjose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxjose.DefaultText = "";
            this.textboxjose.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxjose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxjose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxjose.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxjose.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxjose.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textboxjose.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxjose.Location = new System.Drawing.Point(574, 1054);
            this.textboxjose.Margin = new System.Windows.Forms.Padding(4);
            this.textboxjose.Name = "textboxjose";
            this.textboxjose.PasswordChar = '\0';
            this.textboxjose.PlaceholderText = "";
            this.textboxjose.SelectedText = "";
            this.textboxjose.Size = new System.Drawing.Size(145, 36);
            this.textboxjose.TabIndex = 53;
            // 
            // butonjose
            // 
            this.butonjose.Animated = true;
            this.butonjose.AutoRoundedCorners = true;
            this.butonjose.BackColor = System.Drawing.Color.Transparent;
            this.butonjose.BorderColor = System.Drawing.Color.White;
            this.butonjose.BorderRadius = 17;
            this.butonjose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butonjose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butonjose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butonjose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butonjose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.butonjose.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.butonjose.ForeColor = System.Drawing.Color.White;
            this.butonjose.Location = new System.Drawing.Point(732, 1054);
            this.butonjose.Margin = new System.Windows.Forms.Padding(2);
            this.butonjose.Name = "butonjose";
            this.butonjose.PressedColor = System.Drawing.Color.Teal;
            this.butonjose.Size = new System.Drawing.Size(39, 37);
            this.butonjose.TabIndex = 52;
            this.butonjose.Text = "🔍";
            this.butonjose.Click += new System.EventHandler(this.butonjose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label1.Location = new System.Drawing.Point(571, 1022);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nombre de aerolinea";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 750);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(324, 26);
            this.label6.TabIndex = 50;
            this.label6.Text = "Aviones inactivos por aerolineas";
            // 
            // dataGridJose
            // 
            this.dataGridJose.BackgroundColor = System.Drawing.Color.White;
            this.dataGridJose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJose.Location = new System.Drawing.Point(532, 791);
            this.dataGridJose.Name = "dataGridJose";
            this.dataGridJose.RowHeadersWidth = 51;
            this.dataGridJose.Size = new System.Drawing.Size(370, 214);
            this.dataGridJose.TabIndex = 49;
            // 
            // PanelReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(993, 582);
            this.Controls.Add(this.textboxjose);
            this.Controls.Add(this.butonjose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridJose);
            this.Controls.Add(this.buttonCheckFlys1);
            this.Controls.Add(this.fligthPerPassengerGrid);
            this.Controls.Add(this.fligthsXPassengerLabel);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btPassengers);
            this.Controls.Add(this.tbFlights);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAire8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAir1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fligthPerPassengerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.DataGridView dataGridViewAirPlanes_AirLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
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
		private Guna.UI2.WinForms.Guna2DataGridView tbPlanes;
		private Guna.UI2.WinForms.Guna2Button btPlanesByCity;
		private Guna.UI2.WinForms.Guna2Button btDifferentPlanes;
		private Guna.UI2.WinForms.Guna2Button btTopCity;
		public Guna.UI2.WinForms.Guna2ComboBox cbAirlines;
		private System.Windows.Forms.Label lbAirline;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartTopDays;
	}
		private Guna.UI2.WinForms.Guna2DataGridView tbFlights;
		private Guna.UI2.WinForms.Guna2Button btPassengers;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label fligthsXPassengerLabel;
        private Guna.UI2.WinForms.Guna2DataGridView fligthPerPassengerGrid;
        private Guna.UI2.WinForms.Guna2Button buttonCheckFlys1;
        private Guna.UI2.WinForms.Guna2TextBox textboxjose;
        private Guna.UI2.WinForms.Guna2Button butonjose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridJose;
    }
}
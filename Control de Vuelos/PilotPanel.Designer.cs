using System.Windows.Forms;

namespace Control_de_Vuelos {
	partial class PilotPanel {
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
            this.btnAddPilot = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifyPilot = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeletePilot = new Guna.UI2.WinForms.Guna2Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.lastName2TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.lastName2Label = new System.Windows.Forms.Label();
            this.lastName1TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.lasName1Label = new System.Windows.Forms.Label();
            this.identityTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.identityLabel = new System.Windows.Forms.Label();
            this.nameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pilotsGrid = new System.Windows.Forms.DataGridView();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.airlineLabel = new System.Windows.Forms.Label();
            this.airlineTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.airlineB = new Guna.UI2.WinForms.Guna2Button();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilotsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPilot
            // 
            this.btnAddPilot.Animated = true;
            this.btnAddPilot.AutoRoundedCorners = true;
            this.btnAddPilot.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPilot.BorderColor = System.Drawing.Color.White;
            this.btnAddPilot.BorderRadius = 22;
            this.btnAddPilot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPilot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPilot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPilot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPilot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.btnAddPilot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddPilot.ForeColor = System.Drawing.Color.White;
            this.btnAddPilot.Location = new System.Drawing.Point(41, 42);
            this.btnAddPilot.Name = "btnAddPilot";
            this.btnAddPilot.PressedColor = System.Drawing.Color.Teal;
            this.btnAddPilot.Size = new System.Drawing.Size(226, 46);
            this.btnAddPilot.TabIndex = 0;
            this.btnAddPilot.Text = "Registrar Piloto";
            this.btnAddPilot.Click += new System.EventHandler(this.btnAddPilot_Click);
            // 
            // btnModifyPilot
            // 
            this.btnModifyPilot.Animated = true;
            this.btnModifyPilot.AutoRoundedCorners = true;
            this.btnModifyPilot.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyPilot.BorderColor = System.Drawing.Color.White;
            this.btnModifyPilot.BorderRadius = 22;
            this.btnModifyPilot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModifyPilot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModifyPilot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModifyPilot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModifyPilot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.btnModifyPilot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnModifyPilot.ForeColor = System.Drawing.Color.White;
            this.btnModifyPilot.Location = new System.Drawing.Point(41, 629);
            this.btnModifyPilot.Name = "btnModifyPilot";
            this.btnModifyPilot.PressedColor = System.Drawing.Color.Teal;
            this.btnModifyPilot.Size = new System.Drawing.Size(226, 46);
            this.btnModifyPilot.TabIndex = 1;
            this.btnModifyPilot.Text = "Modificar Piloto";
            this.btnModifyPilot.Visible = false;
            this.btnModifyPilot.Click += new System.EventHandler(this.btnModifyPilot_Click);
            // 
            // btnDeletePilot
            // 
            this.btnDeletePilot.Animated = true;
            this.btnDeletePilot.AutoRoundedCorners = true;
            this.btnDeletePilot.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletePilot.BorderColor = System.Drawing.Color.White;
            this.btnDeletePilot.BorderRadius = 22;
            this.btnDeletePilot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeletePilot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeletePilot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeletePilot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeletePilot.FillColor = System.Drawing.Color.Red;
            this.btnDeletePilot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDeletePilot.ForeColor = System.Drawing.Color.White;
            this.btnDeletePilot.Location = new System.Drawing.Point(299, 629);
            this.btnDeletePilot.Name = "btnDeletePilot";
            this.btnDeletePilot.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeletePilot.Size = new System.Drawing.Size(226, 46);
            this.btnDeletePilot.TabIndex = 2;
            this.btnDeletePilot.Text = "Eliminar Piloto";
            this.btnDeletePilot.Visible = false;
            this.btnDeletePilot.Click += new System.EventHandler(this.btnDeletePilot_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.AutoScroll = true;
            this.searchPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Controls.Add(this.searchTB);
            this.searchPanel.Location = new System.Drawing.Point(615, 36);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(579, 80);
            this.searchPanel.TabIndex = 3;
            this.searchPanel.Visible = false;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.searchLabel.Location = new System.Drawing.Point(3, 34);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(94, 21);
            this.searchLabel.TabIndex = 11;
            this.searchLabel.Text = "Busqueda";
            // 
            // searchTB
            // 
            this.searchTB.AutoRoundedCorners = true;
            this.searchTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.searchTB.BorderRadius = 21;
            this.searchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTB.DefaultText = "";
            this.searchTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.searchTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTB.Location = new System.Drawing.Point(113, 21);
            this.searchTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTB.Name = "searchTB";
            this.searchTB.PasswordChar = '\0';
            this.searchTB.PlaceholderText = "";
            this.searchTB.SelectedText = "";
            this.searchTB.Size = new System.Drawing.Size(351, 44);
            this.searchTB.TabIndex = 11;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // lastName2TB
            // 
            this.lastName2TB.AutoRoundedCorners = true;
            this.lastName2TB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.lastName2TB.BorderRadius = 21;
            this.lastName2TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastName2TB.DefaultText = "";
            this.lastName2TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastName2TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastName2TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastName2TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastName2TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastName2TB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lastName2TB.ForeColor = System.Drawing.Color.Black;
            this.lastName2TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastName2TB.Location = new System.Drawing.Point(68, 426);
            this.lastName2TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastName2TB.Name = "lastName2TB";
            this.lastName2TB.PasswordChar = '\0';
            this.lastName2TB.PlaceholderText = "";
            this.lastName2TB.SelectedText = "";
            this.lastName2TB.Size = new System.Drawing.Size(457, 44);
            this.lastName2TB.TabIndex = 10;
            // 
            // lastName2Label
            // 
            this.lastName2Label.AutoSize = true;
            this.lastName2Label.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lastName2Label.Location = new System.Drawing.Point(64, 401);
            this.lastName2Label.Name = "lastName2Label";
            this.lastName2Label.Size = new System.Drawing.Size(156, 21);
            this.lastName2Label.TabIndex = 9;
            this.lastName2Label.Text = "Apellido Materno";
            // 
            // lastName1TB
            // 
            this.lastName1TB.AutoRoundedCorners = true;
            this.lastName1TB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.lastName1TB.BorderRadius = 21;
            this.lastName1TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastName1TB.DefaultText = "";
            this.lastName1TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastName1TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastName1TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastName1TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastName1TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastName1TB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lastName1TB.ForeColor = System.Drawing.Color.Black;
            this.lastName1TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastName1TB.Location = new System.Drawing.Point(68, 343);
            this.lastName1TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastName1TB.Name = "lastName1TB";
            this.lastName1TB.PasswordChar = '\0';
            this.lastName1TB.PlaceholderText = "";
            this.lastName1TB.SelectedText = "";
            this.lastName1TB.Size = new System.Drawing.Size(457, 44);
            this.lastName1TB.TabIndex = 8;
            // 
            // lasName1Label
            // 
            this.lasName1Label.AutoSize = true;
            this.lasName1Label.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lasName1Label.Location = new System.Drawing.Point(64, 318);
            this.lasName1Label.Name = "lasName1Label";
            this.lasName1Label.Size = new System.Drawing.Size(149, 21);
            this.lasName1Label.TabIndex = 7;
            this.lasName1Label.Text = "Apellido Paterno";
            // 
            // identityTB
            // 
            this.identityTB.AutoRoundedCorners = true;
            this.identityTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.identityTB.BorderRadius = 21;
            this.identityTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.identityTB.DefaultText = "";
            this.identityTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.identityTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.identityTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.identityTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.identityTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.identityTB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.identityTB.ForeColor = System.Drawing.Color.Black;
            this.identityTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.identityTB.Location = new System.Drawing.Point(68, 155);
            this.identityTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.identityTB.Name = "identityTB";
            this.identityTB.PasswordChar = '\0';
            this.identityTB.PlaceholderText = "";
            this.identityTB.SelectedText = "";
            this.identityTB.Size = new System.Drawing.Size(457, 44);
            this.identityTB.TabIndex = 6;
            // 
            // identityLabel
            // 
            this.identityLabel.AutoSize = true;
            this.identityLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.identityLabel.Location = new System.Drawing.Point(64, 130);
            this.identityLabel.Name = "identityLabel";
            this.identityLabel.Size = new System.Drawing.Size(72, 21);
            this.identityLabel.TabIndex = 5;
            this.identityLabel.Text = "Cedula";
            // 
            // nameTB
            // 
            this.nameTB.AutoRoundedCorners = true;
            this.nameTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.nameTB.BorderRadius = 21;
            this.nameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTB.DefaultText = "";
            this.nameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.nameTB.ForeColor = System.Drawing.Color.Black;
            this.nameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTB.Location = new System.Drawing.Point(68, 257);
            this.nameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTB.Name = "nameTB";
            this.nameTB.PasswordChar = '\0';
            this.nameTB.PlaceholderText = "";
            this.nameTB.SelectedText = "";
            this.nameTB.Size = new System.Drawing.Size(457, 44);
            this.nameTB.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.nameLabel.Location = new System.Drawing.Point(64, 232);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(77, 21);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Nombre";
            // 
            // pilotsGrid
            // 
            this.pilotsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.pilotsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pilotsGrid.Location = new System.Drawing.Point(622, 134);
            this.pilotsGrid.Name = "pilotsGrid";
            this.pilotsGrid.RowHeadersWidth = 51;
            this.pilotsGrid.RowTemplate.Height = 24;
            this.pilotsGrid.Size = new System.Drawing.Size(572, 468);
            this.pilotsGrid.TabIndex = 12;
            this.pilotsGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.pilotsGrid_CellMouseDown_1);
            this.pilotsGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.pilotsGrid_RowPrePaint);
            this.pilotsGrid.SelectionChanged += new System.EventHandler(this.pilotsGrid_SelectionChanged_1);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.countryLabel.Location = new System.Drawing.Point(64, 491);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(130, 21);
            this.countryLabel.TabIndex = 13;
            this.countryLabel.Text = "Pais de Origen";
            // 
            // countryCB
            // 
            this.countryCB.BackColor = System.Drawing.Color.Transparent;
            this.countryCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.countryCB.BorderRadius = 15;
            this.countryCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.countryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.countryCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.countryCB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.countryCB.ForeColor = System.Drawing.Color.Black;
            this.countryCB.ItemHeight = 30;
            this.countryCB.Location = new System.Drawing.Point(68, 515);
            this.countryCB.Name = "countryCB";
            this.countryCB.Size = new System.Drawing.Size(199, 36);
            this.countryCB.TabIndex = 14;
            // 
            // airlineLabel
            // 
            this.airlineLabel.AutoSize = true;
            this.airlineLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.airlineLabel.Location = new System.Drawing.Point(295, 490);
            this.airlineLabel.Name = "airlineLabel";
            this.airlineLabel.Size = new System.Drawing.Size(89, 21);
            this.airlineLabel.TabIndex = 15;
            this.airlineLabel.Text = "Aerolinea";
            // 
            // airlineTB
            // 
            this.airlineTB.AutoRoundedCorners = true;
            this.airlineTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.airlineTB.BorderRadius = 21;
            this.airlineTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.airlineTB.DefaultText = "";
            this.airlineTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.airlineTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.airlineTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.airlineTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.airlineTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.airlineTB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.airlineTB.ForeColor = System.Drawing.Color.Black;
            this.airlineTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.airlineTB.Location = new System.Drawing.Point(299, 515);
            this.airlineTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.airlineTB.Name = "airlineTB";
            this.airlineTB.PasswordChar = '\0';
            this.airlineTB.PlaceholderText = "";
            this.airlineTB.ReadOnly = true;
            this.airlineTB.SelectedText = "";
            this.airlineTB.Size = new System.Drawing.Size(166, 44);
            this.airlineTB.TabIndex = 16;
            // 
            // airlineB
            // 
            this.airlineB.Animated = true;
            this.airlineB.AutoRoundedCorners = true;
            this.airlineB.BackColor = System.Drawing.Color.Transparent;
            this.airlineB.BorderColor = System.Drawing.Color.White;
            this.airlineB.BorderRadius = 22;
            this.airlineB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.airlineB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.airlineB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.airlineB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.airlineB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.airlineB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.airlineB.ForeColor = System.Drawing.Color.White;
            this.airlineB.Location = new System.Drawing.Point(473, 515);
            this.airlineB.Name = "airlineB";
            this.airlineB.PressedColor = System.Drawing.Color.Teal;
            this.airlineB.Size = new System.Drawing.Size(52, 46);
            this.airlineB.TabIndex = 17;
            this.airlineB.Text = "🔍";
            this.airlineB.Click += new System.EventHandler(this.airlineB_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Animated = true;
            this.btnReturn.AutoRoundedCorners = true;
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BorderColor = System.Drawing.Color.White;
            this.btnReturn.BorderRadius = 22;
            this.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(299, 45);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.PressedColor = System.Drawing.Color.Teal;
            this.btnReturn.Size = new System.Drawing.Size(226, 46);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Volver a Registro";
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // PilotPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 727);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.airlineB);
            this.Controls.Add(this.airlineTB);
            this.Controls.Add(this.airlineLabel);
            this.Controls.Add(this.countryCB);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.lastName2TB);
            this.Controls.Add(this.lastName2Label);
            this.Controls.Add(this.pilotsGrid);
            this.Controls.Add(this.lastName1TB);
            this.Controls.Add(this.lasName1Label);
            this.Controls.Add(this.identityTB);
            this.Controls.Add(this.identityLabel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.btnDeletePilot);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.btnModifyPilot);
            this.Controls.Add(this.btnAddPilot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1220, 727);
            this.MinimumSize = new System.Drawing.Size(1220, 727);
            this.Name = "PilotPanel";
            this.Text = "PanelPilotos";
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilotsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAddPilot;
        private Guna.UI2.WinForms.Guna2Button btnModifyPilot;
        private Guna.UI2.WinForms.Guna2Button btnDeletePilot;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label nameLabel;
        private Guna.UI2.WinForms.Guna2TextBox nameTB;
        private Guna.UI2.WinForms.Guna2TextBox identityTB;
        private System.Windows.Forms.Label identityLabel;
        private Guna.UI2.WinForms.Guna2TextBox lastName2TB;
        private System.Windows.Forms.Label lastName2Label;
        private Guna.UI2.WinForms.Guna2TextBox lastName1TB;
        private System.Windows.Forms.Label lasName1Label;
        private System.Windows.Forms.Label searchLabel;
        private Guna.UI2.WinForms.Guna2TextBox searchTB;
        private System.Windows.Forms.DataGridView pilotsGrid;
        private System.Windows.Forms.Label countryLabel;
        private Guna.UI2.WinForms.Guna2ComboBox countryCB;
        private Label airlineLabel;
        private Guna.UI2.WinForms.Guna2TextBox airlineTB;
        private Guna.UI2.WinForms.Guna2Button airlineB;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
    }
}
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btPassengers = new Guna.UI2.WinForms.Guna2Button();
			this.btFlights = new Guna.UI2.WinForms.Guna2Button();
			this.btLeftOption = new Guna.UI2.WinForms.Guna2Button();
			this.pInputArea = new System.Windows.Forms.Panel();
			this.lbSelectOpt = new System.Windows.Forms.Label();
			this.btRightOption = new Guna.UI2.WinForms.Guna2Button();
			this.tbFlights = new Guna.UI2.WinForms.Guna2DataGridView();
			this.btBottomOption = new Guna.UI2.WinForms.Guna2Button();
			this.cbAirlines = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbAirline = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.tbFlights)).BeginInit();
			this.SuspendLayout();
			// 
			// btPassengers
			// 
			this.btPassengers.Animated = true;
			this.btPassengers.AutoRoundedCorners = true;
			this.btPassengers.BackColor = System.Drawing.Color.Transparent;
			this.btPassengers.BorderColor = System.Drawing.Color.White;
			this.btPassengers.BorderRadius = 22;
			this.btPassengers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btPassengers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btPassengers.ForeColor = System.Drawing.Color.White;
			this.btPassengers.Location = new System.Drawing.Point(14, 33);
			this.btPassengers.Name = "btPassengers";
			this.btPassengers.PressedColor = System.Drawing.Color.Teal;
			this.btPassengers.ShadowDecoration.BorderRadius = 0;
			this.btPassengers.ShadowDecoration.Depth = 0;
			this.btPassengers.ShadowDecoration.Enabled = true;
			this.btPassengers.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btPassengers.Size = new System.Drawing.Size(226, 46);
			this.btPassengers.TabIndex = 6;
			this.btPassengers.Text = "Pasajeros";
			this.btPassengers.Click += new System.EventHandler(this.button_Click);
			// 
			// btFlights
			// 
			this.btFlights.Animated = true;
			this.btFlights.AutoRoundedCorners = true;
			this.btFlights.BackColor = System.Drawing.Color.Transparent;
			this.btFlights.BorderColor = System.Drawing.Color.White;
			this.btFlights.BorderRadius = 22;
			this.btFlights.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btFlights.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btFlights.ForeColor = System.Drawing.Color.White;
			this.btFlights.Location = new System.Drawing.Point(256, 33);
			this.btFlights.Name = "btFlights";
			this.btFlights.PressedColor = System.Drawing.Color.Teal;
			this.btFlights.ShadowDecoration.BorderRadius = 30;
			this.btFlights.ShadowDecoration.Depth = 0;
			this.btFlights.ShadowDecoration.Enabled = true;
			this.btFlights.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btFlights.Size = new System.Drawing.Size(226, 46);
			this.btFlights.TabIndex = 7;
			this.btFlights.Text = "Vuelos";
			this.btFlights.Click += new System.EventHandler(this.button_Click);
			// 
			// btLeftOption
			// 
			this.btLeftOption.AutoRoundedCorners = true;
			this.btLeftOption.BackColor = System.Drawing.Color.Transparent;
			this.btLeftOption.BorderColor = System.Drawing.Color.White;
			this.btLeftOption.BorderRadius = 22;
			this.btLeftOption.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btLeftOption.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btLeftOption.ForeColor = System.Drawing.Color.White;
			this.btLeftOption.Location = new System.Drawing.Point(14, 614);
			this.btLeftOption.Name = "btLeftOption";
			this.btLeftOption.PressedColor = System.Drawing.Color.Teal;
			this.btLeftOption.ShadowDecoration.BorderRadius = 30;
			this.btLeftOption.ShadowDecoration.Depth = 0;
			this.btLeftOption.ShadowDecoration.Enabled = true;
			this.btLeftOption.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btLeftOption.Size = new System.Drawing.Size(226, 46);
			this.btLeftOption.TabIndex = 8;
			this.btLeftOption.Text = "Modificar/Eliminar";
			this.btLeftOption.Click += new System.EventHandler(this.btLeftOption_Click);
			// 
			// pInputArea
			// 
			this.pInputArea.BackColor = System.Drawing.Color.Transparent;
			this.pInputArea.Location = new System.Drawing.Point(14, 85);
			this.pInputArea.Name = "pInputArea";
			this.pInputArea.Size = new System.Drawing.Size(500, 520);
			this.pInputArea.TabIndex = 9;
			// 
			// lbSelectOpt
			// 
			this.lbSelectOpt.AutoSize = true;
			this.lbSelectOpt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSelectOpt.Location = new System.Drawing.Point(100, 325);
			this.lbSelectOpt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbSelectOpt.Name = "lbSelectOpt";
			this.lbSelectOpt.Size = new System.Drawing.Size(300, 54);
			this.lbSelectOpt.TabIndex = 4;
			this.lbSelectOpt.Text = "Seleccione una opción \r\npara mostrar información";
			this.lbSelectOpt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btRightOption
			// 
			this.btRightOption.AutoRoundedCorners = true;
			this.btRightOption.BackColor = System.Drawing.Color.Transparent;
			this.btRightOption.BorderColor = System.Drawing.Color.White;
			this.btRightOption.BorderRadius = 22;
			this.btRightOption.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btRightOption.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btRightOption.ForeColor = System.Drawing.Color.White;
			this.btRightOption.Location = new System.Drawing.Point(256, 614);
			this.btRightOption.Name = "btRightOption";
			this.btRightOption.PressedColor = System.Drawing.Color.Teal;
			this.btRightOption.ShadowDecoration.BorderRadius = 30;
			this.btRightOption.ShadowDecoration.Depth = 0;
			this.btRightOption.ShadowDecoration.Enabled = true;
			this.btRightOption.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btRightOption.Size = new System.Drawing.Size(226, 46);
			this.btRightOption.TabIndex = 10;
			this.btRightOption.Text = "Confirmar/Modificar";
			this.btRightOption.Click += new System.EventHandler(this.btRightOption_Click);
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
			this.tbFlights.Location = new System.Drawing.Point(520, 88);
			this.tbFlights.Name = "tbFlights";
			this.tbFlights.ReadOnly = true;
			this.tbFlights.RowHeadersVisible = false;
			this.tbFlights.RowHeadersWidth = 51;
			this.tbFlights.RowTemplate.Height = 50;
			this.tbFlights.Size = new System.Drawing.Size(688, 588);
			this.tbFlights.TabIndex = 11;
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
			this.tbFlights.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbFlights_CellDoubleClick);
			// 
			// btBottomOption
			// 
			this.btBottomOption.AutoRoundedCorners = true;
			this.btBottomOption.BackColor = System.Drawing.Color.Transparent;
			this.btBottomOption.BorderColor = System.Drawing.Color.White;
			this.btBottomOption.BorderRadius = 22;
			this.btBottomOption.FillColor = System.Drawing.SystemColors.HotTrack;
			this.btBottomOption.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btBottomOption.ForeColor = System.Drawing.Color.White;
			this.btBottomOption.Location = new System.Drawing.Point(129, 666);
			this.btBottomOption.Name = "btBottomOption";
			this.btBottomOption.PressedColor = System.Drawing.Color.Teal;
			this.btBottomOption.ShadowDecoration.BorderRadius = 30;
			this.btBottomOption.ShadowDecoration.Depth = 0;
			this.btBottomOption.ShadowDecoration.Enabled = true;
			this.btBottomOption.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btBottomOption.Size = new System.Drawing.Size(226, 46);
			this.btBottomOption.TabIndex = 12;
			this.btBottomOption.Text = "Confirmar Pasajeros";
			this.btBottomOption.Click += new System.EventHandler(this.btBottomOption_Click);
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
			this.cbAirlines.Location = new System.Drawing.Point(864, 33);
			this.cbAirlines.Name = "cbAirlines";
			this.cbAirlines.Size = new System.Drawing.Size(344, 36);
			this.cbAirlines.TabIndex = 25;
			this.cbAirlines.SelectedIndexChanged += new System.EventHandler(this.cbAirlines_IndexChanged);
			// 
			// lbAirline
			// 
			this.lbAirline.AutoSize = true;
			this.lbAirline.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAirline.Location = new System.Drawing.Point(734, 42);
			this.lbAirline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbAirline.Name = "lbAirline";
			this.lbAirline.Size = new System.Drawing.Size(123, 27);
			this.lbAirline.TabIndex = 26;
			this.lbAirline.Text = "Aerolínea";
			this.lbAirline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FlightsPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1220, 727);
			this.Controls.Add(this.lbAirline);
			this.Controls.Add(this.cbAirlines);
			this.Controls.Add(this.lbSelectOpt);
			this.Controls.Add(this.pInputArea);
			this.Controls.Add(this.btBottomOption);
			this.Controls.Add(this.tbFlights);
			this.Controls.Add(this.btRightOption);
			this.Controls.Add(this.btLeftOption);
			this.Controls.Add(this.btFlights);
			this.Controls.Add(this.btPassengers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(1220, 727);
			this.MinimumSize = new System.Drawing.Size(1220, 727);
			this.Name = "FlightsPanel";
			this.Text = "PanelVuelos";
			((System.ComponentModel.ISupportInitialize)(this.tbFlights)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Button btPassengers;
		private Guna.UI2.WinForms.Guna2Button btFlights;
		private System.Windows.Forms.Panel pInputArea;
		private System.Windows.Forms.Label lbSelectOpt;
		private Guna.UI2.WinForms.Guna2DataGridView tbFlights;
		public Guna.UI2.WinForms.Guna2Button btRightOption;
		public Guna.UI2.WinForms.Guna2ComboBox cbAirlines;
		private System.Windows.Forms.Label lbAirline;
		public Guna.UI2.WinForms.Guna2Button btBottomOption;
		public Guna.UI2.WinForms.Guna2Button btLeftOption;
	}
}
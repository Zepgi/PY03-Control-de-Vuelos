namespace Control_de_Vuelos {
	partial class MainMenuForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
			this.bExit = new System.Windows.Forms.Button();
			this.btHome = new System.Windows.Forms.Button();
			this.btFlights = new System.Windows.Forms.Button();
			this.btMaintenance = new System.Windows.Forms.Button();
			this.btReports = new System.Windows.Forms.Button();
			this.btAirlines = new System.Windows.Forms.Button();
			this.btMin = new System.Windows.Forms.Button();
			this.pMenu = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btPlanes = new System.Windows.Forms.Button();
			this.pMaintenance = new System.Windows.Forms.Panel();
			this.btPilots = new System.Windows.Forms.Button();
			this.pLeft = new System.Windows.Forms.Panel();
			this.pBottom = new System.Windows.Forms.Panel();
			this.pMain = new System.Windows.Forms.Panel();
			this.pRight = new System.Windows.Forms.Panel();
			this.pMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pMaintenance.SuspendLayout();
			this.SuspendLayout();
			// 
			// bExit
			// 
			this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.bExit.FlatAppearance.BorderSize = 0;
			this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bExit.ForeColor = System.Drawing.Color.White;
			this.bExit.Image = ((System.Drawing.Image)(resources.GetObject("bExit.Image")));
			this.bExit.Location = new System.Drawing.Point(1502, 3);
			this.bExit.Name = "bExit";
			this.bExit.Size = new System.Drawing.Size(47, 43);
			this.bExit.TabIndex = 0;
			this.bExit.UseMnemonic = false;
			this.bExit.UseVisualStyleBackColor = true;
			this.bExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btExit_Click);
			// 
			// btHome
			// 
			this.btHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btHome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btHome.FlatAppearance.BorderSize = 0;
			this.btHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btHome.Image = global::Control_de_Vuelos.Properties.Resources.home_page_icon;
			this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btHome.Location = new System.Drawing.Point(330, 51);
			this.btHome.Name = "btHome";
			this.btHome.Size = new System.Drawing.Size(224, 50);
			this.btHome.TabIndex = 1;
			this.btHome.Text = "Inicio";
			this.btHome.UseVisualStyleBackColor = true;
			this.btHome.Click += new System.EventHandler(this.bt_Click);
			this.btHome.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
			this.btHome.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			// 
			// btFlights
			// 
			this.btFlights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btFlights.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btFlights.FlatAppearance.BorderSize = 0;
			this.btFlights.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btFlights.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btFlights.Image = global::Control_de_Vuelos.Properties.Resources.trip_icon;
			this.btFlights.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btFlights.Location = new System.Drawing.Point(581, 51);
			this.btFlights.Name = "btFlights";
			this.btFlights.Size = new System.Drawing.Size(224, 50);
			this.btFlights.TabIndex = 2;
			this.btFlights.Text = "Vuelos";
			this.btFlights.UseVisualStyleBackColor = true;
			this.btFlights.Click += new System.EventHandler(this.bt_Click);
			this.btFlights.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
			this.btFlights.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			// 
			// btMaintenance
			// 
			this.btMaintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btMaintenance.FlatAppearance.BorderSize = 0;
			this.btMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btMaintenance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btMaintenance.Image")));
			this.btMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btMaintenance.Location = new System.Drawing.Point(1077, 51);
			this.btMaintenance.Name = "btMaintenance";
			this.btMaintenance.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btMaintenance.Size = new System.Drawing.Size(224, 50);
			this.btMaintenance.TabIndex = 4;
			this.btMaintenance.Text = "Mantenimiento";
			this.btMaintenance.UseVisualStyleBackColor = true;
			this.btMaintenance.Click += new System.EventHandler(this.bt_Click);
			this.btMaintenance.MouseEnter += new System.EventHandler(this.btMantenimiento_MouseEnter);
			this.btMaintenance.MouseLeave += new System.EventHandler(this.btMantenimiento_MouseLeave);
			// 
			// btReports
			// 
			this.btReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btReports.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btReports.FlatAppearance.BorderSize = 0;
			this.btReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btReports.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btReports.Image = global::Control_de_Vuelos.Properties.Resources.stats_icon;
			this.btReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btReports.Location = new System.Drawing.Point(829, 51);
			this.btReports.Name = "btReports";
			this.btReports.Size = new System.Drawing.Size(224, 50);
			this.btReports.TabIndex = 5;
			this.btReports.Text = "Reportes";
			this.btReports.UseVisualStyleBackColor = true;
			this.btReports.Click += new System.EventHandler(this.bt_Click);
			this.btReports.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
			this.btReports.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			// 
			// btAirlines
			// 
			this.btAirlines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btAirlines.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btAirlines.FlatAppearance.BorderSize = 0;
			this.btAirlines.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btAirlines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btAirlines.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAirlines.Image = global::Control_de_Vuelos.Properties.Resources.airline_icon;
			this.btAirlines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btAirlines.Location = new System.Drawing.Point(1325, 51);
			this.btAirlines.Name = "btAirlines";
			this.btAirlines.Size = new System.Drawing.Size(224, 50);
			this.btAirlines.TabIndex = 6;
			this.btAirlines.Text = "Aerolineas";
			this.btAirlines.UseVisualStyleBackColor = true;
			this.btAirlines.Click += new System.EventHandler(this.bt_Click);
			this.btAirlines.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
			this.btAirlines.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			// 
			// btMin
			// 
			this.btMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btMin.FlatAppearance.BorderSize = 0;
			this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btMin.ForeColor = System.Drawing.Color.White;
			this.btMin.Image = ((System.Drawing.Image)(resources.GetObject("btMin.Image")));
			this.btMin.Location = new System.Drawing.Point(1464, 0);
			this.btMin.Name = "btMin";
			this.btMin.Size = new System.Drawing.Size(30, 43);
			this.btMin.TabIndex = 7;
			this.btMin.UseMnemonic = false;
			this.btMin.UseVisualStyleBackColor = true;
			this.btMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btMin_Click);
			// 
			// pMenu
			// 
			this.pMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pMenu.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pMenu.Controls.Add(this.pictureBox1);
			this.pMenu.Controls.Add(this.btMin);
			this.pMenu.Controls.Add(this.btAirlines);
			this.pMenu.Controls.Add(this.btReports);
			this.pMenu.Controls.Add(this.btMaintenance);
			this.pMenu.Controls.Add(this.btFlights);
			this.pMenu.Controls.Add(this.btHome);
			this.pMenu.Controls.Add(this.bExit);
			this.pMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.pMenu.Location = new System.Drawing.Point(-320, 0);
			this.pMenu.Name = "pMenu";
			this.pMenu.Size = new System.Drawing.Size(1920, 106);
			this.pMenu.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Control_de_Vuelos.Properties.Resources.config_icon;
			this.pictureBox1.Location = new System.Drawing.Point(1080, 58);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(30, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btPlanes
			// 
			this.btPlanes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btPlanes.FlatAppearance.BorderSize = 0;
			this.btPlanes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btPlanes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btPlanes.Image = global::Control_de_Vuelos.Properties.Resources.plane_icon;
			this.btPlanes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btPlanes.Location = new System.Drawing.Point(0, 3);
			this.btPlanes.Name = "btPlanes";
			this.btPlanes.Size = new System.Drawing.Size(224, 50);
			this.btPlanes.TabIndex = 7;
			this.btPlanes.Text = "Aviones";
			this.btPlanes.UseVisualStyleBackColor = true;
			this.btPlanes.Click += new System.EventHandler(this.bt_Click);
			this.btPlanes.MouseEnter += new System.EventHandler(this.pMantenimiento_MouseEnter);
			this.btPlanes.MouseLeave += new System.EventHandler(this.pMantenimiento_MouseLeave);
			// 
			// pMaintenance
			// 
			this.pMaintenance.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pMaintenance.Controls.Add(this.btPlanes);
			this.pMaintenance.Controls.Add(this.btPilots);
			this.pMaintenance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pMaintenance.ForeColor = System.Drawing.Color.White;
			this.pMaintenance.Location = new System.Drawing.Point(757, 106);
			this.pMaintenance.Name = "pMaintenance";
			this.pMaintenance.Size = new System.Drawing.Size(224, 100);
			this.pMaintenance.TabIndex = 3;
			this.pMaintenance.Visible = false;
			this.pMaintenance.MouseEnter += new System.EventHandler(this.pMantenimiento_MouseEnter);
			this.pMaintenance.MouseLeave += new System.EventHandler(this.pMantenimiento_MouseLeave);
			// 
			// btPilots
			// 
			this.btPilots.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btPilots.FlatAppearance.BorderSize = 0;
			this.btPilots.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btPilots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btPilots.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btPilots.Image = global::Control_de_Vuelos.Properties.Resources.pilot_icon;
			this.btPilots.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btPilots.Location = new System.Drawing.Point(0, 50);
			this.btPilots.Name = "btPilots";
			this.btPilots.Size = new System.Drawing.Size(224, 50);
			this.btPilots.TabIndex = 8;
			this.btPilots.Text = "Pilotos";
			this.btPilots.UseVisualStyleBackColor = true;
			this.btPilots.Click += new System.EventHandler(this.bt_Click);
			this.btPilots.MouseEnter += new System.EventHandler(this.pMantenimiento_MouseEnter);
			this.btPilots.MouseLeave += new System.EventHandler(this.pMantenimiento_MouseLeave);
			// 
			// pLeft
			// 
			this.pLeft.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.pLeft.Location = new System.Drawing.Point(0, -97);
			this.pLeft.Name = "pLeft";
			this.pLeft.Size = new System.Drawing.Size(10, 997);
			this.pLeft.TabIndex = 1;
			// 
			// pBottom
			// 
			this.pBottom.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pBottom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.pBottom.Location = new System.Drawing.Point(0, 835);
			this.pBottom.Name = "pBottom";
			this.pBottom.Size = new System.Drawing.Size(1230, 10);
			this.pBottom.TabIndex = 3;
			// 
			// pMain
			// 
			this.pMain.Location = new System.Drawing.Point(10, 106);
			this.pMain.MaximumSize = new System.Drawing.Size(1220, 727);
			this.pMain.MinimumSize = new System.Drawing.Size(1220, 727);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(1220, 727);
			this.pMain.TabIndex = 4;
			// 
			// pRight
			// 
			this.pRight.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.pRight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.pRight.Location = new System.Drawing.Point(1230, 0);
			this.pRight.Name = "pRight";
			this.pRight.Size = new System.Drawing.Size(10, 845);
			this.pRight.TabIndex = 2;
			// 
			// MainMenuForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1240, 845);
			this.Controls.Add(this.pMaintenance);
			this.Controls.Add(this.pMain);
			this.Controls.Add(this.pBottom);
			this.Controls.Add(this.pRight);
			this.Controls.Add(this.pLeft);
			this.Controls.Add(this.pMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainMenuForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainMenuView";
			this.pMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pMaintenance.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button bExit;
		private System.Windows.Forms.Button btHome;
		private System.Windows.Forms.Button btFlights;
		private System.Windows.Forms.Button btMaintenance;
		private System.Windows.Forms.Button btReports;
		private System.Windows.Forms.Button btAirlines;
		private System.Windows.Forms.Button btMin;
		private System.Windows.Forms.Panel pMenu;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btPlanes;
		private System.Windows.Forms.Panel pMaintenance;
		private System.Windows.Forms.Button btPilots;
		private System.Windows.Forms.Panel pLeft;
		private System.Windows.Forms.Panel pBottom;
		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Panel pRight;
	}
}
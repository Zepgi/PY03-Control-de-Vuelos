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
			this.pMenu = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btMin = new System.Windows.Forms.Button();
			this.btAerolineas = new System.Windows.Forms.Button();
			this.btReportes = new System.Windows.Forms.Button();
			this.btMantenimiento = new System.Windows.Forms.Button();
			this.btVuelos = new System.Windows.Forms.Button();
			this.btInicio = new System.Windows.Forms.Button();
			this.bExit = new System.Windows.Forms.Button();
			this.pMain = new System.Windows.Forms.Panel();
			this.pRight = new System.Windows.Forms.Panel();
			this.pLeft = new System.Windows.Forms.Panel();
			this.pBottom = new System.Windows.Forms.Panel();
			this.pMantenimiento = new System.Windows.Forms.Panel();
			this.btAviones = new System.Windows.Forms.Button();
			this.btPilotos = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pMantenimiento.SuspendLayout();
			this.SuspendLayout();
			// 
			// pMenu
			// 
			this.pMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pMenu.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pMenu.Controls.Add(this.pictureBox1);
			this.pMenu.Controls.Add(this.btMin);
			this.pMenu.Controls.Add(this.btAerolineas);
			this.pMenu.Controls.Add(this.btReportes);
			this.pMenu.Controls.Add(this.btMantenimiento);
			this.pMenu.Controls.Add(this.btVuelos);
			this.pMenu.Controls.Add(this.btInicio);
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
			// btAerolineas
			// 
			this.btAerolineas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btAerolineas.FlatAppearance.BorderSize = 0;
			this.btAerolineas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btAerolineas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btAerolineas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAerolineas.Image = global::Control_de_Vuelos.Properties.Resources.airline_icon;
			this.btAerolineas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btAerolineas.Location = new System.Drawing.Point(1325, 51);
			this.btAerolineas.Name = "btAerolineas";
			this.btAerolineas.Size = new System.Drawing.Size(224, 50);
			this.btAerolineas.TabIndex = 6;
			this.btAerolineas.Text = "Aerolineas";
			this.btAerolineas.UseVisualStyleBackColor = true;
			this.btAerolineas.Click += new System.EventHandler(this.btAerolineas_Click);
			this.btAerolineas.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
			this.btAerolineas.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			// 
			// btReportes
			// 
			this.btReportes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btReportes.FlatAppearance.BorderSize = 0;
			this.btReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btReportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btReportes.Image = global::Control_de_Vuelos.Properties.Resources.stats_icon;
			this.btReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btReportes.Location = new System.Drawing.Point(829, 51);
			this.btReportes.Name = "btReportes";
			this.btReportes.Size = new System.Drawing.Size(224, 50);
			this.btReportes.TabIndex = 5;
			this.btReportes.Text = "Reportes";
			this.btReportes.UseVisualStyleBackColor = true;
			this.btReportes.Click += new System.EventHandler(this.btReportes_Click);
			this.btReportes.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
			this.btReportes.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			// 
			// btMantenimiento
			// 
			this.btMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btMantenimiento.FlatAppearance.BorderSize = 0;
			this.btMantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btMantenimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btMantenimiento.Image")));
			this.btMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btMantenimiento.Location = new System.Drawing.Point(1077, 51);
			this.btMantenimiento.Name = "btMantenimiento";
			this.btMantenimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btMantenimiento.Size = new System.Drawing.Size(224, 50);
			this.btMantenimiento.TabIndex = 4;
			this.btMantenimiento.Text = "Mantenimiento";
			this.btMantenimiento.UseVisualStyleBackColor = true;
			this.btMantenimiento.Click += new System.EventHandler(this.btMantenimiento_Click);
			this.btMantenimiento.MouseEnter += new System.EventHandler(this.btMantenimiento_MouseEnter);
			this.btMantenimiento.MouseLeave += new System.EventHandler(this.btMantenimiento_MouseLeave);
			// 
			// btVuelos
			// 
			this.btVuelos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btVuelos.FlatAppearance.BorderSize = 0;
			this.btVuelos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btVuelos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btVuelos.Image = global::Control_de_Vuelos.Properties.Resources.trip_icon;
			this.btVuelos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btVuelos.Location = new System.Drawing.Point(581, 51);
			this.btVuelos.Name = "btVuelos";
			this.btVuelos.Size = new System.Drawing.Size(224, 50);
			this.btVuelos.TabIndex = 2;
			this.btVuelos.Text = "Vuelos";
			this.btVuelos.UseVisualStyleBackColor = true;
			this.btVuelos.Click += new System.EventHandler(this.btVuelos_Click);
			this.btVuelos.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
			this.btVuelos.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			// 
			// btInicio
			// 
			this.btInicio.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btInicio.FlatAppearance.BorderSize = 0;
			this.btInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btInicio.Image = global::Control_de_Vuelos.Properties.Resources.home_page_icon;
			this.btInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btInicio.Location = new System.Drawing.Point(330, 51);
			this.btInicio.Name = "btInicio";
			this.btInicio.Size = new System.Drawing.Size(224, 50);
			this.btInicio.TabIndex = 1;
			this.btInicio.Text = "Inicio";
			this.btInicio.UseVisualStyleBackColor = true;
			this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
			this.btInicio.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
			this.btInicio.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
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
			this.pRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.pRight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.pRight.Location = new System.Drawing.Point(1270, -97);
			this.pRight.Name = "pRight";
			this.pRight.Size = new System.Drawing.Size(10, 997);
			this.pRight.TabIndex = 2;
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
			this.pBottom.Dock = System.Windows.Forms.DockStyle.Right;
			this.pBottom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.pBottom.Location = new System.Drawing.Point(1230, 0);
			this.pBottom.Name = "pBottom";
			this.pBottom.Size = new System.Drawing.Size(10, 845);
			this.pBottom.TabIndex = 2;
			// 
			// pMantenimiento
			// 
			this.pMantenimiento.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pMantenimiento.Controls.Add(this.btPilotos);
			this.pMantenimiento.Controls.Add(this.btAviones);
			this.pMantenimiento.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pMantenimiento.ForeColor = System.Drawing.Color.White;
			this.pMantenimiento.Location = new System.Drawing.Point(757, 106);
			this.pMantenimiento.Name = "pMantenimiento";
			this.pMantenimiento.Size = new System.Drawing.Size(224, 100);
			this.pMantenimiento.TabIndex = 3;
			this.pMantenimiento.Visible = false;
			this.pMantenimiento.MouseEnter += new System.EventHandler(this.pMantenimiento_MouseEnter);
			this.pMantenimiento.MouseLeave += new System.EventHandler(this.pMantenimiento_MouseLeave);
			// 
			// btAviones
			// 
			this.btAviones.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btAviones.FlatAppearance.BorderSize = 0;
			this.btAviones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btAviones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btAviones.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAviones.Image = global::Control_de_Vuelos.Properties.Resources.plane_icon;
			this.btAviones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btAviones.Location = new System.Drawing.Point(0, 0);
			this.btAviones.Name = "btAviones";
			this.btAviones.Size = new System.Drawing.Size(224, 50);
			this.btAviones.TabIndex = 7;
			this.btAviones.Text = "Aviones";
			this.btAviones.UseVisualStyleBackColor = true;
			this.btAviones.Click += new System.EventHandler(this.btAviones_Click);
			this.btAviones.MouseEnter += new System.EventHandler(this.pMantenimiento_MouseEnter);
			this.btAviones.MouseLeave += new System.EventHandler(this.pMantenimiento_MouseLeave);
			// 
			// btPilotos
			// 
			this.btPilotos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btPilotos.FlatAppearance.BorderSize = 0;
			this.btPilotos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btPilotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btPilotos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btPilotos.Image = global::Control_de_Vuelos.Properties.Resources.pilot_icon;
			this.btPilotos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btPilotos.Location = new System.Drawing.Point(0, 50);
			this.btPilotos.Name = "btPilotos";
			this.btPilotos.Size = new System.Drawing.Size(224, 50);
			this.btPilotos.TabIndex = 8;
			this.btPilotos.Text = "Pilotos";
			this.btPilotos.UseVisualStyleBackColor = true;
			this.btPilotos.Click += new System.EventHandler(this.btPilotos_Click);
			this.btPilotos.MouseEnter += new System.EventHandler(this.pMantenimiento_MouseEnter);
			this.btPilotos.MouseLeave += new System.EventHandler(this.pMantenimiento_MouseLeave);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel2.Location = new System.Drawing.Point(0, 835);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1230, 10);
			this.panel2.TabIndex = 3;
			// 
			// MainMenuForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1240, 845);
			this.Controls.Add(this.pMantenimiento);
			this.Controls.Add(this.pMain);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pBottom);
			this.Controls.Add(this.pLeft);
			this.Controls.Add(this.pRight);
			this.Controls.Add(this.pMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainMenuForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainMenuView";
			this.pMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pMantenimiento.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMenu;
		private System.Windows.Forms.Panel pRight;
		private System.Windows.Forms.Panel pLeft;
		private System.Windows.Forms.Panel pBottom;
		private System.Windows.Forms.Button bExit;
		private System.Windows.Forms.Button btInicio;
		private System.Windows.Forms.Button btAerolineas;
		private System.Windows.Forms.Button btReportes;
		private System.Windows.Forms.Button btMantenimiento;
		private System.Windows.Forms.Button btVuelos;
		private System.Windows.Forms.Panel pMantenimiento;
		private System.Windows.Forms.Button btAviones;
		private System.Windows.Forms.Button btPilotos;
		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btMin;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
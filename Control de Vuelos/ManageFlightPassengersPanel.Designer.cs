namespace Control_de_Vuelos {
	partial class ManageFlightPassengersPanel {
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
			this.cbFlights = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbFlights = new System.Windows.Forms.Label();
			this.btBookTickets = new Guna.UI2.WinForms.Guna2Button();
			this.planeimg = new System.Windows.Forms.PictureBox();
			this.btConfirmPassengers = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.planeimg)).BeginInit();
			this.SuspendLayout();
			// 
			// cbFlights
			// 
			this.cbFlights.BackColor = System.Drawing.Color.Transparent;
			this.cbFlights.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.cbFlights.BorderRadius = 15;
			this.cbFlights.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbFlights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFlights.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbFlights.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbFlights.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbFlights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbFlights.ItemHeight = 30;
			this.cbFlights.Location = new System.Drawing.Point(354, 142);
			this.cbFlights.Name = "cbFlights";
			this.cbFlights.Size = new System.Drawing.Size(134, 36);
			this.cbFlights.TabIndex = 24;
			this.cbFlights.SelectedIndexChanged += new System.EventHandler(this.cbFlights_SelectedIndexChanged);
			// 
			// lbFlights
			// 
			this.lbFlights.AutoSize = true;
			this.lbFlights.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFlights.Location = new System.Drawing.Point(391, 118);
			this.lbFlights.Name = "lbFlights";
			this.lbFlights.Size = new System.Drawing.Size(58, 21);
			this.lbFlights.TabIndex = 29;
			this.lbFlights.Text = "Vuelo";
			this.lbFlights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btBookTickets
			// 
			this.btBookTickets.AutoRoundedCorners = true;
			this.btBookTickets.BackColor = System.Drawing.Color.Transparent;
			this.btBookTickets.BorderColor = System.Drawing.Color.White;
			this.btBookTickets.BorderRadius = 24;
			this.btBookTickets.FillColor = System.Drawing.SystemColors.HotTrack;
			this.btBookTickets.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btBookTickets.ForeColor = System.Drawing.Color.White;
			this.btBookTickets.Location = new System.Drawing.Point(354, 216);
			this.btBookTickets.Name = "btBookTickets";
			this.btBookTickets.PressedColor = System.Drawing.Color.Teal;
			this.btBookTickets.ShadowDecoration.BorderRadius = 30;
			this.btBookTickets.ShadowDecoration.Depth = 0;
			this.btBookTickets.ShadowDecoration.Enabled = true;
			this.btBookTickets.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btBookTickets.Size = new System.Drawing.Size(134, 51);
			this.btBookTickets.TabIndex = 30;
			this.btBookTickets.Text = "Reservar Tiquetes";
			this.btBookTickets.Click += new System.EventHandler(this.btBookTickets_Click);
			// 
			// planeimg
			// 
			this.planeimg.Image = global::Control_de_Vuelos.Properties.Resources.plane_img;
			this.planeimg.Location = new System.Drawing.Point(19, -18);
			this.planeimg.Name = "planeimg";
			this.planeimg.Size = new System.Drawing.Size(290, 723);
			this.planeimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.planeimg.TabIndex = 0;
			this.planeimg.TabStop = false;
			// 
			// btConfirmPassengers
			// 
			this.btConfirmPassengers.AutoRoundedCorners = true;
			this.btConfirmPassengers.BackColor = System.Drawing.Color.Transparent;
			this.btConfirmPassengers.BorderColor = System.Drawing.Color.White;
			this.btConfirmPassengers.BorderRadius = 24;
			this.btConfirmPassengers.FillColor = System.Drawing.SystemColors.HotTrack;
			this.btConfirmPassengers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btConfirmPassengers.ForeColor = System.Drawing.Color.White;
			this.btConfirmPassengers.Location = new System.Drawing.Point(354, 420);
			this.btConfirmPassengers.Name = "btConfirmPassengers";
			this.btConfirmPassengers.PressedColor = System.Drawing.Color.Teal;
			this.btConfirmPassengers.ShadowDecoration.BorderRadius = 30;
			this.btConfirmPassengers.ShadowDecoration.Depth = 0;
			this.btConfirmPassengers.ShadowDecoration.Enabled = true;
			this.btConfirmPassengers.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btConfirmPassengers.Size = new System.Drawing.Size(134, 51);
			this.btConfirmPassengers.TabIndex = 31;
			this.btConfirmPassengers.Text = "Confirmar Pasajeros";
			this.btConfirmPassengers.Click += new System.EventHandler(this.btConfirmPassengers_Click);
			// 
			// ManageFlightPassengersPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(500, 520);
			this.Controls.Add(this.btConfirmPassengers);
			this.Controls.Add(this.btBookTickets);
			this.Controls.Add(this.lbFlights);
			this.Controls.Add(this.cbFlights);
			this.Controls.Add(this.planeimg);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageFlightPassengersPanel";
			this.Text = "ManageFlightPassengers";
			((System.ComponentModel.ISupportInitialize)(this.planeimg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox planeimg;
		private System.Windows.Forms.Label lbFlights;
		private Guna.UI2.WinForms.Guna2Button btBookTickets;
		public Guna.UI2.WinForms.Guna2ComboBox cbFlights;
		private Guna.UI2.WinForms.Guna2Button btConfirmPassengers;
	}
}
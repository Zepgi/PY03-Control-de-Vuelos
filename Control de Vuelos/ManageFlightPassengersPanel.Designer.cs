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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cbDepartureHours = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbDepartureHour = new System.Windows.Forms.Label();
			this.btConfirmPassengers = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Control_de_Vuelos.Properties.Resources.plane_img;
			this.pictureBox1.Location = new System.Drawing.Point(12, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(261, 615);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
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
			this.cbDepartureHours.Location = new System.Drawing.Point(288, 254);
			this.cbDepartureHours.Name = "cbDepartureHours";
			this.cbDepartureHours.Size = new System.Drawing.Size(191, 36);
			this.cbDepartureHours.TabIndex = 24;
			// 
			// lbDepartureHour
			// 
			this.lbDepartureHour.AutoSize = true;
			this.lbDepartureHour.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDepartureHour.Location = new System.Drawing.Point(354, 228);
			this.lbDepartureHour.Name = "lbDepartureHour";
			this.lbDepartureHour.Size = new System.Drawing.Size(58, 21);
			this.lbDepartureHour.TabIndex = 29;
			this.lbDepartureHour.Text = "Vuelo";
			this.lbDepartureHour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.btConfirmPassengers.Location = new System.Drawing.Point(288, 372);
			this.btConfirmPassengers.Name = "btConfirmPassengers";
			this.btConfirmPassengers.PressedColor = System.Drawing.Color.Teal;
			this.btConfirmPassengers.ShadowDecoration.BorderRadius = 30;
			this.btConfirmPassengers.ShadowDecoration.Depth = 0;
			this.btConfirmPassengers.ShadowDecoration.Enabled = true;
			this.btConfirmPassengers.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btConfirmPassengers.Size = new System.Drawing.Size(191, 51);
			this.btConfirmPassengers.TabIndex = 30;
			this.btConfirmPassengers.Text = "Confirmar Reservas";
			// 
			// ManageFlightPassengersPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(500, 520);
			this.Controls.Add(this.btConfirmPassengers);
			this.Controls.Add(this.lbDepartureHour);
			this.Controls.Add(this.cbDepartureHours);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageFlightPassengersPanel";
			this.Text = "ManageFlightPassengers";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2ComboBox cbDepartureHours;
		private System.Windows.Forms.Label lbDepartureHour;
		private Guna.UI2.WinForms.Guna2Button btConfirmPassengers;
	}
}
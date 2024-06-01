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
			// 
			// btModFlight
			// 
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
			// 
			// pInputArea
			// 
			this.pInputArea.Controls.Add(this.lbSelectOpt);
			this.pInputArea.Location = new System.Drawing.Point(40, 155);
			this.pInputArea.Name = "pInputArea";
			this.pInputArea.Size = new System.Drawing.Size(500, 420);
			this.pInputArea.TabIndex = 9;
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
	}
}
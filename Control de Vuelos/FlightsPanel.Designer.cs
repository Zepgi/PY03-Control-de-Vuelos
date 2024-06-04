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
			this.pInputArea.SuspendLayout();
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
			this.btPassengers.Location = new System.Drawing.Point(40, 70);
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
			this.btFlights.Location = new System.Drawing.Point(282, 70);
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
			this.btLeftOption.Location = new System.Drawing.Point(40, 614);
			this.btLeftOption.Name = "btLeftOption";
			this.btLeftOption.PressedColor = System.Drawing.Color.Teal;
			this.btLeftOption.ShadowDecoration.BorderRadius = 30;
			this.btLeftOption.ShadowDecoration.Depth = 0;
			this.btLeftOption.ShadowDecoration.Enabled = true;
			this.btLeftOption.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btLeftOption.Size = new System.Drawing.Size(226, 46);
			this.btLeftOption.TabIndex = 8;
			this.btLeftOption.Text = "Modificar/Eliminar";
			// 
			// pInputArea
			// 
			this.pInputArea.BackColor = System.Drawing.Color.Transparent;
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
			// btRightOption
			// 
			this.btRightOption.AutoRoundedCorners = true;
			this.btRightOption.BackColor = System.Drawing.Color.Transparent;
			this.btRightOption.BorderColor = System.Drawing.Color.White;
			this.btRightOption.BorderRadius = 22;
			this.btRightOption.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.btRightOption.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.btRightOption.ForeColor = System.Drawing.Color.White;
			this.btRightOption.Location = new System.Drawing.Point(282, 614);
			this.btRightOption.Name = "btRightOption";
			this.btRightOption.PressedColor = System.Drawing.Color.Teal;
			this.btRightOption.ShadowDecoration.BorderRadius = 30;
			this.btRightOption.ShadowDecoration.Depth = 0;
			this.btRightOption.ShadowDecoration.Enabled = true;
			this.btRightOption.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
			this.btRightOption.Size = new System.Drawing.Size(226, 46);
			this.btRightOption.TabIndex = 10;
			this.btRightOption.Text = "Confirmar/Modificar";
			// 
			// tbFlights
			// 
			this.tbFlights.AllowUserToAddRows = false;
			this.tbFlights.AllowUserToDeleteRows = false;
			this.tbFlights.AllowUserToResizeColumns = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.tbFlights.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.tbFlights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.tbFlights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.tbFlights.ColumnHeadersHeight = 55;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.tbFlights.DefaultCellStyle = dataGridViewCellStyle3;
			this.tbFlights.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.tbFlights.Location = new System.Drawing.Point(574, 70);
			this.tbFlights.Name = "tbFlights";
			this.tbFlights.ReadOnly = true;
			this.tbFlights.RowHeadersVisible = false;
			this.tbFlights.RowHeadersWidth = 51;
			this.tbFlights.RowTemplate.Height = 24;
			this.tbFlights.Size = new System.Drawing.Size(620, 590);
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
			this.tbFlights.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFlights.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.tbFlights.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.tbFlights.ThemeStyle.HeaderStyle.Height = 55;
			this.tbFlights.ThemeStyle.ReadOnly = true;
			this.tbFlights.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.tbFlights.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.tbFlights.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFlights.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.tbFlights.ThemeStyle.RowsStyle.Height = 24;
			this.tbFlights.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.tbFlights.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// FlightsPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1220, 727);
			this.Controls.Add(this.tbFlights);
			this.Controls.Add(this.btRightOption);
			this.Controls.Add(this.btLeftOption);
			this.Controls.Add(this.pInputArea);
			this.Controls.Add(this.btFlights);
			this.Controls.Add(this.btPassengers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(1220, 727);
			this.MinimumSize = new System.Drawing.Size(1220, 727);
			this.Name = "FlightsPanel";
			this.Text = "PanelVuelos";
			this.pInputArea.ResumeLayout(false);
			this.pInputArea.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbFlights)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Button btPassengers;
		private Guna.UI2.WinForms.Guna2Button btFlights;
		private Guna.UI2.WinForms.Guna2Button btLeftOption;
		private System.Windows.Forms.Panel pInputArea;
		private Guna.UI2.WinForms.Guna2Button btRightOption;
		private System.Windows.Forms.Label lbSelectOpt;
		private Guna.UI2.WinForms.Guna2DataGridView tbFlights;
	}
}
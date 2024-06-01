namespace Control_de_Vuelos {
	partial class HomePanel {
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
			this.lbHour = new System.Windows.Forms.Label();
			this.tbFlights = new System.Windows.Forms.DataGridView();
			this.lbDate = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbWelcome = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbAirlines = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.tbFlights)).BeginInit();
			this.SuspendLayout();
			// 
			// lbHour
			// 
			this.lbHour.AutoSize = true;
			this.lbHour.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbHour.Location = new System.Drawing.Point(60, 122);
			this.lbHour.Name = "lbHour";
			this.lbHour.Size = new System.Drawing.Size(114, 27);
			this.lbHour.TabIndex = 0;
			this.lbHour.Text = "00:00 pm";
			// 
			// tbFlights
			// 
			this.tbFlights.BackgroundColor = System.Drawing.Color.White;
			this.tbFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tbFlights.Location = new System.Drawing.Point(638, 83);
			this.tbFlights.Name = "tbFlights";
			this.tbFlights.RowHeadersWidth = 51;
			this.tbFlights.RowTemplate.Height = 24;
			this.tbFlights.Size = new System.Drawing.Size(550, 584);
			this.tbFlights.TabIndex = 5;
			// 
			// lbDate
			// 
			this.lbDate.AutoSize = true;
			this.lbDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDate.Location = new System.Drawing.Point(60, 83);
			this.lbDate.Name = "lbDate";
			this.lbDate.Size = new System.Drawing.Size(217, 27);
			this.lbDate.TabIndex = 6;
			this.lbDate.Text = "1 de junio de 2024";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(632, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 34);
			this.label3.TabIndex = 7;
			this.label3.Text = "Vuelos";
			// 
			// lbWelcome
			// 
			this.lbWelcome.AutoSize = true;
			this.lbWelcome.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbWelcome.Location = new System.Drawing.Point(58, 36);
			this.lbWelcome.Name = "lbWelcome";
			this.lbWelcome.Size = new System.Drawing.Size(287, 34);
			this.lbWelcome.TabIndex = 8;
			this.lbWelcome.Text = "¡Bienvenido , @User!";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(158, 479);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(313, 91);
			this.label5.TabIndex = 9;
			this.label5.Text = "[LOGO]";
			// 
			// cbAirlines
			// 
			this.cbAirlines.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAirlines.FormattingEnabled = true;
			this.cbAirlines.Location = new System.Drawing.Point(851, 35);
			this.cbAirlines.Name = "cbAirlines";
			this.cbAirlines.Size = new System.Drawing.Size(337, 35);
			this.cbAirlines.TabIndex = 10;
			this.cbAirlines.Text = "Seleccione una aerolínea";
			// 
			// HomePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1220, 727);
			this.Controls.Add(this.cbAirlines);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lbWelcome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbDate);
			this.Controls.Add(this.tbFlights);
			this.Controls.Add(this.lbHour);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(1220, 727);
			this.MinimumSize = new System.Drawing.Size(1220, 727);
			this.Name = "HomePanel";
			this.Text = "PanelInicio";
			((System.ComponentModel.ISupportInitialize)(this.tbFlights)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbHour;
		private System.Windows.Forms.DataGridView tbFlights;
		private System.Windows.Forms.Label lbDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbWelcome;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbAirlines;
	}
}
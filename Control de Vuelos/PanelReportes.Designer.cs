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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewAirPlanes_AirLines = new System.Windows.Forms.DataGridView();
            this.textBoxAirLine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirPlanes_AirLines)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Haz ingresado al panel de reportes\r\n";
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoRoundedCorners = true;
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BorderColor = System.Drawing.Color.White;
            this.buttonSearch.BorderRadius = 13;
            this.buttonSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(103, 445);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.PressedColor = System.Drawing.Color.Teal;
            this.buttonSearch.ShadowDecoration.BorderRadius = 30;
            this.buttonSearch.ShadowDecoration.Depth = 0;
            this.buttonSearch.ShadowDecoration.Enabled = true;
            this.buttonSearch.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 1, 8, 10);
            this.buttonSearch.Size = new System.Drawing.Size(49, 29);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = " ✔";
            // 
            // dataGridViewAirPlanes_AirLines
            // 
            this.dataGridViewAirPlanes_AirLines.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAirPlanes_AirLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAirPlanes_AirLines.Location = new System.Drawing.Point(32, 166);
            this.dataGridViewAirPlanes_AirLines.Name = "dataGridViewAirPlanes_AirLines";
            this.dataGridViewAirPlanes_AirLines.Size = new System.Drawing.Size(370, 214);
            this.dataGridViewAirPlanes_AirLines.TabIndex = 10;
            this.dataGridViewAirPlanes_AirLines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAirPlanes_AirLines_CellContentClick);
            // 
            // textBoxAirLine
            // 
            this.textBoxAirLine.Location = new System.Drawing.Point(50, 420);
            this.textBoxAirLine.Name = "textBoxAirLine";
            this.textBoxAirLine.Size = new System.Drawing.Size(172, 20);
            this.textBoxAirLine.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Aviones por aerolineas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 397);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingrese una matricula";
            // 
            // PanelReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(976, 582);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAirLine);
            this.Controls.Add(this.dataGridViewAirPlanes_AirLines);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(976, 582);
            this.MinimumSize = new System.Drawing.Size(976, 582);
            this.Name = "PanelReportes";
            this.Text = "PanelReportes";
            this.Load += new System.EventHandler(this.PanelReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirPlanes_AirLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewAirPlanes_AirLines;
        private System.Windows.Forms.TextBox textBoxAirLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
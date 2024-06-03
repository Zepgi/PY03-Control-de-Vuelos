namespace Control_de_Vuelos {
	partial class PanelAerolineas {
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
            this.buttonCreateAirline = new System.Windows.Forms.Button();
            this.dataGridViewAirlines = new System.Windows.Forms.DataGridView();
            this.textBoxNombreAerolinea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLemaAerolinea = new System.Windows.Forms.TextBox();
            this.buttonModifyAirline = new System.Windows.Forms.Button();
            this.buttonDeleteAirline = new System.Windows.Forms.Button();
            this.buttonModifyView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirlines)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateAirline
            // 
            this.buttonCreateAirline.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonCreateAirline.Location = new System.Drawing.Point(456, 431);
            this.buttonCreateAirline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateAirline.Name = "buttonCreateAirline";
            this.buttonCreateAirline.Size = new System.Drawing.Size(222, 28);
            this.buttonCreateAirline.TabIndex = 4;
            this.buttonCreateAirline.Text = "Crear aerolinea";
            this.buttonCreateAirline.UseVisualStyleBackColor = false;
            this.buttonCreateAirline.Click += new System.EventHandler(this.buttonCreateAirline_Click);
            // 
            // dataGridViewAirlines
            // 
            this.dataGridViewAirlines.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewAirlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAirlines.Location = new System.Drawing.Point(21, 82);
            this.dataGridViewAirlines.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewAirlines.Name = "dataGridViewAirlines";
            this.dataGridViewAirlines.RowHeadersWidth = 51;
            this.dataGridViewAirlines.RowTemplate.Height = 24;
            this.dataGridViewAirlines.Size = new System.Drawing.Size(370, 378);
            this.dataGridViewAirlines.TabIndex = 17;
            // 
            // textBoxNombreAerolinea
            // 
            this.textBoxNombreAerolinea.Location = new System.Drawing.Point(417, 194);
            this.textBoxNombreAerolinea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombreAerolinea.Name = "textBoxNombreAerolinea";
            this.textBoxNombreAerolinea.Size = new System.Drawing.Size(141, 20);
            this.textBoxNombreAerolinea.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zona de Aerolinea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(782, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lema de la aerolinea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre de la aerolinea";
            // 
            // textBoxLemaAerolinea
            // 
            this.textBoxLemaAerolinea.Location = new System.Drawing.Point(786, 194);
            this.textBoxLemaAerolinea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLemaAerolinea.Name = "textBoxLemaAerolinea";
            this.textBoxLemaAerolinea.Size = new System.Drawing.Size(141, 20);
            this.textBoxLemaAerolinea.TabIndex = 9;
            // 
            // buttonModifyAirline
            // 
            this.buttonModifyAirline.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonModifyAirline.Location = new System.Drawing.Point(682, 431);
            this.buttonModifyAirline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModifyAirline.Name = "buttonModifyAirline";
            this.buttonModifyAirline.Size = new System.Drawing.Size(222, 28);
            this.buttonModifyAirline.TabIndex = 18;
            this.buttonModifyAirline.Text = "Modificar aerolinea";
            this.buttonModifyAirline.UseVisualStyleBackColor = false;
            this.buttonModifyAirline.Click += new System.EventHandler(this.buttonModifyAirline_Click);
            // 
            // buttonDeleteAirline
            // 
            this.buttonDeleteAirline.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteAirline.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteAirline.Location = new System.Drawing.Point(456, 432);
            this.buttonDeleteAirline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteAirline.Name = "buttonDeleteAirline";
            this.buttonDeleteAirline.Size = new System.Drawing.Size(222, 28);
            this.buttonDeleteAirline.TabIndex = 19;
            this.buttonDeleteAirline.Text = "Eliminar";
            this.buttonDeleteAirline.UseVisualStyleBackColor = false;
            this.buttonDeleteAirline.Click += new System.EventHandler(this.buttonDeleteAirline_Click);
            // 
            // buttonModifyView
            // 
            this.buttonModifyView.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonModifyView.Location = new System.Drawing.Point(682, 432);
            this.buttonModifyView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModifyView.Name = "buttonModifyView";
            this.buttonModifyView.Size = new System.Drawing.Size(222, 28);
            this.buttonModifyView.TabIndex = 20;
            this.buttonModifyView.Text = "Modificar ";
            this.buttonModifyView.UseVisualStyleBackColor = false;
            this.buttonModifyView.Click += new System.EventHandler(this.buttonModifyView_Click);
            // 
            // PanelAerolineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 582);
            this.Controls.Add(this.buttonModifyView);
            this.Controls.Add(this.buttonDeleteAirline);
            this.Controls.Add(this.buttonModifyAirline);
            this.Controls.Add(this.dataGridViewAirlines);
            this.Controls.Add(this.textBoxLemaAerolinea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreAerolinea);
            this.Controls.Add(this.buttonCreateAirline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(976, 582);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(976, 582);
            this.Name = "PanelAerolineas";
            this.Text = "PanelAerolineas";
            this.Load += new System.EventHandler(this.PanelAerolineas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirlines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.Button buttonCreateAirline;
        private System.Windows.Forms.DataGridView dataGridViewAirlines;
        private System.Windows.Forms.TextBox textBoxNombreAerolinea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLemaAerolinea;
        private System.Windows.Forms.Button buttonModifyAirline;
        private System.Windows.Forms.Button buttonDeleteAirline;
        private System.Windows.Forms.Button buttonModifyView;
    }
}
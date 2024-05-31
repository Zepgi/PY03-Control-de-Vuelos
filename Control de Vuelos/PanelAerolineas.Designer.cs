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
            this.buttonCrearAerolinea = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.dataGridViewAerolineas = new System.Windows.Forms.DataGridView();
            this.textBoxNombreAerolinea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLemaAerolinea = new System.Windows.Forms.TextBox();
            this.buttonModificarAerolinea = new System.Windows.Forms.Button();
            this.buttonEliminarAerolinea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAerolineas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCrearAerolinea
            // 
            this.buttonCrearAerolinea.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonCrearAerolinea.Location = new System.Drawing.Point(521, 539);
            this.buttonCrearAerolinea.Name = "buttonCrearAerolinea";
            this.buttonCrearAerolinea.Size = new System.Drawing.Size(277, 35);
            this.buttonCrearAerolinea.TabIndex = 4;
            this.buttonCrearAerolinea.Text = "Crear aerolinea";
            this.buttonCrearAerolinea.UseVisualStyleBackColor = false;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.BackColor = System.Drawing.Color.Red;
            this.buttonRegresar.ForeColor = System.Drawing.Color.White;
            this.buttonRegresar.Location = new System.Drawing.Point(804, 539);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(277, 35);
            this.buttonRegresar.TabIndex = 10;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // dataGridViewAerolineas
            // 
            this.dataGridViewAerolineas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewAerolineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAerolineas.Location = new System.Drawing.Point(26, 115);
            this.dataGridViewAerolineas.Name = "dataGridViewAerolineas";
            this.dataGridViewAerolineas.RowHeadersWidth = 51;
            this.dataGridViewAerolineas.RowTemplate.Height = 24;
            this.dataGridViewAerolineas.Size = new System.Drawing.Size(399, 431);
            this.dataGridViewAerolineas.TabIndex = 17;
            // 
            // textBoxNombreAerolinea
            // 
            this.textBoxNombreAerolinea.Location = new System.Drawing.Point(500, 242);
            this.textBoxNombreAerolinea.Name = "textBoxNombreAerolinea";
            this.textBoxNombreAerolinea.Size = new System.Drawing.Size(175, 22);
            this.textBoxNombreAerolinea.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(695, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Crear aerolinea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(873, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lema de la aerolinea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre de la aerolinea";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxLemaAerolinea
            // 
            this.textBoxLemaAerolinea.Location = new System.Drawing.Point(878, 242);
            this.textBoxLemaAerolinea.Name = "textBoxLemaAerolinea";
            this.textBoxLemaAerolinea.Size = new System.Drawing.Size(175, 22);
            this.textBoxLemaAerolinea.TabIndex = 9;
            // 
            // buttonModificarAerolinea
            // 
            this.buttonModificarAerolinea.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonModificarAerolinea.Location = new System.Drawing.Point(804, 580);
            this.buttonModificarAerolinea.Name = "buttonModificarAerolinea";
            this.buttonModificarAerolinea.Size = new System.Drawing.Size(277, 35);
            this.buttonModificarAerolinea.TabIndex = 18;
            this.buttonModificarAerolinea.Text = "Modificar aerolinea";
            this.buttonModificarAerolinea.UseVisualStyleBackColor = false;
            this.buttonModificarAerolinea.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEliminarAerolinea
            // 
            this.buttonEliminarAerolinea.BackColor = System.Drawing.Color.Red;
            this.buttonEliminarAerolinea.ForeColor = System.Drawing.Color.White;
            this.buttonEliminarAerolinea.Location = new System.Drawing.Point(521, 580);
            this.buttonEliminarAerolinea.Name = "buttonEliminarAerolinea";
            this.buttonEliminarAerolinea.Size = new System.Drawing.Size(277, 35);
            this.buttonEliminarAerolinea.TabIndex = 19;
            this.buttonEliminarAerolinea.Text = "Eliminar";
            this.buttonEliminarAerolinea.UseVisualStyleBackColor = false;
            // 
            // PanelAerolineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 727);
            this.Controls.Add(this.buttonEliminarAerolinea);
            this.Controls.Add(this.buttonModificarAerolinea);
            this.Controls.Add(this.dataGridViewAerolineas);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.textBoxLemaAerolinea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreAerolinea);
            this.Controls.Add(this.buttonCrearAerolinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1220, 727);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1220, 727);
            this.Name = "PanelAerolineas";
            this.Text = "PanelAerolineas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAerolineas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.Button buttonCrearAerolinea;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.DataGridView dataGridViewAerolineas;
        private System.Windows.Forms.TextBox textBoxNombreAerolinea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLemaAerolinea;
        private System.Windows.Forms.Button buttonModificarAerolinea;
        private System.Windows.Forms.Button buttonEliminarAerolinea;
    }
}
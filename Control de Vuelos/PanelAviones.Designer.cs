namespace Control_de_Vuelos {
	partial class PanelAviones {
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
            this.components = new System.ComponentModel.Container();
            this.buttonModifyView = new System.Windows.Forms.Button();
            this.buttonDeleteAirPlane = new System.Windows.Forms.Button();
            this.buttonModifyAirPlane = new System.Windows.Forms.Button();
            this.dataGridViewAirPlanes = new System.Windows.Forms.DataGridView();
            this.textBoxMarcaAvion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.buttonCreateAirPlane = new System.Windows.Forms.Button();
            this.textBoxCantPasajeros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonModifyView
            // 
            this.buttonModifyView.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonModifyView.Location = new System.Drawing.Point(739, 425);
            this.buttonModifyView.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifyView.Name = "buttonModifyView";
            this.buttonModifyView.Size = new System.Drawing.Size(222, 28);
            this.buttonModifyView.TabIndex = 30;
            this.buttonModifyView.Text = "Modificar ";
            this.buttonModifyView.UseVisualStyleBackColor = false;
            this.buttonModifyView.Click += new System.EventHandler(this.buttonModifyView_Click);
            // 
            // buttonDeleteAirPlane
            // 
            this.buttonDeleteAirPlane.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteAirPlane.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteAirPlane.Location = new System.Drawing.Point(513, 425);
            this.buttonDeleteAirPlane.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteAirPlane.Name = "buttonDeleteAirPlane";
            this.buttonDeleteAirPlane.Size = new System.Drawing.Size(222, 28);
            this.buttonDeleteAirPlane.TabIndex = 29;
            this.buttonDeleteAirPlane.Text = "Eliminar";
            this.buttonDeleteAirPlane.UseVisualStyleBackColor = false;
            this.buttonDeleteAirPlane.Click += new System.EventHandler(this.buttonDeleteAirPlane_Click);
            // 
            // buttonModifyAirPlane
            // 
            this.buttonModifyAirPlane.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonModifyAirPlane.Location = new System.Drawing.Point(739, 425);
            this.buttonModifyAirPlane.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifyAirPlane.Name = "buttonModifyAirPlane";
            this.buttonModifyAirPlane.Size = new System.Drawing.Size(222, 28);
            this.buttonModifyAirPlane.TabIndex = 28;
            this.buttonModifyAirPlane.Text = "Modificar aviones";
            this.buttonModifyAirPlane.UseVisualStyleBackColor = false;
            this.buttonModifyAirPlane.Click += new System.EventHandler(this.buttonModifyAirPlane_Click);
            // 
            // dataGridViewAirPlanes
            // 
            this.dataGridViewAirPlanes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewAirPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAirPlanes.Location = new System.Drawing.Point(30, 102);
            this.dataGridViewAirPlanes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAirPlanes.Name = "dataGridViewAirPlanes";
            this.dataGridViewAirPlanes.RowHeadersWidth = 51;
            this.dataGridViewAirPlanes.RowTemplate.Height = 24;
            this.dataGridViewAirPlanes.Size = new System.Drawing.Size(447, 378);
            this.dataGridViewAirPlanes.TabIndex = 27;
            this.dataGridViewAirPlanes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAirPlanes_CellContentClick);
            // 
            // textBoxMarcaAvion
            // 
            this.textBoxMarcaAvion.Location = new System.Drawing.Point(485, 221);
            this.textBoxMarcaAvion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMarcaAvion.Name = "textBoxMarcaAvion";
            this.textBoxMarcaAvion.Size = new System.Drawing.Size(141, 20);
            this.textBoxMarcaAvion.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Matricula";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(485, 142);
            this.textBoxMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(141, 20);
            this.textBoxMatricula.TabIndex = 22;
            // 
            // buttonCreateAirPlane
            // 
            this.buttonCreateAirPlane.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonCreateAirPlane.Location = new System.Drawing.Point(513, 425);
            this.buttonCreateAirPlane.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateAirPlane.Name = "buttonCreateAirPlane";
            this.buttonCreateAirPlane.Size = new System.Drawing.Size(222, 28);
            this.buttonCreateAirPlane.TabIndex = 21;
            this.buttonCreateAirPlane.Text = "Crear avion";
            this.buttonCreateAirPlane.UseVisualStyleBackColor = false;
            this.buttonCreateAirPlane.Click += new System.EventHandler(this.buttonCreateAirPlane_Click);
            // 
            // textBoxCantPasajeros
            // 
            this.textBoxCantPasajeros.Location = new System.Drawing.Point(485, 295);
            this.textBoxCantPasajeros.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCantPasajeros.Name = "textBoxCantPasajeros";
            this.textBoxCantPasajeros.Size = new System.Drawing.Size(141, 20);
            this.textBoxCantPasajeros.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cant.Pasajeros";
            // 
            // PanelAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(976, 582);
            this.Controls.Add(this.textBoxCantPasajeros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonModifyView);
            this.Controls.Add(this.buttonDeleteAirPlane);
            this.Controls.Add(this.buttonModifyAirPlane);
            this.Controls.Add(this.dataGridViewAirPlanes);
            this.Controls.Add(this.textBoxMarcaAvion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.buttonCreateAirPlane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(976, 582);
            this.MinimumSize = new System.Drawing.Size(976, 582);
            this.Name = "PanelAviones";
            this.Text = "PanelAviones";
            this.Load += new System.EventHandler(this.PanelAviones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button buttonModifyView;
        private System.Windows.Forms.Button buttonDeleteAirPlane;
        private System.Windows.Forms.Button buttonModifyAirPlane;
        private System.Windows.Forms.DataGridView dataGridViewAirPlanes;
        private System.Windows.Forms.TextBox textBoxMarcaAvion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Button buttonCreateAirPlane;
        private System.Windows.Forms.TextBox textBoxCantPasajeros;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}
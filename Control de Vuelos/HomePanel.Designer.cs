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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lbHour = new System.Windows.Forms.Label();
			this.lbDate = new System.Windows.Forms.Label();
			this.lbFlights = new System.Windows.Forms.Label();
			this.lbWelcome = new System.Windows.Forms.Label();
			this.cbAirlines = new Guna.UI2.WinForms.Guna2ComboBox();
			this.tbFlights = new Guna.UI2.WinForms.Guna2DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.tbFlights)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
			// lbFlights
			// 
			this.lbFlights.AutoSize = true;
			this.lbFlights.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFlights.Location = new System.Drawing.Point(632, 40);
			this.lbFlights.Name = "lbFlights";
			this.lbFlights.Size = new System.Drawing.Size(106, 34);
			this.lbFlights.TabIndex = 7;
			this.lbFlights.Text = "Vuelos";
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
			// cbAirlines
			// 
			this.cbAirlines.BackColor = System.Drawing.Color.Transparent;
			this.cbAirlines.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.cbAirlines.BorderRadius = 15;
			this.cbAirlines.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbAirlines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbAirlines.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbAirlines.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbAirlines.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAirlines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbAirlines.ItemHeight = 30;
			this.cbAirlines.Location = new System.Drawing.Point(844, 34);
			this.cbAirlines.Name = "cbAirlines";
			this.cbAirlines.Size = new System.Drawing.Size(344, 36);
			this.cbAirlines.TabIndex = 26;
			this.cbAirlines.SelectedIndexChanged += new System.EventHandler(this.cbAirlines_IndexChanged);
			// 
			// tbFlights
			// 
			this.tbFlights.AllowUserToAddRows = false;
			this.tbFlights.AllowUserToDeleteRows = false;
			this.tbFlights.AllowUserToResizeColumns = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.tbFlights.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.tbFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.tbFlights.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
			this.tbFlights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.tbFlights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.tbFlights.ColumnHeadersHeight = 50;
			this.tbFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.tbFlights.DefaultCellStyle = dataGridViewCellStyle3;
			this.tbFlights.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.tbFlights.Location = new System.Drawing.Point(638, 83);
			this.tbFlights.Name = "tbFlights";
			this.tbFlights.ReadOnly = true;
			this.tbFlights.RowHeadersVisible = false;
			this.tbFlights.RowHeadersWidth = 51;
			this.tbFlights.RowTemplate.Height = 50;
			this.tbFlights.Size = new System.Drawing.Size(550, 584);
			this.tbFlights.TabIndex = 27;
			this.tbFlights.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.tbFlights.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.tbFlights.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.tbFlights.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.tbFlights.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.tbFlights.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.tbFlights.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.tbFlights.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.tbFlights.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.tbFlights.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFlights.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.tbFlights.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.tbFlights.ThemeStyle.HeaderStyle.Height = 50;
			this.tbFlights.ThemeStyle.ReadOnly = true;
			this.tbFlights.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.tbFlights.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
			this.tbFlights.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFlights.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.tbFlights.ThemeStyle.RowsStyle.Height = 50;
			this.tbFlights.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.tbFlights.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Control_de_Vuelos.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(86, 264);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(395, 403);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 28;
			this.pictureBox1.TabStop = false;
			// 
			// HomePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1220, 727);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tbFlights);
			this.Controls.Add(this.cbAirlines);
			this.Controls.Add(this.lbWelcome);
			this.Controls.Add(this.lbFlights);
			this.Controls.Add(this.lbDate);
			this.Controls.Add(this.lbHour);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(1220, 727);
			this.MinimumSize = new System.Drawing.Size(1220, 727);
			this.Name = "HomePanel";
			this.Text = "PanelInicio";
			((System.ComponentModel.ISupportInitialize)(this.tbFlights)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbHour;
		private System.Windows.Forms.Label lbDate;
		private System.Windows.Forms.Label lbFlights;
		private System.Windows.Forms.Label lbWelcome;
		public Guna.UI2.WinForms.Guna2ComboBox cbAirlines;
		private Guna.UI2.WinForms.Guna2DataGridView tbFlights;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
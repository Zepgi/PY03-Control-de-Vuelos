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
			this.label6 = new System.Windows.Forms.Label();
			this.guna2ComboBox7 = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2ComboBox5 = new Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2ComboBox4 = new Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2ComboBox3 = new Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbSelectOpt = new System.Windows.Forms.Label();
			this.btConfirmPassenger = new Guna.UI2.WinForms.Guna2Button();
			this.label7 = new System.Windows.Forms.Label();
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
			this.btAddFlight.Animated = true;
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
			this.btModFlight.Animated = true;
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
			this.pInputArea.BackColor = System.Drawing.Color.Transparent;
			this.pInputArea.Controls.Add(this.label7);
			this.pInputArea.Controls.Add(this.label6);
			this.pInputArea.Controls.Add(this.guna2ComboBox7);
			this.pInputArea.Controls.Add(this.label5);
			this.pInputArea.Controls.Add(this.label4);
			this.pInputArea.Controls.Add(this.label3);
			this.pInputArea.Controls.Add(this.label2);
			this.pInputArea.Controls.Add(this.label1);
			this.pInputArea.Controls.Add(this.guna2ComboBox5);
			this.pInputArea.Controls.Add(this.guna2ComboBox4);
			this.pInputArea.Controls.Add(this.guna2ComboBox3);
			this.pInputArea.Controls.Add(this.guna2ComboBox2);
			this.pInputArea.Controls.Add(this.guna2DateTimePicker1);
			this.pInputArea.Controls.Add(this.guna2ComboBox1);
			this.pInputArea.Controls.Add(this.lbSelectOpt);
			this.pInputArea.Location = new System.Drawing.Point(40, 155);
			this.pInputArea.Name = "pInputArea";
			this.pInputArea.Size = new System.Drawing.Size(500, 420);
			this.pInputArea.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(98, 297);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 21);
			this.label6.TabIndex = 19;
			this.label6.Text = "Avión";
			// 
			// guna2ComboBox7
			// 
			this.guna2ComboBox7.BackColor = System.Drawing.Color.Transparent;
			this.guna2ComboBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.guna2ComboBox7.BorderRadius = 15;
			this.guna2ComboBox7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.guna2ComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.guna2ComboBox7.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox7.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.guna2ComboBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.guna2ComboBox7.ItemHeight = 30;
			this.guna2ComboBox7.Location = new System.Drawing.Point(250, 237);
			this.guna2ComboBox7.Name = "guna2ComboBox7";
			this.guna2ComboBox7.Size = new System.Drawing.Size(163, 36);
			this.guna2ComboBox7.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(253, 213);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(168, 21);
			this.label5.TabIndex = 17;
			this.label5.Text = "Ciudad de Destino";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(73, 213);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 21);
			this.label4.TabIndex = 16;
			this.label4.Text = "Ciudad de Partida";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(253, 129);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 21);
			this.label3.TabIndex = 15;
			this.label3.Text = "Hora de Llegada";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(98, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 21);
			this.label2.TabIndex = 14;
			this.label2.Text = "Hora de Salida";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(93, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 21);
			this.label1.TabIndex = 13;
			this.label1.Text = "Fecha de Partida";
			// 
			// guna2ComboBox5
			// 
			this.guna2ComboBox5.BackColor = System.Drawing.Color.Transparent;
			this.guna2ComboBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.guna2ComboBox5.BorderRadius = 15;
			this.guna2ComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.guna2ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.guna2ComboBox5.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox5.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.guna2ComboBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.guna2ComboBox5.ItemHeight = 30;
			this.guna2ComboBox5.Location = new System.Drawing.Point(250, 321);
			this.guna2ComboBox5.Name = "guna2ComboBox5";
			this.guna2ComboBox5.Size = new System.Drawing.Size(147, 36);
			this.guna2ComboBox5.TabIndex = 11;
			// 
			// guna2ComboBox4
			// 
			this.guna2ComboBox4.BackColor = System.Drawing.Color.Transparent;
			this.guna2ComboBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.guna2ComboBox4.BorderRadius = 15;
			this.guna2ComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.guna2ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.guna2ComboBox4.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox4.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.guna2ComboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.guna2ComboBox4.ItemHeight = 30;
			this.guna2ComboBox4.Location = new System.Drawing.Point(95, 321);
			this.guna2ComboBox4.Name = "guna2ComboBox4";
			this.guna2ComboBox4.Size = new System.Drawing.Size(148, 36);
			this.guna2ComboBox4.TabIndex = 10;
			// 
			// guna2ComboBox3
			// 
			this.guna2ComboBox3.BackColor = System.Drawing.Color.Transparent;
			this.guna2ComboBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.guna2ComboBox3.BorderRadius = 15;
			this.guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.guna2ComboBox3.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.guna2ComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.guna2ComboBox3.ItemHeight = 30;
			this.guna2ComboBox3.Location = new System.Drawing.Point(250, 153);
			this.guna2ComboBox3.Name = "guna2ComboBox3";
			this.guna2ComboBox3.Size = new System.Drawing.Size(148, 36);
			this.guna2ComboBox3.TabIndex = 9;
			// 
			// guna2ComboBox2
			// 
			this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
			this.guna2ComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.guna2ComboBox2.BorderRadius = 15;
			this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.guna2ComboBox2.ItemHeight = 30;
			this.guna2ComboBox2.Location = new System.Drawing.Point(95, 153);
			this.guna2ComboBox2.Name = "guna2ComboBox2";
			this.guna2ComboBox2.Size = new System.Drawing.Size(148, 36);
			this.guna2ComboBox2.TabIndex = 8;
			// 
			// guna2DateTimePicker1
			// 
			this.guna2DateTimePicker1.Animated = true;
			this.guna2DateTimePicker1.AutoRoundedCorners = true;
			this.guna2DateTimePicker1.BackColor = System.Drawing.Color.White;
			this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.guna2DateTimePicker1.BorderRadius = 19;
			this.guna2DateTimePicker1.Checked = true;
			this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
			this.guna2DateTimePicker1.FocusedColor = System.Drawing.Color.Gainsboro;
			this.guna2DateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.guna2DateTimePicker1.Location = new System.Drawing.Point(95, 65);
			this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
			this.guna2DateTimePicker1.Size = new System.Drawing.Size(310, 40);
			this.guna2DateTimePicker1.TabIndex = 7;
			this.guna2DateTimePicker1.Value = new System.DateTime(2024, 6, 3, 15, 3, 26, 864);
			// 
			// guna2ComboBox1
			// 
			this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
			this.guna2ComboBox1.BorderRadius = 15;
			this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.guna2ComboBox1.ItemHeight = 30;
			this.guna2ComboBox1.Location = new System.Drawing.Point(80, 237);
			this.guna2ComboBox1.Name = "guna2ComboBox1";
			this.guna2ComboBox1.Size = new System.Drawing.Size(163, 36);
			this.guna2ComboBox1.TabIndex = 6;
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
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(253, 297);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 21);
			this.label7.TabIndex = 20;
			this.label7.Text = "Piloto";
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
		private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox5;
		private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox4;
		private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox3;
		private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
		private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
		private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox7;
		private System.Windows.Forms.Label label7;
	}
}
namespace Control_de_Vuelos
{
    partial class SelectAirline
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectAirline));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bExit = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAccept = new Guna.UI2.WinForms.Guna2Button();
            this.airlineGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airlineGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.ForeColor = System.Drawing.Color.White;
            this.bExit.Image = ((System.Drawing.Image)(resources.GetObject("bExit.Image")));
            this.bExit.Location = new System.Drawing.Point(512, 12);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(47, 43);
            this.bExit.TabIndex = 1;
            this.bExit.UseMnemonic = false;
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.airlineGrid);
            this.panel.Controls.Add(this.searchPanel);
            this.panel.Controls.Add(this.btnAccept);
            this.panel.Location = new System.Drawing.Point(10, 80);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(547, 635);
            this.panel.TabIndex = 2;
            // 
            // searchPanel
            // 
            this.searchPanel.AutoScroll = true;
            this.searchPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Controls.Add(this.searchTB);
            this.searchPanel.Location = new System.Drawing.Point(14, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(515, 55);
            this.searchPanel.TabIndex = 14;
            this.searchPanel.Visible = false;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.searchLabel.Location = new System.Drawing.Point(3, 16);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(94, 21);
            this.searchLabel.TabIndex = 11;
            this.searchLabel.Text = "Busqueda";
            // 
            // searchTB
            // 
            this.searchTB.AutoRoundedCorners = true;
            this.searchTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.searchTB.BorderRadius = 21;
            this.searchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTB.DefaultText = "";
            this.searchTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.searchTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTB.Location = new System.Drawing.Point(117, 4);
            this.searchTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTB.Name = "searchTB";
            this.searchTB.PasswordChar = '\0';
            this.searchTB.PlaceholderText = "";
            this.searchTB.SelectedText = "";
            this.searchTB.Size = new System.Drawing.Size(351, 44);
            this.searchTB.TabIndex = 11;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Animated = true;
            this.btnAccept.AutoRoundedCorners = true;
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.BorderColor = System.Drawing.Color.White;
            this.btnAccept.BorderRadius = 22;
            this.btnAccept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccept.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.btnAccept.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(303, 586);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.PressedColor = System.Drawing.Color.Teal;
            this.btnAccept.Size = new System.Drawing.Size(226, 46);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // airlineGrid
            // 
            this.airlineGrid.AllowUserToAddRows = false;
            this.airlineGrid.AllowUserToDeleteRows = false;
            this.airlineGrid.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.airlineGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.airlineGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.airlineGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.airlineGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.airlineGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.airlineGrid.ColumnHeadersHeight = 50;
            this.airlineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.airlineGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.airlineGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.airlineGrid.Location = new System.Drawing.Point(14, 61);
            this.airlineGrid.Name = "airlineGrid";
            this.airlineGrid.ReadOnly = true;
            this.airlineGrid.RowHeadersVisible = false;
            this.airlineGrid.RowHeadersWidth = 51;
            this.airlineGrid.RowTemplate.Height = 50;
            this.airlineGrid.Size = new System.Drawing.Size(515, 519);
            this.airlineGrid.TabIndex = 29;
            this.airlineGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.airlineGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.airlineGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.airlineGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.airlineGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.airlineGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.airlineGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.airlineGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(216)))), ((int)(((byte)(143)))));
            this.airlineGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.airlineGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airlineGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.airlineGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.airlineGrid.ThemeStyle.HeaderStyle.Height = 50;
            this.airlineGrid.ThemeStyle.ReadOnly = true;
            this.airlineGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.airlineGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.airlineGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airlineGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.airlineGrid.ThemeStyle.RowsStyle.Height = 50;
            this.airlineGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.airlineGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.airlineGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.airlineGrid_CellMouseDown_1);
            this.airlineGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.airlineGrid_RowPrePaint_1);
            this.airlineGrid.SelectionChanged += new System.EventHandler(this.airlineGrid_SelectionChanged_1);
            // 
            // SelectAirline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(571, 727);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.bExit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectAirline";
            this.Text = "v";
            this.panel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airlineGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Panel panel;
        private Guna.UI2.WinForms.Guna2Button btnAccept;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label searchLabel;
        private Guna.UI2.WinForms.Guna2TextBox searchTB;
        private Guna.UI2.WinForms.Guna2DataGridView airlineGrid;
    }
}
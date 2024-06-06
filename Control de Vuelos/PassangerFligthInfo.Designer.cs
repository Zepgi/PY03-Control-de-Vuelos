namespace Control_de_Vuelos
{
    partial class PassangerFligthInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassangerFligthInfo));
            this.panel = new System.Windows.Forms.Panel();
            this.bExit = new System.Windows.Forms.Button();
            this.fligthTitleLabel = new System.Windows.Forms.Label();
            this.nameTitleLabel = new System.Windows.Forms.Label();
            this.sitTitleLabel = new System.Windows.Forms.Label();
            this.confirmTitleLabel = new System.Windows.Forms.Label();
            this.fligthText = new System.Windows.Forms.Label();
            this.completeNameText = new System.Windows.Forms.Label();
            this.sitText = new System.Windows.Forms.Label();
            this.confirmText = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.confirmText);
            this.panel.Controls.Add(this.sitText);
            this.panel.Controls.Add(this.completeNameText);
            this.panel.Controls.Add(this.fligthText);
            this.panel.Controls.Add(this.confirmTitleLabel);
            this.panel.Controls.Add(this.sitTitleLabel);
            this.panel.Controls.Add(this.nameTitleLabel);
            this.panel.Controls.Add(this.fligthTitleLabel);
            this.panel.Location = new System.Drawing.Point(10, 80);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(426, 404);
            this.panel.TabIndex = 3;
            // 
            // bExit
            // 
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.ForeColor = System.Drawing.Color.White;
            this.bExit.Image = ((System.Drawing.Image)(resources.GetObject("bExit.Image")));
            this.bExit.Location = new System.Drawing.Point(389, 12);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(47, 43);
            this.bExit.TabIndex = 4;
            this.bExit.UseMnemonic = false;
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // fligthTitleLabel
            // 
            this.fligthTitleLabel.AutoSize = true;
            this.fligthTitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fligthTitleLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fligthTitleLabel.Location = new System.Drawing.Point(15, 19);
            this.fligthTitleLabel.Name = "fligthTitleLabel";
            this.fligthTitleLabel.Size = new System.Drawing.Size(67, 23);
            this.fligthTitleLabel.TabIndex = 45;
            this.fligthTitleLabel.Text = "Vuelo";
            // 
            // nameTitleLabel
            // 
            this.nameTitleLabel.AutoSize = true;
            this.nameTitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTitleLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nameTitleLabel.Location = new System.Drawing.Point(15, 112);
            this.nameTitleLabel.Name = "nameTitleLabel";
            this.nameTitleLabel.Size = new System.Drawing.Size(193, 23);
            this.nameTitleLabel.TabIndex = 46;
            this.nameTitleLabel.Text = "Nombre Completo";
            // 
            // sitTitleLabel
            // 
            this.sitTitleLabel.AutoSize = true;
            this.sitTitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sitTitleLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sitTitleLabel.Location = new System.Drawing.Point(15, 200);
            this.sitTitleLabel.Name = "sitTitleLabel";
            this.sitTitleLabel.Size = new System.Drawing.Size(83, 23);
            this.sitTitleLabel.TabIndex = 47;
            this.sitTitleLabel.Text = "Asiento";
            // 
            // confirmTitleLabel
            // 
            this.confirmTitleLabel.AutoSize = true;
            this.confirmTitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmTitleLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.confirmTitleLabel.Location = new System.Drawing.Point(15, 287);
            this.confirmTitleLabel.Name = "confirmTitleLabel";
            this.confirmTitleLabel.Size = new System.Drawing.Size(126, 23);
            this.confirmTitleLabel.TabIndex = 48;
            this.confirmTitleLabel.Text = "Confirmado";
            // 
            // fligthText
            // 
            this.fligthText.AutoSize = true;
            this.fligthText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fligthText.ForeColor = System.Drawing.SystemColors.InfoText;
            this.fligthText.Location = new System.Drawing.Point(15, 56);
            this.fligthText.Name = "fligthText";
            this.fligthText.Size = new System.Drawing.Size(56, 23);
            this.fligthText.TabIndex = 49;
            this.fligthText.Text = "fligth";
            // 
            // completeNameText
            // 
            this.completeNameText.AutoSize = true;
            this.completeNameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeNameText.ForeColor = System.Drawing.SystemColors.InfoText;
            this.completeNameText.Location = new System.Drawing.Point(15, 150);
            this.completeNameText.Name = "completeNameText";
            this.completeNameText.Size = new System.Drawing.Size(168, 23);
            this.completeNameText.TabIndex = 50;
            this.completeNameText.Text = "nameComplete";
            // 
            // sitText
            // 
            this.sitText.AutoSize = true;
            this.sitText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sitText.ForeColor = System.Drawing.SystemColors.InfoText;
            this.sitText.Location = new System.Drawing.Point(15, 233);
            this.sitText.Name = "sitText";
            this.sitText.Size = new System.Drawing.Size(28, 23);
            this.sitText.TabIndex = 51;
            this.sitText.Text = "sit";
            // 
            // confirmText
            // 
            this.confirmText.AutoSize = true;
            this.confirmText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmText.ForeColor = System.Drawing.SystemColors.InfoText;
            this.confirmText.Location = new System.Drawing.Point(15, 324);
            this.confirmText.Name = "confirmText";
            this.confirmText.Size = new System.Drawing.Size(95, 23);
            this.confirmText.TabIndex = 52;
            this.confirmText.Text = "YesOrNo";
            // 
            // PassangerFligthInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(448, 502);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PassangerFligthInfo";
            this.Text = "PassangerFligthInfo";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label confirmTitleLabel;
        private System.Windows.Forms.Label sitTitleLabel;
        private System.Windows.Forms.Label nameTitleLabel;
        private System.Windows.Forms.Label fligthTitleLabel;
        private System.Windows.Forms.Label confirmText;
        private System.Windows.Forms.Label sitText;
        private System.Windows.Forms.Label completeNameText;
        private System.Windows.Forms.Label fligthText;
    }
}
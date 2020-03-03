namespace FormsIniciales
{
    partial class StartForm
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
            this.lbl_pacs = new System.Windows.Forms.Label();
            this.lbl_innerRingValidation = new System.Windows.Forms.Label();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.ptb_minimize = new System.Windows.Forms.PictureBox();
            this.ptb_close = new System.Windows.Forms.PictureBox();
            this.btn_enterPlanet = new System.Windows.Forms.Button();
            this.btn_enterSpaceship = new System.Windows.Forms.Button();
            this.ptb_decoration = new System.Windows.Forms.PictureBox();
            this.barraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_decoration)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pacs
            // 
            this.lbl_pacs.AutoSize = true;
            this.lbl_pacs.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbl_pacs.ForeColor = System.Drawing.Color.White;
            this.lbl_pacs.Location = new System.Drawing.Point(245, 57);
            this.lbl_pacs.Name = "lbl_pacs";
            this.lbl_pacs.Size = new System.Drawing.Size(75, 36);
            this.lbl_pacs.TabIndex = 0;
            this.lbl_pacs.Text = "PACS";
            // 
            // lbl_innerRingValidation
            // 
            this.lbl_innerRingValidation.AutoSize = true;
            this.lbl_innerRingValidation.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_innerRingValidation.ForeColor = System.Drawing.Color.White;
            this.lbl_innerRingValidation.Location = new System.Drawing.Point(193, 102);
            this.lbl_innerRingValidation.Name = "lbl_innerRingValidation";
            this.lbl_innerRingValidation.Size = new System.Drawing.Size(192, 26);
            this.lbl_innerRingValidation.TabIndex = 1;
            this.lbl_innerRingValidation.Text = "Inner Ring Validation";
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.barraSuperior.Controls.Add(this.ptb_minimize);
            this.barraSuperior.Controls.Add(this.ptb_close);
            this.barraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(564, 35);
            this.barraSuperior.TabIndex = 7;
            // 
            // ptb_minimize
            // 
            this.ptb_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ptb_minimize.Location = new System.Drawing.Point(495, 0);
            this.ptb_minimize.Name = "ptb_minimize";
            this.ptb_minimize.Size = new System.Drawing.Size(35, 35);
            this.ptb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_minimize.TabIndex = 0;
            this.ptb_minimize.TabStop = false;
            // 
            // ptb_close
            // 
            this.ptb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ptb_close.Location = new System.Drawing.Point(530, 0);
            this.ptb_close.Name = "ptb_close";
            this.ptb_close.Size = new System.Drawing.Size(35, 35);
            this.ptb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_close.TabIndex = 0;
            this.ptb_close.TabStop = false;
            // 
            // btn_enterPlanet
            // 
            this.btn_enterPlanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_enterPlanet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_enterPlanet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enterPlanet.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enterPlanet.ForeColor = System.Drawing.Color.White;
            this.btn_enterPlanet.Location = new System.Drawing.Point(100, 361);
            this.btn_enterPlanet.Name = "btn_enterPlanet";
            this.btn_enterPlanet.Size = new System.Drawing.Size(139, 32);
            this.btn_enterPlanet.TabIndex = 13;
            this.btn_enterPlanet.Text = "Enter Planet";
            this.btn_enterPlanet.UseVisualStyleBackColor = false;
            this.btn_enterPlanet.Click += new System.EventHandler(this.btn_enterPlanet_Click);
            // 
            // btn_enterSpaceship
            // 
            this.btn_enterSpaceship.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_enterSpaceship.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_enterSpaceship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enterSpaceship.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enterSpaceship.ForeColor = System.Drawing.Color.White;
            this.btn_enterSpaceship.Location = new System.Drawing.Point(310, 361);
            this.btn_enterSpaceship.Name = "btn_enterSpaceship";
            this.btn_enterSpaceship.Size = new System.Drawing.Size(156, 32);
            this.btn_enterSpaceship.TabIndex = 14;
            this.btn_enterSpaceship.Text = "Enter Spaceship";
            this.btn_enterSpaceship.UseVisualStyleBackColor = false;
            this.btn_enterSpaceship.Click += new System.EventHandler(this.btn_enterSpaceship_Click);
            // 
            // ptb_decoration
            // 
            this.ptb_decoration.Location = new System.Drawing.Point(188, 146);
            this.ptb_decoration.Name = "ptb_decoration";
            this.ptb_decoration.Size = new System.Drawing.Size(187, 179);
            this.ptb_decoration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_decoration.TabIndex = 15;
            this.ptb_decoration.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(564, 454);
            this.Controls.Add(this.ptb_decoration);
            this.Controls.Add(this.btn_enterSpaceship);
            this.Controls.Add(this.btn_enterPlanet);
            this.Controls.Add(this.barraSuperior);
            this.Controls.Add(this.lbl_innerRingValidation);
            this.Controls.Add(this.lbl_pacs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.barraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_decoration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pacs;
        private System.Windows.Forms.Label lbl_innerRingValidation;
        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.PictureBox ptb_minimize;
        private System.Windows.Forms.PictureBox ptb_close;
        private System.Windows.Forms.Button btn_enterPlanet;
        private System.Windows.Forms.Button btn_enterSpaceship;
        private System.Windows.Forms.PictureBox ptb_decoration;
    }
}
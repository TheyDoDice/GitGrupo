namespace FormsIniciales
{
    partial class EnterPlanet
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
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.ptb_minimize = new System.Windows.Forms.PictureBox();
            this.ptb_close = new System.Windows.Forms.PictureBox();
            this.lbl_enterPlanet = new System.Windows.Forms.Label();
            this.lbl_planet = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.cmbx_buscarPlaneta = new System.Windows.Forms.ComboBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.ptb_decoration = new System.Windows.Forms.PictureBox();
            this.barraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_decoration)).BeginInit();
            this.SuspendLayout();
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.barraSuperior.Controls.Add(this.ptb_minimize);
            this.barraSuperior.Controls.Add(this.ptb_close);
            this.barraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(849, 35);
            this.barraSuperior.TabIndex = 10;
            // 
            // ptb_minimize
            // 
            this.ptb_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ptb_minimize.Location = new System.Drawing.Point(780, 0);
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
            this.ptb_close.Location = new System.Drawing.Point(815, 0);
            this.ptb_close.Name = "ptb_close";
            this.ptb_close.Size = new System.Drawing.Size(35, 35);
            this.ptb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_close.TabIndex = 0;
            this.ptb_close.TabStop = false;
            // 
            // lbl_enterPlanet
            // 
            this.lbl_enterPlanet.AutoSize = true;
            this.lbl_enterPlanet.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbl_enterPlanet.ForeColor = System.Drawing.Color.White;
            this.lbl_enterPlanet.Location = new System.Drawing.Point(40, 64);
            this.lbl_enterPlanet.Name = "lbl_enterPlanet";
            this.lbl_enterPlanet.Size = new System.Drawing.Size(164, 36);
            this.lbl_enterPlanet.TabIndex = 11;
            this.lbl_enterPlanet.Text = "Enter Planet";
            // 
            // lbl_planet
            // 
            this.lbl_planet.AutoSize = true;
            this.lbl_planet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_planet.ForeColor = System.Drawing.Color.White;
            this.lbl_planet.Location = new System.Drawing.Point(82, 134);
            this.lbl_planet.Name = "lbl_planet";
            this.lbl_planet.Size = new System.Drawing.Size(84, 29);
            this.lbl_planet.TabIndex = 12;
            this.lbl_planet.Text = "Planet:";
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ip.ForeColor = System.Drawing.Color.White;
            this.lbl_ip.Location = new System.Drawing.Point(338, 134);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(39, 29);
            this.lbl_ip.TabIndex = 13;
            this.lbl_ip.Text = "Ip:";
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_enter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enter.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.ForeColor = System.Drawing.Color.White;
            this.btn_enter.Location = new System.Drawing.Point(238, 281);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(139, 32);
            this.btn_enter.TabIndex = 131;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // cmbx_buscarPlaneta
            // 
            this.cmbx_buscarPlaneta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.cmbx_buscarPlaneta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbx_buscarPlaneta.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbx_buscarPlaneta.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbx_buscarPlaneta.FormattingEnabled = true;
            this.cmbx_buscarPlaneta.Location = new System.Drawing.Point(87, 186);
            this.cmbx_buscarPlaneta.Name = "cmbx_buscarPlaneta";
            this.cmbx_buscarPlaneta.Size = new System.Drawing.Size(183, 26);
            this.cmbx_buscarPlaneta.TabIndex = 132;
            this.cmbx_buscarPlaneta.SelectedIndexChanged += new System.EventHandler(this.cmbx_buscarPlaneta_SelectedIndexChanged);
            // 
            // txt_ip
            // 
            this.txt_ip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.txt_ip.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ip.ForeColor = System.Drawing.Color.White;
            this.txt_ip.Location = new System.Drawing.Point(343, 181);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(175, 31);
            this.txt_ip.TabIndex = 133;
            // 
            // ptb_decoration
            // 
            this.ptb_decoration.Location = new System.Drawing.Point(582, 93);
            this.ptb_decoration.Name = "ptb_decoration";
            this.ptb_decoration.Size = new System.Drawing.Size(207, 220);
            this.ptb_decoration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_decoration.TabIndex = 134;
            this.ptb_decoration.TabStop = false;
            // 
            // EnterPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(849, 385);
            this.Controls.Add(this.ptb_decoration);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.cmbx_buscarPlaneta);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.lbl_ip);
            this.Controls.Add(this.lbl_planet);
            this.Controls.Add(this.lbl_enterPlanet);
            this.Controls.Add(this.barraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnterPlanet";
            this.Text = "EnterPlanet";
            this.Load += new System.EventHandler(this.EnterPlanet_Load);
            this.barraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_decoration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.PictureBox ptb_minimize;
        private System.Windows.Forms.PictureBox ptb_close;
        private System.Windows.Forms.Label lbl_enterPlanet;
        private System.Windows.Forms.Label lbl_planet;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.ComboBox cmbx_buscarPlaneta;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.PictureBox ptb_decoration;
    }
}
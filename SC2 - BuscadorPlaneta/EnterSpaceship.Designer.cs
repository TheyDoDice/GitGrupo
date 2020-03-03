namespace FormsIniciales
{
    partial class EnterSpaceship
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_enterSpaceship = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_planet = new System.Windows.Forms.Label();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.ptb_minimize = new System.Windows.Forms.PictureBox();
            this.ptb_close = new System.Windows.Forms.PictureBox();
            this.cmbx_buscarNau = new System.Windows.Forms.ComboBox();
            this.cmbx_buscarPlaneta = new System.Windows.Forms.ComboBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.ptb_decoration = new System.Windows.Forms.PictureBox();
            this.barraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_decoration)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_enterSpaceship
            // 
            this.lbl_enterSpaceship.AutoSize = true;
            this.lbl_enterSpaceship.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbl_enterSpaceship.ForeColor = System.Drawing.Color.White;
            this.lbl_enterSpaceship.Location = new System.Drawing.Point(35, 57);
            this.lbl_enterSpaceship.Name = "lbl_enterSpaceship";
            this.lbl_enterSpaceship.Size = new System.Drawing.Size(209, 36);
            this.lbl_enterSpaceship.TabIndex = 4;
            this.lbl_enterSpaceship.Text = "Enter Spaceship";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Spaceship:";
            // 
            // lbl_planet
            // 
            this.lbl_planet.AutoSize = true;
            this.lbl_planet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_planet.ForeColor = System.Drawing.Color.White;
            this.lbl_planet.Location = new System.Drawing.Point(290, 126);
            this.lbl_planet.Name = "lbl_planet";
            this.lbl_planet.Size = new System.Drawing.Size(205, 29);
            this.lbl_planet.TabIndex = 6;
            this.lbl_planet.Text = "Destination planet:";
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.barraSuperior.Controls.Add(this.ptb_minimize);
            this.barraSuperior.Controls.Add(this.ptb_close);
            this.barraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(809, 35);
            this.barraSuperior.TabIndex = 9;
            // 
            // ptb_minimize
            // 
            this.ptb_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ptb_minimize.Location = new System.Drawing.Point(740, 0);
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
            this.ptb_close.Location = new System.Drawing.Point(775, 0);
            this.ptb_close.Name = "ptb_close";
            this.ptb_close.Size = new System.Drawing.Size(35, 35);
            this.ptb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_close.TabIndex = 0;
            this.ptb_close.TabStop = false;
            // 
            // cmbx_buscarNau
            // 
            this.cmbx_buscarNau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.cmbx_buscarNau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbx_buscarNau.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbx_buscarNau.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbx_buscarNau.FormattingEnabled = true;
            this.cmbx_buscarNau.Location = new System.Drawing.Point(69, 180);
            this.cmbx_buscarNau.Name = "cmbx_buscarNau";
            this.cmbx_buscarNau.Size = new System.Drawing.Size(153, 26);
            this.cmbx_buscarNau.TabIndex = 128;
            // 
            // cmbx_buscarPlaneta
            // 
            this.cmbx_buscarPlaneta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.cmbx_buscarPlaneta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbx_buscarPlaneta.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbx_buscarPlaneta.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbx_buscarPlaneta.FormattingEnabled = true;
            this.cmbx_buscarPlaneta.Location = new System.Drawing.Point(295, 180);
            this.cmbx_buscarPlaneta.Name = "cmbx_buscarPlaneta";
            this.cmbx_buscarPlaneta.Size = new System.Drawing.Size(145, 26);
            this.cmbx_buscarPlaneta.TabIndex = 129;
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_enter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enter.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.ForeColor = System.Drawing.Color.White;
            this.btn_enter.Location = new System.Drawing.Point(190, 275);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(139, 32);
            this.btn_enter.TabIndex = 130;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click_1);
            // 
            // ptb_decoration
            // 
            this.ptb_decoration.Location = new System.Drawing.Point(537, 87);
            this.ptb_decoration.Name = "ptb_decoration";
            this.ptb_decoration.Size = new System.Drawing.Size(207, 220);
            this.ptb_decoration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_decoration.TabIndex = 131;
            this.ptb_decoration.TabStop = false;
            // 
            // EnterSpaceship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(809, 371);
            this.Controls.Add(this.ptb_decoration);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.cmbx_buscarPlaneta);
            this.Controls.Add(this.cmbx_buscarNau);
            this.Controls.Add(this.barraSuperior);
            this.Controls.Add(this.lbl_planet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_enterSpaceship);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnterSpaceship";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.barraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_decoration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_enterSpaceship;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_planet;
        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.PictureBox ptb_minimize;
        private System.Windows.Forms.PictureBox ptb_close;
        private System.Windows.Forms.ComboBox cmbx_buscarNau;
        private System.Windows.Forms.ComboBox cmbx_buscarPlaneta;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.PictureBox ptb_decoration;
    }
}


namespace ProyectoPrincipal.Forms
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.bordeDerecha = new System.Windows.Forms.Panel();
            this.bordeIzquierda = new System.Windows.Forms.Panel();
            this.bordeInferior = new System.Windows.Forms.Panel();
            this.bordeSuperior = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_splash = new System.Windows.Forms.Label();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.subTop = new System.Windows.Forms.Panel();
            this.barraInferior = new System.Windows.Forms.Panel();
            this.subBot = new System.Windows.Forms.Panel();
            this.subMid = new System.Windows.Forms.Panel();
            this.ptb_meanwhile = new System.Windows.Forms.PictureBox();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_meanwhile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bordeDerecha
            // 
            this.bordeDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.bordeDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.bordeDerecha.Location = new System.Drawing.Point(433, 0);
            this.bordeDerecha.Name = "bordeDerecha";
            this.bordeDerecha.Size = new System.Drawing.Size(1, 338);
            this.bordeDerecha.TabIndex = 6;
            // 
            // bordeIzquierda
            // 
            this.bordeIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.bordeIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.bordeIzquierda.Location = new System.Drawing.Point(0, 0);
            this.bordeIzquierda.Name = "bordeIzquierda";
            this.bordeIzquierda.Size = new System.Drawing.Size(1, 338);
            this.bordeIzquierda.TabIndex = 7;
            // 
            // bordeInferior
            // 
            this.bordeInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.bordeInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bordeInferior.Location = new System.Drawing.Point(1, 337);
            this.bordeInferior.Name = "bordeInferior";
            this.bordeInferior.Size = new System.Drawing.Size(432, 1);
            this.bordeInferior.TabIndex = 8;
            // 
            // bordeSuperior
            // 
            this.bordeSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.bordeSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.bordeSuperior.Location = new System.Drawing.Point(1, 0);
            this.bordeSuperior.Name = "bordeSuperior";
            this.bordeSuperior.Size = new System.Drawing.Size(432, 1);
            this.bordeSuperior.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_splash
            // 
            this.lbl_splash.AutoSize = true;
            this.lbl_splash.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbl_splash.ForeColor = System.Drawing.Color.White;
            this.lbl_splash.Location = new System.Drawing.Point(12, 78);
            this.lbl_splash.Name = "lbl_splash";
            this.lbl_splash.Size = new System.Drawing.Size(143, 36);
            this.lbl_splash.TabIndex = 16;
            this.lbl_splash.Text = "Welcome, ";
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.barraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior.Location = new System.Drawing.Point(1, 1);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(432, 19);
            this.barraSuperior.TabIndex = 0;
            // 
            // subTop
            // 
            this.subTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.subTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.subTop.Location = new System.Drawing.Point(1, 20);
            this.subTop.Name = "subTop";
            this.subTop.Size = new System.Drawing.Size(432, 2);
            this.subTop.TabIndex = 18;
            // 
            // barraInferior
            // 
            this.barraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.barraInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInferior.Location = new System.Drawing.Point(1, 318);
            this.barraInferior.Name = "barraInferior";
            this.barraInferior.Size = new System.Drawing.Size(432, 19);
            this.barraInferior.TabIndex = 19;
            // 
            // subBot
            // 
            this.subBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.subBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.subBot.Location = new System.Drawing.Point(1, 316);
            this.subBot.Name = "subBot";
            this.subBot.Size = new System.Drawing.Size(432, 2);
            this.subBot.TabIndex = 20;
            // 
            // subMid
            // 
            this.subMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.subMid.Location = new System.Drawing.Point(273, 28);
            this.subMid.Name = "subMid";
            this.subMid.Size = new System.Drawing.Size(2, 270);
            this.subMid.TabIndex = 21;
            // 
            // ptb_meanwhile
            // 
            this.ptb_meanwhile.Location = new System.Drawing.Point(12, 159);
            this.ptb_meanwhile.Name = "ptb_meanwhile";
            this.ptb_meanwhile.Size = new System.Drawing.Size(255, 92);
            this.ptb_meanwhile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_meanwhile.TabIndex = 22;
            this.ptb_meanwhile.TabStop = false;
            // 
            // ptb_logo
            // 
            this.ptb_logo.Location = new System.Drawing.Point(282, 6);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(150, 325);
            this.ptb_logo.TabIndex = 15;
            this.ptb_logo.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(434, 338);
            this.Controls.Add(this.ptb_meanwhile);
            this.Controls.Add(this.subMid);
            this.Controls.Add(this.subBot);
            this.Controls.Add(this.barraInferior);
            this.Controls.Add(this.subTop);
            this.Controls.Add(this.barraSuperior);
            this.Controls.Add(this.lbl_splash);
            this.Controls.Add(this.ptb_logo);
            this.Controls.Add(this.bordeSuperior);
            this.Controls.Add(this.bordeInferior);
            this.Controls.Add(this.bordeIzquierda);
            this.Controls.Add(this.bordeDerecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_meanwhile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bordeDerecha;
        private System.Windows.Forms.Panel bordeIzquierda;
        private System.Windows.Forms.Panel bordeInferior;
        private System.Windows.Forms.Panel bordeSuperior;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_splash;
        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Panel subTop;
        private System.Windows.Forms.Panel barraInferior;
        private System.Windows.Forms.Panel subBot;
        private System.Windows.Forms.Panel subMid;
        private System.Windows.Forms.PictureBox ptb_meanwhile;
        private System.Windows.Forms.PictureBox ptb_logo;
    }
}
namespace Odisea_en_el_espacio
{
    partial class Rocket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rocket));
            this.lbl_warning = new System.Windows.Forms.Label();
            this.lbl_planetname = new System.Windows.Forms.Label();
            this.btn_run2 = new System.Windows.Forms.Button();
            this.lbl_coordZ = new System.Windows.Forms.Label();
            this.lbl_coordY = new System.Windows.Forms.Label();
            this.lbl_coordX = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_Frenar = new System.Windows.Forms.Button();
            this.pbx_bb8 = new System.Windows.Forms.PictureBox();
            this.pbx_r2d2 = new System.Windows.Forms.PictureBox();
            this.pbx_c3po = new System.Windows.Forms.PictureBox();
            this.nau = new System.Windows.Forms.PictureBox();
            this.planeta = new System.Windows.Forms.PictureBox();
            this.gif = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_bb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_r2d2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_c3po)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.BackColor = System.Drawing.Color.Transparent;
            this.lbl_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warning.ForeColor = System.Drawing.Color.Red;
            this.lbl_warning.Location = new System.Drawing.Point(549, 483);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(113, 25);
            this.lbl_warning.TabIndex = 31;
            this.lbl_warning.Text = "WARNING!";
            this.lbl_warning.Visible = false;
            // 
            // lbl_planetname
            // 
            this.lbl_planetname.AutoSize = true;
            this.lbl_planetname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_planetname.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_planetname.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_planetname.Location = new System.Drawing.Point(196, 456);
            this.lbl_planetname.Name = "lbl_planetname";
            this.lbl_planetname.Size = new System.Drawing.Size(81, 29);
            this.lbl_planetname.TabIndex = 30;
            this.lbl_planetname.Text = "Planet";
            this.lbl_planetname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_planetname.Visible = false;
            // 
            // btn_run2
            // 
            this.btn_run2.BackColor = System.Drawing.Color.DimGray;
            this.btn_run2.Enabled = false;
            this.btn_run2.Location = new System.Drawing.Point(839, 595);
            this.btn_run2.Name = "btn_run2";
            this.btn_run2.Size = new System.Drawing.Size(22, 23);
            this.btn_run2.TabIndex = 29;
            this.btn_run2.UseVisualStyleBackColor = false;
            this.btn_run2.Click += new System.EventHandler(this.btn_run2_Click);
            // 
            // lbl_coordZ
            // 
            this.lbl_coordZ.AutoSize = true;
            this.lbl_coordZ.BackColor = System.Drawing.Color.Transparent;
            this.lbl_coordZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coordZ.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_coordZ.Location = new System.Drawing.Point(905, 454);
            this.lbl_coordZ.Name = "lbl_coordZ";
            this.lbl_coordZ.Size = new System.Drawing.Size(45, 13);
            this.lbl_coordZ.TabIndex = 28;
            this.lbl_coordZ.Text = "Coord Z";
            this.lbl_coordZ.Visible = false;
            // 
            // lbl_coordY
            // 
            this.lbl_coordY.AutoSize = true;
            this.lbl_coordY.BackColor = System.Drawing.Color.Transparent;
            this.lbl_coordY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coordY.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_coordY.Location = new System.Drawing.Point(905, 432);
            this.lbl_coordY.Name = "lbl_coordY";
            this.lbl_coordY.Size = new System.Drawing.Size(45, 13);
            this.lbl_coordY.TabIndex = 27;
            this.lbl_coordY.Text = "Coord Y";
            this.lbl_coordY.Visible = false;
            // 
            // lbl_coordX
            // 
            this.lbl_coordX.AutoSize = true;
            this.lbl_coordX.BackColor = System.Drawing.Color.Transparent;
            this.lbl_coordX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coordX.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_coordX.Location = new System.Drawing.Point(905, 410);
            this.lbl_coordX.Name = "lbl_coordX";
            this.lbl_coordX.Size = new System.Drawing.Size(45, 13);
            this.lbl_coordX.TabIndex = 26;
            this.lbl_coordX.Text = "Coord X";
            this.lbl_coordX.Visible = false;
            // 
            // btn_run
            // 
            this.btn_run.BackColor = System.Drawing.Color.DimGray;
            this.btn_run.Location = new System.Drawing.Point(746, 595);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(22, 23);
            this.btn_run.TabIndex = 25;
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_Frenar
            // 
            this.btn_Frenar.AutoSize = true;
            this.btn_Frenar.BackColor = System.Drawing.Color.DimGray;
            this.btn_Frenar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Frenar.Enabled = false;
            this.btn_Frenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Frenar.Location = new System.Drawing.Point(356, 595);
            this.btn_Frenar.Name = "btn_Frenar";
            this.btn_Frenar.Size = new System.Drawing.Size(97, 34);
            this.btn_Frenar.TabIndex = 24;
            this.btn_Frenar.Text = "SPEED UP";
            this.btn_Frenar.UseVisualStyleBackColor = false;
            this.btn_Frenar.Click += new System.EventHandler(this.btn_Frenar_Click);
            // 
            // pbx_bb8
            // 
            this.pbx_bb8.BackColor = System.Drawing.Color.Transparent;
            this.pbx_bb8.InitialImage = null;
            this.pbx_bb8.Location = new System.Drawing.Point(285, 23);
            this.pbx_bb8.Name = "pbx_bb8";
            this.pbx_bb8.Size = new System.Drawing.Size(75, 100);
            this.pbx_bb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_bb8.TabIndex = 19;
            this.pbx_bb8.TabStop = false;
            this.pbx_bb8.Visible = false;
            // 
            // pbx_r2d2
            // 
            this.pbx_r2d2.BackColor = System.Drawing.Color.Transparent;
            this.pbx_r2d2.InitialImage = null;
            this.pbx_r2d2.Location = new System.Drawing.Point(28, 23);
            this.pbx_r2d2.Name = "pbx_r2d2";
            this.pbx_r2d2.Size = new System.Drawing.Size(75, 100);
            this.pbx_r2d2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_r2d2.TabIndex = 21;
            this.pbx_r2d2.TabStop = false;
            this.pbx_r2d2.Visible = false;
            // 
            // pbx_c3po
            // 
            this.pbx_c3po.BackColor = System.Drawing.Color.Transparent;
            this.pbx_c3po.InitialImage = null;
            this.pbx_c3po.Location = new System.Drawing.Point(154, 23);
            this.pbx_c3po.Name = "pbx_c3po";
            this.pbx_c3po.Size = new System.Drawing.Size(75, 100);
            this.pbx_c3po.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_c3po.TabIndex = 20;
            this.pbx_c3po.TabStop = false;
            this.pbx_c3po.Visible = false;
            // 
            // nau
            // 
            this.nau.BackColor = System.Drawing.Color.Transparent;
            this.nau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nau.Image = ((System.Drawing.Image)(resources.GetObject("nau.Image")));
            this.nau.InitialImage = null;
            this.nau.Location = new System.Drawing.Point(0, 0);
            this.nau.Name = "nau";
            this.nau.Size = new System.Drawing.Size(1019, 704);
            this.nau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nau.TabIndex = 18;
            this.nau.TabStop = false;
            // 
            // planeta
            // 
            this.planeta.BackColor = System.Drawing.Color.Transparent;
            this.planeta.Location = new System.Drawing.Point(512, -31);
            this.planeta.Name = "planeta";
            this.planeta.Size = new System.Drawing.Size(100, 50);
            this.planeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.planeta.TabIndex = 23;
            this.planeta.TabStop = false;
            // 
            // gif
            // 
            this.gif.BackColor = System.Drawing.Color.Transparent;
            this.gif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gif.InitialImage = null;
            this.gif.Location = new System.Drawing.Point(0, 0);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(1019, 704);
            this.gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gif.TabIndex = 22;
            this.gif.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Rocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1019, 704);
            this.Controls.Add(this.lbl_warning);
            this.Controls.Add(this.lbl_planetname);
            this.Controls.Add(this.btn_run2);
            this.Controls.Add(this.lbl_coordZ);
            this.Controls.Add(this.lbl_coordY);
            this.Controls.Add(this.lbl_coordX);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.btn_Frenar);
            this.Controls.Add(this.pbx_bb8);
            this.Controls.Add(this.pbx_r2d2);
            this.Controls.Add(this.pbx_c3po);
            this.Controls.Add(this.nau);
            this.Controls.Add(this.planeta);
            this.Controls.Add(this.gif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rocket";
            this.Text = "Rocket";
            this.Load += new System.EventHandler(this.Rocket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_bb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_r2d2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_c3po)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.Label lbl_planetname;
        private System.Windows.Forms.Button btn_run2;
        private System.Windows.Forms.Label lbl_coordZ;
        private System.Windows.Forms.Label lbl_coordY;
        private System.Windows.Forms.Label lbl_coordX;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_Frenar;
        private System.Windows.Forms.PictureBox pbx_bb8;
        private System.Windows.Forms.PictureBox pbx_r2d2;
        private System.Windows.Forms.PictureBox pbx_c3po;
        private System.Windows.Forms.PictureBox nau;
        private System.Windows.Forms.PictureBox planeta;
        private System.Windows.Forms.PictureBox gif;
        public System.Windows.Forms.Timer timer1;
    }
}
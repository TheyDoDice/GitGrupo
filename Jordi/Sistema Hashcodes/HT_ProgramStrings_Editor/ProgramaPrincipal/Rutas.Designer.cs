namespace ProgramaPrincipal
{
    partial class Rutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rutas));
            this.gb_rutas = new System.Windows.Forms.GroupBox();
            this.btn_loadHashcodes = new System.Windows.Forms.Button();
            this.tb_HashcodesFileRoute = new System.Windows.Forms.TextBox();
            this.lbl_HashcodesRoute = new System.Windows.Forms.Label();
            this.btn_LoadTextFile = new System.Windows.Forms.Button();
            this.tb_ProgramStrings = new System.Windows.Forms.TextBox();
            this.lbl_textfile = new System.Windows.Forms.Label();
            this.lbl_colors = new System.Windows.Forms.Label();
            this.tb_ProgramColors = new System.Windows.Forms.TextBox();
            this.btn_loadColores = new System.Windows.Forms.Button();
            this.gb_rutas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_rutas
            // 
            this.gb_rutas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_rutas.Controls.Add(this.btn_loadColores);
            this.gb_rutas.Controls.Add(this.tb_ProgramColors);
            this.gb_rutas.Controls.Add(this.lbl_colors);
            this.gb_rutas.Controls.Add(this.btn_loadHashcodes);
            this.gb_rutas.Controls.Add(this.tb_HashcodesFileRoute);
            this.gb_rutas.Controls.Add(this.lbl_HashcodesRoute);
            this.gb_rutas.Controls.Add(this.btn_LoadTextFile);
            this.gb_rutas.Controls.Add(this.tb_ProgramStrings);
            this.gb_rutas.Controls.Add(this.lbl_textfile);
            this.gb_rutas.Location = new System.Drawing.Point(12, 12);
            this.gb_rutas.Name = "gb_rutas";
            this.gb_rutas.Size = new System.Drawing.Size(588, 102);
            this.gb_rutas.TabIndex = 9;
            this.gb_rutas.TabStop = false;
            // 
            // btn_loadHashcodes
            // 
            this.btn_loadHashcodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_loadHashcodes.Location = new System.Drawing.Point(501, 37);
            this.btn_loadHashcodes.Name = "btn_loadHashcodes";
            this.btn_loadHashcodes.Size = new System.Drawing.Size(75, 23);
            this.btn_loadHashcodes.TabIndex = 9;
            this.btn_loadHashcodes.Text = "Cargar";
            this.btn_loadHashcodes.UseVisualStyleBackColor = true;
            this.btn_loadHashcodes.Click += new System.EventHandler(this.btn_loadHashcodes_Click);
            // 
            // tb_HashcodesFileRoute
            // 
            this.tb_HashcodesFileRoute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_HashcodesFileRoute.Location = new System.Drawing.Point(109, 39);
            this.tb_HashcodesFileRoute.Name = "tb_HashcodesFileRoute";
            this.tb_HashcodesFileRoute.ReadOnly = true;
            this.tb_HashcodesFileRoute.Size = new System.Drawing.Size(386, 20);
            this.tb_HashcodesFileRoute.TabIndex = 8;
            // 
            // lbl_HashcodesRoute
            // 
            this.lbl_HashcodesRoute.AutoSize = true;
            this.lbl_HashcodesRoute.Location = new System.Drawing.Point(6, 42);
            this.lbl_HashcodesRoute.Name = "lbl_HashcodesRoute";
            this.lbl_HashcodesRoute.Size = new System.Drawing.Size(103, 13);
            this.lbl_HashcodesRoute.TabIndex = 7;
            this.lbl_HashcodesRoute.Text = "Archivo Hashcodes:";
            // 
            // btn_LoadTextFile
            // 
            this.btn_LoadTextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LoadTextFile.Location = new System.Drawing.Point(501, 11);
            this.btn_LoadTextFile.Name = "btn_LoadTextFile";
            this.btn_LoadTextFile.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadTextFile.TabIndex = 6;
            this.btn_LoadTextFile.Text = "Cargar";
            this.btn_LoadTextFile.UseVisualStyleBackColor = true;
            this.btn_LoadTextFile.Click += new System.EventHandler(this.btn_LoadTextFile_Click);
            // 
            // tb_ProgramStrings
            // 
            this.tb_ProgramStrings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ProgramStrings.Location = new System.Drawing.Point(109, 13);
            this.tb_ProgramStrings.Name = "tb_ProgramStrings";
            this.tb_ProgramStrings.ReadOnly = true;
            this.tb_ProgramStrings.Size = new System.Drawing.Size(386, 20);
            this.tb_ProgramStrings.TabIndex = 5;
            // 
            // lbl_textfile
            // 
            this.lbl_textfile.AutoSize = true;
            this.lbl_textfile.Location = new System.Drawing.Point(34, 16);
            this.lbl_textfile.Name = "lbl_textfile";
            this.lbl_textfile.Size = new System.Drawing.Size(76, 13);
            this.lbl_textfile.TabIndex = 4;
            this.lbl_textfile.Text = "Archivo Texto:";
            // 
            // lbl_colors
            // 
            this.lbl_colors.AutoSize = true;
            this.lbl_colors.Location = new System.Drawing.Point(25, 70);
            this.lbl_colors.Name = "lbl_colors";
            this.lbl_colors.Size = new System.Drawing.Size(84, 13);
            this.lbl_colors.TabIndex = 10;
            this.lbl_colors.Text = "Archivo Colores:";
            // 
            // tb_ProgramColors
            // 
            this.tb_ProgramColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ProgramColors.Location = new System.Drawing.Point(109, 67);
            this.tb_ProgramColors.Name = "tb_ProgramColors";
            this.tb_ProgramColors.ReadOnly = true;
            this.tb_ProgramColors.Size = new System.Drawing.Size(386, 20);
            this.tb_ProgramColors.TabIndex = 11;
            // 
            // btn_loadColores
            // 
            this.btn_loadColores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_loadColores.Location = new System.Drawing.Point(501, 65);
            this.btn_loadColores.Name = "btn_loadColores";
            this.btn_loadColores.Size = new System.Drawing.Size(75, 23);
            this.btn_loadColores.TabIndex = 12;
            this.btn_loadColores.Text = "Cargar";
            this.btn_loadColores.UseVisualStyleBackColor = true;
            this.btn_loadColores.Click += new System.EventHandler(this.btn_loadColores_Click);
            // 
            // Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 126);
            this.Controls.Add(this.gb_rutas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rutas";
            this.Text = "Rutas";
            this.Load += new System.EventHandler(this.Rutas_Load);
            this.gb_rutas.ResumeLayout(false);
            this.gb_rutas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_rutas;
        private System.Windows.Forms.Button btn_loadHashcodes;
        private System.Windows.Forms.Label lbl_HashcodesRoute;
        private System.Windows.Forms.Button btn_LoadTextFile;
        private System.Windows.Forms.Label lbl_textfile;
        private System.Windows.Forms.TextBox tb_HashcodesFileRoute;
        private System.Windows.Forms.TextBox tb_ProgramStrings;
        private System.Windows.Forms.Button btn_loadColores;
        private System.Windows.Forms.TextBox tb_ProgramColors;
        private System.Windows.Forms.Label lbl_colors;
    }
}
namespace FormsMantemimiento
{
    partial class BuscaMantenimientoPlanets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ptb_close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cercar = new System.Windows.Forms.Button();
            this.swt_idSpecie = new CC_Library.SWTextbox();
            this.swt_idRegion = new CC_Library.SWTextbox();
            this.swc_CodeSpecie = new CC_Library.SWCodi();
            this.swc_CodeRegion = new CC_Library.SWCodi();
            this.dataGridView_Planets = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Planets)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_close
            // 
            this.ptb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ptb_close.Location = new System.Drawing.Point(1016, -11);
            this.ptb_close.Name = "ptb_close";
            this.ptb_close.Size = new System.Drawing.Size(35, 35);
            this.ptb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_close.TabIndex = 17;
            this.ptb_close.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.pictureBox1.Location = new System.Drawing.Point(932, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.groupBox1.Controls.Add(this.dataGridView_Planets);
            this.groupBox1.Controls.Add(this.btn_cercar);
            this.groupBox1.Controls.Add(this.swt_idSpecie);
            this.groupBox1.Controls.Add(this.swt_idRegion);
            this.groupBox1.Controls.Add(this.swc_CodeSpecie);
            this.groupBox1.Controls.Add(this.swc_CodeRegion);
            this.groupBox1.Location = new System.Drawing.Point(0, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 432);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // btn_cercar
            // 
            this.btn_cercar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_cercar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cercar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cercar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cercar.ForeColor = System.Drawing.Color.White;
            this.btn_cercar.Location = new System.Drawing.Point(49, 150);
            this.btn_cercar.Name = "btn_cercar";
            this.btn_cercar.Size = new System.Drawing.Size(117, 29);
            this.btn_cercar.TabIndex = 23;
            this.btn_cercar.Text = "Cercar planetes";
            this.btn_cercar.UseVisualStyleBackColor = false;
            this.btn_cercar.Click += new System.EventHandler(this.btn_cercar_Click);
            // 
            // swt_idSpecie
            // 
            this.swt_idSpecie.ControlID = "swc_CodeSpecie";
            this.swt_idSpecie.DadaTipus = CC_Library.SWTextbox.tipDades.Numero;
            this.swt_idSpecie.foranea = false;
            this.swt_idSpecie.Location = new System.Drawing.Point(348, 99);
            this.swt_idSpecie.mensaje = null;
            this.swt_idSpecie.Name = "swt_idSpecie";
            this.swt_idSpecie.nomCamp = null;
            this.swt_idSpecie.nomComboBox = null;
            this.swt_idSpecie.requerit = false;
            this.swt_idSpecie.Size = new System.Drawing.Size(32, 20);
            this.swt_idSpecie.TabIndex = 13;
            this.swt_idSpecie.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_idRegion
            // 
            this.swt_idRegion.ControlID = "swc_CodeRegion";
            this.swt_idRegion.DadaTipus = CC_Library.SWTextbox.tipDades.Numero;
            this.swt_idRegion.foranea = false;
            this.swt_idRegion.Location = new System.Drawing.Point(348, 56);
            this.swt_idRegion.mensaje = null;
            this.swt_idRegion.Name = "swt_idRegion";
            this.swt_idRegion.nomCamp = null;
            this.swt_idRegion.nomComboBox = null;
            this.swt_idRegion.requerit = false;
            this.swt_idRegion.Size = new System.Drawing.Size(32, 20);
            this.swt_idRegion.TabIndex = 12;
            this.swt_idRegion.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swc_CodeSpecie
            // 
            this.swc_CodeSpecie.ClasseCS = null;
            this.swc_CodeSpecie.CodiID = "";
            this.swc_CodeSpecie.ControlID = "swt_idSpecie";
            this.swc_CodeSpecie.FormCS = null;
            this.swc_CodeSpecie.Location = new System.Drawing.Point(49, 97);
            this.swc_CodeSpecie.Name = "swc_CodeSpecie";
            this.swc_CodeSpecie.NomCodi = "CodeSpecie";
            this.swc_CodeSpecie.NomDesc = "DescSpecie";
            this.swc_CodeSpecie.NomID = "idSpecie";
            this.swc_CodeSpecie.NomTaula = "Species";
            this.swc_CodeSpecie.Requerit = false;
            this.swc_CodeSpecie.Size = new System.Drawing.Size(293, 27);
            this.swc_CodeSpecie.TabIndex = 10;
            // 
            // swc_CodeRegion
            // 
            this.swc_CodeRegion.ClasseCS = null;
            this.swc_CodeRegion.CodiID = "";
            this.swc_CodeRegion.ControlID = "swt_idRegion";
            this.swc_CodeRegion.FormCS = null;
            this.swc_CodeRegion.Location = new System.Drawing.Point(49, 54);
            this.swc_CodeRegion.Name = "swc_CodeRegion";
            this.swc_CodeRegion.NomCodi = "CodeRegion";
            this.swc_CodeRegion.NomDesc = "DescRegion";
            this.swc_CodeRegion.NomID = "idRegion";
            this.swc_CodeRegion.NomTaula = "Regions";
            this.swc_CodeRegion.Requerit = false;
            this.swc_CodeRegion.Size = new System.Drawing.Size(293, 27);
            this.swc_CodeRegion.TabIndex = 9;
            // 
            // dataGridView_Planets
            // 
            this.dataGridView_Planets.AllowUserToAddRows = false;
            this.dataGridView_Planets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Planets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Planets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.dataGridView_Planets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Planets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Planets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Planets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Planets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Planets.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Planets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Planets.EnableHeadersVisualStyles = false;
            this.dataGridView_Planets.GridColor = System.Drawing.Color.White;
            this.dataGridView_Planets.Location = new System.Drawing.Point(3, 194);
            this.dataGridView_Planets.Name = "dataGridView_Planets";
            this.dataGridView_Planets.ReadOnly = true;
            this.dataGridView_Planets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Planets.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dataGridView_Planets.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Planets.Size = new System.Drawing.Size(961, 235);
            this.dataGridView_Planets.TabIndex = 24;
            // 
            // BuscaMantenimientoPlanets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(967, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ptb_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscaMantenimientoPlanets";
            this.Text = "BuscaMantenimientoPlanetse";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Planets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cercar;
        private CC_Library.SWTextbox swt_idSpecie;
        private CC_Library.SWTextbox swt_idRegion;
        private CC_Library.SWCodi swc_CodeSpecie;
        private CC_Library.SWCodi swc_CodeRegion;
        protected System.Windows.Forms.DataGridView dataGridView_Planets;
    }
}
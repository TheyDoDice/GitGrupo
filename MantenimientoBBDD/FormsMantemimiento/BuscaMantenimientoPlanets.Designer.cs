﻿namespace FormsMantemimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ptb_close = new System.Windows.Forms.PictureBox();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_Planets = new System.Windows.Forms.DataGridView();
            this.btn_cercar = new System.Windows.Forms.Button();
            this.swt_idSpecie = new CC_Library.SWTextbox();
            this.swt_idRegion = new CC_Library.SWTextbox();
            this.swc_CodeSpecie = new CC_Library.SWCodi();
            this.swc_CodeRegion = new CC_Library.SWCodi();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).BeginInit();
            this.barraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Planets)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_close
            // 
            this.ptb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ptb_close.Location = new System.Drawing.Point(932, 0);
            this.ptb_close.Name = "ptb_close";
            this.ptb_close.Size = new System.Drawing.Size(35, 35);
            this.ptb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_close.TabIndex = 17;
            this.ptb_close.TabStop = false;
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.barraSuperior.Controls.Add(this.ptb_close);
            this.barraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(967, 35);
            this.barraSuperior.TabIndex = 20;
            this.barraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(341, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 169);
            this.panel1.TabIndex = 133;
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
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Planets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView_Planets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Planets.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView_Planets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Planets.EnableHeadersVisualStyles = false;
            this.dataGridView_Planets.GridColor = System.Drawing.Color.White;
            this.dataGridView_Planets.Location = new System.Drawing.Point(0, 238);
            this.dataGridView_Planets.Name = "dataGridView_Planets";
            this.dataGridView_Planets.ReadOnly = true;
            this.dataGridView_Planets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Planets.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dataGridView_Planets.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView_Planets.Size = new System.Drawing.Size(967, 235);
            this.dataGridView_Planets.TabIndex = 132;
            // 
            // btn_cercar
            // 
            this.btn_cercar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_cercar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cercar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cercar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cercar.ForeColor = System.Drawing.Color.White;
            this.btn_cercar.Location = new System.Drawing.Point(42, 169);
            this.btn_cercar.Name = "btn_cercar";
            this.btn_cercar.Size = new System.Drawing.Size(117, 29);
            this.btn_cercar.TabIndex = 131;
            this.btn_cercar.Text = "Cercar planetes";
            this.btn_cercar.UseVisualStyleBackColor = false;
            this.btn_cercar.Click += new System.EventHandler(this.btn_cercar_Click_1);
            // 
            // swt_idSpecie
            // 
            this.swt_idSpecie.ControlID = "swc_CodeSpecie";
            this.swt_idSpecie.DadaTipus = CC_Library.SWTextbox.tipDades.Numero;
            this.swt_idSpecie.foranea = false;
            this.swt_idSpecie.Location = new System.Drawing.Point(341, 118);
            this.swt_idSpecie.mensaje = null;
            this.swt_idSpecie.Name = "swt_idSpecie";
            this.swt_idSpecie.nomCamp = null;
            this.swt_idSpecie.nomComboBox = null;
            this.swt_idSpecie.requerit = false;
            this.swt_idSpecie.Size = new System.Drawing.Size(32, 20);
            this.swt_idSpecie.TabIndex = 130;
            this.swt_idSpecie.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_idRegion
            // 
            this.swt_idRegion.ControlID = "swc_CodeRegion";
            this.swt_idRegion.DadaTipus = CC_Library.SWTextbox.tipDades.Numero;
            this.swt_idRegion.foranea = false;
            this.swt_idRegion.Location = new System.Drawing.Point(341, 75);
            this.swt_idRegion.mensaje = null;
            this.swt_idRegion.Name = "swt_idRegion";
            this.swt_idRegion.nomCamp = null;
            this.swt_idRegion.nomComboBox = null;
            this.swt_idRegion.requerit = false;
            this.swt_idRegion.Size = new System.Drawing.Size(32, 20);
            this.swt_idRegion.TabIndex = 129;
            this.swt_idRegion.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swc_CodeSpecie
            // 
            this.swc_CodeSpecie.ClasseCS = null;
            this.swc_CodeSpecie.CodiID = "";
            this.swc_CodeSpecie.ControlID = "swt_idSpecie";
            this.swc_CodeSpecie.FormCS = null;
            this.swc_CodeSpecie.Location = new System.Drawing.Point(42, 116);
            this.swc_CodeSpecie.Name = "swc_CodeSpecie";
            this.swc_CodeSpecie.NomCodi = "CodeSpecie";
            this.swc_CodeSpecie.NomDesc = "DescSpecie";
            this.swc_CodeSpecie.NomID = "idSpecie";
            this.swc_CodeSpecie.NomTaula = "Species";
            this.swc_CodeSpecie.Requerit = false;
            this.swc_CodeSpecie.Size = new System.Drawing.Size(293, 27);
            this.swc_CodeSpecie.TabIndex = 128;
            // 
            // swc_CodeRegion
            // 
            this.swc_CodeRegion.ClasseCS = null;
            this.swc_CodeRegion.CodiID = "";
            this.swc_CodeRegion.ControlID = "swt_idRegion";
            this.swc_CodeRegion.FormCS = null;
            this.swc_CodeRegion.Location = new System.Drawing.Point(42, 73);
            this.swc_CodeRegion.Name = "swc_CodeRegion";
            this.swc_CodeRegion.NomCodi = "CodeRegion";
            this.swc_CodeRegion.NomDesc = "DescRegion";
            this.swc_CodeRegion.NomID = "idRegion";
            this.swc_CodeRegion.NomTaula = "Regions";
            this.swc_CodeRegion.Requerit = false;
            this.swc_CodeRegion.Size = new System.Drawing.Size(293, 27);
            this.swc_CodeRegion.TabIndex = 127;
            // 
            // BuscaMantenimientoPlanets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(967, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Planets);
            this.Controls.Add(this.btn_cercar);
            this.Controls.Add(this.swt_idSpecie);
            this.Controls.Add(this.swt_idRegion);
            this.Controls.Add(this.swc_CodeSpecie);
            this.Controls.Add(this.swc_CodeRegion);
            this.Controls.Add(this.barraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscaMantenimientoPlanets";
            this.Text = "BuscaMantenimientoPlanetse";
            this.Load += new System.EventHandler(this.BuscaMantenimientoPlanets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).EndInit();
            this.barraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Planets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_close;
        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.DataGridView dataGridView_Planets;
        private System.Windows.Forms.Button btn_cercar;
        private CC_Library.SWTextbox swt_idSpecie;
        private CC_Library.SWTextbox swt_idRegion;
        private CC_Library.SWCodi swc_CodeSpecie;
        private CC_Library.SWCodi swc_CodeRegion;
    }
}
namespace FormsMantemimiento
{
    partial class MantenimientoUserCategories
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
            this.lb_codeSpecie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.swt_codeCategory = new CC_Library.SWTextbox();
            this.swt_descCategory = new CC_Library.SWTextbox();
            this.swt_accessLevel = new CC_Library.SWTextbox();
            this.btn_actualizarDataset = new System.Windows.Forms.Button();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_codeSpecie
            // 
            this.lb_codeSpecie.AutoSize = true;
            this.lb_codeSpecie.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_codeSpecie.ForeColor = System.Drawing.Color.White;
            this.lb_codeSpecie.Location = new System.Drawing.Point(53, 60);
            this.lb_codeSpecie.Name = "lb_codeSpecie";
            this.lb_codeSpecie.Size = new System.Drawing.Size(138, 24);
            this.lb_codeSpecie.TabIndex = 71;
            this.lb_codeSpecie.Text = "Code Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 72;
            this.label1.Text = "Description Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 73;
            this.label2.Text = "Access Level:";
            // 
            // swt_codeCategory
            // 
            this.swt_codeCategory.ControlID = null;
            this.swt_codeCategory.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_codeCategory.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_codeCategory.foranea = false;
            this.swt_codeCategory.ForeColor = System.Drawing.Color.DimGray;
            this.swt_codeCategory.Location = new System.Drawing.Point(263, 57);
            this.swt_codeCategory.mensaje = null;
            this.swt_codeCategory.Name = "swt_codeCategory";
            this.swt_codeCategory.nomCamp = "CodeCategory";
            this.swt_codeCategory.nomComboBox = null;
            this.swt_codeCategory.requerit = false;
            this.swt_codeCategory.Size = new System.Drawing.Size(194, 32);
            this.swt_codeCategory.TabIndex = 74;
            this.swt_codeCategory.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_descCategory
            // 
            this.swt_descCategory.ControlID = null;
            this.swt_descCategory.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_descCategory.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_descCategory.foranea = false;
            this.swt_descCategory.ForeColor = System.Drawing.Color.DimGray;
            this.swt_descCategory.Location = new System.Drawing.Point(263, 112);
            this.swt_descCategory.mensaje = null;
            this.swt_descCategory.Name = "swt_descCategory";
            this.swt_descCategory.nomCamp = "DescCategory";
            this.swt_descCategory.nomComboBox = null;
            this.swt_descCategory.requerit = false;
            this.swt_descCategory.Size = new System.Drawing.Size(194, 32);
            this.swt_descCategory.TabIndex = 75;
            this.swt_descCategory.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_accessLevel
            // 
            this.swt_accessLevel.ControlID = null;
            this.swt_accessLevel.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_accessLevel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_accessLevel.foranea = false;
            this.swt_accessLevel.ForeColor = System.Drawing.Color.DimGray;
            this.swt_accessLevel.Location = new System.Drawing.Point(263, 169);
            this.swt_accessLevel.mensaje = null;
            this.swt_accessLevel.Name = "swt_accessLevel";
            this.swt_accessLevel.nomCamp = "AccessLevel";
            this.swt_accessLevel.nomComboBox = null;
            this.swt_accessLevel.requerit = false;
            this.swt_accessLevel.Size = new System.Drawing.Size(194, 32);
            this.swt_accessLevel.TabIndex = 76;
            this.swt_accessLevel.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // btn_actualizarDataset
            // 
            this.btn_actualizarDataset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_actualizarDataset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_actualizarDataset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizarDataset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarDataset.ForeColor = System.Drawing.Color.White;
            this.btn_actualizarDataset.Location = new System.Drawing.Point(24, 333);
            this.btn_actualizarDataset.Name = "btn_actualizarDataset";
            this.btn_actualizarDataset.Size = new System.Drawing.Size(117, 29);
            this.btn_actualizarDataset.TabIndex = 79;
            this.btn_actualizarDataset.Text = "Actualizar";
            this.btn_actualizarDataset.UseVisualStyleBackColor = false;
            this.btn_actualizarDataset.Click += new System.EventHandler(this.btn_actualizarDataset_Click);
            // 
            // btn_insertar
            // 
            this.btn_insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_insertar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insertar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertar.ForeColor = System.Drawing.Color.White;
            this.btn_insertar.Location = new System.Drawing.Point(168, 333);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(117, 29);
            this.btn_insertar.TabIndex = 80;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = false;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 442);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(907, 278);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // MantenimientoUserCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(907, 720);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.btn_actualizarDataset);
            this.Controls.Add(this.swt_accessLevel);
            this.Controls.Add(this.swt_descCategory);
            this.Controls.Add(this.swt_codeCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_codeSpecie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenimientoUserCategories";
            this.Text = "MantenimientoUserCategories";
            this.Load += new System.EventHandler(this.MantenimientoUserCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_codeSpecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CC_Library.SWTextbox swt_codeCategory;
        private CC_Library.SWTextbox swt_descCategory;
        private CC_Library.SWTextbox swt_accessLevel;
        private System.Windows.Forms.Button btn_actualizarDataset;
        private System.Windows.Forms.Button btn_insertar;
        protected System.Windows.Forms.DataGridView dataGridView1;
    }
}
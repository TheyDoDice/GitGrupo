namespace HT_ProgramStrings_Editor
{
    partial class HT_ProgramStrings_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HT_ProgramStrings_Editor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_DeleteRow = new System.Windows.Forms.Button();
            this.btn_AddToFile = new System.Windows.Forms.Button();
            this.txtb_Catalan = new System.Windows.Forms.TextBox();
            this.lbl_Catalan = new System.Windows.Forms.Label();
            this.txtb_Spanish = new System.Windows.Forms.TextBox();
            this.lbl_Español = new System.Windows.Forms.Label();
            this.txtb_English = new System.Windows.Forms.TextBox();
            this.lbl_english = new System.Windows.Forms.Label();
            this.lbl_HashcodesComboBox = new System.Windows.Forms.Label();
            this.cbx_HashCodesList = new System.Windows.Forms.ComboBox();
            this.DGV_ProgramStrings = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ProgramStrings)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_DeleteRow);
            this.groupBox1.Controls.Add(this.btn_AddToFile);
            this.groupBox1.Controls.Add(this.txtb_Catalan);
            this.groupBox1.Controls.Add(this.lbl_Catalan);
            this.groupBox1.Controls.Add(this.txtb_Spanish);
            this.groupBox1.Controls.Add(this.lbl_Español);
            this.groupBox1.Controls.Add(this.txtb_English);
            this.groupBox1.Controls.Add(this.lbl_english);
            this.groupBox1.Controls.Add(this.lbl_HashcodesComboBox);
            this.groupBox1.Controls.Add(this.cbx_HashCodesList);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_DeleteRow
            // 
            this.btn_DeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteRow.Location = new System.Drawing.Point(669, 17);
            this.btn_DeleteRow.Name = "btn_DeleteRow";
            this.btn_DeleteRow.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteRow.TabIndex = 9;
            this.btn_DeleteRow.Text = "Eliminar";
            this.btn_DeleteRow.UseVisualStyleBackColor = true;
            this.btn_DeleteRow.Click += new System.EventHandler(this.btn_DeleteRow_Click);
            // 
            // btn_AddToFile
            // 
            this.btn_AddToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddToFile.Location = new System.Drawing.Point(588, 17);
            this.btn_AddToFile.Name = "btn_AddToFile";
            this.btn_AddToFile.Size = new System.Drawing.Size(75, 23);
            this.btn_AddToFile.TabIndex = 8;
            this.btn_AddToFile.Text = "Añadir";
            this.btn_AddToFile.UseVisualStyleBackColor = true;
            this.btn_AddToFile.Click += new System.EventHandler(this.btn_AddToFile_Click);
            // 
            // txtb_Catalan
            // 
            this.txtb_Catalan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_Catalan.Location = new System.Drawing.Point(10, 153);
            this.txtb_Catalan.Name = "txtb_Catalan";
            this.txtb_Catalan.Size = new System.Drawing.Size(734, 20);
            this.txtb_Catalan.TabIndex = 7;
            // 
            // lbl_Catalan
            // 
            this.lbl_Catalan.AutoSize = true;
            this.lbl_Catalan.Location = new System.Drawing.Point(9, 137);
            this.lbl_Catalan.Name = "lbl_Catalan";
            this.lbl_Catalan.Size = new System.Drawing.Size(46, 13);
            this.lbl_Catalan.TabIndex = 6;
            this.lbl_Catalan.Text = "Catalán:";
            // 
            // txtb_Spanish
            // 
            this.txtb_Spanish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_Spanish.Location = new System.Drawing.Point(10, 114);
            this.txtb_Spanish.Name = "txtb_Spanish";
            this.txtb_Spanish.Size = new System.Drawing.Size(734, 20);
            this.txtb_Spanish.TabIndex = 5;
            // 
            // lbl_Español
            // 
            this.lbl_Español.AutoSize = true;
            this.lbl_Español.Location = new System.Drawing.Point(9, 98);
            this.lbl_Español.Name = "lbl_Español";
            this.lbl_Español.Size = new System.Drawing.Size(48, 13);
            this.lbl_Español.TabIndex = 4;
            this.lbl_Español.Text = "Español:";
            // 
            // txtb_English
            // 
            this.txtb_English.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_English.Location = new System.Drawing.Point(10, 75);
            this.txtb_English.Name = "txtb_English";
            this.txtb_English.Size = new System.Drawing.Size(734, 20);
            this.txtb_English.TabIndex = 3;
            // 
            // lbl_english
            // 
            this.lbl_english.AutoSize = true;
            this.lbl_english.Location = new System.Drawing.Point(7, 59);
            this.lbl_english.Name = "lbl_english";
            this.lbl_english.Size = new System.Drawing.Size(38, 13);
            this.lbl_english.TabIndex = 2;
            this.lbl_english.Text = "Inglés:";
            // 
            // lbl_HashcodesComboBox
            // 
            this.lbl_HashcodesComboBox.AutoSize = true;
            this.lbl_HashcodesComboBox.Location = new System.Drawing.Point(7, 20);
            this.lbl_HashcodesComboBox.Name = "lbl_HashcodesComboBox";
            this.lbl_HashcodesComboBox.Size = new System.Drawing.Size(59, 13);
            this.lbl_HashcodesComboBox.TabIndex = 1;
            this.lbl_HashcodesComboBox.Text = "Hashcode:";
            // 
            // cbx_HashCodesList
            // 
            this.cbx_HashCodesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_HashCodesList.FormattingEnabled = true;
            this.cbx_HashCodesList.Location = new System.Drawing.Point(72, 17);
            this.cbx_HashCodesList.Name = "cbx_HashCodesList";
            this.cbx_HashCodesList.Size = new System.Drawing.Size(327, 21);
            this.cbx_HashCodesList.TabIndex = 0;
            // 
            // DGV_ProgramStrings
            // 
            this.DGV_ProgramStrings.AllowUserToAddRows = false;
            this.DGV_ProgramStrings.AllowUserToDeleteRows = false;
            this.DGV_ProgramStrings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_ProgramStrings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ProgramStrings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ProgramStrings.Location = new System.Drawing.Point(10, 19);
            this.DGV_ProgramStrings.MultiSelect = false;
            this.DGV_ProgramStrings.Name = "DGV_ProgramStrings";
            this.DGV_ProgramStrings.ReadOnly = true;
            this.DGV_ProgramStrings.RowHeadersVisible = false;
            this.DGV_ProgramStrings.Size = new System.Drawing.Size(734, 272);
            this.DGV_ProgramStrings.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btn_guardar);
            this.groupBox3.Controls.Add(this.DGV_ProgramStrings);
            this.groupBox3.Location = new System.Drawing.Point(14, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 323);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.Location = new System.Drawing.Point(669, 294);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // HT_ProgramStrings_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HT_ProgramStrings_Editor";
            this.Text = "HT ProgramStrings Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ProgramStrings)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddToFile;
        private System.Windows.Forms.TextBox txtb_Catalan;
        private System.Windows.Forms.Label lbl_Catalan;
        private System.Windows.Forms.TextBox txtb_Spanish;
        private System.Windows.Forms.Label lbl_Español;
        private System.Windows.Forms.TextBox txtb_English;
        private System.Windows.Forms.Label lbl_english;
        private System.Windows.Forms.Label lbl_HashcodesComboBox;
        private System.Windows.Forms.ComboBox cbx_HashCodesList;
        private System.Windows.Forms.DataGridView DGV_ProgramStrings;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_DeleteRow;
        private System.Windows.Forms.Button btn_guardar;
    }
}


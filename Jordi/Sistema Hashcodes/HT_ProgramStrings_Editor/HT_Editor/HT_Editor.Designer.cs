namespace HT_Editor
{
    partial class HT_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HT_Editor));
            this.VisorHashcodes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_hashSection = new System.Windows.Forms.Label();
            this.cbx_sections = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtb_HashcodeName = new System.Windows.Forms.TextBox();
            this.lbl_LabelName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_deleteSection = new System.Windows.Forms.Button();
            this.cbx_sections_delete = new System.Windows.Forms.ComboBox();
            this.lbl_sectionDelete = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cbx_HashCodesList = new System.Windows.Forms.ComboBox();
            this.lbl_hashcode = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_AñadirSeccion = new System.Windows.Forms.Button();
            this.txtb_SectionName = new System.Windows.Forms.TextBox();
            this.lbl_prefixSection = new System.Windows.Forms.Label();
            this.lbl_SectionName = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VisorHashcodes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // VisorHashcodes
            // 
            this.VisorHashcodes.AllowUserToAddRows = false;
            this.VisorHashcodes.AllowUserToDeleteRows = false;
            this.VisorHashcodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VisorHashcodes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VisorHashcodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisorHashcodes.Location = new System.Drawing.Point(11, 198);
            this.VisorHashcodes.Name = "VisorHashcodes";
            this.VisorHashcodes.ReadOnly = true;
            this.VisorHashcodes.RowHeadersVisible = false;
            this.VisorHashcodes.Size = new System.Drawing.Size(744, 315);
            this.VisorHashcodes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lbl_hashSection);
            this.groupBox2.Controls.Add(this.cbx_sections);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.txtb_HashcodeName);
            this.groupBox2.Controls.Add(this.lbl_LabelName);
            this.groupBox2.Location = new System.Drawing.Point(12, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 50);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Añadir Hashcode";
            // 
            // lbl_hashSection
            // 
            this.lbl_hashSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hashSection.AutoSize = true;
            this.lbl_hashSection.Location = new System.Drawing.Point(389, 16);
            this.lbl_hashSection.Name = "lbl_hashSection";
            this.lbl_hashSection.Size = new System.Drawing.Size(49, 13);
            this.lbl_hashSection.TabIndex = 5;
            this.lbl_hashSection.Text = "Sección:";
            // 
            // cbx_sections
            // 
            this.cbx_sections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_sections.FormattingEnabled = true;
            this.cbx_sections.Location = new System.Drawing.Point(444, 13);
            this.cbx_sections.Name = "cbx_sections";
            this.cbx_sections.Size = new System.Drawing.Size(205, 21);
            this.cbx_sections.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(657, 11);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Añadir";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtb_HashcodeName
            // 
            this.txtb_HashcodeName.Location = new System.Drawing.Point(70, 13);
            this.txtb_HashcodeName.MaxLength = 70;
            this.txtb_HashcodeName.Name = "txtb_HashcodeName";
            this.txtb_HashcodeName.Size = new System.Drawing.Size(310, 20);
            this.txtb_HashcodeName.TabIndex = 1;
            // 
            // lbl_LabelName
            // 
            this.lbl_LabelName.AutoSize = true;
            this.lbl_LabelName.Location = new System.Drawing.Point(5, 16);
            this.lbl_LabelName.Name = "lbl_LabelName";
            this.lbl_LabelName.Size = new System.Drawing.Size(47, 13);
            this.lbl_LabelName.TabIndex = 0;
            this.lbl_LabelName.Text = "Nombre:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btn_deleteSection);
            this.groupBox3.Controls.Add(this.cbx_sections_delete);
            this.groupBox3.Controls.Add(this.lbl_sectionDelete);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.cbx_HashCodesList);
            this.groupBox3.Controls.Add(this.lbl_hashcode);
            this.groupBox3.Location = new System.Drawing.Point(11, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(744, 74);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // btn_deleteSection
            // 
            this.btn_deleteSection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteSection.Location = new System.Drawing.Point(658, 39);
            this.btn_deleteSection.Name = "btn_deleteSection";
            this.btn_deleteSection.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteSection.TabIndex = 7;
            this.btn_deleteSection.Text = "Eliminar";
            this.btn_deleteSection.UseVisualStyleBackColor = true;
            this.btn_deleteSection.Click += new System.EventHandler(this.btn_deleteSection_Click);
            // 
            // cbx_sections_delete
            // 
            this.cbx_sections_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_sections_delete.FormattingEnabled = true;
            this.cbx_sections_delete.Location = new System.Drawing.Point(71, 41);
            this.cbx_sections_delete.Name = "cbx_sections_delete";
            this.cbx_sections_delete.Size = new System.Drawing.Size(581, 21);
            this.cbx_sections_delete.TabIndex = 6;
            // 
            // lbl_sectionDelete
            // 
            this.lbl_sectionDelete.AutoSize = true;
            this.lbl_sectionDelete.Location = new System.Drawing.Point(19, 44);
            this.lbl_sectionDelete.Name = "lbl_sectionDelete";
            this.lbl_sectionDelete.Size = new System.Drawing.Size(46, 13);
            this.lbl_sectionDelete.TabIndex = 6;
            this.lbl_sectionDelete.Text = "Section:";
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Location = new System.Drawing.Point(657, 13);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cbx_HashCodesList
            // 
            this.cbx_HashCodesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_HashCodesList.FormattingEnabled = true;
            this.cbx_HashCodesList.Location = new System.Drawing.Point(71, 13);
            this.cbx_HashCodesList.Name = "cbx_HashCodesList";
            this.cbx_HashCodesList.Size = new System.Drawing.Size(579, 21);
            this.cbx_HashCodesList.TabIndex = 4;
            // 
            // lbl_hashcode
            // 
            this.lbl_hashcode.AutoSize = true;
            this.lbl_hashcode.Location = new System.Drawing.Point(6, 16);
            this.lbl_hashcode.Name = "lbl_hashcode";
            this.lbl_hashcode.Size = new System.Drawing.Size(59, 13);
            this.lbl_hashcode.TabIndex = 3;
            this.lbl_hashcode.Text = "Hashcode:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btn_AñadirSeccion);
            this.groupBox4.Controls.Add(this.txtb_SectionName);
            this.groupBox4.Controls.Add(this.lbl_prefixSection);
            this.groupBox4.Controls.Add(this.lbl_SectionName);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(743, 44);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Añadir Sección";
            // 
            // btn_AñadirSeccion
            // 
            this.btn_AñadirSeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AñadirSeccion.Location = new System.Drawing.Point(654, 11);
            this.btn_AñadirSeccion.Name = "btn_AñadirSeccion";
            this.btn_AñadirSeccion.Size = new System.Drawing.Size(75, 23);
            this.btn_AñadirSeccion.TabIndex = 3;
            this.btn_AñadirSeccion.Text = "Añadir";
            this.btn_AñadirSeccion.UseVisualStyleBackColor = true;
            this.btn_AñadirSeccion.Click += new System.EventHandler(this.btn_AñadirSeccion_Click);
            // 
            // txtb_SectionName
            // 
            this.txtb_SectionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_SectionName.Location = new System.Drawing.Point(114, 13);
            this.txtb_SectionName.Name = "txtb_SectionName";
            this.txtb_SectionName.Size = new System.Drawing.Size(532, 20);
            this.txtb_SectionName.TabIndex = 2;
            // 
            // lbl_prefixSection
            // 
            this.lbl_prefixSection.AutoSize = true;
            this.lbl_prefixSection.Location = new System.Drawing.Point(59, 16);
            this.lbl_prefixSection.Name = "lbl_prefixSection";
            this.lbl_prefixSection.Size = new System.Drawing.Size(49, 13);
            this.lbl_prefixSection.TabIndex = 1;
            this.lbl_prefixSection.Tag = "";
            this.lbl_prefixSection.Text = "Section_";
            // 
            // lbl_SectionName
            // 
            this.lbl_SectionName.AutoSize = true;
            this.lbl_SectionName.Location = new System.Drawing.Point(6, 16);
            this.lbl_SectionName.Name = "lbl_SectionName";
            this.lbl_SectionName.Size = new System.Drawing.Size(47, 13);
            this.lbl_SectionName.TabIndex = 0;
            this.lbl_SectionName.Text = "Nombre:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.Location = new System.Drawing.Point(680, 519);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // HT_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 554);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.VisorHashcodes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HT_Editor";
            this.Text = "HT Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisorHashcodes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VisorHashcodes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtb_HashcodeName;
        private System.Windows.Forms.Label lbl_LabelName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cbx_HashCodesList;
        private System.Windows.Forms.Label lbl_hashcode;
        private System.Windows.Forms.Label lbl_hashSection;
        private System.Windows.Forms.ComboBox cbx_sections;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_AñadirSeccion;
        private System.Windows.Forms.TextBox txtb_SectionName;
        private System.Windows.Forms.Label lbl_prefixSection;
        private System.Windows.Forms.Label lbl_SectionName;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_deleteSection;
        private System.Windows.Forms.ComboBox cbx_sections_delete;
        private System.Windows.Forms.Label lbl_sectionDelete;
    }
}


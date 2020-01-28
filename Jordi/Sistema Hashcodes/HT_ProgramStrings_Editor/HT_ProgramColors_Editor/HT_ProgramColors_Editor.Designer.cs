namespace HT_ProgramColors_Editor
{
    partial class HT_ProgramColors_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HT_ProgramColors_Editor));
            this.txtb_backcolor = new System.Windows.Forms.TextBox();
            this.lbl_BackColor = new System.Windows.Forms.Label();
            this.lbl_ForeColor = new System.Windows.Forms.Label();
            this.btn_Añadir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lbl_hashcodes = new System.Windows.Forms.Label();
            this.txtb_forecolor = new System.Windows.Forms.TextBox();
            this.ListaHashcodes = new System.Windows.Forms.ListBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_backcolor
            // 
            this.txtb_backcolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtb_backcolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtb_backcolor.Location = new System.Drawing.Point(36, 397);
            this.txtb_backcolor.Name = "txtb_backcolor";
            this.txtb_backcolor.Size = new System.Drawing.Size(162, 20);
            this.txtb_backcolor.TabIndex = 1;
            this.txtb_backcolor.Click += new System.EventHandler(this.txtb_backcolor_Click);
            // 
            // lbl_BackColor
            // 
            this.lbl_BackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_BackColor.AutoSize = true;
            this.lbl_BackColor.Location = new System.Drawing.Point(33, 378);
            this.lbl_BackColor.Name = "lbl_BackColor";
            this.lbl_BackColor.Size = new System.Drawing.Size(62, 13);
            this.lbl_BackColor.TabIndex = 5;
            this.lbl_BackColor.Text = "Back Color:";
            // 
            // lbl_ForeColor
            // 
            this.lbl_ForeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ForeColor.AutoSize = true;
            this.lbl_ForeColor.Location = new System.Drawing.Point(247, 378);
            this.lbl_ForeColor.Name = "lbl_ForeColor";
            this.lbl_ForeColor.Size = new System.Drawing.Size(58, 13);
            this.lbl_ForeColor.TabIndex = 6;
            this.lbl_ForeColor.Text = "Fore Color:";
            // 
            // btn_Añadir
            // 
            this.btn_Añadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Añadir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Añadir.Location = new System.Drawing.Point(186, 441);
            this.btn_Añadir.Name = "btn_Añadir";
            this.btn_Añadir.Size = new System.Drawing.Size(75, 23);
            this.btn_Añadir.TabIndex = 7;
            this.btn_Añadir.Text = "Añadir";
            this.btn_Añadir.UseVisualStyleBackColor = true;
            this.btn_Añadir.Click += new System.EventHandler(this.btn_Añadir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.Location = new System.Drawing.Point(267, 441);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // lbl_hashcodes
            // 
            this.lbl_hashcodes.AutoSize = true;
            this.lbl_hashcodes.Location = new System.Drawing.Point(33, 9);
            this.lbl_hashcodes.Name = "lbl_hashcodes";
            this.lbl_hashcodes.Size = new System.Drawing.Size(64, 13);
            this.lbl_hashcodes.TabIndex = 9;
            this.lbl_hashcodes.Text = "Hashcodes:";
            // 
            // txtb_forecolor
            // 
            this.txtb_forecolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtb_forecolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtb_forecolor.Location = new System.Drawing.Point(250, 398);
            this.txtb_forecolor.Name = "txtb_forecolor";
            this.txtb_forecolor.Size = new System.Drawing.Size(173, 20);
            this.txtb_forecolor.TabIndex = 10;
            this.txtb_forecolor.Click += new System.EventHandler(this.txtb_forecolor_Click);
            // 
            // ListaHashcodes
            // 
            this.ListaHashcodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaHashcodes.FormattingEnabled = true;
            this.ListaHashcodes.Location = new System.Drawing.Point(36, 32);
            this.ListaHashcodes.Name = "ListaHashcodes";
            this.ListaHashcodes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListaHashcodes.Size = new System.Drawing.Size(387, 342);
            this.ListaHashcodes.TabIndex = 11;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.Location = new System.Drawing.Point(348, 441);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 12;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // HT_ProgramColors_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(455, 476);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.ListaHashcodes);
            this.Controls.Add(this.txtb_forecolor);
            this.Controls.Add(this.lbl_hashcodes);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_Añadir);
            this.Controls.Add(this.lbl_ForeColor);
            this.Controls.Add(this.lbl_BackColor);
            this.Controls.Add(this.txtb_backcolor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HT_ProgramColors_Editor";
            this.Text = "HT Program Colors Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtb_backcolor;
        private System.Windows.Forms.Label lbl_BackColor;
        private System.Windows.Forms.Label lbl_ForeColor;
        private System.Windows.Forms.Button btn_Añadir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lbl_hashcodes;
        private System.Windows.Forms.TextBox txtb_forecolor;
        private System.Windows.Forms.ListBox ListaHashcodes;
        private System.Windows.Forms.Button btn_guardar;
    }
}


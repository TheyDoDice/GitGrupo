namespace FormsMantemimiento
{
    partial class MantenimientoSpecies
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
            this.lb_codeSpecie = new System.Windows.Forms.Label();
            this.lbl_DescSpecie = new System.Windows.Forms.Label();
            this.swt_userName = new CC_Library.SWTextbox();
            this.swt_codeSpecie = new CC_Library.SWTextbox();
            this.SuspendLayout();
            // 
            // btn_actualizarDataset
            // 
            this.btn_actualizarDataset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            // 
            // btn_insertar
            // 
            this.btn_insertar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            // 
            // lb_codeSpecie
            // 
            this.lb_codeSpecie.AutoSize = true;
            this.lb_codeSpecie.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_codeSpecie.ForeColor = System.Drawing.Color.White;
            this.lb_codeSpecie.Location = new System.Drawing.Point(25, 44);
            this.lb_codeSpecie.Name = "lb_codeSpecie";
            this.lb_codeSpecie.Size = new System.Drawing.Size(117, 24);
            this.lb_codeSpecie.TabIndex = 70;
            this.lb_codeSpecie.Text = "Code Specie:";
            // 
            // lbl_DescSpecie
            // 
            this.lbl_DescSpecie.AutoSize = true;
            this.lbl_DescSpecie.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_DescSpecie.ForeColor = System.Drawing.Color.White;
            this.lbl_DescSpecie.Location = new System.Drawing.Point(26, 103);
            this.lbl_DescSpecie.Name = "lbl_DescSpecie";
            this.lbl_DescSpecie.Size = new System.Drawing.Size(170, 24);
            this.lbl_DescSpecie.TabIndex = 79;
            this.lbl_DescSpecie.Text = "Description Specie:";
            // 
            // swt_userName
            // 
            this.swt_userName.ControlID = null;
            this.swt_userName.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_userName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_userName.foranea = false;
            this.swt_userName.ForeColor = System.Drawing.Color.DimGray;
            this.swt_userName.Location = new System.Drawing.Point(221, 95);
            this.swt_userName.mensaje = null;
            this.swt_userName.Name = "swt_userName";
            this.swt_userName.nomCamp = "DescSpecie";
            this.swt_userName.nomComboBox = null;
            this.swt_userName.requerit = false;
            this.swt_userName.Size = new System.Drawing.Size(193, 32);
            this.swt_userName.TabIndex = 73;
            this.swt_userName.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_codeSpecie
            // 
            this.swt_codeSpecie.ControlID = null;
            this.swt_codeSpecie.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_codeSpecie.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_codeSpecie.foranea = false;
            this.swt_codeSpecie.ForeColor = System.Drawing.Color.DimGray;
            this.swt_codeSpecie.Location = new System.Drawing.Point(220, 36);
            this.swt_codeSpecie.mensaje = null;
            this.swt_codeSpecie.Name = "swt_codeSpecie";
            this.swt_codeSpecie.nomCamp = "CodeSpecie";
            this.swt_codeSpecie.nomComboBox = null;
            this.swt_codeSpecie.requerit = false;
            this.swt_codeSpecie.Size = new System.Drawing.Size(194, 32);
            this.swt_codeSpecie.TabIndex = 69;
            this.swt_codeSpecie.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // MantenimientoSpecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(967, 783);
            this.Controls.Add(this.lb_codeSpecie);
            this.Controls.Add(this.lbl_DescSpecie);
            this.Controls.Add(this.swt_userName);
            this.Controls.Add(this.swt_codeSpecie);
            this.Name = "MantenimientoSpecies";
            this.tabla = "Species";
            this.Controls.SetChildIndex(this.btn_insertar, 0);
            this.Controls.SetChildIndex(this.btn_actualizarDataset, 0);
            this.Controls.SetChildIndex(this.swt_codeSpecie, 0);
            this.Controls.SetChildIndex(this.swt_userName, 0);
            this.Controls.SetChildIndex(this.lbl_DescSpecie, 0);
            this.Controls.SetChildIndex(this.lb_codeSpecie, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_codeSpecie;
        private System.Windows.Forms.Label lbl_DescSpecie;
        private CC_Library.SWTextbox swt_userName;
        private CC_Library.SWTextbox swt_codeSpecie;
    }
}

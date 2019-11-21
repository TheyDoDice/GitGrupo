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
            this.lb_codeSpecie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.swt_codeSpecie = new CC_Library.SWTextbox();
            this.swTextbox1 = new CC_Library.SWTextbox();
            this.swTextbox2 = new CC_Library.SWTextbox();
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
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 73;
            this.label2.Text = "Access Level";
            // 
            // swt_codeSpecie
            // 
            this.swt_codeSpecie.ControlID = null;
            this.swt_codeSpecie.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_codeSpecie.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_codeSpecie.foranea = false;
            this.swt_codeSpecie.ForeColor = System.Drawing.Color.DimGray;
            this.swt_codeSpecie.Location = new System.Drawing.Point(263, 57);
            this.swt_codeSpecie.mensaje = null;
            this.swt_codeSpecie.Name = "swt_codeSpecie";
            this.swt_codeSpecie.nomCamp = "CodeSpecie";
            this.swt_codeSpecie.nomComboBox = null;
            this.swt_codeSpecie.requerit = false;
            this.swt_codeSpecie.Size = new System.Drawing.Size(194, 32);
            this.swt_codeSpecie.TabIndex = 74;
            this.swt_codeSpecie.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swTextbox1
            // 
            this.swTextbox1.ControlID = null;
            this.swTextbox1.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swTextbox1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swTextbox1.foranea = false;
            this.swTextbox1.ForeColor = System.Drawing.Color.DimGray;
            this.swTextbox1.Location = new System.Drawing.Point(263, 112);
            this.swTextbox1.mensaje = null;
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.nomCamp = "CodeSpecie";
            this.swTextbox1.nomComboBox = null;
            this.swTextbox1.requerit = false;
            this.swTextbox1.Size = new System.Drawing.Size(194, 32);
            this.swTextbox1.TabIndex = 75;
            this.swTextbox1.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swTextbox2
            // 
            this.swTextbox2.ControlID = null;
            this.swTextbox2.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swTextbox2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swTextbox2.foranea = false;
            this.swTextbox2.ForeColor = System.Drawing.Color.DimGray;
            this.swTextbox2.Location = new System.Drawing.Point(263, 169);
            this.swTextbox2.mensaje = null;
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.nomCamp = "CodeSpecie";
            this.swTextbox2.nomComboBox = null;
            this.swTextbox2.requerit = false;
            this.swTextbox2.Size = new System.Drawing.Size(194, 32);
            this.swTextbox2.TabIndex = 76;
            this.swTextbox2.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // MantenimientoUserCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.swt_codeSpecie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_codeSpecie);
            this.Name = "MantenimientoUserCategories";
            this.Text = "MantenimientoUserCategories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_codeSpecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CC_Library.SWTextbox swt_codeSpecie;
        private CC_Library.SWTextbox swTextbox1;
        private CC_Library.SWTextbox swTextbox2;
    }
}
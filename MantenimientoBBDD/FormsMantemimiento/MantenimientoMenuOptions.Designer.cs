namespace FormsMantemimiento
{
    partial class MantenimientoMenuOptions : MantenimientoBBDD.MantenimientoGenerico
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
            this.lb_nameSpace = new System.Windows.Forms.Label();
            this.lb_nomClase = new System.Windows.Forms.Label();
            this.lb_rangMin = new System.Windows.Forms.Label();
            this.lb_text = new System.Windows.Forms.Label();
            this.swt_nameSpace = new CC_Library.SWTextbox();
            this.swt_nomClase = new CC_Library.SWTextbox();
            this.lb_nomDLL = new System.Windows.Forms.Label();
            this.swt_nomDLL = new CC_Library.SWTextbox();
            this.swt_rangMin = new CC_Library.SWTextbox();
            this.swt_text = new CC_Library.SWTextbox();
            this.lb_picture = new System.Windows.Forms.Label();
            this.swt_picture = new CC_Library.SWTextbox();
            this.swt_nomPanel = new CC_Library.SWTextbox();
            this.lb_nomPanel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_nameSpace
            // 
            this.lb_nameSpace.AutoSize = true;
            this.lb_nameSpace.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_nameSpace.ForeColor = System.Drawing.Color.White;
            this.lb_nameSpace.Location = new System.Drawing.Point(25, 36);
            this.lb_nameSpace.Name = "lb_nameSpace";
            this.lb_nameSpace.Size = new System.Drawing.Size(118, 24);
            this.lb_nameSpace.TabIndex = 49;
            this.lb_nameSpace.Text = "NameSpace: ";
            // 
            // lb_nomClase
            // 
            this.lb_nomClase.AutoSize = true;
            this.lb_nomClase.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_nomClase.ForeColor = System.Drawing.Color.White;
            this.lb_nomClase.Location = new System.Drawing.Point(25, 101);
            this.lb_nomClase.Name = "lb_nomClase";
            this.lb_nomClase.Size = new System.Drawing.Size(110, 24);
            this.lb_nomClase.TabIndex = 50;
            this.lb_nomClase.Text = "Nom Clase: ";
            // 
            // lb_rangMin
            // 
            this.lb_rangMin.AutoSize = true;
            this.lb_rangMin.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_rangMin.ForeColor = System.Drawing.Color.White;
            this.lb_rangMin.Location = new System.Drawing.Point(518, 36);
            this.lb_rangMin.Name = "lb_rangMin";
            this.lb_rangMin.Size = new System.Drawing.Size(116, 24);
            this.lb_rangMin.TabIndex = 51;
            this.lb_rangMin.Text = "Rang Minim:";
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_text.ForeColor = System.Drawing.Color.White;
            this.lb_text.Location = new System.Drawing.Point(518, 101);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(116, 24);
            this.lb_text.TabIndex = 52;
            this.lb_text.Text = "Button text: ";
            // 
            // swt_nameSpace
            // 
            this.swt_nameSpace.ControlID = null;
            this.swt_nameSpace.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_nameSpace.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_nameSpace.foranea = false;
            this.swt_nameSpace.ForeColor = System.Drawing.Color.DimGray;
            this.swt_nameSpace.Location = new System.Drawing.Point(149, 33);
            this.swt_nameSpace.mensaje = null;
            this.swt_nameSpace.Name = "swt_nameSpace";
            this.swt_nameSpace.nomCamp = "NameSpace";
            this.swt_nameSpace.nomComboBox = null;
            this.swt_nameSpace.requerit = false;
            this.swt_nameSpace.Size = new System.Drawing.Size(287, 32);
            this.swt_nameSpace.TabIndex = 53;
            this.swt_nameSpace.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_nomClase
            // 
            this.swt_nomClase.ControlID = null;
            this.swt_nomClase.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_nomClase.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_nomClase.foranea = false;
            this.swt_nomClase.ForeColor = System.Drawing.Color.DimGray;
            this.swt_nomClase.Location = new System.Drawing.Point(149, 98);
            this.swt_nomClase.mensaje = null;
            this.swt_nomClase.Name = "swt_nomClase";
            this.swt_nomClase.nomCamp = "NomClase";
            this.swt_nomClase.nomComboBox = null;
            this.swt_nomClase.requerit = false;
            this.swt_nomClase.Size = new System.Drawing.Size(287, 32);
            this.swt_nomClase.TabIndex = 55;
            this.swt_nomClase.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // lb_nomDLL
            // 
            this.lb_nomDLL.AutoSize = true;
            this.lb_nomDLL.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_nomDLL.ForeColor = System.Drawing.Color.White;
            this.lb_nomDLL.Location = new System.Drawing.Point(25, 173);
            this.lb_nomDLL.Name = "lb_nomDLL";
            this.lb_nomDLL.Size = new System.Drawing.Size(95, 24);
            this.lb_nomDLL.TabIndex = 59;
            this.lb_nomDLL.Text = "Nom DLL: ";
            // 
            // swt_nomDLL
            // 
            this.swt_nomDLL.ControlID = null;
            this.swt_nomDLL.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_nomDLL.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_nomDLL.foranea = false;
            this.swt_nomDLL.ForeColor = System.Drawing.Color.DimGray;
            this.swt_nomDLL.Location = new System.Drawing.Point(149, 170);
            this.swt_nomDLL.mensaje = null;
            this.swt_nomDLL.Name = "swt_nomDLL";
            this.swt_nomDLL.nomCamp = "NomDLL";
            this.swt_nomDLL.nomComboBox = null;
            this.swt_nomDLL.requerit = false;
            this.swt_nomDLL.Size = new System.Drawing.Size(287, 32);
            this.swt_nomDLL.TabIndex = 61;
            this.swt_nomDLL.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_rangMin
            // 
            this.swt_rangMin.ControlID = null;
            this.swt_rangMin.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_rangMin.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_rangMin.foranea = false;
            this.swt_rangMin.ForeColor = System.Drawing.Color.DimGray;
            this.swt_rangMin.Location = new System.Drawing.Point(651, 33);
            this.swt_rangMin.mensaje = null;
            this.swt_rangMin.Name = "swt_rangMin";
            this.swt_rangMin.nomCamp = "RangMin";
            this.swt_rangMin.nomComboBox = null;
            this.swt_rangMin.requerit = false;
            this.swt_rangMin.Size = new System.Drawing.Size(199, 32);
            this.swt_rangMin.TabIndex = 62;
            this.swt_rangMin.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_text
            // 
            this.swt_text.ControlID = null;
            this.swt_text.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_text.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_text.foranea = false;
            this.swt_text.ForeColor = System.Drawing.Color.DimGray;
            this.swt_text.Location = new System.Drawing.Point(651, 98);
            this.swt_text.mensaje = null;
            this.swt_text.Name = "swt_text";
            this.swt_text.nomCamp = "Text";
            this.swt_text.nomComboBox = null;
            this.swt_text.requerit = false;
            this.swt_text.Size = new System.Drawing.Size(199, 32);
            this.swt_text.TabIndex = 63;
            this.swt_text.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // lb_picture
            // 
            this.lb_picture.AutoSize = true;
            this.lb_picture.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_picture.ForeColor = System.Drawing.Color.White;
            this.lb_picture.Location = new System.Drawing.Point(554, 168);
            this.lb_picture.Name = "lb_picture";
            this.lb_picture.Size = new System.Drawing.Size(80, 24);
            this.lb_picture.TabIndex = 64;
            this.lb_picture.Text = "Picture: ";
            // 
            // swt_picture
            // 
            this.swt_picture.ControlID = null;
            this.swt_picture.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_picture.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_picture.foranea = false;
            this.swt_picture.ForeColor = System.Drawing.Color.DimGray;
            this.swt_picture.Location = new System.Drawing.Point(651, 165);
            this.swt_picture.mensaje = null;
            this.swt_picture.Name = "swt_picture";
            this.swt_picture.nomCamp = "Picture";
            this.swt_picture.nomComboBox = null;
            this.swt_picture.requerit = false;
            this.swt_picture.Size = new System.Drawing.Size(199, 32);
            this.swt_picture.TabIndex = 65;
            this.swt_picture.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_nomPanel
            // 
            this.swt_nomPanel.ControlID = null;
            this.swt_nomPanel.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_nomPanel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_nomPanel.foranea = false;
            this.swt_nomPanel.ForeColor = System.Drawing.Color.DimGray;
            this.swt_nomPanel.Location = new System.Drawing.Point(149, 243);
            this.swt_nomPanel.mensaje = null;
            this.swt_nomPanel.Name = "swt_nomPanel";
            this.swt_nomPanel.nomCamp = "NomPanel";
            this.swt_nomPanel.nomComboBox = null;
            this.swt_nomPanel.requerit = false;
            this.swt_nomPanel.Size = new System.Drawing.Size(287, 32);
            this.swt_nomPanel.TabIndex = 67;
            this.swt_nomPanel.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // lb_nomPanel
            // 
            this.lb_nomPanel.AutoSize = true;
            this.lb_nomPanel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_nomPanel.ForeColor = System.Drawing.Color.White;
            this.lb_nomPanel.Location = new System.Drawing.Point(25, 246);
            this.lb_nomPanel.Name = "lb_nomPanel";
            this.lb_nomPanel.Size = new System.Drawing.Size(113, 24);
            this.lb_nomPanel.TabIndex = 66;
            this.lb_nomPanel.Text = "Nom Panel: ";
            // 
            // MantenimientoMenuOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 769);
            this.Controls.Add(this.swt_nomPanel);
            this.Controls.Add(this.lb_nomPanel);
            this.Controls.Add(this.swt_picture);
            this.Controls.Add(this.lb_picture);
            this.Controls.Add(this.swt_text);
            this.Controls.Add(this.swt_rangMin);
            this.Controls.Add(this.swt_nomDLL);
            this.Controls.Add(this.lb_nomDLL);
            this.Controls.Add(this.swt_nomClase);
            this.Controls.Add(this.swt_nameSpace);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.lb_rangMin);
            this.Controls.Add(this.lb_nomClase);
            this.Controls.Add(this.lb_nameSpace);
            this.Name = "MantenimientoMenuOptions";
            this.tabla = "MenuOptions";
            this.Text = "MantenimientoMenuOptions";
            this.Load += new System.EventHandler(this.MantenimientoMenuOptions_Load);
            this.Controls.SetChildIndex(this.lb_nameSpace, 0);
            this.Controls.SetChildIndex(this.lb_nomClase, 0);
            this.Controls.SetChildIndex(this.lb_rangMin, 0);
            this.Controls.SetChildIndex(this.lb_text, 0);
            this.Controls.SetChildIndex(this.swt_nameSpace, 0);
            this.Controls.SetChildIndex(this.swt_nomClase, 0);
            this.Controls.SetChildIndex(this.lb_nomDLL, 0);
            this.Controls.SetChildIndex(this.swt_nomDLL, 0);
            this.Controls.SetChildIndex(this.swt_rangMin, 0);
            this.Controls.SetChildIndex(this.swt_text, 0);
            this.Controls.SetChildIndex(this.lb_picture, 0);
            this.Controls.SetChildIndex(this.swt_picture, 0);
            this.Controls.SetChildIndex(this.lb_nomPanel, 0);
            this.Controls.SetChildIndex(this.swt_nomPanel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nameSpace;
        private System.Windows.Forms.Label lb_nomClase;
        private System.Windows.Forms.Label lb_rangMin;
        private System.Windows.Forms.Label lb_text;
        private CC_Library.SWTextbox swt_nameSpace;
        private CC_Library.SWTextbox swt_nomClase;
        private System.Windows.Forms.Label lb_nomDLL;
        private CC_Library.SWTextbox swt_nomDLL;
        private CC_Library.SWTextbox swt_rangMin;
        private CC_Library.SWTextbox swt_text;
        private System.Windows.Forms.Label lb_picture;
        private CC_Library.SWTextbox swt_picture;
        private CC_Library.SWTextbox swt_nomPanel;
        private System.Windows.Forms.Label lb_nomPanel;
    }
}
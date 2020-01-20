namespace FormsMantemimiento
{
    partial class MantenimientoOrders
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
            this.lb_codeOrder = new System.Windows.Forms.Label();
            this.swt_codeOrder = new CC_Library.SWTextbox();
            this.lb_dateOrder = new System.Windows.Forms.Label();
            this.swt_dateOrder = new CC_Library.SWTextbox();
            this.lb_IdPriority = new System.Windows.Forms.Label();
            this.swc_IdPriority = new CC_Library.SWCodi();
            this.swt_IdPriority = new CC_Library.SWTextbox();
            this.swt_IdFactory = new CC_Library.SWTextbox();
            this.swc_IdFactory = new CC_Library.SWCodi();
            this.lbl_IdFactory = new System.Windows.Forms.Label();
            this.swt_idAgency = new CC_Library.SWTextbox();
            this.swc_idAgency = new CC_Library.SWCodi();
            this.lbl_idAgency = new System.Windows.Forms.Label();
            this.swt_idOperationalArea = new CC_Library.SWTextbox();
            this.swc_idOperationalArea = new CC_Library.SWCodi();
            this.lbl_idOperationalArea = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
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
            // lb_codeOrder
            // 
            this.lb_codeOrder.AutoSize = true;
            this.lb_codeOrder.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_codeOrder.ForeColor = System.Drawing.Color.White;
            this.lb_codeOrder.Location = new System.Drawing.Point(33, 40);
            this.lb_codeOrder.Name = "lb_codeOrder";
            this.lb_codeOrder.Size = new System.Drawing.Size(113, 24);
            this.lb_codeOrder.TabIndex = 72;
            this.lb_codeOrder.Text = "Code Order:";
            // 
            // swt_codeOrder
            // 
            this.swt_codeOrder.ControlID = null;
            this.swt_codeOrder.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_codeOrder.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_codeOrder.foranea = false;
            this.swt_codeOrder.ForeColor = System.Drawing.Color.DimGray;
            this.swt_codeOrder.Location = new System.Drawing.Point(196, 40);
            this.swt_codeOrder.mensaje = null;
            this.swt_codeOrder.Name = "swt_codeOrder";
            this.swt_codeOrder.nomCamp = "CodeOrder";
            this.swt_codeOrder.nomComboBox = null;
            this.swt_codeOrder.requerit = false;
            this.swt_codeOrder.Size = new System.Drawing.Size(194, 32);
            this.swt_codeOrder.TabIndex = 71;
            this.swt_codeOrder.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // lb_dateOrder
            // 
            this.lb_dateOrder.AutoSize = true;
            this.lb_dateOrder.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_dateOrder.ForeColor = System.Drawing.Color.White;
            this.lb_dateOrder.Location = new System.Drawing.Point(33, 90);
            this.lb_dateOrder.Name = "lb_dateOrder";
            this.lb_dateOrder.Size = new System.Drawing.Size(110, 24);
            this.lb_dateOrder.TabIndex = 74;
            this.lb_dateOrder.Text = "Date Order:";
            // 
            // swt_dateOrder
            // 
            this.swt_dateOrder.ControlID = null;
            this.swt_dateOrder.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_dateOrder.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_dateOrder.foranea = false;
            this.swt_dateOrder.ForeColor = System.Drawing.Color.DimGray;
            this.swt_dateOrder.Location = new System.Drawing.Point(196, 87);
            this.swt_dateOrder.mensaje = null;
            this.swt_dateOrder.Name = "swt_dateOrder";
            this.swt_dateOrder.nomCamp = "dateOrder";
            this.swt_dateOrder.nomComboBox = null;
            this.swt_dateOrder.requerit = false;
            this.swt_dateOrder.Size = new System.Drawing.Size(199, 32);
            this.swt_dateOrder.TabIndex = 73;
            this.swt_dateOrder.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // lb_IdPriority
            // 
            this.lb_IdPriority.AutoSize = true;
            this.lb_IdPriority.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_IdPriority.ForeColor = System.Drawing.Color.White;
            this.lb_IdPriority.Location = new System.Drawing.Point(33, 139);
            this.lb_IdPriority.Name = "lb_IdPriority";
            this.lb_IdPriority.Size = new System.Drawing.Size(78, 24);
            this.lb_IdPriority.TabIndex = 75;
            this.lb_IdPriority.Text = "Priority:";
            // 
            // swc_IdPriority
            // 
            this.swc_IdPriority.ClasseCS = null;
            this.swc_IdPriority.CodiID = null;
            this.swc_IdPriority.ControlID = "swt_IdPriority";
            this.swc_IdPriority.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swc_IdPriority.ForeColor = System.Drawing.Color.DimGray;
            this.swc_IdPriority.FormCS = null;
            this.swc_IdPriority.Location = new System.Drawing.Point(190, 128);
            this.swc_IdPriority.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.swc_IdPriority.Name = "swc_IdPriority";
            this.swc_IdPriority.NomCodi = "CodePriority";
            this.swc_IdPriority.NomDesc = "DescPriority";
            this.swc_IdPriority.NomID = "IdPriority";
            this.swc_IdPriority.NomTaula = "Priority";
            this.swc_IdPriority.Requerit = false;
            this.swc_IdPriority.Size = new System.Drawing.Size(487, 36);
            this.swc_IdPriority.TabIndex = 76;
            // 
            // swt_IdPriority
            // 
            this.swt_IdPriority.ControlID = "swc_IdPriority";
            this.swt_IdPriority.DadaTipus = CC_Library.SWTextbox.tipDades.Codi;
            this.swt_IdPriority.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_IdPriority.foranea = true;
            this.swt_IdPriority.ForeColor = System.Drawing.Color.DimGray;
            this.swt_IdPriority.Location = new System.Drawing.Point(677, 133);
            this.swt_IdPriority.mensaje = null;
            this.swt_IdPriority.Name = "swt_IdPriority";
            this.swt_IdPriority.nomCamp = "IdPriority";
            this.swt_IdPriority.nomComboBox = null;
            this.swt_IdPriority.requerit = false;
            this.swt_IdPriority.Size = new System.Drawing.Size(34, 32);
            this.swt_IdPriority.TabIndex = 77;
            this.swt_IdPriority.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_IdFactory
            // 
            this.swt_IdFactory.ControlID = "swc_IdFactory";
            this.swt_IdFactory.DadaTipus = CC_Library.SWTextbox.tipDades.Codi;
            this.swt_IdFactory.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_IdFactory.foranea = true;
            this.swt_IdFactory.ForeColor = System.Drawing.Color.DimGray;
            this.swt_IdFactory.Location = new System.Drawing.Point(677, 181);
            this.swt_IdFactory.mensaje = null;
            this.swt_IdFactory.Name = "swt_IdFactory";
            this.swt_IdFactory.nomCamp = "IdFactory";
            this.swt_IdFactory.nomComboBox = null;
            this.swt_IdFactory.requerit = false;
            this.swt_IdFactory.Size = new System.Drawing.Size(34, 32);
            this.swt_IdFactory.TabIndex = 80;
            this.swt_IdFactory.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swc_IdFactory
            // 
            this.swc_IdFactory.ClasseCS = null;
            this.swc_IdFactory.CodiID = null;
            this.swc_IdFactory.ControlID = "swt_IdFactory";
            this.swc_IdFactory.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swc_IdFactory.ForeColor = System.Drawing.Color.DimGray;
            this.swc_IdFactory.FormCS = null;
            this.swc_IdFactory.Location = new System.Drawing.Point(190, 176);
            this.swc_IdFactory.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.swc_IdFactory.Name = "swc_IdFactory";
            this.swc_IdFactory.NomCodi = "CodeFactory";
            this.swc_IdFactory.NomDesc = "DescFactory";
            this.swc_IdFactory.NomID = "IdFactory";
            this.swc_IdFactory.NomTaula = "Factories";
            this.swc_IdFactory.Requerit = false;
            this.swc_IdFactory.Size = new System.Drawing.Size(487, 36);
            this.swc_IdFactory.TabIndex = 79;
            // 
            // lbl_IdFactory
            // 
            this.lbl_IdFactory.AutoSize = true;
            this.lbl_IdFactory.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_IdFactory.ForeColor = System.Drawing.Color.White;
            this.lbl_IdFactory.Location = new System.Drawing.Point(33, 187);
            this.lbl_IdFactory.Name = "lbl_IdFactory";
            this.lbl_IdFactory.Size = new System.Drawing.Size(76, 24);
            this.lbl_IdFactory.TabIndex = 78;
            this.lbl_IdFactory.Text = "Factory:";
            // 
            // swt_idAgency
            // 
            this.swt_idAgency.ControlID = "swc_idAgency";
            this.swt_idAgency.DadaTipus = CC_Library.SWTextbox.tipDades.Codi;
            this.swt_idAgency.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_idAgency.foranea = true;
            this.swt_idAgency.ForeColor = System.Drawing.Color.DimGray;
            this.swt_idAgency.Location = new System.Drawing.Point(677, 229);
            this.swt_idAgency.mensaje = null;
            this.swt_idAgency.Name = "swt_idAgency";
            this.swt_idAgency.nomCamp = "idAgency";
            this.swt_idAgency.nomComboBox = null;
            this.swt_idAgency.requerit = false;
            this.swt_idAgency.Size = new System.Drawing.Size(34, 32);
            this.swt_idAgency.TabIndex = 83;
            this.swt_idAgency.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swc_idAgency
            // 
            this.swc_idAgency.ClasseCS = null;
            this.swc_idAgency.CodiID = null;
            this.swc_idAgency.ControlID = "swt_idAgency";
            this.swc_idAgency.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swc_idAgency.ForeColor = System.Drawing.Color.DimGray;
            this.swc_idAgency.FormCS = null;
            this.swc_idAgency.Location = new System.Drawing.Point(190, 224);
            this.swc_idAgency.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.swc_idAgency.Name = "swc_idAgency";
            this.swc_idAgency.NomCodi = "CodeAgency";
            this.swc_idAgency.NomDesc = "DescAgency";
            this.swc_idAgency.NomID = "idAgency";
            this.swc_idAgency.NomTaula = "Agencies";
            this.swc_idAgency.Requerit = false;
            this.swc_idAgency.Size = new System.Drawing.Size(487, 36);
            this.swc_idAgency.TabIndex = 82;
            // 
            // lbl_idAgency
            // 
            this.lbl_idAgency.AutoSize = true;
            this.lbl_idAgency.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_idAgency.ForeColor = System.Drawing.Color.White;
            this.lbl_idAgency.Location = new System.Drawing.Point(33, 235);
            this.lbl_idAgency.Name = "lbl_idAgency";
            this.lbl_idAgency.Size = new System.Drawing.Size(75, 24);
            this.lbl_idAgency.TabIndex = 81;
            this.lbl_idAgency.Text = "Agency:";
            // 
            // swt_idOperationalArea
            // 
            this.swt_idOperationalArea.ControlID = "swc_idOperationalArea";
            this.swt_idOperationalArea.DadaTipus = CC_Library.SWTextbox.tipDades.Codi;
            this.swt_idOperationalArea.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_idOperationalArea.foranea = true;
            this.swt_idOperationalArea.ForeColor = System.Drawing.Color.DimGray;
            this.swt_idOperationalArea.Location = new System.Drawing.Point(677, 277);
            this.swt_idOperationalArea.mensaje = null;
            this.swt_idOperationalArea.Name = "swt_idOperationalArea";
            this.swt_idOperationalArea.nomCamp = "idOperationalArea";
            this.swt_idOperationalArea.nomComboBox = null;
            this.swt_idOperationalArea.requerit = false;
            this.swt_idOperationalArea.Size = new System.Drawing.Size(34, 32);
            this.swt_idOperationalArea.TabIndex = 86;
            this.swt_idOperationalArea.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swc_idOperationalArea
            // 
            this.swc_idOperationalArea.ClasseCS = null;
            this.swc_idOperationalArea.CodiID = null;
            this.swc_idOperationalArea.ControlID = "swt_idOperationalArea";
            this.swc_idOperationalArea.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swc_idOperationalArea.ForeColor = System.Drawing.Color.DimGray;
            this.swc_idOperationalArea.FormCS = null;
            this.swc_idOperationalArea.Location = new System.Drawing.Point(190, 272);
            this.swc_idOperationalArea.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.swc_idOperationalArea.Name = "swc_idOperationalArea";
            this.swc_idOperationalArea.NomCodi = "CodeOperationalArea";
            this.swc_idOperationalArea.NomDesc = "DescOperationalArea";
            this.swc_idOperationalArea.NomID = "idOperationalArea";
            this.swc_idOperationalArea.NomTaula = "OperationalAreas";
            this.swc_idOperationalArea.Requerit = false;
            this.swc_idOperationalArea.Size = new System.Drawing.Size(487, 36);
            this.swc_idOperationalArea.TabIndex = 85;
            // 
            // lbl_idOperationalArea
            // 
            this.lbl_idOperationalArea.AutoSize = true;
            this.lbl_idOperationalArea.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_idOperationalArea.ForeColor = System.Drawing.Color.White;
            this.lbl_idOperationalArea.Location = new System.Drawing.Point(33, 283);
            this.lbl_idOperationalArea.Name = "lbl_idOperationalArea";
            this.lbl_idOperationalArea.Size = new System.Drawing.Size(161, 24);
            this.lbl_idOperationalArea.TabIndex = 84;
            this.lbl_idOperationalArea.Text = "Operational Area:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(697, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 505);
            this.panel1.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(693, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 88;
            this.label1.Text = "Details:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(678, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 553);
            this.panel2.TabIndex = 89;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.panel3.Location = new System.Drawing.Point(690, 44);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 520);
            this.panel3.TabIndex = 90;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(440, 476);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 129;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_imprimir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_imprimir.Location = new System.Drawing.Point(311, 470);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(103, 29);
            this.btn_imprimir.TabIndex = 128;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(677, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(56, 189);
            this.panel4.TabIndex = 130;
            // 
            // MantenimientoOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1552, 778);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swc_idOperationalArea);
            this.Controls.Add(this.lbl_idOperationalArea);
            this.Controls.Add(this.swc_idAgency);
            this.Controls.Add(this.lbl_idAgency);
            this.Controls.Add(this.swc_IdFactory);
            this.Controls.Add(this.lbl_IdFactory);
            this.Controls.Add(this.swc_IdPriority);
            this.Controls.Add(this.lb_IdPriority);
            this.Controls.Add(this.lb_dateOrder);
            this.Controls.Add(this.swt_dateOrder);
            this.Controls.Add(this.lb_codeOrder);
            this.Controls.Add(this.swt_codeOrder);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.swt_IdPriority);
            this.Controls.Add(this.swt_IdFactory);
            this.Controls.Add(this.swt_idAgency);
            this.Controls.Add(this.swt_idOperationalArea);
            this.Name = "MantenimientoOrders";
            this.tabla = "Orders";
            this.Load += new System.EventHandler(this.MantenimientoOrders_Load);
            this.Controls.SetChildIndex(this.swt_idOperationalArea, 0);
            this.Controls.SetChildIndex(this.swt_idAgency, 0);
            this.Controls.SetChildIndex(this.swt_IdFactory, 0);
            this.Controls.SetChildIndex(this.swt_IdPriority, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.swt_codeOrder, 0);
            this.Controls.SetChildIndex(this.lb_codeOrder, 0);
            this.Controls.SetChildIndex(this.swt_dateOrder, 0);
            this.Controls.SetChildIndex(this.lb_dateOrder, 0);
            this.Controls.SetChildIndex(this.lb_IdPriority, 0);
            this.Controls.SetChildIndex(this.swc_IdPriority, 0);
            this.Controls.SetChildIndex(this.lbl_IdFactory, 0);
            this.Controls.SetChildIndex(this.swc_IdFactory, 0);
            this.Controls.SetChildIndex(this.lbl_idAgency, 0);
            this.Controls.SetChildIndex(this.swc_idAgency, 0);
            this.Controls.SetChildIndex(this.lbl_idOperationalArea, 0);
            this.Controls.SetChildIndex(this.swc_idOperationalArea, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btn_imprimir, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.btn_insertar, 0);
            this.Controls.SetChildIndex(this.btn_actualizarDataset, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_codeOrder;
        private CC_Library.SWTextbox swt_codeOrder;
        private System.Windows.Forms.Label lb_dateOrder;
        private CC_Library.SWTextbox swt_dateOrder;
        private System.Windows.Forms.Label lb_IdPriority;
        private CC_Library.SWCodi swc_IdPriority;
        private CC_Library.SWTextbox swt_IdPriority;
        private CC_Library.SWTextbox swt_IdFactory;
        private CC_Library.SWCodi swc_IdFactory;
        private System.Windows.Forms.Label lbl_IdFactory;
        private CC_Library.SWTextbox swt_idAgency;
        private CC_Library.SWCodi swc_idAgency;
        private System.Windows.Forms.Label lbl_idAgency;
        private CC_Library.SWTextbox swt_idOperationalArea;
        private CC_Library.SWCodi swc_idOperationalArea;
        private System.Windows.Forms.Label lbl_idOperationalArea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Panel panel4;
    }
}

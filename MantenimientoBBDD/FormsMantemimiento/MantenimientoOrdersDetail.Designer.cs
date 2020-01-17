namespace FormsMantemimiento
{
    partial class MantenimientoOrdersDetail
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
            this.swt_idReference = new CC_Library.SWTextbox();
            this.swc_idReference = new CC_Library.SWCodi();
            this.lbl_idReference = new System.Windows.Forms.Label();
            this.swt_idPlanet = new CC_Library.SWTextbox();
            this.swc_idPlanet = new CC_Library.SWCodi();
            this.lbl_idPlanet = new System.Windows.Forms.Label();
            this.swt_idOrder = new CC_Library.SWTextbox();
            this.swc_idOrder = new CC_Library.SWCodi();
            this.lb_idOrder = new System.Windows.Forms.Label();
            this.lb_DeliveryDate = new System.Windows.Forms.Label();
            this.swt_DeliveryDate = new CC_Library.SWTextbox();
            this.lb_Quantity = new System.Windows.Forms.Label();
            this.swt_Quantity = new CC_Library.SWTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_actualizarDataset
            // 
            this.btn_actualizarDataset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_actualizarDataset.Location = new System.Drawing.Point(12, 262);
            // 
            // btn_insertar
            // 
            this.btn_insertar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_insertar.Location = new System.Drawing.Point(149, 262);
            // 
            // swt_idReference
            // 
            this.swt_idReference.ControlID = "swc_idReference";
            this.swt_idReference.DadaTipus = CC_Library.SWTextbox.tipDades.Codi;
            this.swt_idReference.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_idReference.foranea = true;
            this.swt_idReference.ForeColor = System.Drawing.Color.DimGray;
            this.swt_idReference.Location = new System.Drawing.Point(656, 207);
            this.swt_idReference.mensaje = null;
            this.swt_idReference.Name = "swt_idReference";
            this.swt_idReference.nomCamp = "idReference";
            this.swt_idReference.nomComboBox = null;
            this.swt_idReference.requerit = true;
            this.swt_idReference.Size = new System.Drawing.Size(34, 32);
            this.swt_idReference.TabIndex = 99;
            this.swt_idReference.TipusControl = CC_Library.SWTextbox.tipControlRef.SWCodi;
            // 
            // swc_idReference
            // 
            this.swc_idReference.ClasseCS = null;
            this.swc_idReference.CodiID = null;
            this.swc_idReference.ControlID = "swt_idReference";
            this.swc_idReference.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swc_idReference.ForeColor = System.Drawing.Color.DimGray;
            this.swc_idReference.FormCS = null;
            this.swc_idReference.Location = new System.Drawing.Point(169, 202);
            this.swc_idReference.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.swc_idReference.Name = "swc_idReference";
            this.swc_idReference.NomCodi = "CodeReference";
            this.swc_idReference.NomDesc = "DescReference";
            this.swc_idReference.NomID = "idReference";
            this.swc_idReference.NomTaula = "Referencess";
            this.swc_idReference.Requerit = true;
            this.swc_idReference.Size = new System.Drawing.Size(487, 36);
            this.swc_idReference.TabIndex = 98;
            // 
            // lbl_idReference
            // 
            this.lbl_idReference.AutoSize = true;
            this.lbl_idReference.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_idReference.ForeColor = System.Drawing.Color.White;
            this.lbl_idReference.Location = new System.Drawing.Point(12, 213);
            this.lbl_idReference.Name = "lbl_idReference";
            this.lbl_idReference.Size = new System.Drawing.Size(99, 24);
            this.lbl_idReference.TabIndex = 97;
            this.lbl_idReference.Text = "Reference:";
            // 
            // swt_idPlanet
            // 
            this.swt_idPlanet.ControlID = "swc_idPlanet";
            this.swt_idPlanet.DadaTipus = CC_Library.SWTextbox.tipDades.Codi;
            this.swt_idPlanet.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_idPlanet.foranea = true;
            this.swt_idPlanet.ForeColor = System.Drawing.Color.DimGray;
            this.swt_idPlanet.Location = new System.Drawing.Point(656, 159);
            this.swt_idPlanet.mensaje = null;
            this.swt_idPlanet.Name = "swt_idPlanet";
            this.swt_idPlanet.nomCamp = "idPlanet";
            this.swt_idPlanet.nomComboBox = null;
            this.swt_idPlanet.requerit = false;
            this.swt_idPlanet.Size = new System.Drawing.Size(34, 32);
            this.swt_idPlanet.TabIndex = 96;
            this.swt_idPlanet.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swc_idPlanet
            // 
            this.swc_idPlanet.ClasseCS = null;
            this.swc_idPlanet.CodiID = null;
            this.swc_idPlanet.ControlID = "swt_idPlanet";
            this.swc_idPlanet.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swc_idPlanet.ForeColor = System.Drawing.Color.DimGray;
            this.swc_idPlanet.FormCS = null;
            this.swc_idPlanet.Location = new System.Drawing.Point(169, 154);
            this.swc_idPlanet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.swc_idPlanet.Name = "swc_idPlanet";
            this.swc_idPlanet.NomCodi = "CodePlanet";
            this.swc_idPlanet.NomDesc = "DescPlanet";
            this.swc_idPlanet.NomID = "idPlanet";
            this.swc_idPlanet.NomTaula = "Planets";
            this.swc_idPlanet.Requerit = false;
            this.swc_idPlanet.Size = new System.Drawing.Size(487, 36);
            this.swc_idPlanet.TabIndex = 95;
            // 
            // lbl_idPlanet
            // 
            this.lbl_idPlanet.AutoSize = true;
            this.lbl_idPlanet.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_idPlanet.ForeColor = System.Drawing.Color.White;
            this.lbl_idPlanet.Location = new System.Drawing.Point(12, 165);
            this.lbl_idPlanet.Name = "lbl_idPlanet";
            this.lbl_idPlanet.Size = new System.Drawing.Size(70, 24);
            this.lbl_idPlanet.TabIndex = 94;
            this.lbl_idPlanet.Text = "Planet:";
            // 
            // swt_idOrder
            // 
            this.swt_idOrder.ControlID = "swc_idOrder";
            this.swt_idOrder.DadaTipus = CC_Library.SWTextbox.tipDades.Codi;
            this.swt_idOrder.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_idOrder.foranea = true;
            this.swt_idOrder.ForeColor = System.Drawing.Color.DimGray;
            this.swt_idOrder.Location = new System.Drawing.Point(656, 111);
            this.swt_idOrder.mensaje = null;
            this.swt_idOrder.Name = "swt_idOrder";
            this.swt_idOrder.nomCamp = "idOrder";
            this.swt_idOrder.nomComboBox = null;
            this.swt_idOrder.requerit = false;
            this.swt_idOrder.Size = new System.Drawing.Size(34, 32);
            this.swt_idOrder.TabIndex = 93;
            this.swt_idOrder.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swc_idOrder
            // 
            this.swc_idOrder.ClasseCS = null;
            this.swc_idOrder.CodiID = null;
            this.swc_idOrder.ControlID = "swt_idOrder";
            this.swc_idOrder.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swc_idOrder.ForeColor = System.Drawing.Color.DimGray;
            this.swc_idOrder.FormCS = null;
            this.swc_idOrder.Location = new System.Drawing.Point(169, 106);
            this.swc_idOrder.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.swc_idOrder.Name = "swc_idOrder";
            this.swc_idOrder.NomCodi = "CodeOrder";
            this.swc_idOrder.NomDesc = "dateOrder";
            this.swc_idOrder.NomID = "idOrder";
            this.swc_idOrder.NomTaula = "Orders";
            this.swc_idOrder.Requerit = false;
            this.swc_idOrder.Size = new System.Drawing.Size(487, 36);
            this.swc_idOrder.TabIndex = 92;
            // 
            // lb_idOrder
            // 
            this.lb_idOrder.AutoSize = true;
            this.lb_idOrder.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_idOrder.ForeColor = System.Drawing.Color.White;
            this.lb_idOrder.Location = new System.Drawing.Point(12, 117);
            this.lb_idOrder.Name = "lb_idOrder";
            this.lb_idOrder.Size = new System.Drawing.Size(65, 24);
            this.lb_idOrder.TabIndex = 91;
            this.lb_idOrder.Text = "Order:";
            // 
            // lb_DeliveryDate
            // 
            this.lb_DeliveryDate.AutoSize = true;
            this.lb_DeliveryDate.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_DeliveryDate.ForeColor = System.Drawing.Color.White;
            this.lb_DeliveryDate.Location = new System.Drawing.Point(12, 68);
            this.lb_DeliveryDate.Name = "lb_DeliveryDate";
            this.lb_DeliveryDate.Size = new System.Drawing.Size(129, 24);
            this.lb_DeliveryDate.TabIndex = 90;
            this.lb_DeliveryDate.Text = "Delivery Date:";
            // 
            // swt_DeliveryDate
            // 
            this.swt_DeliveryDate.ControlID = null;
            this.swt_DeliveryDate.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_DeliveryDate.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_DeliveryDate.foranea = false;
            this.swt_DeliveryDate.ForeColor = System.Drawing.Color.DimGray;
            this.swt_DeliveryDate.Location = new System.Drawing.Point(175, 65);
            this.swt_DeliveryDate.mensaje = null;
            this.swt_DeliveryDate.Name = "swt_DeliveryDate";
            this.swt_DeliveryDate.nomCamp = "DeliveryDate";
            this.swt_DeliveryDate.nomComboBox = null;
            this.swt_DeliveryDate.requerit = false;
            this.swt_DeliveryDate.Size = new System.Drawing.Size(199, 32);
            this.swt_DeliveryDate.TabIndex = 89;
            this.swt_DeliveryDate.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // lb_Quantity
            // 
            this.lb_Quantity.AutoSize = true;
            this.lb_Quantity.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_Quantity.ForeColor = System.Drawing.Color.White;
            this.lb_Quantity.Location = new System.Drawing.Point(12, 18);
            this.lb_Quantity.Name = "lb_Quantity";
            this.lb_Quantity.Size = new System.Drawing.Size(90, 24);
            this.lb_Quantity.TabIndex = 88;
            this.lb_Quantity.Text = "Quantity:";
            // 
            // swt_Quantity
            // 
            this.swt_Quantity.ControlID = null;
            this.swt_Quantity.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_Quantity.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_Quantity.foranea = false;
            this.swt_Quantity.ForeColor = System.Drawing.Color.DimGray;
            this.swt_Quantity.Location = new System.Drawing.Point(175, 18);
            this.swt_Quantity.mensaje = null;
            this.swt_Quantity.Name = "swt_Quantity";
            this.swt_Quantity.nomCamp = "Quantity";
            this.swt_Quantity.nomComboBox = null;
            this.swt_Quantity.requerit = false;
            this.swt_Quantity.Size = new System.Drawing.Size(194, 32);
            this.swt_Quantity.TabIndex = 87;
            this.swt_Quantity.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(656, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 155);
            this.panel1.TabIndex = 100;
            // 
            // MantenimientoOrdersDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(880, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.swt_idReference);
            this.Controls.Add(this.swc_idReference);
            this.Controls.Add(this.lbl_idReference);
            this.Controls.Add(this.swt_idPlanet);
            this.Controls.Add(this.swc_idPlanet);
            this.Controls.Add(this.lbl_idPlanet);
            this.Controls.Add(this.swt_idOrder);
            this.Controls.Add(this.swc_idOrder);
            this.Controls.Add(this.lb_idOrder);
            this.Controls.Add(this.lb_DeliveryDate);
            this.Controls.Add(this.swt_DeliveryDate);
            this.Controls.Add(this.lb_Quantity);
            this.Controls.Add(this.swt_Quantity);
            this.Name = "MantenimientoOrdersDetail";
            this.tabla = "OrdersDetail where idOrder = 32";
            this.Controls.SetChildIndex(this.btn_insertar, 0);
            this.Controls.SetChildIndex(this.btn_actualizarDataset, 0);
            this.Controls.SetChildIndex(this.swt_Quantity, 0);
            this.Controls.SetChildIndex(this.lb_Quantity, 0);
            this.Controls.SetChildIndex(this.swt_DeliveryDate, 0);
            this.Controls.SetChildIndex(this.lb_DeliveryDate, 0);
            this.Controls.SetChildIndex(this.lb_idOrder, 0);
            this.Controls.SetChildIndex(this.swc_idOrder, 0);
            this.Controls.SetChildIndex(this.swt_idOrder, 0);
            this.Controls.SetChildIndex(this.lbl_idPlanet, 0);
            this.Controls.SetChildIndex(this.swc_idPlanet, 0);
            this.Controls.SetChildIndex(this.swt_idPlanet, 0);
            this.Controls.SetChildIndex(this.lbl_idReference, 0);
            this.Controls.SetChildIndex(this.swc_idReference, 0);
            this.Controls.SetChildIndex(this.swt_idReference, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CC_Library.SWTextbox swt_idReference;
        private CC_Library.SWCodi swc_idReference;
        private System.Windows.Forms.Label lbl_idReference;
        private CC_Library.SWTextbox swt_idPlanet;
        private CC_Library.SWCodi swc_idPlanet;
        private System.Windows.Forms.Label lbl_idPlanet;
        private CC_Library.SWTextbox swt_idOrder;
        private CC_Library.SWCodi swc_idOrder;
        private System.Windows.Forms.Label lb_idOrder;
        private System.Windows.Forms.Label lb_DeliveryDate;
        private CC_Library.SWTextbox swt_DeliveryDate;
        private System.Windows.Forms.Label lb_Quantity;
        private CC_Library.SWTextbox swt_Quantity;
        private System.Windows.Forms.Panel panel1;
    }
}

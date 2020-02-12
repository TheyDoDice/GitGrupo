namespace Ping
{
    partial class frm_Ping
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
            this.txtb_ip = new System.Windows.Forms.TextBox();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.btn_ping = new System.Windows.Forms.Button();
            this.gbx_ip = new System.Windows.Forms.GroupBox();
            this.txtb_consola = new System.Windows.Forms.TextBox();
            this.gbx_ip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtb_ip
            // 
            this.txtb_ip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_ip.Location = new System.Drawing.Point(32, 25);
            this.txtb_ip.Name = "txtb_ip";
            this.txtb_ip.Size = new System.Drawing.Size(254, 20);
            this.txtb_ip.TabIndex = 0;
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(6, 28);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(20, 13);
            this.lbl_ip.TabIndex = 1;
            this.lbl_ip.Text = "IP:";
            // 
            // btn_ping
            // 
            this.btn_ping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ping.Location = new System.Drawing.Point(292, 23);
            this.btn_ping.Name = "btn_ping";
            this.btn_ping.Size = new System.Drawing.Size(75, 23);
            this.btn_ping.TabIndex = 2;
            this.btn_ping.Text = "Ping";
            this.btn_ping.UseVisualStyleBackColor = true;
            this.btn_ping.Click += new System.EventHandler(this.btn_ping_Click);
            // 
            // gbx_ip
            // 
            this.gbx_ip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_ip.Controls.Add(this.lbl_ip);
            this.gbx_ip.Controls.Add(this.btn_ping);
            this.gbx_ip.Controls.Add(this.txtb_ip);
            this.gbx_ip.Location = new System.Drawing.Point(12, 12);
            this.gbx_ip.Name = "gbx_ip";
            this.gbx_ip.Size = new System.Drawing.Size(373, 66);
            this.gbx_ip.TabIndex = 3;
            this.gbx_ip.TabStop = false;
            this.gbx_ip.Text = "Comprovar";
            // 
            // txtb_consola
            // 
            this.txtb_consola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_consola.Location = new System.Drawing.Point(12, 85);
            this.txtb_consola.Multiline = true;
            this.txtb_consola.Name = "txtb_consola";
            this.txtb_consola.Size = new System.Drawing.Size(373, 179);
            this.txtb_consola.TabIndex = 4;
            // 
            // frm_Ping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 276);
            this.Controls.Add(this.txtb_consola);
            this.Controls.Add(this.gbx_ip);
            this.Name = "frm_Ping";
            this.Text = "Ping";
            this.gbx_ip.ResumeLayout(false);
            this.gbx_ip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_ip;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Button btn_ping;
        private System.Windows.Forms.GroupBox gbx_ip;
        private System.Windows.Forms.TextBox txtb_consola;
    }
}


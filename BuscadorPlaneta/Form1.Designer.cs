namespace BuscadorPlaneta
{
    partial class Form1
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
            this.cmbx_buscarPlaneta = new System.Windows.Forms.ComboBox();
            this.tbx_ip = new System.Windows.Forms.TextBox();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.tbx_idPlanet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbx_buscarPlaneta
            // 
            this.cmbx_buscarPlaneta.FormattingEnabled = true;
            this.cmbx_buscarPlaneta.Location = new System.Drawing.Point(51, 91);
            this.cmbx_buscarPlaneta.Name = "cmbx_buscarPlaneta";
            this.cmbx_buscarPlaneta.Size = new System.Drawing.Size(183, 21);
            this.cmbx_buscarPlaneta.TabIndex = 0;
            // 
            // tbx_ip
            // 
            this.tbx_ip.Location = new System.Drawing.Point(371, 91);
            this.tbx_ip.Name = "tbx_ip";
            this.tbx_ip.Size = new System.Drawing.Size(131, 20);
            this.tbx_ip.TabIndex = 1;
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(347, 94);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(18, 13);
            this.lbl_ip.TabIndex = 2;
            this.lbl_ip.Text = "ip:";
            // 
            // tbx_idPlanet
            // 
            this.tbx_idPlanet.Location = new System.Drawing.Point(254, 91);
            this.tbx_idPlanet.Name = "tbx_idPlanet";
            this.tbx_idPlanet.Size = new System.Drawing.Size(45, 20);
            this.tbx_idPlanet.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 225);
            this.Controls.Add(this.tbx_idPlanet);
            this.Controls.Add(this.lbl_ip);
            this.Controls.Add(this.tbx_ip);
            this.Controls.Add(this.cmbx_buscarPlaneta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_buscarPlaneta;
        private System.Windows.Forms.TextBox tbx_ip;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.TextBox tbx_idPlanet;
    }
}


namespace CC_Library
{
    partial class SWCodi
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCodi = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxCodi
            // 
            this.textBoxCodi.Location = new System.Drawing.Point(3, 3);
            this.textBoxCodi.Name = "textBoxCodi";
            this.textBoxCodi.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodi.TabIndex = 0;
            this.textBoxCodi.TextChanged += new System.EventHandler(this.textBoxCodi_TextChanged);
            this.textBoxCodi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCodi_KeyUp);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Enabled = false;
            this.textBoxDesc.Location = new System.Drawing.Point(109, 3);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(374, 20);
            this.textBoxDesc.TabIndex = 1;
            // 
            // SWCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxCodi);
            this.Name = "SWCodi";
            this.Size = new System.Drawing.Size(487, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodi;
        private System.Windows.Forms.TextBox textBoxDesc;
    }
}

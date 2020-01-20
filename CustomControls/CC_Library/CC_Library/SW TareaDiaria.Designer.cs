namespace CC_Library
{
    partial class SW_TareaDiaria
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
            this.Titulo = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(3, 8);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(70, 25);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "label1";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.BackColor = System.Drawing.Color.Transparent;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.ForeColor = System.Drawing.Color.White;
            this.Fecha.Location = new System.Drawing.Point(168, 20);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(41, 15);
            this.Fecha.TabIndex = 2;
            this.Fecha.Text = "label1";
            // 
            // SW_TareaDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Titulo);
            this.Name = "SW_TareaDiaria";
            this.Size = new System.Drawing.Size(243, 40);
            this.Load += new System.EventHandler(this.SW_TareaDiaria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Fecha;
    }
}

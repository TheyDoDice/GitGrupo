namespace FormNave
{
    partial class Nave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nave));
            this.bttn_peticion = new System.Windows.Forms.Button();
            this.bttn_download = new System.Windows.Forms.Button();
            this.bttn_obtenirCodificacio = new System.Windows.Forms.Button();
            this.bttn_EntregarPaquetes = new System.Windows.Forms.Button();
            this.bttn_DescodificarrPaquetes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttn_peticion
            // 
            this.bttn_peticion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_peticion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_peticion.BackgroundImage")));
            this.bttn_peticion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_peticion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttn_peticion.Location = new System.Drawing.Point(294, 346);
            this.bttn_peticion.Name = "bttn_peticion";
            this.bttn_peticion.Size = new System.Drawing.Size(35, 37);
            this.bttn_peticion.TabIndex = 0;
            this.bttn_peticion.UseVisualStyleBackColor = false;
            // 
            // bttn_download
            // 
            this.bttn_download.BackColor = System.Drawing.Color.DimGray;
            this.bttn_download.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_download.BackgroundImage")));
            this.bttn_download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_download.Location = new System.Drawing.Point(561, 401);
            this.bttn_download.Name = "bttn_download";
            this.bttn_download.Size = new System.Drawing.Size(91, 34);
            this.bttn_download.TabIndex = 1;
            this.bttn_download.UseVisualStyleBackColor = false;
            // 
            // bttn_obtenirCodificacio
            // 
            this.bttn_obtenirCodificacio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_obtenirCodificacio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_obtenirCodificacio.BackgroundImage")));
            this.bttn_obtenirCodificacio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_obtenirCodificacio.Location = new System.Drawing.Point(502, 346);
            this.bttn_obtenirCodificacio.Name = "bttn_obtenirCodificacio";
            this.bttn_obtenirCodificacio.Size = new System.Drawing.Size(49, 49);
            this.bttn_obtenirCodificacio.TabIndex = 2;
            this.bttn_obtenirCodificacio.UseVisualStyleBackColor = false;
            // 
            // bttn_EntregarPaquetes
            // 
            this.bttn_EntregarPaquetes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_EntregarPaquetes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_EntregarPaquetes.BackgroundImage")));
            this.bttn_EntregarPaquetes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_EntregarPaquetes.Location = new System.Drawing.Point(423, 437);
            this.bttn_EntregarPaquetes.Name = "bttn_EntregarPaquetes";
            this.bttn_EntregarPaquetes.Size = new System.Drawing.Size(55, 50);
            this.bttn_EntregarPaquetes.TabIndex = 3;
            this.bttn_EntregarPaquetes.UseVisualStyleBackColor = false;
            // 
            // bttn_DescodificarrPaquetes
            // 
            this.bttn_DescodificarrPaquetes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_DescodificarrPaquetes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_DescodificarrPaquetes.BackgroundImage")));
            this.bttn_DescodificarrPaquetes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_DescodificarrPaquetes.Location = new System.Drawing.Point(351, 437);
            this.bttn_DescodificarrPaquetes.Name = "bttn_DescodificarrPaquetes";
            this.bttn_DescodificarrPaquetes.Size = new System.Drawing.Size(52, 50);
            this.bttn_DescodificarrPaquetes.TabIndex = 4;
            this.bttn_DescodificarrPaquetes.UseVisualStyleBackColor = false;
            // 
            // Nave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 499);
            this.Controls.Add(this.bttn_DescodificarrPaquetes);
            this.Controls.Add(this.bttn_EntregarPaquetes);
            this.Controls.Add(this.bttn_obtenirCodificacio);
            this.Controls.Add(this.bttn_download);
            this.Controls.Add(this.bttn_peticion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Nave";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_peticion;
        private System.Windows.Forms.Button bttn_download;
        private System.Windows.Forms.Button bttn_obtenirCodificacio;
        private System.Windows.Forms.Button bttn_EntregarPaquetes;
        private System.Windows.Forms.Button bttn_DescodificarrPaquetes;
    }
}


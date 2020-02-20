namespace FormNave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttn_peticion = new System.Windows.Forms.Button();
            this.bttn_download = new System.Windows.Forms.Button();
            this.bttn_encriptar = new System.Windows.Forms.Button();
            this.bttn_EntregarPaquetes = new System.Windows.Forms.Button();
            this.bttn_ComprobarPaquetes = new System.Windows.Forms.Button();
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
            // bttn_encriptar
            // 
            this.bttn_encriptar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_encriptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_encriptar.BackgroundImage")));
            this.bttn_encriptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_encriptar.Location = new System.Drawing.Point(502, 346);
            this.bttn_encriptar.Name = "bttn_encriptar";
            this.bttn_encriptar.Size = new System.Drawing.Size(49, 49);
            this.bttn_encriptar.TabIndex = 2;
            this.bttn_encriptar.UseVisualStyleBackColor = false;
            // 
            // bttn_EntregarPaquetes
            // 
            this.bttn_EntregarPaquetes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_EntregarPaquetes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_EntregarPaquetes.BackgroundImage")));
            this.bttn_EntregarPaquetes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_EntregarPaquetes.Location = new System.Drawing.Point(362, 437);
            this.bttn_EntregarPaquetes.Name = "bttn_EntregarPaquetes";
            this.bttn_EntregarPaquetes.Size = new System.Drawing.Size(55, 50);
            this.bttn_EntregarPaquetes.TabIndex = 3;
            this.bttn_EntregarPaquetes.UseVisualStyleBackColor = false;
            // 
            // bttn_ComprobarPaquetes
            // 
            this.bttn_ComprobarPaquetes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_ComprobarPaquetes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_ComprobarPaquetes.BackgroundImage")));
            this.bttn_ComprobarPaquetes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_ComprobarPaquetes.Location = new System.Drawing.Point(423, 437);
            this.bttn_ComprobarPaquetes.Name = "bttn_ComprobarPaquetes";
            this.bttn_ComprobarPaquetes.Size = new System.Drawing.Size(63, 50);
            this.bttn_ComprobarPaquetes.TabIndex = 4;
            this.bttn_ComprobarPaquetes.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 499);
            this.Controls.Add(this.bttn_ComprobarPaquetes);
            this.Controls.Add(this.bttn_EntregarPaquetes);
            this.Controls.Add(this.bttn_encriptar);
            this.Controls.Add(this.bttn_download);
            this.Controls.Add(this.bttn_peticion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_peticion;
        private System.Windows.Forms.Button bttn_download;
        private System.Windows.Forms.Button bttn_encriptar;
        private System.Windows.Forms.Button bttn_EntregarPaquetes;
        private System.Windows.Forms.Button bttn_ComprobarPaquetes;
    }
}


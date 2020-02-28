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
            this.bttn_downloadCodificacion = new System.Windows.Forms.Button();
            this.bttn_obtenirValidationCode = new System.Windows.Forms.Button();
            this.bttn_EntregarPaquetes = new System.Windows.Forms.Button();
            this.bttn_DescodificarrPaquetes = new System.Windows.Forms.Button();
            this.btn_enviarMensajeEncriptado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_peticion
            // 
            this.bttn_peticion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttn_peticion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_peticion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_peticion.BackgroundImage")));
            this.bttn_peticion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_peticion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttn_peticion.Location = new System.Drawing.Point(477, 243);
            this.bttn_peticion.Name = "bttn_peticion";
            this.bttn_peticion.Size = new System.Drawing.Size(69, 74);
            this.bttn_peticion.TabIndex = 0;
            this.bttn_peticion.UseVisualStyleBackColor = false;
            this.bttn_peticion.Click += new System.EventHandler(this.bttn_peticion_Click);
            // 
            // bttn_downloadCodificacion
            // 
            this.bttn_downloadCodificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_downloadCodificacion.BackColor = System.Drawing.Color.DimGray;
            this.bttn_downloadCodificacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_downloadCodificacion.BackgroundImage")));
            this.bttn_downloadCodificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_downloadCodificacion.Location = new System.Drawing.Point(288, 334);
            this.bttn_downloadCodificacion.Name = "bttn_downloadCodificacion";
            this.bttn_downloadCodificacion.Size = new System.Drawing.Size(177, 57);
            this.bttn_downloadCodificacion.TabIndex = 1;
            this.bttn_downloadCodificacion.UseVisualStyleBackColor = false;
            this.bttn_downloadCodificacion.Click += new System.EventHandler(this.bttn_downloadCodificacion_Click);
            // 
            // bttn_obtenirValidationCode
            // 
            this.bttn_obtenirValidationCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_obtenirValidationCode.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_obtenirValidationCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_obtenirValidationCode.BackgroundImage")));
            this.bttn_obtenirValidationCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_obtenirValidationCode.Location = new System.Drawing.Point(331, 242);
            this.bttn_obtenirValidationCode.Name = "bttn_obtenirValidationCode";
            this.bttn_obtenirValidationCode.Size = new System.Drawing.Size(86, 74);
            this.bttn_obtenirValidationCode.TabIndex = 2;
            this.bttn_obtenirValidationCode.UseVisualStyleBackColor = false;
            this.bttn_obtenirValidationCode.Click += new System.EventHandler(this.bttn_obtenirValidationCode_Click);
            // 
            // bttn_EntregarPaquetes
            // 
            this.bttn_EntregarPaquetes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_EntregarPaquetes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_EntregarPaquetes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_EntregarPaquetes.BackgroundImage")));
            this.bttn_EntregarPaquetes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_EntregarPaquetes.Location = new System.Drawing.Point(66, 399);
            this.bttn_EntregarPaquetes.Name = "bttn_EntregarPaquetes";
            this.bttn_EntregarPaquetes.Size = new System.Drawing.Size(97, 88);
            this.bttn_EntregarPaquetes.TabIndex = 3;
            this.bttn_EntregarPaquetes.UseVisualStyleBackColor = false;
            this.bttn_EntregarPaquetes.Click += new System.EventHandler(this.bttn_EntregarPaquetes_Click);
            // 
            // bttn_DescodificarrPaquetes
            // 
            this.bttn_DescodificarrPaquetes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttn_DescodificarrPaquetes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_DescodificarrPaquetes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_DescodificarrPaquetes.BackgroundImage")));
            this.bttn_DescodificarrPaquetes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_DescodificarrPaquetes.Location = new System.Drawing.Point(637, 399);
            this.bttn_DescodificarrPaquetes.Name = "bttn_DescodificarrPaquetes";
            this.bttn_DescodificarrPaquetes.Size = new System.Drawing.Size(96, 88);
            this.bttn_DescodificarrPaquetes.TabIndex = 4;
            this.bttn_DescodificarrPaquetes.UseVisualStyleBackColor = false;
            this.bttn_DescodificarrPaquetes.Click += new System.EventHandler(this.bttn_DescodificarrPaquetes_Click);
            // 
            // btn_enviarMensajeEncriptado
            // 
            this.btn_enviarMensajeEncriptado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_enviarMensajeEncriptado.BackColor = System.Drawing.Color.DimGray;
            this.btn_enviarMensajeEncriptado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_enviarMensajeEncriptado.BackgroundImage")));
            this.btn_enviarMensajeEncriptado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enviarMensajeEncriptado.Location = new System.Drawing.Point(215, 243);
            this.btn_enviarMensajeEncriptado.Name = "btn_enviarMensajeEncriptado";
            this.btn_enviarMensajeEncriptado.Size = new System.Drawing.Size(72, 74);
            this.btn_enviarMensajeEncriptado.TabIndex = 5;
            this.btn_enviarMensajeEncriptado.UseVisualStyleBackColor = false;
            this.btn_enviarMensajeEncriptado.Click += new System.EventHandler(this.btn_enviarMensajeEncriptado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Nave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_enviarMensajeEncriptado);
            this.Controls.Add(this.bttn_DescodificarrPaquetes);
            this.Controls.Add(this.bttn_EntregarPaquetes);
            this.Controls.Add(this.bttn_obtenirValidationCode);
            this.Controls.Add(this.bttn_downloadCodificacion);
            this.Controls.Add(this.bttn_peticion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Nave";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_peticion;
        private System.Windows.Forms.Button bttn_downloadCodificacion;
        private System.Windows.Forms.Button bttn_obtenirValidationCode;
        private System.Windows.Forms.Button bttn_EntregarPaquetes;
        private System.Windows.Forms.Button bttn_DescodificarrPaquetes;
        private System.Windows.Forms.Button btn_enviarMensajeEncriptado;
        private System.Windows.Forms.Label label1;
    }
}


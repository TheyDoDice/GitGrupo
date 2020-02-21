namespace WindowsFormsApp1
{
    partial class Cliente
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
            this.tbx_Message = new System.Windows.Forms.TextBox();
            this.bttn_enviarDades = new System.Windows.Forms.Button();
            this.lbl_ipServer = new System.Windows.Forms.Label();
            this.tbx_ip = new System.Windows.Forms.TextBox();
            this.lbl_portServer = new System.Windows.Forms.Label();
            this.tbx_port = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.btn_enviarArchivos = new System.Windows.Forms.Button();
            this.grbx_datos = new System.Windows.Forms.GroupBox();
            this.grbx_mensaje = new System.Windows.Forms.GroupBox();
            this.grbx_datos.SuspendLayout();
            this.grbx_mensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_Message
            // 
            this.tbx_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Message.Location = new System.Drawing.Point(6, 19);
            this.tbx_Message.Multiline = true;
            this.tbx_Message.Name = "tbx_Message";
            this.tbx_Message.Size = new System.Drawing.Size(394, 162);
            this.tbx_Message.TabIndex = 1;
            // 
            // bttn_enviarDades
            // 
            this.bttn_enviarDades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_enviarDades.Location = new System.Drawing.Point(319, 187);
            this.bttn_enviarDades.Name = "bttn_enviarDades";
            this.bttn_enviarDades.Size = new System.Drawing.Size(81, 24);
            this.bttn_enviarDades.TabIndex = 3;
            this.bttn_enviarDades.Text = "Enviar Dades";
            this.bttn_enviarDades.UseVisualStyleBackColor = true;
            this.bttn_enviarDades.Click += new System.EventHandler(this.bttn_enviarDades_Click);
            // 
            // lbl_ipServer
            // 
            this.lbl_ipServer.AutoSize = true;
            this.lbl_ipServer.Location = new System.Drawing.Point(6, 19);
            this.lbl_ipServer.Name = "lbl_ipServer";
            this.lbl_ipServer.Size = new System.Drawing.Size(20, 13);
            this.lbl_ipServer.TabIndex = 1;
            this.lbl_ipServer.Text = "IP:";
            // 
            // tbx_ip
            // 
            this.tbx_ip.Location = new System.Drawing.Point(32, 16);
            this.tbx_ip.Name = "tbx_ip";
            this.tbx_ip.Size = new System.Drawing.Size(149, 20);
            this.tbx_ip.TabIndex = 2;
            this.tbx_ip.Text = "172.17.22.48";
            // 
            // lbl_portServer
            // 
            this.lbl_portServer.AutoSize = true;
            this.lbl_portServer.Location = new System.Drawing.Point(307, 19);
            this.lbl_portServer.Name = "lbl_portServer";
            this.lbl_portServer.Size = new System.Drawing.Size(29, 13);
            this.lbl_portServer.TabIndex = 3;
            this.lbl_portServer.Text = "Port:";
            // 
            // tbx_port
            // 
            this.tbx_port.Location = new System.Drawing.Point(339, 16);
            this.tbx_port.Name = "tbx_port";
            this.tbx_port.Size = new System.Drawing.Size(61, 20);
            this.tbx_port.TabIndex = 4;
            this.tbx_port.Text = "8888";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(27, 310);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(0, 13);
            this.lbl_estado.TabIndex = 12;
            // 
            // btn_enviarArchivos
            // 
            this.btn_enviarArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_enviarArchivos.Location = new System.Drawing.Point(228, 188);
            this.btn_enviarArchivos.Name = "btn_enviarArchivos";
            this.btn_enviarArchivos.Size = new System.Drawing.Size(85, 23);
            this.btn_enviarArchivos.TabIndex = 2;
            this.btn_enviarArchivos.Text = "Enviar Archivo";
            this.btn_enviarArchivos.UseVisualStyleBackColor = true;
            this.btn_enviarArchivos.Click += new System.EventHandler(this.btn_enviarArchivos_Click);
            // 
            // grbx_datos
            // 
            this.grbx_datos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbx_datos.Controls.Add(this.tbx_ip);
            this.grbx_datos.Controls.Add(this.lbl_ipServer);
            this.grbx_datos.Controls.Add(this.lbl_portServer);
            this.grbx_datos.Controls.Add(this.tbx_port);
            this.grbx_datos.Location = new System.Drawing.Point(12, 12);
            this.grbx_datos.Name = "grbx_datos";
            this.grbx_datos.Size = new System.Drawing.Size(409, 47);
            this.grbx_datos.TabIndex = 1;
            this.grbx_datos.TabStop = false;
            this.grbx_datos.Text = "Datos";
            // 
            // grbx_mensaje
            // 
            this.grbx_mensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbx_mensaje.Controls.Add(this.tbx_Message);
            this.grbx_mensaje.Controls.Add(this.bttn_enviarDades);
            this.grbx_mensaje.Controls.Add(this.btn_enviarArchivos);
            this.grbx_mensaje.Location = new System.Drawing.Point(12, 65);
            this.grbx_mensaje.Name = "grbx_mensaje";
            this.grbx_mensaje.Size = new System.Drawing.Size(409, 217);
            this.grbx_mensaje.TabIndex = 2;
            this.grbx_mensaje.TabStop = false;
            this.grbx_mensaje.Text = "Mensaje";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 293);
            this.Controls.Add(this.grbx_mensaje);
            this.Controls.Add(this.grbx_datos);
            this.Controls.Add(this.lbl_estado);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.grbx_datos.ResumeLayout(false);
            this.grbx_datos.PerformLayout();
            this.grbx_mensaje.ResumeLayout(false);
            this.grbx_mensaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbx_Message;
        private System.Windows.Forms.Button bttn_enviarDades;
        private System.Windows.Forms.Label lbl_ipServer;
        private System.Windows.Forms.TextBox tbx_ip;
        private System.Windows.Forms.Label lbl_portServer;
        private System.Windows.Forms.TextBox tbx_port;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Button btn_enviarArchivos;
        private System.Windows.Forms.GroupBox grbx_datos;
        private System.Windows.Forms.GroupBox grbx_mensaje;
    }
}


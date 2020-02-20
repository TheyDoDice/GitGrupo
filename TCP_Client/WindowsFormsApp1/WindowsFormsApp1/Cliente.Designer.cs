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
            this.SuspendLayout();
            // 
            // tbx_Message
            // 
            this.tbx_Message.Location = new System.Drawing.Point(27, 53);
            this.tbx_Message.Multiline = true;
            this.tbx_Message.Name = "tbx_Message";
            this.tbx_Message.Size = new System.Drawing.Size(409, 154);
            this.tbx_Message.TabIndex = 6;
            // 
            // bttn_enviarDades
            // 
            this.bttn_enviarDades.Location = new System.Drawing.Point(318, 223);
            this.bttn_enviarDades.Name = "bttn_enviarDades";
            this.bttn_enviarDades.Size = new System.Drawing.Size(118, 24);
            this.bttn_enviarDades.TabIndex = 7;
            this.bttn_enviarDades.Text = "Enviar Dades";
            this.bttn_enviarDades.UseVisualStyleBackColor = true;
            this.bttn_enviarDades.Click += new System.EventHandler(this.bttn_enviarDades_Click);
            // 
            // lbl_ipServer
            // 
            this.lbl_ipServer.AutoSize = true;
            this.lbl_ipServer.Location = new System.Drawing.Point(29, 30);
            this.lbl_ipServer.Name = "lbl_ipServer";
            this.lbl_ipServer.Size = new System.Drawing.Size(20, 13);
            this.lbl_ipServer.TabIndex = 9;
            this.lbl_ipServer.Text = "IP:";
            // 
            // tbx_ip
            // 
            this.tbx_ip.Location = new System.Drawing.Point(55, 27);
            this.tbx_ip.Name = "tbx_ip";
            this.tbx_ip.Size = new System.Drawing.Size(149, 20);
            this.tbx_ip.TabIndex = 8;
            this.tbx_ip.Text = "172.17.22.48";
            // 
            // lbl_portServer
            // 
            this.lbl_portServer.AutoSize = true;
            this.lbl_portServer.Location = new System.Drawing.Point(331, 33);
            this.lbl_portServer.Name = "lbl_portServer";
            this.lbl_portServer.Size = new System.Drawing.Size(29, 13);
            this.lbl_portServer.TabIndex = 10;
            this.lbl_portServer.Text = "Port:";
            // 
            // tbx_port
            // 
            this.tbx_port.Location = new System.Drawing.Point(375, 30);
            this.tbx_port.Name = "tbx_port";
            this.tbx_port.Size = new System.Drawing.Size(61, 20);
            this.tbx_port.TabIndex = 11;
            this.tbx_port.Text = "8888";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(27, 229);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(0, 13);
            this.lbl_estado.TabIndex = 12;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 270);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.tbx_port);
            this.Controls.Add(this.lbl_portServer);
            this.Controls.Add(this.lbl_ipServer);
            this.Controls.Add(this.tbx_ip);
            this.Controls.Add(this.bttn_enviarDades);
            this.Controls.Add(this.tbx_Message);
            this.Name = "Cliente";
            this.Text = "Form1";
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
    }
}


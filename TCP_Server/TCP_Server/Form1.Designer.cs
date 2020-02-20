namespace TCP_Server
{
    partial class frm_server
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
            this.components = new System.ComponentModel.Container();
            this.grbx_datos = new System.Windows.Forms.GroupBox();
            this.btn_desconectar = new System.Windows.Forms.Button();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.txtb_port = new System.Windows.Forms.TextBox();
            this.lbl_puerto = new System.Windows.Forms.Label();
            this.txtb_ip = new System.Windows.Forms.TextBox();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.gb_datosRecibidos = new System.Windows.Forms.GroupBox();
            this.btn_respuesta = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtb_datosRecibidos = new System.Windows.Forms.RichTextBox();
            this.grbx_datos.SuspendLayout();
            this.gb_datosRecibidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_datos
            // 
            this.grbx_datos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbx_datos.Controls.Add(this.btn_respuesta);
            this.grbx_datos.Controls.Add(this.btn_desconectar);
            this.grbx_datos.Controls.Add(this.btn_conectar);
            this.grbx_datos.Controls.Add(this.txtb_port);
            this.grbx_datos.Controls.Add(this.lbl_puerto);
            this.grbx_datos.Controls.Add(this.txtb_ip);
            this.grbx_datos.Controls.Add(this.lbl_ip);
            this.grbx_datos.Location = new System.Drawing.Point(12, 12);
            this.grbx_datos.Name = "grbx_datos";
            this.grbx_datos.Size = new System.Drawing.Size(515, 46);
            this.grbx_datos.TabIndex = 0;
            this.grbx_datos.TabStop = false;
            this.grbx_datos.Text = "Datos";
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.Location = new System.Drawing.Point(345, 15);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(79, 23);
            this.btn_desconectar.TabIndex = 5;
            this.btn_desconectar.Text = "Desconectar";
            this.btn_desconectar.UseVisualStyleBackColor = true;
            this.btn_desconectar.Click += new System.EventHandler(this.btn_desconectar_Click);
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(281, 15);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(58, 23);
            this.btn_conectar.TabIndex = 4;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // txtb_port
            // 
            this.txtb_port.Location = new System.Drawing.Point(230, 17);
            this.txtb_port.Name = "txtb_port";
            this.txtb_port.Size = new System.Drawing.Size(45, 20);
            this.txtb_port.TabIndex = 3;
            // 
            // lbl_puerto
            // 
            this.lbl_puerto.AutoSize = true;
            this.lbl_puerto.Location = new System.Drawing.Point(183, 20);
            this.lbl_puerto.Name = "lbl_puerto";
            this.lbl_puerto.Size = new System.Drawing.Size(41, 13);
            this.lbl_puerto.TabIndex = 2;
            this.lbl_puerto.Text = "Puerto:";
            // 
            // txtb_ip
            // 
            this.txtb_ip.Location = new System.Drawing.Point(33, 17);
            this.txtb_ip.Name = "txtb_ip";
            this.txtb_ip.Size = new System.Drawing.Size(144, 20);
            this.txtb_ip.TabIndex = 1;
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(7, 20);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(20, 13);
            this.lbl_ip.TabIndex = 0;
            this.lbl_ip.Text = "IP:";
            // 
            // gb_datosRecibidos
            // 
            this.gb_datosRecibidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_datosRecibidos.Controls.Add(this.txtb_datosRecibidos);
            this.gb_datosRecibidos.Location = new System.Drawing.Point(12, 64);
            this.gb_datosRecibidos.Name = "gb_datosRecibidos";
            this.gb_datosRecibidos.Size = new System.Drawing.Size(515, 363);
            this.gb_datosRecibidos.TabIndex = 3;
            this.gb_datosRecibidos.TabStop = false;
            this.gb_datosRecibidos.Text = "Datos Recibidos";
            // 
            // btn_respuesta
            // 
            this.btn_respuesta.Location = new System.Drawing.Point(430, 15);
            this.btn_respuesta.Name = "btn_respuesta";
            this.btn_respuesta.Size = new System.Drawing.Size(75, 23);
            this.btn_respuesta.TabIndex = 6;
            this.btn_respuesta.Text = "Respuesta";
            this.btn_respuesta.UseVisualStyleBackColor = true;
            this.btn_respuesta.Click += new System.EventHandler(this.btn_respuesta_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtb_datosRecibidos
            // 
            this.txtb_datosRecibidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_datosRecibidos.Location = new System.Drawing.Point(10, 19);
            this.txtb_datosRecibidos.Name = "txtb_datosRecibidos";
            this.txtb_datosRecibidos.ReadOnly = true;
            this.txtb_datosRecibidos.Size = new System.Drawing.Size(495, 338);
            this.txtb_datosRecibidos.TabIndex = 0;
            this.txtb_datosRecibidos.Text = "";
            // 
            // frm_server
            // 
            this.AcceptButton = this.btn_conectar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 439);
            this.Controls.Add(this.gb_datosRecibidos);
            this.Controls.Add(this.grbx_datos);
            this.Name = "frm_server";
            this.Text = "Servidor";
            this.grbx_datos.ResumeLayout(false);
            this.grbx_datos.PerformLayout();
            this.gb_datosRecibidos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_datos;
        private System.Windows.Forms.TextBox txtb_port;
        private System.Windows.Forms.Label lbl_puerto;
        private System.Windows.Forms.TextBox txtb_ip;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.GroupBox gb_datosRecibidos;
        private System.Windows.Forms.Button btn_desconectar;
        private System.Windows.Forms.Button btn_respuesta;
        private System.Windows.Forms.RichTextBox txtb_datosRecibidos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}


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
            this.txtb_portData = new System.Windows.Forms.TextBox();
            this.lbl_portData = new System.Windows.Forms.Label();
            this.txtb_port = new System.Windows.Forms.TextBox();
            this.lbl_puerto = new System.Windows.Forms.Label();
            this.gb_datosRecibidos = new System.Windows.Forms.GroupBox();
            this.txtb_datosRecibidos = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtb_portExtensio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbx_datos.SuspendLayout();
            this.gb_datosRecibidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_datos
            // 
            this.grbx_datos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbx_datos.Controls.Add(this.label1);
            this.grbx_datos.Controls.Add(this.txtb_portExtensio);
            this.grbx_datos.Controls.Add(this.txtb_portData);
            this.grbx_datos.Controls.Add(this.lbl_portData);
            this.grbx_datos.Controls.Add(this.txtb_port);
            this.grbx_datos.Controls.Add(this.lbl_puerto);
            this.grbx_datos.Location = new System.Drawing.Point(12, 12);
            this.grbx_datos.Name = "grbx_datos";
            this.grbx_datos.Size = new System.Drawing.Size(281, 96);
            this.grbx_datos.TabIndex = 0;
            this.grbx_datos.TabStop = false;
            this.grbx_datos.Text = "Datos";
            // 
            // txtb_portData
            // 
            this.txtb_portData.Location = new System.Drawing.Point(96, 43);
            this.txtb_portData.Name = "txtb_portData";
            this.txtb_portData.Size = new System.Drawing.Size(167, 20);
            this.txtb_portData.TabIndex = 5;
            this.txtb_portData.Text = "8889";
            this.txtb_portData.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_portData
            // 
            this.lbl_portData.AutoSize = true;
            this.lbl_portData.Location = new System.Drawing.Point(10, 46);
            this.lbl_portData.Name = "lbl_portData";
            this.lbl_portData.Size = new System.Drawing.Size(80, 13);
            this.lbl_portData.TabIndex = 4;
            this.lbl_portData.Text = "Puerto Archivo:";
            // 
            // txtb_port
            // 
            this.txtb_port.Location = new System.Drawing.Point(96, 15);
            this.txtb_port.Name = "txtb_port";
            this.txtb_port.Size = new System.Drawing.Size(167, 20);
            this.txtb_port.TabIndex = 3;
            this.txtb_port.Text = "8888";
            // 
            // lbl_puerto
            // 
            this.lbl_puerto.AutoSize = true;
            this.lbl_puerto.Location = new System.Drawing.Point(10, 18);
            this.lbl_puerto.Name = "lbl_puerto";
            this.lbl_puerto.Size = new System.Drawing.Size(66, 13);
            this.lbl_puerto.TabIndex = 2;
            this.lbl_puerto.Text = "Puerto Chat:";
            // 
            // gb_datosRecibidos
            // 
            this.gb_datosRecibidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_datosRecibidos.Controls.Add(this.txtb_datosRecibidos);
            this.gb_datosRecibidos.Location = new System.Drawing.Point(12, 114);
            this.gb_datosRecibidos.Name = "gb_datosRecibidos";
            this.gb_datosRecibidos.Size = new System.Drawing.Size(281, 313);
            this.gb_datosRecibidos.TabIndex = 3;
            this.gb_datosRecibidos.TabStop = false;
            this.gb_datosRecibidos.Text = "Datos Recibidos";
            // 
            // txtb_datosRecibidos
            // 
            this.txtb_datosRecibidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_datosRecibidos.Location = new System.Drawing.Point(10, 19);
            this.txtb_datosRecibidos.Name = "txtb_datosRecibidos";
            this.txtb_datosRecibidos.ReadOnly = true;
            this.txtb_datosRecibidos.Size = new System.Drawing.Size(253, 288);
            this.txtb_datosRecibidos.TabIndex = 0;
            this.txtb_datosRecibidos.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtb_portExtensio
            // 
            this.txtb_portExtensio.Location = new System.Drawing.Point(96, 69);
            this.txtb_portExtensio.Name = "txtb_portExtensio";
            this.txtb_portExtensio.Size = new System.Drawing.Size(167, 20);
            this.txtb_portExtensio.TabIndex = 6;
            this.txtb_portExtensio.Text = "pacs.tx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre Archivo:";
            // 
            // frm_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 439);
            this.Controls.Add(this.gb_datosRecibidos);
            this.Controls.Add(this.grbx_datos);
            this.Name = "frm_server";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.frm_server_Load);
            this.grbx_datos.ResumeLayout(false);
            this.grbx_datos.PerformLayout();
            this.gb_datosRecibidos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_datos;
        private System.Windows.Forms.TextBox txtb_port;
        private System.Windows.Forms.Label lbl_puerto;
        private System.Windows.Forms.GroupBox gb_datosRecibidos;
        private System.Windows.Forms.RichTextBox txtb_datosRecibidos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtb_portData;
        private System.Windows.Forms.Label lbl_portData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_portExtensio;
    }
}


namespace TcpIP
{
    partial class frm_tcpip
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
            this.gb_datosPC = new System.Windows.Forms.GroupBox();
            this.txtb_puerto = new System.Windows.Forms.TextBox();
            this.lbl_puerto = new System.Windows.Forms.Label();
            this.txtb_ip = new System.Windows.Forms.TextBox();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.txtb_send_data = new System.Windows.Forms.TextBox();
            this.txtb_DatosRecividos = new System.Windows.Forms.TextBox();
            this.btn_escuchar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ip_Sender = new System.Windows.Forms.Label();
            this.txtb_ip_Sender = new System.Windows.Forms.TextBox();
            this.lbl_puerto_sender = new System.Windows.Forms.Label();
            this.txtb_puerto_sender = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_datosPC.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_datosPC
            // 
            this.gb_datosPC.Controls.Add(this.txtb_DatosRecividos);
            this.gb_datosPC.Controls.Add(this.btn_escuchar);
            this.gb_datosPC.Controls.Add(this.txtb_puerto);
            this.gb_datosPC.Controls.Add(this.lbl_puerto);
            this.gb_datosPC.Controls.Add(this.txtb_ip);
            this.gb_datosPC.Controls.Add(this.lbl_ip);
            this.gb_datosPC.Location = new System.Drawing.Point(12, 12);
            this.gb_datosPC.Name = "gb_datosPC";
            this.gb_datosPC.Size = new System.Drawing.Size(384, 228);
            this.gb_datosPC.TabIndex = 0;
            this.gb_datosPC.TabStop = false;
            this.gb_datosPC.Text = "Recibir Datos";
            // 
            // txtb_puerto
            // 
            this.txtb_puerto.Location = new System.Drawing.Point(300, 17);
            this.txtb_puerto.Name = "txtb_puerto";
            this.txtb_puerto.Size = new System.Drawing.Size(68, 20);
            this.txtb_puerto.TabIndex = 3;
            // 
            // lbl_puerto
            // 
            this.lbl_puerto.AutoSize = true;
            this.lbl_puerto.Location = new System.Drawing.Point(253, 20);
            this.lbl_puerto.Name = "lbl_puerto";
            this.lbl_puerto.Size = new System.Drawing.Size(41, 13);
            this.lbl_puerto.TabIndex = 2;
            this.lbl_puerto.Text = "Puerto:";
            // 
            // txtb_ip
            // 
            this.txtb_ip.Location = new System.Drawing.Point(33, 17);
            this.txtb_ip.Name = "txtb_ip";
            this.txtb_ip.Size = new System.Drawing.Size(214, 20);
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
            // txtb_send_data
            // 
            this.txtb_send_data.Location = new System.Drawing.Point(13, 43);
            this.txtb_send_data.Multiline = true;
            this.txtb_send_data.Name = "txtb_send_data";
            this.txtb_send_data.Size = new System.Drawing.Size(358, 140);
            this.txtb_send_data.TabIndex = 1;
            // 
            // txtb_DatosRecividos
            // 
            this.txtb_DatosRecividos.Location = new System.Drawing.Point(10, 43);
            this.txtb_DatosRecividos.Multiline = true;
            this.txtb_DatosRecividos.Name = "txtb_DatosRecividos";
            this.txtb_DatosRecividos.Size = new System.Drawing.Size(358, 144);
            this.txtb_DatosRecividos.TabIndex = 4;
            // 
            // btn_escuchar
            // 
            this.btn_escuchar.Location = new System.Drawing.Point(293, 193);
            this.btn_escuchar.Name = "btn_escuchar";
            this.btn_escuchar.Size = new System.Drawing.Size(75, 23);
            this.btn_escuchar.TabIndex = 4;
            this.btn_escuchar.Text = "Escuchar";
            this.btn_escuchar.UseVisualStyleBackColor = true;
            this.btn_escuchar.Click += new System.EventHandler(this.btn_escuchar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtb_puerto_sender);
            this.groupBox1.Controls.Add(this.lbl_puerto_sender);
            this.groupBox1.Controls.Add(this.txtb_ip_Sender);
            this.groupBox1.Controls.Add(this.lbl_ip_Sender);
            this.groupBox1.Controls.Add(this.txtb_send_data);
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 221);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviar Datos";
            // 
            // lbl_ip_Sender
            // 
            this.lbl_ip_Sender.AutoSize = true;
            this.lbl_ip_Sender.Location = new System.Drawing.Point(10, 20);
            this.lbl_ip_Sender.Name = "lbl_ip_Sender";
            this.lbl_ip_Sender.Size = new System.Drawing.Size(20, 13);
            this.lbl_ip_Sender.TabIndex = 2;
            this.lbl_ip_Sender.Text = "IP:";
            // 
            // txtb_ip_Sender
            // 
            this.txtb_ip_Sender.Location = new System.Drawing.Point(33, 17);
            this.txtb_ip_Sender.Name = "txtb_ip_Sender";
            this.txtb_ip_Sender.Size = new System.Drawing.Size(214, 20);
            this.txtb_ip_Sender.TabIndex = 3;
            // 
            // lbl_puerto_sender
            // 
            this.lbl_puerto_sender.AutoSize = true;
            this.lbl_puerto_sender.Location = new System.Drawing.Point(253, 20);
            this.lbl_puerto_sender.Name = "lbl_puerto_sender";
            this.lbl_puerto_sender.Size = new System.Drawing.Size(41, 13);
            this.lbl_puerto_sender.TabIndex = 4;
            this.lbl_puerto_sender.Text = "Puerto:";
            // 
            // txtb_puerto_sender
            // 
            this.txtb_puerto_sender.Location = new System.Drawing.Point(293, 17);
            this.txtb_puerto_sender.Name = "txtb_puerto_sender";
            this.txtb_puerto_sender.Size = new System.Drawing.Size(75, 20);
            this.txtb_puerto_sender.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_tcpip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_datosPC);
            this.Name = "frm_tcpip";
            this.Text = "TCP IP";
            this.gb_datosPC.ResumeLayout(false);
            this.gb_datosPC.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_datosPC;
        private System.Windows.Forms.TextBox txtb_puerto;
        private System.Windows.Forms.Label lbl_puerto;
        private System.Windows.Forms.TextBox txtb_ip;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.TextBox txtb_send_data;
        private System.Windows.Forms.TextBox txtb_DatosRecividos;
        private System.Windows.Forms.Button btn_escuchar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtb_puerto_sender;
        private System.Windows.Forms.Label lbl_puerto_sender;
        private System.Windows.Forms.TextBox txtb_ip_Sender;
        private System.Windows.Forms.Label lbl_ip_Sender;
        private System.Windows.Forms.Button button1;
    }
}


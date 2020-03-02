namespace TCP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_portChat = new System.Windows.Forms.Label();
            this.lbl_portData = new System.Windows.Forms.Label();
            this.lbl_nomData = new System.Windows.Forms.Label();
            this.txt_ServerChatPort = new System.Windows.Forms.TextBox();
            this.txt_ServerDataPort = new System.Windows.Forms.TextBox();
            this.txt_ServerDataName = new System.Windows.Forms.TextBox();
            this.txt_ClientChatMessage = new System.Windows.Forms.TextBox();
            this.txt_ClientPort = new System.Windows.Forms.TextBox();
            this.lbl_ClientPort = new System.Windows.Forms.Label();
            this.btn_sendChat = new System.Windows.Forms.Button();
            this.btn_sendData = new System.Windows.Forms.Button();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.btn_reiniciarServer = new System.Windows.Forms.Button();
            this.txt_chat = new System.Windows.Forms.RichTextBox();
            this.btn_ClientConect = new System.Windows.Forms.Button();
            this.lbl_ClientIp = new System.Windows.Forms.Label();
            this.txt_ClientIp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(11, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 1);
            this.panel1.TabIndex = 0;
            // 
            // lbl_portChat
            // 
            this.lbl_portChat.AutoSize = true;
            this.lbl_portChat.Location = new System.Drawing.Point(8, 18);
            this.lbl_portChat.Name = "lbl_portChat";
            this.lbl_portChat.Size = new System.Drawing.Size(66, 13);
            this.lbl_portChat.TabIndex = 1;
            this.lbl_portChat.Text = "Puerto Chat:";
            // 
            // lbl_portData
            // 
            this.lbl_portData.AutoSize = true;
            this.lbl_portData.Location = new System.Drawing.Point(8, 44);
            this.lbl_portData.Name = "lbl_portData";
            this.lbl_portData.Size = new System.Drawing.Size(85, 13);
            this.lbl_portData.TabIndex = 2;
            this.lbl_portData.Text = "Puerto Archivos:";
            // 
            // lbl_nomData
            // 
            this.lbl_nomData.AutoSize = true;
            this.lbl_nomData.Location = new System.Drawing.Point(222, 44);
            this.lbl_nomData.Name = "lbl_nomData";
            this.lbl_nomData.Size = new System.Drawing.Size(86, 13);
            this.lbl_nomData.TabIndex = 4;
            this.lbl_nomData.Text = "Nombre Archivo:";
            // 
            // txt_ServerChatPort
            // 
            this.txt_ServerChatPort.Location = new System.Drawing.Point(102, 15);
            this.txt_ServerChatPort.Name = "txt_ServerChatPort";
            this.txt_ServerChatPort.Size = new System.Drawing.Size(100, 20);
            this.txt_ServerChatPort.TabIndex = 5;
            this.txt_ServerChatPort.Text = "8888";
            // 
            // txt_ServerDataPort
            // 
            this.txt_ServerDataPort.Location = new System.Drawing.Point(102, 41);
            this.txt_ServerDataPort.Name = "txt_ServerDataPort";
            this.txt_ServerDataPort.Size = new System.Drawing.Size(100, 20);
            this.txt_ServerDataPort.TabIndex = 6;
            this.txt_ServerDataPort.Text = "8889";
            // 
            // txt_ServerDataName
            // 
            this.txt_ServerDataName.Location = new System.Drawing.Point(326, 41);
            this.txt_ServerDataName.Name = "txt_ServerDataName";
            this.txt_ServerDataName.Size = new System.Drawing.Size(100, 20);
            this.txt_ServerDataName.TabIndex = 7;
            this.txt_ServerDataName.Text = "PACS.zip";
            // 
            // txt_ClientChatMessage
            // 
            this.txt_ClientChatMessage.Location = new System.Drawing.Point(15, 266);
            this.txt_ClientChatMessage.Name = "txt_ClientChatMessage";
            this.txt_ClientChatMessage.Size = new System.Drawing.Size(305, 20);
            this.txt_ClientChatMessage.TabIndex = 8;
            // 
            // txt_ClientPort
            // 
            this.txt_ClientPort.Location = new System.Drawing.Point(59, 231);
            this.txt_ClientPort.Name = "txt_ClientPort";
            this.txt_ClientPort.Size = new System.Drawing.Size(69, 20);
            this.txt_ClientPort.TabIndex = 9;
            this.txt_ClientPort.Text = "8888";
            // 
            // lbl_ClientPort
            // 
            this.lbl_ClientPort.AutoSize = true;
            this.lbl_ClientPort.Location = new System.Drawing.Point(12, 235);
            this.lbl_ClientPort.Name = "lbl_ClientPort";
            this.lbl_ClientPort.Size = new System.Drawing.Size(41, 13);
            this.lbl_ClientPort.TabIndex = 10;
            this.lbl_ClientPort.Text = "Puerto:";
            // 
            // btn_sendChat
            // 
            this.btn_sendChat.Location = new System.Drawing.Point(326, 265);
            this.btn_sendChat.Name = "btn_sendChat";
            this.btn_sendChat.Size = new System.Drawing.Size(100, 20);
            this.btn_sendChat.TabIndex = 11;
            this.btn_sendChat.Text = "Enviar Mensaje";
            this.btn_sendChat.UseVisualStyleBackColor = true;
            this.btn_sendChat.Click += new System.EventHandler(this.btn_sendChat_Click);
            // 
            // btn_sendData
            // 
            this.btn_sendData.Location = new System.Drawing.Point(15, 304);
            this.btn_sendData.Name = "btn_sendData";
            this.btn_sendData.Size = new System.Drawing.Size(100, 20);
            this.btn_sendData.TabIndex = 12;
            this.btn_sendData.Text = "Enviar Archivo";
            this.btn_sendData.UseVisualStyleBackColor = true;
            this.btn_sendData.Click += new System.EventHandler(this.btn_sendData_Click);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(265, 310);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(16, 13);
            this.lbl_estado.TabIndex = 13;
            this.lbl_estado.Text = "...";
            // 
            // btn_reiniciarServer
            // 
            this.btn_reiniciarServer.Location = new System.Drawing.Point(326, 11);
            this.btn_reiniciarServer.Name = "btn_reiniciarServer";
            this.btn_reiniciarServer.Size = new System.Drawing.Size(100, 20);
            this.btn_reiniciarServer.TabIndex = 14;
            this.btn_reiniciarServer.Text = "Reiniciar Servidor";
            this.btn_reiniciarServer.UseVisualStyleBackColor = true;
            // 
            // txt_chat
            // 
            this.txt_chat.Location = new System.Drawing.Point(11, 76);
            this.txt_chat.Name = "txt_chat";
            this.txt_chat.Size = new System.Drawing.Size(415, 115);
            this.txt_chat.TabIndex = 15;
            this.txt_chat.Text = "";
            // 
            // btn_ClientConect
            // 
            this.btn_ClientConect.Location = new System.Drawing.Point(326, 231);
            this.btn_ClientConect.Name = "btn_ClientConect";
            this.btn_ClientConect.Size = new System.Drawing.Size(100, 20);
            this.btn_ClientConect.TabIndex = 16;
            this.btn_ClientConect.Text = "Conectar";
            this.btn_ClientConect.UseVisualStyleBackColor = true;
            this.btn_ClientConect.Click += new System.EventHandler(this.btn_ClientConect_Click);
            // 
            // lbl_ClientIp
            // 
            this.lbl_ClientIp.AutoSize = true;
            this.lbl_ClientIp.Location = new System.Drawing.Point(136, 235);
            this.lbl_ClientIp.Name = "lbl_ClientIp";
            this.lbl_ClientIp.Size = new System.Drawing.Size(19, 13);
            this.lbl_ClientIp.TabIndex = 17;
            this.lbl_ClientIp.Text = "Ip:";
            // 
            // txt_ClientIp
            // 
            this.txt_ClientIp.Location = new System.Drawing.Point(167, 231);
            this.txt_ClientIp.Name = "txt_ClientIp";
            this.txt_ClientIp.Size = new System.Drawing.Size(153, 20);
            this.txt_ClientIp.TabIndex = 18;
            this.txt_ClientIp.Text = "127.0.0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 348);
            this.Controls.Add(this.txt_ClientIp);
            this.Controls.Add(this.lbl_ClientIp);
            this.Controls.Add(this.btn_ClientConect);
            this.Controls.Add(this.txt_chat);
            this.Controls.Add(this.btn_reiniciarServer);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.btn_sendData);
            this.Controls.Add(this.btn_sendChat);
            this.Controls.Add(this.lbl_ClientPort);
            this.Controls.Add(this.txt_ClientPort);
            this.Controls.Add(this.txt_ClientChatMessage);
            this.Controls.Add(this.txt_ServerDataName);
            this.Controls.Add(this.txt_ServerDataPort);
            this.Controls.Add(this.txt_ServerChatPort);
            this.Controls.Add(this.lbl_nomData);
            this.Controls.Add(this.lbl_portData);
            this.Controls.Add(this.lbl_portChat);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "TCP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_portChat;
        private System.Windows.Forms.Label lbl_portData;
        private System.Windows.Forms.Label lbl_nomData;
        private System.Windows.Forms.TextBox txt_ServerChatPort;
        private System.Windows.Forms.TextBox txt_ServerDataPort;
        private System.Windows.Forms.TextBox txt_ServerDataName;
        private System.Windows.Forms.TextBox txt_ClientChatMessage;
        private System.Windows.Forms.TextBox txt_ClientPort;
        private System.Windows.Forms.Label lbl_ClientPort;
        private System.Windows.Forms.Button btn_sendChat;
        private System.Windows.Forms.Button btn_sendData;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Button btn_reiniciarServer;
        private System.Windows.Forms.RichTextBox txt_chat;
        private System.Windows.Forms.Button btn_ClientConect;
        private System.Windows.Forms.Label lbl_ClientIp;
        private System.Windows.Forms.TextBox txt_ClientIp;
    }
}


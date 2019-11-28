namespace RecepcióComandes
{
    partial class RecepcióDeComandes
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
            this.lbl_Servidor = new System.Windows.Forms.Label();
            this.txtb_Servidor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.txtb_user = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.txtb_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_puerto = new System.Windows.Forms.Label();
            this.txtb_puerto = new System.Windows.Forms.TextBox();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Servidor
            // 
            this.lbl_Servidor.AutoSize = true;
            this.lbl_Servidor.Location = new System.Drawing.Point(6, 16);
            this.lbl_Servidor.Name = "lbl_Servidor";
            this.lbl_Servidor.Size = new System.Drawing.Size(49, 13);
            this.lbl_Servidor.TabIndex = 0;
            this.lbl_Servidor.Text = "Servidor:";
            // 
            // txtb_Servidor
            // 
            this.txtb_Servidor.Location = new System.Drawing.Point(61, 13);
            this.txtb_Servidor.Name = "txtb_Servidor";
            this.txtb_Servidor.Size = new System.Drawing.Size(110, 20);
            this.txtb_Servidor.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_conectar);
            this.groupBox1.Controls.Add(this.txtb_puerto);
            this.groupBox1.Controls.Add(this.lbl_puerto);
            this.groupBox1.Controls.Add(this.txtb_contraseña);
            this.groupBox1.Controls.Add(this.lbl_Contraseña);
            this.groupBox1.Controls.Add(this.txtb_user);
            this.groupBox1.Controls.Add(this.lbl_Usuario);
            this.groupBox1.Controls.Add(this.lbl_Servidor);
            this.groupBox1.Controls.Add(this.txtb_Servidor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(209, 16);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(46, 13);
            this.lbl_Usuario.TabIndex = 2;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // txtb_user
            // 
            this.txtb_user.Location = new System.Drawing.Point(261, 13);
            this.txtb_user.Name = "txtb_user";
            this.txtb_user.Size = new System.Drawing.Size(104, 20);
            this.txtb_user.TabIndex = 2;
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(403, 16);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(64, 13);
            this.lbl_Contraseña.TabIndex = 3;
            this.lbl_Contraseña.Text = "Contraseña:";
            // 
            // txtb_contraseña
            // 
            this.txtb_contraseña.Location = new System.Drawing.Point(473, 13);
            this.txtb_contraseña.Name = "txtb_contraseña";
            this.txtb_contraseña.PasswordChar = '*';
            this.txtb_contraseña.Size = new System.Drawing.Size(100, 20);
            this.txtb_contraseña.TabIndex = 3;
            // 
            // lbl_puerto
            // 
            this.lbl_puerto.AutoSize = true;
            this.lbl_puerto.Location = new System.Drawing.Point(607, 16);
            this.lbl_puerto.Name = "lbl_puerto";
            this.lbl_puerto.Size = new System.Drawing.Size(41, 13);
            this.lbl_puerto.TabIndex = 4;
            this.lbl_puerto.Text = "Puerto:";
            // 
            // txtb_puerto
            // 
            this.txtb_puerto.Location = new System.Drawing.Point(654, 13);
            this.txtb_puerto.Name = "txtb_puerto";
            this.txtb_puerto.Size = new System.Drawing.Size(100, 20);
            this.txtb_puerto.TabIndex = 4;
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(775, 11);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_conectar.TabIndex = 5;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // RecepcióDeComandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "RecepcióDeComandes";
            this.Text = "Recepció de comandes";
            this.Load += new System.EventHandler(this.RecepcióDeComandes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Servidor;
        private System.Windows.Forms.TextBox txtb_Servidor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.TextBox txtb_puerto;
        private System.Windows.Forms.Label lbl_puerto;
        private System.Windows.Forms.TextBox txtb_contraseña;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.TextBox txtb_user;
        private System.Windows.Forms.Label lbl_Usuario;
    }
}


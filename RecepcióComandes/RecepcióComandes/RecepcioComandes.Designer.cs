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
            this.cbx_Impresora = new System.Windows.Forms.ComboBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_impresora = new System.Windows.Forms.Label();
            this.txtb_Puerto = new System.Windows.Forms.TextBox();
            this.lbl_puerto = new System.Windows.Forms.Label();
            this.txtb_Contraseña = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.txtb_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.ptb_maximize = new System.Windows.Forms.PictureBox();
            this.ptb_minimize = new System.Windows.Forms.PictureBox();
            this.ptb_close = new System.Windows.Forms.PictureBox();
            this.VisorArchivos = new System.Windows.Forms.TreeView();
            this.txtb_RutaCarpetaDescargas = new System.Windows.Forms.TextBox();
            this.lbl_RutaGuardar = new System.Windows.Forms.Label();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_Processar = new System.Windows.Forms.Button();
            this.btn_CambiarCarpetaDescargas = new System.Windows.Forms.Button();
            this.lbl_ServidorFTP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.barraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Servidor
            // 
            this.lbl_Servidor.AutoSize = true;
            this.lbl_Servidor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Servidor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Servidor.Location = new System.Drawing.Point(17, 20);
            this.lbl_Servidor.Name = "lbl_Servidor";
            this.lbl_Servidor.Size = new System.Drawing.Size(64, 18);
            this.lbl_Servidor.TabIndex = 0;
            this.lbl_Servidor.Text = "Servidor:";
            // 
            // txtb_Servidor
            // 
            this.txtb_Servidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.txtb_Servidor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtb_Servidor.ForeColor = System.Drawing.SystemColors.Window;
            this.txtb_Servidor.Location = new System.Drawing.Point(87, 17);
            this.txtb_Servidor.Name = "txtb_Servidor";
            this.txtb_Servidor.Size = new System.Drawing.Size(110, 26);
            this.txtb_Servidor.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbx_Impresora);
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Controls.Add(this.lbl_impresora);
            this.groupBox1.Controls.Add(this.txtb_Puerto);
            this.groupBox1.Controls.Add(this.lbl_puerto);
            this.groupBox1.Controls.Add(this.txtb_Contraseña);
            this.groupBox1.Controls.Add(this.lbl_Contraseña);
            this.groupBox1.Controls.Add(this.txtb_Usuario);
            this.groupBox1.Controls.Add(this.lbl_Usuario);
            this.groupBox1.Controls.Add(this.lbl_Servidor);
            this.groupBox1.Controls.Add(this.txtb_Servidor);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1116, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbx_Impresora
            // 
            this.cbx_Impresora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.cbx_Impresora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_Impresora.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx_Impresora.FormattingEnabled = true;
            this.cbx_Impresora.Location = new System.Drawing.Point(876, 20);
            this.cbx_Impresora.Name = "cbx_Impresora";
            this.cbx_Impresora.Size = new System.Drawing.Size(100, 21);
            this.cbx_Impresora.TabIndex = 5;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Guardar.Location = new System.Drawing.Point(1020, 17);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(86, 30);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_impresora
            // 
            this.lbl_impresora.AutoSize = true;
            this.lbl_impresora.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_impresora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_impresora.Location = new System.Drawing.Point(795, 20);
            this.lbl_impresora.Name = "lbl_impresora";
            this.lbl_impresora.Size = new System.Drawing.Size(75, 18);
            this.lbl_impresora.TabIndex = 6;
            this.lbl_impresora.Text = "Impresora:";
            // 
            // txtb_Puerto
            // 
            this.txtb_Puerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.txtb_Puerto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtb_Puerto.ForeColor = System.Drawing.Color.White;
            this.txtb_Puerto.Location = new System.Drawing.Point(671, 17);
            this.txtb_Puerto.Name = "txtb_Puerto";
            this.txtb_Puerto.Size = new System.Drawing.Size(100, 26);
            this.txtb_Puerto.TabIndex = 4;
            // 
            // lbl_puerto
            // 
            this.lbl_puerto.AutoSize = true;
            this.lbl_puerto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_puerto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_puerto.Location = new System.Drawing.Point(611, 20);
            this.lbl_puerto.Name = "lbl_puerto";
            this.lbl_puerto.Size = new System.Drawing.Size(54, 18);
            this.lbl_puerto.TabIndex = 4;
            this.lbl_puerto.Text = "Puerto:";
            // 
            // txtb_Contraseña
            // 
            this.txtb_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.txtb_Contraseña.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtb_Contraseña.ForeColor = System.Drawing.Color.White;
            this.txtb_Contraseña.Location = new System.Drawing.Point(490, 17);
            this.txtb_Contraseña.Name = "txtb_Contraseña";
            this.txtb_Contraseña.PasswordChar = '■';
            this.txtb_Contraseña.Size = new System.Drawing.Size(100, 26);
            this.txtb_Contraseña.TabIndex = 3;
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Contraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Contraseña.Location = new System.Drawing.Point(402, 20);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(82, 18);
            this.lbl_Contraseña.TabIndex = 3;
            this.lbl_Contraseña.Text = "Contraseña:";
            // 
            // txtb_Usuario
            // 
            this.txtb_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.txtb_Usuario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtb_Usuario.ForeColor = System.Drawing.SystemColors.Window;
            this.txtb_Usuario.Location = new System.Drawing.Point(278, 17);
            this.txtb_Usuario.Name = "txtb_Usuario";
            this.txtb_Usuario.Size = new System.Drawing.Size(104, 26);
            this.txtb_Usuario.TabIndex = 2;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Usuario.Location = new System.Drawing.Point(212, 20);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(60, 18);
            this.lbl_Usuario.TabIndex = 2;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.barraSuperior.Controls.Add(this.ptb_maximize);
            this.barraSuperior.Controls.Add(this.ptb_minimize);
            this.barraSuperior.Controls.Add(this.ptb_close);
            this.barraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(1152, 35);
            this.barraSuperior.TabIndex = 7;
            // 
            // ptb_maximize
            // 
            this.ptb_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ptb_maximize.Location = new System.Drawing.Point(1083, 0);
            this.ptb_maximize.Name = "ptb_maximize";
            this.ptb_maximize.Padding = new System.Windows.Forms.Padding(9, 10, 9, 8);
            this.ptb_maximize.Size = new System.Drawing.Size(35, 35);
            this.ptb_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_maximize.TabIndex = 11;
            this.ptb_maximize.TabStop = false;
            // 
            // ptb_minimize
            // 
            this.ptb_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ptb_minimize.Location = new System.Drawing.Point(1048, 0);
            this.ptb_minimize.Name = "ptb_minimize";
            this.ptb_minimize.Size = new System.Drawing.Size(35, 35);
            this.ptb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_minimize.TabIndex = 0;
            this.ptb_minimize.TabStop = false;
            // 
            // ptb_close
            // 
            this.ptb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ptb_close.Location = new System.Drawing.Point(1118, 0);
            this.ptb_close.Name = "ptb_close";
            this.ptb_close.Size = new System.Drawing.Size(35, 35);
            this.ptb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_close.TabIndex = 0;
            this.ptb_close.TabStop = false;
            // 
            // VisorArchivos
            // 
            this.VisorArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VisorArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.VisorArchivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisorArchivos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisorArchivos.ForeColor = System.Drawing.SystemColors.Window;
            this.VisorArchivos.LineColor = System.Drawing.Color.White;
            this.VisorArchivos.Location = new System.Drawing.Point(12, 137);
            this.VisorArchivos.Name = "VisorArchivos";
            this.VisorArchivos.PathSeparator = "/";
            this.VisorArchivos.Size = new System.Drawing.Size(382, 496);
            this.VisorArchivos.TabIndex = 1;
            // 
            // txtb_RutaCarpetaDescargas
            // 
            this.txtb_RutaCarpetaDescargas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_RutaCarpetaDescargas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.txtb_RutaCarpetaDescargas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtb_RutaCarpetaDescargas.ForeColor = System.Drawing.SystemColors.Window;
            this.txtb_RutaCarpetaDescargas.Location = new System.Drawing.Point(12, 657);
            this.txtb_RutaCarpetaDescargas.Name = "txtb_RutaCarpetaDescargas";
            this.txtb_RutaCarpetaDescargas.ReadOnly = true;
            this.txtb_RutaCarpetaDescargas.Size = new System.Drawing.Size(1075, 26);
            this.txtb_RutaCarpetaDescargas.TabIndex = 5;
            // 
            // lbl_RutaGuardar
            // 
            this.lbl_RutaGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_RutaGuardar.AutoSize = true;
            this.lbl_RutaGuardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_RutaGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_RutaGuardar.Location = new System.Drawing.Point(9, 636);
            this.lbl_RutaGuardar.Name = "lbl_RutaGuardar";
            this.lbl_RutaGuardar.Size = new System.Drawing.Size(319, 18);
            this.lbl_RutaGuardar.TabIndex = 6;
            this.lbl_RutaGuardar.Text = "Ruta donde se guardarán los archivos descargados:";
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Check.Location = new System.Drawing.Point(417, 137);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(86, 30);
            this.btn_Check.TabIndex = 3;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_Processar
            // 
            this.btn_Processar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_Processar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Processar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Processar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Processar.Location = new System.Drawing.Point(509, 137);
            this.btn_Processar.Name = "btn_Processar";
            this.btn_Processar.Size = new System.Drawing.Size(86, 30);
            this.btn_Processar.TabIndex = 4;
            this.btn_Processar.Text = "Procesar";
            this.btn_Processar.UseVisualStyleBackColor = false;
            // 
            // btn_CambiarCarpetaDescargas
            // 
            this.btn_CambiarCarpetaDescargas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CambiarCarpetaDescargas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_CambiarCarpetaDescargas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CambiarCarpetaDescargas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CambiarCarpetaDescargas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CambiarCarpetaDescargas.Location = new System.Drawing.Point(1093, 657);
            this.btn_CambiarCarpetaDescargas.Name = "btn_CambiarCarpetaDescargas";
            this.btn_CambiarCarpetaDescargas.Size = new System.Drawing.Size(35, 26);
            this.btn_CambiarCarpetaDescargas.TabIndex = 6;
            this.btn_CambiarCarpetaDescargas.Text = "...";
            this.btn_CambiarCarpetaDescargas.UseVisualStyleBackColor = false;
            this.btn_CambiarCarpetaDescargas.Click += new System.EventHandler(this.btn_CambiarCarpetaDescargas_Click);
            // 
            // lbl_ServidorFTP
            // 
            this.lbl_ServidorFTP.AutoSize = true;
            this.lbl_ServidorFTP.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ServidorFTP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ServidorFTP.Location = new System.Drawing.Point(9, 116);
            this.lbl_ServidorFTP.Name = "lbl_ServidorFTP";
            this.lbl_ServidorFTP.Size = new System.Drawing.Size(145, 18);
            this.lbl_ServidorFTP.TabIndex = 11;
            this.lbl_ServidorFTP.Text = "Archivos y directorios:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(637, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "asdasd";
            // 
            // RecepcióDeComandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1152, 695);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ServidorFTP);
            this.Controls.Add(this.btn_CambiarCarpetaDescargas);
            this.Controls.Add(this.btn_Processar);
            this.Controls.Add(this.barraSuperior);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.lbl_RutaGuardar);
            this.Controls.Add(this.txtb_RutaCarpetaDescargas);
            this.Controls.Add(this.VisorArchivos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecepcióDeComandes";
            this.Text = "Recepció de comandes";
            this.Load += new System.EventHandler(this.RecepcióDeComandes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.barraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Servidor;
        private System.Windows.Forms.TextBox txtb_Servidor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txtb_Puerto;
        private System.Windows.Forms.Label lbl_puerto;
        private System.Windows.Forms.TextBox txtb_Contraseña;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.TextBox txtb_Usuario;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.PictureBox ptb_maximize;
        private System.Windows.Forms.PictureBox ptb_minimize;
        private System.Windows.Forms.PictureBox ptb_close;
        private System.Windows.Forms.TreeView VisorArchivos;
        private System.Windows.Forms.TextBox txtb_RutaCarpetaDescargas;
        private System.Windows.Forms.Label lbl_RutaGuardar;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_Processar;
        private System.Windows.Forms.Button btn_CambiarCarpetaDescargas;
        private System.Windows.Forms.ComboBox cbx_Impresora;
        private System.Windows.Forms.Label lbl_impresora;
        private System.Windows.Forms.Label lbl_ServidorFTP;
        private System.Windows.Forms.Label label1;
    }
}


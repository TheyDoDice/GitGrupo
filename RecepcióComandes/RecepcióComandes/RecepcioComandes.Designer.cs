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
            this.components = new System.ComponentModel.Container();
            this.lbl_Servidor = new System.Windows.Forms.Label();
            this.txtb_Servidor = new System.Windows.Forms.TextBox();
            this.gbx_credenciales = new System.Windows.Forms.GroupBox();
            this.cbx_Impresora = new System.Windows.Forms.ComboBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_impresora = new System.Windows.Forms.Label();
            this.txtb_Puerto = new System.Windows.Forms.TextBox();
            this.lbl_puerto = new System.Windows.Forms.Label();
            this.txtb_Contraseña = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.txtb_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.txtb_RutaCarpetaDescargas = new System.Windows.Forms.TextBox();
            this.lbl_RutaGuardar = new System.Windows.Forms.Label();
            this.btn_CambiarCarpetaDescargas = new System.Windows.Forms.Button();
            this.lbl_ServidorFTP = new System.Windows.Forms.Label();
            this.lbl_consola = new System.Windows.Forms.Label();
            this.lbl_text_hora = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.tmr_hora = new System.Windows.Forms.Timer(this.components);
            this.lbl_text_fecha = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.VisorArchivos = new System.Windows.Forms.TreeView();
            this.pnl_consola = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbx_credenciales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            // gbx_credenciales
            // 
            this.gbx_credenciales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_credenciales.Controls.Add(this.cbx_Impresora);
            this.gbx_credenciales.Controls.Add(this.btn_Guardar);
            this.gbx_credenciales.Controls.Add(this.lbl_impresora);
            this.gbx_credenciales.Controls.Add(this.txtb_Puerto);
            this.gbx_credenciales.Controls.Add(this.lbl_puerto);
            this.gbx_credenciales.Controls.Add(this.txtb_Contraseña);
            this.gbx_credenciales.Controls.Add(this.lbl_Contraseña);
            this.gbx_credenciales.Controls.Add(this.txtb_Usuario);
            this.gbx_credenciales.Controls.Add(this.lbl_Usuario);
            this.gbx_credenciales.Controls.Add(this.lbl_Servidor);
            this.gbx_credenciales.Controls.Add(this.txtb_Servidor);
            this.gbx_credenciales.Location = new System.Drawing.Point(12, 41);
            this.gbx_credenciales.Name = "gbx_credenciales";
            this.gbx_credenciales.Size = new System.Drawing.Size(1174, 58);
            this.gbx_credenciales.TabIndex = 0;
            this.gbx_credenciales.TabStop = false;
            // 
            // cbx_Impresora
            // 
            this.cbx_Impresora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.cbx_Impresora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_Impresora.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbx_Impresora.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx_Impresora.FormattingEnabled = true;
            this.cbx_Impresora.Location = new System.Drawing.Point(876, 17);
            this.cbx_Impresora.Name = "cbx_Impresora";
            this.cbx_Impresora.Size = new System.Drawing.Size(184, 26);
            this.cbx_Impresora.TabIndex = 5;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Guardar.Location = new System.Drawing.Point(1082, 13);
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
            // txtb_RutaCarpetaDescargas
            // 
            this.txtb_RutaCarpetaDescargas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_RutaCarpetaDescargas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.txtb_RutaCarpetaDescargas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtb_RutaCarpetaDescargas.ForeColor = System.Drawing.SystemColors.Window;
            this.txtb_RutaCarpetaDescargas.Location = new System.Drawing.Point(12, 580);
            this.txtb_RutaCarpetaDescargas.Name = "txtb_RutaCarpetaDescargas";
            this.txtb_RutaCarpetaDescargas.ReadOnly = true;
            this.txtb_RutaCarpetaDescargas.Size = new System.Drawing.Size(1133, 26);
            this.txtb_RutaCarpetaDescargas.TabIndex = 5;
            // 
            // lbl_RutaGuardar
            // 
            this.lbl_RutaGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_RutaGuardar.AutoSize = true;
            this.lbl_RutaGuardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_RutaGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_RutaGuardar.Location = new System.Drawing.Point(9, 559);
            this.lbl_RutaGuardar.Name = "lbl_RutaGuardar";
            this.lbl_RutaGuardar.Size = new System.Drawing.Size(319, 18);
            this.lbl_RutaGuardar.TabIndex = 6;
            this.lbl_RutaGuardar.Text = "Ruta donde se guardarán los archivos descargados:";
            // 
            // btn_CambiarCarpetaDescargas
            // 
            this.btn_CambiarCarpetaDescargas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CambiarCarpetaDescargas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_CambiarCarpetaDescargas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CambiarCarpetaDescargas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CambiarCarpetaDescargas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CambiarCarpetaDescargas.Location = new System.Drawing.Point(1151, 580);
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
            this.lbl_ServidorFTP.Location = new System.Drawing.Point(3, 0);
            this.lbl_ServidorFTP.Name = "lbl_ServidorFTP";
            this.lbl_ServidorFTP.Size = new System.Drawing.Size(145, 18);
            this.lbl_ServidorFTP.TabIndex = 11;
            this.lbl_ServidorFTP.Text = "Archivos y directorios:";
            // 
            // lbl_consola
            // 
            this.lbl_consola.AutoSize = true;
            this.lbl_consola.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_consola.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_consola.Location = new System.Drawing.Point(3, 0);
            this.lbl_consola.Name = "lbl_consola";
            this.lbl_consola.Size = new System.Drawing.Size(61, 18);
            this.lbl_consola.TabIndex = 13;
            this.lbl_consola.Text = "Consola:";
            this.lbl_consola.Click += new System.EventHandler(this.lbl_consola_Click);
            // 
            // lbl_text_hora
            // 
            this.lbl_text_hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_text_hora.AutoSize = true;
            this.lbl_text_hora.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_text_hora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_text_hora.Location = new System.Drawing.Point(657, -1);
            this.lbl_text_hora.Name = "lbl_text_hora";
            this.lbl_text_hora.Size = new System.Drawing.Size(41, 18);
            this.lbl_text_hora.TabIndex = 14;
            this.lbl_text_hora.Text = "Hora:";
            // 
            // lbl_hora
            // 
            this.lbl_hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_hora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_hora.Location = new System.Drawing.Point(695, -1);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(58, 18);
            this.lbl_hora.TabIndex = 15;
            this.lbl_hora.Text = "17:40:20";
            // 
            // tmr_hora
            // 
            this.tmr_hora.Enabled = true;
            this.tmr_hora.Tick += new System.EventHandler(this.tmr_hora_Tick);
            // 
            // lbl_text_fecha
            // 
            this.lbl_text_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_text_fecha.AutoSize = true;
            this.lbl_text_fecha.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_text_fecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_text_fecha.Location = new System.Drawing.Point(530, -1);
            this.lbl_text_fecha.Name = "lbl_text_fecha";
            this.lbl_text_fecha.Size = new System.Drawing.Size(48, 18);
            this.lbl_text_fecha.TabIndex = 16;
            this.lbl_text_fecha.Text = "Fecha:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_fecha.Location = new System.Drawing.Point(575, -1);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(76, 18);
            this.lbl_fecha.TabIndex = 17;
            this.lbl_fecha.Text = "13/12/2019";
            // 
            // VisorArchivos
            // 
            this.VisorArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VisorArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.VisorArchivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisorArchivos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisorArchivos.ForeColor = System.Drawing.SystemColors.Window;
            this.VisorArchivos.FullRowSelect = true;
            this.VisorArchivos.LineColor = System.Drawing.Color.White;
            this.VisorArchivos.Location = new System.Drawing.Point(3, 21);
            this.VisorArchivos.Name = "VisorArchivos";
            this.VisorArchivos.PathSeparator = "/";
            this.VisorArchivos.Size = new System.Drawing.Size(386, 429);
            this.VisorArchivos.TabIndex = 1;
            // 
            // pnl_consola
            // 
            this.pnl_consola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_consola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.pnl_consola.Location = new System.Drawing.Point(3, 20);
            this.pnl_consola.Name = "pnl_consola";
            this.pnl_consola.Size = new System.Drawing.Size(751, 431);
            this.pnl_consola.TabIndex = 12;
            this.pnl_consola.Resize += new System.EventHandler(this.pnl_consola_Resize);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 105);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.VisorArchivos);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_ServidorFTP);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnl_consola);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_fecha);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_consola);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_text_fecha);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_hora);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_text_hora);
            this.splitContainer1.Size = new System.Drawing.Size(1174, 451);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 18;
            // 
            // RecepcióDeComandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1198, 618);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btn_CambiarCarpetaDescargas);
            this.Controls.Add(this.lbl_RutaGuardar);
            this.Controls.Add(this.txtb_RutaCarpetaDescargas);
            this.Controls.Add(this.gbx_credenciales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecepcióDeComandes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepció de comandes";
            this.Load += new System.EventHandler(this.RecepcióDeComandes_Load);
            this.gbx_credenciales.ResumeLayout(false);
            this.gbx_credenciales.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Servidor;
        private System.Windows.Forms.TextBox txtb_Servidor;
        private System.Windows.Forms.GroupBox gbx_credenciales;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txtb_Puerto;
        private System.Windows.Forms.Label lbl_puerto;
        private System.Windows.Forms.TextBox txtb_Contraseña;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.TextBox txtb_Usuario;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.TextBox txtb_RutaCarpetaDescargas;
        private System.Windows.Forms.Label lbl_RutaGuardar;
        private System.Windows.Forms.Button btn_CambiarCarpetaDescargas;
        private System.Windows.Forms.ComboBox cbx_Impresora;
        private System.Windows.Forms.Label lbl_impresora;
        private System.Windows.Forms.Label lbl_ServidorFTP;
        private System.Windows.Forms.Label lbl_consola;
        private System.Windows.Forms.Label lbl_text_hora;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer tmr_hora;
        private System.Windows.Forms.Label lbl_text_fecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TreeView VisorArchivos;
        private System.Windows.Forms.Panel pnl_consola;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}


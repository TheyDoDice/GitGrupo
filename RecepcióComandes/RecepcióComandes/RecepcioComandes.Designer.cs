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
            this.btn_conectar = new System.Windows.Forms.Button();
            this.txtb_puerto = new System.Windows.Forms.TextBox();
            this.lbl_puerto = new System.Windows.Forms.Label();
            this.txtb_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.txtb_user = new System.Windows.Forms.TextBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.ptb_maximize = new System.Windows.Forms.PictureBox();
            this.ptb_minimize = new System.Windows.Forms.PictureBox();
            this.ptb_close = new System.Windows.Forms.PictureBox();
            this.VisorArchivos = new System.Windows.Forms.TreeView();
            this.txtb_ruta = new System.Windows.Forms.TextBox();
            this.lbl_RutaGuardar = new System.Windows.Forms.Label();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_Processar = new System.Windows.Forms.Button();
            this.btn_AbrirArchivos = new System.Windows.Forms.Button();
            this.btn_changeSavePath = new System.Windows.Forms.Button();
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
            this.lbl_Servidor.Location = new System.Drawing.Point(6, 20);
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
            this.txtb_Servidor.Location = new System.Drawing.Point(76, 17);
            this.txtb_Servidor.Name = "txtb_Servidor";
            this.txtb_Servidor.Size = new System.Drawing.Size(110, 26);
            this.txtb_Servidor.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_conectar);
            this.groupBox1.Controls.Add(this.txtb_puerto);
            this.groupBox1.Controls.Add(this.lbl_puerto);
            this.groupBox1.Controls.Add(this.txtb_contraseña);
            this.groupBox1.Controls.Add(this.lbl_Contraseña);
            this.groupBox1.Controls.Add(this.txtb_user);
            this.groupBox1.Controls.Add(this.lbl_Usuario);
            this.groupBox1.Controls.Add(this.lbl_Servidor);
            this.groupBox1.Controls.Add(this.txtb_Servidor);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_conectar
            // 
            this.btn_conectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_conectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conectar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_conectar.Location = new System.Drawing.Point(789, 15);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(86, 30);
            this.btn_conectar.TabIndex = 5;
            this.btn_conectar.Text = "Guardar";
            this.btn_conectar.UseVisualStyleBackColor = false;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // txtb_puerto
            // 
            this.txtb_puerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.txtb_puerto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtb_puerto.ForeColor = System.Drawing.Color.White;
            this.txtb_puerto.Location = new System.Drawing.Point(660, 17);
            this.txtb_puerto.Name = "txtb_puerto";
            this.txtb_puerto.Size = new System.Drawing.Size(100, 26);
            this.txtb_puerto.TabIndex = 4;
            // 
            // lbl_puerto
            // 
            this.lbl_puerto.AutoSize = true;
            this.lbl_puerto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_puerto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_puerto.Location = new System.Drawing.Point(600, 20);
            this.lbl_puerto.Name = "lbl_puerto";
            this.lbl_puerto.Size = new System.Drawing.Size(54, 18);
            this.lbl_puerto.TabIndex = 4;
            this.lbl_puerto.Text = "Puerto:";
            // 
            // txtb_contraseña
            // 
            this.txtb_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.txtb_contraseña.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtb_contraseña.ForeColor = System.Drawing.Color.White;
            this.txtb_contraseña.Location = new System.Drawing.Point(479, 17);
            this.txtb_contraseña.Name = "txtb_contraseña";
            this.txtb_contraseña.PasswordChar = '■';
            this.txtb_contraseña.Size = new System.Drawing.Size(100, 26);
            this.txtb_contraseña.TabIndex = 3;
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Contraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Contraseña.Location = new System.Drawing.Point(391, 20);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(82, 18);
            this.lbl_Contraseña.TabIndex = 3;
            this.lbl_Contraseña.Text = "Contraseña:";
            // 
            // txtb_user
            // 
            this.txtb_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.txtb_user.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtb_user.ForeColor = System.Drawing.SystemColors.Window;
            this.txtb_user.Location = new System.Drawing.Point(267, 17);
            this.txtb_user.Name = "txtb_user";
            this.txtb_user.Size = new System.Drawing.Size(104, 26);
            this.txtb_user.TabIndex = 2;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Usuario.Location = new System.Drawing.Point(201, 20);
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
            this.barraSuperior.Size = new System.Drawing.Size(917, 35);
            this.barraSuperior.TabIndex = 7;
            // 
            // ptb_maximize
            // 
            this.ptb_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ptb_maximize.Location = new System.Drawing.Point(848, 0);
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
            this.ptb_minimize.Location = new System.Drawing.Point(813, 0);
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
            this.ptb_close.Location = new System.Drawing.Point(883, 0);
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
            this.VisorArchivos.Enabled = false;
            this.VisorArchivos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisorArchivos.ForeColor = System.Drawing.SystemColors.Window;
            this.VisorArchivos.LineColor = System.Drawing.Color.White;
            this.VisorArchivos.Location = new System.Drawing.Point(12, 101);
            this.VisorArchivos.Name = "VisorArchivos";
            this.VisorArchivos.Size = new System.Drawing.Size(261, 364);
            this.VisorArchivos.TabIndex = 3;
            // 
            // txtb_ruta
            // 
            this.txtb_ruta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_ruta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.txtb_ruta.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtb_ruta.ForeColor = System.Drawing.SystemColors.Window;
            this.txtb_ruta.Location = new System.Drawing.Point(12, 489);
            this.txtb_ruta.Name = "txtb_ruta";
            this.txtb_ruta.Size = new System.Drawing.Size(836, 26);
            this.txtb_ruta.TabIndex = 5;
            this.txtb_ruta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtb_ruta_MouseClick);
            // 
            // lbl_RutaGuardar
            // 
            this.lbl_RutaGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_RutaGuardar.AutoSize = true;
            this.lbl_RutaGuardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_RutaGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_RutaGuardar.Location = new System.Drawing.Point(9, 468);
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
            this.btn_Check.Location = new System.Drawing.Point(451, 101);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(86, 30);
            this.btn_Check.TabIndex = 6;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_descargar_Click);
            // 
            // btn_Processar
            // 
            this.btn_Processar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_Processar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Processar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Processar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Processar.Location = new System.Drawing.Point(552, 101);
            this.btn_Processar.Name = "btn_Processar";
            this.btn_Processar.Size = new System.Drawing.Size(86, 30);
            this.btn_Processar.TabIndex = 8;
            this.btn_Processar.Text = "Procesar";
            this.btn_Processar.UseVisualStyleBackColor = false;
            // 
            // btn_AbrirArchivos
            // 
            this.btn_AbrirArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_AbrirArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AbrirArchivos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AbrirArchivos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AbrirArchivos.Location = new System.Drawing.Point(317, 101);
            this.btn_AbrirArchivos.Name = "btn_AbrirArchivos";
            this.btn_AbrirArchivos.Size = new System.Drawing.Size(118, 30);
            this.btn_AbrirArchivos.TabIndex = 9;
            this.btn_AbrirArchivos.Text = "Abrir Archivos";
            this.btn_AbrirArchivos.UseVisualStyleBackColor = false;
            // 
            // btn_changeSavePath
            // 
            this.btn_changeSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_changeSavePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_changeSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changeSavePath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changeSavePath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_changeSavePath.Location = new System.Drawing.Point(858, 485);
            this.btn_changeSavePath.Name = "btn_changeSavePath";
            this.btn_changeSavePath.Size = new System.Drawing.Size(35, 30);
            this.btn_changeSavePath.TabIndex = 6;
            this.btn_changeSavePath.Text = "...";
            this.btn_changeSavePath.UseVisualStyleBackColor = false;
            // 
            // RecepcióDeComandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(917, 527);
            this.Controls.Add(this.btn_changeSavePath);
            this.Controls.Add(this.btn_AbrirArchivos);
            this.Controls.Add(this.btn_Processar);
            this.Controls.Add(this.barraSuperior);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.lbl_RutaGuardar);
            this.Controls.Add(this.txtb_ruta);
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
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.TextBox txtb_puerto;
        private System.Windows.Forms.Label lbl_puerto;
        private System.Windows.Forms.TextBox txtb_contraseña;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.TextBox txtb_user;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.PictureBox ptb_maximize;
        private System.Windows.Forms.PictureBox ptb_minimize;
        private System.Windows.Forms.PictureBox ptb_close;
        private System.Windows.Forms.TreeView VisorArchivos;
        private System.Windows.Forms.TextBox txtb_ruta;
        private System.Windows.Forms.Label lbl_RutaGuardar;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_Processar;
        private System.Windows.Forms.Button btn_AbrirArchivos;
        private System.Windows.Forms.Button btn_changeSavePath;
    }
}


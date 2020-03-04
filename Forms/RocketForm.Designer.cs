namespace Forms
{
    partial class RocketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RocketForm));
            this.bttn_peticion = new System.Windows.Forms.Button();
            this.bttn_downloadCodificacion = new System.Windows.Forms.Button();
            this.bttn_obtenirValidationCode = new System.Windows.Forms.Button();
            this.bttn_EntregarPaquetes = new System.Windows.Forms.Button();
            this.bttn_DescodificarrPaquetes = new System.Windows.Forms.Button();
            this.btn_enviarMensajeEncriptado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_background = new System.Windows.Forms.PictureBox();
            this.tbx_console = new System.Windows.Forms.RichTextBox();
            this.txb_input = new System.Windows.Forms.TextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.lbl_state = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_background)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_peticion
            // 
            this.bttn_peticion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttn_peticion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_peticion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_peticion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttn_peticion.Location = new System.Drawing.Point(477, 574);
            this.bttn_peticion.Name = "bttn_peticion";
            this.bttn_peticion.Size = new System.Drawing.Size(69, 74);
            this.bttn_peticion.TabIndex = 0;
            this.bttn_peticion.UseVisualStyleBackColor = false;
            this.bttn_peticion.Click += new System.EventHandler(this.bttn_peticion_Click);
            // 
            // bttn_downloadCodificacion
            // 
            this.bttn_downloadCodificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_downloadCodificacion.BackColor = System.Drawing.Color.DimGray;
            this.bttn_downloadCodificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_downloadCodificacion.Location = new System.Drawing.Point(942, 665);
            this.bttn_downloadCodificacion.Name = "bttn_downloadCodificacion";
            this.bttn_downloadCodificacion.Size = new System.Drawing.Size(177, 57);
            this.bttn_downloadCodificacion.TabIndex = 1;
            this.bttn_downloadCodificacion.UseVisualStyleBackColor = false;
            this.bttn_downloadCodificacion.Click += new System.EventHandler(this.bttn_downloadCodificacion_Click);
            // 
            // bttn_obtenirValidationCode
            // 
            this.bttn_obtenirValidationCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_obtenirValidationCode.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_obtenirValidationCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_obtenirValidationCode.Location = new System.Drawing.Point(966, 576);
            this.bttn_obtenirValidationCode.Name = "bttn_obtenirValidationCode";
            this.bttn_obtenirValidationCode.Size = new System.Drawing.Size(90, 70);
            this.bttn_obtenirValidationCode.TabIndex = 2;
            this.bttn_obtenirValidationCode.UseVisualStyleBackColor = false;
            this.bttn_obtenirValidationCode.Click += new System.EventHandler(this.bttn_obtenirValidationCode_Click);
            // 
            // bttn_EntregarPaquetes
            // 
            this.bttn_EntregarPaquetes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_EntregarPaquetes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_EntregarPaquetes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_EntregarPaquetes.Location = new System.Drawing.Point(777, 743);
            this.bttn_EntregarPaquetes.Name = "bttn_EntregarPaquetes";
            this.bttn_EntregarPaquetes.Size = new System.Drawing.Size(70, 70);
            this.bttn_EntregarPaquetes.TabIndex = 3;
            this.bttn_EntregarPaquetes.UseVisualStyleBackColor = false;
            this.bttn_EntregarPaquetes.Click += new System.EventHandler(this.bttn_EntregarPaquetes_Click);
            // 
            // bttn_DescodificarrPaquetes
            // 
            this.bttn_DescodificarrPaquetes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttn_DescodificarrPaquetes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_DescodificarrPaquetes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_DescodificarrPaquetes.Location = new System.Drawing.Point(633, 743);
            this.bttn_DescodificarrPaquetes.Name = "bttn_DescodificarrPaquetes";
            this.bttn_DescodificarrPaquetes.Size = new System.Drawing.Size(70, 70);
            this.bttn_DescodificarrPaquetes.TabIndex = 4;
            this.bttn_DescodificarrPaquetes.UseVisualStyleBackColor = false;
            this.bttn_DescodificarrPaquetes.Click += new System.EventHandler(this.bttn_DescodificarrPaquetes_Click);
            // 
            // btn_enviarMensajeEncriptado
            // 
            this.btn_enviarMensajeEncriptado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_enviarMensajeEncriptado.BackColor = System.Drawing.Color.DimGray;
            this.btn_enviarMensajeEncriptado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enviarMensajeEncriptado.Location = new System.Drawing.Point(890, 574);
            this.btn_enviarMensajeEncriptado.Name = "btn_enviarMensajeEncriptado";
            this.btn_enviarMensajeEncriptado.Size = new System.Drawing.Size(70, 70);
            this.btn_enviarMensajeEncriptado.TabIndex = 5;
            this.btn_enviarMensajeEncriptado.UseVisualStyleBackColor = false;
            this.btn_enviarMensajeEncriptado.Click += new System.EventHandler(this.btn_enviarMensajeEncriptado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // ptb_background
            // 
            this.ptb_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_background.Image = ((System.Drawing.Image)(resources.GetObject("ptb_background.Image")));
            this.ptb_background.Location = new System.Drawing.Point(0, 0);
            this.ptb_background.Name = "ptb_background";
            this.ptb_background.Size = new System.Drawing.Size(1530, 830);
            this.ptb_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_background.TabIndex = 7;
            this.ptb_background.TabStop = false;
            // 
            // tbx_console
            // 
            this.tbx_console.Location = new System.Drawing.Point(556, 383);
            this.tbx_console.Name = "tbx_console";
            this.tbx_console.Size = new System.Drawing.Size(388, 135);
            this.tbx_console.TabIndex = 8;
            this.tbx_console.Text = "";
            // 
            // txb_input
            // 
            this.txb_input.Location = new System.Drawing.Point(556, 525);
            this.txb_input.Name = "txb_input";
            this.txb_input.Size = new System.Drawing.Size(321, 20);
            this.txb_input.TabIndex = 9;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(883, 525);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(61, 20);
            this.btn_input.TabIndex = 10;
            this.btn_input.Text = "button1";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(29, 29);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(35, 13);
            this.lbl_state.TabIndex = 11;
            this.lbl_state.Text = "label2";
            // 
            // RocketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1530, 830);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.txb_input);
            this.Controls.Add(this.tbx_console);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_enviarMensajeEncriptado);
            this.Controls.Add(this.bttn_DescodificarrPaquetes);
            this.Controls.Add(this.bttn_EntregarPaquetes);
            this.Controls.Add(this.bttn_obtenirValidationCode);
            this.Controls.Add(this.bttn_downloadCodificacion);
            this.Controls.Add(this.bttn_peticion);
            this.Controls.Add(this.ptb_background);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "RocketForm";
            this.Text = "Rocket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RocketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_peticion;
        private System.Windows.Forms.Button bttn_downloadCodificacion;
        private System.Windows.Forms.Button bttn_obtenirValidationCode;
        private System.Windows.Forms.Button bttn_EntregarPaquetes;
        private System.Windows.Forms.Button bttn_DescodificarrPaquetes;
        private System.Windows.Forms.Button btn_enviarMensajeEncriptado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptb_background;
        private System.Windows.Forms.RichTextBox tbx_console;
        private System.Windows.Forms.TextBox txb_input;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.Label lbl_state;
    }
}
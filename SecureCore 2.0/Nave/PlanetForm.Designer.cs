namespace Nave
{
    partial class frm_nave
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
            this.pnl_enviar_datos = new System.Windows.Forms.Panel();
            this.btn_EnviarInput = new System.Windows.Forms.Button();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.lbl_btn_entregar_datos = new System.Windows.Forms.Label();
            this.lbl_btn_preparar_datos = new System.Windows.Forms.Label();
            this.btn_entregar_datos = new System.Windows.Forms.PictureBox();
            this.btn_preparar_datos = new System.Windows.Forms.PictureBox();
            this.pb_planeta = new System.Windows.Forms.PictureBox();
            this.pb_naves = new System.Windows.Forms.PictureBox();
            this.lbl_btn_verificar = new System.Windows.Forms.Label();
            this.btn_verificar = new System.Windows.Forms.PictureBox();
            this.lbl_state = new System.Windows.Forms.Label();
            this.txtb_consola = new System.Windows.Forms.RichTextBox();
            this.btn_EnviarData = new System.Windows.Forms.Button();
            this.pnl_enviar_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_entregar_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_preparar_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_planeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_naves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_verificar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_enviar_datos
            // 
            this.pnl_enviar_datos.BackColor = System.Drawing.Color.Black;
            this.pnl_enviar_datos.BackgroundImage = global::Planet.Properties.Resources._5e456a7764864_1581607562_5e456a77647fb;
            this.pnl_enviar_datos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_enviar_datos.Controls.Add(this.btn_EnviarData);
            this.pnl_enviar_datos.Controls.Add(this.txtb_consola);
            this.pnl_enviar_datos.Controls.Add(this.lbl_state);
            this.pnl_enviar_datos.Controls.Add(this.btn_EnviarInput);
            this.pnl_enviar_datos.Controls.Add(this.txt_Input);
            this.pnl_enviar_datos.Controls.Add(this.lbl_btn_entregar_datos);
            this.pnl_enviar_datos.Controls.Add(this.lbl_btn_preparar_datos);
            this.pnl_enviar_datos.Controls.Add(this.btn_entregar_datos);
            this.pnl_enviar_datos.Controls.Add(this.btn_preparar_datos);
            this.pnl_enviar_datos.Controls.Add(this.pb_planeta);
            this.pnl_enviar_datos.Controls.Add(this.pb_naves);
            this.pnl_enviar_datos.Controls.Add(this.lbl_btn_verificar);
            this.pnl_enviar_datos.Controls.Add(this.btn_verificar);
            this.pnl_enviar_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_enviar_datos.Location = new System.Drawing.Point(0, 0);
            this.pnl_enviar_datos.Name = "pnl_enviar_datos";
            this.pnl_enviar_datos.Size = new System.Drawing.Size(1530, 830);
            this.pnl_enviar_datos.TabIndex = 2;
            // 
            // btn_EnviarInput
            // 
            this.btn_EnviarInput.Location = new System.Drawing.Point(1231, 609);
            this.btn_EnviarInput.Name = "btn_EnviarInput";
            this.btn_EnviarInput.Size = new System.Drawing.Size(87, 25);
            this.btn_EnviarInput.TabIndex = 52;
            this.btn_EnviarInput.Text = "Send Message";
            this.btn_EnviarInput.UseVisualStyleBackColor = true;
            this.btn_EnviarInput.Click += new System.EventHandler(this.btn_EnviarInput_Click);
            // 
            // txt_Input
            // 
            this.txt_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Input.Location = new System.Drawing.Point(698, 609);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(486, 24);
            this.txt_Input.TabIndex = 51;
            // 
            // lbl_btn_entregar_datos
            // 
            this.lbl_btn_entregar_datos.AutoSize = true;
            this.lbl_btn_entregar_datos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_btn_entregar_datos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_btn_entregar_datos.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_btn_entregar_datos.Location = new System.Drawing.Point(339, 499);
            this.lbl_btn_entregar_datos.Name = "lbl_btn_entregar_datos";
            this.lbl_btn_entregar_datos.Size = new System.Drawing.Size(75, 16);
            this.lbl_btn_entregar_datos.TabIndex = 3;
            this.lbl_btn_entregar_datos.Text = "Enviar Datos";
            // 
            // lbl_btn_preparar_datos
            // 
            this.lbl_btn_preparar_datos.AutoSize = true;
            this.lbl_btn_preparar_datos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_btn_preparar_datos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_btn_preparar_datos.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_btn_preparar_datos.Location = new System.Drawing.Point(245, 499);
            this.lbl_btn_preparar_datos.Name = "lbl_btn_preparar_datos";
            this.lbl_btn_preparar_datos.Size = new System.Drawing.Size(88, 16);
            this.lbl_btn_preparar_datos.TabIndex = 2;
            this.lbl_btn_preparar_datos.Text = "Preparar Datos";
            // 
            // btn_entregar_datos
            // 
            this.btn_entregar_datos.BackColor = System.Drawing.Color.Transparent;
            this.btn_entregar_datos.Image = global::Planet.Properties.Resources.buttonv2;
            this.btn_entregar_datos.Location = new System.Drawing.Point(348, 518);
            this.btn_entregar_datos.Name = "btn_entregar_datos";
            this.btn_entregar_datos.Size = new System.Drawing.Size(54, 58);
            this.btn_entregar_datos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_entregar_datos.TabIndex = 6;
            this.btn_entregar_datos.TabStop = false;
            // 
            // btn_preparar_datos
            // 
            this.btn_preparar_datos.BackColor = System.Drawing.Color.Transparent;
            this.btn_preparar_datos.Image = global::Planet.Properties.Resources.buttonv2;
            this.btn_preparar_datos.Location = new System.Drawing.Point(262, 518);
            this.btn_preparar_datos.Name = "btn_preparar_datos";
            this.btn_preparar_datos.Size = new System.Drawing.Size(54, 58);
            this.btn_preparar_datos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_preparar_datos.TabIndex = 5;
            this.btn_preparar_datos.TabStop = false;
            // 
            // pb_planeta
            // 
            this.pb_planeta.Image = global::Planet.Properties.Resources.Byss;
            this.pb_planeta.Location = new System.Drawing.Point(366, 195);
            this.pb_planeta.Name = "pb_planeta";
            this.pb_planeta.Size = new System.Drawing.Size(262, 183);
            this.pb_planeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_planeta.TabIndex = 3;
            this.pb_planeta.TabStop = false;
            // 
            // pb_naves
            // 
            this.pb_naves.Image = global::Planet.Properties.Resources.nave1;
            this.pb_naves.Location = new System.Drawing.Point(50, 195);
            this.pb_naves.Name = "pb_naves";
            this.pb_naves.Size = new System.Drawing.Size(267, 174);
            this.pb_naves.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_naves.TabIndex = 2;
            this.pb_naves.TabStop = false;
            // 
            // lbl_btn_verificar
            // 
            this.lbl_btn_verificar.AutoSize = true;
            this.lbl_btn_verificar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_btn_verificar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_btn_verificar.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_btn_verificar.Location = new System.Drawing.Point(31, 518);
            this.lbl_btn_verificar.Name = "lbl_btn_verificar";
            this.lbl_btn_verificar.Size = new System.Drawing.Size(174, 23);
            this.lbl_btn_verificar.TabIndex = 1;
            this.lbl_btn_verificar.Text = "Verify Delivery Data";
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackColor = System.Drawing.Color.Transparent;
            this.btn_verificar.Image = global::Planet.Properties.Resources.buttonv2;
            this.btn_verificar.Location = new System.Drawing.Point(35, 553);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(117, 130);
            this.btn_verificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_verificar.TabIndex = 0;
            this.btn_verificar.TabStop = false;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.BackColor = System.Drawing.Color.Transparent;
            this.lbl_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state.ForeColor = System.Drawing.Color.Red;
            this.lbl_state.Location = new System.Drawing.Point(56, 41);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(0, 37);
            this.lbl_state.TabIndex = 55;
            // 
            // txtb_consola
            // 
            this.txtb_consola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_consola.Location = new System.Drawing.Point(698, 266);
            this.txtb_consola.Name = "txtb_consola";
            this.txtb_consola.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtb_consola.Size = new System.Drawing.Size(716, 320);
            this.txtb_consola.TabIndex = 56;
            this.txtb_consola.Text = "";
            // 
            // btn_EnviarData
            // 
            this.btn_EnviarData.Location = new System.Drawing.Point(1324, 611);
            this.btn_EnviarData.Name = "btn_EnviarData";
            this.btn_EnviarData.Size = new System.Drawing.Size(90, 23);
            this.btn_EnviarData.TabIndex = 57;
            this.btn_EnviarData.Text = "Send Data";
            this.btn_EnviarData.UseVisualStyleBackColor = true;
            this.btn_EnviarData.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_nave
            // 
            this.AcceptButton = this.btn_EnviarInput;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 830);
            this.Controls.Add(this.pnl_enviar_datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_nave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_nave_Load);
            this.pnl_enviar_datos.ResumeLayout(false);
            this.pnl_enviar_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_entregar_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_preparar_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_planeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_naves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_verificar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_enviar_datos;
        private System.Windows.Forms.PictureBox btn_verificar;
        private System.Windows.Forms.Label lbl_btn_verificar;
        private System.Windows.Forms.PictureBox pb_naves;
        private System.Windows.Forms.PictureBox pb_planeta;
        private System.Windows.Forms.Label lbl_btn_entregar_datos;
        private System.Windows.Forms.Label lbl_btn_preparar_datos;
        private System.Windows.Forms.PictureBox btn_entregar_datos;
        private System.Windows.Forms.PictureBox btn_preparar_datos;
        private System.Windows.Forms.Button btn_EnviarInput;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.RichTextBox txtb_consola;
        private System.Windows.Forms.Button btn_EnviarData;
    }
}


namespace Forms
{
    partial class PlanetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanetForm));
            this.lbl_state = new System.Windows.Forms.Label();
            this.btn_EnviarData = new System.Windows.Forms.Button();
            this.txtb_consola = new System.Windows.Forms.RichTextBox();
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
            this.ptb_background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_entregar_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_preparar_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_planeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_naves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_verificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_background)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.BackColor = System.Drawing.Color.Transparent;
            this.lbl_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state.ForeColor = System.Drawing.Color.Red;
            this.lbl_state.Location = new System.Drawing.Point(71, 50);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(0, 37);
            this.lbl_state.TabIndex = 55;
            // 
            // btn_EnviarData
            // 
            this.btn_EnviarData.Location = new System.Drawing.Point(1352, 648);
            this.btn_EnviarData.Name = "btn_EnviarData";
            this.btn_EnviarData.Size = new System.Drawing.Size(90, 24);
            this.btn_EnviarData.TabIndex = 69;
            this.btn_EnviarData.Text = "Send Data";
            this.btn_EnviarData.UseVisualStyleBackColor = true;
            // 
            // txtb_consola
            // 
            this.txtb_consola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_consola.Location = new System.Drawing.Point(684, 207);
            this.txtb_consola.Name = "txtb_consola";
            this.txtb_consola.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtb_consola.Size = new System.Drawing.Size(758, 436);
            this.txtb_consola.TabIndex = 68;
            this.txtb_consola.Text = "";
            // 
            // btn_EnviarInput
            // 
            this.btn_EnviarInput.Location = new System.Drawing.Point(1259, 648);
            this.btn_EnviarInput.Name = "btn_EnviarInput";
            this.btn_EnviarInput.Size = new System.Drawing.Size(87, 23);
            this.btn_EnviarInput.TabIndex = 67;
            this.btn_EnviarInput.Text = "Send Message";
            this.btn_EnviarInput.UseVisualStyleBackColor = true;
            // 
            // txt_Input
            // 
            this.txt_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Input.Location = new System.Drawing.Point(684, 648);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(569, 24);
            this.txt_Input.TabIndex = 66;
            // 
            // lbl_btn_entregar_datos
            // 
            this.lbl_btn_entregar_datos.AutoSize = true;
            this.lbl_btn_entregar_datos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_btn_entregar_datos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_btn_entregar_datos.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_btn_entregar_datos.Location = new System.Drawing.Point(382, 501);
            this.lbl_btn_entregar_datos.Name = "lbl_btn_entregar_datos";
            this.lbl_btn_entregar_datos.Size = new System.Drawing.Size(75, 16);
            this.lbl_btn_entregar_datos.TabIndex = 62;
            this.lbl_btn_entregar_datos.Text = "Enviar Datos";
            // 
            // lbl_btn_preparar_datos
            // 
            this.lbl_btn_preparar_datos.AutoSize = true;
            this.lbl_btn_preparar_datos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_btn_preparar_datos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_btn_preparar_datos.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_btn_preparar_datos.Location = new System.Drawing.Point(288, 501);
            this.lbl_btn_preparar_datos.Name = "lbl_btn_preparar_datos";
            this.lbl_btn_preparar_datos.Size = new System.Drawing.Size(88, 16);
            this.lbl_btn_preparar_datos.TabIndex = 60;
            this.lbl_btn_preparar_datos.Text = "Preparar Datos";
            // 
            // btn_entregar_datos
            // 
            this.btn_entregar_datos.BackColor = System.Drawing.Color.Transparent;
            this.btn_entregar_datos.Location = new System.Drawing.Point(403, 529);
            this.btn_entregar_datos.Name = "btn_entregar_datos";
            this.btn_entregar_datos.Size = new System.Drawing.Size(54, 58);
            this.btn_entregar_datos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_entregar_datos.TabIndex = 65;
            this.btn_entregar_datos.TabStop = false;
            // 
            // btn_preparar_datos
            // 
            this.btn_preparar_datos.BackColor = System.Drawing.Color.Transparent;
            this.btn_preparar_datos.Location = new System.Drawing.Point(322, 529);
            this.btn_preparar_datos.Name = "btn_preparar_datos";
            this.btn_preparar_datos.Size = new System.Drawing.Size(54, 58);
            this.btn_preparar_datos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_preparar_datos.TabIndex = 64;
            this.btn_preparar_datos.TabStop = false;
            // 
            // pb_planeta
            // 
            this.pb_planeta.Location = new System.Drawing.Point(358, 171);
            this.pb_planeta.Name = "pb_planeta";
            this.pb_planeta.Size = new System.Drawing.Size(281, 247);
            this.pb_planeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_planeta.TabIndex = 63;
            this.pb_planeta.TabStop = false;
            // 
            // pb_naves
            // 
            this.pb_naves.Location = new System.Drawing.Point(41, 171);
            this.pb_naves.Name = "pb_naves";
            this.pb_naves.Size = new System.Drawing.Size(281, 247);
            this.pb_naves.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_naves.TabIndex = 61;
            this.pb_naves.TabStop = false;
            // 
            // lbl_btn_verificar
            // 
            this.lbl_btn_verificar.AutoSize = true;
            this.lbl_btn_verificar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_btn_verificar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_btn_verificar.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_btn_verificar.Location = new System.Drawing.Point(74, 494);
            this.lbl_btn_verificar.Name = "lbl_btn_verificar";
            this.lbl_btn_verificar.Size = new System.Drawing.Size(174, 23);
            this.lbl_btn_verificar.TabIndex = 59;
            this.lbl_btn_verificar.Text = "Verify Delivery Data";
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackColor = System.Drawing.Color.Transparent;
            this.btn_verificar.Location = new System.Drawing.Point(78, 529);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(97, 102);
            this.btn_verificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_verificar.TabIndex = 58;
            this.btn_verificar.TabStop = false;
            // 
            // ptb_background
            // 
            this.ptb_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_background.Image = ((System.Drawing.Image)(resources.GetObject("ptb_background.Image")));
            this.ptb_background.Location = new System.Drawing.Point(0, 0);
            this.ptb_background.Name = "ptb_background";
            this.ptb_background.Size = new System.Drawing.Size(1530, 830);
            this.ptb_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_background.TabIndex = 70;
            this.ptb_background.TabStop = false;
            // 
            // PlanetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 830);
            this.Controls.Add(this.btn_EnviarData);
            this.Controls.Add(this.btn_EnviarInput);
            this.Controls.Add(this.txt_Input);
            this.Controls.Add(this.lbl_btn_entregar_datos);
            this.Controls.Add(this.lbl_btn_preparar_datos);
            this.Controls.Add(this.btn_entregar_datos);
            this.Controls.Add(this.btn_preparar_datos);
            this.Controls.Add(this.lbl_btn_verificar);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.pb_naves);
            this.Controls.Add(this.pb_planeta);
            this.Controls.Add(this.txtb_consola);
            this.Controls.Add(this.ptb_background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planet";
            this.Load += new System.EventHandler(this.PlanetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_entregar_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_preparar_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_planeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_naves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_verificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Button btn_EnviarData;
        private System.Windows.Forms.RichTextBox txtb_consola;
        private System.Windows.Forms.Button btn_EnviarInput;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.Label lbl_btn_entregar_datos;
        private System.Windows.Forms.Label lbl_btn_preparar_datos;
        private System.Windows.Forms.PictureBox btn_entregar_datos;
        private System.Windows.Forms.PictureBox btn_preparar_datos;
        private System.Windows.Forms.PictureBox pb_planeta;
        private System.Windows.Forms.PictureBox pb_naves;
        private System.Windows.Forms.Label lbl_btn_verificar;
        private System.Windows.Forms.PictureBox btn_verificar;
        private System.Windows.Forms.PictureBox ptb_background;
    }
}
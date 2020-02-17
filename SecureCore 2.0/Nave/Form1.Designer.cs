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
            this.btn_enviar_datos = new System.Windows.Forms.Panel();
            this.pb_planeta = new System.Windows.Forms.PictureBox();
            this.pb_naves = new System.Windows.Forms.PictureBox();
            this.lbl_btn_verificar = new System.Windows.Forms.Label();
            this.btn_verificar = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_preparar_datos = new System.Windows.Forms.PictureBox();
            this.btn_entregar_datos = new System.Windows.Forms.PictureBox();
            this.lbl_btn_preparar_datos = new System.Windows.Forms.Label();
            this.lbl_btn_entregar_datos = new System.Windows.Forms.Label();
            this.btn_enviar_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_planeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_naves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_verificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_preparar_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_entregar_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_enviar_datos
            // 
            this.btn_enviar_datos.BackColor = System.Drawing.Color.Black;
            this.btn_enviar_datos.BackgroundImage = global::Nave.Properties.Resources._5e456a7764864_1581607562_5e456a77647fb;
            this.btn_enviar_datos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enviar_datos.Controls.Add(this.lbl_btn_entregar_datos);
            this.btn_enviar_datos.Controls.Add(this.lbl_btn_preparar_datos);
            this.btn_enviar_datos.Controls.Add(this.btn_entregar_datos);
            this.btn_enviar_datos.Controls.Add(this.btn_preparar_datos);
            this.btn_enviar_datos.Controls.Add(this.textBox1);
            this.btn_enviar_datos.Controls.Add(this.pb_planeta);
            this.btn_enviar_datos.Controls.Add(this.pb_naves);
            this.btn_enviar_datos.Controls.Add(this.lbl_btn_verificar);
            this.btn_enviar_datos.Controls.Add(this.btn_verificar);
            this.btn_enviar_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_enviar_datos.Location = new System.Drawing.Point(0, 0);
            this.btn_enviar_datos.Name = "btn_enviar_datos";
            this.btn_enviar_datos.Size = new System.Drawing.Size(1003, 545);
            this.btn_enviar_datos.TabIndex = 0;
            // 
            // pb_planeta
            // 
            this.pb_planeta.Image = global::Nave.Properties.Resources.Byss;
            this.pb_planeta.Location = new System.Drawing.Point(237, 124);
            this.pb_planeta.Name = "pb_planeta";
            this.pb_planeta.Size = new System.Drawing.Size(179, 132);
            this.pb_planeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_planeta.TabIndex = 3;
            this.pb_planeta.TabStop = false;
            // 
            // pb_naves
            // 
            this.pb_naves.Image = global::Nave.Properties.Resources.nave1;
            this.pb_naves.Location = new System.Drawing.Point(35, 124);
            this.pb_naves.Name = "pb_naves";
            this.pb_naves.Size = new System.Drawing.Size(171, 96);
            this.pb_naves.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_naves.TabIndex = 2;
            this.pb_naves.TabStop = false;
            // 
            // lbl_btn_verificar
            // 
            this.lbl_btn_verificar.AutoSize = true;
            this.lbl_btn_verificar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_btn_verificar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_btn_verificar.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_btn_verificar.Location = new System.Drawing.Point(34, 307);
            this.lbl_btn_verificar.Name = "lbl_btn_verificar";
            this.lbl_btn_verificar.Size = new System.Drawing.Size(55, 16);
            this.lbl_btn_verificar.TabIndex = 1;
            this.lbl_btn_verificar.Text = "Verificar";
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackColor = System.Drawing.Color.Transparent;
            this.btn_verificar.Image = global::Nave.Properties.Resources.buttonv2;
            this.btn_verificar.Location = new System.Drawing.Point(35, 326);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(54, 58);
            this.btn_verificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_verificar.TabIndex = 0;
            this.btn_verificar.TabStop = false;
            this.btn_verificar.MouseLeave += new System.EventHandler(this.btn_verificar_MouseLeave);
            this.btn_verificar.MouseHover += new System.EventHandler(this.btn_verificar_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(452, 163);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 221);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Ejemplo consola\r\nEjemplo consola\r\nEjemplo consola\r\nEjemplo consola";
            // 
            // btn_preparar_datos
            // 
            this.btn_preparar_datos.BackColor = System.Drawing.Color.Transparent;
            this.btn_preparar_datos.Image = global::Nave.Properties.Resources.buttonv2;
            this.btn_preparar_datos.Location = new System.Drawing.Point(112, 326);
            this.btn_preparar_datos.Name = "btn_preparar_datos";
            this.btn_preparar_datos.Size = new System.Drawing.Size(54, 58);
            this.btn_preparar_datos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_preparar_datos.TabIndex = 5;
            this.btn_preparar_datos.TabStop = false;
            // 
            // btn_entregar_datos
            // 
            this.btn_entregar_datos.BackColor = System.Drawing.Color.Transparent;
            this.btn_entregar_datos.Image = global::Nave.Properties.Resources.buttonv2;
            this.btn_entregar_datos.Location = new System.Drawing.Point(198, 326);
            this.btn_entregar_datos.Name = "btn_entregar_datos";
            this.btn_entregar_datos.Size = new System.Drawing.Size(54, 58);
            this.btn_entregar_datos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_entregar_datos.TabIndex = 6;
            this.btn_entregar_datos.TabStop = false;
            // 
            // lbl_btn_preparar_datos
            // 
            this.lbl_btn_preparar_datos.AutoSize = true;
            this.lbl_btn_preparar_datos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_btn_preparar_datos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_btn_preparar_datos.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_btn_preparar_datos.Location = new System.Drawing.Point(95, 307);
            this.lbl_btn_preparar_datos.Name = "lbl_btn_preparar_datos";
            this.lbl_btn_preparar_datos.Size = new System.Drawing.Size(88, 16);
            this.lbl_btn_preparar_datos.TabIndex = 7;
            this.lbl_btn_preparar_datos.Text = "Preparar Datos";
            // 
            // lbl_btn_entregar_datos
            // 
            this.lbl_btn_entregar_datos.AutoSize = true;
            this.lbl_btn_entregar_datos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_btn_entregar_datos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_btn_entregar_datos.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_btn_entregar_datos.Location = new System.Drawing.Point(189, 307);
            this.lbl_btn_entregar_datos.Name = "lbl_btn_entregar_datos";
            this.lbl_btn_entregar_datos.Size = new System.Drawing.Size(75, 16);
            this.lbl_btn_entregar_datos.TabIndex = 8;
            this.lbl_btn_entregar_datos.Text = "Enviar Datos";
            // 
            // frm_nave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 545);
            this.Controls.Add(this.btn_enviar_datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_nave";
            this.Text = "Form1";
            this.btn_enviar_datos.ResumeLayout(false);
            this.btn_enviar_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_planeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_naves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_verificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_preparar_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_entregar_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btn_enviar_datos;
        private System.Windows.Forms.PictureBox btn_verificar;
        private System.Windows.Forms.Label lbl_btn_verificar;
        private System.Windows.Forms.PictureBox pb_naves;
        private System.Windows.Forms.PictureBox pb_planeta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_btn_entregar_datos;
        private System.Windows.Forms.Label lbl_btn_preparar_datos;
        private System.Windows.Forms.PictureBox btn_entregar_datos;
        private System.Windows.Forms.PictureBox btn_preparar_datos;
    }
}


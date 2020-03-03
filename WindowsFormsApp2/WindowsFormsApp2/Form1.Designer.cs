namespace WindowsFormsApp2
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
            this.rtbx_consola = new System.Windows.Forms.RichTextBox();
            this.lbl_planeta = new System.Windows.Forms.Label();
            this.txtb_planeta = new System.Windows.Forms.TextBox();
            this.txtb_nave = new System.Windows.Forms.TextBox();
            this.lbl_nave = new System.Windows.Forms.Label();
            this.btn_enviarTPlaneta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbx_consola
            // 
            this.rtbx_consola.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbx_consola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbx_consola.Location = new System.Drawing.Point(12, 51);
            this.rtbx_consola.Name = "rtbx_consola";
            this.rtbx_consola.ReadOnly = true;
            this.rtbx_consola.Size = new System.Drawing.Size(776, 390);
            this.rtbx_consola.TabIndex = 0;
            this.rtbx_consola.Text = "";
            // 
            // lbl_planeta
            // 
            this.lbl_planeta.AutoSize = true;
            this.lbl_planeta.Location = new System.Drawing.Point(9, 25);
            this.lbl_planeta.Name = "lbl_planeta";
            this.lbl_planeta.Size = new System.Drawing.Size(46, 13);
            this.lbl_planeta.TabIndex = 1;
            this.lbl_planeta.Text = "Planeta:";
            // 
            // txtb_planeta
            // 
            this.txtb_planeta.Location = new System.Drawing.Point(61, 22);
            this.txtb_planeta.Name = "txtb_planeta";
            this.txtb_planeta.Size = new System.Drawing.Size(232, 20);
            this.txtb_planeta.TabIndex = 2;
            // 
            // txtb_nave
            // 
            this.txtb_nave.Location = new System.Drawing.Point(453, 22);
            this.txtb_nave.Name = "txtb_nave";
            this.txtb_nave.Size = new System.Drawing.Size(254, 20);
            this.txtb_nave.TabIndex = 3;
            // 
            // lbl_nave
            // 
            this.lbl_nave.AutoSize = true;
            this.lbl_nave.Location = new System.Drawing.Point(412, 25);
            this.lbl_nave.Name = "lbl_nave";
            this.lbl_nave.Size = new System.Drawing.Size(36, 13);
            this.lbl_nave.TabIndex = 4;
            this.lbl_nave.Text = "Nave:";
            // 
            // btn_enviarTPlaneta
            // 
            this.btn_enviarTPlaneta.Location = new System.Drawing.Point(299, 20);
            this.btn_enviarTPlaneta.Name = "btn_enviarTPlaneta";
            this.btn_enviarTPlaneta.Size = new System.Drawing.Size(75, 23);
            this.btn_enviarTPlaneta.TabIndex = 5;
            this.btn_enviarTPlaneta.Text = "Enviar";
            this.btn_enviarTPlaneta.UseVisualStyleBackColor = true;
            this.btn_enviarTPlaneta.Click += new System.EventHandler(this.btn_enviarTPlaneta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_enviarTPlaneta);
            this.Controls.Add(this.lbl_nave);
            this.Controls.Add(this.txtb_nave);
            this.Controls.Add(this.txtb_planeta);
            this.Controls.Add(this.lbl_planeta);
            this.Controls.Add(this.rtbx_consola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbx_consola;
        private System.Windows.Forms.Label lbl_planeta;
        private System.Windows.Forms.TextBox txtb_planeta;
        private System.Windows.Forms.TextBox txtb_nave;
        private System.Windows.Forms.Label lbl_nave;
        private System.Windows.Forms.Button btn_enviarTPlaneta;
        private System.Windows.Forms.Button button1;
    }
}


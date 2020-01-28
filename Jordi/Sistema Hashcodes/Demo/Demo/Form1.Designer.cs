namespace Demo
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
            this.btn_MostrarIdentificador = new System.Windows.Forms.Button();
            this.btn_MostrarValor = new System.Windows.Forms.Button();
            this.btn_Next_form = new System.Windows.Forms.Button();
            this.grup1 = new System.Windows.Forms.GroupBox();
            this.btn_Prueba1 = new System.Windows.Forms.Button();
            this.grup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_MostrarIdentificador
            // 
            this.btn_MostrarIdentificador.Location = new System.Drawing.Point(15, 35);
            this.btn_MostrarIdentificador.Name = "btn_MostrarIdentificador";
            this.btn_MostrarIdentificador.Size = new System.Drawing.Size(129, 23);
            this.btn_MostrarIdentificador.TabIndex = 0;
            this.btn_MostrarIdentificador.Text = "1";
            this.btn_MostrarIdentificador.UseVisualStyleBackColor = true;
            this.btn_MostrarIdentificador.Click += new System.EventHandler(this.btn_showHashcodeValue_Click);
            // 
            // btn_MostrarValor
            // 
            this.btn_MostrarValor.Location = new System.Drawing.Point(339, 156);
            this.btn_MostrarValor.Name = "btn_MostrarValor";
            this.btn_MostrarValor.Size = new System.Drawing.Size(122, 23);
            this.btn_MostrarValor.TabIndex = 1;
            this.btn_MostrarValor.Text = "2";
            this.btn_MostrarValor.UseVisualStyleBackColor = true;
            this.btn_MostrarValor.Click += new System.EventHandler(this.btn_showcontent_Click);
            // 
            // btn_Next_form
            // 
            this.btn_Next_form.Location = new System.Drawing.Point(574, 289);
            this.btn_Next_form.Name = "btn_Next_form";
            this.btn_Next_form.Size = new System.Drawing.Size(75, 23);
            this.btn_Next_form.TabIndex = 2;
            this.btn_Next_form.Text = "button1";
            this.btn_Next_form.UseVisualStyleBackColor = true;
            this.btn_Next_form.Click += new System.EventHandler(this.button1_Click);
            // 
            // grup1
            // 
            this.grup1.Controls.Add(this.btn_MostrarIdentificador);
            this.grup1.Location = new System.Drawing.Point(32, 123);
            this.grup1.Name = "grup1";
            this.grup1.Size = new System.Drawing.Size(200, 100);
            this.grup1.TabIndex = 3;
            this.grup1.TabStop = false;
            this.grup1.Text = "groupBox1";
            // 
            // btn_Prueba1
            // 
            this.btn_Prueba1.Location = new System.Drawing.Point(586, 90);
            this.btn_Prueba1.Name = "btn_Prueba1";
            this.btn_Prueba1.Size = new System.Drawing.Size(75, 23);
            this.btn_Prueba1.TabIndex = 4;
            this.btn_Prueba1.Text = "button2";
            this.btn_Prueba1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Prueba1);
            this.Controls.Add(this.grup1);
            this.Controls.Add(this.btn_Next_form);
            this.Controls.Add(this.btn_MostrarValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MostrarIdentificador;
        private System.Windows.Forms.Button btn_MostrarValor;
        private System.Windows.Forms.Button btn_Next_form;
        private System.Windows.Forms.GroupBox grup1;
        private System.Windows.Forms.Button btn_Prueba1;
    }
}


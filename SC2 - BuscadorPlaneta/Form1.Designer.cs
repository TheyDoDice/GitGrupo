namespace BuscadorPlaneta
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
            this.cmbx_buscarPlaneta = new System.Windows.Forms.ComboBox();
            this.tbx_ip = new System.Windows.Forms.TextBox();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbx_buscarNau = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbx_buscarPlaneta
            // 
            this.cmbx_buscarPlaneta.FormattingEnabled = true;
            this.cmbx_buscarPlaneta.Location = new System.Drawing.Point(96, 123);
            this.cmbx_buscarPlaneta.Name = "cmbx_buscarPlaneta";
            this.cmbx_buscarPlaneta.Size = new System.Drawing.Size(183, 21);
            this.cmbx_buscarPlaneta.TabIndex = 0;
            this.cmbx_buscarPlaneta.SelectedIndexChanged += new System.EventHandler(this.cmbx_buscarPlaneta_SelectedIndexChanged);
            // 
            // tbx_ip
            // 
            this.tbx_ip.Location = new System.Drawing.Point(338, 125);
            this.tbx_ip.Name = "tbx_ip";
            this.tbx_ip.Size = new System.Drawing.Size(131, 20);
            this.tbx_ip.TabIndex = 1;
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(314, 128);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(18, 13);
            this.lbl_ip.TabIndex = 2;
            this.lbl_ip.Text = "ip:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entrar en Nave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nave: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Planeta: ";
            // 
            // cmbx_buscarNau
            // 
            this.cmbx_buscarNau.FormattingEnabled = true;
            this.cmbx_buscarNau.Location = new System.Drawing.Point(96, 76);
            this.cmbx_buscarNau.Name = "cmbx_buscarNau";
            this.cmbx_buscarNau.Size = new System.Drawing.Size(183, 21);
            this.cmbx_buscarNau.TabIndex = 7;
            this.cmbx_buscarNau.SelectedIndexChanged += new System.EventHandler(this.cmbx_buscarNau_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbx_buscarNau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ip);
            this.Controls.Add(this.tbx_ip);
            this.Controls.Add(this.cmbx_buscarPlaneta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_buscarPlaneta;
        private System.Windows.Forms.TextBox tbx_ip;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbx_buscarNau;
        private System.Windows.Forms.Button button1;
    }
}


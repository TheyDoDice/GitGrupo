namespace FormSWTextbox
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
            this.button1 = new System.Windows.Forms.Button();
            this.swTextbox12 = new SWTextbox.SWTextbox1();
            this.swTextbox11 = new SWTextbox.SWTextbox1();
            this.swTextbox13 = new SWTextbox.SWTextbox1();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // swTextbox12
            // 
            this.swTextbox12.DadaTipus = SWTextbox.SWTextbox1.tipDades.data;
            this.swTextbox12.foranea = false;
            this.swTextbox12.Location = new System.Drawing.Point(349, 42);
            this.swTextbox12.mensaje = null;
            this.swTextbox12.Name = "swTextbox12";
            this.swTextbox12.nomCamp = null;
            this.swTextbox12.nomComboBox = null;
            this.swTextbox12.Size = new System.Drawing.Size(100, 20);
            this.swTextbox12.TabIndex = 2;
            // 
            // swTextbox11
            // 
            this.swTextbox11.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swTextbox11.foranea = false;
            this.swTextbox11.Location = new System.Drawing.Point(68, 43);
            this.swTextbox11.mensaje = "Hola";
            this.swTextbox11.Name = "swTextbox11";
            this.swTextbox11.nomCamp = null;
            this.swTextbox11.nomComboBox = null;
            this.swTextbox11.Size = new System.Drawing.Size(171, 20);
            this.swTextbox11.TabIndex = 0;
            // 
            // swTextbox13
            // 
            this.swTextbox13.DadaTipus = SWTextbox.SWTextbox1.tipDades.Codi;
            this.swTextbox13.foranea = false;
            this.swTextbox13.Location = new System.Drawing.Point(415, 145);
            this.swTextbox13.mensaje = null;
            this.swTextbox13.Name = "swTextbox13";
            this.swTextbox13.nomCamp = null;
            this.swTextbox13.nomComboBox = null;
            this.swTextbox13.Size = new System.Drawing.Size(160, 20);
            this.swTextbox13.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swTextbox13);
            this.Controls.Add(this.swTextbox12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.swTextbox11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SWTextbox.SWTextbox1 swTextbox11;
        private System.Windows.Forms.Button button1;
        private SWTextbox.SWTextbox1 swTextbox12;
        private SWTextbox.SWTextbox1 swTextbox13;
    }
}


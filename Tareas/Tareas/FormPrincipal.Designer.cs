namespace Tareas
{
    partial class FormPrincipal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.ptb_minimize = new System.Windows.Forms.PictureBox();
            this.ptb_close = new System.Windows.Forms.PictureBox();
            this.bordeDerecha = new System.Windows.Forms.Panel();
            this.bordeInferior = new System.Windows.Forms.Panel();
            this.bordeIzquierda = new System.Windows.Forms.Panel();
            this.bordeSuperior = new System.Windows.Forms.Panel();
            this.pantallaPrincipal = new System.Windows.Forms.Panel();
            this.listado = new System.Windows.Forms.Panel();
            this.marginSuperior = new System.Windows.Forms.Panel();
            this.marginIzquierda = new System.Windows.Forms.Panel();
            this.marginDerecha = new System.Windows.Forms.Panel();
            this.barraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).BeginInit();
            this.pantallaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.barraSuperior.Controls.Add(this.ptb_minimize);
            this.barraSuperior.Controls.Add(this.ptb_close);
            this.barraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(263, 27);
            this.barraSuperior.TabIndex = 0;
            // 
            // ptb_minimize
            // 
            this.ptb_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.ptb_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptb_minimize.Location = new System.Drawing.Point(209, 0);
            this.ptb_minimize.Name = "ptb_minimize";
            this.ptb_minimize.Size = new System.Drawing.Size(27, 27);
            this.ptb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_minimize.TabIndex = 2;
            this.ptb_minimize.TabStop = false;
            // 
            // ptb_close
            // 
            this.ptb_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.ptb_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptb_close.Location = new System.Drawing.Point(236, 0);
            this.ptb_close.Name = "ptb_close";
            this.ptb_close.Size = new System.Drawing.Size(27, 27);
            this.ptb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_close.TabIndex = 1;
            this.ptb_close.TabStop = false;
            // 
            // bordeDerecha
            // 
            this.bordeDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(174)))), ((int)(((byte)(234)))));
            this.bordeDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.bordeDerecha.Location = new System.Drawing.Point(265, 0);
            this.bordeDerecha.Name = "bordeDerecha";
            this.bordeDerecha.Size = new System.Drawing.Size(2, 677);
            this.bordeDerecha.TabIndex = 1;
            // 
            // bordeInferior
            // 
            this.bordeInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(174)))), ((int)(((byte)(234)))));
            this.bordeInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bordeInferior.Location = new System.Drawing.Point(0, 675);
            this.bordeInferior.Name = "bordeInferior";
            this.bordeInferior.Size = new System.Drawing.Size(265, 2);
            this.bordeInferior.TabIndex = 2;
            // 
            // bordeIzquierda
            // 
            this.bordeIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(174)))), ((int)(((byte)(234)))));
            this.bordeIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.bordeIzquierda.Location = new System.Drawing.Point(0, 0);
            this.bordeIzquierda.Name = "bordeIzquierda";
            this.bordeIzquierda.Size = new System.Drawing.Size(2, 675);
            this.bordeIzquierda.TabIndex = 2;
            // 
            // bordeSuperior
            // 
            this.bordeSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(174)))), ((int)(((byte)(234)))));
            this.bordeSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.bordeSuperior.Location = new System.Drawing.Point(2, 0);
            this.bordeSuperior.Name = "bordeSuperior";
            this.bordeSuperior.Size = new System.Drawing.Size(263, 2);
            this.bordeSuperior.TabIndex = 2;
            // 
            // pantallaPrincipal
            // 
            this.pantallaPrincipal.Controls.Add(this.listado);
            this.pantallaPrincipal.Controls.Add(this.marginSuperior);
            this.pantallaPrincipal.Controls.Add(this.marginIzquierda);
            this.pantallaPrincipal.Controls.Add(this.marginDerecha);
            this.pantallaPrincipal.Controls.Add(this.barraSuperior);
            this.pantallaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pantallaPrincipal.Location = new System.Drawing.Point(2, 2);
            this.pantallaPrincipal.Name = "pantallaPrincipal";
            this.pantallaPrincipal.Size = new System.Drawing.Size(263, 673);
            this.pantallaPrincipal.TabIndex = 3;
            // 
            // listado
            // 
            this.listado.BackColor = System.Drawing.Color.Transparent;
            this.listado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listado.Location = new System.Drawing.Point(10, 37);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(243, 636);
            this.listado.TabIndex = 4;
            // 
            // marginSuperior
            // 
            this.marginSuperior.BackColor = System.Drawing.Color.Transparent;
            this.marginSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.marginSuperior.Location = new System.Drawing.Point(10, 27);
            this.marginSuperior.Name = "marginSuperior";
            this.marginSuperior.Size = new System.Drawing.Size(243, 10);
            this.marginSuperior.TabIndex = 3;
            // 
            // marginIzquierda
            // 
            this.marginIzquierda.BackColor = System.Drawing.Color.Transparent;
            this.marginIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.marginIzquierda.Location = new System.Drawing.Point(0, 27);
            this.marginIzquierda.Name = "marginIzquierda";
            this.marginIzquierda.Size = new System.Drawing.Size(10, 646);
            this.marginIzquierda.TabIndex = 2;
            // 
            // marginDerecha
            // 
            this.marginDerecha.BackColor = System.Drawing.Color.Transparent;
            this.marginDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.marginDerecha.Location = new System.Drawing.Point(253, 27);
            this.marginDerecha.Name = "marginDerecha";
            this.marginDerecha.Size = new System.Drawing.Size(10, 646);
            this.marginDerecha.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 677);
            this.Controls.Add(this.pantallaPrincipal);
            this.Controls.Add(this.bordeSuperior);
            this.Controls.Add(this.bordeIzquierda);
            this.Controls.Add(this.bordeInferior);
            this.Controls.Add(this.bordeDerecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.barraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).EndInit();
            this.pantallaPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.PictureBox ptb_minimize;
        private System.Windows.Forms.PictureBox ptb_close;
        private System.Windows.Forms.Panel bordeDerecha;
        private System.Windows.Forms.Panel bordeInferior;
        private System.Windows.Forms.Panel bordeIzquierda;
        private System.Windows.Forms.Panel bordeSuperior;
        private System.Windows.Forms.Panel pantallaPrincipal;
        private System.Windows.Forms.Panel listado;
        private System.Windows.Forms.Panel marginSuperior;
        private System.Windows.Forms.Panel marginIzquierda;
        private System.Windows.Forms.Panel marginDerecha;
    }
}
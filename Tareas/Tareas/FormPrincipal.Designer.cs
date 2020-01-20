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
            this.separator = new System.Windows.Forms.Panel();
            this.tarea = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Action = new System.Windows.Forms.Button();
            this.marginIzquierda = new System.Windows.Forms.Panel();
            this.marginDerecha = new System.Windows.Forms.Panel();
            this.barraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).BeginInit();
            this.pantallaPrincipal.SuspendLayout();
            this.marginSuperior.SuspendLayout();
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
            this.listado.AutoScroll = true;
            this.listado.BackColor = System.Drawing.Color.Transparent;
            this.listado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listado.Location = new System.Drawing.Point(10, 297);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(243, 376);
            this.listado.TabIndex = 4;
            // 
            // marginSuperior
            // 
            this.marginSuperior.BackColor = System.Drawing.Color.Transparent;
            this.marginSuperior.Controls.Add(this.separator);
            this.marginSuperior.Controls.Add(this.tarea);
            this.marginSuperior.Controls.Add(this.titulo);
            this.marginSuperior.Controls.Add(this.label2);
            this.marginSuperior.Controls.Add(this.label1);
            this.marginSuperior.Controls.Add(this.btn_Action);
            this.marginSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.marginSuperior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.marginSuperior.Location = new System.Drawing.Point(10, 27);
            this.marginSuperior.Name = "marginSuperior";
            this.marginSuperior.Size = new System.Drawing.Size(243, 270);
            this.marginSuperior.TabIndex = 3;
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.separator.Location = new System.Drawing.Point(0, 259);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(243, 2);
            this.separator.TabIndex = 5;
            // 
            // tarea
            // 
            this.tarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarea.Location = new System.Drawing.Point(6, 103);
            this.tarea.Multiline = true;
            this.tarea.Name = "tarea";
            this.tarea.Size = new System.Drawing.Size(231, 108);
            this.tarea.TabIndex = 4;
            // 
            // titulo
            // 
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(6, 43);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(231, 24);
            this.titulo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // btn_Action
            // 
            this.btn_Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.btn_Action.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Action.FlatAppearance.BorderSize = 0;
            this.btn_Action.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(162)))), ((int)(((byte)(240)))));
            this.btn_Action.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(174)))), ((int)(((byte)(234)))));
            this.btn_Action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Action.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Action.ForeColor = System.Drawing.Color.White;
            this.btn_Action.Location = new System.Drawing.Point(146, 217);
            this.btn_Action.Name = "btn_Action";
            this.btn_Action.Size = new System.Drawing.Size(91, 33);
            this.btn_Action.TabIndex = 0;
            this.btn_Action.Text = "Insertar";
            this.btn_Action.UseVisualStyleBackColor = false;
            this.btn_Action.Click += new System.EventHandler(this.btn_Action_Click);
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
            this.marginSuperior.ResumeLayout(false);
            this.marginSuperior.PerformLayout();
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
        private System.Windows.Forms.Button btn_Action;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.TextBox tarea;
    }
}
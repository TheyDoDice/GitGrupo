namespace CompararArchivos
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
            this.grbx_Rutas = new System.Windows.Forms.GroupBox();
            this.btn_CargarArchivo2 = new System.Windows.Forms.Button();
            this.txtb_RutaArchivo2 = new System.Windows.Forms.TextBox();
            this.lbl_Archivo2 = new System.Windows.Forms.Label();
            this.btn_CargarArchivo1 = new System.Windows.Forms.Button();
            this.txtb_RutaArchivo1 = new System.Windows.Forms.TextBox();
            this.lbl_archivo1 = new System.Windows.Forms.Label();
            this.Consola = new System.Windows.Forms.RichTextBox();
            this.btn_comparar = new System.Windows.Forms.Button();
            this.grbx_Rutas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_Rutas
            // 
            this.grbx_Rutas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbx_Rutas.Controls.Add(this.btn_CargarArchivo2);
            this.grbx_Rutas.Controls.Add(this.txtb_RutaArchivo2);
            this.grbx_Rutas.Controls.Add(this.lbl_Archivo2);
            this.grbx_Rutas.Controls.Add(this.btn_CargarArchivo1);
            this.grbx_Rutas.Controls.Add(this.txtb_RutaArchivo1);
            this.grbx_Rutas.Controls.Add(this.lbl_archivo1);
            this.grbx_Rutas.Location = new System.Drawing.Point(12, 12);
            this.grbx_Rutas.Name = "grbx_Rutas";
            this.grbx_Rutas.Size = new System.Drawing.Size(466, 70);
            this.grbx_Rutas.TabIndex = 0;
            this.grbx_Rutas.TabStop = false;
            this.grbx_Rutas.Text = "Archivos";
            // 
            // btn_CargarArchivo2
            // 
            this.btn_CargarArchivo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CargarArchivo2.Location = new System.Drawing.Point(385, 37);
            this.btn_CargarArchivo2.Name = "btn_CargarArchivo2";
            this.btn_CargarArchivo2.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarArchivo2.TabIndex = 5;
            this.btn_CargarArchivo2.Text = "Cargar";
            this.btn_CargarArchivo2.UseVisualStyleBackColor = true;
            this.btn_CargarArchivo2.Click += new System.EventHandler(this.btn_CargarArchivo2_Click);
            // 
            // txtb_RutaArchivo2
            // 
            this.txtb_RutaArchivo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_RutaArchivo2.Location = new System.Drawing.Point(67, 39);
            this.txtb_RutaArchivo2.Name = "txtb_RutaArchivo2";
            this.txtb_RutaArchivo2.ReadOnly = true;
            this.txtb_RutaArchivo2.Size = new System.Drawing.Size(312, 20);
            this.txtb_RutaArchivo2.TabIndex = 4;
            // 
            // lbl_Archivo2
            // 
            this.lbl_Archivo2.AutoSize = true;
            this.lbl_Archivo2.Location = new System.Drawing.Point(6, 42);
            this.lbl_Archivo2.Name = "lbl_Archivo2";
            this.lbl_Archivo2.Size = new System.Drawing.Size(55, 13);
            this.lbl_Archivo2.TabIndex = 3;
            this.lbl_Archivo2.Text = "Archivo 2:";
            // 
            // btn_CargarArchivo1
            // 
            this.btn_CargarArchivo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CargarArchivo1.Location = new System.Drawing.Point(385, 11);
            this.btn_CargarArchivo1.Name = "btn_CargarArchivo1";
            this.btn_CargarArchivo1.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarArchivo1.TabIndex = 2;
            this.btn_CargarArchivo1.Text = "Cargar";
            this.btn_CargarArchivo1.UseVisualStyleBackColor = true;
            this.btn_CargarArchivo1.Click += new System.EventHandler(this.btn_CargarArchivo1_Click);
            // 
            // txtb_RutaArchivo1
            // 
            this.txtb_RutaArchivo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_RutaArchivo1.Location = new System.Drawing.Point(67, 13);
            this.txtb_RutaArchivo1.Name = "txtb_RutaArchivo1";
            this.txtb_RutaArchivo1.ReadOnly = true;
            this.txtb_RutaArchivo1.Size = new System.Drawing.Size(312, 20);
            this.txtb_RutaArchivo1.TabIndex = 1;
            // 
            // lbl_archivo1
            // 
            this.lbl_archivo1.AutoSize = true;
            this.lbl_archivo1.Location = new System.Drawing.Point(6, 16);
            this.lbl_archivo1.Name = "lbl_archivo1";
            this.lbl_archivo1.Size = new System.Drawing.Size(55, 13);
            this.lbl_archivo1.TabIndex = 0;
            this.lbl_archivo1.Text = "Archivo 1:";
            // 
            // Consola
            // 
            this.Consola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Consola.BackColor = System.Drawing.Color.Black;
            this.Consola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Consola.Location = new System.Drawing.Point(12, 88);
            this.Consola.Name = "Consola";
            this.Consola.ReadOnly = true;
            this.Consola.Size = new System.Drawing.Size(466, 189);
            this.Consola.TabIndex = 1;
            this.Consola.Text = "";
            // 
            // btn_comparar
            // 
            this.btn_comparar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_comparar.Location = new System.Drawing.Point(403, 283);
            this.btn_comparar.Name = "btn_comparar";
            this.btn_comparar.Size = new System.Drawing.Size(75, 23);
            this.btn_comparar.TabIndex = 2;
            this.btn_comparar.Text = "Comparar";
            this.btn_comparar.UseVisualStyleBackColor = true;
            this.btn_comparar.Click += new System.EventHandler(this.btn_comparar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_comparar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 318);
            this.Controls.Add(this.btn_comparar);
            this.Controls.Add(this.Consola);
            this.Controls.Add(this.grbx_Rutas);
            this.Name = "Form1";
            this.Text = "Comparar Archivos";
            this.grbx_Rutas.ResumeLayout(false);
            this.grbx_Rutas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_Rutas;
        private System.Windows.Forms.Button btn_CargarArchivo2;
        private System.Windows.Forms.TextBox txtb_RutaArchivo2;
        private System.Windows.Forms.Label lbl_Archivo2;
        private System.Windows.Forms.Button btn_CargarArchivo1;
        private System.Windows.Forms.TextBox txtb_RutaArchivo1;
        private System.Windows.Forms.Label lbl_archivo1;
        private System.Windows.Forms.RichTextBox Consola;
        private System.Windows.Forms.Button btn_comparar;
    }
}


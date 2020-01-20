namespace RecepcióComandes
{
    partial class PropiedadesConsola
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
            this.lbl_TextColor = new System.Windows.Forms.Label();
            this.lbl_backgroundcolor = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.cbx_textcolors = new System.Windows.Forms.ComboBox();
            this.cbx_colorFondo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TextColor
            // 
            this.lbl_TextColor.AutoSize = true;
            this.lbl_TextColor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TextColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_TextColor.Location = new System.Drawing.Point(6, 69);
            this.lbl_TextColor.Name = "lbl_TextColor";
            this.lbl_TextColor.Size = new System.Drawing.Size(104, 18);
            this.lbl_TextColor.TabIndex = 1;
            this.lbl_TextColor.Text = "Color del texto:";
            // 
            // lbl_backgroundcolor
            // 
            this.lbl_backgroundcolor.AutoSize = true;
            this.lbl_backgroundcolor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_backgroundcolor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_backgroundcolor.Location = new System.Drawing.Point(6, 108);
            this.lbl_backgroundcolor.Name = "lbl_backgroundcolor";
            this.lbl_backgroundcolor.Size = new System.Drawing.Size(104, 18);
            this.lbl_backgroundcolor.TabIndex = 2;
            this.lbl_backgroundcolor.Text = "Color de fondo:";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cerrar.Location = new System.Drawing.Point(315, 207);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(86, 30);
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // cbx_textcolors
            // 
            this.cbx_textcolors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.cbx_textcolors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_textcolors.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbx_textcolors.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx_textcolors.FormattingEnabled = true;
            this.cbx_textcolors.Location = new System.Drawing.Point(116, 66);
            this.cbx_textcolors.Name = "cbx_textcolors";
            this.cbx_textcolors.Size = new System.Drawing.Size(285, 26);
            this.cbx_textcolors.TabIndex = 9;
            this.cbx_textcolors.SelectedValueChanged += new System.EventHandler(this.cbx_textcolors_SelectedValueChanged);
            // 
            // cbx_colorFondo
            // 
            this.cbx_colorFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.cbx_colorFondo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_colorFondo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbx_colorFondo.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx_colorFondo.FormattingEnabled = true;
            this.cbx_colorFondo.Location = new System.Drawing.Point(116, 105);
            this.cbx_colorFondo.Name = "cbx_colorFondo";
            this.cbx_colorFondo.Size = new System.Drawing.Size(285, 26);
            this.cbx_colorFondo.TabIndex = 11;
            this.cbx_colorFondo.SelectedValueChanged += new System.EventHandler(this.cbx_colorFondo_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Los cambios se aplicarán la próxima vez que abra el formulario.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_cerrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_TextColor);
            this.groupBox1.Controls.Add(this.cbx_colorFondo);
            this.groupBox1.Controls.Add(this.lbl_backgroundcolor);
            this.groupBox1.Controls.Add(this.cbx_textcolors);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 245);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "Configurar Consola";
            // 
            // PropiedadesConsola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(420, 252);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PropiedadesConsola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PropiedadesConsola";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PropiedadesConsola_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_TextColor;
        private System.Windows.Forms.Label lbl_backgroundcolor;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.ComboBox cbx_textcolors;
        private System.Windows.Forms.ComboBox cbx_colorFondo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}
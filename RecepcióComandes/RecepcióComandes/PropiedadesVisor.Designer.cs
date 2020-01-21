namespace RecepcióComandes
{
    partial class PropiedadesVisor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ShowLines = new System.Windows.Forms.Label();
            this.rb_lines_yes = new System.Windows.Forms.RadioButton();
            this.rb_lines_no = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_botones_no = new System.Windows.Forms.RadioButton();
            this.rb_botones_yes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbl_sangria = new System.Windows.Forms.Label();
            this.txtb_colorPicker = new System.Windows.Forms.TextBox();
            this.lbl_LinesColour = new System.Windows.Forms.Label();
            this.SelectorColores = new System.Windows.Forms.ColorDialog();
            this.trb_ancho = new System.Windows.Forms.TrackBar();
            this.lbl_trackbarValue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_ancho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_trackbarValue);
            this.groupBox1.Controls.Add(this.trb_ancho);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rb_botones_no);
            this.groupBox1.Controls.Add(this.rb_botones_yes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_cerrar);
            this.groupBox1.Controls.Add(this.lbl_sangria);
            this.groupBox1.Controls.Add(this.txtb_colorPicker);
            this.groupBox1.Controls.Add(this.lbl_LinesColour);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Los cambios se aplicarán la próxima vez que abra el formulario.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_ShowLines);
            this.panel1.Controls.Add(this.rb_lines_yes);
            this.panel1.Controls.Add(this.rb_lines_no);
            this.panel1.Location = new System.Drawing.Point(12, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 27);
            this.panel1.TabIndex = 17;
            // 
            // lbl_ShowLines
            // 
            this.lbl_ShowLines.AutoSize = true;
            this.lbl_ShowLines.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ShowLines.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ShowLines.Location = new System.Drawing.Point(42, 4);
            this.lbl_ShowLines.Name = "lbl_ShowLines";
            this.lbl_ShowLines.Size = new System.Drawing.Size(101, 18);
            this.lbl_ShowLines.TabIndex = 4;
            this.lbl_ShowLines.Text = "Mostrar líneas:";
            // 
            // rb_lines_yes
            // 
            this.rb_lines_yes.AutoSize = true;
            this.rb_lines_yes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.rb_lines_yes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb_lines_yes.Location = new System.Drawing.Point(149, 2);
            this.rb_lines_yes.Name = "rb_lines_yes";
            this.rb_lines_yes.Size = new System.Drawing.Size(37, 22);
            this.rb_lines_yes.TabIndex = 9;
            this.rb_lines_yes.TabStop = true;
            this.rb_lines_yes.Text = "Sí";
            this.rb_lines_yes.UseVisualStyleBackColor = true;
            this.rb_lines_yes.Click += new System.EventHandler(this.rb_lines_yes_Click);
            // 
            // rb_lines_no
            // 
            this.rb_lines_no.AutoSize = true;
            this.rb_lines_no.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.rb_lines_no.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb_lines_no.Location = new System.Drawing.Point(192, 2);
            this.rb_lines_no.Name = "rb_lines_no";
            this.rb_lines_no.Size = new System.Drawing.Size(44, 22);
            this.rb_lines_no.TabIndex = 10;
            this.rb_lines_no.TabStop = true;
            this.rb_lines_no.Text = "No";
            this.rb_lines_no.UseVisualStyleBackColor = true;
            this.rb_lines_no.Click += new System.EventHandler(this.rb_lines_no_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Configurar Tree Node";
            // 
            // rb_botones_no
            // 
            this.rb_botones_no.AutoSize = true;
            this.rb_botones_no.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.rb_botones_no.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb_botones_no.Location = new System.Drawing.Point(204, 168);
            this.rb_botones_no.Name = "rb_botones_no";
            this.rb_botones_no.Size = new System.Drawing.Size(44, 22);
            this.rb_botones_no.TabIndex = 14;
            this.rb_botones_no.TabStop = true;
            this.rb_botones_no.Text = "No";
            this.rb_botones_no.UseVisualStyleBackColor = true;
            this.rb_botones_no.Click += new System.EventHandler(this.rb_botones_no_Click);
            // 
            // rb_botones_yes
            // 
            this.rb_botones_yes.AutoSize = true;
            this.rb_botones_yes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.rb_botones_yes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb_botones_yes.Location = new System.Drawing.Point(161, 168);
            this.rb_botones_yes.Name = "rb_botones_yes";
            this.rb_botones_yes.Size = new System.Drawing.Size(37, 22);
            this.rb_botones_yes.TabIndex = 13;
            this.rb_botones_yes.TabStop = true;
            this.rb_botones_yes.Text = "Sí";
            this.rb_botones_yes.UseVisualStyleBackColor = true;
            this.rb_botones_yes.Click += new System.EventHandler(this.rb_botones_yes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mostrar botones \'+\' \'-\':";
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reset.Location = new System.Drawing.Point(196, 239);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(105, 30);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "Reset config";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cerrar.Location = new System.Drawing.Point(307, 239);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(86, 30);
            this.btn_cerrar.TabIndex = 8;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lbl_sangria
            // 
            this.lbl_sangria.AutoSize = true;
            this.lbl_sangria.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_sangria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_sangria.Location = new System.Drawing.Point(57, 98);
            this.lbl_sangria.Name = "lbl_sangria";
            this.lbl_sangria.Size = new System.Drawing.Size(98, 18);
            this.lbl_sangria.TabIndex = 2;
            this.lbl_sangria.Text = "Ancho sangría:";
            // 
            // txtb_colorPicker
            // 
            this.txtb_colorPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.txtb_colorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtb_colorPicker.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtb_colorPicker.Location = new System.Drawing.Point(161, 61);
            this.txtb_colorPicker.Name = "txtb_colorPicker";
            this.txtb_colorPicker.Size = new System.Drawing.Size(156, 26);
            this.txtb_colorPicker.TabIndex = 1;
            this.txtb_colorPicker.Click += new System.EventHandler(this.txtb_colorPicker_Click);
            // 
            // lbl_LinesColour
            // 
            this.lbl_LinesColour.AutoSize = true;
            this.lbl_LinesColour.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_LinesColour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_LinesColour.Location = new System.Drawing.Point(70, 64);
            this.lbl_LinesColour.Name = "lbl_LinesColour";
            this.lbl_LinesColour.Size = new System.Drawing.Size(85, 18);
            this.lbl_LinesColour.TabIndex = 0;
            this.lbl_LinesColour.Text = "Color líneas:";
            // 
            // trb_ancho
            // 
            this.trb_ancho.Location = new System.Drawing.Point(151, 92);
            this.trb_ancho.Maximum = 20;
            this.trb_ancho.Minimum = 1;
            this.trb_ancho.Name = "trb_ancho";
            this.trb_ancho.Size = new System.Drawing.Size(166, 45);
            this.trb_ancho.TabIndex = 18;
            this.trb_ancho.Value = 1;
            this.trb_ancho.ValueChanged += new System.EventHandler(this.trb_ancho_ValueChanged);
            // 
            // lbl_trackbarValue
            // 
            this.lbl_trackbarValue.AutoSize = true;
            this.lbl_trackbarValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_trackbarValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_trackbarValue.Location = new System.Drawing.Point(314, 92);
            this.lbl_trackbarValue.Name = "lbl_trackbarValue";
            this.lbl_trackbarValue.Size = new System.Drawing.Size(22, 18);
            this.lbl_trackbarValue.TabIndex = 19;
            this.lbl_trackbarValue.Text = "14";
            // 
            // PropiedadesVisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(422, 290);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PropiedadesVisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.PropiedadesVisor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_ancho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_LinesColour;
        private System.Windows.Forms.TextBox txtb_colorPicker;
        private System.Windows.Forms.Label lbl_sangria;
        private System.Windows.Forms.Label lbl_ShowLines;
        private System.Windows.Forms.ColorDialog SelectorColores;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.RadioButton rb_lines_no;
        private System.Windows.Forms.RadioButton rb_lines_yes;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_botones_no;
        private System.Windows.Forms.RadioButton rb_botones_yes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trb_ancho;
        private System.Windows.Forms.Label lbl_trackbarValue;
    }
}
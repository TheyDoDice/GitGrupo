namespace ConnectarBBDD
{
    using CC_Library;
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.swTextbox14 = new CC_Library.SWTextbox();
            this.swTextbox12 = new CC_Library.SWTextbox();
            this.swTextbox11 = new CC_Library.SWTextbox();
            this.swMenuItem1 = new CC_Library.SWMenuItem();
            this.swComboFK1 = new CC_Library.SWComboFK();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(625, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripció";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Regió";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(626, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // swTextbox14
            // 
            this.swTextbox14.ControlID = null;
            this.swTextbox14.DadaTipus = CC_Library.SWTextbox.tipDades.Numero;
            this.swTextbox14.foranea = true;
            this.swTextbox14.Location = new System.Drawing.Point(297, 182);
            this.swTextbox14.mensaje = null;
            this.swTextbox14.Name = "swTextbox14";
            this.swTextbox14.nomCamp = "idCategoriaAliments";
            this.swTextbox14.nomComboBox = "swComboFK2";
            this.swTextbox14.requerit = false;
            this.swTextbox14.Size = new System.Drawing.Size(21, 20);
            this.swTextbox14.TabIndex = 6;
            this.swTextbox14.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swTextbox12
            // 
            this.swTextbox12.ControlID = null;
            this.swTextbox12.DadaTipus = CC_Library.SWTextbox.tipDades.Numero;
            this.swTextbox12.foranea = false;
            this.swTextbox12.Location = new System.Drawing.Point(155, 78);
            this.swTextbox12.mensaje = null;
            this.swTextbox12.Name = "swTextbox12";
            this.swTextbox12.nomCamp = "DescAliment";
            this.swTextbox12.nomComboBox = null;
            this.swTextbox12.requerit = false;
            this.swTextbox12.Size = new System.Drawing.Size(100, 20);
            this.swTextbox12.TabIndex = 3;
            this.swTextbox12.TipusControl = CC_Library.SWTextbox.tipControlRef.SWCodi;
            // 
            // swTextbox11
            // 
            this.swTextbox11.ControlID = null;
            this.swTextbox11.DadaTipus = CC_Library.SWTextbox.tipDades.Codi;
            this.swTextbox11.foranea = false;
            this.swTextbox11.Location = new System.Drawing.Point(155, 52);
            this.swTextbox11.mensaje = null;
            this.swTextbox11.Name = "swTextbox11";
            this.swTextbox11.nomCamp = "CodiAliment";
            this.swTextbox11.nomComboBox = null;
            this.swTextbox11.requerit = false;
            this.swTextbox11.Size = new System.Drawing.Size(100, 20);
            this.swTextbox11.TabIndex = 2;
            this.swTextbox11.TipusControl = CC_Library.SWTextbox.tipControlRef.SWCodi;
            // 
            // swMenuItem1
            // 
            this.swMenuItem1.Location = new System.Drawing.Point(526, 26);
            this.swMenuItem1.Name = "swMenuItem1";
            this.swMenuItem1.NameSpace = "Usuarios";
            this.swMenuItem1.NomClasse = "MantenimientoUsuarios";
            this.swMenuItem1.NomDLL = "Usuarios";
            this.swMenuItem1.PanelForm = null;
            this.swMenuItem1.Picture = null;
            this.swMenuItem1.Size = new System.Drawing.Size(177, 46);
            this.swMenuItem1.TabIndex = 20;
            this.swMenuItem1.Texto = "label1";
            // 
            // swComboFK1
            // 
            this.swComboFK1.ControlID = "swTextbox14";
            this.swComboFK1.DisplayMember = "DescAliment";
            this.swComboFK1.FormattingEnabled = true;
            this.swComboFK1.Location = new System.Drawing.Point(134, 181);
            this.swComboFK1.Name = "swComboFK1";
            this.swComboFK1.NomTaula = "Aliments";
            this.swComboFK1.Size = new System.Drawing.Size(121, 21);
            this.swComboFK1.TabIndex = 21;
            this.swComboFK1.ValorId = "IdAliment";
            this.swComboFK1.ValueMember = "IdAliment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swComboFK1);
            this.Controls.Add(this.swMenuItem1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swTextbox14);
            this.Controls.Add(this.swTextbox12);
            this.Controls.Add(this.swTextbox11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private SWTextbox swTextbox11;
        private SWTextbox swTextbox12;
        private SWTextbox swTextbox14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private SWMenuItem swMenuItem1;
        private SWComboFK swComboFK1;
    }
}
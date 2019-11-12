namespace ConnectarBBDD
{
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.swComboFK2 = new CustomSWComboFK.SWComboFK();
            this.swTextbox14 = new SWTextbox.SWTextbox1();
            this.swTextbox13 = new SWTextbox.SWTextbox1();
            this.swTextbox12 = new SWTextbox.SWTextbox1();
            this.swTextbox11 = new SWTextbox.SWTextbox1();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Observacions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Regió";
            // 
            // swComboFK2
            // 
            this.swComboFK2.ControlID = "swTextbox14";
            this.swComboFK2.DisplayMember = "DescRegion";
            this.swComboFK2.FormattingEnabled = true;
            this.swComboFK2.Location = new System.Drawing.Point(155, 181);
            this.swComboFK2.Name = "swComboFK2";
            this.swComboFK2.NomTaula = "Regions";
            this.swComboFK2.Size = new System.Drawing.Size(131, 21);
            this.swComboFK2.TabIndex = 18;
            this.swComboFK2.ValorId = "idRegion";
            this.swComboFK2.ValueMember = "idRegion";
            // 
            // swTextbox14
            // 
            this.swTextbox14.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swTextbox14.Location = new System.Drawing.Point(297, 182);
            this.swTextbox14.mensaje = null;
            this.swTextbox14.Name = "swTextbox14";
            this.swTextbox14.nomCamp = "idRegion";
            this.swTextbox14.Size = new System.Drawing.Size(21, 20);
            this.swTextbox14.TabIndex = 6;
            this.swTextbox14.TipusControl = SWTextbox.SWTextbox1.tipControlRef.SWComboBox;
            // 
            // swTextbox13
            // 
            this.swTextbox13.DadaTipus = SWTextbox.SWTextbox1.tipDades.Text;
            this.swTextbox13.Location = new System.Drawing.Point(155, 104);
            this.swTextbox13.mensaje = null;
            this.swTextbox13.Multiline = true;
            this.swTextbox13.Name = "swTextbox13";
            this.swTextbox13.nomCamp = "Remarks";
            this.swTextbox13.Size = new System.Drawing.Size(376, 59);
            this.swTextbox13.TabIndex = 4;
            this.swTextbox13.TipusControl = SWTextbox.SWTextbox1.tipControlRef.SWComboBox;
            // 
            // swTextbox12
            // 
            this.swTextbox12.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swTextbox12.Location = new System.Drawing.Point(155, 78);
            this.swTextbox12.mensaje = null;
            this.swTextbox12.Name = "swTextbox12";
            this.swTextbox12.nomCamp = "DescSector";
            this.swTextbox12.Size = new System.Drawing.Size(100, 20);
            this.swTextbox12.TabIndex = 3;
            this.swTextbox12.TipusControl = SWTextbox.SWTextbox1.tipControlRef.SWCodi;
            // 
            // swTextbox11
            // 
            this.swTextbox11.DadaTipus = SWTextbox.SWTextbox1.tipDades.Codi;
            this.swTextbox11.Location = new System.Drawing.Point(155, 52);
            this.swTextbox11.mensaje = null;
            this.swTextbox11.Name = "swTextbox11";
            this.swTextbox11.nomCamp = "CodeSector";
            this.swTextbox11.Size = new System.Drawing.Size(100, 20);
            this.swTextbox11.TabIndex = 2;
            this.swTextbox11.TipusControl = SWTextbox.SWTextbox1.tipControlRef.SWCodi;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swComboFK2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swTextbox14);
            this.Controls.Add(this.swTextbox13);
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
        private SWTextbox.SWTextbox1 swTextbox11;
        private SWTextbox.SWTextbox1 swTextbox12;
        private SWTextbox.SWTextbox1 swTextbox13;
        private SWTextbox.SWTextbox1 swTextbox14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomSWComboFK.SWComboFK swComboFK2;
    }
}
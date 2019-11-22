namespace Odisea_en_el_espacio
{
    partial class Jump
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_jump = new System.Windows.Forms.Button();
            this.dgv_planetes = new System.Windows.Forms.DataGridView();
            this.Planeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_planeta = new System.Windows.Forms.Label();
            this.lbl_dist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_planetes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_jump
            // 
            this.btn_jump.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jump.Location = new System.Drawing.Point(196, 227);
            this.btn_jump.Name = "btn_jump";
            this.btn_jump.Size = new System.Drawing.Size(75, 23);
            this.btn_jump.TabIndex = 15;
            this.btn_jump.Text = "JUMP";
            this.btn_jump.UseVisualStyleBackColor = true;
            this.btn_jump.Click += new System.EventHandler(this.Btn_jump_Click);
            // 
            // dgv_planetes
            // 
            this.dgv_planetes.AllowUserToAddRows = false;
            this.dgv_planetes.AllowUserToDeleteRows = false;
            this.dgv_planetes.AllowUserToResizeColumns = false;
            this.dgv_planetes.AllowUserToResizeRows = false;
            this.dgv_planetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_planetes.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_planetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_planetes.ColumnHeadersVisible = false;
            this.dgv_planetes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Planeta,
            this.Distancia,
            this.Visited});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_planetes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_planetes.Location = new System.Drawing.Point(12, 29);
            this.dgv_planetes.Name = "dgv_planetes";
            this.dgv_planetes.ReadOnly = true;
            this.dgv_planetes.RowHeadersVisible = false;
            this.dgv_planetes.Size = new System.Drawing.Size(259, 187);
            this.dgv_planetes.TabIndex = 14;
            this.dgv_planetes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_planetes_CellContentClick);
            // 
            // Planeta
            // 
            this.Planeta.HeaderText = "Planeta";
            this.Planeta.Name = "Planeta";
            this.Planeta.ReadOnly = true;
            // 
            // Distancia
            // 
            this.Distancia.HeaderText = "Distancia";
            this.Distancia.Name = "Distancia";
            this.Distancia.ReadOnly = true;
            // 
            // Visited
            // 
            this.Visited.FillWeight = 18F;
            this.Visited.HeaderText = "Visited";
            this.Visited.Name = "Visited";
            this.Visited.ReadOnly = true;
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(12, 227);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 16;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // lbl_planeta
            // 
            this.lbl_planeta.AutoSize = true;
            this.lbl_planeta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_planeta.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_planeta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_planeta.Location = new System.Drawing.Point(29, 11);
            this.lbl_planeta.Name = "lbl_planeta";
            this.lbl_planeta.Size = new System.Drawing.Size(69, 13);
            this.lbl_planeta.TabIndex = 25;
            this.lbl_planeta.Text = "PLANETA";
            // 
            // lbl_dist
            // 
            this.lbl_dist.AutoSize = true;
            this.lbl_dist.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dist.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_dist.Location = new System.Drawing.Point(138, 11);
            this.lbl_dist.Name = "lbl_dist";
            this.lbl_dist.Size = new System.Drawing.Size(79, 13);
            this.lbl_dist.TabIndex = 26;
            this.lbl_dist.Text = "DISTANCIA";
            // 
            // Jump
            // 
            this.AcceptButton = this.btn_jump;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(283, 259);
            this.Controls.Add(this.lbl_dist);
            this.Controls.Add(this.lbl_planeta);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_jump);
            this.Controls.Add(this.dgv_planetes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Jump";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jump";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Jump_FormClosed);
            this.Load += new System.EventHandler(this.Jump_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_planetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_jump;
        private System.Windows.Forms.DataGridView dgv_planetes;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_planeta;
        private System.Windows.Forms.Label lbl_dist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Planeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visited;
    }
}
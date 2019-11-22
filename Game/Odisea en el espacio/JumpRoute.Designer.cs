namespace Odisea_en_el_espacio
{
    partial class JumpRoute
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_jump = new System.Windows.Forms.Button();
            this.dgv_routes = new System.Windows.Forms.DataGridView();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_ruta = new System.Windows.Forms.Label();
            this.lbl_planeta = new System.Windows.Forms.Label();
            this.lbl_dist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_routes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_jump
            // 
            this.btn_jump.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jump.Location = new System.Drawing.Point(241, 199);
            this.btn_jump.Name = "btn_jump";
            this.btn_jump.Size = new System.Drawing.Size(75, 23);
            this.btn_jump.TabIndex = 19;
            this.btn_jump.Text = "JUMP";
            this.btn_jump.UseVisualStyleBackColor = true;
            this.btn_jump.Click += new System.EventHandler(this.Btn_jump_Click);
            // 
            // dgv_routes
            // 
            this.dgv_routes.AllowUserToAddRows = false;
            this.dgv_routes.AllowUserToDeleteRows = false;
            this.dgv_routes.AllowUserToResizeColumns = false;
            this.dgv_routes.AllowUserToResizeRows = false;
            this.dgv_routes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_routes.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_routes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_routes.ColumnHeadersVisible = false;
            this.dgv_routes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ruta,
            this.Destino,
            this.Distancia,
            this.Visited});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_routes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_routes.Location = new System.Drawing.Point(12, 31);
            this.dgv_routes.Name = "dgv_routes";
            this.dgv_routes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_routes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_routes.RowHeadersVisible = false;
            this.dgv_routes.Size = new System.Drawing.Size(304, 162);
            this.dgv_routes.TabIndex = 18;
            this.dgv_routes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_routes_CellContentClick);
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            this.Ruta.ReadOnly = true;
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
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
            this.btn_close.Location = new System.Drawing.Point(12, 199);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 20;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // lbl_ruta
            // 
            this.lbl_ruta.AutoSize = true;
            this.lbl_ruta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ruta.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ruta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ruta.Location = new System.Drawing.Point(24, 13);
            this.lbl_ruta.Name = "lbl_ruta";
            this.lbl_ruta.Size = new System.Drawing.Size(41, 13);
            this.lbl_ruta.TabIndex = 21;
            this.lbl_ruta.Text = "RUTA";
            // 
            // lbl_planeta
            // 
            this.lbl_planeta.AutoSize = true;
            this.lbl_planeta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_planeta.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_planeta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_planeta.Location = new System.Drawing.Point(115, 12);
            this.lbl_planeta.Name = "lbl_planeta";
            this.lbl_planeta.Size = new System.Drawing.Size(69, 13);
            this.lbl_planeta.TabIndex = 22;
            this.lbl_planeta.Text = "PLANETA";
            // 
            // lbl_dist
            // 
            this.lbl_dist.AutoSize = true;
            this.lbl_dist.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dist.Font = new System.Drawing.Font("Nasalization Rg", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_dist.Location = new System.Drawing.Point(216, 12);
            this.lbl_dist.Name = "lbl_dist";
            this.lbl_dist.Size = new System.Drawing.Size(79, 13);
            this.lbl_dist.TabIndex = 23;
            this.lbl_dist.Text = "DISTANCIA";
            // 
            // JumpRoute
            // 
            this.AcceptButton = this.btn_jump;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(328, 234);
            this.Controls.Add(this.lbl_dist);
            this.Controls.Add(this.lbl_planeta);
            this.Controls.Add(this.lbl_ruta);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_jump);
            this.Controls.Add(this.dgv_routes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JumpRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JumpRoute";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Jumpr_FormClosed);
            this.Load += new System.EventHandler(this.JumpRoute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_routes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_jump;
        private System.Windows.Forms.DataGridView dgv_routes;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_ruta;
        private System.Windows.Forms.Label lbl_planeta;
        private System.Windows.Forms.Label lbl_dist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visited;
    }
}
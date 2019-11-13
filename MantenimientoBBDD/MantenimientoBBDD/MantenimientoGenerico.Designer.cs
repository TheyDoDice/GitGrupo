namespace MantenimientoBBDD
{
    partial class MantenimientoGenerico
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
            this.btn_actualizarDataset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_insertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_actualizarDataset
            // 
            this.btn_actualizarDataset.Location = new System.Drawing.Point(25, 224);
            this.btn_actualizarDataset.Name = "btn_actualizarDataset";
            this.btn_actualizarDataset.Size = new System.Drawing.Size(117, 23);
            this.btn_actualizarDataset.TabIndex = 24;
            this.btn_actualizarDataset.Text = "Actualizar";
            this.btn_actualizarDataset.UseVisualStyleBackColor = true;
            this.btn_actualizarDataset.Click += new System.EventHandler(this.btn_actualizarDataset_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(590, 160);
            this.dataGridView1.TabIndex = 23;
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(151, 224);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(117, 23);
            this.btn_insertar.TabIndex = 22;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click_1);
            // 
            // MantenimientoGenerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_actualizarDataset);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_insertar);
            this.Name = "MantenimientoGenerico";
            this.Load += new System.EventHandler(this.MantenimientoGenerico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_actualizarDataset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_insertar;
    }
}


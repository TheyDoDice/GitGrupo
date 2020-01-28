namespace ProgramaPrincipal
{
    partial class HashTableEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashTableEditor));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorHashcodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorTextosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorColoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editoresToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(804, 24);
            this.MenuPrincipal.TabIndex = 3;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferenciasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // preferenciasToolStripMenuItem
            // 
            this.preferenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rutasToolStripMenuItem});
            this.preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem";
            this.preferenciasToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.preferenciasToolStripMenuItem.Text = "Preferencias";
            // 
            // rutasToolStripMenuItem
            // 
            this.rutasToolStripMenuItem.Name = "rutasToolStripMenuItem";
            this.rutasToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.rutasToolStripMenuItem.Text = "Rutas";
            this.rutasToolStripMenuItem.Click += new System.EventHandler(this.rutasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editoresToolStripMenuItem
            // 
            this.editoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorHashcodesToolStripMenuItem,
            this.editorTextosToolStripMenuItem,
            this.editorColoresToolStripMenuItem});
            this.editoresToolStripMenuItem.Name = "editoresToolStripMenuItem";
            this.editoresToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.editoresToolStripMenuItem.Text = "Editores";
            // 
            // editorHashcodesToolStripMenuItem
            // 
            this.editorHashcodesToolStripMenuItem.Name = "editorHashcodesToolStripMenuItem";
            this.editorHashcodesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorHashcodesToolStripMenuItem.Text = "Editor Hashcodes";
            this.editorHashcodesToolStripMenuItem.Click += new System.EventHandler(this.editorHashcodesToolStripMenuItem_Click);
            // 
            // editorTextosToolStripMenuItem
            // 
            this.editorTextosToolStripMenuItem.Name = "editorTextosToolStripMenuItem";
            this.editorTextosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorTextosToolStripMenuItem.Text = "Editor Textos";
            this.editorTextosToolStripMenuItem.Click += new System.EventHandler(this.editorTextosToolStripMenuItem_Click);
            // 
            // editorColoresToolStripMenuItem
            // 
            this.editorColoresToolStripMenuItem.Name = "editorColoresToolStripMenuItem";
            this.editorColoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorColoresToolStripMenuItem.Text = "Editor Colores";
            this.editorColoresToolStripMenuItem.Click += new System.EventHandler(this.editorColoresToolStripMenuItem_Click);
            // 
            // HashTableEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 454);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "HashTableEditor";
            this.Text = "Hash Table Editor";
            this.Load += new System.EventHandler(this.HashTableEditor_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorTextosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorHashcodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorColoresToolStripMenuItem;
    }
}


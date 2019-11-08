using System;

namespace ConnectarBBDD
{
    partial class frm_principal
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
            this.components = new System.ComponentModel.Container();
            this.bttn_mostrardades_sql = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_usuari = new System.Windows.Forms.Label();
            this.txtb_nom_usuari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_contrasenya = new System.Windows.Forms.TextBox();
            this.lb_salt = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lb_hash = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_insertar_usuario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtb_repetir_contrasenya = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.swComboFK2 = new SWComboFK.SWComboFK();
            this.lbl_SWComboFK = new System.Windows.Forms.Label();
            this.btn_actualitzar_taula = new System.Windows.Forms.Button();
            this.btn_delete_user = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_validar = new System.Windows.Forms.Button();
            this.txtb_validacio_contrasenya = new System.Windows.Forms.TextBox();
            this.txt_validacio_usuari = new System.Windows.Forms.TextBox();
            this.lb_validacio_contrasenya = new System.Windows.Forms.Label();
            this.lb_validacio_usuari = new System.Windows.Forms.Label();
            this.validador_usuari = new System.Windows.Forms.ErrorProvider(this.components);
            this.validador_contrasenya_igual = new System.Windows.Forms.ErrorProvider(this.components);
            this.validador_contrasenya_blanc = new System.Windows.Forms.ErrorProvider(this.components);
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validador_usuari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validador_contrasenya_igual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validador_contrasenya_blanc)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttn_mostrardades_sql
            // 
            this.bttn_mostrardades_sql.Location = new System.Drawing.Point(6, 16);
            this.bttn_mostrardades_sql.Name = "bttn_mostrardades_sql";
            this.bttn_mostrardades_sql.Size = new System.Drawing.Size(131, 23);
            this.bttn_mostrardades_sql.TabIndex = 12;
            this.bttn_mostrardades_sql.Text = "Mostrar Dades";
            this.bttn_mostrardades_sql.UseVisualStyleBackColor = true;
            this.bttn_mostrardades_sql.Click += new System.EventHandler(this.bttn_mostrardades_sql_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 326);
            this.dataGridView1.TabIndex = 15;
            // 
            // lb_usuari
            // 
            this.lb_usuari.AutoSize = true;
            this.lb_usuari.Location = new System.Drawing.Point(43, 16);
            this.lb_usuari.Name = "lb_usuari";
            this.lb_usuari.Size = new System.Drawing.Size(65, 13);
            this.lb_usuari.TabIndex = 2;
            this.lb_usuari.Text = "Nom Usuari:";
            // 
            // txtb_nom_usuari
            // 
            this.txtb_nom_usuari.Location = new System.Drawing.Point(113, 13);
            this.txtb_nom_usuari.Name = "txtb_nom_usuari";
            this.txtb_nom_usuari.Size = new System.Drawing.Size(117, 20);
            this.txtb_nom_usuari.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contrasenya:";
            // 
            // txtb_contrasenya
            // 
            this.txtb_contrasenya.Location = new System.Drawing.Point(113, 42);
            this.txtb_contrasenya.Name = "txtb_contrasenya";
            this.txtb_contrasenya.PasswordChar = '*';
            this.txtb_contrasenya.Size = new System.Drawing.Size(117, 20);
            this.txtb_contrasenya.TabIndex = 3;
            // 
            // lb_salt
            // 
            this.lb_salt.AutoSize = true;
            this.lb_salt.Location = new System.Drawing.Point(79, 101);
            this.lb_salt.Name = "lb_salt";
            this.lb_salt.Size = new System.Drawing.Size(28, 13);
            this.lb_salt.TabIndex = 6;
            this.lb_salt.Text = "Salt:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(113, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(316, 20);
            this.textBox3.TabIndex = 5;
            // 
            // lb_hash
            // 
            this.lb_hash.AutoSize = true;
            this.lb_hash.Location = new System.Drawing.Point(72, 130);
            this.lb_hash.Name = "lb_hash";
            this.lb_hash.Size = new System.Drawing.Size(35, 13);
            this.lb_hash.TabIndex = 8;
            this.lb_hash.Text = "Hash:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(113, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(316, 20);
            this.textBox4.TabIndex = 6;
            // 
            // btn_insertar_usuario
            // 
            this.btn_insertar_usuario.Location = new System.Drawing.Point(113, 162);
            this.btn_insertar_usuario.Name = "btn_insertar_usuario";
            this.btn_insertar_usuario.Size = new System.Drawing.Size(117, 23);
            this.btn_insertar_usuario.TabIndex = 7;
            this.btn_insertar_usuario.Text = "Insertar Usuari";
            this.btn_insertar_usuario.UseVisualStyleBackColor = true;
            this.btn_insertar_usuario.Click += new System.EventHandler(this.btn_insertar_usuario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtb_repetir_contrasenya);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lb_usuari);
            this.groupBox1.Controls.Add(this.btn_insertar_usuario);
            this.groupBox1.Controls.Add(this.txtb_nom_usuari);
            this.groupBox1.Controls.Add(this.lb_hash);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtb_contrasenya);
            this.groupBox1.Controls.Add(this.lb_salt);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtb_repetir_contrasenya
            // 
            this.txtb_repetir_contrasenya.Location = new System.Drawing.Point(113, 71);
            this.txtb_repetir_contrasenya.Name = "txtb_repetir_contrasenya";
            this.txtb_repetir_contrasenya.PasswordChar = '*';
            this.txtb_repetir_contrasenya.Size = new System.Drawing.Size(117, 20);
            this.txtb_repetir_contrasenya.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Repetir contrasenya:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.swComboFK2);
            this.groupBox2.Controls.Add(this.lbl_SWComboFK);
            this.groupBox2.Controls.Add(this.btn_actualitzar_taula);
            this.groupBox2.Controls.Add(this.btn_delete_user);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.bttn_mostrardades_sql);
            this.groupBox2.Location = new System.Drawing.Point(12, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 380);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(390, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 20);
            this.textBox1.TabIndex = 18;
            // 
            // swComboFK2
            // 
            this.swComboFK2.ControlID = "textBox1";
            this.swComboFK2.DisplayMember = "codeUser";
            this.swComboFK2.FormattingEnabled = true;
            this.swComboFK2.Location = new System.Drawing.Point(253, 18);
            this.swComboFK2.Name = "swComboFK2";
            this.swComboFK2.NomTaula = "Users";
            this.swComboFK2.Size = new System.Drawing.Size(131, 21);
            this.swComboFK2.TabIndex = 17;
            this.swComboFK2.Text = "Selecciona una opción";
            this.swComboFK2.ValueMember = "idUser";
            // 
            // lbl_SWComboFK
            // 
            this.lbl_SWComboFK.AutoSize = true;
            this.lbl_SWComboFK.Location = new System.Drawing.Point(173, 22);
            this.lbl_SWComboFK.Name = "lbl_SWComboFK";
            this.lbl_SWComboFK.Size = new System.Drawing.Size(74, 13);
            this.lbl_SWComboFK.TabIndex = 16;
            this.lbl_SWComboFK.Text = "SWComboFK:";
            // 
            // btn_actualitzar_taula
            // 
            this.btn_actualitzar_taula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_actualitzar_taula.Location = new System.Drawing.Point(580, 19);
            this.btn_actualitzar_taula.Name = "btn_actualitzar_taula";
            this.btn_actualitzar_taula.Size = new System.Drawing.Size(135, 23);
            this.btn_actualitzar_taula.TabIndex = 13;
            this.btn_actualitzar_taula.Text = "Actualitzar taula";
            this.btn_actualitzar_taula.UseVisualStyleBackColor = true;
            this.btn_actualitzar_taula.Visible = false;
            // 
            // btn_delete_user
            // 
            this.btn_delete_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_user.Location = new System.Drawing.Point(721, 19);
            this.btn_delete_user.Name = "btn_delete_user";
            this.btn_delete_user.Size = new System.Drawing.Size(127, 23);
            this.btn_delete_user.TabIndex = 14;
            this.btn_delete_user.Text = "Borrar Usuari";
            this.btn_delete_user.UseVisualStyleBackColor = true;
            this.btn_delete_user.Click += new System.EventHandler(this.btn_delete_user_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.btn_validar);
            this.groupBox3.Controls.Add(this.txtb_validacio_contrasenya);
            this.groupBox3.Controls.Add(this.txt_validacio_usuari);
            this.groupBox3.Controls.Add(this.lb_validacio_contrasenya);
            this.groupBox3.Controls.Add(this.lb_validacio_usuari);
            this.groupBox3.Location = new System.Drawing.Point(457, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 207);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btn_validar
            // 
            this.btn_validar.Location = new System.Drawing.Point(123, 71);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(75, 23);
            this.btn_validar.TabIndex = 10;
            this.btn_validar.Text = "Validar";
            this.btn_validar.UseVisualStyleBackColor = true;
            // 
            // txtb_validacio_contrasenya
            // 
            this.txtb_validacio_contrasenya.Location = new System.Drawing.Point(81, 42);
            this.txtb_validacio_contrasenya.Name = "txtb_validacio_contrasenya";
            this.txtb_validacio_contrasenya.PasswordChar = '*';
            this.txtb_validacio_contrasenya.Size = new System.Drawing.Size(117, 20);
            this.txtb_validacio_contrasenya.TabIndex = 9;
            // 
            // txt_validacio_usuari
            // 
            this.txt_validacio_usuari.Location = new System.Drawing.Point(81, 13);
            this.txt_validacio_usuari.Name = "txt_validacio_usuari";
            this.txt_validacio_usuari.Size = new System.Drawing.Size(117, 20);
            this.txt_validacio_usuari.TabIndex = 8;
            // 
            // lb_validacio_contrasenya
            // 
            this.lb_validacio_contrasenya.AutoSize = true;
            this.lb_validacio_contrasenya.Location = new System.Drawing.Point(6, 45);
            this.lb_validacio_contrasenya.Name = "lb_validacio_contrasenya";
            this.lb_validacio_contrasenya.Size = new System.Drawing.Size(69, 13);
            this.lb_validacio_contrasenya.TabIndex = 1;
            this.lb_validacio_contrasenya.Text = "Contrasenya:";
            // 
            // lb_validacio_usuari
            // 
            this.lb_validacio_usuari.AutoSize = true;
            this.lb_validacio_usuari.Location = new System.Drawing.Point(35, 16);
            this.lb_validacio_usuari.Name = "lb_validacio_usuari";
            this.lb_validacio_usuari.Size = new System.Drawing.Size(40, 13);
            this.lb_validacio_usuari.TabIndex = 0;
            this.lb_validacio_usuari.Text = "Usuari:";
            // 
            // validador_usuari
            // 
            this.validador_usuari.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.validador_usuari.ContainerControl = this;
            // 
            // validador_contrasenya_igual
            // 
            this.validador_contrasenya_igual.ContainerControl = this;
            // 
            // validador_contrasenya_blanc
            // 
            this.validador_contrasenya_blanc.ContainerControl = this;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(1, 2, 0, 2);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(878, 24);
            this.MainMenu.TabIndex = 12;
            this.MainMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(93, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 632);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainMenu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "frm_principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validador_usuari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validador_contrasenya_igual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validador_contrasenya_blanc)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void form1(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button bttn_mostrardades_sql;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_usuari;
        private System.Windows.Forms.TextBox txtb_nom_usuari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_contrasenya;
        private System.Windows.Forms.Label lb_salt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lb_hash;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_insertar_usuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.TextBox txtb_validacio_contrasenya;
        private System.Windows.Forms.TextBox txt_validacio_usuari;
        private System.Windows.Forms.Label lb_validacio_contrasenya;
        private System.Windows.Forms.Label lb_validacio_usuari;
        private System.Windows.Forms.TextBox txtb_repetir_contrasenya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_actualitzar_taula;
        private System.Windows.Forms.Button btn_delete_user;
        private System.Windows.Forms.ErrorProvider validador_usuari;
        private System.Windows.Forms.ErrorProvider validador_contrasenya_igual;
        private System.Windows.Forms.ErrorProvider validador_contrasenya_blanc;
        private System.Windows.Forms.Label lbl_SWComboFK;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private SWComboFK.SWComboFK swComboFK1;
        private SWComboFK.SWComboFK swComboFK2;
        private System.Windows.Forms.TextBox textBox1;
    }
}


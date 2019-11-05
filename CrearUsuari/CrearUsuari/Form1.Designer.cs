namespace CrearUsuari
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_actualitzar_taula = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_photo = new System.Windows.Forms.Label();
            this.txt_photo = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.lb_codeUser = new System.Windows.Forms.Label();
            this.btn_insertar_usuario = new System.Windows.Forms.Button();
            this.txt_codeUser = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_actualitzar_taula);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 347);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // btn_actualitzar_taula
            // 
            this.btn_actualitzar_taula.Location = new System.Drawing.Point(6, 317);
            this.btn_actualitzar_taula.Name = "btn_actualitzar_taula";
            this.btn_actualitzar_taula.Size = new System.Drawing.Size(135, 23);
            this.btn_actualitzar_taula.TabIndex = 13;
            this.btn_actualitzar_taula.Text = "Actualitzar taula";
            this.btn_actualitzar_taula.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(702, 293);
            this.dataGridView1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lbl_photo);
            this.groupBox1.Controls.Add(this.txt_photo);
            this.groupBox1.Controls.Add(this.lbl_login);
            this.groupBox1.Controls.Add(this.txt_login);
            this.groupBox1.Controls.Add(this.lbl_UserName);
            this.groupBox1.Controls.Add(this.txt_userName);
            this.groupBox1.Controls.Add(this.lb_codeUser);
            this.groupBox1.Controls.Add(this.btn_insertar_usuario);
            this.groupBox1.Controls.Add(this.txt_codeUser);
            this.groupBox1.Controls.Add(this.lbl_password);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 207);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // lbl_photo
            // 
            this.lbl_photo.AutoSize = true;
            this.lbl_photo.Location = new System.Drawing.Point(236, 20);
            this.lbl_photo.Name = "lbl_photo";
            this.lbl_photo.Size = new System.Drawing.Size(38, 13);
            this.lbl_photo.TabIndex = 13;
            this.lbl_photo.Text = "Photo:";
            // 
            // txt_photo
            // 
            this.txt_photo.Location = new System.Drawing.Point(307, 17);
            this.txt_photo.Name = "txt_photo";
            this.txt_photo.PasswordChar = '*';
            this.txt_photo.Size = new System.Drawing.Size(117, 20);
            this.txt_photo.TabIndex = 12;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(469, 20);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(36, 13);
            this.lbl_login.TabIndex = 11;
            this.lbl_login.Text = "Login:";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(540, 17);
            this.txt_login.Name = "txt_login";
            this.txt_login.PasswordChar = '*';
            this.txt_login.Size = new System.Drawing.Size(117, 20);
            this.txt_login.TabIndex = 10;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(17, 52);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(63, 13);
            this.lbl_UserName.TabIndex = 8;
            this.lbl_UserName.Text = "User Name:";
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(88, 49);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(112, 20);
            this.txt_userName.TabIndex = 9;
            // 
            // lb_codeUser
            // 
            this.lb_codeUser.AutoSize = true;
            this.lb_codeUser.Location = new System.Drawing.Point(17, 20);
            this.lb_codeUser.Name = "lb_codeUser";
            this.lb_codeUser.Size = new System.Drawing.Size(60, 13);
            this.lb_codeUser.TabIndex = 2;
            this.lb_codeUser.Text = "Code User:";
            // 
            // btn_insertar_usuario
            // 
            this.btn_insertar_usuario.Location = new System.Drawing.Point(20, 166);
            this.btn_insertar_usuario.Name = "btn_insertar_usuario";
            this.btn_insertar_usuario.Size = new System.Drawing.Size(117, 23);
            this.btn_insertar_usuario.TabIndex = 7;
            this.btn_insertar_usuario.Text = "Insertar Usuari";
            this.btn_insertar_usuario.UseVisualStyleBackColor = true;
            this.btn_insertar_usuario.Click += new System.EventHandler(this.btn_insertar_usuario_Click);
            // 
            // txt_codeUser
            // 
            this.txt_codeUser.Location = new System.Drawing.Point(88, 17);
            this.txt_codeUser.Name = "txt_codeUser";
            this.txt_codeUser.Size = new System.Drawing.Size(53, 20);
            this.txt_codeUser.TabIndex = 2;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(236, 56);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(307, 53);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(117, 20);
            this.txt_password.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 577);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_actualitzar_taula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_photo;
        private System.Windows.Forms.TextBox txt_photo;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label lb_codeUser;
        private System.Windows.Forms.Button btn_insertar_usuario;
        private System.Windows.Forms.TextBox txt_codeUser;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}


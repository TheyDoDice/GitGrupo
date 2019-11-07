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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.swc_UserSpecie = new WindowsFormsControlLibrary.SWCodi();
            this.lbl_UserSpecie = new System.Windows.Forms.Label();
            this.swc_UserPlanet = new WindowsFormsControlLibrary.SWCodi();
            this.lbl_UserPlanet = new System.Windows.Forms.Label();
            this.swc_UserCategory = new WindowsFormsControlLibrary.SWCodi();
            this.lbl_UserCategory = new System.Windows.Forms.Label();
            this.swc_UserRank = new WindowsFormsControlLibrary.SWCodi();
            this.lbl_UserRank = new System.Windows.Forms.Label();
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
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 257);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
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
            this.dataGridView1.Size = new System.Drawing.Size(689, 222);
            this.dataGridView1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.swc_UserSpecie);
            this.groupBox1.Controls.Add(this.lbl_UserSpecie);
            this.groupBox1.Controls.Add(this.swc_UserPlanet);
            this.groupBox1.Controls.Add(this.lbl_UserPlanet);
            this.groupBox1.Controls.Add(this.swc_UserCategory);
            this.groupBox1.Controls.Add(this.lbl_UserCategory);
            this.groupBox1.Controls.Add(this.swc_UserRank);
            this.groupBox1.Controls.Add(this.lbl_UserRank);
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
            this.groupBox1.Size = new System.Drawing.Size(729, 264);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // swc_UserSpecie
            // 
            this.swc_UserSpecie.ClasseCS = null;
            this.swc_UserSpecie.CodiID = null;
            this.swc_UserSpecie.ControlID = null;
            this.swc_UserSpecie.FormCS = null;
            this.swc_UserSpecie.Location = new System.Drawing.Point(97, 177);
            this.swc_UserSpecie.Name = "swc_UserSpecie";
            this.swc_UserSpecie.NomCodi = "CodeSpecie";
            this.swc_UserSpecie.NomDesc = "DescSpecie";
            this.swc_UserSpecie.NomID = "idSpecie";
            this.swc_UserSpecie.NomTaula = "Species";
            this.swc_UserSpecie.Requerit = false;
            this.swc_UserSpecie.Size = new System.Drawing.Size(510, 25);
            this.swc_UserSpecie.TabIndex = 10;
            // 
            // lbl_UserSpecie
            // 
            this.lbl_UserSpecie.AutoSize = true;
            this.lbl_UserSpecie.Location = new System.Drawing.Point(19, 183);
            this.lbl_UserSpecie.Name = "lbl_UserSpecie";
            this.lbl_UserSpecie.Size = new System.Drawing.Size(43, 13);
            this.lbl_UserSpecie.TabIndex = 20;
            this.lbl_UserSpecie.Text = "Specie:";
            // 
            // swc_UserPlanet
            // 
            this.swc_UserPlanet.ClasseCS = null;
            this.swc_UserPlanet.CodiID = null;
            this.swc_UserPlanet.ControlID = null;
            this.swc_UserPlanet.FormCS = null;
            this.swc_UserPlanet.Location = new System.Drawing.Point(97, 143);
            this.swc_UserPlanet.Name = "swc_UserPlanet";
            this.swc_UserPlanet.NomCodi = "CodePlanet";
            this.swc_UserPlanet.NomDesc = "DescPlanet";
            this.swc_UserPlanet.NomID = "idPlanet";
            this.swc_UserPlanet.NomTaula = "Planets";
            this.swc_UserPlanet.Requerit = false;
            this.swc_UserPlanet.Size = new System.Drawing.Size(510, 25);
            this.swc_UserPlanet.TabIndex = 9;
            // 
            // lbl_UserPlanet
            // 
            this.lbl_UserPlanet.AutoSize = true;
            this.lbl_UserPlanet.Location = new System.Drawing.Point(19, 149);
            this.lbl_UserPlanet.Name = "lbl_UserPlanet";
            this.lbl_UserPlanet.Size = new System.Drawing.Size(40, 13);
            this.lbl_UserPlanet.TabIndex = 18;
            this.lbl_UserPlanet.Text = "Planet:";
            // 
            // swc_UserCategory
            // 
            this.swc_UserCategory.ClasseCS = null;
            this.swc_UserCategory.CodiID = null;
            this.swc_UserCategory.ControlID = null;
            this.swc_UserCategory.FormCS = null;
            this.swc_UserCategory.Location = new System.Drawing.Point(97, 112);
            this.swc_UserCategory.Name = "swc_UserCategory";
            this.swc_UserCategory.NomCodi = "CodeCategory";
            this.swc_UserCategory.NomDesc = "DescCategory";
            this.swc_UserCategory.NomID = "idUserCategory";
            this.swc_UserCategory.NomTaula = "UserCategories";
            this.swc_UserCategory.Requerit = false;
            this.swc_UserCategory.Size = new System.Drawing.Size(510, 25);
            this.swc_UserCategory.TabIndex = 8;
            // 
            // lbl_UserCategory
            // 
            this.lbl_UserCategory.AutoSize = true;
            this.lbl_UserCategory.Location = new System.Drawing.Point(19, 117);
            this.lbl_UserCategory.Name = "lbl_UserCategory";
            this.lbl_UserCategory.Size = new System.Drawing.Size(77, 13);
            this.lbl_UserCategory.TabIndex = 16;
            this.lbl_UserCategory.Text = "User Category:";
            // 
            // swc_UserRank
            // 
            this.swc_UserRank.ClasseCS = null;
            this.swc_UserRank.CodiID = null;
            this.swc_UserRank.ControlID = null;
            this.swc_UserRank.FormCS = null;
            this.swc_UserRank.Location = new System.Drawing.Point(97, 79);
            this.swc_UserRank.Name = "swc_UserRank";
            this.swc_UserRank.NomCodi = "CodeRank";
            this.swc_UserRank.NomDesc = "DescRank";
            this.swc_UserRank.NomID = "idUserRank";
            this.swc_UserRank.NomTaula = "UserRanks";
            this.swc_UserRank.Requerit = false;
            this.swc_UserRank.Size = new System.Drawing.Size(487, 30);
            this.swc_UserRank.TabIndex = 7;
            // 
            // lbl_UserRank
            // 
            this.lbl_UserRank.AutoSize = true;
            this.lbl_UserRank.Location = new System.Drawing.Point(19, 84);
            this.lbl_UserRank.Name = "lbl_UserRank";
            this.lbl_UserRank.Size = new System.Drawing.Size(61, 13);
            this.lbl_UserRank.TabIndex = 14;
            this.lbl_UserRank.Text = "User Rank:";
            // 
            // lbl_photo
            // 
            this.lbl_photo.AutoSize = true;
            this.lbl_photo.Location = new System.Drawing.Point(227, 20);
            this.lbl_photo.Name = "lbl_photo";
            this.lbl_photo.Size = new System.Drawing.Size(38, 13);
            this.lbl_photo.TabIndex = 13;
            this.lbl_photo.Text = "Photo:";
            // 
            // txt_photo
            // 
            this.txt_photo.Location = new System.Drawing.Point(298, 14);
            this.txt_photo.Name = "txt_photo";
            this.txt_photo.Size = new System.Drawing.Size(100, 20);
            this.txt_photo.TabIndex = 3;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(434, 16);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(36, 13);
            this.lbl_login.TabIndex = 11;
            this.lbl_login.Text = "Login:";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(476, 13);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(100, 20);
            this.txt_login.TabIndex = 4;
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
            this.txt_userName.Location = new System.Drawing.Point(100, 49);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(100, 20);
            this.txt_userName.TabIndex = 5;
            // 
            // lb_codeUser
            // 
            this.lb_codeUser.AutoSize = true;
            this.lb_codeUser.Location = new System.Drawing.Point(17, 21);
            this.lb_codeUser.Name = "lb_codeUser";
            this.lb_codeUser.Size = new System.Drawing.Size(60, 13);
            this.lb_codeUser.TabIndex = 2;
            this.lb_codeUser.Text = "Code User:";
            // 
            // btn_insertar_usuario
            // 
            this.btn_insertar_usuario.Location = new System.Drawing.Point(20, 222);
            this.btn_insertar_usuario.Name = "btn_insertar_usuario";
            this.btn_insertar_usuario.Size = new System.Drawing.Size(117, 23);
            this.btn_insertar_usuario.TabIndex = 11;
            this.btn_insertar_usuario.Text = "Insertar Usuari";
            this.btn_insertar_usuario.UseVisualStyleBackColor = true;
            this.btn_insertar_usuario.Click += new System.EventHandler(this.btn_insertar_usuario_Click);
            // 
            // txt_codeUser
            // 
            this.txt_codeUser.Location = new System.Drawing.Point(100, 17);
            this.txt_codeUser.Name = "txt_codeUser";
            this.txt_codeUser.Size = new System.Drawing.Size(100, 20);
            this.txt_codeUser.TabIndex = 2;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(227, 56);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(298, 53);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 560);
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
        private System.Windows.Forms.Label lbl_UserRank;
        private WindowsFormsControlLibrary.SWCodi swc_UserRank;
        private WindowsFormsControlLibrary.SWCodi swc_UserCategory;
        private System.Windows.Forms.Label lbl_UserCategory;
        private WindowsFormsControlLibrary.SWCodi swc_UserSpecie;
        private System.Windows.Forms.Label lbl_UserSpecie;
        private WindowsFormsControlLibrary.SWCodi swc_UserPlanet;
        private System.Windows.Forms.Label lbl_UserPlanet;
    }
}


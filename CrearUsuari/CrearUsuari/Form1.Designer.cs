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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_insertar_usuario = new System.Windows.Forms.Button();
            this.lb_codeUser = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_photo = new System.Windows.Forms.Label();
            this.lbl_UserRank = new System.Windows.Forms.Label();
            this.lbl_UserCategory = new System.Windows.Forms.Label();
            this.lbl_UserPlanet = new System.Windows.Forms.Label();
            this.lbl_UserSpecie = new System.Windows.Forms.Label();
            this.swt_idSpecie = new SWTextbox.SWTextbox1();
            this.swt_idPlanet = new SWTextbox.SWTextbox1();
            this.swt_idUserCategory = new SWTextbox.SWTextbox1();
            this.swt_idUserRank = new SWTextbox.SWTextbox1();
            this.swt_login = new SWTextbox.SWTextbox1();
            this.swt_password = new SWTextbox.SWTextbox1();
            this.swt_photo = new SWTextbox.SWTextbox1();
            this.swt_userName = new SWTextbox.SWTextbox1();
            this.swt_codeUser = new SWTextbox.SWTextbox1();
            this.swc_UserSpecie = new WindowsFormsControlLibrary.SWCodi();
            this.swc_UserPlanet = new WindowsFormsControlLibrary.SWCodi();
            this.swc_UserCategory = new WindowsFormsControlLibrary.SWCodi();
            this.swc_UserRank = new WindowsFormsControlLibrary.SWCodi();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(631, 160);
            this.dataGridView1.TabIndex = 15;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(222, 57);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password:";
            // 
            // btn_insertar_usuario
            // 
            this.btn_insertar_usuario.Location = new System.Drawing.Point(15, 230);
            this.btn_insertar_usuario.Name = "btn_insertar_usuario";
            this.btn_insertar_usuario.Size = new System.Drawing.Size(117, 23);
            this.btn_insertar_usuario.TabIndex = 14;
            this.btn_insertar_usuario.Text = "Insertar Usuari";
            this.btn_insertar_usuario.UseVisualStyleBackColor = true;
            this.btn_insertar_usuario.Click += new System.EventHandler(this.btn_insertar_usuario_Click);
            // 
            // lb_codeUser
            // 
            this.lb_codeUser.AutoSize = true;
            this.lb_codeUser.Location = new System.Drawing.Point(12, 22);
            this.lb_codeUser.Name = "lb_codeUser";
            this.lb_codeUser.Size = new System.Drawing.Size(60, 13);
            this.lb_codeUser.TabIndex = 2;
            this.lb_codeUser.Text = "Code User:";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(11, 53);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(63, 13);
            this.lbl_UserName.TabIndex = 8;
            this.lbl_UserName.Text = "User Name:";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(429, 17);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(36, 13);
            this.lbl_login.TabIndex = 11;
            this.lbl_login.Text = "Login:";
            // 
            // lbl_photo
            // 
            this.lbl_photo.AutoSize = true;
            this.lbl_photo.Location = new System.Drawing.Point(222, 21);
            this.lbl_photo.Name = "lbl_photo";
            this.lbl_photo.Size = new System.Drawing.Size(38, 13);
            this.lbl_photo.TabIndex = 13;
            this.lbl_photo.Text = "Photo:";
            // 
            // lbl_UserRank
            // 
            this.lbl_UserRank.AutoSize = true;
            this.lbl_UserRank.Location = new System.Drawing.Point(14, 85);
            this.lbl_UserRank.Name = "lbl_UserRank";
            this.lbl_UserRank.Size = new System.Drawing.Size(61, 13);
            this.lbl_UserRank.TabIndex = 14;
            this.lbl_UserRank.Text = "User Rank:";
            // 
            // lbl_UserCategory
            // 
            this.lbl_UserCategory.AutoSize = true;
            this.lbl_UserCategory.Location = new System.Drawing.Point(14, 118);
            this.lbl_UserCategory.Name = "lbl_UserCategory";
            this.lbl_UserCategory.Size = new System.Drawing.Size(77, 13);
            this.lbl_UserCategory.TabIndex = 16;
            this.lbl_UserCategory.Text = "User Category:";
            // 
            // lbl_UserPlanet
            // 
            this.lbl_UserPlanet.AutoSize = true;
            this.lbl_UserPlanet.Location = new System.Drawing.Point(14, 150);
            this.lbl_UserPlanet.Name = "lbl_UserPlanet";
            this.lbl_UserPlanet.Size = new System.Drawing.Size(40, 13);
            this.lbl_UserPlanet.TabIndex = 18;
            this.lbl_UserPlanet.Text = "Planet:";
            // 
            // lbl_UserSpecie
            // 
            this.lbl_UserSpecie.AutoSize = true;
            this.lbl_UserSpecie.Location = new System.Drawing.Point(14, 184);
            this.lbl_UserSpecie.Name = "lbl_UserSpecie";
            this.lbl_UserSpecie.Size = new System.Drawing.Size(43, 13);
            this.lbl_UserSpecie.TabIndex = 20;
            this.lbl_UserSpecie.Text = "Specie:";
            // 
            // swt_idSpecie
            // 
            this.swt_idSpecie.controlID = "swc_UserSpecie";
            this.swt_idSpecie.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swt_idSpecie.foranea = true;
            this.swt_idSpecie.Location = new System.Drawing.Point(599, 178);
            this.swt_idSpecie.mensaje = null;
            this.swt_idSpecie.Name = "swt_idSpecie";
            this.swt_idSpecie.nomCamp = "idSpecie";
            this.swt_idSpecie.nomComboBox = null;
            this.swt_idSpecie.requerit = false;
            this.swt_idSpecie.Size = new System.Drawing.Size(43, 20);
            this.swt_idSpecie.TabIndex = 13;
            // 
            // swt_idPlanet
            // 
            this.swt_idPlanet.controlID = "swc_UserPlanet";
            this.swt_idPlanet.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swt_idPlanet.foranea = true;
            this.swt_idPlanet.Location = new System.Drawing.Point(598, 147);
            this.swt_idPlanet.mensaje = null;
            this.swt_idPlanet.Name = "swt_idPlanet";
            this.swt_idPlanet.nomCamp = "idPlanet";
            this.swt_idPlanet.nomComboBox = null;
            this.swt_idPlanet.requerit = false;
            this.swt_idPlanet.Size = new System.Drawing.Size(44, 20);
            this.swt_idPlanet.TabIndex = 11;
            // 
            // swt_idUserCategory
            // 
            this.swt_idUserCategory.controlID = "swc_UserCategory";
            this.swt_idUserCategory.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swt_idUserCategory.foranea = true;
            this.swt_idUserCategory.Location = new System.Drawing.Point(598, 118);
            this.swt_idUserCategory.mensaje = null;
            this.swt_idUserCategory.Name = "swt_idUserCategory";
            this.swt_idUserCategory.nomCamp = "idUserCategory";
            this.swt_idUserCategory.nomComboBox = null;
            this.swt_idUserCategory.requerit = false;
            this.swt_idUserCategory.Size = new System.Drawing.Size(44, 20);
            this.swt_idUserCategory.TabIndex = 9;
            // 
            // swt_idUserRank
            // 
            this.swt_idUserRank.controlID = "swc_UserRank";
            this.swt_idUserRank.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swt_idUserRank.foranea = true;
            this.swt_idUserRank.Location = new System.Drawing.Point(598, 85);
            this.swt_idUserRank.mensaje = null;
            this.swt_idUserRank.Name = "swt_idUserRank";
            this.swt_idUserRank.nomCamp = "iduserrank";
            this.swt_idUserRank.nomComboBox = null;
            this.swt_idUserRank.requerit = false;
            this.swt_idUserRank.Size = new System.Drawing.Size(44, 20);
            this.swt_idUserRank.TabIndex = 7;
            // 
            // swt_login
            // 
            this.swt_login.controlID = null;
            this.swt_login.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swt_login.foranea = false;
            this.swt_login.Location = new System.Drawing.Point(471, 15);
            this.swt_login.mensaje = null;
            this.swt_login.Name = "swt_login";
            this.swt_login.nomCamp = "Login";
            this.swt_login.nomComboBox = null;
            this.swt_login.requerit = false;
            this.swt_login.Size = new System.Drawing.Size(102, 20);
            this.swt_login.TabIndex = 3;
            // 
            // swt_password
            // 
            this.swt_password.controlID = null;
            this.swt_password.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swt_password.foranea = false;
            this.swt_password.Location = new System.Drawing.Point(279, 54);
            this.swt_password.mensaje = null;
            this.swt_password.Name = "swt_password";
            this.swt_password.nomCamp = "Password";
            this.swt_password.nomComboBox = null;
            this.swt_password.requerit = false;
            this.swt_password.Size = new System.Drawing.Size(102, 20);
            this.swt_password.TabIndex = 5;
            // 
            // swt_photo
            // 
            this.swt_photo.controlID = null;
            this.swt_photo.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swt_photo.foranea = false;
            this.swt_photo.Location = new System.Drawing.Point(279, 18);
            this.swt_photo.mensaje = null;
            this.swt_photo.Name = "swt_photo";
            this.swt_photo.nomCamp = "Photo";
            this.swt_photo.nomComboBox = null;
            this.swt_photo.requerit = false;
            this.swt_photo.Size = new System.Drawing.Size(102, 20);
            this.swt_photo.TabIndex = 2;
            // 
            // swt_userName
            // 
            this.swt_userName.controlID = null;
            this.swt_userName.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swt_userName.foranea = false;
            this.swt_userName.Location = new System.Drawing.Point(94, 54);
            this.swt_userName.mensaje = null;
            this.swt_userName.Name = "swt_userName";
            this.swt_userName.nomCamp = "Username";
            this.swt_userName.nomComboBox = null;
            this.swt_userName.requerit = false;
            this.swt_userName.Size = new System.Drawing.Size(102, 20);
            this.swt_userName.TabIndex = 4;
            // 
            // swt_codeUser
            // 
            this.swt_codeUser.controlID = null;
            this.swt_codeUser.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swt_codeUser.foranea = false;
            this.swt_codeUser.Location = new System.Drawing.Point(94, 19);
            this.swt_codeUser.mensaje = null;
            this.swt_codeUser.Name = "swt_codeUser";
            this.swt_codeUser.nomCamp = "CodeUser";
            this.swt_codeUser.nomComboBox = null;
            this.swt_codeUser.requerit = false;
            this.swt_codeUser.Size = new System.Drawing.Size(102, 20);
            this.swt_codeUser.TabIndex = 1;
            // 
            // swc_UserSpecie
            // 
            this.swc_UserSpecie.ClasseCS = null;
            this.swc_UserSpecie.CodiID = null;
            this.swc_UserSpecie.ControlID = "swTextbox19";
            this.swc_UserSpecie.FormCS = null;
            this.swc_UserSpecie.Location = new System.Drawing.Point(91, 178);
            this.swc_UserSpecie.Name = "swc_UserSpecie";
            this.swc_UserSpecie.NomCodi = "CodeSpecie";
            this.swc_UserSpecie.NomDesc = "DescSpecie";
            this.swc_UserSpecie.NomID = "idSpecie";
            this.swc_UserSpecie.NomTaula = "Species";
            this.swc_UserSpecie.Requerit = false;
            this.swc_UserSpecie.Size = new System.Drawing.Size(487, 25);
            this.swc_UserSpecie.TabIndex = 12;
            // 
            // swc_UserPlanet
            // 
            this.swc_UserPlanet.ClasseCS = null;
            this.swc_UserPlanet.CodiID = null;
            this.swc_UserPlanet.ControlID = "swTextbox18";
            this.swc_UserPlanet.FormCS = null;
            this.swc_UserPlanet.Location = new System.Drawing.Point(91, 144);
            this.swc_UserPlanet.Name = "swc_UserPlanet";
            this.swc_UserPlanet.NomCodi = "CodePlanet";
            this.swc_UserPlanet.NomDesc = "DescPlanet";
            this.swc_UserPlanet.NomID = "idPlanet";
            this.swc_UserPlanet.NomTaula = "Planets";
            this.swc_UserPlanet.Requerit = false;
            this.swc_UserPlanet.Size = new System.Drawing.Size(487, 25);
            this.swc_UserPlanet.TabIndex = 10;
            // 
            // swc_UserCategory
            // 
            this.swc_UserCategory.ClasseCS = null;
            this.swc_UserCategory.CodiID = null;
            this.swc_UserCategory.ControlID = "swTextbox17";
            this.swc_UserCategory.FormCS = null;
            this.swc_UserCategory.Location = new System.Drawing.Point(91, 113);
            this.swc_UserCategory.Name = "swc_UserCategory";
            this.swc_UserCategory.NomCodi = "CodeCategory";
            this.swc_UserCategory.NomDesc = "DescCategory";
            this.swc_UserCategory.NomID = "idUserCategory";
            this.swc_UserCategory.NomTaula = "UserCategories";
            this.swc_UserCategory.Requerit = false;
            this.swc_UserCategory.Size = new System.Drawing.Size(487, 25);
            this.swc_UserCategory.TabIndex = 8;
            // 
            // swc_UserRank
            // 
            this.swc_UserRank.ClasseCS = null;
            this.swc_UserRank.CodiID = null;
            this.swc_UserRank.ControlID = "txt_idUserRank";
            this.swc_UserRank.FormCS = null;
            this.swc_UserRank.Location = new System.Drawing.Point(91, 80);
            this.swc_UserRank.Name = "swc_UserRank";
            this.swc_UserRank.NomCodi = "CodeRank";
            this.swc_UserRank.NomDesc = "DescRank";
            this.swc_UserRank.NomID = "idUserRank";
            this.swc_UserRank.NomTaula = "UserRanks";
            this.swc_UserRank.Requerit = false;
            this.swc_UserRank.Size = new System.Drawing.Size(487, 30);
            this.swc_UserRank.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 446);
            this.Controls.Add(this.swt_idSpecie);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.swt_idPlanet);
            this.Controls.Add(this.swt_idUserCategory);
            this.Controls.Add(this.swt_login);
            this.Controls.Add(this.swt_idUserRank);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.btn_insertar_usuario);
            this.Controls.Add(this.swt_password);
            this.Controls.Add(this.lb_codeUser);
            this.Controls.Add(this.swt_photo);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.swt_userName);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.swt_codeUser);
            this.Controls.Add(this.lbl_photo);
            this.Controls.Add(this.swc_UserSpecie);
            this.Controls.Add(this.lbl_UserRank);
            this.Controls.Add(this.lbl_UserSpecie);
            this.Controls.Add(this.swc_UserRank);
            this.Controls.Add(this.swc_UserPlanet);
            this.Controls.Add(this.lbl_UserCategory);
            this.Controls.Add(this.lbl_UserPlanet);
            this.Controls.Add(this.swc_UserCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_insertar_usuario;
        private System.Windows.Forms.Label lb_codeUser;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_photo;
        private System.Windows.Forms.Label lbl_UserRank;
        private WindowsFormsControlLibrary.SWCodi swc_UserRank;
        private System.Windows.Forms.Label lbl_UserCategory;
        private WindowsFormsControlLibrary.SWCodi swc_UserCategory;
        private System.Windows.Forms.Label lbl_UserPlanet;
        private WindowsFormsControlLibrary.SWCodi swc_UserPlanet;
        private System.Windows.Forms.Label lbl_UserSpecie;
        private WindowsFormsControlLibrary.SWCodi swc_UserSpecie;
        private SWTextbox.SWTextbox1 swt_idSpecie;
        private SWTextbox.SWTextbox1 swt_idPlanet;
        private SWTextbox.SWTextbox1 swt_idUserCategory;
        private SWTextbox.SWTextbox1 swt_idUserRank;
        private SWTextbox.SWTextbox1 swt_login;
        private SWTextbox.SWTextbox1 swt_password;
        private SWTextbox.SWTextbox1 swt_photo;
        private SWTextbox.SWTextbox1 swt_userName;
        private SWTextbox.SWTextbox1 swt_codeUser;
    }
}


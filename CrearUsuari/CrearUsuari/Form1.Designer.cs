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
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_insertar_usuario = new System.Windows.Forms.Button();
            this.lb_codeUser = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_photo = new System.Windows.Forms.Label();
            this.lbl_UserRank = new System.Windows.Forms.Label();
            this.swc_UserRank = new WindowsFormsControlLibrary.SWCodi();
            this.lbl_UserCategory = new System.Windows.Forms.Label();
            this.swc_UserCategory = new WindowsFormsControlLibrary.SWCodi();
            this.lbl_UserPlanet = new System.Windows.Forms.Label();
            this.swc_UserPlanet = new WindowsFormsControlLibrary.SWCodi();
            this.lbl_UserSpecie = new System.Windows.Forms.Label();
            this.swc_UserSpecie = new WindowsFormsControlLibrary.SWCodi();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_codeUser = new SWTextbox.SWTextbox1();
            this.swTextbox12 = new SWTextbox.SWTextbox1();
            this.swTextbox13 = new SWTextbox.SWTextbox1();
            this.txt_password = new SWTextbox.SWTextbox1();
            this.swTextbox15 = new SWTextbox.SWTextbox1();
            this.txt_idUserRank = new SWTextbox.SWTextbox1();
            this.swTextbox17 = new SWTextbox.SWTextbox1();
            this.swTextbox18 = new SWTextbox.SWTextbox1();
            this.swTextbox19 = new SWTextbox.SWTextbox1();
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
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(227, 56);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password:";
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
            // lb_codeUser
            // 
            this.lb_codeUser.AutoSize = true;
            this.lb_codeUser.Location = new System.Drawing.Point(17, 21);
            this.lb_codeUser.Name = "lb_codeUser";
            this.lb_codeUser.Size = new System.Drawing.Size(60, 13);
            this.lb_codeUser.TabIndex = 2;
            this.lb_codeUser.Text = "Code User:";
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
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(434, 16);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(36, 13);
            this.lbl_login.TabIndex = 11;
            this.lbl_login.Text = "Login:";
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
            // lbl_UserRank
            // 
            this.lbl_UserRank.AutoSize = true;
            this.lbl_UserRank.Location = new System.Drawing.Point(19, 84);
            this.lbl_UserRank.Name = "lbl_UserRank";
            this.lbl_UserRank.Size = new System.Drawing.Size(61, 13);
            this.lbl_UserRank.TabIndex = 14;
            this.lbl_UserRank.Text = "User Rank:";
            // 
            // swc_UserRank
            // 
            this.swc_UserRank.ClasseCS = null;
            this.swc_UserRank.CodiID = null;
            this.swc_UserRank.ControlID = "txt_idUserRank";
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
            // lbl_UserCategory
            // 
            this.lbl_UserCategory.AutoSize = true;
            this.lbl_UserCategory.Location = new System.Drawing.Point(19, 117);
            this.lbl_UserCategory.Name = "lbl_UserCategory";
            this.lbl_UserCategory.Size = new System.Drawing.Size(77, 13);
            this.lbl_UserCategory.TabIndex = 16;
            this.lbl_UserCategory.Text = "User Category:";
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
            // lbl_UserPlanet
            // 
            this.lbl_UserPlanet.AutoSize = true;
            this.lbl_UserPlanet.Location = new System.Drawing.Point(19, 149);
            this.lbl_UserPlanet.Name = "lbl_UserPlanet";
            this.lbl_UserPlanet.Size = new System.Drawing.Size(40, 13);
            this.lbl_UserPlanet.TabIndex = 18;
            this.lbl_UserPlanet.Text = "Planet:";
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
            // lbl_UserSpecie
            // 
            this.lbl_UserSpecie.AutoSize = true;
            this.lbl_UserSpecie.Location = new System.Drawing.Point(19, 183);
            this.lbl_UserSpecie.Name = "lbl_UserSpecie";
            this.lbl_UserSpecie.Size = new System.Drawing.Size(43, 13);
            this.lbl_UserSpecie.TabIndex = 20;
            this.lbl_UserSpecie.Text = "Specie:";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.swTextbox19);
            this.groupBox1.Controls.Add(this.swTextbox18);
            this.groupBox1.Controls.Add(this.swTextbox17);
            this.groupBox1.Controls.Add(this.txt_idUserRank);
            this.groupBox1.Controls.Add(this.swTextbox15);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.swTextbox13);
            this.groupBox1.Controls.Add(this.swTextbox12);
            this.groupBox1.Controls.Add(this.txt_codeUser);
            this.groupBox1.Controls.Add(this.swc_UserSpecie);
            this.groupBox1.Controls.Add(this.lbl_UserSpecie);
            this.groupBox1.Controls.Add(this.swc_UserPlanet);
            this.groupBox1.Controls.Add(this.lbl_UserPlanet);
            this.groupBox1.Controls.Add(this.swc_UserCategory);
            this.groupBox1.Controls.Add(this.lbl_UserCategory);
            this.groupBox1.Controls.Add(this.swc_UserRank);
            this.groupBox1.Controls.Add(this.lbl_UserRank);
            this.groupBox1.Controls.Add(this.lbl_photo);
            this.groupBox1.Controls.Add(this.lbl_login);
            this.groupBox1.Controls.Add(this.lbl_UserName);
            this.groupBox1.Controls.Add(this.lb_codeUser);
            this.groupBox1.Controls.Add(this.btn_insertar_usuario);
            this.groupBox1.Controls.Add(this.lbl_password);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 264);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // txt_codeUser
            // 
            this.txt_codeUser.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.txt_codeUser.Location = new System.Drawing.Point(97, 18);
            this.txt_codeUser.mensaje = null;
            this.txt_codeUser.Name = "txt_codeUser";
            this.txt_codeUser.nomCamp = "CodeUser";
            this.txt_codeUser.Size = new System.Drawing.Size(102, 20);
            this.txt_codeUser.TabIndex = 22;
            // 
            // swTextbox12
            // 
            this.swTextbox12.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swTextbox12.Location = new System.Drawing.Point(97, 53);
            this.swTextbox12.mensaje = null;
            this.swTextbox12.Name = "swTextbox12";
            this.swTextbox12.nomCamp = "Username";
            this.swTextbox12.Size = new System.Drawing.Size(102, 20);
            this.swTextbox12.TabIndex = 23;
            // 
            // swTextbox13
            // 
            this.swTextbox13.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swTextbox13.Location = new System.Drawing.Point(284, 17);
            this.swTextbox13.mensaje = null;
            this.swTextbox13.Name = "swTextbox13";
            this.swTextbox13.nomCamp = "Photo";
            this.swTextbox13.Size = new System.Drawing.Size(102, 20);
            this.swTextbox13.TabIndex = 24;
            // 
            // txt_password
            // 
            this.txt_password.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.txt_password.Location = new System.Drawing.Point(284, 53);
            this.txt_password.mensaje = null;
            this.txt_password.Name = "txt_password";
            this.txt_password.nomCamp = "Password";
            this.txt_password.Size = new System.Drawing.Size(102, 20);
            this.txt_password.TabIndex = 25;
            // 
            // swTextbox15
            // 
            this.swTextbox15.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swTextbox15.Location = new System.Drawing.Point(476, 14);
            this.swTextbox15.mensaje = null;
            this.swTextbox15.Name = "swTextbox15";
            this.swTextbox15.nomCamp = "Login";
            this.swTextbox15.Size = new System.Drawing.Size(102, 20);
            this.swTextbox15.TabIndex = 26;
            // 
            // txt_idUserRank
            // 
            this.txt_idUserRank.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.txt_idUserRank.Location = new System.Drawing.Point(603, 84);
            this.txt_idUserRank.mensaje = null;
            this.txt_idUserRank.Name = "txt_idUserRank";
            this.txt_idUserRank.nomCamp = "iduserrank";
            this.txt_idUserRank.Size = new System.Drawing.Size(44, 20);
            this.txt_idUserRank.TabIndex = 27;
            // 
            // swTextbox17
            // 
            this.swTextbox17.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swTextbox17.Location = new System.Drawing.Point(603, 117);
            this.swTextbox17.mensaje = null;
            this.swTextbox17.Name = "swTextbox17";
            this.swTextbox17.nomCamp = "idUserCategory";
            this.swTextbox17.Size = new System.Drawing.Size(44, 20);
            this.swTextbox17.TabIndex = 28;
            // 
            // swTextbox18
            // 
            this.swTextbox18.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swTextbox18.Location = new System.Drawing.Point(603, 146);
            this.swTextbox18.mensaje = null;
            this.swTextbox18.Name = "swTextbox18";
            this.swTextbox18.nomCamp = "idPlanet";
            this.swTextbox18.Size = new System.Drawing.Size(44, 20);
            this.swTextbox18.TabIndex = 29;
            // 
            // swTextbox19
            // 
            this.swTextbox19.DadaTipus = SWTextbox.SWTextbox1.tipDades.Numero;
            this.swTextbox19.Location = new System.Drawing.Point(604, 177);
            this.swTextbox19.mensaje = null;
            this.swTextbox19.Name = "swTextbox19";
            this.swTextbox19.nomCamp = "idSpecie";
            this.swTextbox19.Size = new System.Drawing.Size(43, 20);
            this.swTextbox19.TabIndex = 30;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private SWTextbox.SWTextbox1 swTextbox19;
        private SWTextbox.SWTextbox1 swTextbox18;
        private SWTextbox.SWTextbox1 swTextbox17;
        private SWTextbox.SWTextbox1 txt_idUserRank;
        private SWTextbox.SWTextbox1 swTextbox15;
        private SWTextbox.SWTextbox1 txt_password;
        private SWTextbox.SWTextbox1 swTextbox13;
        private SWTextbox.SWTextbox1 swTextbox12;
        private SWTextbox.SWTextbox1 txt_codeUser;
    }
}


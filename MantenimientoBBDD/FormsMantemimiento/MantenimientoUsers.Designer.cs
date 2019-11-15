namespace FormsMantemimiento
{
    partial class MantenimientoUsers
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
            this.swt_idSpecie = new CC_Library.SWTextbox();
            this.swt_idPlanet = new CC_Library.SWTextbox();
            this.swt_idUserCategory = new CC_Library.SWTextbox();
            this.swt_login = new CC_Library.SWTextbox();
            this.swt_idUserRank = new CC_Library.SWTextbox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.swt_password = new CC_Library.SWTextbox();
            this.lb_codeUser = new System.Windows.Forms.Label();
            this.swt_photo = new CC_Library.SWTextbox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.swt_userName = new CC_Library.SWTextbox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.swt_codeUser = new CC_Library.SWTextbox();
            this.lbl_photo = new System.Windows.Forms.Label();
            this.swc_UserSpecie = new CC_Library.SWCodi();
            this.lbl_UserRank = new System.Windows.Forms.Label();
            this.lbl_UserSpecie = new System.Windows.Forms.Label();
            this.swc_UserRank = new CC_Library.SWCodi();
            this.swc_UserPlanet = new CC_Library.SWCodi();
            this.lbl_UserCategory = new System.Windows.Forms.Label();
            this.lbl_UserPlanet = new System.Windows.Forms.Label();
            this.swc_UserCategory = new CC_Library.SWCodi();
            this.SuspendLayout();
            // 
            // swt_idSpecie
            // 
            this.swt_idSpecie.ControlID = "swc_UserSpecie";
            this.swt_idSpecie.DadaTipus = CC_Library.SWTextbox.tipDades.Numero;
            this.swt_idSpecie.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_idSpecie.foranea = true;
            this.swt_idSpecie.ForeColor = System.Drawing.Color.DimGray;
            this.swt_idSpecie.Location = new System.Drawing.Point(653, 279);
            this.swt_idSpecie.mensaje = null;
            this.swt_idSpecie.Name = "swt_idSpecie";
            this.swt_idSpecie.nomCamp = "idSpecie";
            this.swt_idSpecie.nomComboBox = null;
            this.swt_idSpecie.requerit = false;
            this.swt_idSpecie.Size = new System.Drawing.Size(43, 32);
            this.swt_idSpecie.TabIndex = 64;
            this.swt_idSpecie.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_idPlanet
            // 
            this.swt_idPlanet.ControlID = "swc_UserPlanet";
            this.swt_idPlanet.DadaTipus = CC_Library.SWTextbox.tipDades.Numero;
            this.swt_idPlanet.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_idPlanet.foranea = true;
            this.swt_idPlanet.ForeColor = System.Drawing.Color.DimGray;
            this.swt_idPlanet.Location = new System.Drawing.Point(653, 238);
            this.swt_idPlanet.mensaje = null;
            this.swt_idPlanet.Name = "swt_idPlanet";
            this.swt_idPlanet.nomCamp = "idPlanet";
            this.swt_idPlanet.nomComboBox = null;
            this.swt_idPlanet.requerit = false;
            this.swt_idPlanet.Size = new System.Drawing.Size(43, 32);
            this.swt_idPlanet.TabIndex = 61;
            this.swt_idPlanet.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_idUserCategory
            // 
            this.swt_idUserCategory.ControlID = "swc_UserCategory";
            this.swt_idUserCategory.DadaTipus = CC_Library.SWTextbox.tipDades.Numero;
            this.swt_idUserCategory.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_idUserCategory.foranea = true;
            this.swt_idUserCategory.ForeColor = System.Drawing.Color.DimGray;
            this.swt_idUserCategory.Location = new System.Drawing.Point(653, 197);
            this.swt_idUserCategory.mensaje = null;
            this.swt_idUserCategory.Name = "swt_idUserCategory";
            this.swt_idUserCategory.nomCamp = "idUserCategory";
            this.swt_idUserCategory.nomComboBox = null;
            this.swt_idUserCategory.requerit = false;
            this.swt_idUserCategory.Size = new System.Drawing.Size(43, 32);
            this.swt_idUserCategory.TabIndex = 58;
            this.swt_idUserCategory.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_login
            // 
            this.swt_login.ControlID = null;
            this.swt_login.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_login.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_login.foranea = false;
            this.swt_login.ForeColor = System.Drawing.Color.DimGray;
            this.swt_login.Location = new System.Drawing.Point(757, 28);
            this.swt_login.mensaje = null;
            this.swt_login.Name = "swt_login";
            this.swt_login.nomCamp = "Login";
            this.swt_login.nomComboBox = null;
            this.swt_login.requerit = false;
            this.swt_login.Size = new System.Drawing.Size(187, 32);
            this.swt_login.TabIndex = 50;
            this.swt_login.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_idUserRank
            // 
            this.swt_idUserRank.ControlID = "swc_UserRank";
            this.swt_idUserRank.DadaTipus = CC_Library.SWTextbox.tipDades.Numero;
            this.swt_idUserRank.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_idUserRank.foranea = true;
            this.swt_idUserRank.ForeColor = System.Drawing.Color.DimGray;
            this.swt_idUserRank.Location = new System.Drawing.Point(653, 152);
            this.swt_idUserRank.mensaje = null;
            this.swt_idUserRank.Name = "swt_idUserRank";
            this.swt_idUserRank.nomCamp = "iduserrank";
            this.swt_idUserRank.nomComboBox = null;
            this.swt_idUserRank.requerit = false;
            this.swt_idUserRank.Size = new System.Drawing.Size(43, 32);
            this.swt_idUserRank.TabIndex = 55;
            this.swt_idUserRank.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(373, 91);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(97, 24);
            this.lbl_password.TabIndex = 52;
            this.lbl_password.Text = "Password:";
            // 
            // swt_password
            // 
            this.swt_password.ControlID = null;
            this.swt_password.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_password.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_password.foranea = false;
            this.swt_password.ForeColor = System.Drawing.Color.DimGray;
            this.swt_password.Location = new System.Drawing.Point(483, 89);
            this.swt_password.mensaje = null;
            this.swt_password.Name = "swt_password";
            this.swt_password.nomCamp = "Password";
            this.swt_password.nomComboBox = null;
            this.swt_password.requerit = false;
            this.swt_password.Size = new System.Drawing.Size(193, 32);
            this.swt_password.TabIndex = 53;
            this.swt_password.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // lb_codeUser
            // 
            this.lb_codeUser.AutoSize = true;
            this.lb_codeUser.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lb_codeUser.ForeColor = System.Drawing.Color.White;
            this.lb_codeUser.Location = new System.Drawing.Point(23, 38);
            this.lb_codeUser.Name = "lb_codeUser";
            this.lb_codeUser.Size = new System.Drawing.Size(102, 24);
            this.lb_codeUser.TabIndex = 48;
            this.lb_codeUser.Text = "Code User:";
            // 
            // swt_photo
            // 
            this.swt_photo.ControlID = null;
            this.swt_photo.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_photo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_photo.foranea = false;
            this.swt_photo.ForeColor = System.Drawing.Color.DimGray;
            this.swt_photo.Location = new System.Drawing.Point(483, 31);
            this.swt_photo.mensaje = null;
            this.swt_photo.Name = "swt_photo";
            this.swt_photo.nomCamp = "Photo";
            this.swt_photo.nomComboBox = null;
            this.swt_photo.requerit = false;
            this.swt_photo.Size = new System.Drawing.Size(193, 32);
            this.swt_photo.TabIndex = 49;
            this.swt_photo.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_UserName.ForeColor = System.Drawing.Color.White;
            this.lbl_UserName.Location = new System.Drawing.Point(24, 97);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(108, 24);
            this.lbl_UserName.TabIndex = 57;
            this.lbl_UserName.Text = "User Name:";
            // 
            // swt_userName
            // 
            this.swt_userName.ControlID = null;
            this.swt_userName.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_userName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_userName.foranea = false;
            this.swt_userName.ForeColor = System.Drawing.Color.DimGray;
            this.swt_userName.Location = new System.Drawing.Point(173, 88);
            this.swt_userName.mensaje = null;
            this.swt_userName.Name = "swt_userName";
            this.swt_userName.nomCamp = "Username";
            this.swt_userName.nomComboBox = null;
            this.swt_userName.requerit = false;
            this.swt_userName.Size = new System.Drawing.Size(193, 32);
            this.swt_userName.TabIndex = 51;
            this.swt_userName.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(691, 31);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(60, 24);
            this.lbl_login.TabIndex = 60;
            this.lbl_login.Text = "Login:";
            // 
            // swt_codeUser
            // 
            this.swt_codeUser.ControlID = null;
            this.swt_codeUser.DadaTipus = CC_Library.SWTextbox.tipDades.Text;
            this.swt_codeUser.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swt_codeUser.foranea = false;
            this.swt_codeUser.ForeColor = System.Drawing.Color.DimGray;
            this.swt_codeUser.Location = new System.Drawing.Point(172, 30);
            this.swt_codeUser.mensaje = null;
            this.swt_codeUser.Name = "swt_codeUser";
            this.swt_codeUser.nomCamp = "CodeUser";
            this.swt_codeUser.nomComboBox = null;
            this.swt_codeUser.requerit = false;
            this.swt_codeUser.Size = new System.Drawing.Size(194, 32);
            this.swt_codeUser.TabIndex = 47;
            this.swt_codeUser.TipusControl = CC_Library.SWTextbox.tipControlRef.SWComboBox;
            // 
            // lbl_photo
            // 
            this.lbl_photo.AutoSize = true;
            this.lbl_photo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_photo.ForeColor = System.Drawing.Color.White;
            this.lbl_photo.Location = new System.Drawing.Point(372, 32);
            this.lbl_photo.Name = "lbl_photo";
            this.lbl_photo.Size = new System.Drawing.Size(67, 24);
            this.lbl_photo.TabIndex = 63;
            this.lbl_photo.Text = "Photo:";
            // 
            // swc_UserSpecie
            // 
            this.swc_UserSpecie.ClasseCS = null;
            this.swc_UserSpecie.CodiID = null;
            this.swc_UserSpecie.ControlID = "swt_idSpecie";
            this.swc_UserSpecie.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swc_UserSpecie.ForeColor = System.Drawing.Color.DimGray;
            this.swc_UserSpecie.FormCS = null;
            this.swc_UserSpecie.Location = new System.Drawing.Point(169, 274);
            this.swc_UserSpecie.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.swc_UserSpecie.Name = "swc_UserSpecie";
            this.swc_UserSpecie.NomCodi = "CodeSpecie";
            this.swc_UserSpecie.NomDesc = "DescSpecie";
            this.swc_UserSpecie.NomID = "idSpecie";
            this.swc_UserSpecie.NomTaula = "Species";
            this.swc_UserSpecie.Requerit = false;
            this.swc_UserSpecie.Size = new System.Drawing.Size(487, 36);
            this.swc_UserSpecie.TabIndex = 62;
            // 
            // lbl_UserRank
            // 
            this.lbl_UserRank.AutoSize = true;
            this.lbl_UserRank.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_UserRank.ForeColor = System.Drawing.Color.White;
            this.lbl_UserRank.Location = new System.Drawing.Point(24, 160);
            this.lbl_UserRank.Name = "lbl_UserRank";
            this.lbl_UserRank.Size = new System.Drawing.Size(101, 24);
            this.lbl_UserRank.TabIndex = 65;
            this.lbl_UserRank.Text = "User Rank:";
            // 
            // lbl_UserSpecie
            // 
            this.lbl_UserSpecie.AutoSize = true;
            this.lbl_UserSpecie.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_UserSpecie.ForeColor = System.Drawing.Color.White;
            this.lbl_UserSpecie.Location = new System.Drawing.Point(28, 281);
            this.lbl_UserSpecie.Name = "lbl_UserSpecie";
            this.lbl_UserSpecie.Size = new System.Drawing.Size(69, 24);
            this.lbl_UserSpecie.TabIndex = 68;
            this.lbl_UserSpecie.Text = "Specie:";
            // 
            // swc_UserRank
            // 
            this.swc_UserRank.ClasseCS = null;
            this.swc_UserRank.CodiID = null;
            this.swc_UserRank.ControlID = "swt_idUserRank";
            this.swc_UserRank.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swc_UserRank.ForeColor = System.Drawing.Color.DimGray;
            this.swc_UserRank.FormCS = null;
            this.swc_UserRank.Location = new System.Drawing.Point(169, 147);
            this.swc_UserRank.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.swc_UserRank.Name = "swc_UserRank";
            this.swc_UserRank.NomCodi = "CodeRank";
            this.swc_UserRank.NomDesc = "DescRank";
            this.swc_UserRank.NomID = "idUserRank";
            this.swc_UserRank.NomTaula = "UserRanks";
            this.swc_UserRank.Requerit = false;
            this.swc_UserRank.Size = new System.Drawing.Size(487, 36);
            this.swc_UserRank.TabIndex = 54;
            // 
            // swc_UserPlanet
            // 
            this.swc_UserPlanet.ClasseCS = null;
            this.swc_UserPlanet.CodiID = null;
            this.swc_UserPlanet.ControlID = "swt_idPlanet";
            this.swc_UserPlanet.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swc_UserPlanet.ForeColor = System.Drawing.Color.DimGray;
            this.swc_UserPlanet.FormCS = null;
            this.swc_UserPlanet.Location = new System.Drawing.Point(169, 232);
            this.swc_UserPlanet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.swc_UserPlanet.Name = "swc_UserPlanet";
            this.swc_UserPlanet.NomCodi = "CodePlanet";
            this.swc_UserPlanet.NomDesc = "DescPlanet";
            this.swc_UserPlanet.NomID = "idPlanet";
            this.swc_UserPlanet.NomTaula = "Planets";
            this.swc_UserPlanet.Requerit = false;
            this.swc_UserPlanet.Size = new System.Drawing.Size(487, 36);
            this.swc_UserPlanet.TabIndex = 59;
            // 
            // lbl_UserCategory
            // 
            this.lbl_UserCategory.AutoSize = true;
            this.lbl_UserCategory.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_UserCategory.ForeColor = System.Drawing.Color.White;
            this.lbl_UserCategory.Location = new System.Drawing.Point(24, 196);
            this.lbl_UserCategory.Name = "lbl_UserCategory";
            this.lbl_UserCategory.Size = new System.Drawing.Size(133, 24);
            this.lbl_UserCategory.TabIndex = 66;
            this.lbl_UserCategory.Text = "User Category:";
            // 
            // lbl_UserPlanet
            // 
            this.lbl_UserPlanet.AutoSize = true;
            this.lbl_UserPlanet.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_UserPlanet.ForeColor = System.Drawing.Color.White;
            this.lbl_UserPlanet.Location = new System.Drawing.Point(27, 237);
            this.lbl_UserPlanet.Name = "lbl_UserPlanet";
            this.lbl_UserPlanet.Size = new System.Drawing.Size(70, 24);
            this.lbl_UserPlanet.TabIndex = 67;
            this.lbl_UserPlanet.Text = "Planet:";
            // 
            // swc_UserCategory
            // 
            this.swc_UserCategory.ClasseCS = null;
            this.swc_UserCategory.CodiID = null;
            this.swc_UserCategory.ControlID = "swt_idUserCategory";
            this.swc_UserCategory.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.swc_UserCategory.ForeColor = System.Drawing.Color.DimGray;
            this.swc_UserCategory.FormCS = null;
            this.swc_UserCategory.Location = new System.Drawing.Point(169, 190);
            this.swc_UserCategory.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.swc_UserCategory.Name = "swc_UserCategory";
            this.swc_UserCategory.NomCodi = "CodeCategory";
            this.swc_UserCategory.NomDesc = "DescCategory";
            this.swc_UserCategory.NomID = "idUserCategory";
            this.swc_UserCategory.NomTaula = "UserCategories";
            this.swc_UserCategory.Requerit = false;
            this.swc_UserCategory.Size = new System.Drawing.Size(487, 36);
            this.swc_UserCategory.TabIndex = 56;
            // 
            // MantenimientoUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(967, 783);
            this.Controls.Add(this.swt_idSpecie);
            this.Controls.Add(this.swt_idPlanet);
            this.Controls.Add(this.swt_idUserCategory);
            this.Controls.Add(this.swt_login);
            this.Controls.Add(this.swt_idUserRank);
            this.Controls.Add(this.lbl_password);
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
            this.Name = "MantenimientoUsers";
            this.tabla = "Users";
            this.Controls.SetChildIndex(this.swc_UserCategory, 0);
            this.Controls.SetChildIndex(this.lbl_UserPlanet, 0);
            this.Controls.SetChildIndex(this.lbl_UserCategory, 0);
            this.Controls.SetChildIndex(this.swc_UserPlanet, 0);
            this.Controls.SetChildIndex(this.swc_UserRank, 0);
            this.Controls.SetChildIndex(this.lbl_UserSpecie, 0);
            this.Controls.SetChildIndex(this.lbl_UserRank, 0);
            this.Controls.SetChildIndex(this.swc_UserSpecie, 0);
            this.Controls.SetChildIndex(this.lbl_photo, 0);
            this.Controls.SetChildIndex(this.swt_codeUser, 0);
            this.Controls.SetChildIndex(this.lbl_login, 0);
            this.Controls.SetChildIndex(this.swt_userName, 0);
            this.Controls.SetChildIndex(this.lbl_UserName, 0);
            this.Controls.SetChildIndex(this.swt_photo, 0);
            this.Controls.SetChildIndex(this.lb_codeUser, 0);
            this.Controls.SetChildIndex(this.swt_password, 0);
            this.Controls.SetChildIndex(this.lbl_password, 0);
            this.Controls.SetChildIndex(this.swt_idUserRank, 0);
            this.Controls.SetChildIndex(this.swt_login, 0);
            this.Controls.SetChildIndex(this.swt_idUserCategory, 0);
            this.Controls.SetChildIndex(this.swt_idPlanet, 0);
            this.Controls.SetChildIndex(this.swt_idSpecie, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CC_Library.SWTextbox swt_idSpecie;
        private CC_Library.SWTextbox swt_idPlanet;
        private CC_Library.SWTextbox swt_idUserCategory;
        private CC_Library.SWTextbox swt_login;
        private CC_Library.SWTextbox swt_idUserRank;
        private System.Windows.Forms.Label lbl_password;
        private CC_Library.SWTextbox swt_password;
        private System.Windows.Forms.Label lb_codeUser;
        private CC_Library.SWTextbox swt_photo;
        private System.Windows.Forms.Label lbl_UserName;
        private CC_Library.SWTextbox swt_userName;
        private System.Windows.Forms.Label lbl_login;
        private CC_Library.SWTextbox swt_codeUser;
        private System.Windows.Forms.Label lbl_photo;
        private CC_Library.SWCodi swc_UserSpecie;
        private System.Windows.Forms.Label lbl_UserRank;
        private System.Windows.Forms.Label lbl_UserSpecie;
        private CC_Library.SWCodi swc_UserRank;
        private CC_Library.SWCodi swc_UserPlanet;
        private System.Windows.Forms.Label lbl_UserCategory;
        private System.Windows.Forms.Label lbl_UserPlanet;
        private CC_Library.SWCodi swc_UserCategory;
    }
}

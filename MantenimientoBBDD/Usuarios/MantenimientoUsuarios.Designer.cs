using CC_Library;
namespace Usuarios
{
    partial class MantenimientoUsuarios
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
            this.swt_idSpecie = new SWTextbox();
            this.swt_idPlanet = new SWTextbox();
            this.swt_idUserCategory = new SWTextbox();
            this.swt_login = new SWTextbox();
            this.swt_idUserRank = new SWTextbox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.swt_password = new SWTextbox();
            this.lb_codeUser = new System.Windows.Forms.Label();
            this.swt_photo = new SWTextbox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.swt_userName = new SWTextbox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.swt_codeUser = new SWTextbox();
            this.lbl_photo = new System.Windows.Forms.Label();
            this.swc_UserSpecie = new SWCodi();
            this.lbl_UserRank = new System.Windows.Forms.Label();
            this.lbl_UserSpecie = new System.Windows.Forms.Label();
            this.swc_UserRank = new SWCodi();
            this.swc_UserPlanet = new SWCodi();
            this.lbl_UserCategory = new System.Windows.Forms.Label();
            this.lbl_UserPlanet = new System.Windows.Forms.Label();
            this.swc_UserCategory = new SWCodi();
            this.SuspendLayout();
            // 
            // swt_idSpecie
            // 
            this.swt_idSpecie.ControlID = "swc_UserSpecie";
            this.swt_idSpecie.DadaTipus = SWTextbox.tipDades.Numero;
            this.swt_idSpecie.foranea = true;
            this.swt_idSpecie.Location = new System.Drawing.Point(609, 177);
            this.swt_idSpecie.mensaje = null;
            this.swt_idSpecie.Name = "swt_idSpecie";
            this.swt_idSpecie.nomCamp = "idSpecie";
            this.swt_idSpecie.nomComboBox = null;
            this.swt_idSpecie.requerit = false;
            this.swt_idSpecie.Size = new System.Drawing.Size(43, 20);
            this.swt_idSpecie.TabIndex = 42;
            this.swt_idSpecie.TipusControl = SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_idPlanet
            // 
            this.swt_idPlanet.ControlID = "swc_UserPlanet";
            this.swt_idPlanet.DadaTipus = SWTextbox.tipDades.Numero;
            this.swt_idPlanet.foranea = true;
            this.swt_idPlanet.Location = new System.Drawing.Point(608, 146);
            this.swt_idPlanet.mensaje = null;
            this.swt_idPlanet.Name = "swt_idPlanet";
            this.swt_idPlanet.nomCamp = "idPlanet";
            this.swt_idPlanet.nomComboBox = null;
            this.swt_idPlanet.requerit = false;
            this.swt_idPlanet.Size = new System.Drawing.Size(44, 20);
            this.swt_idPlanet.TabIndex = 39;
            this.swt_idPlanet.TipusControl = SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_idUserCategory
            // 
            this.swt_idUserCategory.ControlID = "swc_UserCategory";
            this.swt_idUserCategory.DadaTipus = SWTextbox.tipDades.Numero;
            this.swt_idUserCategory.foranea = true;
            this.swt_idUserCategory.Location = new System.Drawing.Point(608, 117);
            this.swt_idUserCategory.mensaje = null;
            this.swt_idUserCategory.Name = "swt_idUserCategory";
            this.swt_idUserCategory.nomCamp = "idUserCategory";
            this.swt_idUserCategory.nomComboBox = null;
            this.swt_idUserCategory.requerit = false;
            this.swt_idUserCategory.Size = new System.Drawing.Size(44, 20);
            this.swt_idUserCategory.TabIndex = 36;
            this.swt_idUserCategory.TipusControl = SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_login
            // 
            this.swt_login.ControlID = null;
            this.swt_login.DadaTipus = SWTextbox.tipDades.Text;
            this.swt_login.foranea = false;
            this.swt_login.Location = new System.Drawing.Point(481, 14);
            this.swt_login.mensaje = null;
            this.swt_login.Name = "swt_login";
            this.swt_login.nomCamp = "Login";
            this.swt_login.nomComboBox = null;
            this.swt_login.requerit = false;
            this.swt_login.Size = new System.Drawing.Size(102, 20);
            this.swt_login.TabIndex = 28;
            this.swt_login.TipusControl = SWTextbox.tipControlRef.SWComboBox;
            // 
            // swt_idUserRank
            // 
            this.swt_idUserRank.ControlID = "swc_UserRank";
            this.swt_idUserRank.DadaTipus = SWTextbox.tipDades.Numero;
            this.swt_idUserRank.foranea = true;
            this.swt_idUserRank.Location = new System.Drawing.Point(608, 84);
            this.swt_idUserRank.mensaje = null;
            this.swt_idUserRank.Name = "swt_idUserRank";
            this.swt_idUserRank.nomCamp = "iduserrank";
            this.swt_idUserRank.nomComboBox = null;
            this.swt_idUserRank.requerit = false;
            this.swt_idUserRank.Size = new System.Drawing.Size(44, 20);
            this.swt_idUserRank.TabIndex = 33;
            this.swt_idUserRank.TipusControl = SWTextbox.tipControlRef.SWComboBox;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(232, 56);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 30;
            this.lbl_password.Text = "Password:";
            // 
            // swt_password
            // 
            this.swt_password.ControlID = null;
            this.swt_password.DadaTipus = SWTextbox.tipDades.Text;
            this.swt_password.foranea = false;
            this.swt_password.Location = new System.Drawing.Point(289, 53);
            this.swt_password.mensaje = null;
            this.swt_password.Name = "swt_password";
            this.swt_password.nomCamp = "Password";
            this.swt_password.nomComboBox = null;
            this.swt_password.requerit = false;
            this.swt_password.Size = new System.Drawing.Size(102, 20);
            this.swt_password.TabIndex = 31;
            this.swt_password.TipusControl = SWTextbox.tipControlRef.SWComboBox;
            // 
            // lb_codeUser
            // 
            this.lb_codeUser.AutoSize = true;
            this.lb_codeUser.Location = new System.Drawing.Point(22, 21);
            this.lb_codeUser.Name = "lb_codeUser";
            this.lb_codeUser.Size = new System.Drawing.Size(60, 13);
            this.lb_codeUser.TabIndex = 26;
            this.lb_codeUser.Text = "Code User:";
            // 
            // swt_photo
            // 
            this.swt_photo.ControlID = null;
            this.swt_photo.DadaTipus = SWTextbox.tipDades.Text;
            this.swt_photo.foranea = false;
            this.swt_photo.Location = new System.Drawing.Point(289, 17);
            this.swt_photo.mensaje = null;
            this.swt_photo.Name = "swt_photo";
            this.swt_photo.nomCamp = "Photo";
            this.swt_photo.nomComboBox = null;
            this.swt_photo.requerit = false;
            this.swt_photo.Size = new System.Drawing.Size(102, 20);
            this.swt_photo.TabIndex = 27;
            this.swt_photo.TipusControl = SWTextbox.tipControlRef.SWComboBox;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(21, 52);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(63, 13);
            this.lbl_UserName.TabIndex = 35;
            this.lbl_UserName.Text = "User Name:";
            // 
            // swt_userName
            // 
            this.swt_userName.ControlID = null;
            this.swt_userName.DadaTipus = SWTextbox.tipDades.Text;
            this.swt_userName.foranea = false;
            this.swt_userName.Location = new System.Drawing.Point(104, 53);
            this.swt_userName.mensaje = null;
            this.swt_userName.Name = "swt_userName";
            this.swt_userName.nomCamp = "Username";
            this.swt_userName.nomComboBox = null;
            this.swt_userName.requerit = false;
            this.swt_userName.Size = new System.Drawing.Size(102, 20);
            this.swt_userName.TabIndex = 29;
            this.swt_userName.TipusControl = SWTextbox.tipControlRef.SWComboBox;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(439, 16);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(36, 13);
            this.lbl_login.TabIndex = 38;
            this.lbl_login.Text = "Login:";
            // 
            // swt_codeUser
            // 
            this.swt_codeUser.ControlID = null;
            this.swt_codeUser.DadaTipus = SWTextbox.tipDades.Text;
            this.swt_codeUser.foranea = false;
            this.swt_codeUser.Location = new System.Drawing.Point(104, 18);
            this.swt_codeUser.mensaje = null;
            this.swt_codeUser.Name = "swt_codeUser";
            this.swt_codeUser.nomCamp = "CodeUser";
            this.swt_codeUser.nomComboBox = null;
            this.swt_codeUser.requerit = false;
            this.swt_codeUser.Size = new System.Drawing.Size(102, 20);
            this.swt_codeUser.TabIndex = 25;
            this.swt_codeUser.TipusControl = SWTextbox.tipControlRef.SWComboBox;
            // 
            // lbl_photo
            // 
            this.lbl_photo.AutoSize = true;
            this.lbl_photo.Location = new System.Drawing.Point(232, 20);
            this.lbl_photo.Name = "lbl_photo";
            this.lbl_photo.Size = new System.Drawing.Size(38, 13);
            this.lbl_photo.TabIndex = 41;
            this.lbl_photo.Text = "Photo:";
            // 
            // swc_UserSpecie
            // 
            this.swc_UserSpecie.ClasseCS = null;
            this.swc_UserSpecie.CodiID = null;
            this.swc_UserSpecie.ControlID = "swt_idSpecie";
            this.swc_UserSpecie.FormCS = null;
            this.swc_UserSpecie.Location = new System.Drawing.Point(101, 177);
            this.swc_UserSpecie.Name = "swc_UserSpecie";
            this.swc_UserSpecie.NomCodi = "CodeSpecie";
            this.swc_UserSpecie.NomDesc = "DescSpecie";
            this.swc_UserSpecie.NomID = "idSpecie";
            this.swc_UserSpecie.NomTaula = "Species";
            this.swc_UserSpecie.Requerit = false;
            this.swc_UserSpecie.Size = new System.Drawing.Size(487, 25);
            this.swc_UserSpecie.TabIndex = 40;
            // 
            // lbl_UserRank
            // 
            this.lbl_UserRank.AutoSize = true;
            this.lbl_UserRank.Location = new System.Drawing.Point(24, 84);
            this.lbl_UserRank.Name = "lbl_UserRank";
            this.lbl_UserRank.Size = new System.Drawing.Size(61, 13);
            this.lbl_UserRank.TabIndex = 43;
            this.lbl_UserRank.Text = "User Rank:";
            // 
            // lbl_UserSpecie
            // 
            this.lbl_UserSpecie.AutoSize = true;
            this.lbl_UserSpecie.Location = new System.Drawing.Point(24, 183);
            this.lbl_UserSpecie.Name = "lbl_UserSpecie";
            this.lbl_UserSpecie.Size = new System.Drawing.Size(43, 13);
            this.lbl_UserSpecie.TabIndex = 46;
            this.lbl_UserSpecie.Text = "Specie:";
            // 
            // swc_UserRank
            // 
            this.swc_UserRank.ClasseCS = null;
            this.swc_UserRank.CodiID = null;
            this.swc_UserRank.ControlID = "swt_idUserRank";
            this.swc_UserRank.FormCS = null;
            this.swc_UserRank.Location = new System.Drawing.Point(101, 79);
            this.swc_UserRank.Name = "swc_UserRank";
            this.swc_UserRank.NomCodi = "CodeRank";
            this.swc_UserRank.NomDesc = "DescRank";
            this.swc_UserRank.NomID = "idUserRank";
            this.swc_UserRank.NomTaula = "UserRanks";
            this.swc_UserRank.Requerit = false;
            this.swc_UserRank.Size = new System.Drawing.Size(487, 30);
            this.swc_UserRank.TabIndex = 32;
            // 
            // swc_UserPlanet
            // 
            this.swc_UserPlanet.ClasseCS = null;
            this.swc_UserPlanet.CodiID = null;
            this.swc_UserPlanet.ControlID = "swt_idPlanet";
            this.swc_UserPlanet.FormCS = null;
            this.swc_UserPlanet.Location = new System.Drawing.Point(101, 143);
            this.swc_UserPlanet.Name = "swc_UserPlanet";
            this.swc_UserPlanet.NomCodi = "CodePlanet";
            this.swc_UserPlanet.NomDesc = "DescPlanet";
            this.swc_UserPlanet.NomID = "idPlanet";
            this.swc_UserPlanet.NomTaula = "Planets";
            this.swc_UserPlanet.Requerit = false;
            this.swc_UserPlanet.Size = new System.Drawing.Size(487, 25);
            this.swc_UserPlanet.TabIndex = 37;
            // 
            // lbl_UserCategory
            // 
            this.lbl_UserCategory.AutoSize = true;
            this.lbl_UserCategory.Location = new System.Drawing.Point(24, 117);
            this.lbl_UserCategory.Name = "lbl_UserCategory";
            this.lbl_UserCategory.Size = new System.Drawing.Size(77, 13);
            this.lbl_UserCategory.TabIndex = 44;
            this.lbl_UserCategory.Text = "User Category:";
            // 
            // lbl_UserPlanet
            // 
            this.lbl_UserPlanet.AutoSize = true;
            this.lbl_UserPlanet.Location = new System.Drawing.Point(24, 149);
            this.lbl_UserPlanet.Name = "lbl_UserPlanet";
            this.lbl_UserPlanet.Size = new System.Drawing.Size(40, 13);
            this.lbl_UserPlanet.TabIndex = 45;
            this.lbl_UserPlanet.Text = "Planet:";
            // 
            // swc_UserCategory
            // 
            this.swc_UserCategory.ClasseCS = null;
            this.swc_UserCategory.CodiID = null;
            this.swc_UserCategory.ControlID = "swt_idUserCategory";
            this.swc_UserCategory.FormCS = null;
            this.swc_UserCategory.Location = new System.Drawing.Point(101, 112);
            this.swc_UserCategory.Name = "swc_UserCategory";
            this.swc_UserCategory.NomCodi = "CodeCategory";
            this.swc_UserCategory.NomDesc = "DescCategory";
            this.swc_UserCategory.NomID = "idUserCategory";
            this.swc_UserCategory.NomTaula = "UserCategories";
            this.swc_UserCategory.Requerit = false;
            this.swc_UserCategory.Size = new System.Drawing.Size(487, 25);
            this.swc_UserCategory.TabIndex = 34;
            // 
            // MantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(668, 450);
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
            this.Name = "MantenimientoUsuarios";
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

        private SWTextbox swt_idSpecie;
        private SWTextbox swt_idPlanet;
        private SWTextbox swt_idUserCategory;
        private SWTextbox swt_login;
        private SWTextbox swt_idUserRank;
        private System.Windows.Forms.Label lbl_password;
        private SWTextbox swt_password;
        private System.Windows.Forms.Label lb_codeUser;
        private SWTextbox swt_photo;
        private System.Windows.Forms.Label lbl_UserName;
        private SWTextbox swt_userName;
        private System.Windows.Forms.Label lbl_login;
        private SWTextbox swt_codeUser;
        private System.Windows.Forms.Label lbl_photo;
        private SWCodi swc_UserSpecie;
        private System.Windows.Forms.Label lbl_UserRank;
        private System.Windows.Forms.Label lbl_UserSpecie;
        private SWCodi swc_UserRank;
        private SWCodi swc_UserPlanet;
        private System.Windows.Forms.Label lbl_UserCategory;
        private System.Windows.Forms.Label lbl_UserPlanet;
        private SWCodi swc_UserCategory;
    }
}

namespace ExpoEncriptacio
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
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hash = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.correcto = new System.Windows.Forms.Label();
            this.salt2 = new System.Windows.Forms.Label();
            this.salt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(42, 37);
            this.contraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(199, 26);
            this.contraseña.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SALT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "HASH:";
            // 
            // hash
            // 
            this.hash.AutoSize = true;
            this.hash.Location = new System.Drawing.Point(124, 186);
            this.hash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hash.Name = "hash";
            this.hash.Size = new System.Drawing.Size(0, 20);
            this.hash.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 280);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "SALT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 280);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "HASH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(492, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 346);
            this.panel1.TabIndex = 7;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(738, 37);
            this.login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(175, 26);
            this.login.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(860, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = ": SALT";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(807, 302);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 40);
            this.button3.TabIndex = 14;
            this.button3.Text = "HASH";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // correcto
            // 
            this.correcto.AutoSize = true;
            this.correcto.Location = new System.Drawing.Point(561, 312);
            this.correcto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.correcto.Name = "correcto";
            this.correcto.Size = new System.Drawing.Size(0, 20);
            this.correcto.TabIndex = 15;
            // 
            // salt2
            // 
            this.salt2.AutoSize = true;
            this.salt2.Location = new System.Drawing.Point(537, 123);
            this.salt2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salt2.Name = "salt2";
            this.salt2.Size = new System.Drawing.Size(0, 20);
            this.salt2.TabIndex = 16;
            // 
            // salt
            // 
            this.salt.AutoSize = true;
            this.salt.Location = new System.Drawing.Point(124, 123);
            this.salt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salt.Name = "salt";
            this.salt.Size = new System.Drawing.Size(0, 20);
            this.salt.TabIndex = 17;
            this.salt.TextChanged += new System.EventHandler(this.salt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(855, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = ": HASH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 382);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salt);
            this.Controls.Add(this.salt2);
            this.Controls.Add(this.correcto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contraseña);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label correcto;
        private System.Windows.Forms.Label salt2;
        private System.Windows.Forms.Label salt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBDD;

namespace ProyectoPrincipal.Forms
{
    public partial class Splash : Form
    {
        private int counter = 5;
        private string user;
        private string userRank;
        private DataSet menuOptions;
        public Menu menu;

        public Splash(string user, string userRank, DataSet menu)
        {
            this.user = user;
            this.userRank = userRank;
            this.menuOptions = menu;
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            lbl_splash.Text += user;
            menu = new Menu(user, userRank, menuOptions);
            menu.FormClosed += (se, ev) => this.Close();
            this.CenterToScreen();

            ptb_logo.Image = TakeImg("dark", "logo");
            ptb_meanwhile.Image = TakeImg("dark", "atat_1");
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            counter--;
            changeImg(counter);
            if (counter == 0)
            {
                timer.Stop();
                this.Hide();
                menu.Show();
            }
        }

        private void changeImg(int counter)
        {
            if (counter % 2 == 0)
            {
                ptb_meanwhile.Image = TakeImg("dark", "atat_1");
            }
            else
            {
                ptb_meanwhile.Image = TakeImg("dark", "atat_2");
            }
            ptb_meanwhile.Refresh();
        }
        private Image TakeImg(string mode, string name)
        {
            return Image.FromFile(Application.StartupPath + "\\Img\\" + mode + "_" + name + ".png");
        }
    }
}

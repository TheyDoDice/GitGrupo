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
using CC_Library;
using System.Text.RegularExpressions;

namespace FormsMantemimiento
{
    public partial class BuscaMantenimientoPlanets : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        securecoreEntities db;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public BuscaMantenimientoPlanets()
        {
            InitializeComponent();
            db = new securecoreEntities();
        }

        private Image TakeImg(string mode, string name)
        {
            return Image.FromFile(Application.StartupPath + "\\Img\\" + mode + "_" + name + ".png");
        }

        private void CercaMantenimientoPlanets_Load(object sender, EventArgs e)
        {

            //Botó tancar

            ptb_close.Image = TakeImg("dark", "close");
            ptb_close.MouseLeave += (se, ev) => ptb_close.BackColor = System.Drawing.ColorTranslator.FromHtml("#393939"); ;
            ptb_close.MouseEnter += (se, ev) => ptb_close.BackColor = Color.LightCoral;
            ptb_close.Click += (se, ev) => this.Close();
        }

        private void CercaMantenimientoPlanets_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_cercar_Click(object sender, EventArgs e)
        {
            List<Planets> planets;

            if (swt_idRegion.Text == "" || swt_idSpecie.Text == "")
            {
                planets = db.Planets.ToList();
            }
            else
            {
                planets = db.Planets.ToList().Where(x => x.idSector == int.Parse(swt_idRegion.Text) && x.idNatives == int.Parse(swt_idSpecie.Text)).ToList();
            }
           
            dataGridView_Planets.DataSource = planets;

            Regex rg = new Regex("^id");

            foreach (DataGridViewColumn item in dataGridView_Planets.Columns)
            {
                if (rg.Match(item.Name).Success || item.Name.Equals("Filiations") || item.Name.Equals("MilitaryCamps") ||
                    item.Name.Equals("OrdersDetail") || item.Name.Equals("PlanetRoutes") || item.Name.Equals("Sectors") ||
                    item.Name.Equals("Species") || item.Name.Equals("Users"))
                {
                    dataGridView_Planets.Columns[item.Name].Visible = false;
                }
            }
        }
    }
}




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
        SContext db;

        public BuscaMantenimientoPlanets()
        {
            InitializeComponent();
            db = new SContext();
        }

        private Image TakeImg(string mode, string name)
        {
            return Image.FromFile(Application.StartupPath + "\\Img\\" + mode + "_" + name + ".png");
        }

        private void btn_cercar_Click_1(object sender, EventArgs e)
        {

            if (swt_idRegion.Text == "" || swt_idSpecie.Text == "")
            {
                dataGridView_Planets.DataSource = db.Planets.ToList();
            }
            else
            {
                dataGridView_Planets.DataSource = db.Planets.ToList().Where(x => x.idSector == int.Parse(swt_idRegion.Text) && x.idNatives == int.Parse(swt_idSpecie.Text)).ToList();
            }
        }

        private void BuscaMantenimientoPlanets_Load(object sender, EventArgs e)
        {
            dataGridView_Planets.DataSource = db.Planets.ToList();

            Regex rg = new Regex("^id");

            List<string> camposEscondidos = new List<string>
            {
                "MilitaryCamps",
                "Filiations",
                "OrdersDetail",
                "PlanetRoutes",
                "Sectors",
                "Species",
                "Users",
                "PlanetPicture",
                "IPPlanet",
                "PortPlanet",
                "PortPlanet1"
            };

            foreach (DataGridViewColumn item in dataGridView_Planets.Columns)
            {
                if (rg.Match(item.Name).Success || camposEscondidos.Contains(item.Name))
                {
                    dataGridView_Planets.Columns[item.Name].Visible = false;
                }

            }
        }
    }
}




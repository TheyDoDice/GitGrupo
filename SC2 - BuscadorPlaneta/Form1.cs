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
using FormNave;

namespace BuscadorPlaneta
{
    public partial class Form1 : Form
    {
        private static SContext db = new SContext();
        private int idPlanet;
        private int idNave = 0;
        private string ip;

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbx_buscarPlaneta.DataSource = db.Planets.ToList();
            cmbx_buscarPlaneta.ValueMember = "DescPlanet";

            cmbx_buscarNau.DataSource = db.SpaceShips.ToList();
            cmbx_buscarNau.ValueMember = "CodeSpaceShip";
        }

        private void cmbx_buscarPlaneta_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPlanet = db.Planets.ToArray()[cmbx_buscarPlaneta.SelectedIndex].idPlanet;
        }

        private void cmbx_buscarNau_SelectedIndexChanged(object sender, EventArgs e)
        {
            idNave = db.SpaceShips.ToArray()[cmbx_buscarPlaneta.SelectedIndex].idSpaceShip;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nave = new FormNave.Nave(idNave, idPlanet, ip);
            nave.Show();
        }
    }
}

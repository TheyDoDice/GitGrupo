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

namespace BuscadorPlaneta
{
    public partial class Form1 : Form
    {
        private static SContext db = new SContext();
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbx_buscarPlaneta.DataSource = db.Planets.ToList();
            cmbx_buscarPlaneta.ValueMember = "DescPlanet";
        }
    }
}

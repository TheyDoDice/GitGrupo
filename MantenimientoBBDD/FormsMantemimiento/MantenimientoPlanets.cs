using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsMantemimiento
{
    public partial class MantenimientoPlanets : MantenimientoBBDD.MantenimientoGenerico
    {
        public MantenimientoPlanets()
        {
            InitializeComponent();
        }

        private void MantenimientoPlanets_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Form buscaManteniminetoPlanets = new BuscaMantenimientoPlanets();
                pnl_filtrar.Controls.Add(buscaManteniminetoPlanets);
                buscaManteniminetoPlanets.Show();
            }
        }
    }
}

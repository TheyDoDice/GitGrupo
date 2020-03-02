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
        private bool abrirForm = true;
        Form buscaManteniminetoPlanets = new BuscaMantenimientoPlanets();

        public MantenimientoPlanets()
        {
            InitializeComponent();
        }

        private void MantenimientoPlanets_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                abrirForm = abrirBusqueda(abrirForm);                
            }
        }

        private void btn_busqueda_Click(object sender, EventArgs e)
        {
            abrirForm = abrirBusqueda(abrirForm);
        }

        private bool abrirBusqueda (bool _abrirForm)
        {
            if (_abrirForm)
            {
                buscaManteniminetoPlanets.TopLevel = false;
                buscaManteniminetoPlanets.AutoScroll = true;
                pnl_filtrar.Controls.Add(buscaManteniminetoPlanets);
                buscaManteniminetoPlanets.Dock = DockStyle.Fill;
                buscaManteniminetoPlanets.Show();
                _abrirForm = false;
            }
            else
            {
                pnl_filtrar.Controls.Remove(buscaManteniminetoPlanets);
                _abrirForm = true;
            }
            return _abrirForm;
        }
    }
}

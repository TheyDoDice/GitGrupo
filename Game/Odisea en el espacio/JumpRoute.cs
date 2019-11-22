using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using LlibreriaMinijoc.Classes;

namespace Odisea_en_el_espacio
{
    public partial class JumpRoute : Form
    {
        int index;
        Rocket nave;
        public JumpRoute(Rocket nave)
        {
            InitializeComponent();
            this.nave = nave;
        }

        private void Btn_jump_Click(object sender, EventArgs e)
        {
            if (dgv_routes.SelectedCells.Count > 0)
            {
                string nameSelectedPlanet;
                nameSelectedPlanet = dgv_routes[1, dgv_routes.SelectedCells[0].RowIndex].Value.ToString();

                nave.actualPlanet = nave.Planets[nameSelectedPlanet];

                nave.Viaje();
                nave.position = nave.actualPlanet.Coords;
                nave.CanOpenJumpr = true;
                Close();
            }
        }

        private void Jumpr_FormClosed(object sender, EventArgs e)
        {
            nave.CanOpenJumpr = true;
            nave.CanOpenJump = true;
        }

        private void JumpRoute_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(Application.StartupPath + "\\Imagenes\\jump2.png");
            this.BackgroundImage = myimage;

            foreach (Route route in nave.actualPlanet.Routes)
            {
                Planet destino = (nave.actualPlanet == route.Start) ? route.End : route.Start;

                string distancia = Math.Round(Vector3.Distance(nave.actualPlanet.Coords, destino.Coords), 3).ToString() + " ua";

                dgv_routes.Rows.Add(new string[] { route.Name, destino.Name, distancia, destino.Visited ? "✔" : "✘" });
            }

            if (nave.CanViewFiliation)
            {
                foreach (DataGridViewRow row in dgv_routes.Rows)
                {
                    Planet p = nave.Planets[row.Cells[1].Value.ToString()];
                    if (p.Filiation == "First Order" || p.Filiation == "Unknown")
                    {
                        row.DefaultCellStyle.BackColor = Color.DarkRed;
                    } else
                    {
                        row.DefaultCellStyle.BackColor = Color.DarkGreen;
                    }
                }
            }

        }

        private void Dgv_routes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_routes.SelectedCells.Count > 0)
            {
                index = dgv_routes.SelectedCells[0].RowIndex;
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

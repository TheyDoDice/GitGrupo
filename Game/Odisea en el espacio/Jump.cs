using System;
using LlibreriaMinijoc.Classes;
using System.Collections.Generic;
using System.Windows.Forms;
using LlibreriaMinijoc;
using System.Drawing;

namespace Odisea_en_el_espacio
{
    public partial class Jump : Form
    {
        int index;
        Rocket nave;

        public Jump(Rocket nave)
        {
            InitializeComponent();
            this.nave = nave;
        }

        private void Btn_jump_Click(object sender, EventArgs e)
        {
            if (dgv_planetes.SelectedCells.Count > 0)
            {
                string nameSelectedPlanet;

                nameSelectedPlanet = dgv_planetes[0, dgv_planetes.SelectedCells[0].RowIndex].Value.ToString();


                nave.actualPlanet = nave.Planets[nameSelectedPlanet];

                nave.Viaje();
                nave.position = nave.actualPlanet.Coords;
                nave.CanOpenJump = true;
                Close();
            }
        }

        private void Jump_FormClosed(object sender, EventArgs e)
        {
            nave.CanOpenJump = true;
            nave.CanOpenJumpr = true;
        }

        private void Jump_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(Application.StartupPath + "\\Imagenes\\jump1.png");
            this.BackgroundImage = myimage;

            foreach (KeyValuePair<Planet, double> reg in Loader.GetClosestPlanets(nave.position, nave.DisponiblePlanets, nave.Planets))
            {
                dgv_planetes.Rows.Add(new string[] { reg.Key.Name, Math.Round(reg.Value, 2).ToString() + " ua", reg.Key.Visited ? "✔" : "✘"});
            }

            if (nave.CanViewFiliation)
            {
                foreach (DataGridViewRow row in dgv_planetes.Rows)
                {
                    Planet p = nave.Planets[row.Cells[0].Value.ToString()];
                    if (p.Filiation == "First Order" || p.Filiation == "Unknown")
                    {
                        row.DefaultCellStyle.BackColor = Color.DarkRed;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.DarkGreen;
                    }
                }
            }
        }

        private void Dgv_planetes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_planetes.SelectedCells.Count == 1)
            {
                index = dgv_planetes.SelectedCells[0].RowIndex;
            }
        }

        private void Dgv_routes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_planetes.ClearSelection();
            dgv_planetes.Update();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

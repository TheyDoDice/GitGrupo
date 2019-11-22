using System;
using System.Drawing;
using System.Windows.Forms;
using LlibreriaMinijoc;
using System.Numerics;
using System.Collections.Generic;
using LlibreriaMinijoc.Classes;
using System.Linq;

namespace Odisea_en_el_espacio
{
    public partial class Rocket : Form
    {
        public Vector3 position;
        public Planet actualPlanet;
        public List<Control> compis = new List<Control>();

        public int amigos = 0;
        private JumpRoute jumpr = null;
        private Jump jump = null;

        public int DisponiblePlanets = 5;
        public bool CanViewFiliation = false;
        public bool CanOpenJump = true, CanOpenJumpr = true;
        private bool spoiler = true;

        public Dictionary<string, Planet> Planets;
        public Dictionary<string, Route> Routes;

        

        public Rocket()
        {
            InitializeComponent();
        }
        private void Rocket_Load(object sender, EventArgs e)
        {
            Loader ld = null;
            bool tancar = false;

            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Filter = "XML files (*.xml)|*.xml",
                Title = "Open planets.xml"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                try
                {
                    ld = new Loader(filePath);
                    ld.LoadInfo();
                }
                catch (System.IO.FileNotFoundException exc)
                {
                    MessageBox.Show("S'ha perdut la connexió amb l'arxiu");
                    tancar = true;
                }
            }
            else
            {
                tancar = true;
            }

            if (!tancar)
            {
                Image myimage = new Bitmap(Application.StartupPath + "\\Imagenes\\fons.jpg");
                BackgroundImage = myimage;

                pbx_bb8.ImageLocation = Application.StartupPath + "\\Imagenes\\pbx_bb8.png";
                pbx_c3po.ImageLocation = Application.StartupPath + "\\Imagenes\\pbx_c3po.png";
                pbx_r2d2.ImageLocation = Application.StartupPath + "\\Imagenes\\pbx_r2d2.png";

                gif.Enabled = false;
                gif.Image = null;

                pbx_bb8.Parent = nau;
                pbx_c3po.Parent = nau;
                pbx_r2d2.Parent = nau;

                compis.Add(pbx_bb8);
                compis.Add(pbx_c3po);
                compis.Add(pbx_r2d2);

                MessageBox.Show("Has tenido un accidente y tus amigos se han perdido por todos los planetas de la galaxia.\n" +
                                "Por el accidente a tu nave le faltan algunos componentes: el visor de planetas cercanos y " +
                                "los motores a propulsión para acceder a las rutas de larga distancia.\n\n" +
                                "¡Ves a buscarlos, te necesitan!");

                position = ld.GetRandomCoords();

                SetCoords();
                Activate(btn_run2, false);

                Planets = ld.Planets;
                Routes = ld.Routes;

                lbl_coordX.Show();
                lbl_coordY.Show();
                lbl_coordZ.Show();

                Random generator = new Random();
                List<string> namePlanets = Planets.Keys.ToList();
                bool hasPuppy;

                for (int i = 0; i < 3; i++)
                {
                    do
                    {
                        int index = generator.Next(0, Planets.Count);
                        hasPuppy = Planets[namePlanets[index]].HasPuppy;

                        if (!hasPuppy)
                        {
                            Planets[namePlanets[index]].HasPuppy = true;
                            if (spoiler) MessageBox.Show(namePlanets[index]);
                        }

                    } while (hasPuppy);
                }
            }
            else
            {
                Activate(btn_run, false);
            }
        }
        private void SetCoords()
        {
            lbl_coordX.Text = "X: " + position.X.ToString();
            lbl_coordY.Text = "Y: " + position.Y.ToString();
            lbl_coordZ.Text = "Z: " + position.Z.ToString();
        }

        public void Viaje()
        {
            Info(false);
            foreach (Control puppy in compis)
            {
                puppy.Enabled = false;
            }

            Activate(btn_run, false);
            Activate(btn_run2, false);
            Activate(btn_Frenar, true);
            lbl_warning.Hide();

            SetCoords();
            lbl_planetname.Text = actualPlanet.Name;

            nau.Parent = gif;
            gif.ImageLocation = Application.StartupPath + "\\Imagenes\\GIF.gif";
            gif.Enabled = true;

            timer1.Interval = 3500;
            timer1.Tick += new EventHandler(timer1_Tick);

            timer1.Enabled = true;
            timer1.Start();
        }

        public void Activate(Control c, bool enable)
        {
            c.Enabled = enable;
        }
        private void Info(bool show)
        {
            lbl_coordX.Visible = show;
            lbl_coordY.Visible = show;
            lbl_coordZ.Visible = show;
            lbl_planetname.Visible = show;
        }

        private void Llegada()
        {
            try
            {
                Image myimage = new Bitmap(Application.StartupPath + "\\Imagenes\\" + actualPlanet.Image);
                this.BackgroundImage = myimage;
            }
            catch (ArgumentException exc)
            {
                Image myimage = new Bitmap(Application.StartupPath + "\\Imagenes\\error.png");
                this.BackgroundImage = myimage;
            }
            catch (NullReferenceException exc)
            {
                
            }
            gif.Enabled = false;
            gif.Image = null;

            timer1.Stop();

            Activate(btn_run, true);
            Activate(btn_Frenar, false);
            Info(true);

            if (actualPlanet.HasPuppy)
            {
                amigos++;
                actualPlanet.HasPuppy = false;

                compis[amigos - 1].Visible = true;

                if (amigos == 1)
                {
                    MessageBox.Show("Gracias por salvarme.\nTe he arreglado las rutas espaciales, las encontraras en la parte derecha del panel.");
                }
                else if (amigos == 2)
                {
                    MessageBox.Show("Gracias por salvarme.\nTe he arreglado el visor de rutas y planetas, ahora podràs ver si el planeta es enemigo o aliado antes de saltar.");
                    CanViewFiliation = true;
                }
                else
                {
                    MessageBox.Show("Gracias por salvarme.\nTe he arreglado todo el sistema de viajes, ahora tienes acceso a todos los planetas.");
                    DisponiblePlanets = Planets.Count - 1;
                }
            }

            if (amigos > 0)
            {
                Activate(btn_run2, true);
            }

            if (actualPlanet.Filiation == "First Order" || actualPlanet.Filiation == "Unknown")
            {
                lbl_warning.Show();
            }

            if (!actualPlanet.Visited)
            {
                actualPlanet.Visited = true;
            }
        }



        //EVENTOS BOTONES

        private void timer1_Tick(object sender, EventArgs e)
        {
            Llegada();
        }
        private void btn_Frenar_Click(object sender, EventArgs e)
        {
            Llegada();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            if (CanOpenJump)
            {
                CanOpenJump = false;
                CanOpenJumpr = false;

                jump = new Jump(this);
                //jump.MdiParent = this.MdiParent;
                jump.Show();
            }
        }

        private void btn_run2_Click(object sender, EventArgs e)
        {
            if (actualPlanet != null && CanOpenJumpr)
            {
                CanOpenJumpr = false;
                CanOpenJump = false;

                jumpr = new JumpRoute(this);
                //jumpr.MdiParent = this.MdiParent;
                jumpr.Show();
            }
        }
    }
}

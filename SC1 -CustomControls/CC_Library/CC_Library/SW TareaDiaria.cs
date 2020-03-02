using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CC_Library
{
    public partial class SW_TareaDiaria : UserControl
    {
        #region ROUNDED
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        #endregion
        

        private bool oculto = true;

        public string titulo 
{
            get { return Titulo.Text; }
            set { Titulo.Text = value; }
        }

        public string fecha
        {
            get { return Fecha.Text; }
            set { Fecha.Text = value; }
        }

        public string tarea
        {
            get { return Tarea.Text; }
            set { Tarea.Text = value; }
        }

        public SW_TareaDiaria(string titulo, string fecha, string tarea)
        {
            InitializeComponent();
            this.titulo = titulo;
            this.fecha = fecha;
            this.tarea = tarea;
        }

        private void SW_TareaDiaria_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Img\\dark_close.png");
            pictureBox1.MouseEnter += (se, ev) => pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Img\\red_close.png");
            pictureBox1.MouseLeave += (se, ev) => pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Img\\dark_close.png");

            this.Size = new Size(243, 54);
            panel1.Size = new Size(243, 44);

            panel1.Click += (se, ev) => timer1.Start();
            Tarea.Click  += (se, ev) => timer1.Start();
            Titulo.Click += (se, ev) => timer1.Start();
            Fecha.Click  += (se, ev) => timer1.Start();
        }

        private void desplegarTarea()
        {
            if (oculto)
            {
                this.Size = new Size(243, 154);
                panel1.Size = new Size(243, 144);
                oculto = false;
            }
            else
            {
                this.Size = new Size(243, 54);
                panel1.Size = new Size(243, 44);
                oculto = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Height = oculto ? panel1.Height + 5 : panel1.Height - 5;
            this.Height = oculto ? this.Height + 5 : this.Height - 5;

            if (panel1.Height <= 45 || panel1.Height >= 145)
            {
                oculto = !oculto;
                timer1.Stop();
            }
        }
    }
}

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

        public SW_TareaDiaria(string titulo, string fecha)
        {
            InitializeComponent();
            this.titulo = titulo;
            this.fecha = fecha;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void SW_TareaDiaria_Load(object sender, EventArgs e)
        {

        }
    }
}

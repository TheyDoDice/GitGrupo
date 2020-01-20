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
            this.Size = new Size(243, 54);
            panel1.Size = new Size(243, 44);
        }

        private void panel1_Click(object sender, EventArgs e)
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
    }
}

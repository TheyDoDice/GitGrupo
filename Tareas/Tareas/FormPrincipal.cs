using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBDD;
using CC_Library;

namespace Tareas
{
    public partial class FormPrincipal : Form
    {
        SQL basedatos = new SQL();
        SContext context = new SContext();
        DateTime localDate = DateTime.Now;
        DataSet tareas;
        private string data;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        #region MOVEPANEL
        private const int ButtonDown = 0xA1;
        private const int HtCaption = 0x2;
        [DllImport("User32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void MovePanel(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, ButtonDown, HtCaption, 0);
            }
        }
        #endregion
        

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            #region BARRA SUPERIOR

            barraSuperior.MouseDown += MovePanel;
            barraSuperior.BackColor = Colors.azulPrincipal;

            ptb_close.Image = Image.FromFile(Application.StartupPath + "\\Img\\dark_close.png");
            ptb_close.MouseLeave += (se, ev) => ptb_close.BackColor = Colors.azulPrincipal;
            ptb_close.MouseEnter += (se, ev) => ptb_close.BackColor = Colors.azulSeleccion;
            ptb_close.Click += (se, ev) => this.Close();

            ptb_minimize.Image = Image.FromFile(Application.StartupPath + "\\Img\\dark_minimize.png");
            ptb_minimize.MouseLeave += (se, ev) => ptb_minimize.BackColor = Colors.azulPrincipal;
            ptb_minimize.MouseEnter += (se, ev) => ptb_minimize.BackColor = Colors.azulSeleccion;
            ptb_minimize.Click += (se, ev) => this.WindowState = FormWindowState.Minimized;

            #endregion


            tareas = basedatos.PortarTaula("TareasDiarias");
                
            foreach (DataRow item in tareas.Tables[0].Rows)
            {
                SW_TareaDiaria OpcioMenu = new SW_TareaDiaria(item["Titulo"].ToString(), item["fecha"].ToString().Split(' ')[0], item["Tarea"].ToString());

                OpcioMenu.Dock = DockStyle.Top;
                listado.Controls.Add(OpcioMenu);
                OpcioMenu.Show();
            }

            data = localDate.ToShortDateString();
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            TareasDiarias nuevaTarea = new TareasDiarias();

            nuevaTarea.idUser = 4;
            nuevaTarea.fecha = DateTime.Parse(data);
            nuevaTarea.Titulo = titulo.Text;
            nuevaTarea.Tarea = tarea.Text;

            context.TareasDiarias.Add(nuevaTarea);
            context.SaveChanges();
            actualizarTareas();
        }

        private void actualizarTareas()
        {
            listado.Controls.Clear();

            tareas = basedatos.PortarTaula("TareasDiarias");

            foreach (DataRow item in tareas.Tables[0].Rows)
            {
                SW_TareaDiaria OpcioMenu = new SW_TareaDiaria(item["Titulo"].ToString(), item["fecha"].ToString().Split(' ')[0], item["Tarea"].ToString());

                OpcioMenu.Dock = DockStyle.Top;
                listado.Controls.Add(OpcioMenu);
                OpcioMenu.Show();
            }
        }
    }
}

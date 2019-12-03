using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormsMantemimiento
{
    public partial class MantenimientoUsers : MantenimientoBBDD.MantenimientoGenerico
    {
        List<string> impresoras = new List<string>();

        public MantenimientoUsers()
        {
            InitializeComponent();
        }

        private void MantenimientoUsers_Load(object sender, EventArgs e)
        {
            foreach (var item in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                impresoras.Add(item.ToString());
            }
        }

        

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                
                int id = (int)(dataGridView1.SelectedRows[0].Cells[0].Value);

                ReportDocument rpd = new ReportDocument();
                rpd.Load(Application.StartupPath + @"\CrystalReport\CRUsers.rpt");
                rpd.SetParameterValue("id", id);
                rpd.SetDatabaseLogon("TheyDoDice", "123456aA");

                printPreviewDialog1.ShowDialog();

            }
            catch (Exception)
            {
                MessageBox.Show("selecciona una fila completa");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(, 0 ,0);
        }
    }
}

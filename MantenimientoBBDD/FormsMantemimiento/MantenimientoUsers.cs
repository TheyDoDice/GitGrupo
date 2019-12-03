using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
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
            btn_imprimir.Enabled = false;

            foreach (var item in PrinterSettings.InstalledPrinters)
            {
                impresoras.Add(item.ToString());
            }
            comboBox1.DataSource = impresoras;
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

                PrinterSettings print = new PrinterSettings();
                print.PrinterName = comboBox1.Text;

                rpd.PrintToPrinter(print, new PageSettings(), false);

            }
            catch (Exception)
            {
                MessageBox.Show("selecciona una fila completa");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                btn_imprimir.Enabled = true;
            }
            else
            {
                btn_imprimir.Enabled = false;
            }
        }
    }
}

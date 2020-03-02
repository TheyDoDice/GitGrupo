using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using BBDD;
using CrystalDecisions.CrystalReports.Engine;

namespace FormsMantemimiento
{
    public partial class MantenimientoOrders : MantenimientoBBDD.MantenimientoGenerico
    {
        public string id = "nada";
        SQL database = new SQL();
        List<string> impresoras = new List<string>();


        public MantenimientoOrders()
        {
            InitializeComponent();
        }

        private void MantenimientoOrders_Load(object sender, EventArgs e)
        {
            foreach (var item in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                impresoras.Add(item.ToString());
            }
            comboBox1.DataSource = impresoras;

            label1.MouseEnter += (s, ev) => label1.ForeColor = Color.DarkGray;
            label1.MouseLeave += (s, ev) => label1.ForeColor = Color.White;


            dataGridView1.CellClick += (s, ev) =>
            {
                panel1.Controls.Clear();
                id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                string consulta = "OrdersDetail where idOrder = " + id;

                MantenimientoOrdersDetail detalles = new MantenimientoOrdersDetail();
                detalles.tabla = consulta;
                detalles.TopLevel = false;
                detalles.Dock = DockStyle.Fill;
                panel1.Controls.Add(detalles);
                detalles.Show();

            };
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel3.Size = panel3.Size.Width == 2 ? new System.Drawing.Size(772, 520) : new System.Drawing.Size(2, 520);
            panel2.Visible = panel2.Visible ? false : true;
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDocument rpd = new ReportDocument();
                rpd.Load(Application.StartupPath + @"\CrystalReport\CROrders.rpt");
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

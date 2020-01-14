using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BBDD;

namespace FormsMantemimiento
{
    public partial class MantenimientoOrders : MantenimientoBBDD.MantenimientoGenerico
    {
        public string id = "nada";
        SQL database = new SQL();

        public MantenimientoOrders()
        {
            InitializeComponent();
        }

        private void MantenimientoOrders_Load(object sender, EventArgs e)
        {
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
    }
}

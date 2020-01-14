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
    }
}

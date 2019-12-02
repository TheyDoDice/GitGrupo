using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsMantemimiento
{
    public partial class MantenimientoUsers : MantenimientoBBDD.MantenimientoGenerico
    {
        public static System.Drawing.Printing.PrinterSettings.StringCollection InstalledPrinters { get; }

        public MantenimientoUsers()
        {
            InitializeComponent();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)(dataGridView1.SelectedRows[0].Cells[0].Value);

                //CrystalReportUser cru = new CrystalReportUser(id, swt_codeUser.Text);
                //cru.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("selecciona una fila completa");
            }
        }
    }
}

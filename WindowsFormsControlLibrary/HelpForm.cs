using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBDD;

namespace WindowsFormsControlLibrary
{
    public partial class HelpForm : Form
    {
        string [] args;

        public HelpForm(string [] args)
        {
            InitializeComponent();
            this.args = args;
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            Dades dades = new SQL();
            DataSet dataSet = new DataSet();

            dataSet = dades.PortarTaula(args[0].ToString());
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Columns[0].Visible = false;

            this.CenterToScreen();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            args[1] = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.Close();
        }
    }
}

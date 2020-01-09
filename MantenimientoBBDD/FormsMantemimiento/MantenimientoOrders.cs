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
        private BindingSource masterBindingSource = new BindingSource();
        private BindingSource detailsBindingSource = new BindingSource();
        SQL database = new SQL();
        DataSet dataOrders = new DataSet();
        DataSet dataDetails = new DataSet();

        public MantenimientoOrders()
        {
            InitializeComponent();
        }

        private void MantenimientoOrders_Load(object sender, EventArgs e)
        {
            dataOrders = database.PortarTaula("Orders");
            dataDetails = database.PortarTaula("Details");
            
        }
    }
}

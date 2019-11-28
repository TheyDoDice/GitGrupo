using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsMantemimiento
{
    public partial class CrystalReportUser : Form
    {
        private int id;
        public CrystalReportUser(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void CrystalReportUser_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            ReportDocument rpd = new ReportDocument();
            rpd.Load(Application.StartupPath + @"\CrystalReport\CRUsers.rpt");
            rpd.SetParameterValue(0, id);
            rpd.SetDatabaseLogon("TheyDoDice", "123456aA");
            crystalReportViewer.ReportSource = rpd;
        }
    }
}

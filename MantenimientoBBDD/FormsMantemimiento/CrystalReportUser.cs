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
        private string code;
        public CrystalReportUser(int id, string code)
        {
            InitializeComponent();
            this.id = id;
            this.code = code;
        }

        private void CrystalReportUser_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            //GeneratedBarcode barcode = BarcodeWriter.CreateBarcode(code, BarcodeWriterEncoding.Code128);
            //barcode.SaveAsPng(@"\Img\barcode\"+code+".png");

            ReportDocument rpd = new ReportDocument();
            rpd.Load(Application.StartupPath + @"\CrystalReport\CRUsers.rpt");
            rpd.SetParameterValue("id", id);
            rpd.SetParameterValue("barcode", "a");
            rpd.SetDatabaseLogon("TheyDoDice", "123456aA");
            crystalReportViewer.ReportSource = rpd;
        }
    }
}

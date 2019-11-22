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
using System.Reflection;
using CC_Library;

namespace FormsMantemimiento
{
    public partial class MantenimientoUserCategories : Form
    {
        securecoreEntities db = new securecoreEntities();

        public MantenimientoUserCategories()
        {
            InitializeComponent();

        }       


        private void MantenimientoUserCategories_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.UserCategories.ToList();
            
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            UserCategories Category = new UserCategories();
            foreach (var control in this.Controls)
            {
                if (control is SWTextbox swt)
                {
                    try
                    {
                        int num = int.Parse(swt.Text);
                        Category.GetType().GetProperty(swt.nomCamp).SetValue(Category, num);
                    }
                    catch (Exception)
                    {
                        Category.GetType().GetProperty(swt.nomCamp).SetValue(Category, swt.Text);
                    }
                }
            }
            db.UserCategories.Add(Category);
            db.SaveChanges();
            dataGridView1.DataSource = db.UserCategories.ToList();
        }

        private void btn_actualizarDataset_Click(object sender, EventArgs e)
        {
            UserCategories Category = db.UserCategories.ToList().Find(x => x.idUserCategory == 1);
        }
    }
}

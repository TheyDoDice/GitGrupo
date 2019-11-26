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
using System.Text.RegularExpressions;

namespace FormsMantemimiento
{
    public partial class MantenimientoUserCategories : Form
    {
        securecoreEntities db = new securecoreEntities();
        private bool nuevaFila = false;

        public MantenimientoUserCategories()
        {
            InitializeComponent();

        }       


        private void MantenimientoUserCategories_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.UserCategories.ToList();

            Regex rg = new Regex("^id");

            //foreach (DataGridViewColumn item in dataGridView1.Columns)
            //{
            //    if (rg.Match(item.Name).Success)
            //    {
            //        dataGridView1.Columns[item.Name].Visible = false;
            //    }
            //}
            
            foreach (var control in this.Controls)
            {
                if (control is SWTextbox swt)
                {
                    swt.DataBindings.Clear();
                    swt.DataBindings.Add("Text", dataGridView1.DataSource, swt.nomCamp);
                    swt.Validated += bindingOnValidated;
                }
            }
        }

        private void bindingOnValidated(object sender, EventArgs e)
        {
            if (!nuevaFila)
            {
                ((SWTextbox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }
        private void bindingOnValidated(SWTextbox swt)
        {
            if (!nuevaFila)
            {
                swt.DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        public object GetInstance(string FullyQualifiedNameOfClass)
        {
            Type t = Type.GetType(FullyQualifiedNameOfClass);
            return Activator.CreateInstance(t);
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            nuevaFila = true;

            foreach (var control in this.Controls)
            {
                if (control is SWTextbox swt)
                {
                    swt.DataBindings.Clear();
                    swt.Text = "";
                }
            }
        }

        private void btn_actualizarDataset_Click(object sender, EventArgs e)
        {
            int id = 0;
            UserCategories Category;
            if (dadesUsuariCorrectes())
            {
                if (nuevaFila)
                {
                    Category = new UserCategories();

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
                    id = db.UserCategories.ToList().FindIndex(x => x == Category);
                    nuevaFila = false;
                }
                else
                {
                    id = dataGridView1.CurrentCell.RowIndex;
                    Category = db.UserCategories.ToList()[id];

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
                    db.UserCategories.ToList()[id] = Category;
                }
            }
            else
            {
                MessageBox.Show("Falten dades.");
            }
            db.SaveChanges();
            dataGridView1.DataSource = db.UserCategories.ToList();

            foreach (var control in this.Controls)
            {
                if (control is SWTextbox swt)
                {
                    swt.DataBindings.Clear();
                    swt.DataBindings.Add("Text", dataGridView1.DataSource, swt.nomCamp);
                }
            }
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = dataGridView1.Rows[id].Cells[0];
            //dataGridView1.Rows[id].Selected = true;
        }

        private bool dadesUsuariCorrectes()
        {
            bool res = true;
            foreach (var control in this.Controls)
            {
                if (control is SWTextbox swt)
                {
                    res = swt.Text != "";
                    if (!res)
                        break;
                }
            }
            return res;
        }
    }
}

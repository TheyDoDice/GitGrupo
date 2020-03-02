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
        SContext db = new SContext();
        private bool nuevaFila = false;
        private UserCategories selected = new UserCategories();

        public MantenimientoUserCategories()
        {
            InitializeComponent();

        }       


        private void MantenimientoUserCategories_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.UserCategories.ToList();

            Regex rg = new Regex("^id");

            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                if (rg.Match(item.Name).Success)
                {
                    dataGridView1.Columns[item.Name].Visible = false;
                    dataGridView1.Columns["Users"].Visible = false;
                }
            }

            newBinding();
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
            UserCategories Category = new UserCategories();
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

            newBinding();

            dataGridView1.ClearSelection();
            id = db.UserCategories.ToList().FindIndex(x => x.idUserCategory == Category.idUserCategory);
            dataGridView1.CurrentCell = dataGridView1.Rows[id].Cells[1];
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
        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dataGridView1.SelectedRows.Count == 1)
            {
                db.UserCategories.Remove(db.UserCategories.Find(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())));
                db.SaveChanges();
                dataGridView1.DataSource = db.UserCategories.ToList();

                newBinding();
                dataGridView1.Rows[0].Selected = true;
            }
        }

        private void newBinding()
        {
            foreach (var control in this.Controls)
            {
                if (control is SWTextbox swt)
                {
                    swt.DataBindings.Clear();
                    swt.DataBindings.Add("Text", dataGridView1.DataSource, swt.nomCamp);
                }
            }
        }
    }
}

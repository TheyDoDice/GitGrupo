﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBDD;
using Encriptar;
using SWTextbox;
using WindowsFormsControlLibrary;

namespace MantenimientoBBDD
{
    public partial class MantenimientoGenerico : Form
    {
        public MantenimientoGenerico()
        {
            InitializeComponent();
        }

        Dades bbdd = new SQL();

        public string tabla { get; set; }
        private DataSet dataSet;
        private DataTable datable;
        private bool nuevaFila = false;


        private void MantenimientoGenerico_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            this.WindowState = FormWindowState.Maximized;

            bbdd.Connectar();

            dataSet = bbdd.PortarPerConsulta("select * from " + tabla);
            datable = dataSet.Tables[0];
            dataGridView1.DataSource = datable;

            Regex rg = new Regex("^id");

            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                if (rg.Match(item.Name).Success)
                {
                    dataGridView1.Columns[item.Name].Visible = false;
                }
            }

            foreach (var control in this.Controls)
            {
                if (control is SWTextbox1 swt)
                {
                    swt.DataBindings.Clear();
                    swt.DataBindings.Add("Text", datable, swt.nomCamp);
                    swt.TextChanged += (s, ev) => atualizaLaForanea(swt);
                    atualizaLaForanea(swt);
                    swt.Validated += bindingOnValidated;
                }
            }
        }

        private void bindingOnValidated(object sender, EventArgs e)
        {
            if (!nuevaFila)
            {
                ((SWTextbox1)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }
        private void bindingOnValidated(SWTextbox1 swt)
        {
            if (!nuevaFila)
            {
                swt.DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        private void atualizaLaForanea(SWTextbox1 swt)
        {
            if (swt.foranea)
            {
                foreach (var c in this.Controls)
                {
                    if (c is SWCodi swc)
                    {
                        if (swc.Name == swt.controlID)
                        {
                            swc.ValidaId(swt.Text);
                            swc.Validated += (s, ev) => bindingOnValidated(swt);
                        }
                    }
                }
            }
        }

        private void btn_insertar_Click_1(object sender, EventArgs e)
        {
            nuevaFila = true;

            foreach (var control in this.Controls)
            {
                if (control is SWTextbox1 swt)
                {
                    swt.DataBindings.Clear();
                    swt.Text = "";
                }
            }
        }

        private void btn_actualizarDataset_Click_1(object sender, EventArgs e)
        {
            if (dadesUsuariCorrectes())
            {
                if (nuevaFila)
                {
                    insertarNuevaFila();
                }
                bbdd.Actualitzar("select * from " + tabla, "users", dataSet);
            }
            else
            {
                MessageBox.Show("Falten dades.");
            }
        }

        //FUNCTIONS

        private void insertarNuevaFila()
        {
            DataRow datarow = datable.NewRow();

            foreach (var control in this.Controls)
            {
                if (control is SWTextbox1 swt)
                {
                    if (swt.nomCamp == "Password")
                    {
                        string contra = swt.Text;
                        Hash encript = new Hash();
                        byte[] byteArraySalt = encript.GenerateSalt();
                        byte[] byteArrayhash = encript.ComputeHash(contra, byteArraySalt);
                        datarow["Salt"] = Convert.ToBase64String(byteArraySalt);
                        datarow[swt.nomCamp] = Convert.ToBase64String(byteArrayhash);
                    }
                    else
                    {
                        datarow[swt.nomCamp] = swt.Text;
                    }
                    //RESET DATABINDINGS
                    swt.DataBindings.Clear();
                    swt.DataBindings.Add("Text", datable, swt.nomCamp);
                }
            }
            datable.Rows.Add(datarow);
            nuevaFila = false;
        }

        private bool dadesUsuariCorrectes()
        {
            bool res = true;
            foreach (var control in this.Controls)
            {
                if (control is SWTextbox1 swt)
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
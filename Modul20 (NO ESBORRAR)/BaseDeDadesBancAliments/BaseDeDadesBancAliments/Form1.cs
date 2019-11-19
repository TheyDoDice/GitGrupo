﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CC_Library;
using BBDD;

namespace ConnectarBBDD
{
    public partial class Form1 : Form
    {
        Dades bbdd = new OLDB();

        //Variable consulta
        public string consulta = "select * from Sectors";

        //Declarem el data set
        public DataSet dadesConsulta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Fer la select de la taula usuaris
            dadesConsulta = bbdd.PortarPerConsulta(consulta, "prova");

            //Mostrar les dades en un data grid view
            dataGridView1.DataSource = dadesConsulta.Tables["prova"];

            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(SWTextbox))
                {
                    SWTextbox cc = (SWTextbox)ctr;

                    cc.DataBindings.Clear();
                    cc.DataBindings.Add("Text", dadesConsulta.Tables["prova"], cc.nomCamp);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bbdd.Actualitzar(consulta, "prova", dadesConsulta);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}

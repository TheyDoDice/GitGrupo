using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_enviarTPlaneta_Click(object sender, EventArgs e)
        {
            AddTextoRichTextBox(txtb_planeta.Text, Color.Red);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTextoRichTextBox(txtb_nave.Text, Color.Green);

        }

        public void AddTextoRichTextBox(string text, Color col_texto)
        {
            rtbx_consola.AppendText(text, col_texto);
            rtbx_consola.AppendText(Environment.NewLine, col_texto);
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}

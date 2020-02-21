using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nave
{
    public partial class frm_nave : Form
    {
        public frm_nave()
        {
            InitializeComponent();
        }

        private void btn_verificar_MouseHover(object sender, EventArgs e)
        {
            btn_verificar.Image = TakeImg("buttonv2_hover");
        }

        private void btn_verificar_MouseLeave(object sender, EventArgs e)
        {
            btn_verificar.Image = TakeImg("buttonv2");
        }

        private Image TakeImg(string name)
        {
            string dir = Path.GetDirectoryName(@"‪C:\Users\admin\Desktop\GitGrupo\Imagenes_NewSecureCore\button\");
            return Image.FromFile(dir + name + ".png");
        }
    }
}

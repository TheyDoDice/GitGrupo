using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacsLibrary
{
    public class Images
    {
        public Image TakeImg(string mode, string name)
        {
            return Image.FromFile(Application.StartupPath + "\\Img\\" + mode + "_" + name + ".png");
        }
    }
}

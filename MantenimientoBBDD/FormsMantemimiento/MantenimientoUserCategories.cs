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

namespace FormsMantemimiento
{
    public partial class MantenimientoUserCategories : Form
    {
        public MantenimientoUserCategories()
        {
            InitializeComponent();
        }

        securecoreEntities scEntities = new securecoreEntities();

    }
}

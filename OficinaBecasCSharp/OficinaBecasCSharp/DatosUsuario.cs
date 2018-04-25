using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class DatosUsuario : Form
    {
        public DatosUsuario(bool visible)
        {
            InitializeComponent();
            if (!visible) btmSeleccionar.Visible = false;
        }

        private void btmSeleccionar_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class BuscarBeca : Form
    {
        public BuscarBeca()
        {
            InitializeComponent();
        }

        private void dgvBuscarBecas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

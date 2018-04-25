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
    public partial class AgregarBecarioATutor : Form
    {
        public AgregarBecarioATutor()
        {
            InitializeComponent();
            CBTutorABTXB.SelectedIndex = 0;
            txtCodABTXB.Enabled = false;
            txtNombABTXB.Enabled = false;
            txtApABTXB.Enabled = false;
            btnAceptarABTXB.Enabled = false;
        }

        private void CBTutorABTXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAceptarABTXB.Enabled = true;
        }

        private void btnBuscarABTXB_Click(object sender, EventArgs e)
        {
            BuscarBecarioABTXB frmABTXB = new BuscarBecarioABTXB();
            frmABTXB.ShowDialog();
        }

        private void btnAceptarABTXB_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnCancelarABTXB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

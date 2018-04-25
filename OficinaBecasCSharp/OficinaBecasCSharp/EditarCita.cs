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
    public partial class EditarCita : Form
    {
        public EditarCita()
        {
            InitializeComponent();
            txtCodTutorECGC.Enabled = false;
            txtCodBecECGC.Enabled = false;
            txtBTutoECGC.Enabled = false;
            txtBBecarioECGC.Enabled = false;
        }

        private void btnAceptarECGC_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelarECGC_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBFechaECGC_Click(object sender, EventArgs e)
        {
            AgregarFecha frmBF = new AgregarFecha();
            frmBF.ShowDialog();
        }
    }
}

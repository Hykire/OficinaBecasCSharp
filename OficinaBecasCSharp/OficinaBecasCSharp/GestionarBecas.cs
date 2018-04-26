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
    public partial class GestionarBecas : Form
    {
        public GestionarBecas()
        {
            InitializeComponent();
            txtBFechaGC.Enabled = false;
            txtBDescBecaGB.Enabled = false;
            txtNombBecaGB.Enabled = false;
        }

        private void BAgregarBecaGB_Click(object sender, EventArgs e)
        {
            AgregarBecaGB frmAgregBecaGB = new AgregarBecaGB();
            frmAgregBecaGB.ShowDialog();
        }

        private void btnDescargarGB_Click(object sender, EventArgs e)
        {

        }

        private void BEditarCitaGC_Click(object sender, EventArgs e)
        {
            //if campos... debe seleccionar beca!(después)
            EditarBecaGB frmEditBecaGB = new EditarBecaGB();
            frmEditBecaGB.ShowDialog();
        }

        private void BEliminarCitaGC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombBecaGB.Text))
            {
                MessageBox.Show("Debe seleccionar una beca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("¿Desea eliminar la beca seleccionada?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnMNGestBecas_Click(object sender, EventArgs e)
        {
            PGestBecas.Visible = true;
        }
    }
}

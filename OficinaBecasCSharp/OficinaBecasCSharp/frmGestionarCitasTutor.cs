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
    public partial class frmGestionarCitasTutor : Form
    {
        public frmGestionarCitasTutor()
        {
            InitializeComponent();
            
            //panel citas
            txtBFechaGC.Enabled = false;
            txtBHoraGC.Enabled = false;
            txtCodTutorGC.Enabled = false;
            txtBTutorGC.Enabled = false;
            txtCodBecGC.Enabled = false;
            txtBBecarioGC.Enabled = false;
            txtBLugarGC.Enabled = false;
            txtBObsGC.Enabled = false;
        }
        private void BAgregarCitaGC_Click(object sender, EventArgs e)
        {
            AgregarCita frmAgergar = new AgregarCita();
            frmAgergar.ShowDialog();
        }

        private void BEliminarCitaGC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBFechaGC.Text))
            {
                MessageBox.Show("Debe seleccionar una cita", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("¿Desea eliminar la cita seleccionada?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void BEditarCitaGC_Click(object sender, EventArgs e)
        {
            EditarCita frmAgergar = new EditarCita();
            frmAgergar.ShowDialog();
        }
        private void frmGestionarCitasTutor_Load(object sender, EventArgs e)
        {

        }

        private void BAgregarCitaGC_Click_1(object sender, EventArgs e)
        {
            AgregarCita frmAgergar = new AgregarCita();
            frmAgergar.ShowDialog();
        }

        private void BEditarCitaGC_Click_1(object sender, EventArgs e)
        {
            EditarCita frmAgergar = new EditarCita();
            frmAgergar.ShowDialog();
        }

        private void BEliminarCitaGC_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBFechaGC.Text))
            {
                MessageBox.Show("Debe seleccionar una cita", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("¿Desea eliminar la cita seleccionada?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void BBuscarCitaGC_Click(object sender, EventArgs e)
        {
            //DTPSelDiaGC.Sel
        }
    }
}

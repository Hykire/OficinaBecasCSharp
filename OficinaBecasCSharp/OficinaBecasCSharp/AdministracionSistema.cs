using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista {
    public partial class AdministracionSistema : Form {
        public AdministracionSistema() {
            InitializeComponent();
            panelGestBecarios.Hide();
            panelGestUsuarios.Hide();
            PGestBecas.Hide();

            txtBFechaGC.Enabled = false;
            txtBDescBecaGB.Enabled = false;
            txtNombBecaGB.Enabled = false;

        }                  

        private void button1_Click(object sender, EventArgs e) {

        }


        private void btnNuevoBec_Click(object sender, EventArgs e) {
            AdministracionNuevoBecario ventanaNuevoBecario = new AdministracionNuevoBecario();
            if (ventanaNuevoBecario.ShowDialog() == DialogResult.OK) {

            }
        }

        private void btnModifBec_Click(object sender, EventArgs e) {
            AdministracionModificarBecario ventanaModificarBecario = new AdministracionModificarBecario();
            if (ventanaModificarBecario.ShowDialog() == DialogResult.OK) {

            }
        }

        private void btnNuevoUsu_Click(object sender, EventArgs e) {
            AdministradorNuevoUsuario ventanaNuevoUsuario = new AdministradorNuevoUsuario();
            if (ventanaNuevoUsuario.ShowDialog() == DialogResult.OK) {

            }
        }

        private void btnModifUsu_Click(object sender, EventArgs e) {
            AdministracionModificarUsuario ventanaModificarUsuario = new AdministracionModificarUsuario();
            if (ventanaModificarUsuario.ShowDialog() == DialogResult.OK) {

            }
        }

        private void LGestBecXTutBXT_Click(object sender, EventArgs e)
        {

        }

        private void panelGestBecarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BAgregarBecaGB_Click(object sender, EventArgs e)
        {
            AgregarBecaGB frmAgregBecaGB = new AgregarBecaGB();
            frmAgregBecaGB.ShowDialog();
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

        private void GU_button_Click(object sender, EventArgs e)
        {
            panelGestBecarios.Hide();
            panelGestUsuarios.Show();
            PGestBecas.Hide();
        }

        private void GB_button_Click(object sender, EventArgs e)
        {
            panelGestBecarios.Show();
            panelGestUsuarios.Hide();
            PGestBecas.Hide();
        }

        private void GBeca_button_Click(object sender, EventArgs e)
        {
            panelGestBecarios.Hide();
            panelGestUsuarios.Hide();
            PGestBecas.Show();
        }
    }
}

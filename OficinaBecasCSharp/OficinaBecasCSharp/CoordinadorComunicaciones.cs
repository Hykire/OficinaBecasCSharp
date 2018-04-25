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
    public partial class CoordinadorComunicaciones : Form
    {
        public CoordinadorComunicaciones()
        {
            InitializeComponent();
            cbConsulta.Items.Add("Ciclo Actual");
            cbConsulta.Items.Add("Ciclos Anteriores");
            cbSolicitud.Items.Add("Sí");
            cbSolicitud.Items.Add("No");
            txtCantidadCreditos.Visible = false;
            txtDatosPersonales.Visible = false;
            txtTipoBeca.Visible = false;
            cbSolicitud.Visible = false;
            btnFiltrarResultados.Visible = false;
            btnModificar.Visible = false;
            btnAceptar.Visible = false;
            dgvDatos.Visible = false;
            lbCantidadCreditos.Visible = false;
            lbDatosPersonales.Visible = false;
            lbSolicitud.Visible = false;
            lbTipoBeca.Visible = false;

        }

        private void txtDatosPersonales_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtCantidadCreditos.Text == "" || txtDatosPersonales.Text == "" || txtTipoBeca.Text == "" || cbSolicitud.Text == "")
            {
                MessageBox.Show("Falta completar información", "Información Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show("La información ha sido agregada con éxito", "Usuario Agredado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCantidadCreditos.Text = null;
            txtDatosPersonales.Text = null;
            txtTipoBeca.Text = null;
            cbSolicitud.Text = null;
            txtCantidadCreditos.Enabled = false;
            txtDatosPersonales.Enabled = false;
            txtTipoBeca.Enabled = false;
            cbSolicitud.Enabled = false;
            btnAceptar.Enabled = false;
            btnModificar.Enabled = true;
        }

        private void btnGestionarConvocatoria_Click(object sender, EventArgs e)
        {
            if (cbConsulta.Text == "Ciclo Actual")
            {
                txtCantidadCreditos.Visible = true;
                txtDatosPersonales.Visible = true;
                txtTipoBeca.Visible = true;
                cbSolicitud.Visible = true;
                btnModificar.Visible = true;
                btnAceptar.Visible = true;
                lbCantidadCreditos.Visible = true;
                lbDatosPersonales.Visible = true;
                lbSolicitud.Visible = true;
                lbTipoBeca.Visible = true;
                txtCantidadCreditos.Enabled = false;
                txtDatosPersonales.Enabled = false;
                txtTipoBeca.Enabled = false;
                cbSolicitud.Enabled = false;
                btnAceptar.Enabled = false;
                dgvDatos.Visible = true;
                btnFiltrarResultados.Visible = true;
            }
            if (cbConsulta.Text == "Ciclos Anteriores")
            {
                txtCantidadCreditos.Visible = false;
                txtDatosPersonales.Visible = false;
                txtTipoBeca.Visible = false;
                cbSolicitud.Visible = false;
                btnModificar.Visible = false;
                btnAceptar.Visible = false;
                lbCantidadCreditos.Visible = false;
                lbDatosPersonales.Visible = false;
                lbSolicitud.Visible = false;
                lbTipoBeca.Visible = false;
                dgvDatos.Visible = true;
                btnFiltrarResultados.Visible = true;
            }
        }
        private void btnFiltrarResultados_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtCantidadCreditos.Enabled = true;
            txtDatosPersonales.Enabled = true;
            txtTipoBeca.Enabled = true;
            cbSolicitud.Enabled = true;
            btnAceptar.Enabled = true;
            btnModificar.Enabled = false;
        }
    }
}

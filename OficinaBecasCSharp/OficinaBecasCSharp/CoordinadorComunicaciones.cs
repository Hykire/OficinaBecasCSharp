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
            cbBeca.Items.Add("Beca 1");
            cbBeca.Items.Add("Beca 2");
            txtNumeroEnviados.Visible = false;
            txtNumeroRespuestas.Visible = false;
            txtFechaConvocatoria.Visible = false;
            cbBeca.Visible = false;
            btnFiltrarResultados.Visible = false;
            btnModificar.Visible = false;
            btnAceptar.Visible = false;
            dgvDatos.Visible = false;
            lbNumeroTotalEnviados.Visible = false;
            lbNumeroRespuestas.Visible = false;
            lbNombreConvocatoria.Visible = false;
            lbFechaConvocatoria.Visible = false;
            txtNombreConvocatoria.Visible = false;
            txtDescripcionConvocatoria.Visible = false;
            lbNombreConvocatoria.Visible = false;
            lbDescripciónConvocatoria.Visible = false;
            btnAgregar.Visible = false;
            btnEliminar.Visible = false;
            lbBeca.Visible = false;
            btnBeca.Visible = false;
            txtFiltro.Visible = false;
        }

        private void btnGestionarConvocatoria_Click(object sender, EventArgs e)
        {
            if (cbConsulta.Text == "Ciclo Actual")
            {
                txtNumeroEnviados.Visible = true;
                txtNumeroRespuestas.Visible = true;
                txtFechaConvocatoria.Visible = true;
                cbBeca.Visible = true;
                btnModificar.Visible = true;
                btnAceptar.Visible = true;
                lbNumeroTotalEnviados.Visible = true;
                lbNumeroRespuestas.Visible = true;
                lbNombreConvocatoria.Visible = true;
                lbFechaConvocatoria.Visible = true;
                txtNumeroEnviados.Enabled = false;
                txtNumeroRespuestas.Enabled = false;
                txtFechaConvocatoria.Enabled = false;
                cbBeca.Enabled = false;
                btnAceptar.Enabled = false;
                dgvDatos.Visible = true;
                btnFiltrarResultados.Visible = true;
                txtNombreConvocatoria.Visible = true;
                txtDescripcionConvocatoria.Visible = true;
                txtNombreConvocatoria.Enabled = false;
                txtDescripcionConvocatoria.Enabled = false;
                lbNombreConvocatoria.Visible = true;
                lbDescripciónConvocatoria.Visible = true;
                btnAgregar.Visible = true;
                btnEliminar.Visible = true;
                lbBeca.Visible = true;
                btnBeca.Visible = true;
                btnBeca.Enabled = false;
                txtFiltro.Visible = true;
            }
            if (cbConsulta.Text == "Ciclos Anteriores")
            {
                txtNumeroEnviados.Visible = false;
                txtNumeroRespuestas.Visible = false;
                txtFechaConvocatoria.Visible = false;
                cbBeca.Visible = false;
                btnModificar.Visible = false;
                btnAceptar.Visible = false;
                lbNumeroTotalEnviados.Visible = false;
                lbNumeroRespuestas.Visible = false;
                lbNombreConvocatoria.Visible = false;
                lbFechaConvocatoria.Visible = false;
                dgvDatos.Visible = true;
                btnFiltrarResultados.Visible = true;
                txtNombreConvocatoria.Visible = false;
                txtDescripcionConvocatoria.Visible = false;
                lbNombreConvocatoria.Visible = false;
                lbDescripciónConvocatoria.Visible = false;
                btnAgregar.Visible = false;
                btnEliminar.Visible = false;
                lbBeca.Visible = false;
                btnBeca.Visible = false;
                txtFiltro.Visible = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNumeroEnviados.Text == "" || txtNumeroRespuestas.Text == "" || txtFechaConvocatoria.Text == "" || cbBeca.Text == "")
            {
                MessageBox.Show("Falta completar información", "Información Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show("La información ha sido agregada con éxito", "Información Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNumeroEnviados.Text = null;
            txtNumeroRespuestas.Text = null;
            txtFechaConvocatoria.Text = null;
            txtNombreConvocatoria.Text = null;
            txtDescripcionConvocatoria.Text = null;
            cbBeca.Text = null;
            txtNumeroEnviados.Enabled = false;
            txtNumeroRespuestas.Enabled = false;
            txtFechaConvocatoria.Enabled = false;
            txtNombreConvocatoria.Enabled = false;
            txtDescripcionConvocatoria.Enabled = false;
            btnBeca.Enabled = false;
            cbBeca.Enabled = false;
            btnAceptar.Enabled = false;
            btnModificar.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtNumeroEnviados.Enabled = true;
            txtNumeroRespuestas.Enabled = true;
            txtFechaConvocatoria.Enabled = true;
            txtNombreConvocatoria.Enabled = true;
            txtDescripcionConvocatoria.Enabled = true;
            cbBeca.Enabled = true;
            btnAceptar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
            btnBeca.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNumeroEnviados.Enabled = true;
            txtNumeroRespuestas.Enabled = true;
            txtFechaConvocatoria.Enabled = true;
            txtNombreConvocatoria.Enabled = true;
            txtDescripcionConvocatoria.Enabled = true;
            cbBeca.Enabled = true;
            btnAceptar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
            btnBeca.Enabled = true;
        }

        private void btnBeca_Click(object sender, EventArgs e)
        {
            BuscarBeca beca = new BuscarBeca();
            beca.Visible = true;
        }
    }
}

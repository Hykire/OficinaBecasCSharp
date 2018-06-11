using Controlador;
using Modelo;
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
    public partial class BuscarCandidato : Form
    {
        private CandidatoBL candidatoBL;
        private Candidato candidatoSeleccionado;
        private BindingList<Candidato> listaCandidatos;
        public BuscarCandidato()
        {
            InitializeComponent();
            candidatoBL = new CandidatoBL();
            dgvBuscarCandidato.AutoGenerateColumns = false;
            dgvBuscarCandidato.DataSource = candidatoBL.listarCandidatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = "";
            chPostulante.Checked = false;
            chSeleccionado.Checked = false;
            rbApellidos.Checked = false;
            rbCodigoPUCP.Checked = false;
            rbDNI.Checked = false;
            rbNombres.Checked = false;

            dgvBuscarCandidato.DataSource = candidatoBL.listarCandidatos();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            candidatoSeleccionado = (Candidato)dgvBuscarCandidato.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string postulante;
            string seleccionado;
            if (chPostulante.Checked) postulante = "POSTULÓ";
            else postulante = "NO POSTULÓ";
            if (chSeleccionado.Checked) seleccionado = "SELECCIONADO";
            else seleccionado = "NO SELECCIONADO";

            if (rbApellidos.Checked) listaCandidatos = candidatoBL.filtrarApellidos(txtFiltro.Text, postulante, seleccionado);
            else if (rbApellidos.Checked) listaCandidatos = candidatoBL.filtrarNombre(txtFiltro.Text, postulante, seleccionado);
            else if (rbApellidos.Checked) listaCandidatos = candidatoBL.filtrarCodigoPUCP(Int32.Parse(txtFiltro.Text), postulante, seleccionado);
            else if (rbApellidos.Checked) listaCandidatos = candidatoBL.filtrarDNI(Int32.Parse(txtFiltro.Text), postulante, seleccionado);

            dgvBuscarCandidato.DataSource = listaCandidatos;
        }
    }
}
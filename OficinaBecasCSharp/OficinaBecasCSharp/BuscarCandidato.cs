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
        private Convocatoria convocatoria;
        private CandidatoBL candidatoBL;
        private Candidato candidatoSeleccionado;
        private BindingList<Candidato> listaCandidatos;
        private bool candidatoAnterior;

        public Candidato CandidatoSeleccionado { get => candidatoSeleccionado; set => candidatoSeleccionado = value; }

        public BuscarCandidato(Convocatoria convocatoria, bool candidatoAnterior)
        {
            this.candidatoAnterior = candidatoAnterior;
            this.convocatoria = convocatoria;
            InitializeComponent();
            candidatoBL = new CandidatoBL();
            dgvBuscarCandidato.AutoGenerateColumns = false;
            dgvBuscarCandidato.DataSource = candidatoBL.listarCandidatosAnteriores(convocatoria.IdConvocatoria);
            dgvBuscarCandidato.Columns[4].Visible = false;
            dgvBuscarCandidato.Columns[5].Visible = false;
            rbCodigoPUCP.Checked = true;
            chPostulante.Visible = false;
            chSeleccionado.Visible = false;
        }
        public BuscarCandidato(Convocatoria convocatoria)
        {
            this.candidatoAnterior = false;
            InitializeComponent();
            this.convocatoria = convocatoria;
            candidatoBL = new CandidatoBL();
            dgvBuscarCandidato.AutoGenerateColumns = false;
            dgvBuscarCandidato.DataSource = candidatoBL.listarCandidatos(convocatoria.IdConvocatoria);
            dgvBuscarCandidato.Columns[4].Visible = true;
            dgvBuscarCandidato.Columns[5].Visible = true;
            rbCodigoPUCP.Checked = true;
            chPostulante.Visible = false;
            chSeleccionado.Visible = false;
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
            rbCodigoPUCP.Checked = true;


            if (!candidatoAnterior) dgvBuscarCandidato.DataSource = candidatoBL.listarCandidatos(convocatoria.IdConvocatoria);
            else dgvBuscarCandidato.DataSource = candidatoBL.listarCandidatosAnteriores(convocatoria.IdConvocatoria);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            CandidatoSeleccionado = (Candidato)dgvBuscarCandidato.CurrentRow.DataBoundItem;
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

            if (rbApellidos.Checked) listaCandidatos = candidatoBL.filtrarApellidos(txtFiltro.Text, postulante, seleccionado, convocatoria.IdConvocatoria);
            else if (rbNombres.Checked) listaCandidatos = candidatoBL.filtrarNombre(txtFiltro.Text, postulante, seleccionado, convocatoria.IdConvocatoria);
            else if (rbCodigoPUCP.Checked) listaCandidatos = candidatoBL.filtrarCodigoPUCP(Int32.Parse(txtFiltro.Text), postulante, seleccionado, convocatoria.IdConvocatoria);
            else if (rbDNI.Checked) listaCandidatos = candidatoBL.filtrarDNI(Int32.Parse(txtFiltro.Text), postulante, seleccionado, convocatoria.IdConvocatoria);

            dgvBuscarCandidato.DataSource = listaCandidatos;
        }
    }
}
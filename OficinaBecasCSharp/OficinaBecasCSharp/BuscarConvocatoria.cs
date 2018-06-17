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
    public partial class frmBuscarConvocatoria : Form
    {
        private ConvocatoriaBL convocatoriaBL;
        private BindingList<Convocatoria> convocatorias;
        private Convocatoria convocatoriaSeleccionada;
        private BindingList<string> ciclos;
        private int indicador;

        public Convocatoria ConvocatoriaSeleccionada { get => convocatoriaSeleccionada; set => convocatoriaSeleccionada = value; }

        public frmBuscarConvocatoria(int indicador)
        {
            InitializeComponent();
            this.indicador = indicador;
            convocatoriaBL = new ConvocatoriaBL();
            convocatorias = convocatoriaBL.listarConvocatorias(indicador);
            ciclos = convocatoriaBL.listarCiclos(indicador);

            if(indicador == 1)
            {
                btnSeleccionar.Visible = true;
                btnEliminar.Visible = false;
            }
            if(indicador == 2)
            {
                btnSeleccionar.Visible = false;
                btnEliminar.Visible = false;
            }
            if(indicador == 3)
            {
                btnSeleccionar.Visible = true;
                btnEliminar.Visible = true;
            }

            cbFiltroCiclo.DataSource = ciclos;
            cbFiltroCiclo.Text = null;
            cbFiltroCiclo.Text = " - Seleccione - ";
            dgvConvocatoria.AutoGenerateColumns = false;
            dgvConvocatoria.DataSource = convocatorias;

            visibilidadInicial();

            if (convocatorias.Count == 0) btnSeleccionar.Enabled = false;
       }

        public void visibilidadInicial()
        {
            chNombre.Checked = true;
            chDescripcion.Checked = true;
            chFechaInicio.Checked = true;
            chFechaFin.Checked = true;
            chFechaCreacion.Checked = false;
            chPrevistos.Checked = false;
            chCandidatos.Checked = false;
            chPostulantes.Checked = false;
            chSeleccionados.Checked = false;
            chCiclo.Checked = true;
            chBeca.Checked = true;
            chCreador.Checked = false;

            dgvConvocatoria.Columns[0].Visible = true;
            dgvConvocatoria.Columns[1].Visible = true;
            dgvConvocatoria.Columns[2].Visible = true;
            dgvConvocatoria.Columns[3].Visible = true;
            dgvConvocatoria.Columns[4].Visible = false;
            dgvConvocatoria.Columns[5].Visible = false;
            dgvConvocatoria.Columns[6].Visible = false;
            dgvConvocatoria.Columns[7].Visible = false;
            dgvConvocatoria.Columns[8].Visible = false;
            dgvConvocatoria.Columns[9].Visible = true;
            dgvConvocatoria.Columns[10].Visible = true;
            dgvConvocatoria.Columns[11].Visible = false;
        }

        private void BuscarConvocatoria_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            convocatoriaSeleccionada = (Convocatoria)dgvConvocatoria.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtFiltroNombre.Text == " - Seleccione - " && cbFiltroCiclo.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre o un ciclo a buscar", "Falta Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtFiltroNombre.Text == "")
            {
                convocatorias = convocatoriaBL.filtroCiclo(cbFiltroCiclo.Text);
                dgvConvocatoria.DataSource = convocatorias;
            }
            else if (cbFiltroCiclo.Text == " - Seleccione - ")
            {
                convocatorias = convocatoriaBL.filtroNombres(indicador, txtFiltroNombre.Text);
                dgvConvocatoria.DataSource = convocatorias;
            }

            else
            {
                convocatorias = convocatoriaBL.filtroNombreCiclo(txtFiltroNombre.Text, cbFiltroCiclo.Text);
                dgvConvocatoria.DataSource = convocatorias;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Está apunto de eliminar un registro de la base de datos. ¿Está seguro que desea realizarlo?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                Convocatoria convocatoria = (Convocatoria)dgvConvocatoria.CurrentRow.DataBoundItem;
                convocatoriaBL.eliminarConvocatoria(convocatoria);
                txtFiltroNombre.Text = null;
                cbFiltroCiclo.Text = null;
                convocatorias = convocatoriaBL.listarConvocatorias(indicador);
                dgvConvocatoria.DataSource = convocatorias;
                MessageBox.Show("El registro ha sido eliminado", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtFiltroNombre.Text = null;
            cbFiltroCiclo.Text = null;
            cbFiltroCiclo.Text = " - Seleccione - ";
            convocatorias = convocatoriaBL.listarConvocatorias(indicador);
            dgvConvocatoria.DataSource = convocatorias;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPersonalizar_Click(object sender, EventArgs e)
        {
            if (chNombre.Checked) dgvConvocatoria.Columns[0].Visible = true;
            else dgvConvocatoria.Columns[0].Visible = false;
            if (chDescripcion.Checked) dgvConvocatoria.Columns[1].Visible = true;
            else dgvConvocatoria.Columns[1].Visible = false;
            if (chFechaInicio.Checked) dgvConvocatoria.Columns[2].Visible = true;
            else dgvConvocatoria.Columns[2].Visible = false;
            if (chFechaFin.Checked) dgvConvocatoria.Columns[3].Visible = true;
            else dgvConvocatoria.Columns[3].Visible = false;
            if (chFechaCreacion.Checked) dgvConvocatoria.Columns[4].Visible = true;
            else dgvConvocatoria.Columns[4].Visible = false;
            if (chPrevistos.Checked) dgvConvocatoria.Columns[5].Visible = true;
            else dgvConvocatoria.Columns[5].Visible = false;
            if (chCandidatos.Checked) dgvConvocatoria.Columns[6].Visible = true;
            else dgvConvocatoria.Columns[6].Visible = false;
            if (chPostulantes.Checked) dgvConvocatoria.Columns[7].Visible = true;
            else dgvConvocatoria.Columns[7].Visible = false;
            if (chSeleccionados.Checked) dgvConvocatoria.Columns[8].Visible = true;
            else dgvConvocatoria.Columns[8].Visible = false;
            if (chCiclo.Checked) dgvConvocatoria.Columns[9].Visible = true;
            else dgvConvocatoria.Columns[9].Visible = false;
            if (chBeca.Checked) dgvConvocatoria.Columns[10].Visible = true;
            else dgvConvocatoria.Columns[10].Visible = false;
            if (chCreador.Checked) dgvConvocatoria.Columns[11].Visible = true;
            else dgvConvocatoria.Columns[11].Visible = false;
        }

        private void chFechaFin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

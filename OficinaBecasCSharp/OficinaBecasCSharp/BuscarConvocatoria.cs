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
        private bool esCicloActual;

        public Convocatoria ConvocatoriaSeleccionada { get => convocatoriaSeleccionada; set => convocatoriaSeleccionada = value; }

        public frmBuscarConvocatoria(BindingList<string> ciclos, bool esCicloActual)
        {
            InitializeComponent();
            this.ciclos = ciclos;
            this.esCicloActual = esCicloActual;
            convocatoriaBL = new ConvocatoriaBL();
            if (esCicloActual)
            {
                convocatorias = convocatoriaBL.listarConvocatoriasActuales(ciclos[0],ciclos[1]);
                cbFiltroCiclo.DataSource = ciclos;
            }
            else
            {
                btnSeleccionar.Visible = false;
                btnEliminar.Visible = false;
                convocatorias = convocatoriaBL.listarConvocatoriasAnteriores(ciclos[0], ciclos[1]);
                cbFiltroCiclo.DataSource = convocatoriaBL.ciclosAnteriores(ciclos[0], ciclos[1]);
            }
            if (ciclos[0] == "" && ciclos[1] == "") btnSeleccionar.Visible = true;

            cbFiltroCiclo.Text = null;
            dgvConvocatoria.AutoGenerateColumns = false;
            dgvConvocatoria.DataSource = convocatorias;
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
            if (esCicloActual == true)
            {
                if (txtFiltroNombre.Text == "" && cbFiltroCiclo.Text == "")
                {
                    MessageBox.Show("Debe ingresar un nombre o un ciclo a buscar", "Falta Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtFiltroNombre.Text == "")
                {
                    convocatorias = convocatoriaBL.filtroConvocatorias(cbFiltroCiclo.Text);
                    dgvConvocatoria.DataSource = convocatorias;
                }
                else if (cbFiltroCiclo.Text == "")
                {
                    convocatorias = convocatoriaBL.listarFiltroNombreActual(txtFiltroNombre.Text, ciclos[0], ciclos[1]);
                    dgvConvocatoria.DataSource = convocatorias;
                }

                else
                {
                    convocatorias = convocatoriaBL.filtroNombreCiclo(txtFiltroNombre.Text, cbFiltroCiclo.Text);
                    dgvConvocatoria.DataSource = convocatorias;
                }
            }
            else
            {
                if (txtFiltroNombre.Text == "" && cbFiltroCiclo.Text == "")
                {
                    MessageBox.Show("Debe ingresar un nombre o un ciclo a buscar", "Falta Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtFiltroNombre.Text == "")
                {
                    convocatorias = convocatoriaBL.filtroConvocatorias(cbFiltroCiclo.Text);
                    dgvConvocatoria.DataSource = convocatorias;
                }
                else if (cbFiltroCiclo.Text == "")
                {
                    convocatorias = convocatoriaBL.listarFiltroNombreAnterior(txtFiltroNombre.Text, ciclos[0], ciclos[1]);
                    dgvConvocatoria.DataSource = convocatorias;
                }

                else
                {
                    convocatorias = convocatoriaBL.filtroNombreCiclo(txtFiltroNombre.Text, cbFiltroCiclo.Text);
                    dgvConvocatoria.DataSource = convocatorias;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Está apunto de eliminar un registro de la base de datos. ¿Está seguro que desea realizarlo?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                Convocatoria convocatoria = (Convocatoria)dgvConvocatoria.CurrentRow.DataBoundItem;
                convocatoriaBL.eliminarConvocatoria(convocatoria);
                convocatorias = convocatoriaBL.listarConvocatoriasActuales(ciclos[0], ciclos[1]);
                dgvConvocatoria.DataSource = convocatorias;
                MessageBox.Show("El registro ha sido eliminado", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtFiltroNombre.Text = null;
            cbFiltroCiclo.Text = null;
            if (esCicloActual)
            {
                convocatorias = convocatoriaBL.listarConvocatoriasActuales(ciclos[0], ciclos[1]);
            }
            else
            {
                convocatorias = convocatoriaBL.listarConvocatoriasAnteriores(ciclos[0], ciclos[1]);
            }
            dgvConvocatoria.DataSource = convocatorias;
        }
    }
}

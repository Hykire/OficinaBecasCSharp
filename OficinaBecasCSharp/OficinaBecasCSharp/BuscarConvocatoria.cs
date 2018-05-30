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
        private string ciclo;

        public Convocatoria ConvocatoriaSeleccionada { get => convocatoriaSeleccionada; set => convocatoriaSeleccionada = value; }

        public frmBuscarConvocatoria(string ciclo, bool esCicloActual)
        {
            InitializeComponent();
            this.ciclo = ciclo;
            convocatoriaBL = new ConvocatoriaBL();
            if (esCicloActual) convocatorias = convocatoriaBL.listarConvocatoriasActuales(ciclo);
            else
            {
                btnSeleccionar.Visible = false;
                btnEliminar.Visible = false;
                convocatorias = convocatoriaBL.listarConvocatoriasAnteriores(ciclo);
            }

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
            if(txtFiltroNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre a buscar", "Falta Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            convocatorias = convocatoriaBL.listarFiltroNombre(txtFiltroNombre.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Está apunto de eliminar un registro de la base de datos. ¿Está seguro que desea realizarlo?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                Convocatoria convocatoria = (Convocatoria)dgvConvocatoria.CurrentRow.DataBoundItem;
                convocatoriaBL.eliminarConvocatoria(convocatoria);
                convocatorias = convocatoriaBL.listarConvocatoriasActuales(ciclo);
                dgvConvocatoria.DataSource = convocatorias;
                MessageBox.Show("El registro ha sido eliminado", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

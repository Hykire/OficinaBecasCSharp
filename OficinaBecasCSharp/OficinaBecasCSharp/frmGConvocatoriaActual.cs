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
    public partial class frmGConvocatoriaActual : Form
    {
        private ConvocatoriaBL convocatoriaBL;
        private AsistenteComunicacionesBL asistenteComunicacionesBL;
        private AsistenteComunicaciones asistente;
        private Beca beca;
        private bool actualizar;
        public frmGConvocatoriaActual(int idUsuario)
        {
            InitializeComponent();
            convocatoriaBL = new ConvocatoriaBL();
            asistenteComunicacionesBL = new AsistenteComunicacionesBL();
            asistente = asistenteComunicacionesBL.buscarAsistente(idUsuario);
            cbCicloConvocatoria.DataSource = agregarCiclos(DateTime.Today);
            txtIdConvocatoria.Enabled = false;
            txtNombreConvocatoria.Enabled = false;
            txtDescripcionConvocatoria.Enabled = false;
            dtFechaCreacion.Enabled = false;
            dtFechaInicio.Enabled = false;
            dtFechaFin.Enabled = false;
            txtTotalCandidatos.Enabled = false;
            txtCantidadCandidatosPrevistos.Enabled = false;
            txtCantidadPostulantes.Enabled = false;
            txtCreadorConvocatoria.Enabled = false;
            txtCantidadSeleccionados.Enabled = false;
            cbCicloConvocatoria.Enabled = false;
            txtBecaAsociada.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnBeca.Enabled = false;
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
            btnEditar.Enabled = false;
            EstadoInicial();
        }

        public BindingList<string> agregarCiclos(DateTime fecha)
        {
            BindingList<string> ciclos = new BindingList<string>();
            if (fecha.Month > 6)
            {
                ciclos.Add((fecha.Year + 1).ToString() + "-" + "1");
                ciclos.Add((fecha.Year + 1).ToString() + "-" + "2");
            }
            else
            {
                ciclos.Add((fecha.Year).ToString() + "-" + "2");
                ciclos.Add((fecha.Year + 1).ToString() + "-" + "1");
            }
            return ciclos;
        }

        public void EstadoInicial()
        {
            txtIdConvocatoria.Text = null;
            txtNombreConvocatoria.Text = null;
            txtDescripcionConvocatoria.Text = null;
            dtFechaCreacion.Text = null;
            dtFechaInicio.Text = null;
            dtFechaFin.Text = null;
            txtTotalCandidatos.Text = null;
            txtCantidadCandidatosPrevistos.Text = null;
            txtCantidadPostulantes.Text = null;
            txtCantidadSeleccionados.Text = null;
            txtCreadorConvocatoria.Text = null;
            cbCicloConvocatoria.Text = null;
            txtBecaAsociada.Text = null;
            actualizar = false;
            cbCicloConvocatoria.Text = " - Seleccione - ";
            dtFechaInicio.MinDate = DateTime.Today;
            dtFechaFin.MinDate = DateTime.Today;
            dtFechaInicio.MaxDate = DateTime.Today.AddYears(1);
            dtFechaFin.MaxDate = DateTime.Today.AddYears(1);
        }

        private void btnBeca_Click(object sender, EventArgs e)
        {
            BuscarBeca beca = new BuscarBeca();
            beca.Visible = true;
        }



        private void CoordinadorComunicaciones_Load(object sender, EventArgs e)
        {

        }

        private void lbNumeroRespuestas_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreConvocatoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            txtNombreConvocatoria.Enabled = true;
            txtDescripcionConvocatoria.Enabled = true;
            dtFechaInicio.Enabled = true;
            dtFechaFin.Enabled = true;
            txtTotalCandidatos.Enabled = false;
            txtCantidadCandidatosPrevistos.Enabled = true;
            txtCantidadPostulantes.Enabled = false;
            txtCantidadSeleccionados.Enabled = false;
            cbCicloConvocatoria.Enabled = true;
            btnGuardar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
            btnBeca.Enabled = true;
            btnEditar.Enabled = false;
            txtCreadorConvocatoria.Text = asistente.Nombres + " " + asistente.Apellidos;
            txtTotalCandidatos.Text = "0";
            txtCantidadPostulantes.Text = "0";
            txtCantidadSeleccionados.Text = "0";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdConvocatoria.Enabled = false;
            txtNombreConvocatoria.Enabled = false;
            txtDescripcionConvocatoria.Enabled = false;
            dtFechaCreacion.Enabled = false;
            dtFechaInicio.Enabled = false;
            dtFechaFin.Enabled = false;
            txtTotalCandidatos.Enabled = false;
            txtCantidadCandidatosPrevistos.Enabled = false;
            txtCantidadPostulantes.Enabled = false;
            txtCreadorConvocatoria.Enabled = false;
            txtCantidadSeleccionados.Enabled = false;
            cbCicloConvocatoria.Enabled = false;
            txtBecaAsociada.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
            btnBeca.Enabled = false;
            btnEditar.Enabled = false;
            EstadoInicial();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnBeca_Click_1(object sender, EventArgs e)
        {
            BuscarBeca buscarBeca = new BuscarBeca();
            buscarBeca.Owner = this;
            if (buscarBeca.ShowDialog() == DialogResult.OK)
            {
                txtBecaAsociada.Text = buscarBeca.BecaSeleccionada.Nombre_beca;
                beca = buscarBeca.BecaSeleccionada;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtNombreConvocatoria.Enabled = true;
            txtDescripcionConvocatoria.Enabled = true;
            dtFechaInicio.Enabled = true;
            dtFechaFin.Enabled = true;
            txtTotalCandidatos.Enabled = false;
            txtCantidadCandidatosPrevistos.Enabled = true;
            txtCantidadPostulantes.Enabled = false;
            txtCantidadSeleccionados.Enabled = false;
            cbCicloConvocatoria.Enabled = true;
            btnGuardar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
            btnBeca.Enabled = true;
            btnEditar.Enabled = false;
            actualizar = true;
        }

    }
}

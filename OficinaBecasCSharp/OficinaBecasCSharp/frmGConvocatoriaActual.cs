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
        private int idUsuario;
        public frmGConvocatoriaActual(int idUsuario)
        {
            InitializeComponent();
            convocatoriaBL = new ConvocatoriaBL();
            asistenteComunicacionesBL = new AsistenteComunicacionesBL();
            this.idUsuario = idUsuario;
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
            asistente = asistenteComunicacionesBL.buscarAsistente(idUsuario);
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

        private void btnNuevo_Click_1(object sender, EventArgs e)
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

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNombreConvocatoria.Text == "" || txtDescripcionConvocatoria.Text == "" || txtCantidadCandidatosPrevistos.Text == "" || txtCantidadPostulantes.Text == "" || txtTotalCandidatos.Text == "" || cbCicloConvocatoria.Text == "" || txtBecaAsociada.Text == "")
            {
                MessageBox.Show("No se ha ingresado información en todos los campos", "Falta Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int cantidad;
            if (!Int32.TryParse(txtCantidadCandidatosPrevistos.Text, out cantidad) || cantidad < 0)
            {
                MessageBox.Show("Debe ingresar un número en el campo Candidatos Previstos", "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((DateTime.Parse(dtFechaFin.Text).Month > 6 && cbCicloConvocatoria.Text.EndsWith("2")) || (DateTime.Parse(dtFechaFin.Text).Month <= 6 && cbCicloConvocatoria.Text.EndsWith("1")))
            {
                MessageBox.Show("La fecha fin no puede pertenecer al ciclo de la convocatoria", "Error en Rango de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Convocatoria convocatoria = new Convocatoria();
            convocatoria.NombreConvocatoria = txtNombreConvocatoria.Text;
            convocatoria.DescripcionConvocatoria = txtDescripcionConvocatoria.Text;
            convocatoria.FechaInicio = DateTime.Parse(dtFechaInicio.Text);
            convocatoria.FechaFin = DateTime.Parse(dtFechaFin.Text);
            convocatoria.FechaCreacion = DateTime.Parse(dtFechaCreacion.Text);
            convocatoria.CantidadCandidatosPrevistos = Int32.Parse(txtCantidadCandidatosPrevistos.Text);
            convocatoria.CantidadTotalCandidatos = Int32.Parse(txtTotalCandidatos.Text);
            convocatoria.CantidadPostulantes = Int32.Parse(txtCantidadPostulantes.Text);
            convocatoria.CantidadSeleccionados = Int32.Parse(txtCantidadSeleccionados.Text);
            convocatoria.CicloConvocatoria = cbCicloConvocatoria.Text;
            convocatoria.CreadorConvocatoria = asistente;
            convocatoria.BecaAsociada = beca;

            if (actualizar)
            {
                convocatoria.IdConvocatoria = Int32.Parse(txtIdConvocatoria.Text);
                convocatoriaBL.actualizarConvocatoria(convocatoria);
                if (MessageBox.Show("Está apunto de actualizar un registro de la base de datos. ¿Está seguro que desea realizarlo?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) MessageBox.Show("Se ha actualizado el registro de manera exitosa", "Registro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else return;
            }
            else
            {
                txtIdConvocatoria.Text = convocatoriaBL.agregarConvocatoria(convocatoria).ToString();
                MessageBox.Show("Se ha agregado el registro de manera exitosa", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            txtIdConvocatoria.Enabled = false;
            txtNombreConvocatoria.Enabled = false;
            txtDescripcionConvocatoria.Enabled = false;
            dtFechaCreacion.Enabled = false;
            dtFechaInicio.Enabled = false;
            dtFechaFin.Enabled = false;
            txtTotalCandidatos.Enabled = false;
            txtCantidadCandidatosPrevistos.Enabled = false;
            txtCantidadPostulantes.Enabled = false;
            txtCantidadSeleccionados.Enabled = false;
            txtCreadorConvocatoria.Enabled = false;
            cbCicloConvocatoria.Enabled = false;
            txtBecaAsociada.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnBeca.Enabled = false;
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
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

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            frmGConvocatoriaAntiguas convocatoria = new frmGConvocatoriaAntiguas(3);
            convocatoria.Owner = this;
            actualizar = false;
            if (convocatoria.ShowDialog() == DialogResult.OK)
            {
                dtFechaInicio.MinDate = DateTime.Today.AddYears(-10);
                txtIdConvocatoria.Text = convocatoria.ConvocatoriaSeleccionada.IdConvocatoria.ToString();
                txtNombreConvocatoria.Text = convocatoria.ConvocatoriaSeleccionada.NombreConvocatoria;
                txtDescripcionConvocatoria.Text = convocatoria.ConvocatoriaSeleccionada.DescripcionConvocatoria;
                dtFechaCreacion.Text = convocatoria.ConvocatoriaSeleccionada.FechaCreacion.ToString();
                dtFechaInicio.Text = convocatoria.ConvocatoriaSeleccionada.FechaInicio.ToString();
                dtFechaFin.Text = convocatoria.ConvocatoriaSeleccionada.FechaFin.ToString();
                txtCantidadCandidatosPrevistos.Text = convocatoria.ConvocatoriaSeleccionada.CantidadCandidatosPrevistos.ToString();
                txtTotalCandidatos.Text = convocatoria.ConvocatoriaSeleccionada.CantidadTotalCandidatos.ToString();
                txtCantidadPostulantes.Text = convocatoria.ConvocatoriaSeleccionada.CantidadPostulantes.ToString();
                txtCantidadSeleccionados.Text = convocatoria.ConvocatoriaSeleccionada.CantidadSeleccionados.ToString();
                txtCreadorConvocatoria.Text = convocatoria.ConvocatoriaSeleccionada.NombreCreadorConvocatoria;
                cbCicloConvocatoria.Text = convocatoria.ConvocatoriaSeleccionada.CicloConvocatoria;
                txtBecaAsociada.Text = convocatoria.ConvocatoriaSeleccionada.NombreBeca;
                beca = convocatoria.ConvocatoriaSeleccionada.BecaAsociada;
                asistente = convocatoria.ConvocatoriaSeleccionada.CreadorConvocatoria;
            }
            if (txtIdConvocatoria.Text == "")
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
                btnBeca.Enabled = false;
                btnNuevo.Enabled = true;
                btnBuscar.Enabled = true;
                btnEditar.Enabled = false;
                EstadoInicial();
                return;
            }
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnBuscar.Enabled = false;
            btnLimpiar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
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
    }
}

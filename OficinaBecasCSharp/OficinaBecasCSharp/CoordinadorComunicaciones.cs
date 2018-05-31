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
    public partial class CoordinadorComunicaciones : Form
    {
        private ConvocatoriaBL convocatoriaBL;
        private AsistenteComunicaciones asistente;
        private Beca beca;
        private bool actualizar;
        public CoordinadorComunicaciones()
        {
            InitializeComponent();
            convocatoriaBL = new ConvocatoriaBL();
            asistente = new AsistenteComunicaciones();
            asistente.Nombres = "Ariana";
            asistente.Apellidos = "Grande";
            asistente.IdAsistente = 1;
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
            btnCancelar.Enabled = false;
            btnBeca.Enabled = false;
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
            btnActualizar.Enabled = false;
            EstadoInicial();
        }

        public BindingList<string> agregarCiclos(DateTime fecha)
        {
            BindingList<string> ciclos = new BindingList<string>();
            if (fecha.Month < 7)
            {
                ciclos.Add(fecha.Year.ToString() + "-" + "1");
                ciclos.Add(fecha.Year.ToString() + "-" + "2");
            }
            else
            {
                ciclos.Add(fecha.Year.ToString() + "-" + "2");
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
            frmBuscarConvocatoria convocatoria = new frmBuscarConvocatoria(agregarCiclos(DateTime.Today),true);
            convocatoria.Owner = this;
            actualizar = false;
            if(convocatoria.ShowDialog() == DialogResult.OK)
            {
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
            if(txtIdConvocatoria.Text == "")
            {
                MessageBox.Show("No se ha seleccionado registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                btnCancelar.Enabled = false;
                btnBeca.Enabled = false;
                btnNuevo.Enabled = true;
                btnBuscar.Enabled = true;
                btnActualizar.Enabled = false;
                EstadoInicial();
                return;
            }
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;
            btnBuscar.Enabled = false;
            btnCancelar.Enabled = true;
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
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
            btnBeca.Enabled = true;
            btnActualizar.Enabled = false;
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
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
            btnBeca.Enabled = false;
            btnActualizar.Enabled = false;
            EstadoInicial();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombreConvocatoria.Text == "" || txtDescripcionConvocatoria.Text == "" || txtCantidadCandidatosPrevistos.Text == "" || txtCantidadPostulantes.Text == "" || txtTotalCandidatos.Text == "" || cbCicloConvocatoria.Text == "" || txtBecaAsociada.Text == "")
            {
                MessageBox.Show("No se ha ingresado información en todos los campos", "Falta Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btnCancelar.Enabled = false;
            btnBeca.Enabled = false;
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
            btnActualizar.Enabled = false;
        }

        private void btnBeca_Click_1(object sender, EventArgs e)
        {
            BuscarBeca buscarBeca = new BuscarBeca();
            buscarBeca.Owner = this;
            if(buscarBeca.ShowDialog() == DialogResult.OK)
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
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
            btnBeca.Enabled = true;
            btnActualizar.Enabled = false;
            actualizar = true;
        }
    }
}

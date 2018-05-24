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
        public CoordinadorComunicaciones()
        {
            InitializeComponent();
            convocatoriaBL = new ConvocatoriaBL();
            asistente = new AsistenteComunicaciones();
            asistente.Nombres = "Remus";
            asistente.Apellidos = "Lupin";
            asistente.IdAsistente = 1;
            BindingList<string> ciclos = new BindingList<string>();
            ciclos.Add("2018-1");
            ciclos.Add("2018-2");
            ciclos.Add("2019-1");
            ciclos.Add("2019-2");
            cbCicloConvocatoria.DataSource = ciclos;
            txtIdConvocatoria.Enabled = false;
            txtNombreConvocatoria.Enabled = false;
            txtDescripcionConvocatoria.Enabled = false;
            dtFechaCreacion.Enabled = false;
            dtFechaInicio.Enabled = false;
            dtFechaFin.Enabled = false;
            txtCantidadRespuestas.Enabled = false;
            txtCantidadPersonasPrevistas.Enabled = false;
            txtCantidadPersonasCovocadas.Enabled = false;
            txtCreadorConvocatoria.Enabled = false;
            cbCicloConvocatoria.Enabled = false;
            txtBecaAsociada.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnBeca.Enabled = false;
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
            EstadoInicial();
        }

        public void EstadoInicial()
        {
            txtIdConvocatoria.Text = null;
            txtNombreConvocatoria.Text = null;
            txtDescripcionConvocatoria.Text = null;
            dtFechaCreacion.Text = null;
            dtFechaInicio.Text = null;
            dtFechaFin.Text = null;
            txtCantidadRespuestas.Text = null;
            txtCantidadPersonasPrevistas.Text = null;
            txtCantidadPersonasCovocadas.Text = null;
            txtCreadorConvocatoria.Text = null;
            cbCicloConvocatoria.Text = null;
            txtBecaAsociada.Text = null;
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
            frmBuscarConvocatoria convocatoria = new frmBuscarConvocatoria();
            convocatoria.Owner = this;
            if(convocatoria.ShowDialog() == DialogResult.OK)
            {
                txtIdConvocatoria.Text = convocatoria.ConvocatoriaSeleccionada.IdConvocatoria.ToString();
                txtNombreConvocatoria.Text = convocatoria.ConvocatoriaSeleccionada.NombreConvocatoria;
                txtDescripcionConvocatoria.Text = convocatoria.ConvocatoriaSeleccionada.DescripcionConvocatoria;
                dtFechaCreacion.Text = convocatoria.ConvocatoriaSeleccionada.FechaCreacion.ToString();
                dtFechaInicio.Text = convocatoria.ConvocatoriaSeleccionada.FechaInicio.ToString();
                dtFechaFin.Text = convocatoria.ConvocatoriaSeleccionada.FechaFin.ToString();
                txtCantidadRespuestas.Text = convocatoria.ConvocatoriaSeleccionada.CantidadRespuestas.ToString();
                txtCantidadPersonasPrevistas.Text = convocatoria.ConvocatoriaSeleccionada.CantidadPersonasPrevistas.ToString();
                txtCantidadPersonasCovocadas.Text = convocatoria.ConvocatoriaSeleccionada.CantidadPersonasConvocadas.ToString();
                txtCreadorConvocatoria.Text = convocatoria.ConvocatoriaSeleccionada.NombreCreadorConvocatoria;
                cbCicloConvocatoria.Text = convocatoria.ConvocatoriaSeleccionada.CicloConvocatoria;
                txtBecaAsociada.Text = convocatoria.ConvocatoriaSeleccionada.NombreBeca;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            txtNombreConvocatoria.Enabled = true;
            txtDescripcionConvocatoria.Enabled = true;
            dtFechaInicio.Enabled = true;
            dtFechaFin.Enabled = true;
            txtCantidadRespuestas.Enabled = true;
            txtCantidadPersonasPrevistas.Enabled = true;
            txtCantidadPersonasCovocadas.Enabled = true;
            cbCicloConvocatoria.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
            btnBeca.Enabled = true;
            txtCreadorConvocatoria.Text = asistente.Nombres + " " + asistente.Apellidos;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdConvocatoria.Enabled = false;
            txtNombreConvocatoria.Enabled = false;
            txtDescripcionConvocatoria.Enabled = false;
            dtFechaCreacion.Enabled = false;
            dtFechaInicio.Enabled = false;
            dtFechaFin.Enabled = false;
            txtCantidadRespuestas.Enabled = false;
            txtCantidadPersonasPrevistas.Enabled = false;
            txtCantidadPersonasCovocadas.Enabled = false;
            txtCreadorConvocatoria.Enabled = false;
            cbCicloConvocatoria.Enabled = false;
            txtBecaAsociada.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
            btnBeca.Enabled = false;
            EstadoInicial();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombreConvocatoria.Text == "" || txtDescripcionConvocatoria.Text == "" || txtCantidadPersonasPrevistas.Text == "" || txtCantidadPersonasCovocadas.Text == "" || txtCantidadRespuestas.Text == "" || cbCicloConvocatoria.Text == "" || txtBecaAsociada.Text == "")
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
            convocatoria.CantidadPersonasPrevistas = Int32.Parse(txtCantidadPersonasPrevistas.Text);
            convocatoria.CantidadPersonasConvocadas = Int32.Parse(txtCantidadPersonasCovocadas.Text);
            convocatoria.CantidadRespuestas = Int32.Parse(txtCantidadRespuestas.Text);
            convocatoria.CicloConvocatoria = cbCicloConvocatoria.Text;
            convocatoria.CreadorConvocatoria = asistente;
            convocatoria.BecaAsociada = beca;

            txtIdConvocatoria.Text = convocatoriaBL.agregarConvocatoria(convocatoria).ToString();

            MessageBox.Show("Se ha agregado el registro de manera exitosa", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtIdConvocatoria.Enabled = false;
            txtNombreConvocatoria.Enabled = false;
            txtDescripcionConvocatoria.Enabled = false;
            dtFechaCreacion.Enabled = false;
            dtFechaInicio.Enabled = false;
            dtFechaFin.Enabled = false;
            txtCantidadRespuestas.Enabled = false;
            txtCantidadPersonasPrevistas.Enabled = false;
            txtCantidadPersonasCovocadas.Enabled = false;
            txtCreadorConvocatoria.Enabled = false;
            cbCicloConvocatoria.Enabled = false;
            txtBecaAsociada.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnBeca.Enabled = false;
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
            EstadoInicial();
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
    }
}

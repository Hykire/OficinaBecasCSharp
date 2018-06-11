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
    public partial class frmGestionarCandidatos : Form
    {
        private Convocatoria convocatoria;
        public frmGestionarCandidatos()
        {
            InitializeComponent();
            EstadoInicial();
        }

        public void EstadoInicial()
        {
            txtApellidos.Enabled = false;
            txtCandidatos.Enabled = false;
            txtCodigoPUCP.Enabled = false;
            txtCorreoAlternativo.Enabled = false;
            txtCorreoPUCP.Enabled = false;
            txtDNI.Enabled = false;
            txtEdad.Enabled = false;
            txtIdConvocatoria.Enabled = false;
            txtIdPersona.Enabled = false;
            txtNombreConvocatoria.Enabled = false;
            txtNombres.Enabled = false;
            txtPostulantes.Enabled = false;
            txtSeleccionados.Enabled = false;
            txtTelefonoFijo.Enabled = false;
            txtTelefonoMovil.Enabled = false;
            dtFechaFin.Enabled = false;
            dtFechaNacimiento.Enabled = false;
            chPostulo.Enabled = false;
            chFueSeleccionado.Enabled = false;
            rbFemenino.Enabled = false;
            rbMasculino.Enabled = false;
            btnBuscarConvocatoria.Enabled = true;
            btnBuscarPersona.Enabled = false;

            txtApellidos.Text = null;
            txtCandidatos.Text = null;
            txtCodigoPUCP.Text = null;
            txtCorreoAlternativo.Text = null;
            txtCorreoPUCP.Text = null;
            txtDNI.Text = null;
            txtEdad.Text = null;
            txtIdConvocatoria.Text = null;
            txtIdPersona.Text = null;
            txtNombreConvocatoria.Text = null;
            txtNombres.Text = null;
            txtPostulantes.Text = null;
            txtSeleccionados.Text = null;
            txtTelefonoFijo.Text = null;
            txtTelefonoMovil.Text = null;
            dtFechaFin.Text = null;
            dtFechaNacimiento.Text = null;
            chPostulo.Checked = false;
            chFueSeleccionado.Checked = false;
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;

            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingList<string> listaNula = new BindingList<string>();
            listaNula.Add("");
            listaNula.Add("");
            frmBuscarConvocatoria frmBuscarConvocatoria = new frmBuscarConvocatoria(listaNula, false);
            
            if(frmBuscarConvocatoria.ShowDialog() == DialogResult.OK)
            {
                convocatoria = frmBuscarConvocatoria.ConvocatoriaSeleccionada;
                txtIdConvocatoria.Text = frmBuscarConvocatoria.ConvocatoriaSeleccionada.IdConvocatoria.ToString();
                txtNombreConvocatoria.Text = frmBuscarConvocatoria.ConvocatoriaSeleccionada.NombreConvocatoria;
                dtFechaFin.Text = frmBuscarConvocatoria.ConvocatoriaSeleccionada.FechaFin.ToString();
                txtCandidatos.Text = frmBuscarConvocatoria.ConvocatoriaSeleccionada.CantidadTotalCandidatos.ToString();
                txtPostulantes.Text = frmBuscarConvocatoria.ConvocatoriaSeleccionada.CantidadPostulantes.ToString();
                txtSeleccionados.Text = frmBuscarConvocatoria.ConvocatoriaSeleccionada.CantidadSeleccionados.ToString();
                btnBuscar.Enabled = true;
                btnCancelar.Enabled = true;
                if (DateTime.Parse(dtFechaFin.Text) >= DateTime.Today) btnNuevo.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtApellidos.Enabled = true;
            txtCandidatos.Enabled = false;
            txtCodigoPUCP.Enabled = true;
            txtCorreoAlternativo.Enabled = true;
            txtCorreoPUCP.Enabled = true;
            txtDNI.Enabled = true;
            txtEdad.Enabled = true;
            txtIdConvocatoria.Enabled = false;
            txtIdPersona.Enabled = false;
            txtNombreConvocatoria.Enabled = false;
            txtNombres.Enabled = true;
            txtPostulantes.Enabled = false;
            txtSeleccionados.Enabled = false;
            txtTelefonoFijo.Enabled = true;
            txtTelefonoMovil.Enabled = true;
            dtFechaFin.Enabled = false;
            dtFechaNacimiento.Enabled = true;
            chPostulo.Enabled = true;
            chFueSeleccionado.Enabled = true;
            rbFemenino.Enabled = true;
            rbMasculino.Enabled = true;
            btnBuscarConvocatoria.Enabled = false;
            btnBuscarPersona.Enabled = true;

            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmBuscarPersona buscarPersona = new frmBuscarPersona();
            if (buscarPersona.ShowDialog() == DialogResult.OK) {
                Persona persona = buscarPersona.PersonaSeleccionada;
                txtApellidos.Text = persona.Apellidos;
                txtCodigoPUCP.Text = persona.CodigoPUCP.ToString();
                txtCorreoAlternativo.Text = persona.CorreoAlternativo;
                txtCorreoPUCP.Text = persona.CorreoPUCP;
                txtDNI.Text = persona.Dni.ToString();
                txtEdad.Text = persona.Edad.ToString();
                txtIdPersona.Text = persona.Id_persona.ToString();
                txtNombres.Text = persona.Nombres;
                txtTelefonoFijo.Text = persona.TelfFijo;
                txtTelefonoMovil.Text = persona.TelfMovil;
                dtFechaNacimiento.Text = persona.Fecha_nacimiento.ToString();
                if (persona.Sexo == 'M') rbMasculino.Checked = true;
                else if (persona.Sexo == 'F') rbFemenino.Checked = true;

                txtApellidos.Enabled = false;
                txtCodigoPUCP.Enabled = false;
                txtCorreoAlternativo.Enabled = false;
                txtCorreoPUCP.Enabled = false;
                txtDNI.Enabled = false;
                txtEdad.Enabled = false;
                txtIdPersona.Enabled = false;
                txtNombres.Enabled = false;
                txtTelefonoFijo.Enabled = false;
                txtTelefonoMovil.Enabled = false;
                dtFechaNacimiento.Enabled = false;
                rbMasculino.Enabled = false;
                rbFemenino.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Candidato candidato = new Candidato();
            candidato.Apellidos = txtApellidos.Text;
            candidato.CodigoPUCP = Int32.Parse(txtCodigoPUCP.Text);
            candidato.CorreoAlternativo = txtCorreoAlternativo.Text;
            candidato.CorreoPUCP = txtCorreoPUCP.Text;
            candidato.Dni = Int32.Parse(txtDNI.Text);
            candidato.Edad = Int32.Parse(txtEdad.Text);
            candidato.Estado = "ACTIVO";
            if (chPostulo.Checked) candidato.EstadoPostulacion = true;
            else candidato.EstadoPostulacion = false;
            if (chFueSeleccionado.Checked) candidato.EstadoSeleccion = true;
            else candidato.EstadoSeleccion = false;
            candidato.Fecha_nacimiento = DateTime.Parse(dtFechaNacimiento.Text);
            candidato.Nombres = txtNombres.Text;
            if (rbMasculino.Checked) candidato.Sexo = 'M';
            else if (rbFemenino.Checked) candidato.Sexo = 'F';
            candidato.TelfFijo = txtTelefonoFijo.Text;
            candidato.TelfMovil = txtTelefonoMovil.Text;

            if (txtIdPersona.Text == "") { }
            else { }

            MessageBox.Show("El candidato se ha registrado con éxito", "Registro Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtApellidos.Enabled = false;
            txtCodigoPUCP.Enabled = false;
            txtCorreoAlternativo.Enabled = false;
            txtCorreoPUCP.Enabled = false;
            txtDNI.Enabled = false;
            txtEdad.Enabled = false;
            txtIdPersona.Enabled = false;
            txtNombres.Enabled = false;
            txtTelefonoFijo.Enabled = false;
            txtTelefonoMovil.Enabled = false;
            dtFechaNacimiento.Enabled = false;
            rbMasculino.Enabled = false;
            rbFemenino.Enabled = false;
            chPostulo.Enabled = false;
            chFueSeleccionado.Enabled = false;
            btnBuscarPersona.Enabled = false;

            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            btnBuscar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCandidato buscarCandidato = new BuscarCandidato();
            if(buscarCandidato.ShowDialog() == DialogResult.OK)
            {
                btnActualizar.Enabled = true;
                btnCancelar.Enabled = true;
                btnBuscar.Enabled = false;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = false;
            }
        }
    }
}

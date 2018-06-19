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
    public partial class frmGestionarCandidatos : Form
    {
        private Convocatoria convocatoria;
        private CandidatoBL candidatoBL;
        private Candidato candidato;
        private bool actualizar;
        private bool buscar;
        public frmGestionarCandidatos()
        {
            candidatoBL = new CandidatoBL();
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
            txtIdCandidato.Enabled = false;
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
            btnBuscarCandidato.Enabled = false;

            txtApellidos.Text = null;
            txtCandidatos.Text = null;
            txtCodigoPUCP.Text = null;
            txtCorreoAlternativo.Text = null;
            txtCorreoPUCP.Text = null;
            txtDNI.Text = null;
            txtEdad.Text = null;
            txtIdConvocatoria.Text = null;
            txtIdCandidato.Text = null;
            txtNombreConvocatoria.Text = null;
            txtNombres.Text = null;
            txtPostulantes.Text = null;
            txtSeleccionados.Text = null;
            txtTelefonoFijo.Text = null;
            txtTelefonoMovil.Text = null;
            dtFechaFin.Text = DateTime.Today.AddYears(-15).ToString();
            chPostulo.Checked = false;
            chFueSeleccionado.Checked = false;
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;

            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
            btnEditar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingList<string> listaNula = new BindingList<string>();
            listaNula.Add("");
            listaNula.Add("");
            frmGConvocatoriaAntiguas frmBuscarConvocatoria = new frmGConvocatoriaAntiguas(1);

            if (frmBuscarConvocatoria.ShowDialog() == DialogResult.OK)
            {
                convocatoria = frmBuscarConvocatoria.ConvocatoriaSeleccionada;
                txtIdConvocatoria.Text = frmBuscarConvocatoria.ConvocatoriaSeleccionada.IdConvocatoria.ToString();
                txtNombreConvocatoria.Text = frmBuscarConvocatoria.ConvocatoriaSeleccionada.NombreConvocatoria;
                dtFechaFin.Text = frmBuscarConvocatoria.ConvocatoriaSeleccionada.FechaFin.ToString();
                txtCandidatos.Text = frmBuscarConvocatoria.ConvocatoriaSeleccionada.CantidadTotalCandidatos.ToString();
                txtPostulantes.Text = frmBuscarConvocatoria.ConvocatoriaSeleccionada.CantidadPostulantes.ToString();
                txtSeleccionados.Text = frmBuscarConvocatoria.ConvocatoriaSeleccionada.CantidadSeleccionados.ToString();
                btnBuscar.Enabled = true;
                btnLimpiar.Enabled = true;
                if (DateTime.Parse(dtFechaFin.Text) >= DateTime.Today) btnNuevo.Enabled = true;
                else btnNuevo.Enabled = false;
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
            dtFechaNacimiento.MaxDate = DateTime.Today.AddYears(-15);
            dtFechaNacimiento.MinDate = DateTime.Today.AddYears(-100);

            actualizar = false;

            txtApellidos.Enabled = true;
            txtCandidatos.Enabled = false;
            txtCodigoPUCP.Enabled = true;
            txtCorreoAlternativo.Enabled = true;
            txtCorreoPUCP.Enabled = true;
            txtDNI.Enabled = true;
            txtEdad.Enabled = false;
            txtIdConvocatoria.Enabled = false;
            txtIdCandidato.Enabled = false;
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
            btnBuscarCandidato.Enabled = true;

            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
            btnEditar.Enabled = false;
            btnLimpiar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void button1_Click_1(object sender, EventArgs e) //Botón Buscar
        {
            BuscarCandidato buscarPersona = new BuscarCandidato(convocatoria, true);
            if (buscarPersona.ShowDialog() == DialogResult.OK)
            {
                Candidato persona = buscarPersona.CandidatoSeleccionado;
                this.candidato = persona;
                buscar = true;
                txtApellidos.Text = persona.Apellidos;
                txtCodigoPUCP.Text = persona.CodigoPUCP.ToString();
                txtCorreoAlternativo.Text = persona.CorreoAlternativo;
                txtCorreoPUCP.Text = persona.CorreoPUCP;
                txtDNI.Text = persona.Dni.ToString();
                txtEdad.Text = persona.Edad.ToString();
                txtIdCandidato.Text = persona.IdCandidato.ToString();
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
                txtIdCandidato.Enabled = false;
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
            int cantidad;
            if (!Int32.TryParse(txtCodigoPUCP.Text, out cantidad))
            {
                MessageBox.Show("Debe ingresar un número en el campo Código PUCP", "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Int32.TryParse(txtDNI.Text, out cantidad) || cantidad < 0)
            {
                MessageBox.Show("Debe ingresar un número en el campo DNI", "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Int32.TryParse(txtEdad.Text, out cantidad) || cantidad < 0)
            {
                MessageBox.Show("Debe ingresar un número en el campo Edad", "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!(txtCorreoPUCP.Text).Contains("@pucp.edu.pe") && !(txtCorreoPUCP.Text).Contains("@pucp.pe"))
            {
                MessageBox.Show("El correo ingresado no es un correo PUCP", "Error en el Formato de Correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtCorreoAlternativo.Text.Contains("@") || !txtCorreoAlternativo.Text.Contains("."))
            {
                MessageBox.Show("El texto ingresado no es un correo", "Error en el Formato de Correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtApellidos.Text == "" || txtCodigoPUCP.Text == "" || txtCorreoPUCP.Text == "" || txtDNI.Text == "" || txtEdad.Text == "" || (!rbFemenino.Checked && !rbMasculino.Checked) || txtNombres.Text == "" || dtFechaNacimiento.Text == "" || txtTelefonoMovil.Text == "")
            {
                MessageBox.Show("Falta completar información", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (chFueSeleccionado.Checked && !chPostulo.Checked)
            {
                MessageBox.Show("El candidato no puede haber sido seleccionado sin postular", "Inconsistencia en la Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Candidato candidato = new Candidato();
            if (actualizar == true || buscar == true) candidato = this.candidato;
            candidato.Apellidos = txtApellidos.Text;
            candidato.CodigoPUCP = Int32.Parse(txtCodigoPUCP.Text);
            candidato.CorreoAlternativo = txtCorreoAlternativo.Text;
            candidato.CorreoPUCP = txtCorreoPUCP.Text;
            candidato.Dni = Int32.Parse(txtDNI.Text);
            candidato.Edad = Int32.Parse(txtEdad.Text);
            candidato.Estado = "ACTIVO";
            if (chPostulo.Checked) candidato.EstadoPostulacion = "POSTULÓ";
            else candidato.EstadoPostulacion = "NO POSTULÓ";
            if (chFueSeleccionado.Checked) candidato.EstadoSeleccion = "SELECCIONADO";
            else candidato.EstadoSeleccion = "NO SELECCIONADO";
            candidato.Fecha_nacimiento = DateTime.Parse(dtFechaNacimiento.Text);
            candidato.Nombres = txtNombres.Text;
            if (rbMasculino.Checked) candidato.Sexo = 'M';
            else if (rbFemenino.Checked) candidato.Sexo = 'F';
            candidato.TelfFijo = txtTelefonoFijo.Text;
            candidato.TelfMovil = txtTelefonoMovil.Text;


            if (actualizar == false)
            {
                if (txtIdCandidato.Text == "")
                {
                    candidato.Id_persona = candidatoBL.insertarPersona(candidato);
                    candidato.IdCandidato = candidatoBL.insertarCandidato(candidato, convocatoria.IdConvocatoria);
                    txtIdCandidato.Text = candidato.IdCandidato.ToString();
                }
                else
                {
                    candidato.Id_persona = Int32.Parse(txtIdCandidato.Text);
                    candidatoBL.insertarCandidatoAntiguo(candidato, convocatoria.IdConvocatoria);
                }

                MessageBox.Show("El candidato se ha registrado con éxito", "Registro Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (actualizar == true)
            {
                if (convocatoria.FechaFin < DateTime.Today)
                {
                    candidatoBL.actualizarCandidatoAntiguo(candidato, convocatoria.IdConvocatoria);
                }
                else
                {
                    candidatoBL.actualizarCandidatoActual(candidato, convocatoria.IdConvocatoria);
                }
                MessageBox.Show("El candidato ha sido actualizado con éxito", "Registro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            candidatoBL.actualizarContadores(convocatoria);

            txtCandidatos.Text = convocatoria.CantidadCandidatosPrevistos.ToString();
            txtPostulantes.Text = convocatoria.CantidadPostulantes.ToString();
            txtSeleccionados.Text = convocatoria.CantidadSeleccionados.ToString();

            txtApellidos.Enabled = false;
            txtCodigoPUCP.Enabled = false;
            txtCorreoAlternativo.Enabled = false;
            txtCorreoPUCP.Enabled = false;
            txtDNI.Enabled = false;
            txtEdad.Enabled = false;
            txtIdCandidato.Enabled = false;
            txtNombres.Enabled = false;
            txtTelefonoFijo.Enabled = false;
            txtTelefonoMovil.Enabled = false;
            dtFechaNacimiento.Enabled = false;
            rbMasculino.Enabled = false;
            rbFemenino.Enabled = false;
            chPostulo.Enabled = false;
            chFueSeleccionado.Enabled = false;
            btnBuscarCandidato.Enabled = false;

            btnEditar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnBuscar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCandidato buscarCandidato = new BuscarCandidato(convocatoria);
            if (buscarCandidato.ShowDialog() == DialogResult.OK)
            {
                btnBuscarConvocatoria.Enabled = false;
                Candidato persona = buscarCandidato.CandidatoSeleccionado;
                candidato = buscarCandidato.CandidatoSeleccionado;
                txtApellidos.Text = persona.Apellidos;
                txtCodigoPUCP.Text = persona.CodigoPUCP.ToString();
                txtCorreoAlternativo.Text = persona.CorreoAlternativo;
                txtCorreoPUCP.Text = persona.CorreoPUCP;
                txtDNI.Text = persona.Dni.ToString();
                txtEdad.Text = persona.Edad.ToString();
                txtIdCandidato.Text = persona.Id_persona.ToString();
                txtNombres.Text = persona.Nombres;
                txtTelefonoFijo.Text = persona.TelfFijo;
                txtTelefonoMovil.Text = persona.TelfMovil;
                dtFechaNacimiento.Text = persona.Fecha_nacimiento.ToString();
                txtIdCandidato.Text = persona.IdCandidato.ToString();

                if (persona.Sexo == 'M') rbMasculino.Checked = true;
                else if (persona.Sexo == 'F') rbFemenino.Checked = true;
                if (persona.EstadoPostulacion == "POSTULÓ") chPostulo.Checked = true;
                else if (persona.EstadoPostulacion == "NO POSTULÓ") chPostulo.Checked = false;
                if (persona.EstadoSeleccion == "SELECCIONADO") chFueSeleccionado.Checked = true;
                else if (persona.EstadoSeleccion == "NO SELECCIONADO") chFueSeleccionado.Checked = false;

                txtApellidos.Enabled = false;
                txtCodigoPUCP.Enabled = false;
                txtCorreoAlternativo.Enabled = false;
                txtCorreoPUCP.Enabled = false;
                txtDNI.Enabled = false;
                txtEdad.Enabled = false;
                txtIdCandidato.Enabled = false;
                txtNombres.Enabled = false;
                txtTelefonoFijo.Enabled = false;
                txtTelefonoMovil.Enabled = false;
                dtFechaNacimiento.Enabled = false;
                rbMasculino.Enabled = false;
                rbFemenino.Enabled = false;

                btnEditar.Enabled = true;
                btnLimpiar.Enabled = true;
                btnBuscar.Enabled = false;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizar = true;
            btnBuscarConvocatoria.Enabled = false;
            btnBuscarCandidato.Enabled = false;
            if (convocatoria.FechaFin < DateTime.Today)
            {
                txtApellidos.Enabled = false;
                txtCandidatos.Enabled = false;
                txtCodigoPUCP.Enabled = false;
                txtCorreoAlternativo.Enabled = false;
                txtCorreoPUCP.Enabled = false;
                txtDNI.Enabled = false;
                txtEdad.Enabled = false;
                txtIdConvocatoria.Enabled = false;
                txtIdCandidato.Enabled = false;
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
                btnBuscarConvocatoria.Enabled = false;
                btnBuscarCandidato.Enabled = false;
                chPostulo.Enabled = true;
                chFueSeleccionado.Enabled = true;
            }
            else
            {
                txtApellidos.Enabled = true;
                txtCandidatos.Enabled = false;
                txtCodigoPUCP.Enabled = true;
                txtCorreoAlternativo.Enabled = true;
                txtCorreoPUCP.Enabled = true;
                txtDNI.Enabled = true;
                txtEdad.Enabled = false;
                txtIdConvocatoria.Enabled = false;
                txtIdCandidato.Enabled = false;
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
                btnBuscarCandidato.Enabled = true;
            }

            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
            btnEditar.Enabled = false;
            btnLimpiar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void dtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Parse(dtFechaNacimiento.Text).Month > DateTime.Today.Month)
            {
                txtEdad.Text = (DateTime.Today.Year - DateTime.Parse(dtFechaNacimiento.Text).Year - 1).ToString();
            }
            else if (DateTime.Parse(dtFechaNacimiento.Text).Month == DateTime.Today.Month)
            {
                if (DateTime.Parse(dtFechaNacimiento.Text).Day > DateTime.Today.Day)
                {
                    txtEdad.Text = (DateTime.Today.Year - DateTime.Parse(dtFechaNacimiento.Text).Year - 1).ToString();
                }
                else txtEdad.Text = (DateTime.Today.Year - DateTime.Parse(dtFechaNacimiento.Text).Year).ToString();
            }
            else txtEdad.Text = (DateTime.Today.Year - DateTime.Parse(dtFechaNacimiento.Text).Year).ToString();
        }

        private void dtFechaNacimiento_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }
        
    }
}

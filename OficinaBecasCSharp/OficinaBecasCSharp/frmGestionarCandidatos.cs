﻿using Controlador;
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
            actualizar = false;

            txtApellidos.Enabled = true;
            txtCandidatos.Enabled = false;
            txtCodigoPUCP.Enabled = true;
            txtCorreoAlternativo.Enabled = true;
            txtCorreoPUCP.Enabled = true;
            txtDNI.Enabled = true;
            txtEdad.Enabled = true;
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
            BuscarCandidato buscarPersona = new BuscarCandidato(convocatoria,true);
            if (buscarPersona.ShowDialog() == DialogResult.OK) {
                Candidato persona = buscarPersona.CandidatoSeleccionado;
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
            Candidato candidato = new Candidato();
            if (actualizar == true) candidato = this.candidato;
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
                    candidatoBL.insertarCandidatoAntiguo(candidato,convocatoria.IdConvocatoria);
                }

                MessageBox.Show("El candidato se ha registrado con éxito", "Registro Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if(actualizar == true)
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

            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            btnBuscar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCandidato buscarCandidato = new BuscarCandidato(convocatoria);
            if(buscarCandidato.ShowDialog() == DialogResult.OK)
            {
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

                btnActualizar.Enabled = true;
                btnCancelar.Enabled = true;
                btnBuscar.Enabled = false;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizar = true;

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
                txtEdad.Enabled = true;
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
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
        }
    }
}

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
    public partial class GestionarUsuarios : Form
    {
        public GestionarUsuarios()
        {
            InitializeComponent();
            cbTUsuario.Items.Add("Becario");
            cbTUsuario.Items.Add("Coordinador Administrativo");
            cbTUsuario.Items.Add("Coordinador de Comunicaciones");
            cbTUsuario.Items.Add("Coordinador de Tutoría");
            cbTUsuario.Items.Add("Tutor");


            txtApellidos.Enabled = false;
            txtCodigoPUCP.Enabled = false;
            txtContrasena.Enabled = false;
            txtCorreo.Enabled = false;
            txtDireccion.Enabled = false;
            txtDNI.Enabled = false;
            txtEspecialidad.Enabled = false;
            txtNombres.Enabled = false;
            txtProfesion.Enabled = false;
            txtTCasa.Enabled = false;
            TxtTMovil.Enabled = false;
            cbTUsuario.Enabled = false;
            txtUsuario.Enabled = false;
            btmAceptar.Enabled = false;
            btmCancelar.Enabled = false;
        }

        private void btmAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "" || txtCodigoPUCP.Text == "" || txtContrasena.Text == "" || txtCorreo.Text == "" || txtDireccion.Text == "" || txtDNI.Text == "" || txtEspecialidad.Text == "" || txtNombres.Text == "" || txtProfesion.Text == "" || txtTCasa.Text == "" || TxtTMovil.Text == "" || txtUsuario.Text == "" || cbTUsuario.Text == "")
            {
                MessageBox.Show("Falta completar información", "Información Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult msgBox = MessageBox.Show("¿Está seguro que desea agregar a este usuario?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (msgBox == DialogResult.OK)
            {
                MessageBox.Show("El usuario ha sido agregado con éxito", "Usuario Agredado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApellidos.Enabled = false;
                txtCodigoPUCP.Enabled = false;
                txtContrasena.Enabled = false;
                txtCorreo.Enabled = false;
                txtDireccion.Enabled = false;
                txtDNI.Enabled = false;
                txtEspecialidad.Enabled = false;
                txtNombres.Enabled = false;
                txtProfesion.Enabled = false;
                txtTCasa.Enabled = false;
                TxtTMovil.Enabled = false;
                cbTUsuario.Enabled = false;
                txtUsuario.Enabled = false;
                btmAceptar.Enabled = false;
                btmCancelar.Enabled = false;
                txtApellidos.Text = null;
                txtCodigoPUCP.Text = null;
                txtContrasena.Text = null;
                txtCorreo.Text = null;
                txtDireccion.Text = null;
                txtDNI.Text = null;
                txtEspecialidad.Text = null;
                txtNombres.Text = null;
                txtProfesion.Text = null;
                txtTCasa.Text = null;
                TxtTMovil.Text = null;
                cbTUsuario.Text = null;
                txtUsuario.Text = null;
                agregarPersonaToolStripMenuItem.Enabled = true;
                modificarPersonaToolStripMenuItem.Enabled = true;
                mostrarDatosToolStripMenuItem.Enabled = true;
            }
            if (msgBox == DialogResult.Cancel) return;
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            txtApellidos.Enabled = false;
            txtCodigoPUCP.Enabled = false;
            txtContrasena.Enabled = false;
            txtCorreo.Enabled = false;
            txtDireccion.Enabled = false;
            txtDNI.Enabled = false;
            txtEspecialidad.Enabled = false;
            txtNombres.Enabled = false;
            txtProfesion.Enabled = false;
            txtTCasa.Enabled = false;
            TxtTMovil.Enabled = false;
            cbTUsuario.Enabled = false;
            txtUsuario.Enabled = false;
            btmAceptar.Enabled = false;
            btmCancelar.Enabled = false;
            txtApellidos.Text = null;
            txtCodigoPUCP.Text = null;
            txtContrasena.Text = null;
            txtCorreo.Text = null;
            txtDireccion.Text = null;
            txtDNI.Text = null;
            txtEspecialidad.Text = null;
            txtNombres.Text = null;
            txtProfesion.Text = null;
            txtTCasa.Text = null;
            TxtTMovil.Text = null;
            cbTUsuario.Text = null;
            txtUsuario.Text = null;
            agregarPersonaToolStripMenuItem.Enabled = true;
            modificarPersonaToolStripMenuItem.Enabled = true;
            mostrarDatosToolStripMenuItem.Enabled = true;
        }

        private void agregarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtApellidos.Enabled = true;
            txtCodigoPUCP.Enabled = true;
            txtContrasena.Enabled = true;
            txtCorreo.Enabled = true;
            txtDireccion.Enabled = true;
            txtDNI.Enabled = true;
            txtEspecialidad.Enabled = true;
            txtNombres.Enabled = true;
            txtProfesion.Enabled = true;
            txtTCasa.Enabled = true;
            TxtTMovil.Enabled = true;
            cbTUsuario.Enabled = true;
            txtUsuario.Enabled = true;
            btmAceptar.Enabled = true;
            btmCancelar.Enabled = true;
            agregarPersonaToolStripMenuItem.Enabled = false;
            modificarPersonaToolStripMenuItem.Enabled = false;
            mostrarDatosToolStripMenuItem.Enabled = false;
        }

        private void modificarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosUsuario dataUser = new DatosUsuario(true);
            dataUser.Visible = true;
        }

        private void mostrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosUsuario dataUser = new DatosUsuario(false);
            dataUser.Visible = true;
        }
    }
}

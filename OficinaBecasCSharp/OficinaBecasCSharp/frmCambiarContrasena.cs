using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista {
    public partial class frmCambiarContrasena : Form {
        private UsuarioBL usuarioBL;
        private int id = -1;
        public frmCambiarContrasena(int idUsuario) {
            InitializeComponent();
            usuarioBL = new UsuarioBL();
            id = idUsuario;
        }

        public bool validarContrasena(string nuevaContra, string confirmacion) {
            if (nuevaContra == "") return false;
            if (confirmacion == "") return false;
            if (confirmacion != nuevaContra) return false;
            else return true;
        }

        public void cambiarContrasena() {
            if (txtContraActual.Text == "") {
                MessageBox.Show("Ingrese su contraseña actual", "Cambio de contrasena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtContraNueva.Text == "") {
                MessageBox.Show("Ingrese su nueva contraseña", "Cambio de contrasena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtContraNuevaConf.Text == "") {
                MessageBox.Show("Ingrese la confirmacion de su nueva contraseña", "Cambio de contrasena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtContraNueva.Text.Length > 20) {
                MessageBox.Show("La contrasena no debe tener mas de 20 caracteres", "Cambio de contrasena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!usuarioBL.contrasenaCoincide(id, txtContraActual.Text)) {
                MessageBox.Show("Contrasena actual incorrecta", "Cambio de contrasena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (validarContrasena(txtContraNueva.Text, txtContraNuevaConf.Text)) {
                if (id == -1) return;
                usuarioBL.cambiarContrasena(id, txtContraNueva.Text);
                MessageBox.Show("¡Su contraseña se cambio exitosamente!", "Cambio de contrasena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else {
                MessageBox.Show("Las contrasenas no coinciden", "Cambio de contrasena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnCambiarContra_Click(object sender, EventArgs e) {
            cambiarContrasena();
        }

        private void txtContraActual_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                cambiarContrasena();
            }
        }

        private void txtContraNueva_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                cambiarContrasena();
            }
        }

        private void txtContraNuevaConf_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                cambiarContrasena();
            }
        }
    }
}

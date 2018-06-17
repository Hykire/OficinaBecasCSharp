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

namespace Vista
{
    public partial class Login : Form
    {
        private bool limpiarUsuario = false;
        private bool limpiarContrasena = false;
        private UsuarioBL usuarioBL;
        public Login()
        {
            InitializeComponent();
            usuarioBL = new UsuarioBL();
        }

        public void estadoInicial() {
            txtUsuario.Text = "Usuario";
            txtContrasena.Text = "Contrasena";
            limpiarUsuario = false;
            limpiarContrasena = false;
        }

        public void verificarUsuario() {
            if (txtUsuario.Text == "") {
                MessageBox.Show("Ingrese un usuario.", "Usuario incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtContrasena.Text == "") {
                MessageBox.Show("Ingrese una contraseña.", "Contrasena incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (usuarioBL.validarUsuario(txtUsuario.Text, txtContrasena.Text)) {
                Principal ventanaPrincipal = new Principal(obtenerIdUsuario());
                this.Hide();
                ventanaPrincipal.ShowDialog();
                estadoInicial();
                this.Show();
            }
            else {
                MessageBox.Show("Usuario o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarUsuario = false;
                limpiarContrasena = false;
                return;
            }
        }

        private void buttonSignIt_Click(object sender, EventArgs e) {
            verificarUsuario();
            
        }
        
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                verificarUsuario();
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                verificarUsuario();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e) {

        }

        private void txtUsuario_Click(object sender, EventArgs e) {
            if (!limpiarUsuario) txtUsuario.Text = "";
            limpiarUsuario = true;
        }

        private void textBox1_Click(object sender, EventArgs e) {
            if (!limpiarContrasena) txtContrasena.Text = "";
            limpiarContrasena = true;
        }

        public int obtenerIdUsuario() {
            return usuarioBL.obtenerIdUsuario(txtUsuario.Text);
        }
    }
}

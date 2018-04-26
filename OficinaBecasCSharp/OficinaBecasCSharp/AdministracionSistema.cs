using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista {
    public partial class AdministracionSistema : Form {
        public AdministracionSistema() {
            InitializeComponent();
            panelGestBecarios.Hide();
            panelGestUsuarios.Hide();
        }

        private void button1_Click(object sender, EventArgs e) {
            panelGestBecarios.Hide();
            panelGestUsuarios.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            panelGestBecarios.Show();
            panelGestUsuarios.Hide();
        }
        
        private void button4_Click(object sender, EventArgs e) {
            panelGestBecarios.Hide();
            panelGestUsuarios.Hide();
        }

        private void button8_Click(object sender, EventArgs e) {

        }

        private void btnNuevoBec_Click(object sender, EventArgs e) {
            AdministracionNuevoBecario ventanaNuevoBecario = new AdministracionNuevoBecario();
            if (ventanaNuevoBecario.ShowDialog() == DialogResult.OK) {

            }
        }

        private void btnModifBec_Click(object sender, EventArgs e) {
            AdministracionModificarBecario ventanaModificarBecario = new AdministracionModificarBecario();
            if (ventanaModificarBecario.ShowDialog() == DialogResult.OK) {

            }
        }

        private void btnNuevoUsu_Click(object sender, EventArgs e) {
            AdministradorNuevoUsuario ventanaNuevoUsuario = new AdministradorNuevoUsuario();
            if (ventanaNuevoUsuario.ShowDialog() == DialogResult.OK) {

            }
        }

        private void btnModifUsu_Click(object sender, EventArgs e) {
            AdministracionModificarUsuario ventanaModificarUsuario = new AdministracionModificarUsuario();
            if (ventanaModificarUsuario.ShowDialog() == DialogResult.OK) {

            }
        }

        private void button4_Click_1(object sender, EventArgs e) {
            GestionarBecas ventanaGestionarBecas = new GestionarBecas();
            if (ventanaGestionarBecas.ShowDialog() == DialogResult.OK) {

            }
        }
    }
}

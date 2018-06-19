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
    public partial class Principal : Form {
        private UsuarioBL usuarioBL;
        int id = -1;
        public Principal(int idUsuario) {
            InitializeComponent();
            
            usuarioBL = new UsuarioBL();
            id = idUsuario;
            string nombreUsuario = usuarioBL.obtenerNombreUsuario(idUsuario);
            lblNombreUsuario.Text = nombreUsuario;

            int tipoUsuario = usuarioBL.obtenerTipoUsuario(idUsuario);

            if (tipoUsuario != -1) {
                if (tipoUsuario == 2) modoTutor(); //tutor
                else if (tipoUsuario == 3) modoCoordTutor(); //coordinador de tutoria
                else if (tipoUsuario == 4) modoAdministrador(); //administrador
                else if (tipoUsuario == 5) modoAsistComunicacion(); //asistente de comunicacion
            }
        }

        public void modoAdministrador() {
            buttonAdmin.Enabled = true;
            buttonCT.Enabled = true;
            buttonTutor.Enabled = true;
            buttonAC.Enabled = true;
        }

        public void modoCoordTutor() {
            buttonAdmin.Enabled = false;
            buttonCT.Enabled = true;
            buttonTutor.Enabled = false;
            buttonAC.Enabled = false;
        }

        public void modoTutor() {
            buttonAdmin.Enabled = false;
            buttonCT.Enabled = false;
            buttonTutor.Enabled = true;
            buttonAC.Enabled = false;
        }

        public void modoAsistComunicacion() {
            buttonAdmin.Enabled = false;
            buttonCT.Enabled = false;
            buttonTutor.Enabled = false;
            buttonAC.Enabled = true;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (this.panel_Principal.Controls.Count > 0)
                this.panel_Principal.Controls.RemoveAt(0);
            AdministrarAsistComunicaciones form = Application.OpenForms.OfType<AdministrarAsistComunicaciones>().FirstOrDefault();
            AdministrarAsistComunicaciones ventanaCC = form ?? new AdministrarAsistComunicaciones(id);
            ventanaCC.TopLevel = false;
            ventanaCC.FormBorderStyle = FormBorderStyle.None;
            ventanaCC.Dock = DockStyle.Fill;
            this.panel_Principal.Controls.Add(ventanaCC);
            this.panel_Principal.Tag = ventanaCC;
            ventanaCC.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) {

            if (this.panel_Principal.Controls.Count > 0 )
                this.panel_Principal.Controls.RemoveAt(0);
            AdministracionSistema form = Application.OpenForms.OfType<AdministracionSistema>().FirstOrDefault();
            AdministracionSistema ventanaAdminSist = form ?? new AdministracionSistema();
            ventanaAdminSist.TopLevel = false;
            ventanaAdminSist.FormBorderStyle = FormBorderStyle.None;
            ventanaAdminSist.Dock = DockStyle.Fill;
            this.panel_Principal.Controls.Add(ventanaAdminSist);
            this.panel_Principal.Tag = ventanaAdminSist;
            ventanaAdminSist.Show();
        }

        private void buttonCT_Click(object sender, EventArgs e)
        {
            if (this.panel_Principal.Controls.Count > 0)
                this.panel_Principal.Controls.RemoveAt(0);
            AdministracionCoordTutores form = Application.OpenForms.OfType<AdministracionCoordTutores>().FirstOrDefault();
            AdministracionCoordTutores ventanagestionarTutores = form ?? new AdministracionCoordTutores();
            ventanagestionarTutores.TopLevel = false;
            ventanagestionarTutores.FormBorderStyle = FormBorderStyle.None;
            ventanagestionarTutores.Dock = DockStyle.Fill;
            this.panel_Principal.Controls.Add(ventanagestionarTutores);
            this.panel_Principal.Tag = ventanagestionarTutores;
            ventanagestionarTutores.Show();
        }

        private void buttonTutor_Click(object sender, EventArgs e)
        {
            if (this.panel_Principal.Controls.Count > 0)
                this.panel_Principal.Controls.RemoveAt(0);
            AdministrarTareaTutor form = Application.OpenForms.OfType<AdministrarTareaTutor>().FirstOrDefault();
            AdministrarTareaTutor gestionarTutor = form ?? new AdministrarTareaTutor();
            gestionarTutor.TopLevel = false;
            gestionarTutor.FormBorderStyle = FormBorderStyle.None;
            gestionarTutor.Dock = DockStyle.Fill;
            this.panel_Principal.Controls.Add(gestionarTutor);
            this.panel_Principal.Tag = gestionarTutor;
            gestionarTutor.Show();
        }

        private void btnCambiarContra_Click(object sender, EventArgs e) {
            frmCambiarContrasena ventanaCambioContra = new frmCambiarContrasena(id);
            ventanaCambioContra.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCambiarContrasena ventanaCambioContra = new frmCambiarContrasena(id);
            ventanaCambioContra.ShowDialog();
        }
    }
}

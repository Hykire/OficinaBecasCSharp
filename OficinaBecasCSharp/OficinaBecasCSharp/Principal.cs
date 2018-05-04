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
    public partial class Principal : Form {

        public Principal() {
            InitializeComponent();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (this.panel_Principal.Controls.Count > 0)
                this.panel_Principal.Controls.RemoveAt(0);
            CoordinadorComunicaciones form = Application.OpenForms.OfType<CoordinadorComunicaciones>().FirstOrDefault();
            CoordinadorComunicaciones ventanaCC = form ?? new CoordinadorComunicaciones();
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
            GestionarTutores form = Application.OpenForms.OfType<GestionarTutores>().FirstOrDefault();
            GestionarTutores gestionarTutores = form ?? new GestionarTutores();
            gestionarTutores.TopLevel = false;
            gestionarTutores.FormBorderStyle = FormBorderStyle.None;
            gestionarTutores.Dock = DockStyle.Fill;
            this.panel_Principal.Controls.Add(gestionarTutores);
            this.panel_Principal.Tag = gestionarTutores;
            gestionarTutores.Show();
        }

        private void buttonTutor_Click(object sender, EventArgs e)
        {
            if (this.panel_Principal.Controls.Count > 0)
                this.panel_Principal.Controls.RemoveAt(0);
            GestionarTutor form = Application.OpenForms.OfType<GestionarTutor>().FirstOrDefault();
            GestionarTutor gestionarTutor = form ?? new GestionarTutor();
            gestionarTutor.TopLevel = false;
            gestionarTutor.FormBorderStyle = FormBorderStyle.None;
            gestionarTutor.Dock = DockStyle.Fill;
            this.panel_Principal.Controls.Add(gestionarTutor);
            this.panel_Principal.Tag = gestionarTutor;
            gestionarTutor.Show();
        }
    }
}

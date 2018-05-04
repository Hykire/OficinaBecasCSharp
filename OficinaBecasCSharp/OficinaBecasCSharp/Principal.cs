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
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            CoordinadorComunicaciones form = Application.OpenForms.OfType<CoordinadorComunicaciones>().FirstOrDefault();
            CoordinadorComunicaciones ventanaCC = form ?? new CoordinadorComunicaciones();
            ventanaCC.TopLevel = false;
            ventanaCC.FormBorderStyle = FormBorderStyle.None;
            ventanaCC.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(ventanaCC);
            this.panelPrincipal.Tag = ventanaCC;
            ventanaCC.Show();

            //CoordinadorComunicaciones ventanaCC = new CoordinadorComunicaciones();
            //if( ventanaCC.ShowDialog() == DialogResult.OK)
            //{

            //}
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) {

            if (this.panelPrincipal.Controls.Count > 0 )
                this.panelPrincipal.Controls.RemoveAt(0);
            AdministracionSistema form = Application.OpenForms.OfType<AdministracionSistema>().FirstOrDefault();
            AdministracionSistema ventanaAdminSist = form ?? new AdministracionSistema();
            ventanaAdminSist.TopLevel = false;
            ventanaAdminSist.FormBorderStyle = FormBorderStyle.None;
            ventanaAdminSist.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(ventanaAdminSist);
            this.panelPrincipal.Tag = ventanaAdminSist;
            ventanaAdminSist.Show();
            //ventanaAdminSist.Visible = true;
            //ventanaAdminSist.MdiParent = this;
            
            //if (ventanaAdminSist.ShowDialog() == DialogResult.OK) {
            //}
        }

        private void buttonCT_Click(object sender, EventArgs e)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            GestionarTutores form = Application.OpenForms.OfType<GestionarTutores>().FirstOrDefault();
            GestionarTutores gestionarTutores = form ?? new GestionarTutores();
            gestionarTutores.TopLevel = false;
            gestionarTutores.FormBorderStyle = FormBorderStyle.None;
            gestionarTutores.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(gestionarTutores);
            this.panelPrincipal.Tag = gestionarTutores;
            gestionarTutores.Show();
            //GestionarTutores f_CT = new GestionarTutores();
            //if (f_CT.ShowDialog() == DialogResult.OK)
            //{
            //}
        }

        private void buttonTutor_Click(object sender, EventArgs e)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            GestionarTutor form = Application.OpenForms.OfType<GestionarTutor>().FirstOrDefault();
            GestionarTutor gestionarTutor = form ?? new GestionarTutor();
            gestionarTutor.TopLevel = false;
            gestionarTutor.FormBorderStyle = FormBorderStyle.None;
            gestionarTutor.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(gestionarTutor);
            this.panelPrincipal.Tag = gestionarTutor;
            gestionarTutor.Show();
            //FormTutor form_tuto = new FormTutor();
            //if (form_tuto.ShowDialog() == DialogResult.OK) { }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

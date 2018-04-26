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
            CoordinadorComunicaciones ventanaCC = new CoordinadorComunicaciones();
            if( ventanaCC.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) {
            AdministracionSistema ventanaAdminSist = new AdministracionSistema();
            if (ventanaAdminSist.ShowDialog() == DialogResult.OK) {
            }
        }

        private void buttonCT_Click(object sender, EventArgs e)
        {
            GestionarTutores f_CT = new GestionarTutores();
            if (f_CT.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void buttonTutor_Click(object sender, EventArgs e)
        {
            FormTutor form_tuto = new FormTutor();
            if (form_tuto.ShowDialog() == DialogResult.OK) { }
        }
    }
}

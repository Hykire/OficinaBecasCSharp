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
        }                  

        private void btnGestionarAlumnos_Click(object sender, EventArgs e)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frmBecado form = Application.OpenForms.OfType<frmBecado>().FirstOrDefault();
            frmBecado ventana = form ?? new frmBecado();
            ventana.TopLevel = false;
            ventana.FormBorderStyle = FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(ventana);
            this.panel2.Tag = ventana;
            ventana.Show();
        }

        private void GestionarBecasxAlumno_Click(object sender, EventArgs e)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frmBecadoxBeca form = Application.OpenForms.OfType<frmBecadoxBeca>().FirstOrDefault();
            frmBecadoxBeca ventana = form ?? new frmBecadoxBeca();
            ventana.TopLevel = false;
            ventana.FormBorderStyle = FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(ventana);
            this.panel2.Tag = ventana;
            ventana.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_gestionarBecados_Click(object sender, EventArgs e)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frmBecado form = Application.OpenForms.OfType<frmBecado>().FirstOrDefault();
            frmBecado ventana = form ?? new frmBecado();
            ventana.TopLevel = false;
            ventana.FormBorderStyle = FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(ventana);
            this.panel2.Tag = ventana;
            ventana.Show();
        }

        private void btn_becados_x_Becas_Click(object sender, EventArgs e)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frmBecadoxBeca form = Application.OpenForms.OfType<frmBecadoxBeca>().FirstOrDefault();
            frmBecadoxBeca ventana = form ?? new frmBecadoxBeca();
            ventana.TopLevel = false;
            ventana.FormBorderStyle = FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(ventana);
            this.panel2.Tag = ventana;
            ventana.Show();
        }

        private void btn_gestionarBecas_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class AdministracionCoordTutores : Form
    {
        public AdministracionCoordTutores()
        {
            InitializeComponent();
        }

        private void GBT_button_Click(object sender, EventArgs e)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frmGestionarTutores form = Application.OpenForms.OfType<frmGestionarTutores>().FirstOrDefault();
            frmGestionarTutores ventana = form ?? new frmGestionarTutores();
            ventana.TopLevel = false;
            ventana.FormBorderStyle = FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(ventana);
            this.panel2.Tag = ventana;
            ventana.Show();
        }

        private void GT_button_Click(object sender, EventArgs e)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frmGestionarTutoresTutor form = Application.OpenForms.OfType<frmGestionarTutoresTutor>().FirstOrDefault();
            frmGestionarTutoresTutor ventana = form ?? new frmGestionarTutoresTutor();
            ventana.TopLevel = false;
            ventana.FormBorderStyle = FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(ventana);
            this.panel2.Tag = ventana;
            ventana.Show();
        }

        private void GC_button_Click(object sender, EventArgs e)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frmGestionarCitasTutor form = Application.OpenForms.OfType<frmGestionarCitasTutor>().FirstOrDefault();
            frmGestionarCitasTutor ventana = form ?? new frmGestionarCitasTutor();
            ventana.TopLevel = false;
            ventana.FormBorderStyle = FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(ventana);
            this.panel2.Tag = ventana;
            ventana.Show();
        }
    }
}

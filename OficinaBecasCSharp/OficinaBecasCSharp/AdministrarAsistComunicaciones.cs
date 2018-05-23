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
    public partial class AdministrarAsistComunicaciones : Form
    {
        public AdministrarAsistComunicaciones()
        {
            InitializeComponent();
            cbConsulta.Items.Add("Ciclo Actual");
            cbConsulta.Items.Add("Ciclos Anteriores");
        }
        private void GC_button_Click_1(object sender, EventArgs e)
        {
            if (cbConsulta.Text == "Ciclo Actual")
            {
                if (this.panel2.Controls.Count > 0)
                    this.panel2.Controls.RemoveAt(0);
                CoordinadorComunicaciones form = Application.OpenForms.OfType<CoordinadorComunicaciones>().FirstOrDefault();
                CoordinadorComunicaciones ventana = form ?? new CoordinadorComunicaciones();
                ventana.TopLevel = false;
                ventana.FormBorderStyle = FormBorderStyle.None;
                ventana.Dock = DockStyle.Fill;
                this.panel2.Controls.Add(ventana);
                this.panel2.Tag = ventana;
                ventana.Show();
            }
            if (cbConsulta.Text == "Ciclos Anteriores")
            {
                if (this.panel2.Controls.Count > 0)
                    this.panel2.Controls.RemoveAt(0);
                frmCoordComunicCiclosPasados form = Application.OpenForms.OfType<frmCoordComunicCiclosPasados>().FirstOrDefault();
                frmCoordComunicCiclosPasados ventana = form ?? new frmCoordComunicCiclosPasados();
                ventana.TopLevel = false;
                ventana.FormBorderStyle = FormBorderStyle.None;
                ventana.Dock = DockStyle.Fill;
                this.panel2.Controls.Add(ventana);
                this.panel2.Tag = ventana;
                ventana.Show();
            }
        }
        private void AdministrarAsistComunicaciones_Load(object sender, EventArgs e)
        {

        }


    }
}

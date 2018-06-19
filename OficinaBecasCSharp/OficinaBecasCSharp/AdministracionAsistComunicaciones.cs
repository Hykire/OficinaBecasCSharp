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
    public partial class AdministracionAsistComunicaciones : Form
    {
        private int idUsuario;
        public AdministracionAsistComunicaciones(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }
        private void GC_button_Click_1(object sender, EventArgs e)
        {
                if (this.panel2.Controls.Count > 0)
                    this.panel2.Controls.RemoveAt(0);
                frmGConvocatoriaActual form = Application.OpenForms.OfType<frmGConvocatoriaActual>().FirstOrDefault();
                frmGConvocatoriaActual ventana = form ?? new frmGConvocatoriaActual(idUsuario);
                ventana.TopLevel = false;
                ventana.FormBorderStyle = FormBorderStyle.None;
                ventana.Dock = DockStyle.Fill;
                this.panel2.Controls.Add(ventana);
                this.panel2.Tag = ventana;
                ventana.Show();
            
        }
        public BindingList<string> agregarCiclos(DateTime fecha)
        {
            BindingList<string> ciclos = new BindingList<string>();
            if (fecha.Month >= 7)
            {
                ciclos.Add((fecha.Year + 1).ToString() + "-" + "1");
                ciclos.Add((fecha.Year + 1).ToString() + "-" + "2");
            }
            else
            {
                ciclos.Add((fecha.Year).ToString() + "-" + "2");
                ciclos.Add((fecha.Year + 1).ToString() + "-" + "1");
            }
            return ciclos;
        }
        private void AdministrarAsistComunicaciones_Load(object sender, EventArgs e) { }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frmGestionarCandidatos form = Application.OpenForms.OfType<frmGestionarCandidatos>().FirstOrDefault();
            frmGestionarCandidatos ventana = form ?? new frmGestionarCandidatos();
            ventana.TopLevel = false;
            ventana.FormBorderStyle = FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(ventana);
            this.panel2.Tag = ventana;
            ventana.Show();
        }

        private void btnGestionarConvocatoriaActual_Click(object sender, EventArgs e)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frmGConvocatoriaAntiguas form = Application.OpenForms.OfType<frmGConvocatoriaAntiguas>().FirstOrDefault();
            frmGConvocatoriaAntiguas ventana = form ?? new frmGConvocatoriaAntiguas(2);
            ventana.TopLevel = false;
            ventana.FormBorderStyle = FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(ventana);
            this.panel2.Tag = ventana;
            ventana.Show();
        }
    }
}

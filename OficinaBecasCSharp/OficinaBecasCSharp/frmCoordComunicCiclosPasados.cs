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
    public partial class frmCoordComunicCiclosPasados : Form
    {
        public frmCoordComunicCiclosPasados()
        {
            frmBuscarConvocatoria buscarConvocatoria = new frmBuscarConvocatoria("2018-1",false);
            buscarConvocatoria.Visible = true;
        }

        private void frmCoordComunicCiclosPasados_Load(object sender, EventArgs e)
        {

        }

        private void panelCC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}

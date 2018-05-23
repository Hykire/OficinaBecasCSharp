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
            InitializeComponent();
            txtNumeroEnviados.Visible = false;
            txtNumeroRespuestas.Visible = false;
            txtFechaConvocatoria.Visible = false;
            cbBeca.Visible = false;
            btnModificar.Visible = false;
            btnAceptar.Visible = false;
            lbNumeroTotalEnviados.Visible = false;
            lbNumeroRespuestas.Visible = false;
            lbNombreConvocatoria.Visible = false;
            lbFechaConvocatoria.Visible = false;
            dgvDatos.Visible = true;
            //btnFiltrarResultados.Visible = true;
            txtNombreConvocatoria.Visible = false;
            txtDescripcionConvocatoria.Visible = false;
            lbNombreConvocatoria.Visible = false;
            lbDescripciónConvocatoria.Visible = false;
            btnAgregar.Visible = false;
            btnEliminar.Visible = false;
            lbBeca.Visible = false;
            btnBeca.Visible = false;
           // txtFiltro.Visible = true;
        }

        private void frmCoordComunicCiclosPasados_Load(object sender, EventArgs e)
        {

        }
    }
}

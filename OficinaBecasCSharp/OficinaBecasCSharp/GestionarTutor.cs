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
    public partial class GestionarTutor : Form
    {
        public GestionarTutor()
        {
            InitializeComponent();
            panelConsultarEmails.Visible = false;
            panelConsultarBecas.Visible = false;
            panelConsultarBecario.Visible = false;
            panel2.Show();
        }

        

        private void btnBuscarBecas_Click(object sender, EventArgs e)
        {
            BuscarBeca frmBuscarBeca = new BuscarBeca();
            frmBuscarBeca.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBecasPUCP_Click(object sender, EventArgs e)
        {

        }

        private void btnBecasExternas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConsultarEmails_Click(object sender, EventArgs e)
        {
            panelConsultarEmails.Visible = true;
            panelConsultarBecario.Visible = false;
            panelConsultarBecas.Visible = false;
        }

        private void btnConsultarBecario_Click(object sender, EventArgs e)
        {
            panelConsultarEmails.Visible = false;
            panelConsultarBecario.Visible = true;
            panelConsultarBecas.Visible = false;

        }

        private void btnConsultarBecas_Click(object sender, EventArgs e)
        {
            panelConsultarEmails.Visible = false;
            panelConsultarBecario.Visible = false;
            panelConsultarBecas.Visible = true;

        }

        private void lblFiltro_Click(object sender, EventArgs e)
        {

        }

        private void ConsultarBecas_Load(object sender, EventArgs e)
        {

        }
    }
}

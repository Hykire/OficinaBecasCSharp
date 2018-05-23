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

            panel2.Show();
        }

        

        private void btnBuscarBecas_Click(object sender, EventArgs e)
        {
            BuscarBeca frmBuscarBeca = new BuscarBeca();
            frmBuscarBeca.Show();
        }
        /*
        private void CB_button_Click(object sender, EventArgs e)
        {
            panelConsultarEmails.Visible = false;
            panelConsultarBecario.Visible = false;
            panelConsultarBecas.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panelConsultarEmails.Visible = false;
            panelConsultarBecario.Visible = true;
            panelConsultarBecas.Visible = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panelConsultarEmails.Visible = true;
            panelConsultarBecario.Visible = false;
            panelConsultarBecas.Visible = false;
        }*/
    }
}

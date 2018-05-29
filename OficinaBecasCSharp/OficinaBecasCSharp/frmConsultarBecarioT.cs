using Controlador;
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
    public partial class frmConsultarBecarioT : Form
    {
        private PersonaBL logicaNegocioPersona;
        public frmConsultarBecarioT()
        {
            InitializeComponent();
            logicaNegocioPersona = new PersonaBL();
            //txtCodBecario = null;
        }

        private void btnBuscarBecario_Click(object sender, EventArgs e)
        {
            String cod;

            cod = txtCodBecario.Text.ToString();
            // MessageBox.Show(cod);
            dgvBecarios.AutoGenerateColumns = false;
            dgvBecarios.DataSource = logicaNegocioPersona.listarBecarios(cod);
        }
    }
}

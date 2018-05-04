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
    public partial class EditarTutor : Form
    {
        public EditarTutor()
        {
            InitializeComponent();
            CBEstadoET.SelectedIndex = 0;
            txtNombET.Enabled = false;
            txtApET.Enabled = false;
            txtApET.Enabled = false;
            txtCodET.Enabled = false;
        }

        private void Editar_Tutor_Load(object sender, EventArgs e)
        {

        }

        private void CBEstadoET_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodET_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptarET_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelarET_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

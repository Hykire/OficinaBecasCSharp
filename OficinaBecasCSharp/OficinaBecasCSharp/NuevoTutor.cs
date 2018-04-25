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
    public partial class NuevoTutor : Form
    {
        public NuevoTutor()
        {
            InitializeComponent();
            txtCodNT.Enabled = false;
            txtNombNT.Enabled = false;
            txtApNT.Enabled = false;
            CBEstadoNT.SelectedIndex= 0;
        }

        private void btnCancelarNT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptarNT_Click(object sender, EventArgs e)
        {
            /*
            if ((String.IsNullOrEmpty(txtCodNT.Text)) || (String.IsNullOrEmpty(txtNombNT.Text))
                    || (String.IsNullOrEmpty(txtApNT.Text)))
            {
                MessageBox.Show("Hay campos sin llenar", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
               
            }
            else
            {
               //codigo
            }
            */
            this.Dispose();
        }

        private void txtCodNT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarNT_Click(object sender, EventArgs e)
        {
            BuscarTutorNT frmBT = new BuscarTutorNT();
            frmBT.ShowDialog();
        }

        private void CBEstadoNT_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

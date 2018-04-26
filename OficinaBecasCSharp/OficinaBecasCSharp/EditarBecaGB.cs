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
    public partial class EditarBecaGB : Form
    {
        public EditarBecaGB()
        {
            InitializeComponent();
        }

        private void btnAceptarEBGB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelarEBGB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditarDocEBGB_Click(object sender, EventArgs e)
        {
            EditarDoc frmEditDoc = new EditarDoc();
            frmEditDoc.ShowDialog();
        }
    }
}

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
    public partial class AgregarCita : Form
    {
        public AgregarCita()
        {
            InitializeComponent();
        }

        private void btnAceptarACGC_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelarAGGC_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscarBecarioACGC_Click(object sender, EventArgs e)
        {
            //enlazarlo con modal de busqueda de becarios:
            BuscarBecarioT frmBBCT = new BuscarBecarioT();
            frmBBCT.ShowDialog();
        }
    }
}

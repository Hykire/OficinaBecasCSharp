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
    public partial class frmConsultarBecaTutor : Form
    {
        public frmConsultarBecaTutor()
        {
            InitializeComponent();
            
        }

        private void frmConsultarBecaTutor_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarBecaCBT_Click(object sender, EventArgs e)
        {
            BuscarBeca frmBuscarBecaT = new BuscarBeca();
            frmBuscarBecaT.Show();
        }
    }
}

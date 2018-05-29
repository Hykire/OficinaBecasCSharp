using Modelo;
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
        private BindingList<Beca> lstBecasSeleccionadas;
        public frmConsultarBecaTutor()
        {
            InitializeComponent();
            lstBecasSeleccionadas = new BindingList<Beca>();
            DGVConsBecaT.AutoGenerateColumns = false;
            DGVConsBecaT.DataSource = lstBecasSeleccionadas;
        }

        private void frmConsultarBecaTutor_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarBecaCBT_Click(object sender, EventArgs e)
        {
            BuscarBeca frmBuscarBecaT = new BuscarBeca();
            //frmBuscarBecaT.Show();
            if(frmBuscarBecaT.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(frmBuscarBecaT.BecaSeleccionada.Nombre_beca);
                MessageBox.Show(frmBuscarBecaT.BecaSeleccionada.Descripcion);
                lstBecasSeleccionadas.Add(frmBuscarBecaT.BecaSeleccionada);
                //DGVConsBecaT.DataSource = lstBecasSeleccionadas;
                //DGVConsBecaT.Refresh();
            }
        }
    }
}

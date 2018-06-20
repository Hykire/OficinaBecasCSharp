using Controlador;
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
        private BecaBL becaBL;
        private Beca becaSeleccionada;
        public frmConsultarBecaTutor()
        {
            InitializeComponent();
            lstBecasSeleccionadas = new BindingList<Beca>();
            DGVConsBecaT.AutoGenerateColumns = false;
            DGVConsBecaT.DataSource = lstBecasSeleccionadas;
            becaBL = new BecaBL();
            becaSeleccionada = new Beca();
        }

        private void frmConsultarBecaTutor_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarBecaCBT_Click(object sender, EventArgs e)
        {
            if (txtCodBecCBT.Text != "")
            {
                DGVConsBecaT.DataSource = becaBL.listarBecaSolicitada(txtCodBecCBT.Text);
                DGVConsBecaT.Refresh();
            }
            else
            {
                BuscarBeca frmBuscarBecaT = new BuscarBeca();
                // frmBuscarBecaT.Show();
                if (frmBuscarBecaT.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(frmBuscarBecaT.BecaSeleccionada.Nombre_beca);
                    //MessageBox.Show(frmBuscarBecaT.BecaSeleccionada.Descripcion);
                    lstBecasSeleccionadas.Add(frmBuscarBecaT.BecaSeleccionada);
                    //DGVConsBecaT.DataSource = lstBecasSeleccionadas;
                    //DGVConsBecaT.Refresh();
                }
            }
            
        }

        private void DGVConsBecaT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            becaSeleccionada = (Beca)DGVConsBecaT.CurrentRow.DataBoundItem;
            txtDescripcionSelec.Text = becaSeleccionada.Descripcion.ToString();
            //txtFechaConvocatoriaSelec.Text = becaSeleccionada.FechaConvocatoria.ToString();
            //txtFechaConvocatoriaSelec.Text = "";
            txtFinanciadorSelec.Text = becaSeleccionada.Financiador.ToString();
            txtNombreBecaSelec.Text = becaSeleccionada.Nombre_beca.ToString();
        }
    }
}

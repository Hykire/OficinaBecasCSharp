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
    public partial class frmConsultarBecarioT : Form
    {
        private BecadoBL logicaNegocioPersona;
        private Becado alumnoSeleccionado;
        private Becado_x_BecaBL logicaNegoAB;

        public frmConsultarBecarioT()
        {
            InitializeComponent();
            logicaNegocioPersona = new BecadoBL();
            alumnoSeleccionado = new Becado();
            logicaNegoAB = new Becado_x_BecaBL();
        }

        private void btnBuscarBecario_Click(object sender, EventArgs e)
        {
            String cod;
            
            cod = txtCodBecario.Text.ToString();
            // MessageBox.Show(cod);
            dgvBecarios.AutoGenerateColumns = false;
            dgvBecarios.DataSource = logicaNegocioPersona.listarBecarios(cod);
        }

        private void dgvBecarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            alumnoSeleccionado = (Becado)dgvBecarios.CurrentRow.DataBoundItem;
            txtApellidos.Text = alumnoSeleccionado.Apellidos.ToString();
            //txtFechaConvocatoriaSelec.Text = becaSeleccionada.FechaConvocatoria.ToString();
            txtCodigo.Text = alumnoSeleccionado.CodigoPUCP.ToString();;
            txtCorreoPUCP.Text = alumnoSeleccionado.CorreoPUCP.ToString();
            txtNombreBecario.Text = alumnoSeleccionado.Nombres.ToString();
        }

        private void btnVerHistBecas_Click(object sender, EventArgs e)
        {
            string idBec = alumnoSeleccionado.Id_becado.ToString();
            DGVCicloXBeca.AutoGenerateColumns = false;
            DGVCicloXBeca.DataSource = logicaNegoAB.BuscarIdBecas(idBec);

            //BecaBL logicaNegoBeca = new BecaBL();
            //BindingList<Beca> listaB = logicaNegoBeca.listar_Beca();
            //foreach (Beca b in listaB)
            //{
            //    if (((Becado_x_Beca)cbox_ciclo.SelectedItem).Id_beca == b.Id_beca)
            //    {
            //        cbox_beca.Text = b.Nombre_beca;
            //    }
            //}

        }
    }
}

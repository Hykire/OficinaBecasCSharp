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
        public frmConsultarBecarioT()
        {
            InitializeComponent();
            logicaNegocioPersona = new BecadoBL();
            alumnoSeleccionado = new Becado();
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
    }
}

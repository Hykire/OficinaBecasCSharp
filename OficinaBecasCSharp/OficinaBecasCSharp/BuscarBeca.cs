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
    public partial class BuscarBeca : Form
    {
        private BecaBL becaBL;
        private Beca becaSeleccionada;

        public Beca BecaSeleccionada { get => becaSeleccionada; set => becaSeleccionada = value; }

        public BuscarBeca()
        {
            InitializeComponent();
            becaBL = new BecaBL();
            dgvBuscarBecas.AutoGenerateColumns = false;
            dgvBuscarBecas.DataSource = becaBL.listarBecas();
        }

        private void dgvBuscarBecas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            becaSeleccionada = (Beca)dgvBuscarBecas.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BuscarBeca_Load(object sender, EventArgs e)
        {

        }
    }
}

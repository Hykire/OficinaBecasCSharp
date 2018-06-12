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
    public partial class frmBuscarBeca_F : Form
    {
        private Beca _becaSeleccionada;
        private BecaBL logicanegocioBeca;
        public frmBuscarBeca_F()
        {
            InitializeComponent();

            logicanegocioBeca = new BecaBL();
            _becaSeleccionada = new Beca();
            dgv_beca.AutoGenerateColumns = false;
            dgv_beca.AllowUserToAddRows = false; //quitar la ultima fila
            dgv_beca.DataSource = logicanegocioBeca.listarBeca();
        }

        public Beca BecaSeleccionada { get => _becaSeleccionada; set => _becaSeleccionada = value; }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            _becaSeleccionada = ((Beca)dgv_beca.CurrentRow.DataBoundItem);
            this.DialogResult = DialogResult.OK;
        }
    }
}

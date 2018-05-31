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
    public partial class frmBuscarTutor : Form
    {
        private Tutor personaSeleccionada;
        private TutorBL logicaNegocioTutor;
        public frmBuscarTutor()
        {
            InitializeComponent();
            logicaNegocioTutor = new TutorBL();
        }

        public Tutor PersonaSeleccionada { get => personaSeleccionada; set => personaSeleccionada = value; }

        private void btnCancelarBTBP_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregarT_Click(object sender, EventArgs e)
        {
            PersonaSeleccionada = (Tutor)DGVBuscartutor.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscarT_Click(object sender, EventArgs e)
        {
            string cod;
            cod = txtBuscarTutor.Text.ToString();
            DGVBuscartutor.AutoGenerateColumns = false;
            DGVBuscartutor.DataSource = logicaNegocioTutor.traerTutoresCod(cod);
        }
    }
}

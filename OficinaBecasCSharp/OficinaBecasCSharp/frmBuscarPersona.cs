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
    public partial class frmBuscarPersona : Form
    {
        private Persona personaSeleccionada;
        private PersonaBL logicaNegocioPersona;
        public frmBuscarPersona()
        {
            InitializeComponent();
            logicaNegocioPersona = new PersonaBL();
        }

        public Persona PersonaSeleccionada { get => personaSeleccionada; set => personaSeleccionada = value; }

        private void btnBuscarBTBP_Click(object sender, EventArgs e)
        {
            string cod;
            cod = txtBuscarTutorBP.Text.ToString();
            DGVBuscarPersona.AutoGenerateColumns = false;
            DGVBuscarPersona.DataSource = logicaNegocioPersona.listarPersonas(cod);
        }

        private void btnCancelarBTBP_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregarBTBP_Click(object sender, EventArgs e)
        {
            PersonaSeleccionada = (Persona)DGVBuscarPersona.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}

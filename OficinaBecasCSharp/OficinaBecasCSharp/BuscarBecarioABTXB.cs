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
    public partial class BuscarBecarioABTXB : Form
    {
        private Becado personaSeleccionada;
        private PersonaBL logicaNegocioPersona;
        private AlumnoBL logicaNegocioAlumno;

        public Becado PersonaSeleccionada { get => personaSeleccionada; set => personaSeleccionada = value; }

        public BuscarBecarioABTXB()
        {
            InitializeComponent();
            logicaNegocioPersona = new PersonaBL();
            logicaNegocioAlumno = new AlumnoBL();
        }

        private void btnAgregarABTXB_Click(object sender, EventArgs e)
        {
            PersonaSeleccionada = (Becado)DGVBuscarBecarioABTXB.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
            //this.Dispose();
        }

        private void btnCancelarABTXB_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnBuscarABTXB_Click(object sender, EventArgs e)
        {
            String cod;
            
            cod = txtBuscarBecarioABTXB.Text.ToString();
           // MessageBox.Show(cod);
            DGVBuscarBecarioABTXB.AutoGenerateColumns = false;
            DGVBuscarBecarioABTXB.DataSource = logicaNegocioAlumno.listarBecarios(cod);

           
        }

        private void BuscarBecarioABTXB_Load(object sender, EventArgs e)
        {

        }
    }
}

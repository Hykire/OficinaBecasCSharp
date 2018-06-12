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
    public partial class frmBuscarPersona_F : Form
    {
        private PersonaBL logicaNegoPersona;
        private Persona _personaSeleccionada;

        public Persona PersonaSeleccionada { get => _personaSeleccionada; set => _personaSeleccionada = value; }

        public frmBuscarPersona_F()
        {
            InitializeComponent();

            logicaNegoPersona = new PersonaBL();
            PersonaSeleccionada = new Persona();
            dvg_persona.AllowUserToAddRows = false; //quitar la ultima fila
            dvg_persona.AutoGenerateColumns = false;
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            string codigoB = tbox_codigo.Text;
            string nombreB = tbox_nombres.Text;
            string apellidoB = tbox_apellidos.Text;

            dvg_persona.DataSource = logicaNegoPersona.buscar_Persona_F(codigoB, nombreB, apellidoB);
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            _personaSeleccionada = ((Persona)dvg_persona.CurrentRow.DataBoundItem);
            this.DialogResult = DialogResult.OK;
        }
    }
}

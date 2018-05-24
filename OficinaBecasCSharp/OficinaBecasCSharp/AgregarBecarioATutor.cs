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
    public partial class AgregarBecarioATutor : Form
    {
        Persona p;
        PersonaBL logicaNegocioPer;
        public AgregarBecarioATutor()
        {
            InitializeComponent();
            
            txtCodABTXB.Enabled = false;
            txtNombABTXB.Enabled = false;
            txtApABTXB.Enabled = false;
            btnAceptarABTXB.Enabled = false;
            logicaNegocioPer = new PersonaBL();

            BindingList<Persona> lstTutores = new BindingList<Persona>();
            lstTutores = logicaNegocioPer.traerTutores();
            CBTutorABTXB.ValueMember = "Nombres";
            foreach(var e in lstTutores)
            {
                CBTutorABTXB.Items.Add(e);
            }
            CBTutorABTXB.SelectedIndex = 0;
        }

        private void CBTutorABTXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAceptarABTXB.Enabled = true;
        }

        private void btnBuscarABTXB_Click(object sender, EventArgs e)
        {

            BuscarBecarioABTXB frmABTXB = new BuscarBecarioABTXB();
            if (frmABTXB.ShowDialog() == DialogResult.OK)
            {
                p = (Persona)frmABTXB.PersonaSeleccionada;
                txtCodABTXB.Text = p.CodigoPUCP.ToString();
                txtNombABTXB.Text = p.Nombres;
                txtApABTXB.Text = p.Apellidos;
                TxtIdOcultoB.Text = p.Id_persona.ToString();
            }
            //frmABTXB.ShowDialog();
        }

        private void btnAceptarABTXB_Click(object sender, EventArgs e)
        {
            Alumno pe = new Alumno();
            Persona persona = new Persona();
            String id = TxtIdOcultoB.Text;
            persona = (Persona) CBTutorABTXB.SelectedItem;
            pe.Id_tutor = persona.Id_persona;
            pe.Id_persona = Convert.ToInt32(id);
           // pe.Id_tutor = Convert.ToInt32(idTut);
            logicaNegocioPer.enlazarBecario(pe);
            this.Dispose();

        }

        private void btnCancelarABTXB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AgregarBecarioATutor_Load(object sender, EventArgs e)
        {

        }
    }
}

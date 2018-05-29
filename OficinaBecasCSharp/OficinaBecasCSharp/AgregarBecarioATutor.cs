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
        Alumno per;
        PersonaBL logicaNegocioPer;
        TutorBL logicaNegocioTutor;
        public AgregarBecarioATutor()
        {
            InitializeComponent();
            
            txtCodABTXB.Enabled = false;
            txtNombABTXB.Enabled = false;
            txtApABTXB.Enabled = false;
            btnAceptarABTXB.Enabled = false;
            logicaNegocioPer = new PersonaBL();
            logicaNegocioTutor = new TutorBL();
            BindingList<Tutor> lstTutores = new BindingList<Tutor>();
            lstTutores = logicaNegocioTutor.traerTutores();
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
                per = (Alumno)frmABTXB.PersonaSeleccionada;
                txtCodABTXB.Text = per.CodigoPUCP.ToString();
                txtNombABTXB.Text = per.Nombres;
                txtApABTXB.Text = per.Apellidos;
                TxtIdOcultoB.Text = per.Id_alumno.ToString();
            }
            //frmABTXB.ShowDialog();
        }

        private void btnAceptarABTXB_Click(object sender, EventArgs e)
        {
           
            Tutor persona = new Tutor();
            String id = TxtIdOcultoB.Text;
            persona = (Tutor) CBTutorABTXB.SelectedItem;
            int idbec = Convert.ToInt32(TxtIdOcultoB.Text);
            string ciclo = cbxCiclo.SelectedItem.ToString();
            MessageBox.Show(idbec.ToString());
            logicaNegocioPer.enlazarBecario(persona,idbec, ciclo);
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

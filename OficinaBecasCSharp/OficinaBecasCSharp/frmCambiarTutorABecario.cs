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
    public partial class frmCambiarTutorABecario : Form
    {
        PersonaBL logicaNegocioPer;
        public frmCambiarTutorABecario()
        {
            InitializeComponent();
            txtCodCambiar.Enabled = false;
            txtNombCambiar.Enabled = false;
            txtApCambiar.Enabled = false;
            txtIdOcultoCambiar.Enabled = false;
            //llenar combobox
            logicaNegocioPer = new PersonaBL();
            BindingList<Persona> lstTutores = new BindingList<Persona>();
            lstTutores = logicaNegocioPer.traerTutores();
            cbxTutorCambiar.ValueMember = "Nombres";
            foreach (var e in lstTutores)
            {
                cbxTutorCambiar.Items.Add(e);
            }
            cbxTutorCambiar.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmCambiarTutorABecario_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            String idAlum = txtIdOcultoCambiar.Text;
            persona = (Persona) cbxTutorCambiar.SelectedItem;
            
            Alumno pe = new Alumno();
            pe.Id_tutor = persona.Id_persona;
            pe.Id_persona = Convert.ToInt32(idAlum);

            logicaNegocioPer.enlazarBecario2(pe);
            this.Dispose();
        }
    }
}

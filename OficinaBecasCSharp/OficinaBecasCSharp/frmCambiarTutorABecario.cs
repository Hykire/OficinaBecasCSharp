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
        TutorBL logicaNegocioTutor;
        public frmCambiarTutorABecario()
        {
            InitializeComponent();
            txtCodCambiar.Enabled = false;
            txtNombCambiar.Enabled = false;
            txtApCambiar.Enabled = false;
            txtIdOcultoCambiar.Enabled = false;
            //llenar combobox
            logicaNegocioPer = new PersonaBL();
            logicaNegocioTutor = new TutorBL();
            BindingList<Tutor> lstTutores = new BindingList<Tutor>();
            lstTutores = logicaNegocioTutor.traerTutores();
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
            Tutor persona = new Tutor();
            String idAlum = txtIdOcultoCambiar.Text;
            persona = (Tutor) cbxTutorCambiar.SelectedItem;
            
            Becado pe = new Becado();
            pe.Id_tutor = persona.IdTutor;
            //pe.Id_persona = Convert.ToInt32(idAlum);
            if (logicaNegocioPer.enlazarBecario2(pe, idAlum))
            {
                MessageBox.Show("La operación se realizó con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Dispose();
        }
    }
}

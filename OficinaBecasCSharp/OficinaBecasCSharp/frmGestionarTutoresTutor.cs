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
    public partial class frmGestionarTutoresTutor : Form
    {
        private Tutor tutorSelecc;
        private PersonaBL logicaNegocioPersona;
        private Persona p;
        public Tutor TutorSelecc { get => tutorSelecc; set => tutorSelecc = value; }

        public frmGestionarTutoresTutor()
        {
            InitializeComponent();
            logicaNegocioPersona = new PersonaBL();
            DGVTutores.AutoGenerateColumns = false;
            DGVTutores.DataSource = logicaNegocioPersona.listarTutores();
            txtIdOcultoGT.Enabled = false;
            txtCodGT.Enabled = false;
            txtNombGT.Enabled = false;
            txtApGt.Enabled = false;
            txtDni.Enabled = false;
            txtTelf.Enabled = false;
            txtEstado.Enabled = false;
            btnBuscarNT.Enabled = false;
            CBEstadoNT.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;

            BindingList<Persona> lstTutores = new BindingList<Persona>();
            lstTutores = logicaNegocioPersona.traerCoordinadores();
            cbxCoordinador.ValueMember = "Nombres";
            foreach (var en in lstTutores)
            {
                cbxCoordinador.Items.Add(en);
            }
            cbxCoordinador.SelectedIndex = 0;
        }

        private void frmGestionarTutoresTutor_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoTutor_Click(object sender, EventArgs e)
        {
            NuevoTutor frmNT = new NuevoTutor();
            frmNT.ShowDialog();
        }

        private void btnEditarTutor_Click(object sender, EventArgs e)
        {
            EditarTutor frmET = new EditarTutor();
            frmET.ShowDialog();
        }

        private void btnEliminarTutor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Desea eliminar de la lista el Tutor seleccionado?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void DGVTutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TutorSelecc = (Tutor)DGVTutores.CurrentRow.DataBoundItem;
            txtCodGT.Text = TutorSelecc.CodigoPUCP.ToString();
            txtNombGT.Text = TutorSelecc.Nombres.ToString();
            txtApGt.Text = TutorSelecc.Apellidos.ToString();
            txtIdOcultoGT.Text = TutorSelecc.Id_persona.ToString();
            txtDni.Text = TutorSelecc.Dni.ToString();
            txtTelf.Text = TutorSelecc.TelfMovil.ToString();
            char est = TutorSelecc.EstadoT;
            if(est == 'A')
            {
                txtEstado.Text = "Activo";
            }
            else
            {
                txtEstado.Text = "Inactivo";
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnBuscarNT.Enabled = true;
            CBEstadoNT.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            cbxCoordinador.Enabled = true;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdOcultoGT.Enabled = false;
            txtCodGT.Enabled = false;
            txtNombGT.Enabled = false;
            txtApGt.Enabled = false;
            txtDni.Enabled = false;
            txtTelf.Enabled = false;
            txtEstado.Enabled = false;
            btnBuscarNT.Enabled = false;
            CBEstadoNT.Enabled = false;
            cbxCoordinador.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;

            txtIdOcultoGT.Text = "";
            txtCodGT.Text = "";
            txtNombGT.Text = "";
            txtApGt.Text = "";
            txtDni.Text = "";
            txtTelf.Text = "";
            txtEstado.Text = "";
        }

        private void btnBuscarNT_Click(object sender, EventArgs e)
        {
            frmBuscarPersona frmBPersona = new frmBuscarPersona();
            if (frmBPersona.ShowDialog() == DialogResult.OK)
            {
                BindingList<Persona> lista = new BindingList<Persona>();
                p = (Persona)frmBPersona.PersonaSeleccionada;
                int cod = p.Id_persona;
                txtIdOcultoGT.Text = p.Id_persona.ToString();
                txtCodGT.Text = p.CodigoPUCP.ToString();
                txtNombGT.Text = p.Nombres;
                txtApGt.Text = p.Apellidos;
                txtDni.Text = p.Dni.ToString();
                txtTelf.Text = p.TelfMovil.ToString();
                txtEstado.Text = "Sin Estado";

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CBEstadoNT.Enabled = false;
            string idPer = txtIdOcultoGT.Text.ToString();//aqui esta el id del tutor
            //Tutor tut = new Tutor();
            //int estado = Convert.ToInt32(CBEstadoNT.SelectedItem);
            char est;
            if(CBEstadoNT.SelectedItem.ToString() == "Activo")
            {
                est = 'A';
            }else
            {
                est = 'I';
            }
            Persona per1 = new Persona();
            per1 = (Persona)cbxCoordinador.SelectedItem;
            string idcoord = per1.Id_persona.ToString(); //aqui esta el id del coordinador
            logicaNegocioPersona.insertarNuevoTutor(idPer, idcoord, est);

        }
    }
}

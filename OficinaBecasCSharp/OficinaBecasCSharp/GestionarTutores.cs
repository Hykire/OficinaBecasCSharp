﻿using Controlador;
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
    public partial class GestionarTutores : Form
    {
        private PersonaBL logicaNegocioPersona;
        private Persona tutorSelecc;
        private Persona p;

        public Persona TutorSelecc { get => tutorSelecc; set => tutorSelecc = value; }

        public GestionarTutores()
        {
            InitializeComponent();
            BindingList<Persona> lsttutores = new BindingList<Persona>();
            logicaNegocioPersona = new PersonaBL();
            
            TxtCodTutorBXT.Enabled = false;
            TxtNombTutorBXT.Enabled = false;
            TxtApeTutor.Enabled = false;
            btnBXTVer.Enabled = false;
            DGVBXT.AutoGenerateColumns = false;
            dgvListaTutores.AutoGenerateColumns = false;
            dgvListaTutores.DataSource = logicaNegocioPersona.listarTutores();

            //de segunda seccion
            txtBAcod.Enabled = false;
            txtBANomb.Enabled = false;
            txtBAApe.Enabled = false;
            txtBACodTutor.Enabled = false;
            txtBANombTutor.Enabled = false;
            txtBAApeTutor.Enabled = false;
            txtCAIdOcullto.Enabled = false;
            
        }

        private void btnEditarTutor_Click(object sender, EventArgs e)
        {
            EditarTutor frmET = new EditarTutor();
            frmET.ShowDialog();
        }

        private void btnBXTAnadir_Click(object sender, EventArgs e)
        {
            AgregarBecarioATutor frmABTXB = new AgregarBecarioATutor();
            frmABTXB.ShowDialog();
        }


        private void btnNuevoTutor_Click(object sender, EventArgs e)
        {
            NuevoTutor frmNT = new NuevoTutor();
            frmNT.ShowDialog();
        }

        private void GestionarTutores_Load(object sender, EventArgs e)
        {
            //ni bien aparezca este modal, se muestre la lista de tutores en el DGV
        }

        private void btnEliminarTutor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Desea eliminar de la lista el Tutor seleccionado?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

        }

        private void CBTutorGBXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBXTVer.Enabled = true;
        }

        private void TBCodTutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarTXB_Click(object sender, EventArgs e)
        {
            ModificarTXB frmTXB = new ModificarTXB();
            frmTXB.ShowDialog();
        }


        private void btnBuscarBeca_Click(object sender, EventArgs e)
        {
            BuscarBeca frmBuscarBecaT = new BuscarBeca();
            frmBuscarBecaT.Show();
        }

        private void btnBXTAnadir_Click_1(object sender, EventArgs e)
        {
            AgregarBecarioATutor frmABTXB = new AgregarBecarioATutor();
            frmABTXB.ShowDialog();
        }

        private void btnBuscarBecadoGBXT_Click(object sender, EventArgs e)
        {
            BuscarBecarioABTXB frmABTXB = new BuscarBecarioABTXB();
            if (frmABTXB.ShowDialog() == DialogResult.OK)
            {
                BindingList<Persona> lista = new BindingList<Persona>();
               p = (Persona)frmABTXB.PersonaSeleccionada;
                int cod = p.Id_persona;
                txtCAIdOcullto.Text = p.Id_persona.ToString();
                txtBAcod.Text = p.CodigoPUCP.ToString();
                txtBANomb.Text = p.Nombres;
                txtBAApe.Text = p.Apellidos;
                Persona per = new Persona();
                lista = logicaNegocioPersona.listarTutorDeBecado(cod);
                foreach (Persona en in lista){
                    per.CodigoPUCP = en.CodigoPUCP;
                    per.Nombres = en.Nombres;
                    per.Apellidos = en.Apellidos;
                }
                txtBACodTutor.Text = per.CodigoPUCP.ToString();
                txtBANombTutor.Text = per.Nombres;
                txtBAApeTutor.Text = per.Apellidos;
            }
        }

        private void LBXA_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaTutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvListaTutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TutorSelecc = (Persona)dgvListaTutores.CurrentRow.DataBoundItem;
            TxtCodTutorBXT.Text = TutorSelecc.CodigoPUCP.ToString();
            TxtNombTutorBXT.Text = TutorSelecc.Nombres.ToString();
            TxtApeTutor.Text = TutorSelecc.Apellidos.ToString();
            TxtIDOculto.Text = TutorSelecc.Id_persona.ToString();
            btnBXTVer.Enabled = true;
        }

        private void btnBXTVer_Click(object sender, EventArgs e)
        {
            String idTut = TxtIDOculto.Text;
            //MessageBox.Show(idTut);
            //DGVBXT.AutoGenerateColumns = false;
            DGVBXT.DataSource = logicaNegocioPersona.listarBecadosXTutor(idTut);
        }

        private void btnCambiarTutorAlumno_Click(object sender, EventArgs e)
        {
            frmCambiarTutorABecario frmCambTut = new frmCambiarTutorABecario();
            frmCambTut.txtCodCambiar.Text = txtBAcod.Text;
            frmCambTut.txtNombCambiar.Text = txtBANomb.Text;
            frmCambTut.txtApCambiar.Text = txtBAApe.Text;
            frmCambTut.txtIdOcultoCambiar.Text = txtCAIdOcullto.Text;
            frmCambTut.ShowDialog();
        }
    }
}

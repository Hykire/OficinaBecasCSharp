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
    public partial class frmGestionarCitasTutor : Form
    {
        private BecadoBL logicaNegocioBecado;
        private CitaBL logicaNegocioCita;
        private TutorBL logicaNegocioTutor;
        private Becado al;
        private Tutor tut;
        private Cita citaSelect;

        public Cita CitaSelect { get => citaSelect; set => citaSelect = value; }

        public frmGestionarCitasTutor()
        {
            InitializeComponent();
            logicaNegocioBecado = new BecadoBL();
            logicaNegocioCita = new CitaBL();
            logicaNegocioTutor = new TutorBL();
            DGVCitas.AutoGenerateColumns = false;
            //panel citas

            //txtBHoraGC.Enabled = false;
            txtCodTutorGC.Enabled = false;
            txtBTutorGC.Enabled = false;
            txtCodBecGC.Enabled = false;
            txtBBecarioGC.Enabled = false;
            txtBObsGC.Enabled = false;
            txtIdtutOculto.Enabled = false;
            txtIdBecOculto.Enabled = false;
            btnBuscarTutor.Enabled = false;
            btnBuscarBecario.Enabled = false;
            txtIdCitaOculto.Enabled = false;
            txtBLugarGC.Enabled = false;
            txtHora.Enabled = false;
        }
        private void BAgregarCitaGC_Click(object sender, EventArgs e)
        {
            AgregarCita frmAgergar = new AgregarCita();
            frmAgergar.ShowDialog();
        }
    //borrar:
        private void BEliminarCitaGC_Click(object sender, EventArgs e)
        {
            if (DGVCitas.SelectedRows.Count == 1)
            {
                MessageBox.Show("¿Desea eliminar la cita seleccionada?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cita", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }
        //borrar:
        private void BEditarCitaGC_Click(object sender, EventArgs e)
        {
            EditarCita frmAgergar = new EditarCita();
            frmAgergar.ShowDialog();
        }
        private void frmGestionarCitasTutor_Load(object sender, EventArgs e)
        {

        }
        //borrar:
        private void BAgregarCitaGC_Click_1(object sender, EventArgs e)
        {
           // AgregarCita frmAgergar = new AgregarCita();
            //frmAgergar.ShowDialog();
        }
        //borrar:
        private void BEditarCitaGC_Click_1(object sender, EventArgs e)
        {
            //EditarCita frmAgergar = new EditarCita();
            //frmAgergar.ShowDialog();
        }

        private void BEliminarCitaGC_Click_1(object sender, EventArgs e)
        {
            
        }
        
        private void BBuscarCitaGC_Click(object sender, EventArgs e)
        {
            txtBObsGC.Enabled = false;
            txtBObsGC.Enabled = false;

            BindingList<Cita> lista = new BindingList<Cita>();
            // MessageBox.Show(DTPSelDiaGC.Text);
            DGVCitas.DataSource = logicaNegocioCita.buscarcita(DateTime.Parse(DTPSelDiaGC.Text));
            //modificar para que tmbn traiga horas
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGVCitas.SelectedRows.Count == 1)
            {
                MessageBox.Show("¿Desea eliminar la cita seleccionada?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cita", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtBBecarioGC.Text = "";
            //txtBHoraGC.Text = "";
            txtBObsGC.Text = "";
            txtBTutorGC.Text = "";
            txtCodBecGC.Text = "";
            txtCodTutorGC.Text = "";
            txtIdtutOculto.Text = "";
            txtIdBecOculto.Text = "";
            txtIdCitaOculto.Text = "";
            txtBLugarGC.Text = "";
            txtHora.Text = "";

            DTPSelDiaGC.Enabled = false;
            BBuscarCitaGC.Enabled = false;
            DTPSelDiaGC.Enabled = true;
           //txtBHoraGC.Enabled = true;
            txtBObsGC.Enabled = true;

            btnBuscarTutor.Enabled = true;
            btnBuscarBecario.Enabled = true;

            txtBLugarGC.Enabled = true;
            txtHora.Enabled = true;
            
        }

        private void btnBuscarBecario_Click(object sender, EventArgs e)
        {
            BuscarBecarioABTXB frmABTXB = new BuscarBecarioABTXB();
            if (frmABTXB.ShowDialog() == DialogResult.OK)
            {
                al = (Becado)frmABTXB.PersonaSeleccionada;
                int cod = al.Id_becado;
                txtIdBecOculto.Text = al.Id_becado.ToString();
                txtCodBecGC.Text = al.CodigoPUCP.ToString();
                txtBBecarioGC.Text = al.Nombres + " " + al.Apellidos;
            }
        }

        private void btnBuscarTutor_Click(object sender, EventArgs e)
        {
            frmBuscarTutor frmBT = new frmBuscarTutor();
            if (frmBT.ShowDialog() == DialogResult.OK)
            {
                tut = (Tutor)frmBT.PersonaSeleccionada;
                int cod = tut.IdTutor;
                txtIdtutOculto.Text = tut.IdTutor.ToString();
                txtCodTutorGC.Text = tut.CodigoPUCP.ToString();
                txtBTutorGC.Text = tut.Nombres + " " + tut.Apellidos;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DTPSelDiaGC.Enabled = true;
            BBuscarCitaGC.Enabled = true;
            txtBBecarioGC.Text = "";
            //txtBHoraGC.Text = "";
            txtBObsGC.Text = "";
            txtBTutorGC.Text = "";
            txtCodBecGC.Text = "";
            txtCodTutorGC.Text = "";
            txtIdtutOculto.Text = "";
            txtIdBecOculto.Text = "";
            txtIdCitaOculto.Text = "";
            txtBLugarGC.Text = "";
            txtHora.Text = "";

             //txtBHoraGC.Enabled = false;
            txtCodTutorGC.Enabled = false;
            txtBTutorGC.Enabled = false;
            txtCodBecGC.Enabled = false;
            txtBBecarioGC.Enabled = false;
            txtBObsGC.Enabled = false;
            txtIdtutOculto.Enabled = false;
            txtIdBecOculto.Enabled = false;
            btnBuscarTutor.Enabled = false;
            btnBuscarBecario.Enabled = false;
            txtIdCitaOculto.Enabled = false;
            txtBLugarGC.Enabled = false;
            txtHora.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string lugar = txtBLugarGC.Text.ToString();
            string obs = txtBObsGC.Text.ToString();
            //string fecha = txtBFechaGC.Text.ToString();
            int idTut = Convert.ToInt32(txtIdtutOculto.Text.ToString());
            int idBec = Convert.ToInt32(txtIdBecOculto.Text.ToString());
            DTPSelDiaGC.Enabled = false;
            Cita cita = new Cita();
            cita.Fecha = DateTime.Parse(DTPSelDiaGC.Text);
            cita.Lugar = txtBLugarGC.Text;
            cita.Observacion = txtBObsGC.Text;
            cita.Hora = txtHora.Text;
            logicaNegocioCita.agregarCita(cita, idBec, idTut);
            //falta modificar AD y workbench para que admita string hora
        }

        private void DGVCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CitaSelect = (Cita) DGVCitas.CurrentRow.DataBoundItem;
            txtIdBecOculto.Text = CitaSelect.IdBecado.ToString();
            string idBec= txtIdBecOculto.Text;
            Becado bec = new Becado();
            bec = logicaNegocioBecado.buscarBecado(idBec);
            txtBBecarioGC.Text = bec.Nombres + " " + bec.Apellidos;
            txtCodBecGC.Text = bec.CodigoPUCP.ToString();

            txtIdtutOculto.Text = CitaSelect.IdTutor.ToString();
            string idTut = txtIdtutOculto.Text;
            Tutor tut = new Tutor();
            tut = logicaNegocioTutor.buscarTutor(idTut);
            txtBTutorGC.Text = tut.Nombres + " " + tut.Apellidos;
            txtCodTutorGC.Text = tut.CodigoPUCP.ToString();

            txtBObsGC.Text = CitaSelect.Observacion;
            txtBLugarGC.Text = CitaSelect.Lugar;
            txtIdCitaOculto.Text = CitaSelect.IdCita.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (DGVCitas.SelectedRows.Count == 1)
            {
                CitaSelect = (Cita)DGVCitas.CurrentRow.DataBoundItem;
                txtIdBecOculto.Text = CitaSelect.IdBecado.ToString();
                string idBec = txtIdBecOculto.Text;
                Becado bec = new Becado();
                bec = logicaNegocioBecado.buscarBecado(idBec);
                txtBBecarioGC.Text = bec.Nombres + " " + bec.Apellidos;
                txtCodBecGC.Text = bec.CodigoPUCP.ToString();

                txtIdtutOculto.Text = CitaSelect.IdTutor.ToString();
                string idTut = txtIdtutOculto.Text;
                Tutor tut = new Tutor();
                tut = logicaNegocioTutor.buscarTutor(idTut);
                txtBTutorGC.Text = tut.Nombres + " " + tut.Apellidos;
                txtCodTutorGC.Text = tut.CodigoPUCP.ToString();

                txtBObsGC.Text = CitaSelect.Observacion;

                btnBuscarBecario.Enabled = true;
                btnBuscarTutor.Enabled = true;
                txtIdCitaOculto.Enabled = true;
                txtBLugarGC.Enabled = true;
                txtHora.Enabled = true;
                txtBObsGC.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cita", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}

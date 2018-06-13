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
        
        private void BBuscarCitaGC_Click(object sender, EventArgs e)
        {
            txtBObsGC.Enabled = false;
            txtBObsGC.Enabled = false;

            BindingList<Cita> lista = new BindingList<Cita>();
            lista = logicaNegocioCita.buscarcita(DateTime.Parse(DTPSelDiaGC.Text));
            DGVCitas.DataSource = lista; 
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
            BBuscarCita2GC.Enabled = false;
            btnBuscarTutor2.Enabled = false;
            DTPSelDiaGC.Enabled = true;
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
            BBuscarCita2GC.Enabled = true;
            btnBuscarTutor2.Enabled = true;

            txtBBecarioGC.Text = "";
            txtBObsGC.Text = "";
            txtBTutorGC.Text = "";
            txtCodBecGC.Text = "";
            txtCodTutorGC.Text = "";
            txtIdtutOculto.Text = "";
            txtIdBecOculto.Text = "";
            txtIdCitaOculto.Text = "";
            txtBLugarGC.Text = "";
            txtHora.Text = "";
            txtBTutorGC2.Text = "";
            txtCodTutor2.Text = "";
            txtIdtutOculto2.Text = "";

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
            int i = 0;
            bool result = int.TryParse(txtIdCitaOculto.Text,out i);
            if(result == false)
            {
                cita.IdCita = 0;
            }
            else
            {
                cita.IdCita = Convert.ToInt32(txtIdCitaOculto.Text);
            }
            
            logicaNegocioCita.agregarCita(cita, idBec, idTut);
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
            txtHora.Text = CitaSelect.Hora;

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

                DTPSelDiaGC.Enabled = false;
                btnBuscarBecario.Enabled = true;
                btnBuscarTutor.Enabled = true;
                BBuscarCitaGC.Enabled = false;
                BBuscarCita2GC.Enabled = false;
                btnBuscarTutor2.Enabled = false;
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

        private void btnBuscarTutor2_Click(object sender, EventArgs e)
        {
            frmBuscarTutor frmBT = new frmBuscarTutor();
            if (frmBT.ShowDialog() == DialogResult.OK)
            {
                tut = (Tutor)frmBT.PersonaSeleccionada;
                int cod = tut.IdTutor;
                txtIdtutOculto2.Text = tut.IdTutor.ToString();
                txtCodTutor2.Text = tut.CodigoPUCP.ToString();
                txtBTutorGC2.Text = tut.Nombres + " " + tut.Apellidos;
            }
        }
    }
}

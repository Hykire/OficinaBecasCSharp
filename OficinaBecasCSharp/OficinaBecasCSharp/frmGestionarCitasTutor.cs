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
        private AlumnoBL logicaNegocioBecado;
        private CitaBL logicaNegocioCita;
        private TutorBL logicaNegocioTutor;
        private Becado al;
        private Tutor tut;
        public frmGestionarCitasTutor()
        {
            InitializeComponent();
            logicaNegocioBecado = new AlumnoBL();
            logicaNegocioCita = new CitaBL();
            logicaNegocioTutor = new TutorBL();

            //panel citas
            txtBFechaGC.Enabled = false;
            //txtBHoraGC.Enabled = false;
            txtCodTutorGC.Enabled = false;
            txtBTutorGC.Enabled = false;
            txtCodBecGC.Enabled = false;
            txtBBecarioGC.Enabled = false;
            txtBLugarGC.Enabled = false;
            txtBObsGC.Enabled = false;
            txtidCitaOculto.Enabled = false;
            txtIdtutOculto.Enabled = false;
            txtIdBecOculto.Enabled = false;
            btnBuscarTutor.Enabled = false;
            btnBuscarBecario.Enabled = false;
        }
        private void BAgregarCitaGC_Click(object sender, EventArgs e)
        {
            AgregarCita frmAgergar = new AgregarCita();
            frmAgergar.ShowDialog();
        }

        private void BEliminarCitaGC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBFechaGC.Text))
            {
                MessageBox.Show("Debe seleccionar una cita", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("¿Desea eliminar la cita seleccionada?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
            txtBLugarGC.Enabled = false;
            txtBObsGC.Enabled = false;

            BindingList<Cita> lista = new BindingList<Cita>();
           // MessageBox.Show(DTPSelDiaGC.Text);
            lista = logicaNegocioCita.buscarcita(DTPSelDiaGC.Text.ToString());
           foreach(Cita c in lista)
            {
                txtBFechaGC.Text = c.Fecha.ToString();
                txtBLugarGC.Text = c.Lugar;
                txtBObsGC.Text = c.Observacion;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBFechaGC.Text))
            {
                MessageBox.Show("Debe seleccionar una cita", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("¿Desea eliminar la cita seleccionada?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtBBecarioGC.Text = "";
            txtBFechaGC.Text = "";
            //txtBHoraGC.Text = "";
            txtBLugarGC.Text = "";
            txtBObsGC.Text = "";
            txtBTutorGC.Text = "";
            txtCodBecGC.Text = "";
            txtCodTutorGC.Text = "";
            txtidCitaOculto.Text = "";
            txtIdtutOculto.Text = "";
            txtIdBecOculto.Text = "";

            DTPSelDiaGC.Enabled = false;
            BBuscarCitaGC.Enabled = false;
            DTPSelDiaGC.Enabled = true;
            txtBFechaGC.Enabled = true;
            //txtBHoraGC.Enabled = true;
            txtBLugarGC.Enabled = true;
            txtBObsGC.Enabled = true;

            btnBuscarTutor.Enabled = true;
            btnBuscarBecario.Enabled = true;

            
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
            txtBFechaGC.Text = "";
            //txtBHoraGC.Text = "";
            txtBLugarGC.Text = "";
            txtBObsGC.Text = "";
            txtBTutorGC.Text = "";
            txtCodBecGC.Text = "";
            txtCodTutorGC.Text = "";
            txtidCitaOculto.Text = "";
            txtIdtutOculto.Text = "";
            txtIdBecOculto.Text = "";

            txtBFechaGC.Enabled = false;
            //txtBHoraGC.Enabled = false;
            txtCodTutorGC.Enabled = false;
            txtBTutorGC.Enabled = false;
            txtCodBecGC.Enabled = false;
            txtBBecarioGC.Enabled = false;
            txtBLugarGC.Enabled = false;
            txtBObsGC.Enabled = false;
            txtidCitaOculto.Enabled = false;
            txtIdtutOculto.Enabled = false;
            txtIdBecOculto.Enabled = false;
            btnBuscarTutor.Enabled = false;
            btnBuscarBecario.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string lugar = txtBLugarGC.Text.ToString();
            string obs = txtBObsGC.Text.ToString();
            string fecha = txtBFechaGC.Text.ToString();
            int idTut = Convert.ToInt32(txtIdtutOculto.Text.ToString());
            int idBec = Convert.ToInt32(txtIdBecOculto.Text.ToString());
            DTPSelDiaGC.Enabled = false;
            Cita cita = new Cita();
            cita.Fecha = DateTime.Parse(DTPSelDiaGC.Text);
            cita.Lugar = txtBLugarGC.Text;
            cita.Observacion = txtBObsGC.Text;

            logicaNegocioCita.agregarCita(cita, idBec, idTut);
           
        }
    }
}

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
    public partial class frmBuscarAlumno : Form
    {
        private AlumnoBL logicaNegoAlumno;
        private Alumno _alumnoSeleccionado;

        public frmBuscarAlumno()
        {
            logicaNegoAlumno = new AlumnoBL();
            _alumnoSeleccionado = new Alumno();

            InitializeComponent();
            dvg_alumnos.AutoGenerateColumns = false;
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            _alumnoSeleccionado = ((Alumno) dvg_alumnos.CurrentRow.DataBoundItem);
            this.DialogResult = DialogResult.OK;
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            string codigoB = tbox_codigo.Text;
            string nombreB = tbox_nombres.Text;
            string apellidoB = tbox_apellidos.Text;

            dvg_alumnos.DataSource = logicaNegoAlumno.BuscarAlumno(codigoB, nombreB, apellidoB);
        }

        public Alumno AlumnoSeleccionado { get => _alumnoSeleccionado; set => _alumnoSeleccionado = value; }
    }
}

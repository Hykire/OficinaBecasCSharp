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
    public partial class frmBuscarBecario_F : Form
    {
        private BecadoBL logicaNegoAlumno;
        private Becado _alumnoSeleccionado;

        public frmBuscarBecario_F()
        {
            InitializeComponent();

            logicaNegoAlumno = new BecadoBL();
            _alumnoSeleccionado = new Becado();
            dvg_alumnos.AllowUserToAddRows = false; //quitar la ultima fila
            dvg_alumnos.AutoGenerateColumns = false;
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            _alumnoSeleccionado = ((Becado) dvg_alumnos.CurrentRow.DataBoundItem);
            this.DialogResult = DialogResult.OK;
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            string codigoB = tbox_codigo.Text;
            string nombreB = tbox_nombres.Text;
            string apellidoB = tbox_apellidos.Text;

            dvg_alumnos.DataSource = logicaNegoAlumno.buscarAlumno(codigoB, nombreB, apellidoB);
        }

        public Becado AlumnoSeleccionado { get => _alumnoSeleccionado; set => _alumnoSeleccionado = value; }
    }
}

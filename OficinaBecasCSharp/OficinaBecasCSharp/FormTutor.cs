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
    public partial class FormTutor : Form
    {
        public FormTutor()
        {
            InitializeComponent();
        }


        private void boton_buscarB_Click(object sender, EventArgs e)
        {
            BuscarBecarioT buscar_b = new BuscarBecarioT();
            if (buscar_b.ShowDialog() == DialogResult.OK) { }
        }

        private void boton_agregarC_Click(object sender, EventArgs e)
        {
            AgregarCita agre_c = new AgregarCita();
            if (agre_c.ShowDialog() == DialogResult.OK) { }
        }
    }
}

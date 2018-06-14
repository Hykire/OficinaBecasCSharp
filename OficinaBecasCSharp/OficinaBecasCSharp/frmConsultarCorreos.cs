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
    public partial class frmConsultarCorreos : Form
    {
        private BecadoBL becadoBL;
        private BindingList<Becado> lstBecados;
        private BindingList<Becado> lstFiltos;
        private Becado bec;
        public frmConsultarCorreos()
        {
            InitializeComponent();
            becadoBL = new BecadoBL();
            dgvConsultarEmails.AutoGenerateColumns = false;
            dgvConsultarEmails.DataSource = lstBecados;
            lstFiltos = new BindingList<Becado>();
            bec = new Becado();
            bec.NombreEspecialidad = "";
            bec.Sexo = '\0';
            cbSexo.Items.Add(bec);

            cbEspecialidad.Items.Add(bec);
            btnDescargarEmails.Visible = false;
        }

        private void btnBuscarCorreos_Click(object sender, EventArgs e) {
            if(txtCicloSolicitado.Text == "") {
                MessageBox.Show("Debe insertar un ciclo a buscar", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else {
                lstBecados = new BindingList<Becado>();
                lstBecados = becadoBL.listarBecadosPorCiclo(txtCicloSolicitado.Text);
                
                dgvConsultarEmails.DataSource = lstBecados;
                cbEspecialidad.ValueMember = "NombreEspecialidad";
                
                foreach(var i in lstBecados) {
                    if (cbEspecialidad.FindString(i.NombreEspecialidad) == -1)
                        cbEspecialidad.Items.Add(i);
                    else
                        continue;
                    
                }
                cbSexo.ValueMember = "Sexo";
                
                foreach (var i in lstBecados) {
                    if (cbSexo.FindString(i.Sexo.ToString()) == -1)
                        cbSexo.Items.Add(i);
                    else
                        continue;
                }
            }
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e) {
            //Becado becado = (Becado)cbSexo.SelectedItem;
            //BindingList<Becado> lstAux = new BindingList<Becado>();
            //if(becado.Sexo == '\0') {
            //    dgvConsultarEmails.DataSource = lstBecados;
                
            //}
            //else {
            //    foreach(var i in lstFiltos) {
            //        if(i.Sexo.ToString() == becado.Sexo.ToString()) {
            //            lstAux.Add(i);
            //        }
            //    }
            //    dgvConsultarEmails.DataSource = lstAux;
            //    lstFiltos = lstAux;
            //}
        }

        private void cbEspecialidad_SelectedIndexChanged(object sender, EventArgs e) {
            //Becado becado = (Becado)cbEspecialidad.SelectedItem;
            //BindingList<Becado> lstAux = new BindingList<Becado>();
            //if (becado.NombreEspecialidad == "") {
            //    dgvConsultarEmails.DataSource = lstBecados;
                
            //}
            //else {
            //    foreach (var i in lstFiltos) {
            //        if (i.NombreEspecialidad == becado.NombreEspecialidad) {
            //            lstAux.Add(i);
            //        }
            //    }
            //    dgvConsultarEmails.DataSource = lstAux;
            //    lstFiltos = lstAux;
            //}
        }

        private void btnFiltrar_Click(object sender, EventArgs e) {
            Becado becado1 = (Becado)cbSexo.SelectedItem;
            Becado becado2 = (Becado)cbEspecialidad.SelectedItem;
            if(becado1 == null) {
                becado1 = new Becado();
            }
            if(becado2 == null) {
                becado2 = new Becado();
            }

            lstFiltos = new BindingList<Becado>();

            if(becado1.Sexo == '\0' && becado2.NombreEspecialidad == "") {
                dgvConsultarEmails.DataSource = lstBecados;
            }
            else if(becado1.Sexo == '\0' && becado2.NombreEspecialidad != "") {
                foreach (var i in lstBecados) {
                    if (i.NombreEspecialidad == becado2.NombreEspecialidad) {
                        lstFiltos.Add(i);
                    }
                }
                
                dgvConsultarEmails.DataSource = lstFiltos;
            }
            else if (becado1.Sexo != '\0' && becado2.NombreEspecialidad == "") {
                foreach (var i in lstBecados) {
                    if (i.Sexo.ToString() == becado1.Sexo.ToString()) {
                        lstFiltos.Add(i);
                    }
                }
                
                dgvConsultarEmails.DataSource = lstFiltos;
            }
            else {
                BindingList<Becado> lstAux = new BindingList<Becado>();
                foreach (var i in lstBecados) {
                    if (i.NombreEspecialidad == becado2.NombreEspecialidad) {
                        lstFiltos.Add(i);
                    }
                }
                foreach(var i in lstFiltos) {
                    if (i.Sexo.ToString() == becado1.Sexo.ToString()) {
                        lstAux.Add(i);
                    }
                }
                lstFiltos = lstAux;
                dgvConsultarEmails.DataSource = lstFiltos;
            }
        }
    }
}

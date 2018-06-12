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
    public partial class frmGestionarBecas : Form
    {
        private int flag_elementoNuevo = 0;
        private int flag_elementoEditar = 0;
        private BecaBL logicanegocioBeca;

        public frmGestionarBecas()
        {
            InitializeComponent();
            logicanegocioBeca = new BecaBL();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Beca b = new Beca();
            if (flag_elementoEditar == 1) { b.Id_beca = Int32.Parse(tbox_idBeca.Text); }
            b.Nombre_beca = tbox_nombre.Text;
            b.Descripcion = rtbox_descripcion.Text;
            b.Estado = cbox_estado.Text;
            b.Financiador = tbox_financiador.Text;

            //la parte pesada :'v
            BindingList<int> id_esp = new BindingList<int>();
            if (check_1.Checked == true) id_esp.Add(1);   if (check_2.Checked == true) id_esp.Add(2);
            if (check_3.Checked == true) id_esp.Add(3);   if (check_4.Checked == true) id_esp.Add(4);
            if (check_5.Checked == true) id_esp.Add(5);   if (check_6.Checked == true) id_esp.Add(6);
            if (check_7.Checked == true) id_esp.Add(7);   if (check_8.Checked == true) id_esp.Add(8);
            if (check_9.Checked == true) id_esp.Add(9);   if (check_10.Checked == true) id_esp.Add(10);
            if (check_11.Checked == true) id_esp.Add(11); if (check_12.Checked == true) id_esp.Add(12);
            if (check_13.Checked == true) id_esp.Add(13); if (check_14.Checked == true) id_esp.Add(14);
            if (check_15.Checked == true) id_esp.Add(15); if (check_16.Checked == true) id_esp.Add(16);
            if (check_17.Checked == true) id_esp.Add(17); if (check_18.Checked == true) id_esp.Add(18);
            if (check_19.Checked == true) id_esp.Add(19); if (check_20.Checked == true) id_esp.Add(20);
            if (check_21.Checked == true) id_esp.Add(21); if (check_22.Checked == true) id_esp.Add(22);
            if (check_23.Checked == true) id_esp.Add(23); if (check_24.Checked == true) id_esp.Add(24);
            if (check_25.Checked == true) id_esp.Add(25); if (check_26.Checked == true) id_esp.Add(26);
            if (check_27.Checked == true) id_esp.Add(27); if (check_28.Checked == true) id_esp.Add(28);
            if (check_29.Checked == true) id_esp.Add(29); if (check_30.Checked == true) id_esp.Add(30);
            if (check_31.Checked == true) id_esp.Add(31); if (check_32.Checked == true) id_esp.Add(32);
            if (check_33.Checked == true) id_esp.Add(33); if (check_34.Checked == true) id_esp.Add(34);
            if (check_35.Checked == true) id_esp.Add(35); if (check_36.Checked == true) id_esp.Add(36);
            if (check_37.Checked == true) id_esp.Add(37); if (check_38.Checked == true) id_esp.Add(38);
            if (check_39.Checked == true) id_esp.Add(39); if (check_40.Checked == true) id_esp.Add(40);
            if (check_41.Checked == true) id_esp.Add(41); if (check_42.Checked == true) id_esp.Add(42);
            if (check_43.Checked == true) id_esp.Add(43); if (check_44.Checked == true) id_esp.Add(44);
            if (check_45.Checked == true) id_esp.Add(45); if (check_46.Checked == true) id_esp.Add(46);
            if (check_47.Checked == true) id_esp.Add(47); if (check_48.Checked == true) id_esp.Add(48);

            if(flag_elementoNuevo == 1)
            {
                flag_elementoNuevo = 0;
                logicanegocioBeca.registrar_Beca(b, id_esp);
                MessageBox.Show("Se ha registrado un nuevo alumno con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(flag_elementoEditar == 1)
            {
                flag_elementoEditar = 0;
                logicanegocioBeca.modificar_Beca(b, id_esp);
                MessageBox.Show("Se ha actualizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            flag_elementoNuevo = 1;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            flag_elementoEditar = 1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarBeca_F formBAlumno = new frmBuscarBeca_F();
            if (formBAlumno.ShowDialog() == DialogResult.OK)
            {
                tbox_idBeca.Text = formBAlumno.BecaSeleccionada.Id_beca.ToString();
                tbox_nombre.Text = formBAlumno.BecaSeleccionada.Nombre_beca;
                tbox_financiador.Text = formBAlumno.BecaSeleccionada.Financiador;
                rtbox_descripcion.Text = formBAlumno.BecaSeleccionada.Descripcion;
                cbox_estado.Text = formBAlumno.BecaSeleccionada.Estado;

                //falta rellenar los check_box...
                BindingList<int> lista_esp = logicanegocioBeca.obtener_especialidadesBeca(formBAlumno.BecaSeleccionada);
                foreach(int i in lista_esp)
                {
                    switch (i)
                    {
                        case 1: check_1.Checked = true; break;
                        case 2: check_2.Checked = true; break;
                        case 3: check_3.Checked = true; break;
                        case 4: check_4.Checked = true; break;
                        case 5: check_5.Checked = true; break;
                        case 6: check_6.Checked = true; break;
                        case 7: check_7.Checked = true; break;
                        case 8: check_8.Checked = true; break;
                        case 9: check_9.Checked = true; break;
                        case 10: check_10.Checked = true; break;
                        case 11: check_11.Checked = true; break;
                        case 12: check_12.Checked = true; break;
                        case 13: check_13.Checked = true; break;
                        case 14: check_14.Checked = true; break;
                        case 15: check_15.Checked = true; break;
                        case 16: check_16.Checked = true; break;
                        case 17: check_17.Checked = true; break;
                        case 18: check_18.Checked = true; break;
                        case 19: check_19.Checked = true; break;
                        case 20: check_20.Checked = true; break;
                        case 21: check_21.Checked = true; break;
                        case 22: check_22.Checked = true; break;
                        case 23: check_23.Checked = true; break;
                        case 24: check_24.Checked = true; break;
                        case 25: check_25.Checked = true; break;
                        case 26: check_26.Checked = true; break;
                        case 27: check_27.Checked = true; break;
                        case 28: check_28.Checked = true; break;
                        case 29: check_29.Checked = true; break;
                        case 30: check_30.Checked = true; break;
                        case 31: check_31.Checked = true; break;
                        case 32: check_32.Checked = true; break;
                        case 33: check_33.Checked = true; break;
                        case 34: check_34.Checked = true; break;
                        case 35: check_35.Checked = true; break;
                        case 36: check_36.Checked = true; break;
                        case 37: check_37.Checked = true; break;
                        case 38: check_38.Checked = true; break;
                        case 39: check_39.Checked = true; break;
                        case 40: check_40.Checked = true; break;
                        case 41: check_41.Checked = true; break;
                        case 42: check_42.Checked = true; break;
                        case 43: check_43.Checked = true; break;
                        case 44: check_44.Checked = true; break;
                        case 45: check_45.Checked = true; break;
                        case 46: check_46.Checked = true; break;
                        case 47: check_47.Checked = true; break;
                        case 48: check_48.Checked = true; break;
                    }
                }//fin del switch
            }
        }
    }
}

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

        public enum Estado { Habilitado, Deshabilitado }
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Deshabilitado:
                    cbox_estado.Enabled = false;
                    tbox_nombre.Enabled = false;
                    tbox_financiador.Enabled = false;
                    rtbox_descripcion.Enabled = false;

                    check_1.Enabled = false; check_2.Enabled = false;
                    check_3.Enabled = false; check_4.Enabled = false;
                    check_5.Enabled = false; check_6.Enabled = false;
                    check_7.Enabled = false; check_8.Enabled = false;
                    check_9.Enabled = false; check_10.Enabled = false;
                    check_11.Enabled = false; check_12.Enabled = false;
                    check_13.Enabled = false; check_14.Enabled = false;
                    check_15.Enabled = false; check_16.Enabled = false;
                    check_17.Enabled = false; check_18.Enabled = false;
                    check_19.Enabled = false; check_20.Enabled = false;
                    check_21.Enabled = false; check_22.Enabled = false;
                    check_23.Enabled = false; check_24.Enabled = false;
                    check_25.Enabled = false; check_26.Enabled = false;
                    check_27.Enabled = false; check_28.Enabled = false;
                    check_29.Enabled = false; check_30.Enabled = false;
                    check_31.Enabled = false; check_32.Enabled = false;
                    check_33.Enabled = false; check_34.Enabled = false;
                    check_35.Enabled = false; check_36.Enabled = false;
                    check_37.Enabled = false; check_38.Enabled = false;
                    check_39.Enabled = false; check_40.Enabled = false;
                    check_41.Enabled = false; check_42.Enabled = false;
                    check_43.Enabled = false; check_44.Enabled = false;
                    check_45.Enabled = false; check_46.Enabled = false;
                    check_47.Enabled = false; check_48.Enabled = false;
                    break;
                case Estado.Habilitado:
                    cbox_estado.Enabled = true;
                    tbox_nombre.Enabled = true;
                    tbox_financiador.Enabled = true;
                    rtbox_descripcion.Enabled = true;

                    check_1.Enabled = true; check_2.Enabled = true;
                    check_3.Enabled = true; check_4.Enabled = true;
                    check_5.Enabled = true; check_6.Enabled = true;
                    check_7.Enabled = true; check_8.Enabled = true;
                    check_9.Enabled = true; check_10.Enabled = true;
                    check_11.Enabled = true; check_12.Enabled = true;
                    check_13.Enabled = true; check_14.Enabled = true;
                    check_15.Enabled = true; check_16.Enabled = true;
                    check_17.Enabled = true; check_18.Enabled = true;
                    check_19.Enabled = true; check_20.Enabled = true;
                    check_21.Enabled = true; check_22.Enabled = true;
                    check_23.Enabled = true; check_24.Enabled = true;
                    check_25.Enabled = true; check_26.Enabled = true;
                    check_27.Enabled = true; check_28.Enabled = true;
                    check_29.Enabled = true; check_30.Enabled = true;
                    check_31.Enabled = true; check_32.Enabled = true;
                    check_33.Enabled = true; check_34.Enabled = true;
                    check_35.Enabled = true; check_36.Enabled = true;
                    check_37.Enabled = true; check_38.Enabled = true;
                    check_39.Enabled = true; check_40.Enabled = true;
                    check_41.Enabled = true; check_42.Enabled = true;
                    check_43.Enabled = true; check_44.Enabled = true;
                    check_45.Enabled = true; check_46.Enabled = true;
                    check_47.Enabled = true; check_48.Enabled = true;
                    break;
            }
        }
        public void limpiarComponentes()
        {
            cbox_estado.Text = "";
            tbox_nombre.Text = "";
            tbox_financiador.Text = "";
            rtbox_descripcion.Text = "";

            check_1.Checked = false; check_2.Checked = false;
            check_3.Checked = false; check_4.Checked = false;
            check_5.Checked = false; check_6.Checked = false;
            check_7.Checked = false; check_8.Checked = false;
            check_9.Checked = false; check_10.Checked = false;
            check_11.Checked = false; check_12.Checked = false;
            check_13.Checked = false; check_14.Checked = false;
            check_15.Checked = false; check_16.Checked = false;
            check_17.Checked = false; check_18.Checked = false;
            check_19.Checked = false; check_20.Checked = false;
            check_21.Checked = false; check_22.Checked = false;
            check_23.Checked = false; check_24.Checked = false;
            check_25.Checked = false; check_26.Checked = false;
            check_27.Checked = false; check_28.Checked = false;
            check_29.Checked = false; check_30.Checked = false;
            check_31.Checked = false; check_32.Checked = false;
            check_33.Checked = false; check_34.Checked = false;
            check_35.Checked = false; check_36.Checked = false;
            check_37.Checked = false; check_38.Checked = false;
            check_39.Checked = false; check_40.Checked = false;
            check_41.Checked = false; check_42.Checked = false;
            check_43.Checked = false; check_44.Checked = false;
            check_45.Checked = false; check_46.Checked = false;
            check_47.Checked = false; check_48.Checked = false;
        }

        public frmGestionarBecas()
        {
            InitializeComponent();

            logicanegocioBeca = new BecaBL();
            estadoComponentes(Estado.Deshabilitado);
            btnNuevo.Enabled = true; btnBuscar.Enabled = true; btnCancelar.Enabled = true;
            btnGuardar.Enabled = false; btnEditar.Enabled = false;
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

            estadoComponentes(Estado.Deshabilitado);
            if (flag_elementoNuevo == 1)
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
            btnGuardar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //habilita flag
            flag_elementoNuevo = 1;

            //habilitamos botones
            btnCancelar.Enabled = true; btnGuardar.Enabled = true;
            btnNuevo.Enabled = false; btnEditar.Enabled = false; btnBuscar.Enabled = false;

            //se habilitan los campos
            estadoComponentes(Estado.Habilitado);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //habilita flag
            flag_elementoEditar = 1;

            //habilitamos botones
            btnCancelar.Enabled = true; btnGuardar.Enabled = true;
            btnNuevo.Enabled = false; btnEditar.Enabled = false; btnBuscar.Enabled = false;

            //se habilitan los campos
            estadoComponentes(Estado.Habilitado);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //habilitamos botones
            btnEditar.Enabled = true;

            frmBuscarBeca_F formBAlumno = new frmBuscarBeca_F();
            if (formBAlumno.ShowDialog() == DialogResult.OK)
            {
                tbox_idBeca.Text = formBAlumno.BecaSeleccionada.Id_beca.ToString();
                tbox_nombre.Text = formBAlumno.BecaSeleccionada.Nombre_beca;
                tbox_financiador.Text = formBAlumno.BecaSeleccionada.Financiador;
                rtbox_descripcion.Text = formBAlumno.BecaSeleccionada.Descripcion;
                cbox_estado.Text = formBAlumno.BecaSeleccionada.Estado;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //habilitamos botones
            btnNuevo.Enabled = true; btnCancelar.Enabled = true; btnBuscar.Enabled = true;
            btnGuardar.Enabled = false; btnEditar.Enabled = false;

            //se deshabilita los campos
            estadoComponentes(Estado.Deshabilitado);

            //se limpia
            limpiarComponentes();
            flag_elementoEditar = 0;
            flag_elementoNuevo = 0;
        }
    }
}

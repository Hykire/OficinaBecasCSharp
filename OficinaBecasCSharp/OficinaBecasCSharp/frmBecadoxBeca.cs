using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmBecadoxBeca : Form
    {
        private int flag_elementoNuevo = 0;
        private int flag_elementoEditar = 0;
        private Becado_x_BecaBL logicaNegoAB;

        public enum Estado
        {
            Habilitado, Deshabilitado
        }
        public frmBecadoxBeca()
        {
            InitializeComponent();

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = true;
            cbox_ciclo.Visible = false;
            cbox_ciclo_nuevo1.Visible = true;
            cbox_ciclo_nuevo2.Visible = true;

            //btn_historiaacademica.Enabled = false;

            estadoComponentes(Estado.Deshabilitado);
            limpiarComponentes();
            logicaNegoAB = new Becado_x_BecaBL();

            //cargamos el combo box de beca
            BecaBL logicaNegoBeca = new BecaBL();
            cbox_beca.DataSource = logicaNegoBeca.listar_Beca();
            cbox_beca.Sorted = false;
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Deshabilitado:
                    tbox_apellidos.Enabled = false;
                    tbox_codigo.Enabled = false;
                    tbox_cubiertos.Enabled = false;
                    cbox_escalapago1.Enabled = false;
                    cbox_escalapago2.Enabled = false;
                    tbox_ncarta.Enabled = false;
                    tbox_nombres.Enabled = false;
                    tbox_nregularC.Enabled = false;
                    tbox_nregularesRC.Enabled = false;
                    tbox_nveranoC.Enabled = false;
                    tbox_restantes.Enabled = false;
                    tbox_tiposansion.Enabled = false;
                    tbox_utilizados.Enabled = false;

                    cbox_adelantobono.Enabled = false;
                    cbox_ampliacion.Enabled = false;
                    cbox_beca.Enabled = false;
                    cbox_bonoalojamiento.Enabled = false;
                    cbox_bonomateriales.Enabled = false;
                    cbox_ciclo.Enabled = false;
                    cbox_renovacion.Enabled = false;
                    cbox_suspencion.Enabled = false;
                    cbox_tipointercambio.Enabled = false;
                    cbox_intercambio.Enabled = false;
                    cbox_sansion.Enabled = false;
                    cbox_ciclo_nuevo1.Enabled = false;
                    cbox_ciclo_nuevo2.Enabled = false;
                    cbox_tipoescala.Enabled = false;
                    cbox_nivelcreditos.Enabled = false;
                    cbox_cicloS1.Enabled = false;
                    cbox_cicloS2.Enabled = false;

                    rtbox_respuesta.Enabled = false;

                    dt_periodointercambiofin.Enabled = false;
                    dt_periodointercambioini.Enabled = false;
                    dt_sansionfin.Enabled = false;
                    dt_sansionini.Enabled = false;

                    break;

                case Estado.Habilitado:
                    tbox_cubiertos.Enabled = true;
                    cbox_escalapago1.Enabled = true;
                    cbox_escalapago2.Enabled = true;
                    tbox_ncarta.Enabled = true;
                    tbox_nregularC.Enabled = true;
                    tbox_nregularesRC.Enabled = true;
                    tbox_nveranoC.Enabled = true;
                    tbox_restantes.Enabled = true;
                    tbox_tiposansion.Enabled = true;
                    tbox_utilizados.Enabled = true;
                    cbox_adelantobono.Enabled = true;
                    cbox_ampliacion.Enabled = true;
                    cbox_beca.Enabled = true;
                    cbox_bonoalojamiento.Enabled = true;
                    cbox_bonomateriales.Enabled = true;
                    cbox_ciclo.Enabled = true;
                    cbox_renovacion.Enabled = true;
                    cbox_suspencion.Enabled = true;
                    cbox_tipointercambio.Enabled = true;
                    cbox_intercambio.Enabled = true;
                    cbox_sansion.Enabled = true;
                    cbox_ciclo_nuevo1.Enabled = true;
                    cbox_ciclo_nuevo2.Enabled = true;
                    cbox_tipoescala.Enabled = true;
                    cbox_nivelcreditos.Enabled = true;
                    cbox_cicloS1.Enabled = true;
                    cbox_cicloS2.Enabled = true;

                    rtbox_respuesta.Enabled = true;

                    dt_periodointercambiofin.Enabled = true;
                    dt_periodointercambioini.Enabled = true;
                    dt_sansionfin.Enabled = true;
                    dt_sansionini.Enabled = true;
                    dt_periodointercambiofin.Visible = true;
                    dt_periodointercambioini.Visible = true;
                    dt_sansionfin.Visible = true;
                    dt_sansionini.Visible = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            tbox_cubiertos.Text = "";
            tbox_ncarta.Text = "";
            tbox_nregularC.Text = "";
            tbox_nregularesRC.Text = "";
            tbox_nveranoC.Text = "";
            tbox_restantes.Text = "";
            tbox_tiposansion.Text = "";
            tbox_utilizados.Text = "";

            cbox_adelantobono.SelectedIndex = -1;
            cbox_ampliacion.SelectedIndex = -1;
            cbox_beca.SelectedIndex = -1;
            cbox_bonoalojamiento.SelectedIndex = -1;
            cbox_bonomateriales.SelectedIndex = -1;
            cbox_ciclo.SelectedIndex = -1;
            cbox_renovacion.SelectedIndex = -1;
            cbox_tipointercambio.SelectedIndex = -1;
            cbox_sansion.SelectedIndex = -1;
            cbox_intercambio.SelectedIndex = -1;
            cbox_ciclo_nuevo1.SelectedIndex = -1;
            cbox_ciclo_nuevo2.SelectedIndex = -1;
            cbox_suspencion.SelectedIndex = -1;
            cbox_escalapago1.SelectedIndex = -1;
            cbox_escalapago2.SelectedIndex = -1;
            cbox_tipoescala.SelectedIndex = -1;
            cbox_cicloS1.SelectedIndex = -1;
            cbox_cicloS2.SelectedIndex = -1;
            cbox_nivelcreditos.Text = "";

            rtbox_respuesta.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarBecario_F formBAlumno = new frmBuscarBecario_F();
            if (formBAlumno.ShowDialog() == DialogResult.OK)
            {
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnBuscar.Enabled = false;

                cbox_ciclo.Visible = true;
                cbox_ciclo_nuevo1.Visible = false;
                cbox_ciclo_nuevo2.Visible = false;

                cbox_ciclo.Enabled = true;
                tbox_nombres.Text = formBAlumno.AlumnoSeleccionado.Nombres;
                tbox_apellidos.Text = formBAlumno.AlumnoSeleccionado.Apellidos;
                tbox_codigo.Text = formBAlumno.AlumnoSeleccionado.CodigoPUCP.ToString();
                tbox_id_becado.Text = formBAlumno.AlumnoSeleccionado.Id_becado.ToString();

                //se listará los ciclos
                BindingList<Becado_x_Beca> listaCiclo = logicaNegoAB.BuscarBecaxAlumno(formBAlumno.AlumnoSeleccionado.Id_becado);
                cbox_ciclo.DataSource = listaCiclo;
                cbox_ciclo.Sorted = false;

                //se limpia
                limpiarComponentes();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cbox_ciclo.Visible = false;
            cbox_ciclo_nuevo1.Visible = true;
            cbox_ciclo_nuevo2.Visible = true;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = false;

            estadoComponentes(Estado.Habilitado);
            limpiarComponentes();
            flag_elementoNuevo = 1;

            //se vuelve a cargar las becas por si se agregaron mas en el proceso
            //cargamos el combo box de beca
            BecaBL logicaNegoBeca = new BecaBL();
            cbox_beca.DataSource = logicaNegoBeca.listar_Beca();
            cbox_beca.Sorted = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = false;
            //btn_historiaacademica.Enabled = false;
            estadoComponentes(Estado.Deshabilitado);



            Becado_x_Beca axb = new Becado_x_Beca();

            if (flag_elementoEditar == 1)
            {
                axb.Id_becado_x_beca = Int32.Parse(tbox_id_becadoxbeca.Text);
            }
            axb.Id_becado = Int32.Parse(tbox_id_becado.Text);
            axb.Id_beca = ((Beca)cbox_beca.SelectedItem).Id_beca;
            axb.Ciclo = cbox_ciclo_nuevo1.Text + "-" + cbox_ciclo_nuevo2.Text;
            axb.Tipo_escala_pago = cbox_tipoescala.Text;
            if (cbox_tipoescala.Text == "ANTIGUA") axb.Escala_pago = Int32.Parse(cbox_escalapago1.Text);
            else if (cbox_tipoescala.Text == "ACTUAL") axb.Escala_pago = Int32.Parse(cbox_escalapago2.Text);
            axb.Nivel_creditos = Int32.Parse(cbox_nivelcreditos.Text);
            axb.Ncreditos_cubiertos = Double.Parse(tbox_cubiertos.Text, CultureInfo.InvariantCulture);
            axb.Ncreditos_utilizados = Double.Parse(tbox_utilizados.Text, CultureInfo.InvariantCulture);
            axb.Ncreditos_restantes = Double.Parse(tbox_restantes.Text, CultureInfo.InvariantCulture);
            axb.Nsemestres_regular = Int32.Parse(tbox_nregularC.Text);
            axb.Nsemestres_verano = Int32.Parse(tbox_nveranoC.Text);
            axb.Nsemestres_restantes = Int32.Parse(tbox_nregularesRC.Text);
            if (cbox_renovacion.Text == "Sí") axb.Renovacion = 1; else axb.Renovacion = 0;
            if (cbox_suspencion.Text == "Sí") axb.Suspencion = 1; else axb.Suspencion = 0;
            if (cbox_ampliacion.Text == "Sí") axb.Ampliacion = 1; else axb.Ampliacion = 0;
            axb.Ciclo_solicitado = cbox_cicloS1.Text + "-" + cbox_cicloS2.Text;
            axb.Respuesta = rtbox_respuesta.Text;
            axb.Ncarta = tbox_ncarta.Text;

            if (cbox_bonomateriales.Text == "Sí") axb.Redencion_materiales = 1; else axb.Redencion_materiales = 0;
            if (cbox_bonoalojamiento.Text == "Sí") axb.Redencion_alojamiento = 1; else axb.Redencion_alojamiento = 0;
            if (cbox_sansion.Text == "Sí") axb.Sansion = 1; else axb.Sansion = 0;
            axb.Sansion_tipo = tbox_tiposansion.Text;
            axb.Sansion_ini = DateTime.Parse(dt_sansionini.Text);
            axb.Sansion_fin = DateTime.Parse(dt_sansionfin.Text);

            if (cbox_intercambio.Text == "Sí") axb.Intercambio = 1; else axb.Intercambio = 0;
            axb.Intercambio_tipo = cbox_tipointercambio.Text;
            axb.Intercambio_ini = DateTime.Parse(dt_periodointercambioini.Text);
            axb.Intercambio_fin = DateTime.Parse(dt_sansionfin.Text);
            if (cbox_adelantobono.Text == "Sí") axb.Adelanto = 1; else axb.Adelanto = 0;

            if (flag_elementoNuevo == 1)
            {
                flag_elementoNuevo = 0;
                logicaNegoAB.RegistrarBecaxAlumno(axb);
                MessageBox.Show("Se ha registrado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (flag_elementoEditar == 1)
            {
                flag_elementoEditar = 0;
                logicaNegoAB.ActualizarBecaxAlumno(axb);
                MessageBox.Show("Se ha registrado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = false;
            //btn_historiaacademica.Enabled = true;

            cbox_ciclo_nuevo1.Visible = true;
            cbox_ciclo_nuevo2.Visible = true;
            cbox_ciclo.Visible = false;
            cbox_ciclo_nuevo1.Text = cbox_ciclo.Text.Substring(0, 4);
            cbox_ciclo_nuevo2.Text = cbox_ciclo.Text.Substring(5, 1);
            //tbox_ciclo.Visible = true;
            //tbox_ciclo.Text = cbox_ciclo.Text;
            estadoComponentes(Estado.Habilitado);
            flag_elementoEditar = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = true;

            cbox_ciclo.Visible = false;
            cbox_ciclo_nuevo1.Visible = true;
            cbox_ciclo_nuevo2.Visible = true;

            estadoComponentes(Estado.Deshabilitado);
            //se limpia
            limpiarComponentes();
            tbox_codigo.Text = "";
            tbox_nombres.Text = "";
            tbox_apellidos.Text = "";

            flag_elementoEditar = 0;
            flag_elementoNuevo = 0;
        }

        private void cbox_ciclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_ciclo.SelectedIndex != -1)
            {
                //
                //cargamos el combo box de beca
                BecaBL logicaNegoBeca = new BecaBL();
                BindingList<Beca> listaB = logicaNegoBeca.listar_Beca();
                foreach (Beca b in listaB)
                {
                    if (((Becado_x_Beca)cbox_ciclo.SelectedItem).Id_beca == b.Id_beca)
                    {
                        cbox_beca.Text = b.Nombre_beca;
                    }
                }
                //
                if (((Becado_x_Beca)cbox_ciclo.SelectedItem).Tipo_escala_pago == "ANTIGUA")
                {
                    cbox_tipoescala.Text = "ANTIGUA";
                    cbox_escalapago1.Visible = true;
                    cbox_escalapago2.Visible = false;
                    cbox_escalapago1.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Escala_pago.ToString();
                }
                else if (((Becado_x_Beca)cbox_ciclo.SelectedItem).Tipo_escala_pago == "ACTUAL")
                {
                    cbox_tipoescala.Text = "ACTUAL";
                    cbox_escalapago1.Visible = false;
                    cbox_escalapago2.Visible = true;
                    cbox_escalapago2.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Escala_pago.ToString();
                }
                cbox_nivelcreditos.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Nivel_creditos.ToString();
                tbox_cubiertos.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Ncreditos_cubiertos.ToString(CultureInfo.InvariantCulture);
                tbox_restantes.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Ncreditos_restantes.ToString(CultureInfo.InvariantCulture);
                tbox_utilizados.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Ncreditos_utilizados.ToString(CultureInfo.InvariantCulture);
                tbox_nregularC.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Nsemestres_regular.ToString();
                tbox_nveranoC.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Nsemestres_verano.ToString();
                tbox_nregularesRC.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Nsemestres_restantes.ToString();

                if (((Becado_x_Beca)cbox_ciclo.SelectedItem).Renovacion == 1) cbox_renovacion.Text = "Sí"; else cbox_renovacion.Text = "No";
                if (((Becado_x_Beca)cbox_ciclo.SelectedItem).Ampliacion == 1) cbox_ampliacion.Text = "Sí"; else cbox_ampliacion.Text = "No";
                if (((Becado_x_Beca)cbox_ciclo.SelectedItem).Suspencion == 1) cbox_suspencion.Text = "Sí"; else cbox_suspencion.Text = "No";
                cbox_cicloS1.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Ciclo_solicitado.Substring(0, 4);
                cbox_cicloS2.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Ciclo_solicitado.Substring(5, 1);
                tbox_ncarta.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Ncarta;
                rtbox_respuesta.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Respuesta;

                if (((Becado_x_Beca)cbox_ciclo.SelectedItem).Redencion_materiales == 1) cbox_bonomateriales.Text = "Sí"; else cbox_bonomateriales.Text = "No";
                if (((Becado_x_Beca)cbox_ciclo.SelectedItem).Redencion_alojamiento == 1) cbox_bonoalojamiento.Text = "Sí"; else cbox_bonoalojamiento.Text = "No";
                if (((Becado_x_Beca)cbox_ciclo.SelectedItem).Sansion == 1)
                {
                    cbox_sansion.Text = "Sí";
                    tbox_tiposansion.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Sansion_tipo;
                    dt_sansionini.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Sansion_ini.ToString();
                    dt_sansionfin.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Sansion_fin.ToString();
                    dt_sansionini.Visible = true;
                    dt_sansionfin.Visible = true;
                }
                else
                {
                    cbox_sansion.Text = "No";
                    tbox_tiposansion.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Sansion_tipo;
                    dt_sansionini.Visible = false;
                    dt_sansionfin.Visible = false;
                }
                if (((Becado_x_Beca)cbox_ciclo.SelectedItem).Intercambio == 1)
                {
                    cbox_intercambio.Text = "Sí";
                    cbox_tipointercambio.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Intercambio_tipo;
                    if (((Becado_x_Beca)cbox_ciclo.SelectedItem).Adelanto == 1) cbox_adelantobono.Text = "Sí"; else cbox_adelantobono.Text = "No";
                    dt_periodointercambioini.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Intercambio_ini.ToString();
                    dt_periodointercambiofin.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Intercambio_fin.ToString();
                    dt_periodointercambioini.Visible = true;
                    dt_periodointercambiofin.Visible = true;
                }
                else
                {
                    cbox_intercambio.Text = "No";
                    cbox_tipointercambio.Text = "";
                    cbox_adelantobono.Text = "";
                    dt_periodointercambioini.Visible = false;
                    dt_periodointercambiofin.Visible = false;
                }
                cbox_tipointercambio.Enabled = false;
                cbox_adelantobono.Enabled = false;
                tbox_tiposansion.Enabled = false;
                dt_periodointercambioini.Enabled = false;
                dt_periodointercambiofin.Enabled = false;
                dt_sansionini.Enabled = false;
                dt_sansionfin.Enabled = false;
                tbox_id_becadoxbeca.Text = ((Becado_x_Beca)cbox_ciclo.SelectedItem).Id_becado_x_beca.ToString();
            }
        }

        private void cbox_sansion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cbox_sansion.SelectedIndex;
            if (idx == 1)
            {
                tbox_tiposansion.Enabled = false;
                dt_sansionini.Enabled = false;
                dt_sansionfin.Enabled = false;
            }
            else if (idx == 0)
            {
                tbox_tiposansion.Enabled = true;
                dt_sansionini.Enabled = true;
                dt_sansionfin.Enabled = true;
            }
        }

        private void cbox_intercambio_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cbox_intercambio.SelectedIndex;
            if (idx == 1)
            {
                cbox_tipointercambio.Enabled = false;
                dt_periodointercambioini.Enabled = false;
                dt_periodointercambiofin.Enabled = false;
                cbox_adelantobono.Enabled = false;
            }
            else if (idx == 0)
            {
                cbox_tipointercambio.Enabled = true;
                dt_periodointercambioini.Enabled = true;
                dt_periodointercambiofin.Enabled = true;
                cbox_adelantobono.Enabled = true;
            }
        }

        private void cbox_tipoescala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_tipoescala.Text == "ANTIGUA")
            {
                cbox_escalapago1.Visible = true;
                cbox_escalapago2.Visible = false;
            }
            else
            {
                cbox_escalapago1.Visible = false;
                cbox_escalapago2.Visible = true;
            }
        }

        private bool validar()
        {
            BindingList<int> validacion = new BindingList<int>();
            double r_a;
            int r_b;
            if (cbox_ciclo_nuevo1.Text == "") { validacion.Add(1); }
            if (cbox_ciclo_nuevo2.Text == "") { validacion.Add(1); }
            if (cbox_escalapago1.Text == "") { validacion.Add(2); }
            if (cbox_escalapago2.Text == "") { validacion.Add(3); }
            if (cbox_nivelcreditos.Text == "") { validacion.Add(4); }
            if (double.TryParse(tbox_cubiertos.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(5); }
            if (double.TryParse(tbox_utilizados.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(6); }
            if (double.TryParse(tbox_restantes.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(7); }
            if (int.TryParse(tbox_nregularC.Text, out r_b) == false) { validacion.Add(8); }
            if (int.TryParse(tbox_nveranoC.Text, out r_b) == false) { validacion.Add(9); }
            if (int.TryParse(tbox_nregularesRC.Text, out r_b) == false) { validacion.Add(10); }

            foreach(int i in validacion)
            {
                if (i == 1) { MessageBox.Show("Debe ingresar un ciclo valido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 2) { MessageBox.Show("Debe ingresar un tipo de escala.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 3) { MessageBox.Show("Debe ingresar un número de escala.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 4) { MessageBox.Show("Debe ingresar un nivel de créditos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 5) { MessageBox.Show("Debe ingresar un número válido en Nro. de Créditos Cubiertos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 6) { MessageBox.Show("Debe ingresar un número válido en Nro. de Créditos Utilizados.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 7) { MessageBox.Show("Debe ingresar un número válido en Nro. de Créditos Restantes.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 8) { MessageBox.Show("Debe ingresar un número válido en Nro. de Semestre Regular con Cobertura.  Recuerde, el número debe ser entero.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 9) { MessageBox.Show("Debe ingresar un número válido en Nro. de Semestre de Verano con Cobertura.  Recuerde, el número debe ser entero.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 10) { MessageBox.Show("Debe ingresar un número válido en Nro. de Semestres Regulares Restantes con Cobertura.  Recuerde, el número debe ser entero.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            }
            return true;
        }
    }
}

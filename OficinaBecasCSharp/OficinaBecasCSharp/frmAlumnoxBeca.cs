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
    public partial class frmAlumnoxBeca : Form
    {
        private int flag_elementoNuevo = 0;
        private int flag_elementoEditar = 0;
        private Alumno_x_BecaBL logicaNegoAB;

        public enum Estado
        {
            Habilitado, Deshabilitado
        }
        public frmAlumnoxBeca()
        {
            InitializeComponent();

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = true;
            cbox_ciclo.Visible = false;
            tbox_ciclo.Visible = true;
            //btn_historiaacademica.Enabled = false;

            estadoComponentes(Estado.Deshabilitado);
            limpiarComponentes();
            logicaNegoAB = new Alumno_x_BecaBL();

            //cargamos el combo box de beca
            BecaBL logicaNegoBeca = new BecaBL();
            cbox_beca.DataSource = logicaNegoBeca.listarBeca();
            cbox_beca.Sorted = false;
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Deshabilitado:
                    tbox_apellidos.Enabled = false;
                    tbox_ciclo.Enabled = false;
                    tbox_ciclosolicitado.Enabled = false;
                    tbox_codigo.Enabled = false;
                    tbox_cubiertos.Enabled = false;
                    tbox_escalapago.Enabled = false;
                    tbox_ncarta.Enabled = false;
                    tbox_nivelcreditos.Enabled = false;
                    tbox_nombres.Enabled = false;
                    tbox_nregularC.Enabled = false;
                    tbox_nregularesRC.Enabled = false;
                    tbox_nveranoC.Enabled = false;
                    tbox_restantes.Enabled = false;
                    tbox_tiposansion.Enabled = false;
                    tbox_suspencion.Enabled = false;
                    tbox_utilizados.Enabled = false;

                    cbox_adelantobono.Enabled = false;
                    cbox_ampliacion.Enabled = false;
                    cbox_beca.Enabled = false;
                    cbox_bonoalojamiento.Enabled = false;
                    cbox_bonomateriales.Enabled = false;
                    cbox_ciclo.Enabled = false;
                    cbox_renovacion.Enabled = false;
                    cbox_tipointercambio.Enabled = false;
                    cbox_intercambio.Enabled = false;
                    cbox_sansion.Enabled = false;

                    rtbox_respuesta.Enabled = false;

                    dt_periodointercambiofin.Enabled = false;
                    dt_periodointercambioini.Enabled = false;
                    dt_sansionfin.Enabled = false;
                    dt_sansionini.Enabled = false;

                    break;

                case Estado.Habilitado:
                    tbox_ciclo.Enabled = true;
                    tbox_ciclosolicitado.Enabled = true;
                    tbox_cubiertos.Enabled = true;
                    tbox_escalapago.Enabled = true;
                    tbox_ncarta.Enabled = true;
                    tbox_nivelcreditos.Enabled = true;
                    tbox_nregularC.Enabled = true;
                    tbox_nregularesRC.Enabled = true;
                    tbox_nveranoC.Enabled = true;
                    tbox_restantes.Enabled = true;
                    tbox_tiposansion.Enabled = true;
                    tbox_suspencion.Enabled = true;
                    tbox_utilizados.Enabled = true;

                    cbox_adelantobono.Enabled = true;
                    cbox_ampliacion.Enabled = true;
                    cbox_beca.Enabled = true;
                    cbox_bonoalojamiento.Enabled = true;
                    cbox_bonomateriales.Enabled = true;
                    cbox_ciclo.Enabled = true;
                    cbox_renovacion.Enabled = true;
                    cbox_tipointercambio.Enabled = true;
                    cbox_intercambio.Enabled = true;
                    cbox_sansion.Enabled = true;

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
            tbox_ciclo.Text = "";
            tbox_ciclosolicitado.Text = "";
            tbox_cubiertos.Text = "";
            tbox_escalapago.Text = "";
            tbox_ncarta.Text = "";
            tbox_nivelcreditos.Text = "";
            tbox_nregularC.Text = "";
            tbox_nregularesRC.Text = "";
            tbox_nveranoC.Text = "";
            tbox_restantes.Text = "";
            tbox_tiposansion.Text = "";
            tbox_suspencion.Text = "";
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
            rtbox_respuesta.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarAlumno formBAlumno = new frmBuscarAlumno();
            if (formBAlumno.ShowDialog() == DialogResult.OK)
            {
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnBuscar.Enabled = false;
                //btn_historiaacademica.Enabled = true;

                cbox_ciclo.Visible = true;
                tbox_ciclo.Visible = false;

                cbox_ciclo.Enabled = true;
                tbox_nombres.Text = formBAlumno.AlumnoSeleccionado.Nombres;
                tbox_apellidos.Text = formBAlumno.AlumnoSeleccionado.Apellidos;
                tbox_codigo.Text = formBAlumno.AlumnoSeleccionado.CodigoPUCP.ToString();
                tbox_id_alumno.Text = formBAlumno.AlumnoSeleccionado.Id_persona.ToString();
                //flag_elementoNuevo = 1;

                //se listará los ciclos
                BindingList<Alumno_x_Beca> listaCiclo = logicaNegoAB.BuscarBecaxAlumno(formBAlumno.AlumnoSeleccionado.Id_persona);
                cbox_ciclo.DataSource = listaCiclo;
                cbox_ciclo.Sorted = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cbox_ciclo.Visible = false;
            tbox_ciclo.Visible = true;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = false;

            estadoComponentes(Estado.Habilitado);
            limpiarComponentes();
            flag_elementoNuevo = 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = false;
            //btn_historiaacademica.Enabled = false;
            estadoComponentes(Estado.Deshabilitado);

            int id_alumno = Int32.Parse(tbox_id_alumno.Text);
            int id_axb;
            if (flag_elementoEditar == 1) { id_axb = Int32.Parse(tbox_id_alumnoxbeca.Text); }

            Alumno_x_Beca axb = new Alumno_x_Beca();
            //vemos lo de la beca
            axb.Id_beca = ((Beca)cbox_beca.SelectedItem).Id_beca;
            axb.Ciclo = tbox_ciclo.Text;
            axb.Escala_pago = Int32.Parse(tbox_escalapago.Text);
            axb.Nivel_creditos = tbox_nivelcreditos.Text;
            axb.Ncreditos_cubiertos = Double.Parse(tbox_cubiertos.Text);
            axb.Ncreditos_utilizados = Double.Parse(tbox_utilizados.Text);
            axb.Ncreditos_restantes = Double.Parse(tbox_restantes.Text);
            axb.Nsemestres_regular = Int32.Parse(tbox_nregularC.Text);
            axb.Nsemestres_verano = Int32.Parse(tbox_nveranoC.Text);
            axb.Nsemestres_restantes = Int32.Parse(tbox_nregularesRC.Text);
            if (cbox_renovacion.Text == "Sí") axb.Renovacion = 1; else axb.Renovacion = 0;
            axb.Suspencion = tbox_suspencion.Text;
            if (cbox_ampliacion.Text == "Sí") axb.Ampliacion = 1; else axb.Ampliacion = 0;
            axb.Ciclo_solicitado = tbox_ciclosolicitado.Text;
            axb.Respuesta = rtbox_respuesta.Text;
            axb.Ncarta = tbox_ncarta.Text;

            if (cbox_bonomateriales.Text == "Sí") axb.Redencion_materiales = 1; else axb.Redencion_materiales = 0;
            if (cbox_bonoalojamiento.Text == "Sí") axb.Redencion_alojamiento = 1; else axb.Redencion_alojamiento = 0;
            if (cbox_sansion.Text == "Sí") axb.Sansion = 1; else axb.Sansion = 0;
            axb.Sansion_tipo = tbox_tiposansion.Text;
            axb.Sansion_ini = dt_sansionini.Value.ToString("dd-MM-yyyy");
            axb.Sansion_fin = dt_sansionfin.Value.ToString("dd-MM-yyyy");

            if (cbox_intercambio.Text == "Sí") axb.Intercambio = 1; else axb.Intercambio = 0;
            axb.Intercambio_tipo = cbox_tipointercambio.Text;
            axb.Intercambio_ini = dt_periodointercambioini.Value.ToString("dd-MM-yyyy");
            axb.Intercambio_fin = dt_sansionfin.Value.ToString("dd-MM-yyyy");
            if (cbox_adelantobono.Text == "Sí") axb.Adelanto = 1; else axb.Adelanto = 0;

            if (flag_elementoNuevo == 1)
            {
                flag_elementoNuevo = 0;
                logicaNegoAB.RegistrarBecaxAlumno(axb, id_alumno);
                MessageBox.Show("Se ha registrado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (flag_elementoEditar == 1)
            {
                flag_elementoEditar = 0;
                //logicaNegoAB.ActualizarBecaxAlumno(axb, id_alumno, id_beca, id_axb);
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

            cbox_ciclo.Visible = false;
            tbox_ciclo.Visible = true;
            tbox_ciclo.Text = cbox_ciclo.Text;
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
            tbox_ciclo.Visible = true;
            //btn_historiaacademica.Enabled = false;

            estadoComponentes(Estado.Deshabilitado);
            //se limpia
            limpiarComponentes();
            tbox_codigo.Text = "";
            tbox_nombres.Text = "";
            tbox_apellidos.Text = "";
        }

        private void cbox_ciclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_ciclo.SelectedIndex != -1)
            {
                //
                //cargamos el combo box de beca
                BecaBL logicaNegoBeca = new BecaBL();
                BindingList<Beca> listaB = logicaNegoBeca.listarBeca();
                foreach (Beca b in listaB)
                {
                    if (((Alumno_x_Beca)cbox_ciclo.SelectedItem).Id_beca == b.Id_beca)
                    {
                        cbox_beca.Text = b.Nombre_beca;
                    }
                }
                //
                tbox_escalapago.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Escala_pago.ToString();
                tbox_nivelcreditos.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Nivel_creditos;
                tbox_cubiertos.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Ncreditos_cubiertos.ToString();
                tbox_restantes.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Ncreditos_restantes.ToString();
                tbox_utilizados.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Ncreditos_utilizados.ToString();
                tbox_nregularC.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Nsemestres_regular.ToString();
                tbox_nveranoC.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Nsemestres_verano.ToString();
                tbox_nregularesRC.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Nsemestres_restantes.ToString();

                if (((Alumno_x_Beca)cbox_ciclo.SelectedItem).Renovacion == 1) cbox_renovacion.Text = "Sí"; else cbox_renovacion.Text = "No";
                if (((Alumno_x_Beca)cbox_ciclo.SelectedItem).Ampliacion == 1) cbox_ampliacion.Text = "Sí"; else cbox_ampliacion.Text = "No";
                tbox_suspencion.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Suspencion;
                tbox_ciclosolicitado.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Ciclo_solicitado;
                tbox_ncarta.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Ncarta;
                rtbox_respuesta.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Respuesta;

                if (((Alumno_x_Beca)cbox_ciclo.SelectedItem).Redencion_materiales == 1) cbox_bonomateriales.Text = "Sí"; else cbox_bonomateriales.Text = "No";
                if (((Alumno_x_Beca)cbox_ciclo.SelectedItem).Redencion_alojamiento == 1) cbox_bonoalojamiento.Text = "Sí"; else cbox_bonoalojamiento.Text = "No";
                if (((Alumno_x_Beca)cbox_ciclo.SelectedItem).Sansion == 1)
                {
                    cbox_sansion.Text = "Sí";
                    tbox_tiposansion.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Sansion_tipo;
                    dt_sansionini.Value = DateTime.Parse(((Alumno_x_Beca)cbox_ciclo.SelectedItem).Sansion_ini);
                    dt_sansionfin.Value = DateTime.Parse(((Alumno_x_Beca)cbox_ciclo.SelectedItem).Sansion_fin);
                    dt_sansionini.Visible = true;
                    dt_sansionfin.Visible = true;
                }
                else
                {
                    cbox_sansion.Text = "No";
                    tbox_tiposansion.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Sansion_tipo;
                    dt_sansionini.Visible = false;
                    dt_sansionfin.Visible = false;
                }
                if (((Alumno_x_Beca)cbox_ciclo.SelectedItem).Intercambio == 1)
                {
                    cbox_intercambio.Text = "Sí";
                    cbox_tipointercambio.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Intercambio_tipo;
                    if (((Alumno_x_Beca)cbox_ciclo.SelectedItem).Adelanto == 1) cbox_adelantobono.Text = "Sí"; else cbox_adelantobono.Text = "No";
                    dt_periodointercambioini.Value = DateTime.Parse(((Alumno_x_Beca)cbox_ciclo.SelectedItem).Intercambio_ini);
                    dt_periodointercambiofin.Value = DateTime.Parse(((Alumno_x_Beca)cbox_ciclo.SelectedItem).Intercambio_fin);
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
                tbox_id_alumnoxbeca.Text = ((Alumno_x_Beca)cbox_ciclo.SelectedItem).Id_alumno_x_beca.ToString();
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
    }
}

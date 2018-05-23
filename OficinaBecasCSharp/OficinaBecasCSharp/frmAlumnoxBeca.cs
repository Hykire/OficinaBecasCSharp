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
            btnBuscarCiclo.Visible = true;
            //btn_historiaacademica.Enabled = false;

            estadoComponentes(Estado.Deshabilitado);
            limpiarComponentes();
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
                    tbox_sansion.Enabled = false;
                    tbox_suspencion.Enabled = false;
                    tbox_utilizados.Enabled = false;

                    cbox_adelantobono.Enabled = false;
                    cbox_ampliacion.Enabled = false;
                    cbox_beca.Enabled = false;
                    cbox_bonoalojamiento.Enabled = false;
                    cbox_bonomateriales.Enabled = false;
                    cbox_ciclo.Enabled = false;
                    cbox_renovacion.Enabled = false;
                    cbox_tipo.Enabled = false;

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
                    tbox_sansion.Enabled = true;
                    tbox_suspencion.Enabled = true;
                    tbox_utilizados.Enabled = true;

                    cbox_adelantobono.Enabled = true;
                    cbox_ampliacion.Enabled = true;
                    cbox_beca.Enabled = true;
                    cbox_bonoalojamiento.Enabled = true;
                    cbox_bonomateriales.Enabled = true;
                    cbox_ciclo.Enabled = true;
                    cbox_renovacion.Enabled = true;
                    cbox_tipo.Enabled = true;

                    rtbox_respuesta.Enabled = true;

                    dt_periodointercambiofin.Enabled = true;
                    dt_periodointercambioini.Enabled = true;
                    dt_sansionfin.Enabled = true;
                    dt_sansionini.Enabled = true;

                    break;
            }
        }

        public void limpiarComponentes()
        {
            tbox_apellidos.Text = "";
            tbox_ciclo.Text = "";
            tbox_ciclosolicitado.Text = "";
            tbox_codigo.Text = "";
            tbox_cubiertos.Text = "";
            tbox_escalapago.Text = "";
            tbox_ncarta.Text = "";
            tbox_nivelcreditos.Text = "";
            tbox_nombres.Text = "";
            tbox_nregularC.Text = "";
            tbox_nregularesRC.Text = "";
            tbox_nveranoC.Text = "";
            tbox_restantes.Text = "";
            tbox_sansion.Text = "";
            tbox_suspencion.Text = "";
            tbox_utilizados.Text = "";

            cbox_adelantobono.SelectedIndex = -1;
            cbox_ampliacion.SelectedIndex = -1;
            cbox_beca.SelectedIndex = -1;
            cbox_bonoalojamiento.SelectedIndex = -1;
            cbox_bonomateriales.SelectedIndex = -1;
            cbox_ciclo.SelectedIndex = -1;
            cbox_renovacion.SelectedIndex = -1;
            cbox_tipo.SelectedIndex = -1;

            rtbox_respuesta.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarAlumno formBAlumno = new frmBuscarAlumno();
            if (formBAlumno.ShowDialog() == DialogResult.OK)
            {
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = false;
                btnBuscar.Enabled = false;
                btnBuscarCiclo.Enabled = true;
                //btn_historiaacademica.Enabled = true;

                cbox_ciclo.Visible = true;
                tbox_ciclo.Visible = false;

                cbox_ciclo.Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cbox_ciclo.Visible = false;
            tbox_ciclo.Visible = true;
            btnBuscarCiclo.Visible = false;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = false;

            estadoComponentes(Estado.Habilitado);
            limpiarComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = false;
            //btn_historiaacademica.Enabled = false;

            estadoComponentes(Estado.Deshabilitado);
            MessageBox.Show("Se ha registrado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarCiclo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnBuscar.Enabled = false;
            //agarra el valor del combobox y lo buscas y trae todos los datos

            btnBuscarCiclo.Visible = true;
            estadoComponentes(Estado.Deshabilitado);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = false;
            //btn_historiaacademica.Enabled = true;

            estadoComponentes(Estado.Habilitado);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = true;

            cbox_ciclo.Visible = false;
            tbox_ciclo.Visible = true;
            btnBuscarCiclo.Visible = true;
            //btn_historiaacademica.Enabled = false;

            estadoComponentes(Estado.Deshabilitado);
            limpiarComponentes();
        }
    }
}

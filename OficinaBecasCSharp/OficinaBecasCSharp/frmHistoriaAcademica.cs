﻿using Controlador;
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
    public partial class frmHistoriaAcademica : Form
    {
        private int id_becado;
        private int flag_elementoNuevo = 0;
        private int flag_elementoEditar = 0;
        private HistoriaAcademicaBL logicaNegoHistoria;
        private EspecialidadBL logicaNegoFacultad;

        public enum Estado { Habilitado, Deshabilitado }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Deshabilitado:
                    tbox_cac.Enabled = false;
                    tbox_cahn.Enabled = false;
                    tbox_cah_con.Enabled = false;
                    tbox_cah_exi.Enabled = false;
                    tbox_cah_exo.Enabled = false;
                    tbox_cdh.Enabled = false;
                    tbox_cr.Enabled = false;
                    tbox_craest.Enabled = false;
                    tbox_creditosR.Enabled = false;
                    tbox_creditosrestantes.Enabled = false;
                    tbox_creditosSR.Enabled = false;
                    tbox_cur.Enabled = false;
                    tbox_facultad.Enabled = false;
                    tbox_nciclos.Enabled = false;
                    tbox_ncreditos1.Enabled = false;
                    tbox_ncreditos2.Enabled = false;
                    tbox_ncreditos3.Enabled = false;
                    tbox_ncreditos4.Enabled = false;
                    tbox_ncre_rh.Enabled = false;
                    tbox_ncursosR.Enabled = false;
                    tbox_ncursosSR.Enabled = false;
                    tbox_ordenmerito.Enabled = false;
                    tbox_tcac.Enabled = false;

                    cbox_especialidad.Enabled = false;
                    cbox_etapa.Enabled = false;
                    cbox_ultimociclo1.Enabled = false;
                    cbox_ultimociclo2.Enabled = false;
                    break;
                case Estado.Habilitado:
                    tbox_cac.Enabled = true;
                    tbox_cahn.Enabled = true;
                    tbox_cah_con.Enabled = true;
                    tbox_cah_exi.Enabled = true;
                    tbox_cah_exo.Enabled = true;
                    tbox_cdh.Enabled = true;
                    tbox_cr.Enabled = true;
                    tbox_craest.Enabled = true;
                    tbox_creditosR.Enabled = true;
                    tbox_creditosrestantes.Enabled = true;
                    tbox_creditosSR.Enabled = true;
                    tbox_cur.Enabled = true;
                    tbox_facultad.Enabled = true;
                    tbox_nciclos.Enabled = true;
                    tbox_ncreditos1.Enabled = true;
                    tbox_ncreditos2.Enabled = true;
                    tbox_ncreditos3.Enabled = true;
                    tbox_ncreditos4.Enabled = true;
                    tbox_ncre_rh.Enabled = true;
                    tbox_ncursosR.Enabled = true;
                    tbox_ncursosSR.Enabled = true;
                    tbox_ordenmerito.Enabled = true;
                    tbox_tcac.Enabled = true;
                    cbox_especialidad.Enabled = true;
                    cbox_etapa.Enabled = true;
                    cbox_ultimociclo1.Enabled = true;
                    cbox_ultimociclo2.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            tbox_cac.Text = "";
            tbox_cahn.Text = "";
            tbox_cah_con.Text = "";
            tbox_cah_exi.Text = "";
            tbox_cah_exo.Text = "";
            tbox_cdh.Text = "";
            tbox_cr.Text = "";
            tbox_craest.Text = "";
            tbox_creditosR.Text = "";
            tbox_creditosrestantes.Text = "";
            tbox_creditosSR.Text = "";
            tbox_cur.Text = "";
            tbox_facultad.Text = "";
            tbox_nciclos.Text = "";
            tbox_ncreditos1.Text = "";
            tbox_ncreditos2.Text = "";
            tbox_ncreditos3.Text = "";
            tbox_ncreditos4.Text = "";
            tbox_ncre_rh.Text = "";
            tbox_ncursosR.Text = "";
            tbox_ncursosSR.Text = "";
            tbox_ordenmerito.Text = "";
            tbox_tcac.Text = "";

            cbox_ciclo.SelectedIndex = -1;
            cbox_especialidad.SelectedIndex = -1;
            cbox_etapa.SelectedIndex = -1;
            cbox_ultimociclo1.SelectedIndex = -1;
            cbox_ultimociclo2.SelectedIndex = -1;
        }

        public frmHistoriaAcademica(int id_becado)
        {
            InitializeComponent();
            this.id_becado = id_becado;

            //se cargan los combo box de especialidad
            logicaNegoFacultad = new EspecialidadBL();
            cbox_especialidad.DataSource = logicaNegoFacultad.listarEspecialidad();
            cbox_especialidad.Sorted = false;

            //se listará los ciclos
            logicaNegoHistoria = new HistoriaAcademicaBL();
            BindingList<HistoriaAcademica> listaCiclo = logicaNegoHistoria.buscarHistoriaAcademica(id_becado);
            cbox_ciclo.DataSource = listaCiclo;
            cbox_ciclo.Sorted = false;

            //se desabilitan los campos y se limpia
            estadoComponentes(Estado.Deshabilitado);
            limpiarComponentes();

            //se bloquean los botones
            btnNuevo.Enabled = true; btnCancelar.Enabled = true;
            btnGuardar.Enabled = false; btnEditar.Enabled = false;

            //juego con los combo box
            cbox_ciclo.Visible = true;
            cbox_ciclo_nuevo1.Visible = false;
            cbox_ciclo_nuevo2.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                HistoriaAcademica h = new HistoriaAcademica();
                if (flag_elementoEditar == 1) { h.Id_historia_academica = Int32.Parse(tbox_id_historia_academica.Text); }

                h.Id_becado = id_becado;
                h.Ciclo = cbox_ciclo_nuevo1.Text + "-" + cbox_ciclo_nuevo2.Text;
                h.Ultimo_ciclom = cbox_ultimociclo1.Text + "-" + cbox_ultimociclo2.Text;

                h.Id_especialidad_actual = ((Especialidad)cbox_especialidad.SelectedItem).Id_especialidad;
                h.Id_facultad_actual = ((Especialidad)cbox_especialidad.SelectedItem).Facultad.Id_facultad;

                h.Craest = Double.Parse(tbox_craest.Text, CultureInfo.InvariantCulture);
                h.Orden = Double.Parse(tbox_ordenmerito.Text, CultureInfo.InvariantCulture);
                h.Ncm = Int32.Parse(tbox_nciclos.Text);
                h.Etapa = cbox_etapa.Text;
                h.Crpe = Double.Parse(tbox_creditosrestantes.Text, CultureInfo.InvariantCulture);
                h.Ncur_msr = Int32.Parse(tbox_ncursosSR.Text);
                h.Ncur_r = Int32.Parse(tbox_ncursosR.Text);
                h.Ncre_msr = Double.Parse(tbox_creditosSR.Text, CultureInfo.InvariantCulture);
                h.Ncre_mr = Double.Parse(tbox_creditosR.Text, CultureInfo.InvariantCulture);
                h.Ncre_1 = Double.Parse(tbox_ncreditos1.Text, CultureInfo.InvariantCulture);
                h.Ncre_2 = Double.Parse(tbox_ncreditos2.Text, CultureInfo.InvariantCulture);
                h.Ncre_3 = Double.Parse(tbox_ncreditos3.Text, CultureInfo.InvariantCulture);
                h.Ncre_4 = Double.Parse(tbox_ncreditos4.Text, CultureInfo.InvariantCulture);
                h.Cahn = Double.Parse(tbox_cahn.Text, CultureInfo.InvariantCulture);
                h.Tcac = Double.Parse(tbox_tcac.Text, CultureInfo.InvariantCulture);
                h.Cdh = Double.Parse(tbox_cdh.Text, CultureInfo.InvariantCulture);
                h.Cur = Double.Parse(tbox_cur.Text, CultureInfo.InvariantCulture);
                h.Cac = Double.Parse(tbox_cac.Text, CultureInfo.InvariantCulture);
                h.Cr = Double.Parse(tbox_cr.Text, CultureInfo.InvariantCulture);
                h.Cah_exi = Double.Parse(tbox_cah_exi.Text, CultureInfo.InvariantCulture);
                h.Cah_exo = Double.Parse(tbox_cah_exo.Text, CultureInfo.InvariantCulture);
                h.Cah_con = Double.Parse(tbox_cah_con.Text, CultureInfo.InvariantCulture);
                h.Ncre_rh = Double.Parse(tbox_ncre_rh.Text, CultureInfo.InvariantCulture);

                estadoComponentes(Estado.Deshabilitado);
                if (flag_elementoNuevo == 1)
                {
                    flag_elementoNuevo = 0;
                    logicaNegoHistoria.registrarHistoriaAcademica(h);
                    MessageBox.Show("Se ha registrado un nuevo alumno con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (flag_elementoEditar == 1)
                {
                    flag_elementoEditar = 0;
                    logicaNegoHistoria.actualizarHistoriaAcademica(h);
                    MessageBox.Show("Se ha actualizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //se listará los ciclos nuevamente con la informacion actualizada
                logicaNegoHistoria = new HistoriaAcademicaBL();
                BindingList<HistoriaAcademica> listaCiclo = logicaNegoHistoria.buscarHistoriaAcademica(id_becado);
                cbox_ciclo.DataSource = listaCiclo;
                cbox_ciclo.Sorted = false;

                btnGuardar.Enabled = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //habilita flag
            flag_elementoNuevo = 1;

            //habilitamos botones
            btnCancelar.Enabled = true; btnGuardar.Enabled = true;
            btnNuevo.Enabled = false; btnEditar.Enabled = false;

            //se habilitan los campos
            estadoComponentes(Estado.Habilitado);

            //se limpia los campos
            limpiarComponentes();
            cbox_ciclo_nuevo1.SelectedIndex = -1;
            cbox_ciclo_nuevo2.SelectedIndex = -1;

            //se juega con los combo box
            cbox_ciclo_nuevo1.Visible = true; cbox_ciclo_nuevo2.Visible = true;
            cbox_ciclo.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //habilita flag
            flag_elementoEditar = 1;

            //habilitamos botones
            btnCancelar.Enabled = true; btnGuardar.Enabled = true;
            btnNuevo.Enabled = false; btnEditar.Enabled = false;

            //se habilitan los campos
            estadoComponentes(Estado.Habilitado);

            //se juega con los combo box
            cbox_ciclo_nuevo1.Visible = true; cbox_ciclo_nuevo2.Visible = true;
            cbox_ciclo.Visible = false;
            cbox_ciclo_nuevo1.Text = cbox_ciclo.Text.Substring(0, 4);
            cbox_ciclo_nuevo2.Text = cbox_ciclo.Text.Substring(5, 1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //habilitamos botones
            btnNuevo.Enabled = true; btnCancelar.Enabled = true;
            btnGuardar.Enabled = false; btnEditar.Enabled = false;

            //se deshabilita los campos
            estadoComponentes(Estado.Deshabilitado);


            //se limpia
            limpiarComponentes();
            flag_elementoEditar = 0;
            flag_elementoNuevo = 0;

            //juego con los combo box
            cbox_ciclo.Visible = true;
            cbox_ciclo_nuevo1.Visible = false; cbox_ciclo_nuevo2.Visible = false;
        }

        private void cbox_especialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_especialidad.SelectedIndex != -1)
            {
                tbox_facultad.Text = ((Especialidad)cbox_especialidad.SelectedItem).Facultad.Nombre;
            }
        }

        private void cbox_ciclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_ciclo.SelectedIndex != -1)
            {
                tbox_id_historia_academica.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Id_historia_academica.ToString();

                cbox_ultimociclo1.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Ultimo_ciclom.Substring(0, 4);
                cbox_ultimociclo2.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Ultimo_ciclom.Substring(5, 1);
                foreach (Especialidad x in (BindingList<Especialidad>)cbox_especialidad.DataSource)
                {
                    if (x.Id_especialidad == ((HistoriaAcademica)cbox_ciclo.SelectedItem).Id_especialidad_actual) { cbox_especialidad.Text = x.Nombre; break; }
                }
                /*----se cambia automaticamente facultad----*/
                tbox_craest.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Craest.ToString(CultureInfo.InvariantCulture);
                tbox_ordenmerito.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Orden.ToString(CultureInfo.InvariantCulture);
                tbox_nciclos.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Ncm.ToString();
                cbox_etapa.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Etapa;
                tbox_creditosrestantes.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Crpe.ToString(CultureInfo.InvariantCulture);
                tbox_ncursosSR.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Ncur_msr.ToString();
                tbox_ncursosR.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Ncur_r.ToString();
                tbox_creditosSR.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Ncre_msr.ToString(CultureInfo.InvariantCulture);
                tbox_creditosR.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Ncre_mr.ToString(CultureInfo.InvariantCulture);
                tbox_ncreditos1.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Ncre_1.ToString(CultureInfo.InvariantCulture);
                tbox_ncreditos2.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Ncre_2.ToString(CultureInfo.InvariantCulture);
                tbox_ncreditos3.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Ncre_3.ToString(CultureInfo.InvariantCulture);
                tbox_ncreditos4.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Ncre_4.ToString(CultureInfo.InvariantCulture);
                tbox_cahn.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Cahn.ToString(CultureInfo.InvariantCulture);
                tbox_tcac.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Tcac.ToString(CultureInfo.InvariantCulture);
                tbox_cdh.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Cdh.ToString(CultureInfo.InvariantCulture);
                tbox_cur.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Cur.ToString(CultureInfo.InvariantCulture);
                tbox_cac.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Cac.ToString(CultureInfo.InvariantCulture);
                tbox_cr.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Cr.ToString(CultureInfo.InvariantCulture);
                tbox_cah_exi.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Cah_exi.ToString(CultureInfo.InvariantCulture);
                tbox_cah_exo.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Cah_exo.ToString(CultureInfo.InvariantCulture);
                tbox_cah_con.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Cah_con.ToString(CultureInfo.InvariantCulture);
                tbox_ncre_rh.Text = ((HistoriaAcademica)cbox_ciclo.SelectedItem).Ncre_rh.ToString(CultureInfo.InvariantCulture);

                //habilitamos el boton de editar
                btnEditar.Enabled = true;
            }
        }

        private bool validar()
        {
            BindingList<int> validacion = new BindingList<int>();
            double r_a;

            if (cbox_ciclo_nuevo1.Text == "") { validacion.Add(1); }
            if (cbox_ciclo_nuevo2.Text == "") { validacion.Add(1); }
            if (cbox_ultimociclo1.Text == "") { validacion.Add(2); }
            if (cbox_ultimociclo2.Text == "") { validacion.Add(2); }
            if (double.TryParse(tbox_craest.Text, NumberStyles.Any,CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(3); }
            if (double.TryParse(tbox_ordenmerito.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(4); }
            if (int.TryParse(tbox_nciclos.Text, out int result_3) == false) { validacion.Add(5); }
            if (cbox_etapa.Text == "") { validacion.Add(6); }
            if (double.TryParse(tbox_creditosrestantes.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(7); }
            if (int.TryParse(tbox_ncursosSR.Text, out int result_5) == false) { validacion.Add(8); }
            if (int.TryParse(tbox_ncursosR.Text, out int result_6) == false) { validacion.Add(9); }
            if (double.TryParse(tbox_creditosSR.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(10); }
            if (double.TryParse(tbox_creditosR.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(11); }
            if (double.TryParse(tbox_ncreditos1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(12); }
            if (double.TryParse(tbox_ncreditos2.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(13); }
            if (double.TryParse(tbox_ncreditos3.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(14); }
            if (double.TryParse(tbox_ncreditos4.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(15); }
            if (double.TryParse(tbox_cahn.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(16); }
            if (double.TryParse(tbox_cac.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(17); }
            if (double.TryParse(tbox_cdh.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(18); }
            if (double.TryParse(tbox_cur.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(19); }
            if (double.TryParse(tbox_cac.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(20); }
            if (double.TryParse(tbox_cr.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(21); }
            if (double.TryParse(tbox_cah_exi.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(22); }
            if (double.TryParse(tbox_cah_exo.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(23); }
            if (double.TryParse(tbox_cah_con.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(24); }
            if (double.TryParse(tbox_ncre_rh.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out r_a) == false) { validacion.Add(25); }

            foreach (int i in validacion)
            {
                if (i == 1) { MessageBox.Show("Debe ingresar un ciclo valido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 2) { MessageBox.Show("Debe ingresar un último ciclo valido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 3) { MessageBox.Show("Debe ingresar un número de craest válido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 4) { MessageBox.Show("Debe ingresar un orden de merito válido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 5) { MessageBox.Show("Debe ingresar un numero de ciclos válido. Recuerde, el número debe ser entero.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 6) { MessageBox.Show("Debe ingresar una etapa.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 7) { MessageBox.Show("Debe ingresar un número de creditos restantes válido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 8)  { MessageBox.Show("Debe ingresar un numero válido en Nro de Cursos Matriculados sin Retirados. Recuerde, el número debe ser entero.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 9)  { MessageBox.Show("Debe ingresar un numero válido en Nro de Cursos Retirados. Recuerde, el número debe ser entero.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 10) { MessageBox.Show("Debe ingresar un numero válido en Nro de Créditos Matriculados sin Retirados.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 11) { MessageBox.Show("Debe ingresar un número válido en Nro de Créditos Matriculados Retirados.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 12) { MessageBox.Show("Debe ingresar un número válido en Nro de Créditos llevados por 1era vez.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 13) { MessageBox.Show("Debe ingresar un número válido en Nro de Créditos llevados por 2da vez.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 14) { MessageBox.Show("Debe ingresar un número válido en Nro de Créditos llevados por 3era vez.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 15) { MessageBox.Show("Debe ingresar un número válido en Nro de Créditos llevados por 4ta vez.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 16) { MessageBox.Show("Debe ingresar un número válido en Créditos Aprobados Historicos Normal.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 17) { MessageBox.Show("Debe ingresar un número válido en Total de Créditos Aprobados Convalidados.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 18) { MessageBox.Show("Debe ingresar un número válido en Créditos Desaprobados Histórico.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 19) { MessageBox.Show("Debe ingresar un número válido en Créditos usados para Reconocer.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 20) { MessageBox.Show("Debe ingresar un número válido en Créditos Aprobados Consorcio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 21) { MessageBox.Show("Debe ingresar un número válido en Créditos Reconocidos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 22) { MessageBox.Show("Debe ingresar un número válido en Créditos Aprobados Históricos Eximidos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 23) { MessageBox.Show("Debe ingresar un número válido en Créditos Aprobados Históricos Exonerados.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 24) { MessageBox.Show("Debe ingresar un número válido en Créditos Aprobados Históricos Convalidados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 25) { MessageBox.Show("Debe ingresar un número válido en Nro. de Créditos Retirados Históricos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            }
            return true;
        }
    }
}

﻿using Controlador;
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
    public partial class frmBecado : Form
    {
        private int flag_elementoNuevo = 0;
        private int flag_elementoEditar = 0;
        private EspecialidadBL logicaNegoFacultad;
        private BecadoBL logicaNegoAlumno;
        private int id_becado_ParaHistoriaAcademica;

        public enum Estado { Habilitado, Deshabilitado }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Deshabilitado:
                    tbox_apellidos.Enabled = false;
                    tbox_codigo.Enabled = false;
                    tbox_correoalternativo.Enabled = false;
                    tbox_correopucp.Enabled = false;
                    tbox_direccion.Enabled = false;
                    tbox_distritoN.Enabled = false;
                    tbox_provinciaN.Enabled = false;
                    tbox_dni.Enabled = false;
                    tbox_edad.Enabled = false;
                    tbox_facultad.Enabled = false;
                    tbox_fijo.Enabled = false;
                    tbox_movil.Enabled = false;
                    tbox_nombres.Enabled = false;
                    cbox_paisN.Enabled = false;
                    tbox_provincia.Enabled = false;

                    rbutton_femenino.Enabled = false;
                    rbutton_masculino.Enabled = false;

                    dt_fechanacimiento.Enabled = false;

                    cbox_departamento.Enabled = false;
                    cbox_departamentoN.Enabled = false;
                    cbox_especialidad.Enabled = false;
                    cbox_ciclo1.Enabled = false;
                    cbox_ciclo2.Enabled = false;
                    cbox_estado.Enabled = false;
                    cbox_distrito.Enabled = false;
                    cbox_tipogrupo.Enabled = false;
                    break;

                case Estado.Habilitado:

                    tbox_apellidos.Enabled = true;
                    tbox_codigo.Enabled = true;
                    tbox_correoalternativo.Enabled = true;
                    tbox_correopucp.Enabled = true;
                    tbox_direccion.Enabled = true;
                    tbox_distritoN.Enabled = true;
                    tbox_provinciaN.Enabled = true;
                    tbox_dni.Enabled = true;
                    tbox_edad.Enabled = false;
                    tbox_facultad.Enabled = false;
                    tbox_fijo.Enabled = true;
                    tbox_movil.Enabled = true;
                    tbox_nombres.Enabled = true;
                    cbox_paisN.Enabled = true;
                    tbox_provincia.Enabled = true;

                    rbutton_femenino.Enabled = true;
                    rbutton_masculino.Enabled = true;

                    dt_fechanacimiento.Enabled = true;

                    cbox_departamento.Enabled = true;
                    cbox_departamentoN.Enabled = true;
                    cbox_especialidad.Enabled = true;
                    cbox_ciclo1.Enabled = true;
                    cbox_ciclo2.Enabled = true;
                    cbox_estado.Enabled = true;
                    cbox_distrito.Enabled = true;
                    cbox_tipogrupo.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            tbox_apellidos.Text = "";
            tbox_codigo.Text = "";
            tbox_correoalternativo.Text = "";
            tbox_correopucp.Text = "";
            tbox_direccion.Text = "";
            tbox_distritoN.Text = "";
            tbox_provinciaN.Text = "";
            tbox_dni.Text = "";
            tbox_edad.Text = "";
            tbox_facultad.Text = "";
            tbox_fijo.Text = "";
            tbox_movil.Text = "";
            tbox_nombres.Text = "";
            cbox_paisN.SelectedIndex = -1;
            tbox_provincia.Text = "";

            rbutton_femenino.Checked = false;
            rbutton_masculino.Checked = false;

            cbox_departamento.SelectedIndex = -1;
            cbox_departamentoN.SelectedIndex = -1;
            cbox_especialidad.SelectedIndex = -1;
            cbox_ciclo1.SelectedIndex = -1;
            cbox_ciclo2.SelectedIndex = -1;
            cbox_estado.SelectedIndex = -1;
            cbox_distrito.SelectedIndex = -1;
            cbox_tipogrupo.Text = "";
        }

        public frmBecado()
        {
            InitializeComponent();

            //se cargan los combo box de especialidad
            logicaNegoFacultad = new EspecialidadBL();
            cbox_especialidad.DataSource = logicaNegoFacultad.listarEspecialidad();
            cbox_especialidad.Sorted = false;

            //se desabilitan los campos y se limpia
            estadoComponentes(Estado.Deshabilitado);
            limpiarComponentes();

            //se inicializa la logica de negocio
            logicaNegoAlumno = new BecadoBL();

            //se bloquean los botones
            btnNuevo.Enabled = true; btnCancelar.Enabled = true; btnBuscar.Enabled = true;
            btnGuardar.Enabled = false; btnEditar.Enabled = false; btn_historiaacademica.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //se habilita el flag
            flag_elementoNuevo = 1;

            //habilitamos botones
            btnGuardar.Enabled = true; btnCancelar.Enabled = true;
            btnNuevo.Enabled = false; btnEditar.Enabled = false; btnBuscar.Enabled = false;
            btn_historiaacademica.Enabled = false;

            //se habilitan los campos
            estadoComponentes(Estado.Habilitado);

            //se limpia los campos
            limpiarComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                relleno();
                Becado a = new Becado();
                if (flag_elementoEditar == 1) { a.Id_persona = Int32.Parse(tbox_id_persona.Text); a.Id_becado = Int32.Parse(tbox_id_becado.Text); }

                a.CodigoPUCP = Int32.Parse(tbox_codigo.Text);
                a.Nombres = tbox_nombres.Text;
                a.Apellidos = tbox_apellidos.Text;
                if (rbutton_masculino.Checked == true) a.Sexo = 'M'; else if (rbutton_femenino.Checked == true) a.Sexo = 'F';
                a.Edad = Int32.Parse(tbox_edad.Text);
                a.Dni = Int32.Parse(tbox_dni.Text);
                a.CorreoPUCP = tbox_correopucp.Text;
                a.CorreoAlternativo = tbox_correoalternativo.Text;
                a.TelfMovil = tbox_movil.Text;
                a.TelfFijo = tbox_fijo.Text;
                a.Ciclo_ingreso = cbox_ciclo1.Text + "-" + cbox_ciclo2.Text;

                a.Especialidad = ((Especialidad)cbox_especialidad.SelectedItem).Id_especialidad;
                a.Facultad = ((Especialidad)cbox_especialidad.SelectedItem).Facultad.Id_facultad;

                a.Tipo_grupo = cbox_tipogrupo.Text;
                a.Direccion = tbox_direccion.Text;
                a.Distrito_actual = cbox_distrito.Text;
                a.Distrito_nacimiento = tbox_provinciaN.Text;
                a.Provincia_actual = tbox_provincia.Text;
                a.Provincia_nacimiento = tbox_provinciaN.Text;
                a.Departamento_actual = cbox_departamento.Text;
                a.Departamento_nacimiento = cbox_departamentoN.Text;
                a.Pais_nacimiento = cbox_paisN.Text;
                a.Fecha_nacimiento = DateTime.Parse(dt_fechanacimiento.Text);
                a.Estado = cbox_estado.Text;

                estadoComponentes(Estado.Deshabilitado);
                if (flag_elementoNuevo == 1)
                {
                    flag_elementoNuevo = 0;
                    id_becado_ParaHistoriaAcademica = logicaNegoAlumno.registrarAlumno(a);
                    MessageBox.Show("Se ha registrado un nuevo alumno con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_historiaacademica.Enabled = true;
                }
                else if (flag_elementoEditar == 1)
                {
                    flag_elementoEditar = 0;
                    logicaNegoAlumno.actualizarAlumno(a);
                    MessageBox.Show("Se ha actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnGuardar.Enabled = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //habilitar el flag
            flag_elementoEditar = 1;

            //habilitamos botones
            btnCancelar.Enabled = true; btnGuardar.Enabled = true;
            btnNuevo.Enabled = false; btnEditar.Enabled = false; btnBuscar.Enabled = false; btn_historiaacademica.Enabled = true;

            //se habilitan los campos
            estadoComponentes(Estado.Habilitado);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarBecario_F formBAlumno = new frmBuscarBecario_F();
            if (formBAlumno.ShowDialog() == DialogResult.OK)
            {
                tbox_id_persona.Text = formBAlumno.AlumnoSeleccionado.Id_persona.ToString();
                tbox_id_becado.Text = formBAlumno.AlumnoSeleccionado.Id_becado.ToString();

                /*IMPORTANTE id_becado_ParaHistoriaAcademica*/
                id_becado_ParaHistoriaAcademica = formBAlumno.AlumnoSeleccionado.Id_becado;

                tbox_codigo.Text = formBAlumno.AlumnoSeleccionado.CodigoPUCP.ToString();
                tbox_nombres.Text = formBAlumno.AlumnoSeleccionado.Nombres;
                tbox_apellidos.Text = formBAlumno.AlumnoSeleccionado.Apellidos;
                if (formBAlumno.AlumnoSeleccionado.Sexo == 'M') rbutton_masculino.Checked = true; else if (formBAlumno.AlumnoSeleccionado.Sexo == 'F') rbutton_femenino.Checked = true;
                tbox_dni.Text = formBAlumno.AlumnoSeleccionado.Dni.ToString();
                tbox_correopucp.Text = formBAlumno.AlumnoSeleccionado.CorreoPUCP;
                tbox_correoalternativo.Text = formBAlumno.AlumnoSeleccionado.CorreoAlternativo;
                tbox_direccion.Text = formBAlumno.AlumnoSeleccionado.Direccion;
                cbox_distrito.Text = formBAlumno.AlumnoSeleccionado.Distrito_actual;
                tbox_provincia.Text = formBAlumno.AlumnoSeleccionado.Provincia_actual;
                cbox_departamento.Text = formBAlumno.AlumnoSeleccionado.Departamento_actual;
                tbox_distritoN.Text = formBAlumno.AlumnoSeleccionado.Distrito_nacimiento;
                tbox_provinciaN.Text = formBAlumno.AlumnoSeleccionado.Provincia_nacimiento;
                cbox_departamentoN.Text = formBAlumno.AlumnoSeleccionado.Departamento_nacimiento;
                cbox_paisN.Text = formBAlumno.AlumnoSeleccionado.Pais_nacimiento;
                cbox_tipogrupo.Text = formBAlumno.AlumnoSeleccionado.Tipo_grupo;
                tbox_movil.Text = formBAlumno.AlumnoSeleccionado.TelfMovil;
                tbox_fijo.Text = formBAlumno.AlumnoSeleccionado.TelfFijo;
                dt_fechanacimiento.Text = formBAlumno.AlumnoSeleccionado.Fecha_nacimiento.ToString();
                cbox_ciclo1.Text = (formBAlumno.AlumnoSeleccionado.Ciclo_ingreso).Substring(0, 4);
                cbox_ciclo2.Text = (formBAlumno.AlumnoSeleccionado.Ciclo_ingreso).Substring(5, 1);
                cbox_estado.Text = formBAlumno.AlumnoSeleccionado.Estado;
                foreach (Especialidad x in (BindingList<Especialidad>)cbox_especialidad.DataSource)
                {
                    if (x.Id_especialidad == formBAlumno.AlumnoSeleccionado.Especialidad) { cbox_especialidad.Text = x.Nombre; break; }
                }
                tbox_edad.Text = (calcular_edad()).ToString();

                //se habilitan botones
                btnEditar.Enabled = true;
                btnGuardar.Enabled = false;
                btn_historiaacademica.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //habilitamos botones
            btnNuevo.Enabled = true; btnCancelar.Enabled = true; btnBuscar.Enabled = true;
            btnGuardar.Enabled = false; btnEditar.Enabled = false; btn_historiaacademica.Enabled = false;

            //se deshabilita los campos
            estadoComponentes(Estado.Deshabilitado);

            //se limpia
            flag_elementoEditar = 0;
            flag_elementoNuevo = 0;
            limpiarComponentes();
        }

      

        private void cbox_especialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_especialidad.SelectedIndex != -1)
            {
                tbox_facultad.Text = ((Especialidad)cbox_especialidad.SelectedItem).Facultad.Nombre;
            }
        }

        private int calcular_edad()
        {
            DateTime fecha_nacimiento = dt_fechanacimiento.Value;
            int anios = System.DateTime.Now.Year - fecha_nacimiento.Year;
            if (System.DateTime.Now.Subtract(fecha_nacimiento.AddYears(anios)).TotalDays < 0)
                return (anios - 1);
            return anios;
        }

        private void btn_historiaacademica_Click(object sender, EventArgs e)
        {
            frmHistoriaAcademica frmHA = new frmHistoriaAcademica(id_becado_ParaHistoriaAcademica);
            if (frmHA.ShowDialog() == DialogResult.OK) { }

        }

        private void dt_fechanacimiento_ValueChanged(object sender, EventArgs e)
        {
            tbox_edad.Text = calcular_edad().ToString();
        }

        private bool validar()
        {
            BindingList<int> validaciones = new BindingList<int>();
            bool flag = false;
            PersonaBL logicanegocioPersona = new PersonaBL();

            //validacion de codigo
            if (tbox_codigo.Text == "") { validaciones.Add(1); }
            else if (tbox_codigo.Text.Length != 8) { validaciones.Add(2); }
            else if (int.TryParse(tbox_codigo.Text, out int result) == false) { validaciones.Add(3); }
            else if (flag_elementoEditar==0 && logicanegocioPersona.existe_codigo(int.Parse(tbox_codigo.Text)) == true) { validaciones.Add(20); }

            //validacion de nombres
            if (tbox_nombres.Text == "") { validaciones.Add(4); }
            else if (tbox_nombres.Text.Any(char.IsDigit) == true) { validaciones.Add(5); }
            if (tbox_apellidos.Text == "") { validaciones.Add(6); }
            else if (tbox_apellidos.Text.Any(char.IsDigit) == true) { validaciones.Add(7); }
            //validacion de genero
            if (rbutton_femenino.Checked == false && rbutton_masculino.Checked == false) { validaciones.Add(8); }
            //validacion de dni
            if (tbox_dni.Text == "") { validaciones.Add(9); }
            else if (tbox_dni.Text.Length != 8) { validaciones.Add(10); }
            else if (int.TryParse(tbox_dni.Text, out int result_2) == false) { validaciones.Add(11); }
            //validacion de edad
            if (tbox_edad.Text == "") { validaciones.Add(12); }
            //validad de correo pucp
            if (tbox_correopucp.Text == "") { validaciones.Add(13); }
            else if (!(tbox_correopucp.Text.Contains("@pucp.pe") || tbox_correopucp.Text.Contains("@pucp.edu.pe") )) { validaciones.Add(14); }
            //validacion de correo alternativo
            if (tbox_correoalternativo.Text == "") { }
            else if (tbox_correoalternativo.Text.Contains("@") == false) { validaciones.Add(15); }

            //validacion de ciclo
            if (cbox_ciclo1.Text == "") { validaciones.Add(16); }
            if (cbox_ciclo2.Text == "") { validaciones.Add(17); }
            // validacion de la especialidad
            if (cbox_especialidad.Text == "") { validaciones.Add(18); }
            // validacion del tipo de grupo
            if (cbox_tipogrupo.Text == "") { validaciones.Add(19); }


            foreach (int i in validaciones)
            {
                if (i == 1) { MessageBox.Show("Debe ingresar un código.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 2) { MessageBox.Show("El código ingresado no es de 8 dígitos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
                if (i == 3) { MessageBox.Show("El código ingresado es incorrecto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }

                if (i == 4) { MessageBox.Show("Debe ingresar por lo menos un nombre.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 5) { MessageBox.Show("Los nombres ingresados cuentan con caracteres numéricos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
                if (i == 6) { MessageBox.Show("Debe ingresar por lo menos un apellido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 7) { MessageBox.Show("Los apellidos ingresados cuentan con caracteres numéricos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }

                if (i == 8) { MessageBox.Show("Debe seleccionar un género.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
                if (i == 9) { MessageBox.Show("Debe ingresar un dni.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 10) { MessageBox.Show("El dni ingresado no es de 8 dígitos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
                if (i == 11) { MessageBox.Show("El dni ingresado es incorrecto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }

                if (i == 12) { MessageBox.Show("Debe ingresar una fecha de nacimiento.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }

                if (i == 13) { MessageBox.Show("Debe ingresar el correo pucp.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 14) { MessageBox.Show("El correo pucp ingresado es incorrecto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
                if (i == 15) { MessageBox.Show("El correo alternativo ingresado es incorrecto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }

                if (i == 16) { MessageBox.Show("Debe ingresar un año de ingreso.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 17) { MessageBox.Show("Debe ingresar un semestre ingreso.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 18) { MessageBox.Show("Debe ingresar una especialidad de ingreso.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 19) { MessageBox.Show("Debe ingresar un tipo de grupo de ingreso.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                if (i == 20) { MessageBox.Show("El código ingresado ya existe en la base de datos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                flag = true;
            }
            return true;
        }
        private void relleno()
        {
            if (tbox_fijo.Text == "") tbox_fijo.Text = "--";
            if (tbox_movil.Text == "") tbox_movil.Text = "--";

            if (tbox_direccion.Text == "") tbox_direccion.Text = "--";
            if (cbox_departamento.Text == "") cbox_departamento.Text = "--";
            if (cbox_distrito.Text == "") cbox_distrito.Text = "--";
            if (tbox_provincia.Text == "") tbox_provincia.Text = "--";

            if (cbox_paisN.Text == "") cbox_paisN.Text = "--";
            if (cbox_departamentoN.Text == "") cbox_departamentoN.Text = "--";
            if (tbox_distritoN.Text == "") tbox_distritoN.Text = "--";
            if (tbox_provinciaN.Text == "") tbox_provinciaN.Text = "--";
        }
    }
}

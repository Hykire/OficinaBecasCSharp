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
    public partial class frmAlumno : Form
    {
        private int flag_elementoNuevo = 0;
        private int flag_elementoEditar = 0;
        private EspecialidadBL logicaNegoFacultad;
        private AlumnoBL logicaNegoAlumno;

        public enum Estado
        {
            Habilitado, Deshabilitado
        }
        public frmAlumno()
        {
            InitializeComponent();

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = true;
            btn_historiaacademica.Enabled = false;

            //se cargan los combo box
            logicaNegoFacultad = new EspecialidadBL();
            cbox_especialidad.DataSource = logicaNegoFacultad.listarEspecialidad();
            cbox_especialidad.Sorted = false;

            estadoComponentes(Estado.Deshabilitado);
            limpiarComponentes();

            logicaNegoAlumno = new AlumnoBL();
        }
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Deshabilitado:
                    tbox_apellidos.Enabled = false;
                    tbox_ciclo.Enabled = false;
                    tbox_codigo.Enabled = false;
                    tbox_correoalternativo.Enabled = false;
                    tbox_correopucp.Enabled = false;
                    tbox_direccion.Enabled = false;
                    tbox_distritoN.Enabled = false;
                    tbox_distrito.Enabled = false;
                    tbox_provinciaN.Enabled = false;
                    tbox_dni.Enabled = false;
                    tbox_edad.Enabled = false;
                    tbox_facultad.Enabled = false;
                    tbox_fijo.Enabled = false;
                    tbox_movil.Enabled = false;
                    tbox_nombres.Enabled = false;
                    tbox_paisN.Enabled = false;
                    tbox_provincia.Enabled = false;
                    tbox_tipogrupo.Enabled = false;

                    rbutton_femenino.Enabled = false;
                    rbutton_masculino.Enabled = false;

                    dt_fechanacimiento.Enabled = false;

                    cbox_departamento.Enabled = false;
                    cbox_departamentoN.Enabled = false;
                    cbox_especialidad.Enabled = false;

                    break;

                case Estado.Habilitado:

                    tbox_apellidos.Enabled = true;
                    tbox_ciclo.Enabled = true;
                    tbox_codigo.Enabled = true;
                    tbox_correoalternativo.Enabled = true;
                    tbox_correopucp.Enabled = true;
                    tbox_direccion.Enabled = true;
                    tbox_distritoN.Enabled = true;
                    tbox_distrito.Enabled = true;
                    tbox_provinciaN.Enabled = true;
                    tbox_dni.Enabled = true;
                    tbox_edad.Enabled = false;
                    tbox_facultad.Enabled = false;
                    tbox_fijo.Enabled = true;
                    tbox_movil.Enabled = true;
                    tbox_nombres.Enabled = true;
                    tbox_paisN.Enabled = true;
                    tbox_provincia.Enabled = true;
                    tbox_tipogrupo.Enabled = true;

                    rbutton_femenino.Enabled = true;
                    rbutton_masculino.Enabled = true;

                    dt_fechanacimiento.Enabled = true;

                    cbox_departamento.Enabled = true;
                    cbox_departamentoN.Enabled = true;
                    cbox_especialidad.Enabled = true;

                    break;
            }
        }

        public void limpiarComponentes()
        {
            tbox_apellidos.Text = "";
            tbox_ciclo.Text = "";
            tbox_codigo.Text = "";
            tbox_correoalternativo.Text = "";
            tbox_correopucp.Text = "";
            tbox_direccion.Text = "";
            tbox_distritoN.Text = "";
            tbox_distrito.Text = "";
            tbox_provinciaN.Text = "";
            tbox_dni.Text = "";
            tbox_edad.Text = "";
            tbox_facultad.Text = "";
            tbox_fijo.Text = "";
            tbox_movil.Text = "";
            tbox_nombres.Text = "";
            tbox_paisN.Text = "";
            tbox_provincia.Text = "";
            tbox_tipogrupo.Text = "";

            rbutton_femenino.Checked = false;
            rbutton_masculino.Checked = false;

            cbox_departamento.SelectedIndex = -1;
            cbox_departamentoN.SelectedIndex = -1;
            cbox_especialidad.SelectedIndex = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = false;
            btn_historiaacademica.Enabled = true;

            estadoComponentes(Estado.Habilitado);
            limpiarComponentes();
            flag_elementoNuevo = 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = true;
            btn_historiaacademica.Enabled = false;

            Alumno a = new Alumno();
            if (flag_elementoEditar == 1) { a.Id_persona = Int32.Parse(tbox_id.Text); }
            a.CodigoPUCP = Int32.Parse(tbox_codigo.Text);
            a.Nombres = tbox_nombres.Text;
            a.Apellidos = tbox_apellidos.Text;
            if (rbutton_masculino.Checked == true) a.Sexo = 'M';
            else if (rbutton_femenino.Checked == true) a.Sexo = 'F';
            a.Dni = Int32.Parse(tbox_dni.Text);
            a.CorreoPUCP = tbox_correopucp.Text;
            a.CorreoAlternativo = tbox_correoalternativo.Text;
            a.TelfMovil = tbox_movil.Text;
            a.TelfFijo = tbox_fijo.Text;
            a.Ciclo_ingreso = tbox_ciclo.Text;
            //para la especialidad
            BindingList<Especialidad> lst = (BindingList<Especialidad>)cbox_especialidad.DataSource;
            int id_especialidadIngreso = lst[cbox_especialidad.SelectedIndex].Id_especialidad;
            //
            a.Tipo_grupo = tbox_tipogrupo.Text;
            a.Direccion = tbox_direccion.Text;
            a.Distrito_actual = tbox_distrito.Text;
            a.Distrito_nacimiento = tbox_provinciaN.Text;
            a.Provincia_actual = tbox_provincia.Text;
            a.Provincia_nacimiento = tbox_provinciaN.Text;
            a.Departamento_actual = cbox_departamento.Text;
            a.Departamento_nacimiento = cbox_departamentoN.Text;
            a.Pais_nacimiento = tbox_paisN.Text;
            a.Fecha_nacimiento = dt_fechanacimiento.Value.ToString("dd-MM-yyyy");
            estadoComponentes(Estado.Deshabilitado);
            if (flag_elementoNuevo == 1)
            {
                flag_elementoNuevo = 0;
                logicaNegoAlumno.RegistrarAlumno(a, id_especialidadIngreso);
                MessageBox.Show("Se ha registrado un nuevo alumno con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (flag_elementoEditar == 1)
            {
                flag_elementoEditar = 0;
                logicaNegoAlumno.ActualizarAlumno(a, id_especialidadIngreso);
                MessageBox.Show("Se ha actualizado el alumno con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = false;
            btn_historiaacademica.Enabled = true;

            flag_elementoEditar = 1;
            estadoComponentes(Estado.Habilitado);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarAlumno formBAlumno = new frmBuscarAlumno();
            if (formBAlumno.ShowDialog() == DialogResult.OK)
            {
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = true;
                btnBuscar.Enabled = false;
                btn_historiaacademica.Enabled = true;

                tbox_id.Text = formBAlumno.AlumnoSeleccionado.Id_persona.ToString();
                tbox_codigo.Text = formBAlumno.AlumnoSeleccionado.CodigoPUCP.ToString();
                tbox_nombres.Text = formBAlumno.AlumnoSeleccionado.Nombres;
                tbox_apellidos.Text = formBAlumno.AlumnoSeleccionado.Apellidos;
                if (formBAlumno.AlumnoSeleccionado.Sexo == 'M') rbutton_masculino.Checked = true;
                else if (formBAlumno.AlumnoSeleccionado.Sexo == 'F') rbutton_femenino.Checked = true;
                tbox_dni.Text = formBAlumno.AlumnoSeleccionado.Dni.ToString();
                tbox_correopucp.Text = formBAlumno.AlumnoSeleccionado.CorreoPUCP;
                tbox_correoalternativo.Text = formBAlumno.AlumnoSeleccionado.CorreoAlternativo;
                tbox_direccion.Text = formBAlumno.AlumnoSeleccionado.Direccion;
                tbox_distrito.Text = formBAlumno.AlumnoSeleccionado.Distrito_actual;
                tbox_provincia.Text = formBAlumno.AlumnoSeleccionado.Provincia_actual;
                cbox_departamento.Text = formBAlumno.AlumnoSeleccionado.Departamento_actual;
                tbox_distritoN.Text = formBAlumno.AlumnoSeleccionado.Distrito_nacimiento;
                tbox_provinciaN.Text = formBAlumno.AlumnoSeleccionado.Provincia_nacimiento;
                cbox_departamentoN.Text = formBAlumno.AlumnoSeleccionado.Departamento_nacimiento;
                tbox_paisN.Text = formBAlumno.AlumnoSeleccionado.Pais_nacimiento;
                tbox_tipogrupo.Text = formBAlumno.AlumnoSeleccionado.Tipo_grupo;
                tbox_movil.Text = formBAlumno.AlumnoSeleccionado.TelfMovil;
                tbox_fijo.Text = formBAlumno.AlumnoSeleccionado.TelfFijo;

                dt_fechanacimiento.Value = DateTime.Parse(formBAlumno.AlumnoSeleccionado.Fecha_nacimiento);
                tbox_ciclo.Text = formBAlumno.AlumnoSeleccionado.Ciclo_ingreso;
                cbox_especialidad.Text = formBAlumno.AlumnoSeleccionado.Especialidad.Nombre;

                tbox_edad.Text = (calcular_edad()).ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = true;
            btn_historiaacademica.Enabled = false;
            flag_elementoEditar = 0;
            flag_elementoNuevo = 0;

            estadoComponentes(Estado.Deshabilitado);
            limpiarComponentes();
        }

        private void cbox_especialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_especialidad.SelectedIndex != -1)
            {
                BindingList<Especialidad> lst = (BindingList<Especialidad>)cbox_especialidad.DataSource;
                tbox_facultad.Text = lst[cbox_especialidad.SelectedIndex].Facultad.Nombre;
            }
        }

        private void dt_fechanacimiento_ValueChanged(object sender, EventArgs e)
        {
            tbox_edad.Text = calcular_edad().ToString();
        }

        private int calcular_edad()
        {
            DateTime fecha_nacimiento = dt_fechanacimiento.Value;
            int anios = System.DateTime.Now.Year - fecha_nacimiento.Year;
            if (System.DateTime.Now.Subtract(fecha_nacimiento.AddYears(anios)).TotalDays < 0)
                return (anios - 1);
            return anios;
        }
    }
}

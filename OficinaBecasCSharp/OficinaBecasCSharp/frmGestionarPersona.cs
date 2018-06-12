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
    public partial class frmGestionarPersona : Form
    {
        private int flag_elementoNuevo = 0;
        private int flag_elementoEditar = 0;
        private PersonaBL logicanegocioPersona;
        private UsuarioBL logicanegocioUsuario;

        public enum Estado { Habilitado, Deshabilitado }
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Deshabilitado:
                    tbox_nombres.Enabled = false;
                    tbox_apellidos.Enabled = false;
                    tbox_codigo.Enabled = false;
                    tbox_dni.Enabled = false;
                    tbox_edad.Enabled = false;
                    tbox_correoalternativo.Enabled = false;
                    tbox_correopucp.Enabled = false;
                    tbox_movil.Enabled = false;
                    tbox_fijo.Enabled = false;
                    tbox_user.Enabled = false;
                    tbox_password.Enabled = false;

                    cbox_estado.Enabled = false;
                    cbox_tipo.Enabled = false;

                    dt_fechanacimiento.Enabled = false;

                    rbutton_femenino.Enabled = false;
                    rbutton_masculino.Enabled = false;
                    break;
                case Estado.Habilitado:
                    tbox_nombres.Enabled = true;
                    tbox_apellidos.Enabled = true;
                    tbox_codigo.Enabled = true;
                    tbox_dni.Enabled = true;
                    tbox_correoalternativo.Enabled = true;
                    tbox_correopucp.Enabled = true;
                    tbox_movil.Enabled = true;
                    tbox_fijo.Enabled = true;
                    tbox_user.Enabled = true;
                    tbox_password.Enabled = true;

                    cbox_estado.Enabled = true;
                    cbox_tipo.Enabled = true;

                    dt_fechanacimiento.Enabled = true;

                    rbutton_femenino.Enabled = true;
                    rbutton_masculino.Enabled = true;
                    break;
            }
        }
        public void limpiarComponentes()
        {
            tbox_nombres.Text = "";
            tbox_apellidos.Text = "";
            tbox_codigo.Text = "";
            tbox_dni.Text = "";
            tbox_edad.Text = "";
            tbox_correoalternativo.Text = "";
            tbox_correopucp.Text = "";
            tbox_movil.Text = "";
            tbox_fijo.Text = "";
            tbox_user.Text = "";
            tbox_password.Text = "";

            cbox_estado.SelectedIndex = -1;
            cbox_tipo.SelectedIndex = -1;

            rbutton_femenino.Checked = false;
            rbutton_masculino.Checked = false;

            //dt_fechanacimiento.Enabled = true;
        }
        public frmGestionarPersona()
        {
            InitializeComponent();

            logicanegocioPersona = new PersonaBL();
            logicanegocioUsuario = new UsuarioBL();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            Usuario u = new Usuario();
            if (flag_elementoEditar ==1) { p.Id_persona = Int32.Parse(tbox_id_persona.Text);  u.Id_usuario = Int32.Parse(tbox_id_usuario.Text); }

            p.CodigoPUCP = Int32.Parse(tbox_codigo.Text);
            p.Nombres = tbox_nombres.Text;
            p.Apellidos = tbox_apellidos.Text;
            if (rbutton_masculino.Checked == true) p.Sexo = 'M'; else if (rbutton_femenino.Checked == true) p.Sexo = 'F';
            p.Edad = Int32.Parse(tbox_edad.Text);
            p.Dni = Int32.Parse(tbox_dni.Text);
            p.CorreoPUCP = tbox_correopucp.Text;
            p.CorreoAlternativo = tbox_correoalternativo.Text;
            p.TelfMovil = tbox_movil.Text;
            p.TelfFijo = tbox_fijo.Text;
            p.Fecha_nacimiento = DateTime.Parse(dt_fechanacimiento.Text);
            p.Estado = cbox_estado.Text;

            u.User = tbox_user.Text;
            u.Password = tbox_password.Text;
            u.Id_tipo_usuario = Int32.Parse(cbox_tipo.Text);

            if (flag_elementoNuevo == 1)
            {
                flag_elementoNuevo = 0;
                logicanegocioPersona.registrar_persona(p, u);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //habilitamos botones
            btnEditar.Enabled = true;

            frmBuscarPersona_F formBPersona = new frmBuscarPersona_F();
            if (formBPersona.ShowDialog() == DialogResult.OK)
            {
                tbox_id_persona.Text = formBPersona.PersonaSeleccionada.Id_persona.ToString();
                tbox_id_usuario.Text = formBPersona.PersonaSeleccionada.Id_usuario.ToString();

                tbox_codigo.Text = formBPersona.PersonaSeleccionada.CodigoPUCP.ToString();
                tbox_nombres.Text = formBPersona.PersonaSeleccionada.Nombres;
                tbox_apellidos.Text = formBPersona.PersonaSeleccionada.Apellidos;
                if (formBPersona.PersonaSeleccionada.Sexo == 'M') rbutton_masculino.Checked = true; else if (formBPersona.PersonaSeleccionada.Sexo == 'F') rbutton_femenino.Checked = true;
                tbox_dni.Text = formBPersona.PersonaSeleccionada.Dni.ToString();
                tbox_correopucp.Text = formBPersona.PersonaSeleccionada.CorreoPUCP;
                tbox_correoalternativo.Text = formBPersona.PersonaSeleccionada.CorreoAlternativo;
                tbox_movil.Text = formBPersona.PersonaSeleccionada.TelfMovil;
                tbox_fijo.Text = formBPersona.PersonaSeleccionada.TelfFijo;
                dt_fechanacimiento.Text = formBPersona.PersonaSeleccionada.Fecha_nacimiento.ToString();
                cbox_estado.Text = formBPersona.PersonaSeleccionada.Estado;
                tbox_edad.Text = (calcular_edad()).ToString();

                //ahora obtenemos los datos de usuario, contraseña y tipo de usuario
                //como ya se tiene el id persona...
                Usuario u = logicanegocioUsuario.obtenerUsuario(Int32.Parse(tbox_id_usuario.Text));
                tbox_id_usuario.Text = u.Id_usuario.ToString();
                tbox_user.Text = u.User;
                tbox_password.Text = u.Password;
                cbox_tipo.Text = u.Id_tipo_usuario.ToString();
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

        private void dt_fechanacimiento_ValueChanged(object sender, EventArgs e)
        {
            tbox_edad.Text = calcular_edad().ToString();
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
    }
}

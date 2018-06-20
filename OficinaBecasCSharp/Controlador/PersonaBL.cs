using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{

    public class PersonaBL
    {
        private PersonaAD accesoDatosPersona;
        private UsuarioDA accesoDatosUsuario;
        public PersonaBL()
        {
            accesoDatosPersona = new PersonaAD();
            accesoDatosUsuario = new UsuarioDA();
        }

        public BindingList<Persona> listarBecadosXTutor(String idTut)
        {
            return accesoDatosPersona.listarBecadosXTutor(idTut);
        }

        public bool enlazarBecario(Tutor pe,int idbec,string ciclo)
        {
           return accesoDatosPersona.enlazarBecario(pe, idbec,ciclo);
        }

        public bool enlazarBecario2(Becado pe, string idAlum)
        {
            return accesoDatosPersona.enlazarBecario2(pe, idAlum);
        }

        public BindingList<Persona> listarPersonas(String cod)
        {
            return accesoDatosPersona.listarPersonas(cod);
        }

        //hecho por Francisco, se usa en el frmGestionarPersona
        public void registrar_persona(Persona p, Usuario u)
        {
            int id_usuario = accesoDatosUsuario.insertar_usuario(u);
            int id_persona = accesoDatosPersona.insertar_persona(p, id_usuario);
            //se inserta en las tablas correspondientes
            if (u.Id_tipo_usuario == 3)
            {
                accesoDatosPersona.insertar_personaEnTCoordinadorTuto(id_persona);
            }
            if (u.Id_tipo_usuario == 5)
            {
                accesoDatosPersona.insertar_personaEnAsistenteCom(id_persona);
            }
        }
        public void editar_persona(Persona p, Usuario u)
        {
            accesoDatosPersona.actualizar_persona(p);
            accesoDatosUsuario.actualizarUsuario(u);
        }

        public bool existe_codigo(int codigo)
        {
            return accesoDatosPersona.existe_cod(codigo);
        }
        public bool existe_usuario(string n_usuario)
        {
            return accesoDatosUsuario.existe_user(n_usuario);
        }
        //hecho por Francisco, se usa en el frmBuscarPersona_F
        public BindingList<Persona> buscar_Persona_F(string codigoB, string nombreB, string apellidoB)
        {
            BindingList<Persona> lista = accesoDatosPersona.listar_Persona_F(); //lista todos las Persona
            BindingList<Persona> listaB = new BindingList<Persona>(); //listaB tendrá los becados de acuerdo a los parametros de busqueda

            if (codigoB != "") //si se ingreso un codigo
            {
                bool esNumero = int.TryParse(codigoB, out int codigo);
                if (esNumero == true)
                {
                    if (nombreB != "" && apellidoB != "")
                    {
                        foreach (Persona a in lista) { if (a.CodigoPUCP == codigo && a.Nombres.Contains(nombreB) == true && a.Apellidos.Contains(apellidoB) == true) { listaB.Add(a); break; } }
                    }
                    if (nombreB != "" && apellidoB == "")
                    {
                        foreach (Persona a in lista) { if (a.CodigoPUCP == codigo && a.Nombres.Contains(nombreB) == true) { listaB.Add(a); break; } }
                    }
                    if (nombreB == "" && apellidoB != "")
                    {
                        foreach (Persona a in lista) { if (a.CodigoPUCP == codigo && a.Apellidos.Contains(apellidoB) == true) { listaB.Add(a); break; } }
                    }
                    if (nombreB == "" && apellidoB == "")
                    {
                        foreach (Persona a in lista) { if (a.CodigoPUCP == codigo) { listaB.Add(a); break; } }
                    }
                }
                else { MessageBox.Show("Error, el codigo ingresado no es un número", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //si no se ingreso un codigo...
            {
                if (nombreB != "" && apellidoB != "")
                {
                    foreach (Persona a in lista) { if (a.Nombres.Contains(nombreB) == true && a.Apellidos.Contains(apellidoB) == true) { listaB.Add(a); } }
                }
                if (nombreB != "" && apellidoB == "")
                {
                    foreach (Persona a in lista) { if (a.Nombres.Contains(nombreB) == true) { listaB.Add(a); } }
                }
                if (nombreB == "" && apellidoB != "")
                {
                    foreach (Persona a in lista) { if (a.Apellidos.Contains(apellidoB) == true) { listaB.Add(a); } }
                }
                if (nombreB == "" && apellidoB == "")
                {
                    return lista;
                }
            }
            return listaB;
        }
    }
}

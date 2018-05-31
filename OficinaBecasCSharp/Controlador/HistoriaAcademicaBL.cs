using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class HistoriaAcademicaBL
    {
        private HistoriaAcademicaDA accesoDatos;

        public HistoriaAcademicaBL() { accesoDatos = new HistoriaAcademicaDA(); }

        public BindingList<HistoriaAcademica> buscarHistoriaAcademica(int id_becado)
        {
            BindingList<HistoriaAcademica> lista = accesoDatos.buscar_enHistoriaA(id_becado);
            BindingList<HistoriaAcademica> ltsOrdenada = new BindingList<HistoriaAcademica>(lista.OrderBy(x => x.Ciclo).ToList());
            return ltsOrdenada;
        }

        public void registrarHistoriaAcademica(HistoriaAcademica h) { accesoDatos.registrar_enHistoriaA(h); }
        public void actualizarHistoriaAcademica(HistoriaAcademica h) { accesoDatos.actualizar_enHistoriaA(h); }
    }
}

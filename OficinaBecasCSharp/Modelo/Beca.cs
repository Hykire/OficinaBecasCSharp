using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Beca
    {
        private int id_beca;
        private string nombre_beca;
        private string descrip_beca;
        private DateTime fecha_creacion;
        private DateTime fecha_modificacion;

        private string tipo_beca; //postulantes, estudiantes
        private string fecha_convocatoria; //abierta, sin convocatoria, todo el años
        private string estado_beca; //bloqueada, en espera...

        private DateTime fecha_inicio;
        private DateTime fecha_cierre;

        private List<Especialidad> lts_espc;
        private Financiador finan;
        private List<Documento> lst_doc;

        public Beca()
        {
            lts_espc = new List<Especialidad>();
            lst_doc = new List<Documento>();
        }
        //SET'S y GET'S
     
        public List<Documento> _lts_doc
        {
            set
            {
                lst_doc = value;
            }
            get
            {
                return lst_doc;
            }
        }
        public Financiador _finan
        {
            set
            {
                finan = value;
            }
            get
            {
                return finan;
            }
        }
        public int _id_beca
        {
            set
            {
                id_beca = value;
            }
            get
            {
                return id_beca;
            }
        }
        public string _nombre_beca
        {
            set
            {
                nombre_beca = value;
            }
            get
            {
                return nombre_beca;
            }
        }
        public string _descrip_beca
        {
            set
            {
                descrip_beca = value;
            }
            get
            {
                return descrip_beca;
            }
        }
        public string _tipo_beca
        {
            set
            {
                tipo_beca = value;
            }
            get
            {
                return tipo_beca;
            }
        }
        public string _fecha_convocatoria
        {
            set
            {
                fecha_convocatoria = value;
            }
            get
            {
                return fecha_convocatoria;
            }
        }
        public string _estado_beca
        {
            set
            {
                estado_beca = value;
            }
            get
            {
                return estado_beca;
            }
        }
    }
}

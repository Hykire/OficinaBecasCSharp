using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Documento
    {
        private int id_doc;
        private string nombre_doc;
        private string descripcion_doc;
        private DateTime creacion_doc;
        private string estado_doc;

        //SET'S y GET'S
        public int _id_doc
        {
            set
            {
                id_doc = value;
            }
            get
            {
                return id_doc;
            }
        }
        public string _nombre_doc
        {
            set
            {
                nombre_doc = value;
            }
            get
            {
                return nombre_doc;
            }
        }
        public string _descripcion_doc
        {
            set
            {
                descripcion_doc = value;
            }
            get
            {
                return descripcion_doc;
            }
        }
        public string _estado_doc
        {
            set
            {
                estado_doc = value;
            }
            get
            {
                return estado_doc;
            }
        }
    }
}

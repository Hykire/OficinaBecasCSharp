using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Especialidad
    {
        private int id_esp;
        private string nomb_esp;

        public int _id_esp
        {
            set
            {
                id_esp = value;
            }
            get
            {
                return id_esp;
            }
        }

        public string _nomb_esp
        {
            set
            {
                nomb_esp = value;
            }
            get
            {
                return nomb_esp;
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Beca
    {
        private int _id_beca;
        private string _nombre_beca;
        private string _descripcion;
        private string financiador;
        private DateTime fechaConvocatoria;

        public override string ToString() { return _nombre_beca; }

        public int Id_beca { get => _id_beca; set => _id_beca = value; }
        public string Nombre_beca { get => _nombre_beca; set => _nombre_beca = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Financiador { get => financiador; set => financiador = value; }
        public DateTime FechaConvocatoria { get => fechaConvocatoria; set => fechaConvocatoria = value; }
    }
}

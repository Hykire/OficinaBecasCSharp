namespace Modelo
{
    public class Financiador
    {
        private int id_financiador;
        private string nombre_finan;
        private string razonSocial;
        private long RUC;
        private string tipo_institucion;
        private string pag_web;
        private string email;
        private int telefono;

        public Financiador()
        {
        }

        public int _id_financiador
        {
            set
            {
                id_financiador = value;
            }
            get
            {
                return id_financiador;
            }
        }

        public string _nombre_finan
        {
            set
            {
                nombre_finan = value;
            }
            get
            {
                return nombre_finan;
            }
        }

        public string _razonSocial
        {
            set
            {
                razonSocial = value;
            }
            get
            {
                return razonSocial;
            }
        }

        public long _ruc
        {
            set
            {
                RUC = value;
            }
            get
            {
                return RUC;
            }
        }

        public string _tipo_institucion
        {
            set
            {
                tipo_institucion = value;
            }
            get
            {
                return tipo_institucion;
            }
        }
        public string _pag_web
        {
            set
            {
                pag_web = value;
            }
            get
            {
                return pag_web;
            }
        }
        public string _email
        {
            set
            {
                email = value;
            }
            get
            {
                return email;
            }
        }
        public int _telefono
        {
            set
            {
                telefono = value;
            }
            get
            {
                return telefono;
            }
        }
    }
}
using System;

namespace Modelo
{
    class Becado
    {
        private string nombreApoderado;
        private string dirApoderado;
        private string telefApoderado;
        private string correoApoderado;
        private string expediente;
        private string estado;

        public Becado(){}

        public void setNombreApoderado(string nombreApoderado){
            this.nombreApoderado = nombreApoderado;
        }

        public string getNombreApoderado(){
            return nombreApoderado;
        }

        public string getDirApoderado(){
            return dirApoderado;
        }

        public void setDirApoderado(string dirApoderado){
            this.dirApoderado = dirApoderado;
        }


        public void setTelefApoderado(string telefApoderado){
            this.telefApoderado = telefApoderado;
        }

        public string getTelefApoderado(){
            return telefApoderado;
        }

        public void setCorreoApoderado(string correoApoderado){
            this.correoApoderado = correoApoderado;
        }

        public string getCorreoApoderado(){
            return correoApoderado;
        }

        public void setExpediente(string expediente){
            this.expediente = expediente;
        }

        public string getExpediente(){
            return expediente;
        }

        public void setEstado(string estado){
            this.estado = estado;
        }

        public string getEstado(){
            return estado;
        }
    }
}

namespace Modelo;
public class Financiador {
    private string idFinanciador;
    private string nombre;
    private string razonSocial;
    private string RUC;

    public Financiador() {
    }
    
    public string getIdFinanciador() {
        return idFinanciador;
    }

    public void setIdFinanciador(string idFinanciador) {
        this.idFinanciador = idFinanciador;
    }

    public string getNombre() {
        return nombre;
    }

    public void setNombre(string nombre) {
        this.nombre = nombre;
    }

    public string getRazonSocial() {
        return razonSocial;
    }

    public void setRazonSocial(string razonSocial) {
        this.razonSocial = razonSocial;
    }

    public string getRUC() {
        return RUC;
    }

    public void setRUC(string RUC) {
        this.RUC = RUC;
    }
    
    
}
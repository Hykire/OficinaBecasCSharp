namespace Modelo
public class Postulacion {
    private string idPostulacion;
    private Persona Postulante;
    private DateTime fechaRegistrada;
    private Beca Beca;

    public Postulacion() {
    }
    
    public string getIdPostulacion() {
        return idPostulacion;
    }

    public void setIdPostulacion(string idPostulacion) {
        this.idPostulacion = idPostulacion;
    }

    public Persona getPostulante() {
        return Postulante;
    }

    public void setPostulante(Persona Postulante) {
        this.Postulante = Postulante;
    }

    public DateTime getFechaRegistrada() {
        return fechaRegistrada;
    }

    public void setFechaRegistrada(DateTime fechaRegistrada) {
        this.fechaRegistrada = fechaRegistrada;
    }

    public Beca getBeca() {
        return Beca;
    }

    public void setBeca(Beca Beca) {
        this.Beca = Beca;
    }
}
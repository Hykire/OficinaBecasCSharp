using System;
using System.Collections.Generic;
public class Administrador : Persona{
	private DateTime fechaContrato;
	private List<Solicitud> solicitudesAprobadas;
	private List<Solicitud> solicitudesRechazadas;
	
	public Administrador(){
		solicitudesAprobadas = new List<Solicitud>();
		solicitudesRechazadas = new List<Solicitud>();
	}
	
	public DateTime FechaContrato{
		set{
			fechaContrato = value;
		}
		get{
			return fechaContrato;
		}
	}
	
	public List<Solicitud> SolicitudesAprobadas{
		set{
			solicitudesAprobadas = value;
		}
		get{
			return solicitudesAprobadas;
		}
	}
	
	public List<Solicitud> SolicitudesRechazadas{
		set{
			solicitudesRechazadas = value;
		}
		get{
			return solicitudesRechazadas;
		}
	}
	
	public void aprobarSolicitud(Solicitud solicitud);
	
	public void rechazarSolicitud(Solicitud solicitud);
	
	public void registrarBecario();
}
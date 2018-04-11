public class Postulante : Persona{
	private float promedio;
	private float craest;
	private int ciclo;
	private float porcentajeMerito;
	private int escala;
	
	public Postulante(){}
	
	public float Promedio{
		set{
			promedio = value;
		}
		get{
			return promedio;
		}
	}
	
	public float Craest{
		set{
			craest = value;
		}
		get{
			return craest;
		}
	}
	
	public int Ciclo{
		set{
			ciclo = value;
		}
		get{
			return ciclo;
		}
	}
	
	public float PorcentajeMerito{
		set{
			porcentajeMerito = value
		}
		get{
			return porcentajeMerito;
		}
	}
	
	public int Escala{
		set{
			escala = value;
		}
		get{
			return escala;
		}
	}
}
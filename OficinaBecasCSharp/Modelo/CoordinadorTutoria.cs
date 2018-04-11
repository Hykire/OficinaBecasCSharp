using System.Collections.Generic;
public class CoordinadorTutoria : Persona{
	private List<Tutor> tutores;
	
	public CoordinadorTutoria(){
		tutores = new List<Tutor>();
	}
	
	public List<Tutor> Tutores{
		set{
			tutores = value;
		}
		get{
			return tutores;
		}
	}
	
}
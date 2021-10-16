using System;

namespace aux121
{
	class Persona{

		protected string nombre,ci,fechanac;

		//->Getters & Setters

		public string getNombre(){
			return nombre;
		}
		public void setNombre(string n){
			nombre=n;
		}
		public string getCi(){
			return ci;
		}
		public void setCi(string c){
			ci=c;
		}
		public string getFechaNac(){
			return fechanac;
		}
		public void setFechaNac(string f){
			fechanac=f;
		}

		//->Constructors
		public Persona(){
			nombre="Andres";
			ci="123";
			fechanac="21/09/1999";
		}

		public Persona(string n, string c, string f){
			nombre=n;
			ci=c;
			fechanac=f;
		}

		//->Methods

		public virtual void show(){
			Console.WriteLine("-------------------------");
			Console.WriteLine("Nombre:"+nombre);
			Console.WriteLine("ci: "+ci);
			Console.WriteLine("Fecha nacimiento: "+fechanac);
		}

		public bool verify(Persona x){
			if(this.nombre==x.getNombre()){
				return true;
			}else{
				return false;
			}
		}
	}

}
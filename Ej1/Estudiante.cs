using System;

namespace aux121
{
	class Estudiante:Persona{
		private int ru;
		private string fingreso;

		//->Getters & Setters
		public int getRu(){
			return ru;
		}
		public void setRu(int x){
			ru=x;
		}
		public string getFingreso(){
			return fingreso;
		}
		public void setFingreso(string f){
			fingreso=f;
		}

		//->Constructors

		public Estudiante(){
			ru=456;
			fingreso="09/02/2019";
		}

		public Estudiante(string n,string c,string f,int r,string fing):base(n,c,f){
			ru=r;
			fingreso=fing;
		}

		//->Methods

		public override void show()
		{
			base.show();
			Console.WriteLine("RU: "+ru);
			Console.WriteLine("Fecha ingreso: "+fingreso);
		}

		public bool age(){
			
			int	ageEst=int.Parse(fechanac.Substring(6,4));

			if(ageEst<=2003){
				return true;
			}else{
				return false;
			}
		}
	}
}
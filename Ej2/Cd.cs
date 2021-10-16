using System;
namespace Ej2
{
	class Cd:Publicacion{
		private int tiempRep;
			
		//->Getters & Setters
		public int getTiempoRep(){
			return tiempRep;
		}
		public void setTiempoRep(int t){
			tiempRep=t;
		}

		//->Constructors
		public Cd():base(){
			tiempRep=4;
		}
		public Cd(string t,int p, int tiemp):base(t,p){
			tiempRep=tiemp;
		}

		//->Methods
		public override void show()
		{
			base.show();
			Console.WriteLine("Tiempo de reproducción: "+tiempRep+" hrs");
		}
	}
}
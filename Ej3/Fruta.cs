using System;
namespace Ej3
{
	class Fruta:Alimento{
		private double cantAzucares;
		//->Getters & Setters
		//->Constructor 
		public Fruta(string n,int p,int nv,int nm,int ca):base(n,p,nv,nm){
			cantAzucares=ca;
		}
		//->Methods
		public override void show()
		{
			base.show();
			Console.WriteLine("Cantidad azucares: "+cantAzucares);
		}
	}
}
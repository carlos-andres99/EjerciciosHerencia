using System;
namespace Ej3
{
	class Carne:Alimento{
		private string tipo;
		//->Getters & Setters
		//->Constructor 
		public Carne(string n,int p,int nv,int nm,string t):base(n,p,nv,nm){
			tipo=t;
		}
		//->Methods
		public override void show()
		{
			base.show();
			Console.WriteLine("Tipo: "+tipo);
		}
	}
}
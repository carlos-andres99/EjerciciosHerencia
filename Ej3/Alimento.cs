using System;
namespace Ej3
{
	class Alimento{
		protected string nombre;
		protected int precio,nroVitaminas,nroMinerales;
		protected string[] vitaminas,minerales;

		//->Getters & Setters
		//->Constructor 
		public Alimento(string n,int p,int nv,int nm){
			nombre=n;
			precio=p;
			nroVitaminas=nv;
			nroMinerales=nm;
			vitaminas=new string[nroVitaminas];
			minerales=new string[nroMinerales];

			for(int i=0; i<nroVitaminas ;i++){
				Console.Write("Int. vitamina: ");
				vitaminas[i]=Console.ReadLine();
			}
			for(int j=0; j<nroMinerales ;j++){
				Console.Write("Int. mineral: ");
				minerales[j]=Console.ReadLine();
			}

		}

		//->Methods
		
		public virtual void show(){
			Console.WriteLine("------------------");
			Console.WriteLine("Nombre: "+nombre);
			Console.WriteLine("Precio: "+precio+"Bs");
			Console.WriteLine("Vitaminas: ");
			for(int i=0; i<nroVitaminas ;i++){
				Console.Write(vitaminas[i]+" ");
			}
			Console.WriteLine("Minerales: ");
			for(int j=0; j<nroMinerales ;j++){
				Console.WriteLine(minerales[j]+" ");
			}
			Console.WriteLine();
		}

		public bool verifyV(Alimento x){
			int cont=0;
			if(this.nroVitaminas==x.nroVitaminas){
				for(int a=0; a<this.nroVitaminas ;a++){
					for(int b=0; b<x.nroVitaminas ;b++){
						if(this.vitaminas[a]==x.vitaminas[b]){
							cont++;
						}
					}
				}
			}
			if(cont==nroVitaminas){
				return true;
			}else{
				return false;
			}
		}

		public bool verifyP(Alimento x){
			if(this.precio==x.precio){
				return true;
			}else{
				return false;
			}
		}

		public void minerals(Alimento x){
			int cont=0;
			for(int a=0; a<this.nroMinerales ;a++){
				for(int b=0; b<x.nroMinerales ;b++){
					if(this.minerales[a]==x.minerales[b]){
						Console.WriteLine(this.minerales[a]);
						cont++;
					}
				}
			}
			if(cont==0){
				Console.WriteLine("No tienen minerales en común");
			}
		}
	}
}
using System;
namespace Ej2
{
	class Libro:Publicacion{
		private int nroPag;

			
		//->Getters & Setters
		public int getNroPag(){
			return nroPag;
		}
		public void setNroPag(int n){
			nroPag=n;
		}

		//->Constructors
		public Libro():base(){
			nroPag=300;
		}
		public Libro(string t,int p,int n):base(t,p){
			nroPag=n;
		}

		//->Methods	
		public override void show()
		{
			base.show();
			Console.WriteLine("Nro Pag: "+nroPag+" Pags.");
		}

		public bool verify(Cd c){
			if(this.titulo==c.getTitulo()){
				return true;
			}else{
				return false;
			}
	
		}
	}
}
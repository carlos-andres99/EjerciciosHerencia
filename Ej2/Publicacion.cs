using System;
namespace Ej2
{
	class Publicacion{
		protected string titulo;
		protected int precio;
		
		//->Getters & Setters
		public string getTitulo(){
			return titulo;
		}
		public void setTitulo(string t){
			titulo=t;
		}
		public int getPrecio(){
			return precio;
		}
		public void setPrecio(int p){
			precio=p;
		}

		//->Constructors
		public Publicacion(){
			titulo="El principito";
			precio=80;
		}
		public Publicacion(string t, int p){
			titulo=t;
			precio=p;

		}

		//->Methods

		public virtual void show(){
			Console.WriteLine("-------------------");
			Console.WriteLine("Titulo: "+titulo);
			Console.WriteLine("Precio: "+precio+"Bs");
		}

		public int totalPrice( Publicacion y, Publicacion z){
			int price=this.precio+y.precio+z.precio;
			return price;
		}


	}
}
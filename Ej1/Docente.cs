using System;

namespace aux121
{
	class Docente:Persona{
		private int item, cargaHor;
		private string categoria;

		//-> Getters & Setters

		public int getItem(){
			return item;
		}
		public void setItem(int x){
			item=x;
		}
		public int getCargaHor(){
			return cargaHor;
		}
		public void setCargaHor(int x){
			cargaHor=x;
		}
		public string Getcategoria(){
			return categoria;
		}
		public void setCategoria(string c){
			categoria=c;
		}

		//-->Constructors
		
		public Docente(){
			item=456;
			cargaHor=2;
			categoria="Titular";
		}

		public Docente(string n, string c, string f,int i, int carg, string cat):base(n,c,f){
			item=i;
			cargaHor=carg;
			categoria=cat;
		}

		//--->Methods

		public override void show(){
			base.show();
			Console.WriteLine("Item: "+item);
			Console.WriteLine("Carga horaria: "+cargaHor);
			Console.WriteLine("Categoria: "+categoria);
		}

		public void showD(Docente x){
			if(this.cargaHor>x.cargaHor){
				this.show();
			}else{
				x.show();
			}
		}


	}
}

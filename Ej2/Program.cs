using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1=new Libro("El principito",100,400);
            Libro libro2=new Libro("cien años de soledad",150,471);
            Cd cd=new Cd("Romeo y Julieta",90,8);
            libro1.show();
            libro2.show();
            cd.show();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("El precio total es: "+libro1.totalPrice(libro2,cd)+"Bs");
            Console.WriteLine(libro1.verify(cd));
        }
    }
}

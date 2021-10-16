using System;

namespace aux121
{
    class Program
    {
        static void Main(string[] args)
        {
          Docente docente1=new Docente("Armando","1234","09/08/1997",345,2,"Titular");
          Docente docente2=new Docente("Julio","789","06/02/1994",678,4,"suplente");
          Estudiante estudiante1=new Estudiante("Andres","9234","01/04/1999",2970,"03/02/2019");
          Estudiante estudiante2=new Estudiante("Juan","4652","05/01/2001",9638,"02/02/2018");


          Console.WriteLine("Son la misma persona: "+docente1.verify(estudiante1));
          Console.WriteLine("Es mayor de edad: "+estudiante1.age());
          Console.WriteLine("Es mayor de edad: "+estudiante2.age());
          docente1.showD(docente2);
        }
    }
}

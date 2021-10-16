using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Verdura lechuga=new Verdura("lechuga",6,3,1);
            Fruta platano=new Fruta("plátano",5,4,3,3);
            Carne cerdo=new Carne("Cerdo",20,4,3,"carne roja");
            Console.WriteLine(lechuga.verifyP(platano));

        }
    }
}

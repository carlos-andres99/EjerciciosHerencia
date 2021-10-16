using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Verdura lechuga=new Verdura("lechuga",6,2,1);
            Fruta platano=new Fruta("plátano",5,2,3,3);
            Carne cerdo=new Carne("Cerdo",20,2,3,"carne roja");
            lechuga.show();
            platano.show();
            cerdo.show();
            Console.WriteLine("tienen las mismas vitaminas: ");
            Console.WriteLine(lechuga.verifyV(platano));
            Console.WriteLine("Tienen el mismo precio:");
            Console.WriteLine(platano.verifyP(lechuga));
            Console.WriteLine("minerales en común:");
            cerdo.minerals(lechuga);
        }
    }
}

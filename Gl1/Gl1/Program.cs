using System;

namespace Aosk
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kernel kern = new Kernel();
            Console.WriteLine("###########################################################");
            Console.WriteLine();
            Console.WriteLine("Bienvenue sur Aosk, un logiciel de traitemenent de données.");
            Console.WriteLine();
            Console.WriteLine("###########################################################");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            string msg = "";
            while(!msg.Equals("Exit")) {
                Console.Write("Saisissez votre commande : ");
                msg = Console.ReadLine();
                msg = kern.interact(msg);
                Console.WriteLine(msg);
                Console.WriteLine();
            }
        }
    }
}

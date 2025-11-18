using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papir_kamen_makaze
{
    class Program
    {
        static void Main(string[] args)
        {
            string igrac, kompjuter;
            Random rand = new Random();

            Console.WriteLine("Igraj protiv kompjutera- papir, kamen, makaze");
            Console.Write("\nUnesi svoj izbor: ");
            igrac = Console.ReadLine().ToLower();

            int broj = rand.Next(1, 4);

            if (broj == 1) kompjuter = "kamen";
            else if (broj == 2) kompjuter = "papir";
            else kompjuter = "makaze";

            Console.WriteLine("\nKompjuter je izabrao: " + kompjuter);

            if (igrac == kompjuter)
            {
                Console.WriteLine("Nerešeno!");
            }
            else if (igrac == "kamen" && kompjuter == "makaze" ||
                     igrac == "makaze" && kompjuter == "papir" ||
                     igrac == "papir" && kompjuter == "kamen")
            {
                Console.WriteLine("Pobedio si!");
            }
            else
            {
                Console.WriteLine("Izgubio si!");
            }

            Console.WriteLine("\nPritisni Enter za kraj");

        }
    }
}

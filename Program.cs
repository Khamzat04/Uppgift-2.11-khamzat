using System;
namespace Uppgift_2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur lång hoppade Elin i meter");
            string x = Console.ReadLine();          
            Console.WriteLine("hur långt har Alma hoppad i meter");
            string z = Console.ReadLine();

            int y = int.Parse(z);
            Console.WriteLine("Elin hoppade "+ x);

        }
    }
}
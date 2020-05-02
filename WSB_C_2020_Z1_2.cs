using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {

            double silnia = 1; 
           
            for (byte i = 1; i <= 9; i++)
            {
                silnia = silnia * i; 
                Console.WriteLine("Wynik to" + silnia);
            }

            for (byte i = 1; i <= 12; i++)
            {
                silnia = silnia * i;
                    Console.WriteLine("Wynik to" + silnia);
            }

            for (int i = 1; i <= 20; i++)
            {
                silnia = silnia * i;
                Console.WriteLine("Wynik to" + silnia);
            }
        }

        Console.ReadKey();
    }
}

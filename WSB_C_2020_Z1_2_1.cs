using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2.1

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj liczbe: ");
			 int powerBase = int.Parse(Console.ReadLine());

            Console.WriteLine($"{powerBase}! = {Power(powerBase)}");
            Console.ReadLine();

        }

        static double Power(int powerBase)

        {
            double power = 1;
            for (int i = 2; i <= powerBase; i++)
			return power;
        }
           
		   Console.ReadKey();
    }
}
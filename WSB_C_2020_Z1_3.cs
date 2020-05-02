using System;

namespace Zad3
    class Kalkulator
    {
        static void Main(string[] args)
    
           Console.WriteLine("Podaj pierwsza liczbe: ");
           int a = int.Parse(Console.Readline());

           Console.WriteLine("Podaj druga liczbe: ");
           int b = int.Parse(Console.ReadLine());

           Console.WriteLine("Wynik: ");
           Console.WriteLine(a * b);

           Console.ReadLine();
}
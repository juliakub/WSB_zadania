using System;

namespace Zad3.1

    class Kalkulator
	{
       static void Main(string[] args)
          
        Console.WriteLine("Podaj pierwsza liczbe: ");
       int a = int.Parse(Console.Readline());

       Console.WriteLine("Podaj druga liczbe: ");
       int b = int.Parse(Console.ReadLine());

       Console.WriteLine("Wynik: ");
       Console.WriteLine(a * b);

       Console.WriteLine("Jakie dzialanie chcesz wykonac: ");
       string operation = Console.ReadLine();
       if (operation == "+")
         {
           Console.WriteLine(a + b);
         }

       else if (operation == "-")
         {
           Console.WriteLine(a - b);
         }
     
       else
         {
          Console.WriteLine("Ta operacja jest nieznana");
         }

    Console.ReadLine();
     }
using System;

namespace Zad3.2

    class Kalkulator
	{
       static void Main(string[] args)
          
        Console.WriteLine("Podaj pierwsza liczbe: ");
       int a = int.Parse(Console.Readline());

       Console.WriteLine("Podaj druga liczbe: ");
       int b = int.Parse(Console.ReadLine());

       Console.WriteLine("Jakie dzialanie chcesz wykonac (+ | - | * | /): ");
  
    switch (operation)
    {
      case "+":
        Console.WriteLine(a + b);
        break;

      case "-":
        Console.WriteLine(a - b);
        break;

      case "*":
        Console.WriteLine(a * b);
        break;

      default:
         Console.WriteLine("Nieznane dzialanie");
         break;
     }

    Console.ReadLine();
}
using System;

namespace Zad4
{
    class Przywitanie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe: ");
            int a = int.Parse(Console.ReadLine());
            string operation;

            do
            {
                Console.WriteLine("Jaka operacje chcesz wykonac (+ | - | * | /) lub wpisz "n" aby zakonczyc program");
                operation = Console.ReadLine();

                if (operation == n)
                {
                    Console.WriteLine("Twoj wynik to")
                    break;
                }
            }

            Console.WriteLine("Podaj liczbe: ")
            int b = int.Parse(Console.ReadLine());

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


                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Nie mozna dzielic przez 0");
                    }

                    else
                    {
                        Console.WriteLine(a / b);
                    }
                    break;

                default:
                    Console.WriteLine("Nieznane dzialanie");
                    break;
            }
        }
    } while (OperationCanceledException != "n");

        Console.ReadLine();
}


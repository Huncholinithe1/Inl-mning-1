using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till IT-Högskolan!, skriv in ditt namn nedan.");
            String name = Console.ReadLine();
            Console.WriteLine($" Hej {name}");
            Console.WriteLine("Skriv sedan in din ålder så ska jag räkna ut vilket år du är född :)");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            int birthyear = 2024 - age;
            Console.WriteLine($"Du är {age} år gammal och du är född år {birthyear}");
            Console.WriteLine("Tryck på valfri kanpp för att stänga detta fönster. Adjö:)");
            Console.ReadKey();
        }
    }
    }


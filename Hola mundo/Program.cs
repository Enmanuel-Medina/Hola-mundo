using System;

namespace Hola_mundo
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo, Jose Enmanuel de este lado");

            Console.WriteLine("\nCual es tu nombre?");
            var nombre = Console.ReadLine();
            var datos = DateTime.Now;

            Console.WriteLine($"\n Hola,{nombre},y {datos:A} y {datos: r}!");
            Console.WriteLine("Precione una tecla para terminar");
            Console.ReadKey(true);
        }
    }
}

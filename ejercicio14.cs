using System;

namespace VariablesC_
{
    internal class ejercicio13
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la distancia en metros");
            double metros = Convert.ToDouble(Console.ReadLine());

            double kilometros = metros / 1000;

            double milimetros = metros * 1000;

            double centimetros = metros * 100;

            Console.WriteLine("Metros: " + metros + "\nKilometros: " + kilometros + "\nmilimetros: " + milimetros + "\ncentimetros: " + centimetros);

        }
    }
}

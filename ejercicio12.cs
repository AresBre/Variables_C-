using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

/*
namespace VariablesC_
{
    internal class ejercicio12
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el lado a: ");
            int a;
            if (int.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Ingrese el lado b: ");
                int b;
                if (int.TryParse(Console.ReadLine(), out b))
                {
                    double hipotenusa = CalcularHipotenusa(a, b);
                    Console.WriteLine("La hipotenusa es " + hipotenusa);
                }
                else
                {
                    Console.WriteLine("El input no es un número válido.");
                }
            }
            else
            {
                Console.WriteLine("El input no es un número válido.");
            }
        }

        static double CalcularHipotenusa(double a, double b)
        {
            double x = a * a + b * b;
            double y = x;

            while (true)
            {
                y = (y + x / y) / 2;
                if (Math.Abs(y * y - x) < 0.00001)
                {
                    break;
                }
            }

            return y;
        }
    }
}
*/
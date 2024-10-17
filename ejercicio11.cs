using System;

/*
namespace VariablesC_
{
    internal class ejercicio10
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            string input = Console.ReadLine();
            double numero;

            if (double.TryParse(input, out numero))
            {
                if (numero < 0)
                {
                    Console.WriteLine("No se puede calcular la raiz cuadrada de un numero negativo.");
                }
                else
                {
                    double raizCuadrada = CalcularRaizCuadrada(numero);
                    Console.WriteLine("La raiz cuadrada de " + numero + " es " + raizCuadrada);
                }
            }
            else
            {
                Console.WriteLine("El input no es un número válido.");
            }

        }

        static double CalcularRaizCuadrada(double numero)
        {
            double x = numero;
            double y = (x + 1) / 2;

            while (y < x)
            {
                x = y;
                y = (x + numero / x) / 2;
            }

            return x;
        }
    }
}
*/

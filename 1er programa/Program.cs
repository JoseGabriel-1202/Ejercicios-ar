using System;

namespace _1er_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[4];
            double suma = 0, media;
            int num;

            Console.Write("Ingrese 4 números para calcular su media" + "\n");

            for (num = 0; num < 4; num++)
            {
                Console.Write("\n" + "Ingrese el valor {0}: ", num + 1);
                numeros[num] = double.Parse(Console.ReadLine());
                suma += numeros[num];
            }

            media = suma / 4;
            Console.Write("\n" + "La media  es: {0}", media);

            Console.Write("\n" + "estos son los valores ingresados: ");
            for (num = 0; num < 4; num++)
            {
                Console.Write("\n" + "({0}) ", numeros[num]);
            }
            Console.ReadKey();
        }
    }
}

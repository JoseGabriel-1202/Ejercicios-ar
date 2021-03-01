using System;

namespace _1er_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma;
            int[] numeros = new int[4];

            for (int i = 0; i < 4; i++) 
            {
                Console.WriteLine("Digite un numero ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            suma = numeros[0] + numeros[1] + numeros[2] + numeros[3];
            suma /= 4;
            Console.WriteLine("la media es {0}: " , suma);

        }
    }
}

using System;

namespace _2do_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float[] numeros;
            
            numeros = new float[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("introduzca un numero real");

                 numeros[i] = float.Parse(Console.ReadLine());

            }
            Array.Sort(numeros);

            for (int i = 4; i > -1; i--)
            {
                
                    Console.WriteLine(numeros[i]);
            }
                
            
              
        }
    }
}

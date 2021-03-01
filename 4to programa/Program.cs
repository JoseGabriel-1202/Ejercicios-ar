using System;

namespace _4to_programa
{
    class Program
    {
        static void Main(string[] args)
         /*Un programa que pida al usuario 10 números y luego calcule y muestre cuál es el mayor de todos ellos.*/
        {
            int suma; 
            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite un numero ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            suma = numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4] + numeros[5] + numeros[6] + numeros[7] + numeros[8] + numeros[9];
            Console.Write("la suma es: " + suma);
            if (numeros[0] > numeros[1] && numeros[0] > numeros[2] && numeros[0] > numeros[3] && numeros[0] > numeros[4] && numeros[0] > numeros[5] && numeros[0] > numeros[6] && numeros[0] > numeros[7] && numeros[0] > numeros[8] && numeros[0] > numeros[9]) 
            {
                Console.Write("\n el numero mayor es: " + numeros[0]); 
            }
            if (numeros[1] > numeros[0] && numeros[1] > numeros[2] && numeros[1] > numeros[3] && numeros[1] > numeros[4] && numeros[1] > numeros[5] && numeros[1] > numeros[6] && numeros[1] > numeros[7] && numeros[1] > numeros[8] && numeros[1] > numeros[9])
            {
                Console.Write("\n el numero mayor es: " + numeros[1]);
            }
            if (numeros[2] > numeros[1] && numeros[2] > numeros[0] && numeros[2] > numeros[3] && numeros[2] > numeros[4] && numeros[2] > numeros[5] && numeros[2] > numeros[6] && numeros[2] > numeros[7] && numeros[2] > numeros[8] && numeros[2] > numeros[9])
            {
                Console.Write("\n el numero mayor es: " + numeros[2]);
            }
            if (numeros[3] > numeros[1] && numeros[3] > numeros[2] && numeros[3] > numeros[0] && numeros[3] > numeros[4] && numeros[3] > numeros[5] && numeros[3] > numeros[6] && numeros[3] > numeros[7] && numeros[3] > numeros[8] && numeros[3] > numeros[9])
            {
                Console.Write("\n el numero mayor es: " + numeros[3]);
            }
            if (numeros[4] > numeros[1] && numeros[4] > numeros[2] && numeros[4] > numeros[3] && numeros[4] > numeros[0] && numeros[4] > numeros[5] && numeros[4] > numeros[6] && numeros[4] > numeros[7] && numeros[4] > numeros[8] && numeros[4] > numeros[9])
            {
                Console.Write("\n el numero mayor es: " + numeros[4]);
            }
            if (numeros[5] > numeros[1] && numeros[5] > numeros[2] && numeros[5] > numeros[3] && numeros[5] > numeros[4] && numeros[5] > numeros[0] && numeros[5] > numeros[6] && numeros[5] > numeros[7] && numeros[5] > numeros[8] && numeros[5] > numeros[9])
            {
                Console.Write("\n el numero mayor es: " + numeros[5]);
            }
            if (numeros[6] > numeros[1] && numeros[6] > numeros[2] && numeros[6] > numeros[3] && numeros[6] > numeros[4] && numeros[6] > numeros[5] && numeros[6] > numeros[0] && numeros[6] > numeros[7] && numeros[6] > numeros[8] && numeros[6] > numeros[9])
            {
                Console.Write("\n el numero mayor es: " + numeros[6]);
            }
            if (numeros[7] > numeros[1] && numeros[7] > numeros[2] && numeros[7] > numeros[3] && numeros[7] > numeros[4] && numeros[7] > numeros[5] && numeros[7] > numeros[6] && numeros[7] > numeros[0] && numeros[7] > numeros[8] && numeros[7] > numeros[9])
            {
                Console.Write("\n el numero mayor es: " + numeros[7]);
            }
            if (numeros[8] > numeros[1] && numeros[8] > numeros[2] && numeros[8] > numeros[3] && numeros[8] > numeros[4] && numeros[8] > numeros[5] && numeros[8] > numeros[6] && numeros[8] > numeros[7] && numeros[8] > numeros[0] && numeros[8] > numeros[9])
            {
                Console.Write("\n el numero mayor es: " + numeros[8]);
            }
            if (numeros[9] > numeros[1] && numeros[9] > numeros[2] && numeros[9] > numeros[3] && numeros[9] > numeros[4] && numeros[9] > numeros[9] && numeros[0] > numeros[9] && numeros[0] > numeros[9] && numeros[0] > numeros[9] && numeros[9] > numeros[0])
            {
                Console.Write("\n el numero mayor es: " + numeros[9]);
            }
        }
    }
}

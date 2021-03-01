using System;

namespace _7mo_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            
            Console.Write("ingrese su nombre:\n" +
            "");
            nombre = Console.ReadLine();
            char[] letra_por_letra = nombre.ToCharArray();
            foreach (char n in letra_por_letra)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();

        }
    }
}


using System;

namespace _10mo_programa
{
    class Program
    {
        
        static void aNombre_y_edad()
        {
            string nombre;
            int edad;
            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Hola " + nombre + "tu edad es: "+ edad);
            if (edad >= 18) 
            {
                Console.WriteLine("usted es mayor de edad");
            }
        }
        static void Main(string[] args)
        {
            aNombre_y_edad();
        }

    }
}

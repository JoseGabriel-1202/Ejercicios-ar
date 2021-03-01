using System;

namespace _8vo_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crear un programa que defina un array de 5 elementos de tipo float que representen las alturas de 5 personas.
            Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.*/
            float suma;
            float promedio;
            
            float [] Alturas = { 5.8F , 5.8F , 6.7F, 7.6F, 5.8F};

            Console.WriteLine("Estas son las alturas: " +
              "\n" + Alturas[0] +
              "\n" + Alturas[1] + 
              "\n" + Alturas[2] + 
              "\n" + Alturas[3] +
              "\n" + Alturas[4]);

            suma = Alturas[0] + Alturas[1] + Alturas[2] + Alturas[3] + Alturas[4];

            promedio = suma / 5;

            Console.WriteLine("la altura promedio es: " + promedio);

            
            if (Alturas[0] < promedio && Alturas[1] < promedio)
            {
                Console.WriteLine("hay dos personas altas y tres bajas");

            }

            if  (Alturas[2] < promedio && Alturas[3] < promedio) 
            {
                Console.WriteLine("hay dos personas altas y tres bajas");
            }

            if (Alturas[3] < promedio && Alturas[4] < promedio)
            {
                Console.WriteLine("hay dos personas altas y tre bajas");
            }

        }   
        
    }
}

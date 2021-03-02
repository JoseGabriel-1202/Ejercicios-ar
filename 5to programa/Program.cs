using System;

namespace _5to_programa
{
    class Program
    {
        static void Main(string[] args)
        //Un programa que prepare espacio para un máximo de 100 nombres. 
        //El usuario deberá ir introduciendo un nombre cada vez, hasta que se pulse Intro sin teclear nada,
        //momento en el que dejarán de pedirse más nombres y se mostrará en pantalla la lista de los nombres que se han introducido.
        {
             string[] Nombre = new string[100];

             int abc = 0;
             do
             {
                 Console.WriteLine("Ingrese un nombre: ");
                abc += 1;
                 Nombre[abc] = Convert.ToString(Console.ReadLine());

            } 
             while (Nombre[abc] != "");

             
             for ( abc = 1; abc < 100; abc++)
             {
                 Console.WriteLine("posicion " + abc+ " : " + Nombre[abc]);
             }
             Console.ReadKey();
        
        }
    }
}


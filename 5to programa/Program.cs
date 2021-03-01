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

             int i = 0;
             do
             {
                 Console.WriteLine("Ingrese un nombre: ");

                 Nombre[i] = Console.ReadLine();

             } 
             while (Nombre[i] != "");

             Console.WriteLine("fin");


             for ( i = 0; i < 99; i++)
             {
                 Console.WriteLine("posicion " +i+ " : " + Nombre[i]);
             }
             Console.ReadKey();
        
        }
    }
}


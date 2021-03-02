using System;

namespace _6to_programa
{
    class Program
    {
        struct ficha
        {
            public string nombre_de_las_ficha;
            public long aPIXELES;
            public long alPIXELES;
            public long tamaño;
        };

        static void Main(string[] args)
        {

            ficha[] fichas = new ficha[700];
            int Sficha = 0;
            int US;
            int menu;
            string buscar_nom;
            long buscar_imagen;

            do
            {

                Console.WriteLine("\n" + "----Menu----");
                Console.WriteLine("1.- Nueva imagen.");
                Console.WriteLine("2.- Mostrar informacion de las imagenes.");
                Console.WriteLine("3.- Buscar imagen por tamaño.");
                Console.WriteLine("4.- Buscar imagen por nombre.");
                Console.WriteLine("5.- Salir del programa.");

                Console.Write("\n" + "Ingrese una opcion del menu: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {

                    case 1:
                        if (Sficha < 1000)
                        {
                            Console.Write("\n" + "Ingrese el nombre de la imagen: ");
                            fichas[Sficha].nombre_de_las_ficha = Console.ReadLine();
                            Console.Write("Ingrese la anchura de pixeles: ");
                            fichas[Sficha].aPIXELES = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese la altura de pixeles: ");
                            fichas[Sficha].alPIXELES = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el tamaño en KB: ");
                            fichas[Sficha].tamaño = int.Parse(Console.ReadLine());
                            Sficha++;
                        }
                        else
                        {
                            Console.WriteLine("\n" + "Ha alcanzado el máximo de espacio (700)");
                        }

                        break;

                    case 2:
                        for (US = 0; US < Sficha; US++)
                            Console.WriteLine("\n" + "Nombre: {0}; Anchura: {1} px; Altura: {2} px; Tamaño: {3} KB",
                            fichas[US].nombre_de_las_ficha, fichas[US].aPIXELES, fichas[US].alPIXELES, fichas[US].tamaño);
                        break;

                    case 3:
                        Console.Write("\n" + "Ingrese el tamaño de las imagenes que desea ver:");
                        buscar_imagen = int.Parse(Console.ReadLine());

                        for (US = 0; US < Sficha; US++)
                            if (fichas[US].tamaño >= buscar_imagen)
                                Console.WriteLine("\n" + "Nombre: {0}; Anchura: {1} px; Altura: {2} px; Tamaño: {3} KB",
                                fichas[US].nombre_de_las_ficha, fichas[US].aPIXELES, fichas[US].alPIXELES, fichas[US].tamaño) ;
                        break;

                    case 4:
                        Console.Write("\n" + "Ingrese el nombre de las imagenes que desea ver:");
                        buscar_nom = Console.ReadLine();

                        for (US = 0; US < Sficha; US++)
                            if (fichas[US].nombre_de_las_ficha == buscar_nom)
                                Console.WriteLine("\n" + "Nombre: {0}; Anchura: {1} px; Altura: {2} px; Tamaño: {3} KB",
                                fichas[US].nombre_de_las_ficha, fichas[US].aPIXELES, fichas[US].alPIXELES, fichas[US].tamaño);
                        break;

                    case 5:
                        Console.WriteLine("\n" + "Fin del programa");
                        break;

                    default:
                        Console.WriteLine("\n" + "Esta opcion no esta en el menu.");
                        break;

                }
                Console.ReadKey();

            } while (menu != 0);
        }
    }
}

using System;

namespace _3er_programa
{
    class Program
    {
        static void Main(string[] args)
        /*Un programa que almacene en un array el número de días que tiene cada mes (supondremos que es un año no bisiesto), 
       pida al usuario que le indique un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que tiene ese mes.*/
        {
            string[] meses_del_año = {"enero","febrero","marzo","abril","mayo","junio","julio","agosto","septiembre","octubre","nobiembre","diciembre" };
            

            int as1 = 0;
            do
            {

                Console.WriteLine("hay 12 meses del año, de cual mes necesita saber cuantos dias tiene");
                Console.WriteLine("digite un numero del 1 al 11");
                as1 = Convert.ToInt32(Console.ReadLine());
                switch (as1)
                {
                    case 0:
                        Console.WriteLine(meses_del_año[0] + "tiene 31 dias");

                        break;

                    case 1:
                        Console.WriteLine( meses_del_año[1]+ "tiene 28 dias");
                        break;

                    case 2:
                        Console.WriteLine(meses_del_año[2] + "tiene 31 dias");
                        break;
                    case 3:
                        Console.WriteLine(meses_del_año[3] + " tiene 30 dias");
                        break;

                    case 4:
                        Console.WriteLine(meses_del_año[4] + " tiene 31 dias");
                        break;

                    case 5:
                        Console.WriteLine(meses_del_año[5] + " tiene 30 dias");
                        break;
                    case 6:
                        Console.WriteLine(meses_del_año[6] + " tiene 31 dias");
                        break;
                    case 7:
                        Console.WriteLine(meses_del_año[7] + " tiene 31 dias");
                        break;
                    case 8:
                        Console.WriteLine(meses_del_año[8]+" tiene 30 dias");
                        break;
                    case 9:
                        Console.WriteLine(meses_del_año[9] + " tiene 31 dias");
                        break;

                    case 10:
                        Console.WriteLine(meses_del_año[10]+" tiene 30 dias");
                        break;
                    case 11:
                        Console.WriteLine(meses_del_año[11]+" tiene 31 dias");
                        break;
                    default:
                        Console.WriteLine("ese numero no esta dentro de las opciones");
                        break;

                }
            }
            while (as1 != 12);
            Console.WriteLine("usted ha finalizado");


        }
    }
}

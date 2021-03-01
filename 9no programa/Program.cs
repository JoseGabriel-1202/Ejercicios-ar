using System;

namespace _9no_programa
{
    class TablaMultiplicar
    {
        public void CargarValor()
        {
            int valor;
            string linea;
            do
            {
                Console.Write("teclee un valor (-1 para finalizar):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != -1)
                {
                    Calcular(valor);
                }
            } while (valor != -1);
        }

        public void Calcular(int v)
        {
            for (int f = v; f <= v * 10; f = f + v)
            {
                Console.Write(f + "-");
            }
            Console.WriteLine();
        }

        
        
    }
}

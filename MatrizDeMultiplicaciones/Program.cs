using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizDeMultiplicaciones
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("\t*********** Estructura de Matriz de multiplicaciones ***********");
            Console.WriteLine();

            int cont = 0;
            int cont2 = 0;


            for (int i = 0; i < 11; i++)//Filas
            {

                cont = 0;
                for (int j = 0; j < 11; j++)//columnas
                {
                    if (cont == 0)
                        Console.Write("{0}\t", i);

                    else
                        if(cont2 == 0)
                            Console.Write("{0}\t", j);
                        else
                            Console.Write("0\t");

                    cont++;
                }
                cont2++;

                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine("\t\t*********** Matriz de multiplicaciones ***********");
            Console.WriteLine();

            int cont1 = 0;
            int cont3 = 0;


            for (int i = 0; i < 11; i++)//Filas
            {

                cont1 = 0;
                for (int j = 0; j < 11; j++)//columnas
                {
                    if (cont1 == 0)
                        Console.Write("{0}\t", i);

                    else
                        if (cont3 == 0)
                        Console.Write("{0}\t", j);
                    else
                        Console.Write("{0}\t",i*j);

                    cont1++;
                }
                cont3++;

                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}

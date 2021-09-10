using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecto15_contarAprobados
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 1;
            int nota = 0;
            int mayores = 0;
            int menores = 0;

            while (x<=10)
            {
                Console.Write("Ingrese la Nota  0{0} :", x);
                nota = int.Parse(Console.ReadLine());
                if (nota >=7)
                {
                    mayores = mayores + 1;
                }
                else
                {
                    menores = menores + 1;
                }

                x = x + 1;
            }

            Console.WriteLine("Notas Mayores es : {0} ", mayores);
            Console.WriteLine("Notas Menores es : {0} ", menores);

            Console.Read();
        }
    }
}

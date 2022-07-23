using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_em_csharpe__equação_do_2º_grau_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, delta;
            double raiz1, raiz2;

            Console.WriteLine("informe os valores:");

            Console.WriteLine("a: ");
            a = int.Parse (Console.ReadLine());

            Console.WriteLine("b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("c: ");
            c = int.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;


            if (delta>0)
            {
                raiz1 = -b + Math.Sqrt (delta)/2 * a;

                raiz2 = +b + Math.Sqrt(delta) / 2 * a;

                Console.WriteLine($"raiz: {raiz1}  raiz2:{raiz2}");
            }

            else if(delta == 0)
            {
                raiz1 = -b + Math.Sqrt(delta) / 2 * a;
                Console.WriteLine($"raiz: {raiz1}");
            }

            else
            {
                Console.WriteLine("não há raizes reais");
            }

            Console.ReadKey();
        }
    }
}

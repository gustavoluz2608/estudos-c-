using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudos_em_c_sharpe_duplo_for
{
    internal class Program
    {
        
        static int[] preencheVetor(int n)
        {
            int[] v= new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1}º elemento do vetor: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            return v;
        }
        
        static void comparaVetor(int[]v1, int[] v2)
        {
            for(int i = 0; i < v1.Length; i++)
            {
                for( int j = 0; j < v2.Length; j++)
                {
                    if (v1[i] == v2[j])
                        Console.WriteLine(v1[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            int n1, n2;
            int[] v1, v2;

            Console.WriteLine("Informe o tamanho do primeiro vetor: ");
            n1=int.Parse(Console.ReadLine());

            Console.WriteLine("Informe os elementos do primeiro vetor: ");
            v1 = preencheVetor(n1);


            Console.WriteLine("Informe o tamanho do segundo vetor: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe os elementos do segundo vetor: ");
            v2 = preencheVetor(n2);

            Console.WriteLine("Os elementos de intersecção são: ");

            comparaVetor(v1, v2);

            Console.ReadKey();


        }
    }
}

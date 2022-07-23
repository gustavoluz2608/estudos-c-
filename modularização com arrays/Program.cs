using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudos_em_c_shaerpe
{
    internal class Program
    {

        static int[] inverteVetor(int[]v)
        {
            int[] vi = new int[v.Length];
            int j = v.Length - 1;
            
            for(int i = 0; i < v.Length; i++)
            {
                vi[i] = v[j];
                j--;
            }
            return vi;
        }

        static int[] preencheVetor(int n)
        {
            int i;
            int[] v = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1}º elemento do vetor:");
                v[i] = int.Parse(Console.ReadLine());   
            }

            return v;
        }

        static void exibeVetor(int[] v)
        {
            for(int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
        }
        
        static void Main(string[] args)
        {
            int n, i;
            int[] v, vi;

            Console.WriteLine("Informe o tamanho do vetor: ");
            n=int.Parse(Console.ReadLine());

            Console.WriteLine("Informe os elementos do vetor: ");

            v = preencheVetor(n);

            vi = inverteVetor(v);

            Console.WriteLine("O vetor invertido é: ");

            exibeVetor(vi);

            Console.ReadKey();

        }
    }
}

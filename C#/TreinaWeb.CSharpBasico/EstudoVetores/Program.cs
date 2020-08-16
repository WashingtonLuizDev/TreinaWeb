using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meuVetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                meuVetor[i] = i + 1;
                Console.WriteLine("posição Nrº{0}: {1}", i, meuVetor[i]);
            }

            foreach (int numero in meuVetor)
            {
                Console.Write("{0} ", numero);
            }
            Console.WriteLine("\nO tamanho do meuVetor é {0}", meuVetor.Length);
            Console.ReadKey();
            
        }
    }
}

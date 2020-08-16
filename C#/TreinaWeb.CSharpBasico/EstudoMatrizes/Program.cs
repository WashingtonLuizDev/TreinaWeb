using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] MinhaMatriz = new int[2, 4];
            int numero = 0;
            for (int linha = 0; linha <= 1; linha++)
            {
                for (int coluna = 0; coluna <= 3; coluna++) {
                    MinhaMatriz[linha, coluna] = numero;
                    numero++;
                }
            }
            for (int linha = 0; linha <=1; linha++)
            {
                for (int coluna = 0; coluna <=3; coluna++)
                {
                    Console.WriteLine("Minha Matriz {0},{1} = {2}",linha, coluna, MinhaMatriz[linha,coluna]);
                }
            }
            Console.WriteLine("Quantidade de dimensões: {0}", MinhaMatriz.Rank);
            Console.WriteLine("Tamanho da matriz: {0}", MinhaMatriz.Length);
            Console.ReadKey();
        }

    }
}

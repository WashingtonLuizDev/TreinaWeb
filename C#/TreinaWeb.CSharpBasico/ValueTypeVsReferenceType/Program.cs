﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeVsReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Passagem por valor
            int numero1 = 3;
            int numero2 = numero1;

            numero1 = 5;
            Console.WriteLine("Passagem por Valor");
            Console.WriteLine("numero1 = {0}, numero2 = {1}", numero1, numero2);
            //Passagem por referencia
            Teste teste1 = new Teste();

            teste1.Quantidade = 3;

            Teste teste2 = teste1;
            Console.WriteLine("Passagem por referencia");
            teste1.Quantidade = 5;
            Console.WriteLine("teste1.Quantidade = {0}, teste2.quantidade = {1}", teste1.Quantidade, teste2.Quantidade);

            Teste teste3 = new Teste();

            teste3.Quantidade = 1;
            teste3.Pai = new Teste();
            teste3.Pai.Quantidade = 6;
            Console.WriteLine("Quantidade é {0}", teste3.Quantidade);
            Console.WriteLine("Quantidade do teste pai é {0}", teste3.Pai.Quantidade);
            Console.ReadKey();

        }

        class Teste {
            public int Quantidade;
            public Teste Pai;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConhecendoDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).ExecutarPrograma();
        }

        int LerInteiro() {
            Console.WriteLine("Digite um número: ");
            return int.Parse(Console.ReadLine());
        }

        int CalcularSoma(int num1, int num2) {
            int resultado = num1 + num2;
            return resultado;
        }

        void ExecutarPrograma() {
            int numero1 = LerInteiro();
            int numero2 = LerInteiro();
            int soma = CalcularSoma(numero1, numero2);
            Console.WriteLine("O ressultado da soma é {0}", soma);
            Console.ReadKey();
        }
    }
}

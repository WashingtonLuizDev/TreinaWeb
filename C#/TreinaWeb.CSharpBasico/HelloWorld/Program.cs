using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World");
            Console.ReadKey();
            Console.WriteLine"Hello World Again!");
            Console.ReadKey();
            Console.WriteLine("Hello TreinaWeb");
            Console.ReadKey();
            */
            int inteiro1 = 4;

            //Variavel de inferencia o compilador define o tipo da variavel
            var inteiro2 = 4;
            var nome = "TreinaWeb";

            Console.WriteLine("inteiro1 {0}", inteiro1);
            Console.WriteLine("inteiro2 {0}", inteiro2);
            Console.WriteLine("nome {0}", nome);

            dynamic minhaVariavel = 2;

            //minhaVariavel.
            Console.WriteLine("Inteiro1 + minhaVariavel = {0}", inteiro1 + minhaVariavel);
            minhaVariavel = "TreinaWeb";
            Console.WriteLine("minhaVariavel = {0}", minhaVariavel);
            Console.ReadKey();
        }
    }
}

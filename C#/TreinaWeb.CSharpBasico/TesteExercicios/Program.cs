using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TesteExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            var dia = Dias.Dom;
            Console.WriteLine(dia);
            string Nome = "Washington";
            Console.WriteLine(Nome.PadRight(50, ' ')+'.');
            Console.ReadKey();
        }

        public enum Dias: short
        {
            Dom = 1,
            Seg,
            Ter,
            Qua,
            Qui,
            Sex,
            Sab
        }
    }
}


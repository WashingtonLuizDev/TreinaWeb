using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "ABC";
            string string2 = "DEF";
            string string3 = "GHI";

            Console.WriteLine("Sem StringBuilder");
            Console.WriteLine("{0}", string1 + " " + string2 + " GHI");

            StringBuilder sb = new StringBuilder();
            sb.Append("Com StringBuilder");
            sb.Append("\n");
            sb.Append(string1);
            sb.Append(" ");
            sb.Append(string2);
            sb.Append(" ");
            sb.Append(string3);
            Console.WriteLine("{0}", sb.ToString());
            Console.ReadKey();
        }
    }
}

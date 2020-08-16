using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> listaNumeros = new List<int>();
            for (int i = 0; i <= 19; i++)
            {
                listaNumeros.Add(i);
            }
            //listaNumeros.Remove(5);
            listaNumeros.RemoveAt(2);
            listaNumeros.Reverse();
            Console.WriteLine("O número 15 está na posição {0} da lista.",listaNumeros.IndexOf(15));
            foreach (var Lista in listaNumeros)
            {
                Console.WriteLine("Número: {0}",Lista);
            }
            Console.WriteLine(listaNumeros.Count);
            */
            /*
            Dictionary<string, string> meuDicionario = new Dictionary<string, string>();
            meuDicionario.Add("Adicionar", "Adicionar significa Somar");
            meuDicionario.Add("Subtrair", "Subtrair significa diminuir");
            foreach (string chave in meuDicionario.Keys) {
                Console.WriteLine("{0} ==> {1}", chave, meuDicionario[chave]);
            }
            */
            Dictionary<int, string> meuDicionario = new Dictionary<int, string>();
            meuDicionario.Add(1, "Washington");
            meuDicionario.Add(2, "Janaina");
            foreach (int chave in meuDicionario.Keys) {
                Console.WriteLine("O cliente com código {0} é o Sr(a) {1}", chave, meuDicionario[chave]);
            }
            Console.ReadKey();
            
        }
    }
}

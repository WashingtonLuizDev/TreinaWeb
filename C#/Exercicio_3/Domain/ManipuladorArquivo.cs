using Exercicio_3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_3.Domain
{
    public class ManipuladorArquivo
    {
        /// <summary>
        /// Constante com o endereço do arquivo
        /// </summary>
        private static string EnderecoArquivo = AppDomain.CurrentDomain.BaseDirectory + "Produtos.txt";

        /// <summary>
        /// Faz a leitura do arquivo
        /// </summary>
        /// <returns>Retorna uma listagem com todos os produtos</returns>
        public static List<Produto> LerArquivo()
        {
            //Lista que será devolvida com todos os produtos contidos no arquivo
            List<Produto> produtoList = new List<Produto>();

            //Validação para saber se o arquivo existe
            if (!File.Exists(@EnderecoArquivo))
            {
                MessageBox.Show("Não foi localizado o arquivo com o cadastro dos produtos.");
                return new List<Produto>();
            }

            //Fazendo a leitura do arquivo 
            using (StreamReader streamReader = File.OpenText(@EnderecoArquivo))
            {
                //Enquanto existir linhas no arquivo deve fazer a leitura
                while (streamReader.Peek() >= 0)
                {
                    string linha = streamReader.ReadLine();

                    //Separando as linhas por | para adicionar no objeto de produtos
                    string[] linhaComSplit = linha.Split('|');

                    if (linhaComSplit.Count() == 3)
                    {
                        Produto produto = new Produto()
                        {
                            Nome = linhaComSplit[0],
                            Preco = Convert.ToDouble(linhaComSplit[1]),
                            Quantidade = Convert.ToDouble(linhaComSplit[2])
                        };

                        produtoList.Add(produto);
                    }
                }
            }
            return produtoList;
        }

        /// <summary>
        /// Grava os produtos no arquivo
        /// </summary>
        /// <param name="produtoList"></param>
        public static void EscreverArquivo(List<Produto> produtoList) 
        {
            using (StreamWriter streamWriter = new StreamWriter(EnderecoArquivo,false))
            {
                foreach (var produto in produtoList)
                {
                    string linha = string.Format("{0}|{1}|{2}", produto.Nome, produto.Preco.ToString(), produto.Quantidade.ToString());

                    streamWriter.WriteLine(linha);
                }
                streamWriter.Flush();
            }
        }
            
    }
}

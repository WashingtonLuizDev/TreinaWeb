using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico
{
    public class ManipuladorArquivos
    {
        /// <summary>
        /// Constante para armazenar o Arquivo
        /// </summary>
        private static string EnderecoArquivo = AppDomain.CurrentDomain.BaseDirectory + "Contatos.txt";
        /// <summary>
        /// Método responsável por fazer a leitura do arquivo
        /// </summary>
        /// <returns>Retorna uma lista com todos os contatos</returns>
        public static List<Contato> LerArquivo()
        {
            List<Contato> contatosList = new List<Contato>();

            //Caso o arquivo exista deve fazer a leitura do mesmo e preencher a lista
            if (File.Exists(@EnderecoArquivo))
            {
                using (StreamReader streamReader = File.OpenText(EnderecoArquivo))
                {
                    while (streamReader.Peek() >= 0)
                    {
                        string linha = streamReader.ReadLine();

                        string[] linhaComSlipt = linha.Split('|');

                        if (linhaComSlipt.Count() == 3)
                        {
                            Contato contato = new Contato();
                            contato.Nome = linhaComSlipt[0];
                            contato.Email = linhaComSlipt[1];
                            contato.NumeroTelefone = linhaComSlipt[2];

                            contatosList.Add(contato);
                        }
                    }
                }
            }
            return contatosList;
        }

        /// <summary>
        /// Método responsável por persistir os contatos no arquivo
        /// </summary>
        /// <param name="contatoList"></param>
        public static void EscreverArquivo(List<Contato> contatoList)
        {
            using (StreamWriter streamWriter = new StreamWriter(EnderecoArquivo, false))
            {
                foreach (var contato in contatoList)
                {
                    string linha = string.Format("{0}|{1}|{2}", contato.Nome, contato.Email, contato.NumeroTelefone);

                    streamWriter.WriteLine(linha);
                }
                streamWriter.Flush();
            }
        }
    }
}

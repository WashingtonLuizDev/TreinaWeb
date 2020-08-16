using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContatosTreinaWeb
{
    public class ManipuladorArquivos
    {
        //Constate com o diretório do arquivo
        private static string EnderecoArquivo = AppDomain.CurrentDomain.BaseDirectory + "contatos.txt";
        public static List<Contato> LerArquivo()
        {
            List<Contato> contatoList = new List<Contato>();
            //programação defensiva se faz necessário para ler o arquivo pois pode ocorrer dele não existir ainda
            if (File.Exists(EnderecoArquivo))
            {
                using (StreamReader sr = File.OpenText(EnderecoArquivo)) {
                    //Quando acabar os registros dentro do arquivo o peek irá retorna -1
                    while (sr.Peek() >= 0) {
                        string linha = sr.ReadLine();
                        //o split retorna um array com os valores separados pelo delimitador que você utilizou
                        string[] linhaComSplit = linha.Split('|');
                        //programação defensiva para verificar se o split contem as 3 casas necessárias(Nome,Email,NumeroTelefone)
                        if (linhaComSplit.Count() == 3) {
                            Contato contato = new Contato();

                            contato.Nome = linhaComSplit[0];
                            contato.Email = linhaComSplit[1];
                            contato.NumeroTelefone = linhaComSplit[2];
                            contatoList.Add(contato);
                        }
                    }
                }
            }
            return contatoList;
        }

        public static void EscreverArquivo(List<Contato> contatoList)
        {
            //programação defensiva não é necessária pois no momento da escrita do arquivo caso não exista ele cria o arquivo
            /*
             * Utilizando o using ele automaticamente faz o fechamento da conexão com o arquivo após a execução do código
            */
            using (StreamWriter sw = new StreamWriter(EnderecoArquivo, false))
            {
                foreach (Contato contato in contatoList)
                {
                    string linha = string.Format("{0}|{1}|{2}", contato.Nome, contato.Email, contato.NumeroTelefone);
                    sw.WriteLine(linha);
                }
                sw.Flush();
            }

        }
    }
}

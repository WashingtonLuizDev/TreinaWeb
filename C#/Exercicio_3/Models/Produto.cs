using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.Models
{
    /// <summary>
    /// Classe de produtos
    /// </summary>
    public class Produto
    {
        /// <summary>
        /// Nome do produto
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Preço do produto
        /// </summary>
        public double Preco { get; set; }
        /// <summary>
        /// Quantidade do produto
        /// </summary>
        public double Quantidade { get; set; }

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="preco"></param>
        /// <param name="quantidade"></param>
        public Produto(string nome = "", double preco = 0.0, int quantidade = 0)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        /// <summary>
        /// Sobreescrita do método ToString para devolver os produtos formatados.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} - {1} - Qtd: {2}", Nome, Preco.ToString("C"), Quantidade);
        }

    }
}

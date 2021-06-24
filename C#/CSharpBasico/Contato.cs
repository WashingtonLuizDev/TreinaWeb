using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico
{
    public class Contato
    {
        /// <summary>
        /// Atributo Nome
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Atributo Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Atributo Numero Telefone
        /// </summary>
        public string NumeroTelefone { get; set; }

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="numeroTelefone"></param>
        public Contato(string nome = "", string email = "", string numeroTelefone = "") {
            Nome = nome;
            Email = email;
            NumeroTelefone = numeroTelefone;
        }

        /// <summary>
        /// Sobrescrita do método para formatar corretamente na lista de contatos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} | {1} | {2}", Nome, Email, NumeroTelefone);
        }
    }
}

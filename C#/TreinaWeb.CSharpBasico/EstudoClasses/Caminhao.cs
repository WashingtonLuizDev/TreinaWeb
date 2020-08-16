using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    class Caminhao : Veiculo
    {
        public override string Abastecer()
        {
            return "O caminhão já foi abastecido...";
        }

        public override string Desligar()
        {
            return "O caminhão está desligado...";
        }

        public override string Ligar()
        {
            return "O caminhão está ligado...";
        }
    }
}

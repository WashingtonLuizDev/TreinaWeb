using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            carro.Marca = "Ferrari";
            carro.Nome = "F200";
            carro.NumeroPortas = 4;
            carro.Potencia = 1000.00;
            Dono donoJoao = new Dono();
            Dono donoMaria = new Dono();

            donoJoao.Nome = "João";
            donoJoao.Idade = 30;
            donoMaria.Nome = "Maria";
            donoMaria.Idade = 28;

            carro.AdicionarAntigoDono(donoJoao);
            carro.AdicionarAntigoDono(donoMaria);
            /*
            carro.AntigosDonos = new List<string>();
            carro.AntigosDonos.Add("Fernando da Silva");
            foreach (string nome in carro.AntigosDonos)
            {
                Console.WriteLine("Um dos antigos donos é {0}", nome);
            }
            */
            foreach (Dono dono in carro.GetAntigosDonos())
            {
                Console.WriteLine("Um dos antigos donos é: {0}, e sua idade é {1}", dono.Nome,dono.Idade);
            }
            Console.WriteLine(carro.Ligar());
            Console.WriteLine("A marca do carro é: {0} ", carro.Marca);
            Carro carro2 = new Carro("Astra");
            Console.WriteLine("Este outro carro se chama {0}", carro2.Nome);
            Carro carro3 = new Carro("Ford", 3);
            Console.WriteLine("Este outro carro é da marca {0} e tem {1} portas", carro3.Marca, carro3.NumeroPortas);
            Carro carro4 = new Carro(6);
            Console.WriteLine("Este carro tem {0} portas.", carro4.NumeroPortas);
            Carro carro5 = new Carro(nome: "ka", marca: "Ford");
            Console.WriteLine("Este carro é da marca {0}, nome {1} e tem {2} portas.", carro5.Marca, carro5.Nome, carro5.NumeroPortas);
            Carro carro6 = new Carro
            {
                Nome = "Astra",
                Marca = "GM",
                NumeroPortas = 4,
                Potencia = 2.0
            };
            Console.WriteLine("Agora, já este carro se chama {0}, é da macar {1}, possui {2} portas e tem potência de {3}",
                carro6.Nome,
                carro6.Marca,
                carro6.NumeroPortas,
                carro6.Potencia);

            Carro carro7 = new Carro();
            Console.WriteLine(carro7.Ligar());

            Moto moto1 = new Moto();
            moto1.Nome = "Titan";
            moto1.Marca = "Honda";
            moto1.Potencia = 150;
            moto1.CapacidadeTanque = 15;

            Console.WriteLine("Essa moto se chama {0}, da marca {1}, com potência de {2} e capacidade do tanque de {3}",moto1.Nome,moto1.Marca,moto1.Potencia,moto1.CapacidadeTanque);


            Veiculo meuCarro = new Carro();
            Veiculo minhaMoto = new Moto();

            Console.WriteLine("Ligando o carro: {0} ",meuCarro.Ligar());
            Console.WriteLine("Ligando a moto: {0} ", minhaMoto.Ligar());

            Console.WriteLine("Desligando o carro: {0} ", meuCarro.Desligar());
            Console.WriteLine("Desligando a moto: {0}", minhaMoto.Desligar());
            Console.WriteLine("Abastecendo o carro: {0}", meuCarro.Abastecer());
            Console.WriteLine("Abastecendo a moto: {0}", minhaMoto.Abastecer());

            IVeiculo meuCaminhao = new Caminhao();

            Console.WriteLine("Ligando o caminhão: {0}", meuCaminhao.Ligar());
            Console.WriteLine("Desligando o caminhão: {0}", meuCaminhao.Desligar());
            Console.WriteLine("Abastecendo o caminhão: {0}", meuCaminhao.Abastecer());
            Console.WriteLine("Desabastecendo o caminhão: {0}", meuCaminhao.Desabastecer());
            Console.ReadKey();
        }
    }
}

using System;

namespace Exercicio_2
{
    class Program
    {
        //Constantes com os valores dos impostos
        const double IMPOSTO_AREA_CONSTRUIDA = 5;
        const double IMPOSTO_AREA_NAO_CONSTRUIDA = 3.8;

        static void Main(string[] args)
        {
            //Váriaveis utilizadas para o calculo
            double areaTotalTerreno,areaConstruidaTerreno,valorTotalTerreno;

            try
            {

                Console.Write("Informe a area total do Terreno: ");
                areaTotalTerreno = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a area total construida: ");
                areaConstruidaTerreno = Convert.ToDouble(Console.ReadLine());

                valorTotalTerreno = CalcularValorImpostoAreaConstruida(areaConstruidaTerreno) + CalcularValorImpostoAreaNaoConstruida(areaConstruidaTerreno, areaTotalTerreno);

                Console.WriteLine("O valor total do terreno é R$ {0}", valorTotalTerreno.ToString("C"));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro, detalhes do erro:\n{0}", ex.Message);
                throw;
            }

            Console.WriteLine("Pressione qualquer tecla para finalizar a calculadora ");
            Console.ReadKey();

        }

        /// <summary>
        /// Calcula o valor de impostos sobre area construida
        /// </summary>
        /// <param name="areaConstruida"></param>
        /// <returns>Retorna o valor do imposto sobre a area construida</returns>
        public static double CalcularValorImpostoAreaConstruida(double areaConstruida)
        {
            return areaConstruida * IMPOSTO_AREA_CONSTRUIDA;
        }

        /// <summary>
        /// Calcula o valor de imposto sobre a area não construida
        /// </summary>
        /// <param name="areaConstruida"></param>
        /// <param name="areaTotalTerreno"></param>
        /// <returns>Retorna o valor de imposto sobre a area não construida</returns>
        public static double CalcularValorImpostoAreaNaoConstruida(double areaConstruida, double areaTotalTerreno)
        {
            return (areaTotalTerreno - areaConstruida) * IMPOSTO_AREA_NAO_CONSTRUIDA;
        }
    }

    
}

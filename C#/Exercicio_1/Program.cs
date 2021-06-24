using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal areaParede,areaAzulejos,quantidadeAzulejos;

            //Altura da parede
            decimal hp;
            Console.Write("Informe a altura da parede: ");
            hp = Convert.ToDecimal(Console.ReadLine());

            //Largura da parede
            decimal lp;
            Console.Write("Informe a largura da parede:");
            lp = Convert.ToDecimal(Console.ReadLine());

            //Altura do azulejo
            decimal ha;
            Console.Write("Informe a altura do azulejo:");
            ha = Convert.ToDecimal(Console.ReadLine());

            //Largura do azulejo;
            decimal la;
            Console.Write("Informe a largura do azulejo:");
            la = Convert.ToDecimal(Console.ReadLine());

            areaParede = CalcularAreaParede(hp,lp);
            areaAzulejos = CalcularAreaAzulejos(ha,la);

            quantidadeAzulejos = CalcularQuantidadeAzulejos(areaParede, areaAzulejos);

            Console.WriteLine($"A quantidade de azulejos necessários para se preencher uma parede com altura = {hp} e largura = {lp} é de {quantidadeAzulejos} azulejos.\nObs: Levando em consideração que cada azulejo possui altura de {ha} e largura de {la} ");
            Console.ReadLine();
        }

        public static decimal CalcularQuantidadeAzulejos(decimal areaParede, decimal areaAzulejos) {

            return areaParede / areaAzulejos;
            
        }

        /// <summary>
        /// Cacula a área da parede onde será colocado todos os azulejos.
        /// </summary>
        /// <param name="alturaParede"></param>
        /// <param name="larguraParede"></param>
        /// <returns></returns>
        public static decimal CalcularAreaParede(decimal alturaParede, decimal larguraParede) {

            return alturaParede * larguraParede;
        }
        
        /// <summary>
        /// Calcula a Area de cada Azulejo
        /// </summary>
        /// <param name="alturaAzulejos"></param>
        /// <param name="larguraAzulejos"></param>
        /// <returns></returns>
        public static decimal CalcularAreaAzulejos(decimal alturaAzulejos, decimal larguraAzulejos)
        {

            return alturaAzulejos * larguraAzulejos;
        }
    }
}

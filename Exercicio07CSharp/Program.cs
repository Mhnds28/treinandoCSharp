using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex07 Exercicio = new Ex07();
            double custoTotalDeFabricao;
            double custoTotalDeImpostos;
            double custoTotaldoDistribuidor;
            do{
                Console.Write("Informe o custo de fabricação!"+"\n");
                custoTotalDeFabricao = Convert.ToDouble(Console.ReadLine());
            }while(custoTotalDeFabricao <=0);
            do
            {
                Console.WriteLine("Informe a porcentagem dos imostos!");
                custoTotalDeImpostos = Convert.ToDouble(Console.ReadLine());
            } while (custoTotalDeImpostos <= 0);
            do
            {
                Console.WriteLine("Informe  a porcentagem do distribuidor!");
                custoTotaldoDistribuidor = Convert.ToDouble(Console.ReadLine());
            } while (custoTotaldoDistribuidor <= 0);
            
            Console.WriteLine("O Custo final do veiculo é: " + Exercicio.calculoCustoFinal(custoTotalDeFabricao, custoTotaldoDistribuidor, custoTotalDeImpostos));

        }
    }
}

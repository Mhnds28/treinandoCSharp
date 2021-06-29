using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex06 Exercicio = new Ex06();
            double valorSalario;
            double valorPorcentagem;

            do{
                Console.WriteLine("Informe o salario!");
                valorSalario=Convert.ToDouble(Console.ReadLine());
                if(valorSalario <=0)
                {
                    Console.WriteLine("Informe um valor superior a 0!");
                }
            } while(valorSalario < 0); 
            do{
                Console.WriteLine("Informe a porcentagem!");
                valorPorcentagem=Convert.ToDouble(Console.ReadLine());
                if ((valorPorcentagem < 0) || (valorPorcentagem > 100))
                {
                    Console.WriteLine("Informe um valor superior a 0!");
                }
            } while((valorPorcentagem <= 0) || (valorPorcentagem > 100));
            Console.WriteLine("O salario "+ valorSalario + " Recebeu "+ valorPorcentagem + "% de aumento Ficando em " + Exercicio.Reajuste(valorSalario,valorPorcentagem));

        }
    }
}

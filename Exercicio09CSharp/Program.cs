using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex09 Exercicio = new Ex09();
            int qtde = 0;
            do{
                Console.WriteLine("Informe a quantidade!");
                qtde = Convert.ToInt32(Console.ReadLine());
                if (qtde <= 0)
                {
                    Console.WriteLine("Informe um valor igual ou maior que 1!");
                }
            }while(qtde <=0);
            Console.WriteLine("O valor total de sua compra é: R$ " + Exercicio.CalculoFinal(qtde) + " Reais");
        }
    }
}

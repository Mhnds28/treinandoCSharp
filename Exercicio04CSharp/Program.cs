using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex04 Exercicio = new Ex04();
            int anosVida, meseVida, diasVida;

            do
            {
                Console.WriteLine("Informe quantos anos você tem!");
                anosVida = Convert.ToInt32(Console.ReadLine());
                if(anosVida < 0)
                {
                    Console.WriteLine("Informe um valor superior a 0");
                }
            } while (anosVida <= 0);

            do{
                Console.WriteLine("Informe a quantidade de meses que você possui!");
                meseVida=Convert.ToInt32(Console.ReadLine());
                if(meseVida < 0)
                {
                    Console.WriteLine("Informe um valor igual ou superior a 0!!!");
                }
            }while(meseVida < 0);

            do
            {
                Console.WriteLine("informe a quantidade de dias que você possui!!!");
                diasVida = Convert.ToInt32(Console.ReadLine());
                if(diasVida < 0)
                {
                    Console.WriteLine("Informe o valor igual ou superior a 0!!!");
                }
            } while (diasVida < 0);
            Console.WriteLine("A quantidade total de dias é: " + Exercicio.calculo(anosVida,meseVida,diasVida));

        }
            
    }
}

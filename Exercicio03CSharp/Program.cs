using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double basedoRetangulo;
            double alturadoRetangulo;

            Ex03 exercicio = new Ex03();

            do
            {
                Console.WriteLine("Informe o valor da base!!");
                basedoRetangulo = Convert.ToDouble(Console.ReadLine());
                if(basedoRetangulo <=0)
                {
                    Console.WriteLine("Informe un numero positivo!!!");
                }
            } while (basedoRetangulo <= 0);

            do
            {
                Console.WriteLine("Informe o valor da altura!");
                alturadoRetangulo = Convert.ToDouble(Console.ReadLine());
                if (alturadoRetangulo <=0)
                {
                    Console.Write("Informe um numero positivo!!!");
                }
            } while (alturadoRetangulo <= 0);
            Console.WriteLine("O valor da area é: " + exercicio.Area(basedoRetangulo, alturadoRetangulo));            

        }
    }
}

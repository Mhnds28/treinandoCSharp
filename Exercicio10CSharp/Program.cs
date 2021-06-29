using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10CSharp
{
    class Program
    {
        static void Main(string[] args)
        {                      
            int qtde=0;
            int i,j,aux;
            do{
                Console.WriteLine("Informe a quantidade de numeros que deseja armazenar!");
                qtde=Convert.ToInt32(Console.ReadLine());
                if (qtde <= 0)
                {
                    Console.WriteLine("Informe um valor igual ou maior que 1!");
                }
            }while(qtde <=0);

            int[] valor = new int[qtde];

            for (i = 0; i <= qtde-1; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° valor");
                valor[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Os numeros digitador foram: " + "\n");
            for (i = 0; i <= qtde-1; i++)
            {
              Console.WriteLine(valor[i]);
            }
            for (i = 0; i <= qtde - 1; i++)
            {

                for (j = 0; j <= qtde - 2; j++)
                {
                    if (valor[j] > valor[j + 1])
                    {
                        aux = valor[j];
                        valor[j] = valor[j + 1];
                        valor[j + 1] = aux;
                    }

                }

            }
            Console.WriteLine("Os numeros ordenador ficam: " + "\n");
            for (i = 0; i <= qtde - 1; i++)
            {
                Console.WriteLine(valor[i]);
            }


        }        
    }
}

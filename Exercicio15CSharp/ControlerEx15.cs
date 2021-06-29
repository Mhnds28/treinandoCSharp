using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15CSharp
{
    class ControlerEx15
    {
        Ex15 exercicio;
        private int i, num, qtde, contador;
       
        public ControlerEx15()
        {
            i = 0;
            num = 0;
            qtde = 0;
            contador = 0;
            exercicio = new Ex15();
        }


        private void ColetarQtde()
        {
            do
            {
                Console.WriteLine("Informe a quantidade de valores que deseja verificar!");
                qtde = Convert.ToInt32(Console.ReadLine());               
                if (exercicio.ValidarNegativo(qtde) == false)
                {
                    Console.WriteLine("Informe um valor positivo!");
                }
                
            } while (exercicio.ValidarNegativo(qtde) == false);

        }

        private void PopularArray()
        {

            int[] listaNumero = new int[qtde];

            do
            {
                Console.WriteLine("Informe o " + (contador + 1) + "° numero");
                listaNumero[contador] = Convert.ToInt32(Console.ReadLine());
                if (exercicio.ValidarNegativo(listaNumero[contador]) == false)
                {
                    num = num + 1;
                }

                contador = contador + 1;
            } while (contador <= qtde - 1);            

        }


        public void GeraResultado()
        {
            ColetarQtde();
            PopularArray();
            Console.WriteLine("A quantidade de numero negativos é: " + num);
        }

    }
}

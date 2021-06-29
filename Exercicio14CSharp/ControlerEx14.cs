using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14CSharp
{
    class ControlerEx14
    {
        private int numero;
        Ex14 exercicio;

        public ControlerEx14()
        {
            numero = 0;
            exercicio = new Ex14();
        }
        public void ColetarNumero()
        {
            do
            {
                Console.WriteLine("Informe um numero!");
                numero=Convert.ToInt32(Console.ReadLine());
                if(exercicio.validarNegativo(numero)==false)
                {
                    Console.WriteLine("Informe um valor mair que 0!");
                }
            } while (exercicio.validarNegativo(numero) == false);
        }

        public void GerarLista()
        {
            ColetarNumero();
            exercicio.ListaNumero(numero);
        }




    }
}

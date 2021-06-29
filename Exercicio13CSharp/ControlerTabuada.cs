using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13CSharp
{
    class ControlerTabuada
    {

        private int numero;
        Tabuada tabuada;
        public ControlerTabuada()
        {
            numero = 0;
            tabuada = new Tabuada();
        }
        public void ColetarNumero()
        {
            do
            {
                Console.WriteLine("Informe um numero!");
                numero = Convert.ToInt32(Console.ReadLine());
                if (tabuada.ValidaNegativo(numero) == false)
                {
                    Console.WriteLine("Informe um numero entre 1 e 10");
                }
            } while (tabuada.ValidaNegativo(numero) == false);           

        }
        public void GerarTabuada()
        {
            ColetarNumero();
            tabuada.CalculoTabuada(numero);
        }
    }
}

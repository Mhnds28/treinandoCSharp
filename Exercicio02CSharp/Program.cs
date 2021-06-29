using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex02 Exercicio = new Ex02();
            Console.WriteLine("Informe o numero!!!");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O antecessor de " + num + " é "+ Exercicio.Antecessor(num));
        }
    }
}

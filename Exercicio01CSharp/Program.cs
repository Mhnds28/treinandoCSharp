using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex01 Exercicio = new Ex01();
            
            Console.WriteLine("Informe o valor de A!!!");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor de B!!!");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Exercicio.TorcaAB(A, B));            
           
        }
    }
}

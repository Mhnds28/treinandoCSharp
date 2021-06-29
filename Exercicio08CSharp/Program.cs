using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double primeiraNota = 0;
            double segundaNota = 0;
            double terceiraNota = 0;

            Ex08 Exercicio = new Ex08();
            do
            {
                Console.WriteLine("Informe a primeira nota!");
                primeiraNota = Convert.ToDouble(Console.ReadLine());
            } while ((primeiraNota < 0) && (primeiraNota > 10));
            do
            {
                Console.WriteLine("Informe a segunda!");
                primeiraNota = Convert.ToDouble(Console.ReadLine());
            } while ((segundaNota < 0) && (segundaNota > 10));
            do
            {
                Console.WriteLine("Informe a terceira nota!");
                terceiraNota = Convert.ToDouble(Console.ReadLine());
            } while ((terceiraNota < 0) && (terceiraNota > 10));

            Console.WriteLine("A média do aluno(a) é: " + Exercicio.mediaAluno(primeiraNota,segundaNota,terceiraNota));




        }
    }
}

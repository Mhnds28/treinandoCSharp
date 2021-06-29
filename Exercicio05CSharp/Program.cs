using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex05 Exercicio = new Ex05();
            int totaldeEleitores,totalVotosBrancos,totalVotosNulos,totalVotosValidos,totalVotos;           

           do{
               Console.WriteLine("Informe a quantidade de votos brancos!");
               totalVotosBrancos = Convert.ToInt32(Console.ReadLine());
               if(totalVotosBrancos < 0)
               {
                   Console.WriteLine("Informe um valor igual ou superior a 0!");
               }
           }while(totalVotosBrancos < 0);

           do
           {
               Console.WriteLine("Informe a quantidade de votos nulos!");
               totalVotosNulos = Convert.ToInt32(Console.ReadLine());
               if(totalVotosNulos < 0)
               {
                   Console.WriteLine("Informe um valor igual ou superiro a 0!");
               }
           } while (totalVotosNulos < 0);

           do
           {
               Console.WriteLine("Informe a quantidade de votos validos!");
               totalVotosValidos = Convert.ToInt32(Console.ReadLine());
               if(totalVotosValidos < 0)
               {
                   Console.WriteLine("Informe um valor igual ou superior a 0!");
               }
           } while (totalVotosValidos < 0);

           totalVotos = totalVotosBrancos + totalVotosNulos + totalVotosValidos;
           do
           {
               Console.WriteLine("Informe a quantidade total de eleitores!");
               totaldeEleitores = Convert.ToInt32(Console.ReadLine());
               if(totaldeEleitores != totalVotos)
               {
                   Console.WriteLine("O total de votos diferem do total de eleitores!");
               }
           } while (totaldeEleitores != totalVotos);
           Console.WriteLine(Exercicio.eleicao(totaldeEleitores, totalVotosBrancos, totalVotosNulos, totalVotosValidos));

        }
    }
}

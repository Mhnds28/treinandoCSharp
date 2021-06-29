using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11CSharp
{
    class ControlerEmpresa
    {
        Empresa empresa;
        private double vSalario;
        private double vTotalCompra;


        public ControlerEmpresa()
        {
            empresa = new Empresa();
            vSalario = 0;
            vTotalCompra = 0;
        }

        public double salario
        {
            get
            {
                return vSalario;
            }
            set
            {
                vSalario = value;
            }
        }
        public double totalCompra
        {
            get
            {
                return vTotalCompra;
            }
            set
            {
                vTotalCompra = value;
            }
        }

        public void ColetarSalario()
        {
            do
            {
                Console.WriteLine("Informe o salario!");
                vSalario = Convert.ToDouble(Console.ReadLine());
                if (empresa.ValidarNegativo(salario) == true)
                {
                    Console.WriteLine("Informe um valor positivo");
                }
            } while (empresa.ValidarNegativo(salario) == true);
        }

        public void ColetarValorTotalCompra()
        {
            do
            {
                Console.WriteLine("Informe o valor total da compra!");
                totalCompra = Convert.ToDouble(Console.ReadLine());
                if (empresa.ValidarNegativo(totalCompra) == true)
                {
                    Console.WriteLine("Informe um valor positivo");
                }
            }while(empresa.ValidarNegativo(totalCompra)==true);
        }

        public void ResultadoDeexercicio()
        {
            ColetarSalario();
            ColetarValorTotalCompra();
            Console.WriteLine("O valor total a pagar é de: " + empresa.CalculoSalarioTotal(salario, totalCompra));
        }


    }
}

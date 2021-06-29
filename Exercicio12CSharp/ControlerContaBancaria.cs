using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12CSharp
{
    class ControlerContaBancaria
    {
        ContaBancaria conta;
        private int valorNumeroDaConta;
        private double valorSaldo;
        private double valorDebito;
        private double valorCredito;
        private double valorSaldoAtual;
        private int consultaConta;

        public ControlerContaBancaria()
        {
            conta = new ContaBancaria();
            valorNumeroDaConta = 0;
            valorSaldo = 0;
            valorDebito = 0;
            valorCredito = 0;
            valorSaldoAtual = 0;
            consultaConta = 0;

        }

        public void ColetaValorNumeroDaConta()
        {
            do
            {
                Console.WriteLine("Informe o numero da sua conta!");
                valorNumeroDaConta = Convert.ToInt32(Console.ReadLine());
                if (conta.ValidaNegativo(valorNumeroDaConta) == false)
                {
                    Console.WriteLine("Informe um numero positivo");
                }
            } while (conta.ValidaNegativo(valorNumeroDaConta) == false);

        }

        public void ColetarValorSaldo()
        {
            do{
                Console.WriteLine("Informe o valor do saldo!");
                valorSaldo=Convert.ToDouble(Console.ReadLine());
                if(conta.ValidaNegativo(valorSaldo)==false)
                {
                    Console.WriteLine("Informe um saldo positivo!");
                }
            }while(conta.ValidaNegativo(valorSaldo)==false);
        }
        public void ColetarValorDebito()
        {
            do
            {
                Console.WriteLine("Informe o valor do débito!");
                valorDebito = Convert.ToDouble(Console.ReadLine());
                if (conta.ValidaNegativo(valorDebito) == false)
                {
                    Console.WriteLine("Informe o valor de débito positivo");
                }
            } while (conta.ValidaNegativo(valorDebito) == false);
        }
        public void ColetarValorCredito()
        {
            do
            {
                Console.WriteLine("Informe o valor de crédito!");
                valorCredito = Convert.ToDouble(Console.ReadLine());
                if (conta.ValidaNegativo(valorCredito) == false)
                {
                    Console.WriteLine("Informe um valor de crédito positivo!");
                }
            } while (conta.ValidaNegativo(valorCredito) == false);
        }
        public void consultarSaldo()

        {   
            
            ColetaValorNumeroDaConta();
            ColetarValorSaldo();
            ColetarValorDebito();
            ColetarValorCredito();
            Console.WriteLine("Informe o numero da conta que deseja consultar!");
            consultaConta=Convert.ToInt32(Console.ReadLine());

            if (valorNumeroDaConta == consultaConta)
            {
                
               Console.WriteLine("O seu saldo atual R$ " + conta.CalcularSaldoAtual(valorSaldo, valorDebito, valorCredito)+" Reais");
            }
            else
            {
                Console.WriteLine("A conta informada é invalida!");
            }
            
        }

    }
}

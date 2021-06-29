using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12CSharp
{
    class ContaBancaria
    {

        private int _numeroConta;
        private double _saldo;       
        private double _debito;
        private double _credito;
        private double _saldoAtual;
        private Boolean _negativo;

                
        public ContaBancaria()
        {
            _numeroConta = 0;
            _saldo = 0;
            _debito = 0;
            _credito = 0;
            _saldoAtual = 0;
            _negativo = false;
        }

        public int NumeroConta
        {
            get { return _numeroConta; }
            set { _numeroConta = value; }
        }
        public double Debito
        {
            get { return _debito; }
            set { _debito = value; }
        }
        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        public double Credito
        {
            get { return _credito; }
            set { _credito = value; }
        }
        public double SaldoAtual
        {
            get { return _saldoAtual; }
            set { _saldoAtual = value; }
        }
        public Boolean Negativo
        {
            get { return _negativo; }
            set { _negativo = value; }
        }

        public Boolean ValidaNegativo(double numero)
        {
            if (numero < 0)
            {
                Negativo = false;
            }
            else
            {
                Negativo = true;
            }
            return Negativo;
        }
        public double CalcularSaldoAtual(double vSaldo, double vDebito, double vCredito)
        {
            Saldo = vSaldo;
            Debito = vDebito;
            Credito = vCredito;
            SaldoAtual = Saldo - Debito + Credito;
            return SaldoAtual;
        }
    }
}

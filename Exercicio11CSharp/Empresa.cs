using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11CSharp
{
    class Empresa
    {

        private double _salarioFixo;
        private double _valorTotalCompra;
        private int _comissao;
        private double _salarioTotal;
        private Boolean _validacao;

      
        public Empresa()
        {

            _salarioFixo = 0;
            _valorTotalCompra = 0;
            _comissao = 0;
            _salarioTotal = 0;
            _validacao = false;

        }

        public double salarioFixo
        {
            get
            {
                return _salarioFixo;
            }
            set
            {
                this._salarioFixo = value;
            }

        }
        public double valorTotalcompra
        {
            get
            {
                return _valorTotalCompra;
            }
            set
            {
                this._valorTotalCompra = value;
            }
        }
        public int comissao
        {
            get
            {
                return _comissao;
            }
            set
            {
                this._comissao = value;
            }

        }
        public double salariototal
        {
            get
            {
                return _salarioTotal;
            }
            set
            {
                this._salarioTotal = value;
            }

        }
        public Boolean Validacao
        {
            get
            {
                return _validacao;
            }
            set
            {
                this._validacao = value;
            }
        }

        public double ValorComissao(double vValorTotalCompra)
        {
            valorTotalcompra = vValorTotalCompra;
            if (valorTotalcompra <= 1500)
            {
                comissao = 3;
            }
            else
            {
                comissao = 5;
            }
            return comissao;
        }

        public double CalculoSalarioTotal(double vSalario, double vValortotalCompra)
        {
            valorTotalcompra=vValortotalCompra;
            salarioFixo=vSalario;
            salariototal = ((ValorComissao(valorTotalcompra)/100) * valorTotalcompra)  + salarioFixo;
            return salariototal;      
        }

        public Boolean ValidarNegativo(double vNumero)
        {
            
            if (vNumero<0)
            {
                Validacao = true;
            }
            else
            {
                Validacao = false;
            }
            return Validacao;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09CSharp
{
    class Ex09
    {

        private double _valorBruto;
        private double _valorDesconto;
        private double _custoTotal;
        private int _qtde;
        
        public Ex09()
        {
            _valorBruto = 1.30;
            _valorDesconto = 1.00;
            _custoTotal=0;
            _qtde=0;                
        }
        public double valorBruto
        {
            get
            {
                return _valorBruto;
            }
            set
            {
                _valorBruto = value;
            }
        }
        public double valorDesconto
        {
            get
            {
                return _valorDesconto;
            }
            set
            {
                _valorDesconto = value;
            }
        }
        public double custoTotal
        {
            get
            {
                return _custoTotal;
            }
            set
            {
                _custoTotal = value;
            }

        }
        public int Qtde
        {
            get
            {
                return _qtde;
            }
            set
            {
                _qtde = value;
            }
        }
        public double CalculoFinal(int vQtde)
        {
            Qtde=vQtde;
            if(Qtde >=12)
            {
                custoTotal = Qtde * valorDesconto;
            }
            else
            {
                custoTotal = Qtde * valorBruto;
            }
            return custoTotal;
        }
    }
}

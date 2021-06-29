using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07CSharp
{
    class Ex07
    {
        private double _custoFabrica;
        private double _porcentagemDistribuidor;
        private double _impostos;
        private double _custoFinal;
       

        public Ex07()
        {
            _custoFabrica = 0;
            _porcentagemDistribuidor = 0;
            _impostos = 0;
            _custoFinal = 0;
           
        }
        public double custoFabrica
        {
            get
            {
                return _custoFabrica;
            }
            set
            {
                _custoFabrica = value;
            }
        }
        public double porcentagemDistribuidor
        {
            get
            {
                return _porcentagemDistribuidor;
            }
            set
            {
                _porcentagemDistribuidor = value;
            }
        }
        public double impostos
        {
            get
            {
                return _impostos;
            }
            set
            {
                _impostos = value;
            }
        }
       
        public double CustoFinal
        {
            get
            {
                return _custoFinal;
            }
            set
            {
                _custoFinal = value;
            }
        }

        public double custoDoDistribuidor(double vCustoFabrica, double vCustoDistribuidor)
        {
            porcentagemDistribuidor = (vCustoFabrica * (vCustoDistribuidor/100)) ;
            return porcentagemDistribuidor;
        }

        public double custoImpostos(double vCustoFabrica, double vCustoImposto)
        {
            impostos = (vCustoFabrica * (vCustoImposto/100)) ;
            return impostos;
        }        
       
       public double calculoCustoFinal(double vCustoFabrica, double vCustoDistribuidor, double vImpostos)
        {
           custoDoDistribuidor(vCustoFabrica, vCustoDistribuidor);
           custoImpostos(vCustoFabrica, vImpostos);
           return CustoFinal = porcentagemDistribuidor + impostos+ vCustoFabrica ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06CSharp
{
    class Ex06
    {
        private double _salario;
        private double _porcentagem;

        public Ex06()
        {
            _salario = 0;
            _porcentagem = 0;
        }
        public double salario
        {
            get
            {
                return _salario;
            }
            set
            {
                this._salario = value;
            }
        }
        public double porcentagem
        {
            get
            {
                return _porcentagem;
            }
            set
            {
                this._porcentagem = value;
            }
        }

        public double Reajuste(double vSalario, double vPorcentagem)
        {
            salario = vSalario;
            porcentagem = vPorcentagem;
            return ((porcentagem / 100) * salario) + salario;
        }



    }
}

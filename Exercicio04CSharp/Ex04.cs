using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04CSharp
{
    class Ex04
    {
        private int _anos;
        private int _meses;
        private int _dias;
        private int _resultado;

        public Ex04()
        {
            _anos = 0;
            _meses = 0;
            _dias = 0;
            _resultado = 0;
        }
        public int anos
        {
            get
            {
                return _anos;
            }
            set
            {
                this._anos = value;
            }
        }
        public int meses
        {
            get
            {
                return _meses;
            }
            set
            {
                this._meses = value;
            }
        }
        public int dias
        {
            get
            {
                return _dias;
            }
            set
            {
                this._dias = value;
            }
        }
        public int resultado
        {
            get
            {
                return _resultado;
            }
            set
            {
                this._resultado = value;
            }
        }

        public int calculo(int VAnos, int vMeses, int vDias)
        {
            anos = VAnos;
            meses = vMeses;
            dias = vDias;
            resultado = (anos * 365) + (meses * 30) + dias;
            return resultado;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02CSharp
{
    class Ex02
    {
        private int _numero;

        public Ex02()
        {
            _numero = 0;
        }

        public int numero
        {
            get
            {
                return _numero;
            }
            set
            {
                this._numero = value;
            }
        }

        public int Antecessor(int num) 
        {
            numero = num;
            return numero - 1;
        }
    }
}

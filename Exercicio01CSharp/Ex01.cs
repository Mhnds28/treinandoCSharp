using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01CSharp
{
    class Ex01
    {
        private int _A, _B, _C;

        public Ex01()
        {
            _A = 0;
            _B = 0;
            _C = 0;

        }

        public int A
        {
            get
            {
                return _A;
            }
            set
            {
                this._A = value;
            }
        }

        public int B
        {
            get
            {
                return _B;
            }
            set
            {
                this._B = value;
            }
        }

        public int C
        {
            get
            {
                return _C;
            }
            set
            {
                this._C = value;
            }
        }

        public string TorcaAB(int vA, int vB)
        {
            A = vA;
            B = vB;
            C = A;
            A = B;
            B = C;
            return "O valor de A: " + A + "\n" +
                   "O valor de B: " + B; 
        }
        
    }
}

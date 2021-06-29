using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15CSharp
{
    class Ex15
    {

        private Boolean _negativo;
        private int _qtde;

        public Ex15()
        {
            _negativo = false;
            _qtde = 0;
        }


        public int Qtde
        {
            get { return _qtde; }
            set { _qtde = value; }
        }
        
        public Boolean Negativo
        {
            get { return _negativo; }
            set { _negativo = value; }
        }
        public Boolean ValidarNegativo(int vNumero)
        {
            if (vNumero < 0)
            {
                Negativo = false;
            }
            else
            {
                Negativo = true;
            }
            return Negativo;
        }

        

    }
}

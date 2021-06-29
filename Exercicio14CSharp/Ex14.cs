using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14CSharp
{
    class Ex14
    {

        private int _n;
        private Boolean _negativo;

        public Ex14()
        {
            _n = 0;
            _negativo = false;

        }

        public Boolean Negativo
        {
            get { return _negativo; }
            set { _negativo = value; }
        }

        public int N
        {
            get { return _n; }
            set { _n = value; }
        }
        
       

        public Boolean validarNegativo(int vNumero)
        {
            if (vNumero <= 0)
            {
                Negativo = false;
            }
            else
            {
                Negativo = true;
            }
            return Negativo;
        }

        public void ListaNumero(int vNumero)
        {
            N = vNumero;
            for (int I = 0; I <= N; I++)
            {
                Console.WriteLine(I);
            }
        }

    }
}

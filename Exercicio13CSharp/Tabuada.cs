using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13CSharp
{
    class Tabuada
    {

        private int _numeroTabuada;       
        private Boolean negativo;


        public Tabuada()
        {
            _numeroTabuada = 0;           
            negativo = false;
        }        
        
               public int NumeroTabuada
        {
            get { return _numeroTabuada; }
            set { _numeroTabuada = value; }
        }


        public Boolean ValidaNegativo(int vNumero)
        {
           
            if (vNumero < 0 || vNumero > 10)
            {
                negativo = false;
            }
            else
            {
                negativo = true;
            }
            return negativo;
        }

        public void CalculoTabuada(int vNumero)
        {
            
            NumeroTabuada = vNumero;
            for (int I = 0; I < 11;I++ )
            {
                Console.WriteLine(vNumero + " X " + I + " = " + I * vNumero);
            }
            
        }
        
       

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08CSharp
{
    class Ex08
    {

        private double _primeiraNota;
        private double _segundaNota;
        private double _terceiraNota;
        private double _media;

        public Ex08()
        {
            _primeiraNota = 0;
            _segundaNota=0;
            _terceiraNota = 0;
            _media = 0;
        }
        public double primeiraNota
        {
            get
            {
                return _primeiraNota;
            }
            set
            {
                _primeiraNota = value;
            }
        }
        public double segundaNota
        {
            get
            {
                return _segundaNota;
            }
            set
            {
                _segundaNota = value;
            }
        }
        public double terceiraNota
        {
            get
            {
                return _terceiraNota;
            }
            set
            {
                _terceiraNota = value;
            }
        }
        public double media
        {
            get
            {
                return _media;
            }
            set
            {
                _media = value;
            }
        }
        public double mediaAluno(double vPrimeiraNota, double vSegundaNota, double vTerceiraNota)
        {
            primeiraNota = vPrimeiraNota;
            segundaNota = vSegundaNota;
            terceiraNota = vTerceiraNota;
            return media =((primeiraNota + segundaNota + terceiraNota) / 3);
        }


    }
}

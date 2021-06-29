using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03CSharp
{
    class Ex03
    {
        private double _base;
        private double _altura;

        public Ex03()
        {
            _base = 0;
            _altura = 0;
        }

        public double baseRetangulo
        {
            get
            {
                return _base;
            }
            set
            {
                this._base = value;
            }
        }

        public double alturaRetangulo
        {
            get
            {
                return _altura;
            }
            set
            {
                this._altura = value;
            }
        }

        public double Area(double vBase, double vAltura)
        {
            baseRetangulo = vBase;
            alturaRetangulo = vAltura;
            return baseRetangulo * alturaRetangulo;
        }
    }
}

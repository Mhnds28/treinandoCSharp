using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05CSharp
{
    class Ex05
    {
        private double _totalEleitores;
        private double _votosBrancos;
        private double _votosNulos;
        private double _votosValidos;
        private double _pBranco;
        private double _pNulo;
        private double _pValidos;

        public Ex05()
        {
            _totalEleitores = 0;
            _votosBrancos = 0;
            _votosNulos = 0;
            _votosValidos = 0;
            _pBranco = 0;
            _pNulo = 0;
            _pValidos = 0;
        }
        public double totalEleitores
        {
            get
            {
                return _totalEleitores;
            }
            set
            {
                this._totalEleitores = value;
            }
        }

        public double votosBrancos
        {
            get
            {
                return _votosBrancos;
            }
            set
            {
                this._votosBrancos = value;
            }
        }
        public double votosNulos
        {
            get
            {
                return _votosNulos;
            }
            set
            {
                this._votosNulos = value;
            }
        }
        public double votosValidos
        {
            get
            {
                return _votosValidos;
            }
            set
            {
                this._votosValidos = value;
            }
        }
        public double pBranco
        {
            get
            {
                return _pBranco;
            }
            set
            {
                this._pBranco = value;
            }
        }
        public double pNulo
        {
            get
            {
                return _pNulo;
            }
            set
            {
                this._pNulo = value;
            }
        }
        public double pValido
        {
            get
            {
                return _pValidos;
            }
            set
            {
                this._pValidos = value;
            }
        }
        public string eleicao(double vTotalEleitores, double vVotosBrancos, double vVotosNulos, double vVotosValidos)
        {
            totalEleitores = vTotalEleitores;
            votosBrancos = vVotosBrancos;
            votosNulos = vVotosNulos;
            votosValidos = vVotosValidos;
            pBranco = (votosBrancos / totalEleitores) * 100;
            pNulo = (votosNulos / totalEleitores) * 100;
            pValido =(votosValidos / totalEleitores) * 100;
            return "Total de eleitores " + totalEleitores + "\n" +
                   "Votos brancos " + pBranco + "%" + "\n" +
                   "Votos nulos   " + pNulo + "%" + "\n" +
                   "Votos Validos " + pValido + "%" + "\n";

        }
    }
}

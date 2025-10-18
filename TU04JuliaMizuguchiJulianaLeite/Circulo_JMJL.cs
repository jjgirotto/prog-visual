using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU04JuliaMizuguchiJulianaLeite
{
    internal class Circulo_JMJL : FiguraGeometrica_JMJL
    {
        public int Raio_JMJL { get; set; }

        public Circulo_JMJL(int x, int y, int raio) : base(x, y)
        {
            this.Raio_JMJL = raio;
        }

        public Circulo_JMJL(Ponto_JMJL centro, int raio) : this(centro.X_JMJL, centro.Y_JMJL, raio)
        {
        }

        public Circulo_JMJL() : this(0, 0, 0)
        {
        }

        public override string ToString()
        {
            return "[C: CENTRO: " + Origem_JMJL + ", Raio: " + Raio_JMJL + " ]";
        }

        override
            public double CalcularArea_JMJL()
        {
            return Math.PI * Math.Pow(Raio_JMJL, 2);
        }
    }
}

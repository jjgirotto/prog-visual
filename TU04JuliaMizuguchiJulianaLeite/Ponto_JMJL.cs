using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU04JuliaMizuguchiJulianaLeite
{
    internal class Ponto_JMJL
    {
        // Propriedades com campo implicito
        // São públicas e mascaram o campo
        public int X_JMJL { get; set; }
        public int Y_JMJL { get; set; }
        public Ponto_JMJL(int x, int y)
        {
            X_JMJL = x;
            Y_JMJL = y;
        }
        public Ponto_JMJL() : this(0, 0)
        {
        }
        public void Desloca_JMJL(int dx, int dy)
        {
            X_JMJL += dx;
            Y_JMJL += dy;
        }
        public override string ToString()
        {
            return "(" + X_JMJL + "," + Y_JMJL + ")";
        }
    }
}

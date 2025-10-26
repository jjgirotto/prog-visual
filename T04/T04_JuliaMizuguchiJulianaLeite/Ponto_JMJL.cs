using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04_JuliaMizuguchiJulianaLeite
{
    internal class Ponto_JMJL
    {
        // Propriedades com campo implicito
        // São públicas e mascaram o campo
        public int X_JMJL { get; set; }
        public int Y_JMJL { get; set; }
        public Ponto_JMJL(int x_JMJL, int y_JMJL)
        {
            X_JMJL = x_JMJL;
            Y_JMJL = y_JMJL;
        }
        public Ponto_JMJL() : this(0, 0)
        {
        }
        public void Desloca_JMJL(int dx_JMJL, int dy_JMJL)
        {
            X_JMJL += dx_JMJL;
            Y_JMJL += dy_JMJL;
        }
        public override string ToString()
        {
            return "(" + X_JMJL + "," + Y_JMJL + ")";
        }
    }
}

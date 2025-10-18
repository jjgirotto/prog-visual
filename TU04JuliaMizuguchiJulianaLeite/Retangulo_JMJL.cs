using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU04JuliaMizuguchiJulianaLeite
{
    internal class Retangulo_JMJL : FiguraGeometrica_JMJL
    {
        public int X2_JMJL { get; set; }
        public int Y2_JMJL { get; set; }

        public Retangulo_JMJL(int x, int y, int x2, int y2) : base(x, y)
        {
            X2_JMJL = x2;
            Y2_JMJL = y2;
        }

        public Retangulo_JMJL(Ponto_JMJL p1, Ponto_JMJL p2) : this(p1.X_JMJL, p1.Y_JMJL, p2.X_JMJL, p2.Y_JMJL)
        {
        }

        public Retangulo_JMJL() : this(0, 0, 0, 0)
        {
        }

        // NOTE QUE em C# é obrigatório marcar com [« override »] membros da classe que escondam os membro
        // da classe base, os quais terão de estar marcados com [« virtual »]
        // NOTE AINDA QUE: se não pretender que o membro com identificador igual ao da classe base
        // esconda o da classe base terá de o marcar com [« new »]
        public override void Desloca_JMJL(int dx, int dy)
        {
            base.Desloca_JMJL(dx, dy);
            X2_JMJL += dx;
            Y2_JMJL += dy;
        }

        public override string ToString()
        {
            return "[R: ORIGEM: " + base.ToString() + ",(" + X2_JMJL + "," + Y2_JMJL + ")]";
        }

        public override double CalcularArea_JMJL()
        {
            int largura = Math.Abs(X2_JMJL - Origem_JMJL.X_JMJL);
            int altura = Math.Abs(Y2_JMJL - Origem_JMJL.Y_JMJL);
            return largura * altura;
        }
    }
}

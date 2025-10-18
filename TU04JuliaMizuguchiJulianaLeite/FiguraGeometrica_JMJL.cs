using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU04JuliaMizuguchiJulianaLeite
{
    internal class FiguraGeometrica_JMJL
    {
        public Ponto_JMJL Origem_JMJL { get; set; }
        public FiguraGeometrica_JMJL(Ponto_JMJL ponto)
        {
            Origem_JMJL = ponto;
        }
        public FiguraGeometrica_JMJL(int x_JMJL, int y_JMJL) : this(new Ponto_JMJL(x_JMJL, y_JMJL))
        {
        }
        
        public FiguraGeometrica_JMJL() : this(new Ponto_JMJL())
        {
        }

        // NOTE QUE em C# é obrigatório marcar como
        // [« virtual »] membros da classe que sejam
        // [« overrided »] JMJLs subclasses
        public virtual void Desloca_JMJL(int dx_JMJL, int dy_JMJL)
        {
            Origem_JMJL.Desloca_JMJL(dx_JMJL, dy_JMJL);
        }
        public override string ToString()
        {
            return Origem_JMJL.ToString();
        }

        public virtual double CalcularArea_JMJL()
        {
            return 0.0;
        }
    }
}

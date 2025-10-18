using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU04JuliaMizuguchiJulianaLeite
{
    internal class Desenho_JMJL
    {
        public List<FiguraGeometrica_JMJL> figuras_JMJL { get; set; }

        public Desenho_JMJL()
        {
            figuras_JMJL = new List<FiguraGeometrica_JMJL> ();
        }

        public void AdicionarFiguraGeometrica(FiguraGeometrica_JMJL figuraGeometrica_JMJL)
        {
            figuras_JMJL.Add(figuraGeometrica_JMJL);
        }

        public double CalcularSomaAreas_JMJL()
        {
            double somaAreas_JMJL = 0;
            foreach (FiguraGeometrica_JMJL figura in figuras_JMJL)
            {
                somaAreas_JMJL += figura.CalcularArea_JMJL();
            }
            return somaAreas_JMJL;
        }

        public virtual void Desloca_JMJL(int dx_JMJL, int dy_JMJL)
        {
            foreach (FiguraGeometrica_JMJL figura in figuras_JMJL)
            {
                figura.Desloca_JMJL(dx_JMJL, dy_JMJL);
            }
        }

        override
            public String ToString()
        {
            String tmp = "";
            foreach (FiguraGeometrica_JMJL figura_JMJL in figuras_JMJL)
            {
                tmp += figura_JMJL.ToString() + '\n';
            }
            return tmp;
        }
    }
}

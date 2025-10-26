using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class CartaoDoCidadao_JMJL
    {
        public string Numero_JMJL { get; set; }
        public DateTime DataDeValidade_JMJL { get; set; }

        public CartaoDoCidadao_JMJL(string numero_JMJL, DateTime data_JMJL)
        {
            Numero_JMJL = numero_JMJL;
            DataDeValidade_JMJL = data_JMJL;
        }

        override
            public string ToString()
        {
            return Numero_JMJL + " - " + DataDeValidade_JMJL.Year + "/" + DataDeValidade_JMJL.Month;
        }
    }
}

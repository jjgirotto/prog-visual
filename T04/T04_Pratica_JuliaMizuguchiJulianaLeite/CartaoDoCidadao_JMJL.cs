using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04_Pratica_JuliaMizuguchiJulianaLeite
{
    internal class CartaoDoCidadao_JMJL
    {
        public string Numero_JMJL { get; set; }
        public string Nome_JMJL { get; set; }

        public CartaoDoCidadao_JMJL(string numero_JMJL, string nome_JMJL)
        {
            Numero_JMJL = numero_JMJL;
            Nome_JMJL = nome_JMJL;
        }

        public CartaoDoCidadao_JMJL() : this("000", "Sem nome definido") { }

        override
            public string ToString()
        {
            return "NCC: " + Numero_JMJL + " - " + Nome_JMJL;
        }
    }
}

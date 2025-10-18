using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04_Pratica_JuliaMizuguchiJulianaLeite
{
    internal class Docente_JMJL : Cidadao_JMJL
    {
        public string CategoriaProfissional_JMJL { get; set; }
        public string Gabinete_JMJL { get; set; }

        public Docente_JMJL(CartaoDoCidadao_JMJL cartao_JMJL, DateTime data_JMJL, string categoriaProfissional_JMJL, string gabinete_JMJL) : base(cartao_JMJL, data_JMJL)
        {
            CategoriaProfissional_JMJL = categoriaProfissional_JMJL;
            Gabinete_JMJL = gabinete_JMJL;
        }

        public Docente_JMJL() : this(new CartaoDoCidadao_JMJL(), new DateTime(), "000", "Sem gabinete definido") { }

        override
            public string ToString()
        {
            return "Docente: " + CategoriaProfissional_JMJL + " - " + Gabinete_JMJL + " " + base.ToString();
        }
    }
}

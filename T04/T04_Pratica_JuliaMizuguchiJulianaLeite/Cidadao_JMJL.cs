using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04_Pratica_JuliaMizuguchiJulianaLeite
{
    internal class Cidadao_JMJL
    {
        public CartaoDoCidadao_JMJL CartaoDoCidadao_JMJL { get; set; }
        public DateTime DataNascimento_JMJL { get; set; }

        public Cidadao_JMJL(CartaoDoCidadao_JMJL cartaoDoCidadao_JMJL, DateTime dataNascimento_JMJL)
        {
            CartaoDoCidadao_JMJL = cartaoDoCidadao_JMJL;
            DataNascimento_JMJL = dataNascimento_JMJL;
        }

        public Cidadao_JMJL() : this(new CartaoDoCidadao_JMJL(), new DateTime()) { }

        override
            public string ToString()
        {
            return CartaoDoCidadao_JMJL.ToString() + " - " + DataNascimento_JMJL;
        }
    }
}

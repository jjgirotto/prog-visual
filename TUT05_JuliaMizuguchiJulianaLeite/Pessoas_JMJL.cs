using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class Pessoas_JMJL : List<Pessoa_JMJL>
    {
        public override string ToString()
        {
            string str_JMJL = "";
            foreach (Pessoa_JMJL p in this)
            {
                str_JMJL += p + "\n";
            }
            return str_JMJL;
        }
    }
}

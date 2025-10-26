using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class OsMeusLivros_JMJL : List<Livro_JMJL>
    {
        public override string ToString()
        {
            string str_JMJL = "";
            foreach (Livro_JMJL l in this)
                str_JMJL += l + "\n";
            return str_JMJL;
        }
    }
}

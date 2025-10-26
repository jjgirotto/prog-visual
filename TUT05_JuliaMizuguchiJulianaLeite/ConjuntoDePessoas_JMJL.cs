using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class ConjuntoDePessoas_JMJL : HashSet<Pessoa_JMJL>
    {
        public override string ToString()
        {
            string tmp_JMJL = "";
            foreach (Pessoa_JMJL p in this)
                tmp_JMJL += "\n" + p;
            return tmp_JMJL;
        }
    }
}

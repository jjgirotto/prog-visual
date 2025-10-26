using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class Livraria_JMJL
    {
        public string Nome_JMJL { get; set; }
        public string Nif_JMJL { get; set; }
        public string Url_JMJL { get; set; }
        public List<Livro_JMJL> livros_JMJL { get; set; }

        public override string ToString()
        {
            string tmp = $"Nome: {Nome_JMJL} - NIF: {Nif_JMJL} - URL: {Url_JMJL} - Livros:\n";
            foreach (Livro_JMJL l in livros_JMJL)
            {
                tmp += l + "\n";
            }
            return tmp;
        }

    }
}

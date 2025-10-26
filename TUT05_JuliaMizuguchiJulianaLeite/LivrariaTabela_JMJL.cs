using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class LivrariaTabela_JMJL : Dictionary<Livro_JMJL, int>
    {
        public string Nome_JMJL { get; set; }

        public LivrariaTabela_JMJL(string nome_JMJL)
        {
            Nome_JMJL = nome_JMJL;
        }

        public void AdicionarLivro(Livro_JMJL livro_JMJL, int stock)
        {
            if (this.ContainsKey(livro_JMJL))
            {
                // Se sim, atualiza o stock
                this[livro_JMJL] += stock;
            }
            else
            {
                // Se não, adiciona
                this.TryAdd(livro_JMJL, stock);
            }
        }

        public override string ToString()
        {
            string tmp_JMJL = Nome_JMJL + "\n";
            foreach (KeyValuePair<Livro_JMJL, int> livroStock in this)
            {
                tmp_JMJL += $"{livroStock.Key} | STOCK NA LIVRARIA: {livroStock.Value}\n";
            }
            return tmp_JMJL;
        }
    }
}

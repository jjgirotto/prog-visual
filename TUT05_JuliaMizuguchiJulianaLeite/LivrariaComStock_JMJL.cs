using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class LivrariaComStock_JMJL
    {
        public string Nome_JMJL { get; set; }
        public Dictionary<Livro_JMJL, int> conjuntoDeLivrosEstoque;

        public LivrariaComStock_JMJL(string nome_JMJL)
        {
            Nome_JMJL = nome_JMJL;
            conjuntoDeLivrosEstoque = new Dictionary<Livro_JMJL, int>();
        }

        public void AdicionarLivro(Livro_JMJL livro_JMJL, int stock)
        {
            if (conjuntoDeLivrosEstoque.ContainsKey(livro_JMJL))
            {
                //se sim, soma o novo stock ao valor existente
                conjuntoDeLivrosEstoque[livro_JMJL] += stock;
            }
            else
            {
                // se não (livro novo), ADICIONA o livro com o stock inicial
                conjuntoDeLivrosEstoque.TryAdd(livro_JMJL, stock);
            }
        }

        public override string ToString()
        {
            string tmp_JMJL = Nome_JMJL + "\n";
            foreach (KeyValuePair<Livro_JMJL, int> livroStock in conjuntoDeLivrosEstoque)
            {
                tmp_JMJL += $"{livroStock.Key} | STOCK NA LIVRARIA: {livroStock.Value}\n";
            }
            return tmp_JMJL;
        }
    }
}

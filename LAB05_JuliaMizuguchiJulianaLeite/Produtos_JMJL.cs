using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05_JuliaMizuguchiJulianaLeite
{
    internal class Produtos_JMJL : List<Product_JMJL>
    {

        public IEnumerable<Product_JMJL> TodosOsProdutos_JMJL()
        {
            var todosOsProdutos_JMJL = from i
                                       in this
                                       select i;
            return todosOsProdutos_JMJL;

        }

        public IEnumerable<Product_JMJL> ProdutosSemStock_JMJL()
        {
            var produtosSemStock_JML = from i in this
                                       where i.UnitsInStock_JMJL == 0
                                       select i;
            return produtosSemStock_JML;
        }

        public IEnumerable<String> CondimentosOrdemAlfabetica_JMJL()
        {
            var condimentosOrdemAlfabetica_JMJL = from i in this
                                                  where i.Category_JMJL.Equals("Condiments")
                                                  orderby i.ProductName_JMJL
                                                  select i.ProductName_JMJL;
            return condimentosOrdemAlfabetica_JMJL;
        }

        public IEnumerable<Product_JMJL> BebidasMenos25_JMJL()
        {
            var bebidasMenos25_JMJL = from i in this
                                      where i.Category_JMJL.Equals("Beverages")
                                      && i.UnitPrice_JMJL < 25
                                      orderby i.UnitPrice_JMJL
                                      select i;
            return bebidasMenos25_JMJL;
        }

        public Product_JMJL PrecoMaisBarato_JMJL()
        {
            decimal precoMaisBarato_JMJL = (from i in this
                                            select i.UnitPrice_JMJL).Min();
            Product_JMJL produtoMaisBarato_JMJL = (from i in this
                                                   where i.UnitPrice_JMJL == precoMaisBarato_JMJL
                                                   select i).First();
            return produtoMaisBarato_JMJL;
        }

        public Product_JMJL PrecoMaisCaro_JMJL()
        {
            decimal precoMaisCaro_JMJL = (from i in this
                                          select i.UnitPrice_JMJL).Max();
            Product_JMJL produtoMaisCaro_JMJL = (from i in this
                                                 where i.UnitPrice_JMJL == precoMaisCaro_JMJL
                                                 select i).First();
            return produtoMaisCaro_JMJL;
        }

        public decimal ValorMedio_JMJL()
        {
            decimal valorMedio_JMJL = (from i in this
                                       select i.UnitPrice_JMJL).Average();

            return valorMedio_JMJL;
        }

        public IEnumerable<(string Nome, decimal ValorTotal)> ProdutosEValor_JMJL()
        {
            var produtosEValor_JMJL = from i in this
                                      select (i.ProductName_JMJL,
                                         i.UnitPrice_JMJL * i.UnitsInStock_JMJL
                                         );
            return produtosEValor_JMJL;
        }

        public IEnumerable<Product_JMJL> PrecoOrdemAscendente_JMJL()
        {
            var precoOrdemAscendente_JMJL = this.OrderBy(p => p.UnitPrice_JMJL);
            return precoOrdemAscendente_JMJL;
        }

        public IEnumerable<String> CategoriasUnicas_JMJL()
        {
            var categoriasUnicas_JMJL = this.Select(p => p.Category_JMJL).Distinct();
            return categoriasUnicas_JMJL;
        }

        public bool ValorMaiorQue200_JMJL()
        {
            bool produtosMaiorQue200_JMJL = this.Any(p => p.UnitPrice_JMJL > 200);
            return produtosMaiorQue200_JMJL;
        }

        public double MediaStock_JMJL()
        {
            double mediaStock_JMJL = this.Average(p => p.UnitsInStock_JMJL);
            return mediaStock_JMJL;
        }

        public IEnumerable<Product_JMJL> Produtos3MaisQue50_JMJL()
        {
            var produtos3MaisQue50_JMJL = (from i in this
                                           where i.UnitPrice_JMJL > 50
                                           select i).Take(5);
            return produtos3MaisQue50_JMJL;
        }

        public IEnumerable<Product_JMJL> Produtos4E5ComC_JMJL()
        {
            var produtos4E5ComC_JMJL = (from i in this
                                        where i.ProductName_JMJL.StartsWith("C")
                                        select i).Skip(2).Take(3);
            return produtos4E5ComC_JMJL;
        }

        public IEnumerable<Product_JMJL> ProdutosCategoriaNome_JMJL()
        {
            var produtosPorCategoriaENome_JMJL = (from i in this
                                                  orderby i.Category_JMJL, i.ProductName_JMJL
                                                  select i);
            return produtosPorCategoriaENome_JMJL;
        }

        public IEnumerable<IGrouping<string, Product_JMJL>> CategoriaEProdutos_JMJL()
        {
            var categoriaEProdutos_JMJL = from i in this
                                          group i by i.Category_JMJL into g
                                          orderby g.Key
                                          select g;
            return categoriaEProdutos_JMJL;
        }

    }
        
}

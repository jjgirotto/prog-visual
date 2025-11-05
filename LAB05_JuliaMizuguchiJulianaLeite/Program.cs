using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LAB05_JuliaMizuguchiJulianaLeite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product_JMJL> products = CriarProdutos();
            Console.WriteLine("Lista de Produtos: \n");
            foreach (Product_JMJL product in products)
            {
                Console.WriteLine("{0:00} - {1}", product.ProductId_JMJL, product.ProductName_JMJL);
            }

            // Testes LinQ

            var todos = from i in products select i;

            List<Product_JMJL> snapshotDosProdutos = todos.ToList();

            foreach (Product_JMJL product in snapshotDosProdutos)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\nNivel 1*************************");
            Console.ReadLine();
            Console.WriteLine("\n Produtos sem estoque: ");
            var produtosSemEstoque_JMJL = from i in products where i.UnitsInStock_JMJL == 0 select i;
            foreach (Product_JMJL product in produtosSemEstoque_JMJL)
                Console.WriteLine(product);

            Console.WriteLine("\n Nomes de condimentos em ordem alfabética: ");
            var nomesCondimentosOrdemAlfabetica_JMJL = from i in products where i.Category_JMJL == "Condiments" orderby i.ProductName_JMJL select i.ProductName_JMJL;
            foreach (string nome in nomesCondimentosOrdemAlfabetica_JMJL)
                Console.WriteLine(nome);

            Console.WriteLine("\nNivel 2************************");
            Console.ReadLine();
            Console.WriteLine("\n Bebidas por menos de 25€: ");
            var bebidasMenos25_JMJL = from i in products where i.Category_JMJL == "Beverages"
                                      && i.UnitPrice_JMJL < 25 orderby i.UnitPrice_JMJL select i;
            foreach (Product_JMJL product in bebidasMenos25_JMJL)
                Console.WriteLine(product);

            products.Add(new Product_JMJL
            {
                ProductId_JMJL = 78,
                ProductName_JMJL = "Sagres",
                Category_JMJL = "Beverages",
                UnitPrice_JMJL = 12.2M,
                UnitsInStock_JMJL = 25
            });
            products.Add(new Product_JMJL
            {
                ProductId_JMJL = 79,
                ProductName_JMJL = "Super Bock",
                Category_JMJL = "Beverages",
                UnitPrice_JMJL = 10.1M,
                UnitsInStock_JMJL = 15
            });

            Console.WriteLine("\nDepois de adicionar 78 e 79");
            foreach (Product_JMJL product in bebidasMenos25_JMJL)
                Console.WriteLine(product);
            int id = (from i in products select i.ProductId_JMJL).Max() + 1;
            products.Add(new Product_JMJL
            {
                ProductId_JMJL = id,
                ProductName_JMJL = "Carlsberg",
                Category_JMJL = "Beverages",
                UnitPrice_JMJL = 18.1M,
                UnitsInStock_JMJL = 12
            });

            Console.WriteLine("\nNivel 3************************");
            Console.ReadLine();
            decimal precoMaisBarato_JMJL = (from i in products select i.UnitPrice_JMJL).Min();
            Product_JMJL produtoMaisBarato_JMJL = (from i in products where i.UnitPrice_JMJL == precoMaisBarato_JMJL select i).First();
            Console.WriteLine("\n Produto mais barato: " + produtoMaisBarato_JMJL);
            decimal precoMaisCaro_JMJL = (from i in products select i.UnitPrice_JMJL).Max();
            Product_JMJL produtoMaisCaro_JMJL = (from i in products where i.UnitPrice_JMJL == precoMaisCaro_JMJL select i).First();
            Console.WriteLine("\n Produto mais caro: " + produtoMaisCaro_JMJL);
            decimal valorMedio_JMJL = (from i in products select i.UnitPrice_JMJL).Average();
            Console.WriteLine("\n Valor médio dos produtos: " + valorMedio_JMJL);
            Console.WriteLine("\n Produto e valor total no estoque: ");
            var produtosEValor_JMJL = from i in products
                                select new { Nome = i.ProductName_JMJL,
                                    ValorTotal = i.UnitsInStock_JMJL * i.UnitPrice_JMJL };
            foreach (var p in produtosEValor_JMJL)
                Console.WriteLine(p);

            Console.WriteLine("\nNivel 4************************");
            Console.ReadLine();
            Console.WriteLine("\nProdutos ordenados por preço de forma ascendente");
            var produtosOrdenados_JMJL = products.OrderBy(p => p.UnitPrice_JMJL);
            foreach (Product_JMJL product in produtosOrdenados_JMJL)
                Console.WriteLine(product);
            Console.WriteLine("\nA lista de categorias únicas (sem repetição)");
            var categorias_JMJL = products.Select(p => p.Category_JMJL).Distinct();
            foreach (var categoria in categorias_JMJL)
                Console.WriteLine(categoria);
            Console.WriteLine("\nExiste produto com um custo maior que 200?");
            bool produtosMaior200_JMJL = products.Any(p => p.UnitPrice_JMJL > 200);
            if (produtosMaior200_JMJL) Console.WriteLine("Existe produto mais caro que 200");
            else Console.WriteLine("Não existe produto mais caro que 200");
            double mediaStock_JMJL = products.Average(p => p.UnitsInStock_JMJL);
            Console.WriteLine("\nO número médio de unidades em stock: " + mediaStock_JMJL);

            Console.WriteLine("\nNivel 5************************");
            Console.ReadLine();
            Console.WriteLine("\n Os primeiros 3 produtos que custam mais de 50");
            var produtos3Mais50_JMJL = (from i in products where i.UnitPrice_JMJL > 50 select i).Take(3);
            foreach (Product_JMJL product in produtos3Mais50_JMJL) Console.WriteLine(product);
            Console.WriteLine("\n O quarto e o quinto produto começado pela letra C");
            var produtos4E5ComC_JMJL = (from i in products where i.ProductName_JMJL.StartsWith("C") select i).Skip(3).Take(2);
            foreach (Product_JMJL product in produtos4E5ComC_JMJL) Console.WriteLine(product);
            Console.WriteLine("\n A lista de produtos ordenada pela categoria e depois pelo nome do produto");
            var produtosPorCategoriaENome_JMJL = (from i in products orderby i.Category_JMJL, i.ProductName_JMJL select i);
            foreach (Product_JMJL product in produtosPorCategoriaENome_JMJL) Console.WriteLine(product);
            Console.WriteLine("\n Mostre cada categoria seguida da lista de produtos incluídos na mesma");
            var categoriaEProdutos_JMJL = from i in products group i by i.Category_JMJL into g
                                          orderby g.Key select g;
            foreach (var grupo in categoriaEProdutos_JMJL)
            {
                Console.WriteLine($"\nCategoria: {grupo.Key}");
                foreach (var product in grupo)
                    Console.WriteLine(product);
            }

            Console.WriteLine("\nNivel 6************************");
            Console.ReadLine();
            Produtos_JMJL produtos_JMJL = new Produtos_JMJL();
            produtos_JMJL.AddRange(products);

            foreach (var p in produtos_JMJL.TodosOsProdutos_JMJL())
                Console.WriteLine(p);

            foreach (var p in produtos_JMJL.ProdutosSemStock_JMJL())
                Console.WriteLine(p);

            foreach (var p in produtos_JMJL.CondimentosOrdemAlfabetica_JMJL())
                Console.WriteLine(p);

            foreach (var p in produtos_JMJL.BebidasMenos25_JMJL())
                Console.WriteLine(p);


            Console.WriteLine(produtos_JMJL.PrecoMaisBarato_JMJL());
            Console.WriteLine(produtos_JMJL.PrecoMaisCaro_JMJL());
            Console.WriteLine(produtos_JMJL.ValorMedio_JMJL());

            foreach (var p in produtos_JMJL.ProdutosEValor_JMJL())
                Console.WriteLine(p);

            foreach (var p in produtos_JMJL.PrecoOrdemAscendente_JMJL())
                Console.WriteLine(p);

            foreach (var c in produtos_JMJL.CategoriasUnicas_JMJL())
                Console.WriteLine(c);

            Console.WriteLine(produtos_JMJL.ValorMaiorQue200_JMJL());

            Console.WriteLine(produtos_JMJL.MediaStock_JMJL());

            foreach (var p in produtos_JMJL.Produtos3MaisQue50_JMJL())
                Console.WriteLine(p);

            foreach (var p in produtos_JMJL.Produtos4E5ComC_JMJL())
                Console.WriteLine(p);

            foreach (var p in produtos_JMJL.ProdutosCategoriaNome_JMJL())
                Console.WriteLine(p);

            foreach (var grupo in produtos_JMJL.CategoriaEProdutos_JMJL())
            {
                Console.WriteLine($"\nCategoria: {grupo.Key}");
                foreach (var product in grupo)
                    Console.WriteLine(product);
            }

            Console.WriteLine("\nExemplo de Venda\n");
            Stock_JMJL stock_JMJL = new Stock_JMJL();
            Product_JMJL p1_JMJL = produtos_JMJL[2];

            stock_JMJL[p1_JMJL] = p1_JMJL.UnitsInStock_JMJL;
            Console.WriteLine("Stock anterior à venda:\n" + stock_JMJL[p1_JMJL]);

            stock_JMJL.Venda_JMJL(p1_JMJL, 5);
            Console.WriteLine("Quantidade em stock após a venda:\n" + stock_JMJL[p1_JMJL]);
            Console.WriteLine("Stock atualizado do produto:\n" + p1_JMJL.UnitsInStock_JMJL); 


        }

        private static List<Product_JMJL> CriarProdutos()
        {
            Product_JMJL[] productList_JMJL =
            {
                new Product_JMJL
                    {
                        ProductId_JMJL = 1,
                        ProductName_JMJL = "Chai",
                        Category_JMJL = "Beverages",
                        UnitPrice_JMJL = 18.0000M,
                        UnitsInStock_JMJL = 39
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 2,
                        ProductName_JMJL = "Chang",
                        Category_JMJL = "Beverages",
                        UnitPrice_JMJL = 19.0000M,
                        UnitsInStock_JMJL = 17
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 3,
                        ProductName_JMJL = "Aniseed Syrup",
                        Category_JMJL = "Condiments",
                        UnitPrice_JMJL = 10.0000M,
                        UnitsInStock_JMJL = 13
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 4,
                        ProductName_JMJL = "Chef Anton's Cajun Seasoning",
                        Category_JMJL = "Condiments",
                        UnitPrice_JMJL = 22.0000M,
                        UnitsInStock_JMJL = 53
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 5,
                        ProductName_JMJL = "Chef Anton's Gumbo Mix",
                        Category_JMJL = "Condiments",
                        UnitPrice_JMJL = 21.3500M,
                        UnitsInStock_JMJL = 0
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 6,
                        ProductName_JMJL = "Grandma's Boysenberry Spread",
                        Category_JMJL = "Condiments",
                        UnitPrice_JMJL = 25.0000M,
                        UnitsInStock_JMJL = 120
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 7,
                        ProductName_JMJL = "Uncle Bob's Organic Dried Pears",
                        Category_JMJL = "Produce",
                        UnitPrice_JMJL = 30.0000M,
                        UnitsInStock_JMJL = 15
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 8,
                        ProductName_JMJL = "Northwoods Cranberry Sauce",
                        Category_JMJL = "Condiments",
                        UnitPrice_JMJL = 40.0000M,
                        UnitsInStock_JMJL = 6
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 9,
                        ProductName_JMJL = "Mishi Kobe Niku",
                        Category_JMJL = "Meat/Poultry",
                        UnitPrice_JMJL = 97.0000M,
                        UnitsInStock_JMJL = 29
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 10,
                        ProductName_JMJL = "Ikura",
                        Category_JMJL = "Seafood",
                        UnitPrice_JMJL = 31.0000M,
                        UnitsInStock_JMJL = 31
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 11,
                        ProductName_JMJL = "Queso Cabrales",
                        Category_JMJL = "Dairy Products",
                        UnitPrice_JMJL = 21.0000M,
                        UnitsInStock_JMJL = 22
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 12,
                        ProductName_JMJL = "Queso Manchego La Pastora",
                        Category_JMJL = "Dairy Products",
                        UnitPrice_JMJL = 38.0000M,
                        UnitsInStock_JMJL = 86
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 13,
                        ProductName_JMJL = "Konbu",
                        Category_JMJL = "Seafood",
                        UnitPrice_JMJL = 6.0000M,
                        UnitsInStock_JMJL = 24
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 14,
                        ProductName_JMJL = "Tofu",
                        Category_JMJL = "Produce",
                        UnitPrice_JMJL = 23.2500M,
                        UnitsInStock_JMJL = 35
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 15,
                        ProductName_JMJL = "Genen Shouyu",
                        Category_JMJL = "Condiments",
                        UnitPrice_JMJL = 15.5000M,
                        UnitsInStock_JMJL = 39
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 16,
                        ProductName_JMJL = "Pavlova",
                        Category_JMJL = "Confections",
                        UnitPrice_JMJL = 17.4500M,
                        UnitsInStock_JMJL = 29
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 17,
                        ProductName_JMJL = "Alice Mutton",
                        Category_JMJL = "Meat/Poultry",
                        UnitPrice_JMJL = 39.0000M,
                        UnitsInStock_JMJL = 0
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 18,
                        ProductName_JMJL = "Carnarvon Tigers",
                        Category_JMJL = "Seafood",
                        UnitPrice_JMJL = 62.5000M,
                        UnitsInStock_JMJL = 42
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 19,
                        ProductName_JMJL = "Teatime Chocolate Biscuits",
                        Category_JMJL = "Confections",
                        UnitPrice_JMJL = 9.2000M,
                        UnitsInStock_JMJL = 25
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 20,
                        ProductName_JMJL = "Sir Rodney's Marmalade",
                        Category_JMJL = "Confections",
                        UnitPrice_JMJL = 81.0000M,
                        UnitsInStock_JMJL = 40
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 21,
                        ProductName_JMJL = "Sir Rodney's Scones",
                        Category_JMJL = "Confections",
                        UnitPrice_JMJL = 10.0000M,
                        UnitsInStock_JMJL = 3
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 22,
                        ProductName_JMJL = "Gustaf's Knäckebröd",
                        Category_JMJL = "Grains/Cereals",
                        UnitPrice_JMJL = 21.0000M,
                        UnitsInStock_JMJL = 104
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 23,
                        ProductName_JMJL = "Tunnbröd",
                        Category_JMJL = "Grains/Cereals",
                        UnitPrice_JMJL = 9.0000M,
                        UnitsInStock_JMJL = 61
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 24,
                        ProductName_JMJL = "Guaraná Fantástica",
                        Category_JMJL = "Beverages",
                        UnitPrice_JMJL = 4.5000M,
                        UnitsInStock_JMJL = 20
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 25,
                        ProductName_JMJL = "NuNuCa Nuß-Nougat-Creme",
                        Category_JMJL = "Confections",
                        UnitPrice_JMJL = 14.0000M,
                        UnitsInStock_JMJL = 76
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 26,
                        ProductName_JMJL = "Gumbär Gummibärchen",
                        Category_JMJL = "Confections",
                        UnitPrice_JMJL = 31.2300M,
                        UnitsInStock_JMJL = 15
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 27,
                        ProductName_JMJL = "Schoggi Schokolade",
                        Category_JMJL = "Confections",
                        UnitPrice_JMJL = 43.9000M,
                        UnitsInStock_JMJL = 49
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 28,
                        ProductName_JMJL = "Rössle Sauerkraut",
                        Category_JMJL = "Produce",
                        UnitPrice_JMJL = 45.6000M,
                        UnitsInStock_JMJL = 26
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 29,
                        ProductName_JMJL = "Thüringer Rostbratwurst",
                        Category_JMJL = "Meat/Poultry",
                        UnitPrice_JMJL = 123.7900M,
                        UnitsInStock_JMJL = 0
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 30,
                        ProductName_JMJL = "Nord-Ost Matjeshering",
                        Category_JMJL = "Seafood",
                        UnitPrice_JMJL = 25.8900M,
                        UnitsInStock_JMJL = 10
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 31,
                        ProductName_JMJL = "Gorgonzola Telino",
                        Category_JMJL = "Dairy Products",
                        UnitPrice_JMJL = 12.5000M,
                        UnitsInStock_JMJL = 0
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 32,
                        ProductName_JMJL = "Mascarpone Fabioli",
                        Category_JMJL = "Dairy Products",
                        UnitPrice_JMJL = 32.0000M,
                        UnitsInStock_JMJL = 9
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 33,
                        ProductName_JMJL = "Geitost",
                        Category_JMJL = "Dairy Products",
                        UnitPrice_JMJL = 2.5000M,
                        UnitsInStock_JMJL = 112
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 34,
                        ProductName_JMJL = "Sasquatch Ale",
                        Category_JMJL = "Beverages",
                        UnitPrice_JMJL = 14.0000M,
                        UnitsInStock_JMJL = 111
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 35,
                        ProductName_JMJL = "Steeleye Stout",
                        Category_JMJL = "Beverages",
                        UnitPrice_JMJL = 18.0000M,
                        UnitsInStock_JMJL = 20
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 36,
                        ProductName_JMJL = "Inlagd Sill",
                        Category_JMJL = "Seafood",
                        UnitPrice_JMJL = 19.0000M,
                        UnitsInStock_JMJL = 112
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 37,
                        ProductName_JMJL = "Gravad lax",
                        Category_JMJL = "Seafood",
                        UnitPrice_JMJL = 26.0000M,
                        UnitsInStock_JMJL = 11
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 38,
                        ProductName_JMJL = "Côte de Blaye",
                        Category_JMJL = "Beverages",
                        UnitPrice_JMJL = 263.5000M,
                        UnitsInStock_JMJL = 17
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 39,
                        ProductName_JMJL = "Chartreuse verte",
                        Category_JMJL = "Beverages",
                        UnitPrice_JMJL = 18.0000M,
                        UnitsInStock_JMJL = 69
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 40,
                        ProductName_JMJL = "Boston Crab Meat",
                        Category_JMJL = "Seafood",
                        UnitPrice_JMJL = 18.4000M,
                        UnitsInStock_JMJL = 123
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 41,
                        ProductName_JMJL = "Jack's new Product England Clam Chowder",
                        Category_JMJL = "Seafood",
                        UnitPrice_JMJL = 9.6500M,
                        UnitsInStock_JMJL = 85
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 42,
                        ProductName_JMJL = "Singaporean Hokkien Fried Mee",
                        Category_JMJL = "Grains/Cereals",
                        UnitPrice_JMJL = 14.0000M,
                        UnitsInStock_JMJL = 26
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 43,
                        ProductName_JMJL = "Ipoh Coffee",
                        Category_JMJL = "Beverages",
                        UnitPrice_JMJL = 46.0000M,
                        UnitsInStock_JMJL = 17
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 44,
                        ProductName_JMJL = "Gula Malacca",
                        Category_JMJL = "Condiments",
                        UnitPrice_JMJL = 19.4500M,
                        UnitsInStock_JMJL = 27
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 45,
                        ProductName_JMJL = "Rogede sild",
                        Category_JMJL = "Seafood",
                        UnitPrice_JMJL = 9.5000M,
                        UnitsInStock_JMJL = 5
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 46,
                        ProductName_JMJL = "Spegesild",
                        Category_JMJL = "Seafood",
                        UnitPrice_JMJL = 12.0000M,
                        UnitsInStock_JMJL = 95
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 47,
                        ProductName_JMJL = "Zaanse koeken",
                        Category_JMJL = "Confections",
                        UnitPrice_JMJL = 9.5000M,
                        UnitsInStock_JMJL = 36
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 48,
                        ProductName_JMJL = "Chocolade",
                        Category_JMJL = "Confections",
                        UnitPrice_JMJL = 12.7500M,
                        UnitsInStock_JMJL = 15
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 49,
                        ProductName_JMJL = "Maxilaku",
                        Category_JMJL = "Confections",
                        UnitPrice_JMJL = 20.0000M,
                        UnitsInStock_JMJL = 10
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 50,
                        ProductName_JMJL = "Valkoinen suklaa",
                        Category_JMJL = "Confections",
                        UnitPrice_JMJL = 16.2500M,
                        UnitsInStock_JMJL = 65
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 51,
                        ProductName_JMJL = "Manjimup Dried Apples",
                        Category_JMJL = "Produce",
                        UnitPrice_JMJL = 53.0000M,
                        UnitsInStock_JMJL = 20
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 52,
                        ProductName_JMJL = "Filo Mix",
                        Category_JMJL = "Grains/Cereals",
                        UnitPrice_JMJL = 7.0000M,
                        UnitsInStock_JMJL = 38
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 53,
                        ProductName_JMJL = "Perth Pasties",
                        Category_JMJL = "Meat/Poultry",
                        UnitPrice_JMJL = 32.8000M,
                        UnitsInStock_JMJL = 0
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 54,
                        ProductName_JMJL = "Tourtière",
                        Category_JMJL = "Meat/Poultry",
                        UnitPrice_JMJL = 7.4500M,
                        UnitsInStock_JMJL = 21
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 55,
                        ProductName_JMJL = "Pâté chinois",
                        Category_JMJL = "Meat/Poultry",
                        UnitPrice_JMJL = 24.0000M,
                        UnitsInStock_JMJL = 115
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 56,
                        ProductName_JMJL = "Gnocchi di nonna Alice",
                        Category_JMJL = "Grains/Cereals",
                        UnitPrice_JMJL = 38.0000M,
                        UnitsInStock_JMJL = 21
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 57,
                        ProductName_JMJL = "Ravioli Angelo",
                        Category_JMJL = "Grains/Cereals",
                        UnitPrice_JMJL = 19.5000M,
                        UnitsInStock_JMJL = 36
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 58,
                        ProductName_JMJL = "Escargots de Bourgogne",
                        Category_JMJL = "Seafood",
                        UnitPrice_JMJL = 13.2500M,
                        UnitsInStock_JMJL = 62
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 59,
                        ProductName_JMJL = "Raclette Courdavault",
                        Category_JMJL = "Dairy Products",
                        UnitPrice_JMJL = 55.0000M,
                        UnitsInStock_JMJL = 79
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 60,
                        ProductName_JMJL = "Camembert Pierrot",
                        Category_JMJL = "Dairy Products",
                        UnitPrice_JMJL = 34.0000M,
                        UnitsInStock_JMJL = 19
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 61,
                        ProductName_JMJL = "Sirop d'érable",
                        Category_JMJL = "Condiments",
                        UnitPrice_JMJL = 28.5000M,
                        UnitsInStock_JMJL = 113
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 62,
                        ProductName_JMJL = "Tarte au sucre",
                        Category_JMJL = "Confections",
                        UnitPrice_JMJL = 49.3000M,
                        UnitsInStock_JMJL = 17
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 63,
                        ProductName_JMJL = "Vegie-spread",
                        Category_JMJL = "Condiments",
                        UnitPrice_JMJL = 43.9000M,
                        UnitsInStock_JMJL = 24
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 64,
                        ProductName_JMJL = "Wimmers gute Semmelknödel",
                        Category_JMJL = "Grains/Cereals",
                        UnitPrice_JMJL = 33.2500M,
                        UnitsInStock_JMJL = 22
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 65,
                        ProductName_JMJL = "Louisiana Fiery Hot Pepper Sauce",
                        Category_JMJL = "Condiments",
                        UnitPrice_JMJL = 21.0500M,
                        UnitsInStock_JMJL = 76
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 66,
                        ProductName_JMJL = "Louisiana Hot Spiced Okra",
                        Category_JMJL = "Condiments",
                        UnitPrice_JMJL = 17.0000M,
                        UnitsInStock_JMJL = 4
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 67,
                        ProductName_JMJL = "Laughing Lumberjack Lager",
                        Category_JMJL = "Beverages",
                        UnitPrice_JMJL = 14.0000M,
                        UnitsInStock_JMJL = 52
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 68,
                        ProductName_JMJL = "Scottish Longbreads",
                        Category_JMJL = "Confections",
                        UnitPrice_JMJL = 12.5000M,
                        UnitsInStock_JMJL = 6
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 69,
                        ProductName_JMJL = "Gudbrandsdalsost",
                        Category_JMJL = "Dairy Products",
                        UnitPrice_JMJL = 36.0000M,
                        UnitsInStock_JMJL = 26
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 70,
                        ProductName_JMJL = "Outback Lager",
                        Category_JMJL = "Beverages",
                        UnitPrice_JMJL = 15.0000M,
                        UnitsInStock_JMJL = 15
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 71,
                        ProductName_JMJL = "Flotemysost",
                        Category_JMJL = "Dairy Products",
                        UnitPrice_JMJL = 21.5000M,
                        UnitsInStock_JMJL = 26
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 72,
                        ProductName_JMJL = "Mozzarella di Giovanni",
                        Category_JMJL = "Dairy Products",
                        UnitPrice_JMJL = 34.8000M,
                        UnitsInStock_JMJL = 14
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 73,
                        ProductName_JMJL = "Röd Kaviar",
                        Category_JMJL = "Seafood",
                        UnitPrice_JMJL = 15.0000M,
                        UnitsInStock_JMJL = 101
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 74,
                        ProductName_JMJL = "Longlife Tofu",
                        Category_JMJL = "Produce",
                        UnitPrice_JMJL = 10.0000M,
                        UnitsInStock_JMJL = 4
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 75,
                        ProductName_JMJL = "Rhönbräu Klosterbier",
                        Category_JMJL = "Beverages",
                        UnitPrice_JMJL = 7.7500M,
                        UnitsInStock_JMJL = 125
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 76,
                        ProductName_JMJL = "Lakkalikööri",
                        Category_JMJL = "Beverages",
                        UnitPrice_JMJL = 18.0000M,
                        UnitsInStock_JMJL = 57
                    },
                    new Product_JMJL
                    {
                        ProductId_JMJL = 77,
                        ProductName_JMJL = "Original Frankfurter grüne Soße",
                        Category_JMJL = "Condiments",
                        UnitPrice_JMJL = 13.0000M,
                        UnitsInStock_JMJL = 32
                    }
            };
            return new List<Product_JMJL>(productList_JMJL);
        }

    }
    
}

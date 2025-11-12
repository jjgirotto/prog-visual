namespace LAB06_GrupoB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = BookStore.Books;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Lista de livros: \n");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\nNivel 1 * ************************");
            var todos = from i in books select i;
            foreach (Book b in todos)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("\nLivros de História * ************************");

            var livrosHistoria = from i in books where i.Category == "História" select i;
            foreach (Book b in livrosHistoria)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("\nLivros por Título * ************************");

            var livrosPorTitulo = from i in books orderby i.Title select i.Title;
            foreach (String b in livrosPorTitulo)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("\nNivel 2 *************************");
            var livrosDepois1950 = from i in books where i.Year > 1950 orderby i.Year select new { Title = i.Title, Year = i.Year };
            foreach (var b in livrosDepois1950)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("\nExecução imediata");

            var livrosDepois1950Imeadiata = (from i in books where i.Year > 1950 orderby i.Year
                                             select new { Title = i.Title, Year = i.Year }).ToList();
            foreach (var b in livrosDepois1950Imeadiata)
            {
                Console.WriteLine(b);
            }

            books.Add(new Book
            {
                BookId = 51,
                Title = "Jubiabá",
                Author = "Jorge Amado",
                Category = "Ficção",
                Year = 1978,
                Pages = 204,
                Price = 21.99m
            });

            books.Add(new Book
            {
                BookId = 52,
                Title = "O Chão Que Ela Pisa",
                Author = "Salmon Rushdie",
                Category = "Ficção",
                Year = 1998,
                Pages = 560,
                Price = 25.99m
            });

            Console.WriteLine("\nExecução diferida - após adicionar 2 livros");

            foreach (var b in livrosDepois1950)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("\nExecução imediata - após adicionar 2 livros");

            foreach (var b in livrosDepois1950Imeadiata)
            {
                Console.WriteLine(b);
            }
            
            decimal media = books.Average(b => b.Price);
            Console.WriteLine($"\nMédia de preço: {media:F2} €");

            Console.WriteLine("\nNivel 3 *************************");
            decimal mediaPorPaginaLivrosHistoria = (from b in books where b.Category == "História" select b.Price / b.Pages).Average();
            var livrosComMediaPorPagina = from b in books where b.Category == "História" select new { Title = b.Title,
                                                 Author = b.Author, PricePerPage = Math.Round(b.Price / b.Pages, 2) };
            foreach (var b in livrosComMediaPorPagina)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine($"\nMédia geral (História): {mediaPorPaginaLivrosHistoria:F2} € por página");

            decimal precoMaximo = (from b in books select b.Price).Max();
            decimal precoMinimo = (from b in books select b.Price).Min();
            Console.WriteLine("Preço máximo: " + precoMaximo + " €");
            Console.WriteLine("Preço mínimo: " + precoMinimo + " €");

            Console.WriteLine("\nLivros com preço máximo");
            var livrosPrecoMaximo = from b in books where b.Price == precoMaximo select b;
            foreach (Book b in livrosPrecoMaximo)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("\nNivel 4*********************");

            var livrosClassicosOrdemDecrescentePreco = books.OrderByDescending(b => b.Price).Where(b => b.Category == "Clássico");
            foreach (Book b in livrosClassicosOrdemDecrescentePreco)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("\nCategorias sem repetição");
            var categoriasSemRepeticao = books.Select(b => b.Category).Distinct();
            foreach (string b in categoriasSemRepeticao)
            {
                Console.WriteLine(b);
            }

            bool livroApos2000PrecoInferior15 = books.Any(b => b.Year > 2000 && b.Price < 15);
            if (livroApos2000PrecoInferior15)
                Console.WriteLine("\nExiste livro com ano após 2000 com preço menor que 15 €.");
            else Console.WriteLine("\nNão existe livro com ano após 2000 com preço menor que 15 €.");
            
            Console.WriteLine("\nNivel 5 * ********************");
            Console.WriteLine("\nLivros mais caros até o 3º com preço decrescente");
            var livros3MaisCarosPorPrecoDecrescente = books.OrderByDescending(b => b.Price).Take(3);
            foreach (Book b in livros3MaisCarosPorPrecoDecrescente)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("\nLivros mais caros do 3º ao 7º com preço decrescente");
            var livros3ao7MaisCarosPorPrecoDecrescente = books.OrderByDescending(b => b.Price).Skip(2).Take(5);
            foreach (Book b in livros3ao7MaisCarosPorPrecoDecrescente)
            {
                Console.WriteLine(b);
            }

            Book primeiroLivroPrecoMaior15 = books.FirstOrDefault(b => b.Price > 15);
            Console.WriteLine("\nPrimeiro livro com preço maior que 15 €: " + primeiroLivroPrecoMaior15);

            Console.WriteLine("\nNivel 6 * ********************");
            var livrosPorAutor = from b in books group b by b.Author into grupo select grupo;
            foreach (var grupo in livrosPorAutor)
            {
                Console.WriteLine("\nAutor: " + grupo.Key);
                decimal precoTotalPorAutor = grupo.Sum(x => x.Price);
                double mediaPaginas = grupo.Average(x => x.Pages);
                int numeroTotalLivros = grupo.Count();
                Console.WriteLine("\n Preço total: " + precoTotalPorAutor + " € | Média de páginas: " + mediaPaginas + 
                    " | Número total de livros: " + numeroTotalLivros);
            }

            Console.WriteLine("\nNivel 7 * ********************");

            Console.ReadKey();
        }
    }
}

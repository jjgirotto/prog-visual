namespace A10_JulianaLeite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(3);
            nums.Add(5);
            nums.Add(7);

            //LINQ mais simples from <iterador> in <coleção/BD> select i
            //retorna todos os elementos da coleção
            var resultado = from i in nums select i; //definição da query
            Console.WriteLine(resultado);
            //System.Linq.Enumerable+ArraySelectIterator`2[System.Int32,System.Int32]

            Console.WriteLine("\n EXECUÇÂO DEFERIDA");
            foreach (int i in resultado) //execução da query
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nApós alteração");

            //execução deferida é standard no LINQ
            //execução da query/instrução LINQ é deferida pelo que é aplicada à coleção no momento da execução
            nums.Add(10);
            nums.Add(11);
            foreach (int i in resultado) //execução da query
            {
                Console.WriteLine(i); //imprime com 10 e 11
            }

            //se quisermos um snapshot da coleção em determinado momento, podemos forçar execução imediata
            //usando métodos de extensão
            Console.WriteLine("\n EXECUÇÂO IMEDIATA");
            List<int> foto = resultado.ToList();
            foreach (int i in foto) //listagem da variável foto
            {
                Console.WriteLine(i);
            }

            nums.Add(20);
            nums.Add(30);

            Console.WriteLine("\nApós alteração");

            foreach (int i in foto) //listagem da variável foto
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n PROJEÇÃO DE DADOS");
            List<Disciplina> disciplinas = new List<Disciplina>();
            disciplinas.Add(new Disciplina()
            {
                Nome = "Programação Visual",
                TotalDeAlunos = 27,
                Curso = "CTESP TPSI"
            });
            disciplinas.Add(new Disciplina()
            {
                Nome = "Programação Web",
                TotalDeAlunos = 23,
                Curso = "CTESP TPSI"
            });
            disciplinas.Add(new Disciplina()
            {
                Nome = "Gestão",
                TotalDeAlunos = 15,
                Curso = "CTESP TPSI"
            });

            //definimos uma query que quando for executada retorna um IEnumerable<T> com os nomes das UC's
            //que contém Programação
            var duasColunas = from d in disciplinas
                              where d.Nome.Contains("Programação")
                              select new { NOME_DA_UC = d.Nome };

            int totalDeUCsComProgramacaoNoNome = duasColunas.Count();
            Console.WriteLine(totalDeUCsComProgramacaoNoNome);

            foreach (var nome in duasColunas)
            {
                Console.WriteLine(nome);
            }
        }
    }
}

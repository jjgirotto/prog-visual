using System.Security.Cryptography.X509Certificates;
using TUT05_JuliaMizuguchiJuliaJMJLLeite;

namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* 2 Listas - List<T> " +
                "\n*** Listas são coleções de elementos indexados " +
                "\n*** e possivelmente repetidos" +
                "\n*** Abordaremos apenas as listas parametrizadas" +
                "\n*** List<T> onde T é o tipo de dados passível" +
                "\n*** de armazenar na lista");
            // Declaração de uma lista de inteiros
            List<int> listaDeInteiros_JMJL;
            // Criação da lista (ou inicialização da variável
            listaDeInteiros_JMJL = new List<int>();
            // Inicialização dos elementos da lista
            for (int i = 0; i < 10; i++)
                listaDeInteiros_JMJL.Add(i);
            foreach (int i in listaDeInteiros_JMJL)
                Console.Write(i + " - ");
            int soma_JMJL = 0;
            foreach (int i in listaDeInteiros_JMJL)
                soma_JMJL += i;
            Console.WriteLine("Soma: " + soma_JMJL);
            for (int i = 0; i < 5; i++)
                Console.Write(listaDeInteiros_JMJL[i] + " - ");

            Console.WriteLine("\n\nXXXXXXXXXXXXXXX 3.1 CLASSES");
            CartaoDoCidadao_JMJL cc1_JMJL = new CartaoDoCidadao_JMJL("111111111", new DateTime(2021, 1, 1));
            CartaoDoCidadao_JMJL cc2_JMJL = new CartaoDoCidadao_JMJL("222222222", new DateTime(2022, 2, 1));
            Console.WriteLine("Cartão 1: " + cc1_JMJL);
            Console.WriteLine("Cartão 2: " + cc2_JMJL);

            Console.WriteLine("\nXXXXXXXXXXX 3.2 COMPOSIÇÃO");
            Pessoa_JMJL p1_JMJL = new Pessoa_JMJL("Jorge Candeias", new DateTime(2001, 1, 2), cc1_JMJL);
            Pessoa_JMJL p2_JMJL = new Pessoa_JMJL("Ana Candeias", new DateTime(2002, 3, 4), cc2_JMJL);
            Console.WriteLine("Pessoa 1: " + p1_JMJL);
            Console.WriteLine("Pessoa 2: " + p2_JMJL);

            Console.WriteLine("\nXXXXXXXXXXXXXX 3.3 HERANÇA");
            Aluno_JMJL a1_JMJL = new Aluno_JMJL("Luis Santos", new DateTime(2001, 1, 2), cc1_JMJL, "202000521");
            Aluno_JMJL a2_JMJL = new Aluno_JMJL("Lena Pereira", new DateTime(2002, 3, 4), cc2_JMJL, "202000622");
            Console.WriteLine("Aluno 1: " + a1_JMJL);
            Console.WriteLine("Aluno 2: " + a2_JMJL);

            Console.WriteLine("\nXXXXXXXXXXXXXXX 4.1 COLEÇÕES => List<T>");
            List<Pessoa_JMJL> pessoas = new List<Pessoa_JMJL>();
            pessoas.Add(p1_JMJL);
            pessoas.Add(p2_JMJL);
            pessoas.Add(a1_JMJL);
            pessoas.Add(a2_JMJL);
            foreach (Pessoa_JMJL p in pessoas)
                Console.WriteLine(p);

            Console.WriteLine("\nXXXXXXXXX COLEÇÕES COMPOSTAS POR LISTAS");
            Turma_JMJL turmaB_JMJL = new Turma_JMJL("CTESP-TPSI", 2, 'A');
            turmaB_JMJL.AddAluno_JMJL(a1_JMJL);
            turmaB_JMJL.AddAluno_JMJL(a2_JMJL);
            turmaB_JMJL.AddAluno_JMJL(a1_JMJL);
            turmaB_JMJL.AddAluno_JMJL(a2_JMJL);
            turmaB_JMJL.AddAluno_JMJL(a1_JMJL);
            turmaB_JMJL.AddAluno_JMJL(a2_JMJL);
            Console.WriteLine(turmaB_JMJL);
            turmaB_JMJL.RemoveAluno_JMJL(a1_JMJL); // remove o 1º a1
            turmaB_JMJL.RemoveAt_JMJL(turmaB_JMJL.GetLenght_JMJL() - 1);
            Console.WriteLine("\nXXXX Removeu: \n" + turmaB_JMJL);

            Console.WriteLine("\nLIVRARIA");
            Livro_JMJL l1_JMJL = new Livro_JMJL("Engenharia de Software", "978-3-16-148410-0",
                new Autor_JMJL("Ian Sommerville", "Inglês"), 5);
            Livro_JMJL l2_JMJL = new Livro_JMJL("Programação com C#", "978-3-16-148410-1",
                new Autor_JMJL("Ian Cabreira", "Português"), 10);
            Livraria_JMJL livraria_JMJL = new Livraria_JMJL
            {
                Nome_JMJL = "Livraria do João",
                Nif_JMJL = "123456789",
                Url_JMJL = "www.livrariadojoao.com",
                livros_JMJL = new List<Livro_JMJL> { l1_JMJL, l2_JMJL }
            };
            Console.WriteLine(livraria_JMJL);

            Console.WriteLine("\nXXXXXXXXX COLEÇÕES QUE HERDAM DE List<T>");
            Pessoas_JMJL listaDePessoas_JMJL = new Pessoas_JMJL();
            listaDePessoas_JMJL.Add(p1_JMJL);
            listaDePessoas_JMJL.Add(p2_JMJL);
            listaDePessoas_JMJL.Add(a1_JMJL);
            listaDePessoas_JMJL.Add(a2_JMJL);
            listaDePessoas_JMJL.Add(p1_JMJL);
            listaDePessoas_JMJL.Add(p2_JMJL);
            listaDePessoas_JMJL.Add(a1_JMJL);
            listaDePessoas_JMJL.Add(a2_JMJL);
            Console.WriteLine(listaDePessoas_JMJL);
            listaDePessoas_JMJL.Remove(p1_JMJL);// remove o 1º p1
            listaDePessoas_JMJL.RemoveAt(listaDePessoas_JMJL.Count - 1);
            Console.WriteLine("\nXXXX Removeu: \n" + listaDePessoas_JMJL);

            Console.WriteLine("\nLIVRARIA");
            OsMeusLivros_JMJL listaDeLivros_JMJL = new OsMeusLivros_JMJL();
            listaDeLivros_JMJL.Add(l1_JMJL);
            listaDeLivros_JMJL.Add(l2_JMJL);
            Console.WriteLine(listaDeLivros_JMJL);
            listaDeLivros_JMJL.Remove(l1_JMJL);
            Console.WriteLine("\nXXXX Removeu: \n" + listaDeLivros_JMJL);

            Console.WriteLine("\n************* 5 Conjuntos - HashSet<T> " +
            "\n*** Conjuntos são coleções de elementos: " +
            "\n*** \t\t\t sem ordem nem repetições." +
            "\n*** Significando isto que:" +
            "\n*** 1) não podemos assumir que os elementos estão" +
            "\n*** \t de alguma forma ordenados pelo que também" +
            "\n*** \t não podemos aceder-lhes através de um indice" +
            "\n*** 2) Não podemos inserir/adicionar elementos " +
            "\n*** \t repetidos a um conjunto, cabendo ao programador" +
            "\n*** \t definir o que são dois elementos iguais," +
            "\n*** \t implementando os métodos" +
            "\n*** \t Equals() e" +
            "\n*** \t GetHashCode()" +
            "\n*** \t nas classes o que requeiram");

            Console.WriteLine("\n************* 5.1 HashSet<String>");
            // Declaração de uma variável do tipo um HashSet de Strings
            HashSet<String> nomesDePessoas_JMJL;
            // Criação de um objeto do tipo HashSet de Strings e
            // atribuição do objeto à variável
            nomesDePessoas_JMJL = new HashSet<String>();
            // inicilização do conjunto com nomes repetidos
            nomesDePessoas_JMJL.Add("Ibn Kasi");
            nomesDePessoas_JMJL.Add("Geraldo sem Pavor");
            nomesDePessoas_JMJL.Add("Ibn Kasi");
            nomesDePessoas_JMJL.Add("Dona Berengária");
            foreach (String s in nomesDePessoas_JMJL)
            { Console.WriteLine(s); }
            nomesDePessoas_JMJL.Remove("Dona Berengária");
            nomesDePessoas_JMJL.Add("Dona Sancha");
            Console.WriteLine("\nDepois da remoção e adição:");
            foreach (String s in nomesDePessoas_JMJL)
            { Console.WriteLine(s); }

            HashSet<int> numeros;
            numeros = new HashSet<int>();
            numeros.Add(10);
            numeros.Add(11);
            numeros.Add(11); //11 repetido
            numeros.Add(20);
            numeros.Add(22);
            numeros.Add(22); //22 repetido
            foreach (int n in numeros)
            { Console.WriteLine(n); }
            // imprimiu 10,11,20,22 sem repetições, HashSet<T> não permite elementos duplicados.
            // As tentativas de readicionar os valores 11 e 22 são simplesmente ignoradas

            Console.WriteLine("\n** 5.2 Classe com conjunto de Aluno_JMJL");
            TurmaComConjunto_JMJL turmaComConjunto_JMJL;
            turmaComConjunto_JMJL = new TurmaComConjunto_JMJL("TPSI", 1, 'B');
            turmaComConjunto_JMJL.AddAluno_JMJL(a1_JMJL);
            turmaComConjunto_JMJL.AddAluno_JMJL(a2_JMJL);
            turmaComConjunto_JMJL.AddAluno_JMJL(new Aluno_JMJL("Siznando Simeão",
                new DateTime(1141, 2, 23),
                new CartaoDoCidadao_JMJL("123987456",
                    new DateTime(1150, 12, 25)),
                "2025123123"));

            turmaComConjunto_JMJL.AddAluno_JMJL(new Aluno_JMJL("Siznanda Simeão",
                new DateTime(1141, 2, 23),
                new CartaoDoCidadao_JMJL("123987456",
                    new DateTime(1150, 12, 25)),
                "2025123123"));

            turmaComConjunto_JMJL.AddAluno_JMJL(new Aluno_JMJL("Sezimando Simão",
                new DateTime(1140, 3, 24),
                new CartaoDoCidadao_JMJL("987654321",
                    new DateTime(1151, 12, 25)),
                "2025123124"));

            turmaComConjunto_JMJL.AddAluno_JMJL(new Aluno_JMJL("Sezimanda Simão",
                new DateTime(1140, 3, 24),
                new CartaoDoCidadao_JMJL("987654321",
                    new DateTime(1151, 12, 25)),
                "2025123124"));

            // Note que pudemos adicionar objetos com os mesmos valores nos campos
            // CartaoDoCidadao_JMJL e Numero_JMJL porque, obviamente o C# não pode saber
            // o que é que nós programadores consideramos "dois alunos iguais"
            // temos assim que definir o que são dois alunos iguais:
            // Vamos considerar que dois alunos são iguais se os seus números
            // de aluno foram iguais e assim sendo, vamos definir
            // os métodos Equals e GetHashCode na classe Aluno_JMJL
            Console.WriteLine(turmaComConjunto_JMJL);

            Console.WriteLine("\nPESSOAS");
            ConjuntoDePessoas_JMJL conjuntoDePessoas_JMJL;
            conjuntoDePessoas_JMJL = new ConjuntoDePessoas_JMJL();
            conjuntoDePessoas_JMJL.Add(p1_JMJL);
            conjuntoDePessoas_JMJL.Add(p2_JMJL);
            conjuntoDePessoas_JMJL.Add(new Pessoa_JMJL("Julia Mizuguchi", new DateTime(2004, 6, 21),
                new CartaoDoCidadao_JMJL("987654321", new DateTime(2050, 12, 25))));
            conjuntoDePessoas_JMJL.Add(new Pessoa_JMJL("Juliana Leite", new DateTime(1996, 8, 8),
                new CartaoDoCidadao_JMJL("988644456", new DateTime(2050, 12, 25))));
            conjuntoDePessoas_JMJL.Add(new Pessoa_JMJL("Julia Matias Mizuguchi", new DateTime(2004, 6, 21),
                new CartaoDoCidadao_JMJL("987654321", new DateTime(2050, 12, 25))));
            conjuntoDePessoas_JMJL.Add(new Pessoa_JMJL("Juliana Girotto Leite", new DateTime(1996, 8, 8),
                new CartaoDoCidadao_JMJL("988644456", new DateTime(2050, 12, 25))));
            Console.WriteLine(conjuntoDePessoas_JMJL);
            //segunda Julia e segunda Juliana não foram adicionadas ao conjunto (possuem mesmo número de cartão de cidadão)

            Console.WriteLine("\n**************** 6 Tabelas - Dictionary<K,V>" +
            "\n*** Tabelas são coleções de pares " +
            "\n*** \t\t chave (Key,K) - valor (Value, V): " +
            "\n*** Significando isto que:" +
            "\n*** 1) Uma tabela não pode ter chaves repetidas" +
            "\n*** 2) Mas pode ter valores repetidos " +
            "\n*** 3) Entenda-se o conceito de chaves iguais" +
            "\n*** \t tal como o dedos elementos iguais para os" +
            "\n*** \t conjuntos anteriormente abordados" +
            "\n*** 4) É fácil reconhecer nos Dictionary o" +
            "\n*** \t equivalente aos Map<K,V> do java");

            //Declaração da tabela
            Dictionary<Aluno_JMJL, int> notasDePv_JMJL;
            // Criação da tabela
            notasDePv_JMJL = new Dictionary<Aluno_JMJL, int>();
            //Inicialização de pares <chave, valor>
            notasDePv_JMJL.TryAdd(a1_JMJL, 10);
            notasDePv_JMJL.TryAdd(a1_JMJL, 15);
            notasDePv_JMJL.TryAdd(a2_JMJL, 10);
            notasDePv_JMJL.TryAdd(new Aluno_JMJL("Siznando Simeão", new DateTime(1141, 2, 23),
                new CartaoDoCidadao_JMJL("123987456", new DateTime(1150, 12, 25)), "2025123123"), 10);
            notasDePv_JMJL.TryAdd(new Aluno_JMJL("Siznanda Simeão", new DateTime(1141, 2, 23),
                new CartaoDoCidadao_JMJL("123987456", new DateTime(1150, 12, 25)), "2025116166"), 10);
            //Alteração da nota do aluno a1
            notasDePv_JMJL[a1_JMJL] = 14;
            Aluno_JMJL? alunoEncontrado_JMJL = null;
            
            //Iteração pelas chaves
            foreach (Aluno_JMJL a in notasDePv_JMJL.Keys)
            {
                if (a.NumeroDeAluno_JMJL.Equals("2025123123")) alunoEncontrado_JMJL = a;
            }
            notasDePv_JMJL[alunoEncontrado_JMJL] = 14;

            Console.WriteLine("\n**************** Notas");
            //Iteração pelos valores
            foreach (int i in notasDePv_JMJL.Values) Console.WriteLine(i);

            Console.WriteLine("\n**************** Alunos e Notas");
            //Iteração por chave e valor
            //foreach (KeyValuePair<Aluno_JMJL, int> par in notasDePv_JMJL) Console.WriteLine(par);
            foreach (var v in notasDePv_JMJL) Console.WriteLine(v.Value + " - " + v.Key);

            Console.WriteLine("\nLIVRARIA");
            LivrariaComStock_JMJL livrariaComStock_JMJL = new LivrariaComStock_JMJL("Livraria Ju's");
            livrariaComStock_JMJL.AdicionarLivro(l1_JMJL, 0);
            livrariaComStock_JMJL.AdicionarLivro(l2_JMJL, 5);
            livrariaComStock_JMJL.AdicionarLivro(l2_JMJL, 5);
            Console.WriteLine(livrariaComStock_JMJL);

            Console.WriteLine("\nLIVRARIA TABELA");
            LivrariaTabela_JMJL livrariaTabela_JMJL = new LivrariaTabela_JMJL("Livraria JULIA E JULIANA");
            Livro_JMJL livro1 = new Livro_JMJL("O Senhor dos Anéis", "978-0618640157",
                new Autor_JMJL("J.R.R. Tolkien", "Inglês"), 0);
            Livro_JMJL livro2 = new Livro_JMJL("1984", "978-0451524935",
                new Autor_JMJL("George Orwell", "Inglês"), 1);
            Livro_JMJL livro3 = new Livro_JMJL("Duna", "978-0441172719",
                new Autor_JMJL("Frank Herbert", "Francês"), 3);
            livrariaTabela_JMJL.AdicionarLivro(livro1, 50);
            livrariaTabela_JMJL.AdicionarLivro(livro2, 30);
            livrariaTabela_JMJL.AdicionarLivro(livro3, 40);
            Console.WriteLine(livrariaTabela_JMJL);
            // adicionar mais stock a um livro existente
            Console.WriteLine("\n--- A adicionar 10 unidades ao livro '1984' ---");
            livrariaTabela_JMJL.AdicionarLivro(livro2, 10); // Deve somar 10 aos 30 existentes
            Console.WriteLine(livrariaTabela_JMJL);


        }
    }
}

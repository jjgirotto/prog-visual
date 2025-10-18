namespace T04_Pratica_JuliaMizuguchiJulianaLeite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cartão
            Console.WriteLine("Cartão do Cidadão");
            Console.WriteLine("Antes do set");
            CartaoDoCidadao_JMJL cartao1_JMJL = new CartaoDoCidadao_JMJL("123", "Juliana");
            CartaoDoCidadao_JMJL cartao2_JMJL = new CartaoDoCidadao_JMJL();
            Console.WriteLine("Impressão pelo ToString()");
            Console.WriteLine(cartao1_JMJL + "\n" + cartao2_JMJL);
            cartao2_JMJL.Numero_JMJL = "124";
            cartao2_JMJL.Nome_JMJL="Ana";
            Console.WriteLine("Depois do set - impressão pelo Get()");
            Console.WriteLine("NCC: " + cartao2_JMJL.Numero_JMJL + " - " + cartao2_JMJL.Nome_JMJL);

            //cidadao
            Console.WriteLine("\nCidadão");
            Console.WriteLine("Antes do set");
            Cidadao_JMJL c1_JMJL = new Cidadao_JMJL(cartao1_JMJL, new DateTime(1990, 1, 1, 10, 14, 15));
            Cidadao_JMJL c2_JMJL = new Cidadao_JMJL();
            Console.WriteLine("Impressão pelo ToString()");
            Console.WriteLine(c1_JMJL + "\n" + c2_JMJL);
            c2_JMJL.CartaoDoCidadao_JMJL = cartao2_JMJL;
            c2_JMJL.DataNascimento_JMJL = new DateTime(1996, 10, 14, 18, 55, 00);
            Console.WriteLine("Depois do set - impressão pelo Get()");
            Console.WriteLine(c2_JMJL.CartaoDoCidadao_JMJL + " - " + c2_JMJL.DataNascimento_JMJL);

            //aluno
            Console.WriteLine("\nAluno");
            Console.WriteLine("Antes do set");
            Aluno_JMJL aluno1_JMJL = new Aluno_JMJL(cartao1_JMJL, DateTime.Now, "111", "aluno@email.com");
            Aluno_JMJL aluno2_JMJL = new Aluno_JMJL();
            Console.WriteLine("Impressão pelo ToString()");
            Console.WriteLine(aluno1_JMJL + "\n" + aluno2_JMJL);
            aluno2_JMJL.CartaoDoCidadao_JMJL = cartao2_JMJL;
            aluno2_JMJL.DataNascimento_JMJL= DateTime.Now;
            aluno2_JMJL.NumeroAluno_JMJL="112";
            aluno2_JMJL.Email_JMJL="email@email.com";
            Console.WriteLine("Depois do set - impressão pelo Get()");
            Console.WriteLine("Aluno " + aluno2_JMJL.NumeroAluno_JMJL + " " + aluno2_JMJL.CartaoDoCidadao_JMJL + " - " + aluno2_JMJL.DataNascimento_JMJL);

            //docente
            Console.WriteLine("\nDocente");
            Console.WriteLine("Antes do set");
            Docente_JMJL docente1_JMJL = new Docente_JMJL(cartao1_JMJL, DateTime.Now, "222", "Coordenador");
            Docente_JMJL docente2_JMJL = new Docente_JMJL();
            Console.WriteLine("Impressão pelo ToString()");
            Console.WriteLine(docente1_JMJL + "\n" + docente2_JMJL);
            docente2_JMJL.CartaoDoCidadao_JMJL=cartao2_JMJL;
            docente2_JMJL.DataNascimento_JMJL=DateTime.Now;
            docente2_JMJL.CategoriaProfissional_JMJL="224";
            docente2_JMJL.Gabinete_JMJL="Adjunto";
            Console.WriteLine("Depois do set - impressão pelo Get()");
            Console.WriteLine("Docente " + docente2_JMJL.CategoriaProfissional_JMJL + " - " + docente2_JMJL.Gabinete_JMJL + " " + docente2_JMJL.CartaoDoCidadao_JMJL + " - " + docente2_JMJL.DataNascimento_JMJL);
            Console.ReadKey();
        }
    }
}

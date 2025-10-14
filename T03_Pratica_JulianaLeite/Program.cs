namespace T03_Pratica_JulianaLeite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cartão
            Console.WriteLine("Cartão do Cidadão");
            Console.WriteLine("Antes do set");
            CartaoDoCidadao_JL cartao1_JL = new CartaoDoCidadao_JL("123", "Juliana");
            CartaoDoCidadao_JL cartao2_JL = new CartaoDoCidadao_JL();
            Console.WriteLine("Impressão pelo ToString()");
            Console.WriteLine(cartao1_JL + "\n" + cartao2_JL);
            cartao2_JL.SetNumero_JL("124");
            cartao2_JL.SetNome_JL("Ana");
            Console.WriteLine("Depois do set - impressão pelo Get()");
            Console.WriteLine("NCC: " + cartao2_JL.GetNumero_JL() + " - " + cartao2_JL.GetNome_JL());

            //cidadao
            Console.WriteLine("\nCidadão");
            Console.WriteLine("Antes do set");
            Cidadao_JL c1_JL = new Cidadao_JL(cartao1_JL, new DateTime(1990, 1, 1, 10, 14, 15));
            Cidadao_JL c2_JL = new Cidadao_JL();
            Console.WriteLine("Impressão pelo ToString()");
            Console.WriteLine(c1_JL + "\n" + c2_JL);
            c2_JL.SetCartaoDoCidadao_JL(cartao2_JL);
            c2_JL.SetDataNascimento_JL(new DateTime(1996, 10, 14, 18, 55, 00));
            Console.WriteLine("Depois do set - impressão pelo Get()");
            Console.WriteLine(c2_JL.GetCartaoDoCidadao_JL() + " - " + c2_JL.GetDataNascimento_JL());

            //aluno
            Console.WriteLine("\nAluno");
            Console.WriteLine("Antes do set");
            Aluno_JL aluno1_JL = new Aluno_JL(cartao1_JL, DateTime.Now, "111", "aluno@email.com");
            Aluno_JL aluno2_JL = new Aluno_JL();
            Console.WriteLine("Impressão pelo ToString()");
            Console.WriteLine(aluno1_JL + "\n" + aluno2_JL);
            aluno2_JL.SetCartaoDoCidadao_JL(cartao2_JL);
            aluno2_JL.SetDataNascimento_JL(DateTime.Now);
            aluno2_JL.SetNumeroAluno_JL("112");
            aluno2_JL.SetEmail_JL("email@email.com");
            Console.WriteLine("Depois do set - impressão pelo Get()");
            Console.WriteLine("Aluno " + aluno2_JL.GetNumeroAluno_JL() + aluno2_JL.GetCartaoDoCidadao_JL() + " - " + aluno2_JL.GetDataNascimento_JL());

            //docente
            Console.WriteLine("\nDocente");
            Console.WriteLine("Antes do set");
            Docente_JL docente1_JL = new Docente_JL(cartao1_JL, DateTime.Now, "222", "Coordenador");
            Docente_JL docente2_JL = new Docente_JL();
            Console.WriteLine("Impressão pelo ToString()");
            Console.WriteLine(docente1_JL + "\n" + docente2_JL);
            docente2_JL.SetCartaoDoCidadao_JL(cartao2_JL);
            docente2_JL.SetDataNascimento_JL(DateTime.Now);
            docente2_JL.SetCategoriaProfissional_JL("224");
            docente2_JL.SetGabinete_JL("Adjunto");
            Console.WriteLine("Depois do set - impressão pelo Get()");
            Console.WriteLine("Docente " + docente2_JL.GetCategoriaProfissional_JL() + " - " + docente2_JL.GetGabinete_JL() + docente2_JL.GetCartaoDoCidadao_JL() + " - " + docente2_JL.GetDataNascimento_JL());
            Console.ReadKey();
        }
    }
}

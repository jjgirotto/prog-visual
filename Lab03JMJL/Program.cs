namespace PROJETO_LAB03_2025116155_2025116166
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao_JMJL posicao1_JMJL = new Posicao_JMJL('b', 2);
            Posicao_JMJL posicao2_JMJL = new Posicao_JMJL();

            Console.WriteLine("Posição 1: " + posicao1_JMJL);
            Console.WriteLine("\nPosição 2: " + posicao2_JMJL);

            Peca_JMJL peca1_JMJL = new Peao_JMJL(posicao1_JMJL, Cor_JMJL.Branco_JMJL);
            Peca_JMJL peca2_JMJL = new Torre_JMJL(posicao2_JMJL, Cor_JMJL.Preto_JMJL);
            
            Console.WriteLine("\nPeça 1: " + peca1_JMJL);
            Console.WriteLine("\nPeça 2: " + peca2_JMJL);

            Peca_JMJL[] pecas_JMJL = new Peca_JMJL[2];
            pecas_JMJL[0] = peca1_JMJL;
            pecas_JMJL[1] = peca2_JMJL;

            foreach (Peca_JMJL p in pecas_JMJL)
            {
                Console.WriteLine("\n" + p.GetNome_JMJL());
            }

            peca1_JMJL.Deslocar_JMJL(0, 1);
            peca2_JMJL.Deslocar_JMJL(1, 0);

            Console.WriteLine("\nPeça 1 após deslocar: " + peca1_JMJL);
            Console.WriteLine("\nPeça 2 após deslocar: " + peca2_JMJL);

            Console.WriteLine("\nSímbolo Peça 1: " + peca1_JMJL.GetSimbolo_JMJL());
            Console.WriteLine("\nSímbolo Peça 2: " + peca2_JMJL.GetSimbolo_JMJL());

            Tabuleiro_JMJL tabuleiro_JMJL = new Tabuleiro_JMJL();

            tabuleiro_JMJL.MostrarTabuleiro_JMJL();



        }
    }
}

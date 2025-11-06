using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_LAB03_2025116155_2025116166
{
    internal class Tabuleiro_JMJL
    {
        // 9x9 para incluir letras (coluna extra) e números (linha extra)
        Peca_JMJL[,] tabuleiro = new Peca_JMJL[8, 8];

        public Tabuleiro_JMJL()
        {
            // Peões brancos na linha 2 (índice 1)
            for (int i = 0; i < 8; i++)
            {
                tabuleiro[1, i] = new Peao_JMJL(new Posicao_JMJL((char)('a' + i), 2), Cor_JMJL.Branco_JMJL);
            }

            // Peões pretos na linha 7 (índice 6)
            for (int i = 0; i < 8; i++)
            {
                tabuleiro[6, i] = new Peao_JMJL(new Posicao_JMJL((char)('a' + i), 7), Cor_JMJL.Preto_JMJL);
            }

            tabuleiro[0, 0] = new Torre_JMJL(new Posicao_JMJL('a', 1), Cor_JMJL.Branco_JMJL);
            tabuleiro[0, 7] = new Torre_JMJL(new Posicao_JMJL('h', 1), Cor_JMJL.Branco_JMJL);

            tabuleiro[7, 0] = new Torre_JMJL(new Posicao_JMJL('a', 8), Cor_JMJL.Preto_JMJL);
            tabuleiro[7, 7] = new Torre_JMJL(new Posicao_JMJL('h', 8), Cor_JMJL.Preto_JMJL);

            tabuleiro[0, 1] = new Cavalo_JMJL(new Posicao_JMJL('b', 1), Cor_JMJL.Branco_JMJL);
            tabuleiro[0, 6] = new Cavalo_JMJL(new Posicao_JMJL('g', 1), Cor_JMJL.Branco_JMJL);

            tabuleiro[7, 1] = new Cavalo_JMJL(new Posicao_JMJL('b', 8), Cor_JMJL.Preto_JMJL);
            tabuleiro[7, 6] = new Cavalo_JMJL(new Posicao_JMJL('g', 8), Cor_JMJL.Preto_JMJL);

            tabuleiro[0, 2] = new Bispo_JMJL(new Posicao_JMJL('c', 1), Cor_JMJL.Branco_JMJL);
            tabuleiro[0, 5] = new Bispo_JMJL(new Posicao_JMJL('f', 1), Cor_JMJL.Branco_JMJL);

            tabuleiro[7, 2] = new Bispo_JMJL(new Posicao_JMJL('c', 8), Cor_JMJL.Preto_JMJL);
            tabuleiro[7, 5] = new Bispo_JMJL(new Posicao_JMJL('f', 8), Cor_JMJL.Preto_JMJL);

            tabuleiro[0, 3] = new Rainha_JMJL(new Posicao_JMJL('d', 1), Cor_JMJL.Branco_JMJL);
            tabuleiro[0, 4] = new Rei_JMJL(new Posicao_JMJL('e', 1), Cor_JMJL.Branco_JMJL);

            tabuleiro[7, 3] = new Rainha_JMJL(new Posicao_JMJL('d', 8), Cor_JMJL.Preto_JMJL);
            tabuleiro[7, 4] = new Rei_JMJL(new Posicao_JMJL('e', 8), Cor_JMJL.Preto_JMJL);
        }

        public void MostrarTabuleiro_JMJL()
        {
            // Imprime letras das colunas
            Console.Write("  ");
            for (int j = 0; j < 8; j++)
            {
                Console.Write((char)('a' + j) + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                // Imprime número da linha
                Console.Write((i + 1) + " ");
                for (int j = 0; j < 8; j++)
                {
                    if (tabuleiro[i, j] != null)
                    {
                        Console.Write(tabuleiro[i, j].GetSimbolo_JMJL() + " ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
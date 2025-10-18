using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU04JuliaMizuguchiJulianaLeite
{
    internal class Ecra_JMJL
    {
        private char[][] ecra_JMJL;
        public char this[int x, int y]
        {
            get { return ecra_JMJL[x][y]; }
            set { ecra_JMJL[x][y] = value; }
        }

        public Ecra_JMJL(int largura, int altura)
        {
            ecra_JMJL = new char[altura][];
            for (int x = 0; x < altura; x++)
            {
                ecra_JMJL[x] = new char[largura];
                for (int y = 0; y < largura; y++)
                {
                    ecra_JMJL[x][y] = 'X';
                }
            }
        }

        public override string ToString()
        {
            String tmp = " ";
            for (int y = 0; y < ecra_JMJL.Length; y++)
            {
                tmp += ("\n");
                for (int x = 0; x < ecra_JMJL[0].Length; x++)
                {
                    tmp += ecra_JMJL[y][x] + " ";
                }
            }
            return tmp;
        }
    }
}

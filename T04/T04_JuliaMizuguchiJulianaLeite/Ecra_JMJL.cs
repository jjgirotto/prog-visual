using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04_JuliaMizuguchiJulianaLeite
{
    internal class Ecra_JMJL
    {
        private char[][] ecra_JMJL;
        public char this[int x_JMJL, int y_JMJL]
        {
            get { return ecra_JMJL[x_JMJL][y_JMJL]; }
            set { ecra_JMJL[x_JMJL][y_JMJL] = value; }
        }

        public Ecra_JMJL(int largura_JMJL, int altura_JMJL)
        {
            ecra_JMJL = new char[altura_JMJL][];
            for (int x = 0; x < altura_JMJL; x++)
            {
                ecra_JMJL[x] = new char[largura_JMJL];
                for (int y = 0; y < largura_JMJL; y++)
                {
                    ecra_JMJL[x][y] = 'X';
                }
            }
        }

        public override string ToString()
        {
            String tmp_JMJL = " ";
            for (int y = 0; y < ecra_JMJL.Length; y++)
            {
                tmp_JMJL += ("\n");
                for (int x = 0; x < ecra_JMJL[0].Length; x++)
                {
                    tmp_JMJL += ecra_JMJL[y][x] + " ";
                }
            }
            return tmp_JMJL;
        }
    }
}

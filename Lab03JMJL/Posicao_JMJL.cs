using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_LAB03_2025116155_2025116166
{
    internal class Posicao_JMJL
    {
        char x_JMJL;
        int y_JMJL;

        static char posicaoInicialX_JMJL = 'a';
        static int posicaoInicialY_JMJL = 1;

        public Posicao_JMJL(char x_JMJL, int y_JMJL)
        {
            this.x_JMJL = x_JMJL;
            this.y_JMJL = y_JMJL;
        }

        public Posicao_JMJL() : this(posicaoInicialX_JMJL, posicaoInicialY_JMJL) { }

        public char GetX_JMJL()
        {
            return x_JMJL;
        }

        public int GetY_JMJL()
        {
            return y_JMJL;
        }

        public void setX_JMJL(char x_JMJL)
        {
            this.x_JMJL = x_JMJL;
        }

        public void setY_JMJL(int y_JMJL)
        {
            this.y_JMJL = y_JMJL;
        }

        override
        public string ToString()
        {
            return "" + x_JMJL + y_JMJL;
        }

    }
}

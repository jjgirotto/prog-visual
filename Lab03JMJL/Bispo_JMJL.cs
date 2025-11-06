using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_LAB03_2025116155_2025116166
{
    internal class Bispo_JMJL : Peca_JMJL
    {
        public Bispo_JMJL(Posicao_JMJL posicao_JMJL, Cor_JMJL cor_JMJL) : base(posicao_JMJL, cor_JMJL)
        {
        }

        override
        public string GetSimbolo_JMJL()
        {
            return "B";
        }

        public override void Deslocar_JMJL(int dx_JMJL, int dy_JMJL)
        {
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_LAB03_2025116155_2025116166
{
    internal class Rainha_JMJL : Peca_JMJL
    {
        public Rainha_JMJL(Posicao_JMJL posicao_JMJL, Cor_JMJL cor_JMJL) : base(posicao_JMJL, cor_JMJL)
        {
        }

        override
        public string GetSimbolo_JMJL()
        {
            return "D";
        }

        public override void Deslocar_JMJL(int dx_JMJL, int dy_JMJL)
        {
        }
    }
}

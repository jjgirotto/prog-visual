using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_LAB03_2025116155_2025116166
{
    internal class Peao_JMJL : Peca_JMJL
    {

        public Peao_JMJL(Posicao_JMJL posicao_JMJL, Cor_JMJL cor_JMJL) : base(posicao_JMJL, cor_JMJL)
        {
        }


        override
        public string GetNome_JMJL()
        {
            return "Peão";
        } 

        override
        public string GetSimbolo_JMJL()
        {
            return "P";
        }

        override
        public void Deslocar_JMJL(int dx_JMJL, int dy_JMJL)
        {
            SetY_JMJL(GetY_JMJL() + dy_JMJL);
        }

        override
        public string ToString()
        {
            return base.ToString();
        }
    }
}

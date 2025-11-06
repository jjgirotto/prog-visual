using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_LAB03_2025116155_2025116166
{
    internal class Torre_JMJL : Peca_JMJL
    {

        public Torre_JMJL(Posicao_JMJL posicao_JMJL, Cor_JMJL cor_JMJL) : base(posicao_JMJL, cor_JMJL)
        {
        }

        override
        public string GetNome_JMJL()
        {
            return "Torre";
        }

        override
        public string GetSimbolo_JMJL()
        {
            return "T";
        }

        override
        public void Deslocar_JMJL(int dx_JMJL, int dy_JMJL)
        {
            if (!(dx_JMJL != 0 && dy_JMJL != 0))
            {
                if (dx_JMJL == 0)
                {
                    SetY_JMJL(GetY_JMJL() + dy_JMJL);
                }
                else
                {
                    SetX_JMJL((char)(GetX_JMJL() + dx_JMJL));
                }
            }
        }

        override
        public string ToString()
        {
            return "T" + base.ToString();
        }


    }
}

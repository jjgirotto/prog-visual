using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_LAB03_2025116155_2025116166
{
    internal abstract class Peca_JMJL : IMover_JMJL
    {
        Posicao_JMJL posicao_JMJL;
        Cor_JMJL cor_JMJL;
        string nome_JMJL ;

        public Peca_JMJL(Posicao_JMJL posicao_JMJL, Cor_JMJL cor_JMJL)
        {
            this.posicao_JMJL = posicao_JMJL;
            this.cor_JMJL = cor_JMJL;
        }

        public Peca_JMJL() : this(new Posicao_JMJL(), new Cor_JMJL()) { }

        virtual
        public string GetNome_JMJL()
        {
            return "desconhecido";
        }

        public char GetX_JMJL()
        {
            return posicao_JMJL.GetX_JMJL();
        }

        public int GetY_JMJL()
        {
            return posicao_JMJL.GetY_JMJL();
        }

        public Cor_JMJL GetCor_JMJL()
        {
            return cor_JMJL;
        }


        public void SetX_JMJL(char x_JMJL)
        {
            this.posicao_JMJL.setX_JMJL(x_JMJL);
        }

        public void SetY_JMJL(int y_JMJL)
        {
            this.posicao_JMJL.setY_JMJL(y_JMJL);
        }

        public Boolean IsBranca_JMJL()
        {
            return cor_JMJL == Cor_JMJL.Branco_JMJL;
        }

        public Boolean IsPreta_JMJL()
        {
            return cor_JMJL == Cor_JMJL.Preto_JMJL;
        }

        virtual
        public string GetSimbolo_JMJL()
        {
            return "";
        }

        override 
        public string ToString()
        {
            return "" + posicao_JMJL;
        }

        abstract public void Deslocar_JMJL(int dx_JMJL, int dy_JMJL);
        
    }
}

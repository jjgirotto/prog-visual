using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_Pratica_JulianaLeite
{
    internal class Cidadao_JL
    {
        CartaoDoCidadao_JL cartaoDoCidadao_JL;
        DateTime dataNascimento_JL;

        public Cidadao_JL(CartaoDoCidadao_JL cartaoDoCidadao_JL, DateTime dataNascimento_JL)
        {
            this.cartaoDoCidadao_JL = cartaoDoCidadao_JL;
            this.dataNascimento_JL = dataNascimento_JL;
        }

        public Cidadao_JL() : this(new CartaoDoCidadao_JL(), new DateTime()) { }

        public CartaoDoCidadao_JL GetCartaoDoCidadao_JL()
        {
            return cartaoDoCidadao_JL;
        }
        public DateTime GetDataNascimento_JL()
        {
            return dataNascimento_JL;
        }
        public void SetCartaoDoCidadao_JL(CartaoDoCidadao_JL cartaoDoCidadao_JL)
        {
            this.cartaoDoCidadao_JL = cartaoDoCidadao_JL;
        }
        public void SetDataNascimento_JL(DateTime dataNascimento_JL)
        {
            this.dataNascimento_JL = dataNascimento_JL;
        }
        override
            public string ToString()
        {
            return cartaoDoCidadao_JL.ToString() + " - " + dataNascimento_JL;
        }
    }
}

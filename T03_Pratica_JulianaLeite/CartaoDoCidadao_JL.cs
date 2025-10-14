using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_Pratica_JulianaLeite
{
    internal class CartaoDoCidadao_JL
    {
        private string numero_JL;
        private string nome_JL;

        public CartaoDoCidadao_JL(string numero_JL, string nome_JL)
        {
            this.numero_JL = numero_JL;
            this.nome_JL = nome_JL;
        }

        public CartaoDoCidadao_JL() : this("000", "Sem nome definido") { }

        public string GetNumero_JL()
        {
            return numero_JL;
        }
        public string GetNome_JL()
        {
            return nome_JL;
        }
        public void SetNumero_JL(string numero_JL)
        {
            this.numero_JL = numero_JL; 
        }
        public void SetNome_JL(string nome_JL)
        {
            this.nome_JL = nome_JL;
        }

        override
            public string ToString()
        {
            return "NCC: " + numero_JL + " - " + nome_JL;
        }

    }
}

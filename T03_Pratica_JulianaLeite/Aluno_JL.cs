using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_Pratica_JulianaLeite
{
    internal class Aluno_JL : Cidadao_JL
    {
        string numeroAluno_JL;
        string email_JL;

        public Aluno_JL (CartaoDoCidadao_JL cartao_JL, DateTime data_JL, string numeroAluno_JL, string email_JL) : base (cartao_JL, data_JL)
        {
            this.numeroAluno_JL = numeroAluno_JL;
            this.email_JL = email_JL;
        }

        public Aluno_JL () : this (new CartaoDoCidadao_JL(), new DateTime (), "000", "Sem email definido") { }

        public string GetNumeroAluno_JL ()
        {
            return numeroAluno_JL;
        }
        public string GetEmail_JL() { return email_JL; }
        public void SetNumeroAluno_JL(string numeroAluno_JL) { this.numeroAluno_JL = numeroAluno_JL; }
        public void SetEmail_JL(string email_JL) { this.email_JL = email_JL; }

        override
            public string ToString()
        {
            return "Aluno: " + numeroAluno_JL + " " + base.ToString();
        }

    }
}

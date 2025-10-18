using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04_Pratica_JuliaMizuguchiJulianaLeite
{
    internal class Aluno_JMJL : Cidadao_JMJL
    {
        public string NumeroAluno_JMJL { get; set; }
        public string Email_JMJL { get; set; }

        public Aluno_JMJL(CartaoDoCidadao_JMJL cartao_JMJL, DateTime data_JMJL, string numeroAluno_JMJL, string email_JMJL) : base(cartao_JMJL, data_JMJL)
        {
            NumeroAluno_JMJL = numeroAluno_JMJL;
            Email_JMJL = email_JMJL;
        }

        public Aluno_JMJL() : this(new CartaoDoCidadao_JMJL(), new DateTime(), "000", "Sem email definido") { }

        override
            public string ToString()
        {
            return "Aluno: " + NumeroAluno_JMJL + " " + base.ToString();
        }
    }
}

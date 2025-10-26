using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class Pessoa_JMJL
    {
        public string Nome_JMJL { get; set; }
        public DateTime DataDeNascimento_JMJL { get; set; }
        public CartaoDoCidadao_JMJL CartaoDoCidadao_JMJL { get; set; }
        public List<string> NumerosDeTelefone_JMJL { get; set; }
        public List<string> Emails_JMJL { get; set; }

        public Pessoa_JMJL(string nome_JMJL, DateTime dataDeNascimento_JMJL, CartaoDoCidadao_JMJL cartaoDoCidadao_JMJL)
        {
            Nome_JMJL = nome_JMJL;
            DataDeNascimento_JMJL = dataDeNascimento_JMJL;
            CartaoDoCidadao_JMJL = cartaoDoCidadao_JMJL;
        }

        public override bool Equals(object obj)
        {
            //Is null (como o objeto que invoca não pode ser null)
            if (Object.ReferenceEquals(null, obj))
            {
                return false;
            }
            //Is the same object
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }
            // Not same type
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            //Is the same type -> podemos fazer cast seguro
            Pessoa_JMJL p = obj as Pessoa_JMJL;
            return String.Equals(CartaoDoCidadao_JMJL.Numero_JMJL, p.CartaoDoCidadao_JMJL.Numero_JMJL);
        }

        public override int GetHashCode()
        {
            return CartaoDoCidadao_JMJL.Numero_JMJL.GetHashCode();
        }

        override
            public string ToString()
        {
            return Nome_JMJL + "\t- " + DataDeNascimento_JMJL.Year + "/" + DataDeNascimento_JMJL.Month + "/"
                + DataDeNascimento_JMJL.Day + "\t- " + CartaoDoCidadao_JMJL;
        }

    }
}

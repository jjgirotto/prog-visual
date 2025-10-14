using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_JulianaLeite
{
    internal class MessagePost_JL : Post_JL
    {
        private String message;

        public MessagePost_JL(String username, String message) : base (username)
        {
            // NOTE a invocação do construtor da
            // classe base (da classe Post_NA)
            // usando :base(<parametros>)
            this.message = message;
        }
        public MessagePost_JL() : this("Anónimo", "Vazia")
        {
            // NOTE QUE de acordo com as BPP
            // invocamos o construtor da própria
            // classe com : this (<parametros>)
            // não invocamos o contrutor da
            // classe base (a super classe do java)
        }

        // note como uma série de métodos do C#:
        // ToString, LastIndexOf, Substring
        // têm o mesmo nome dos do java
        // mas em PascalCase
        // porque são públicos ;-)

        override public String ToString()
        {
            // invocação do ToString da
            // classe base Post
            String toStringDaSuper = base.ToString();
            int ultimoC = toStringDaSuper.LastIndexOf("***") + 3;
            String antes = toStringDaSuper.Substring(0, ultimoC);
            String depois = toStringDaSuper.Substring(ultimoC);
            String tmp = antes + "\n " + message;
            tmp += depois;
            return tmp;
        }
    }
}

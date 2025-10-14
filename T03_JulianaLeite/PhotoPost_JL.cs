using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_JulianaLeite
{
    internal class PhotoPost_JL : Post_JL
    {
        private String filename;
        private String caption;
        public PhotoPost_JL(String filename, String caption, String username) : base(username)
        {
            // NOTE a invocação do construtor da
            // classe base (da classe Post_NA)
            // usando :base(<parametros>)
            this.filename = filename;
            this.caption = caption;
        }

        public PhotoPost_JL() : this("Anónimo", "no file", "no caption")
        {
            // NOTE QUE de acordo com as BPP
            // invocamos o construtor da própria
            // classe com : this (<parametros>)
            // não invocamos o contrutor da
            // classe base (a super classe do java)
        }

        override public String ToString()
        {
            // invocação do toString da
            // classe base Post
            String toStringDaSuper = base.ToString();
            int ultimoC = toStringDaSuper.LastIndexOf("***") + 3;
            String antes = toStringDaSuper.Substring(0, ultimoC);
            String depois = toStringDaSuper.Substring(ultimoC);
            String tmp = antes + "\n ";
            tmp += caption + "\n ";
            tmp += "[" + filename + "]";
            tmp += depois;
            return tmp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_Pratica_JulianaLeite
{
    internal class Docente_JL : Cidadao_JL
    {
        string categoriaProfissional_JL;
        string gabinete_JL;
        
        public Docente_JL(CartaoDoCidadao_JL cartao_JL, DateTime data_JL, string categoriaProfissional_JL, string gabinete_JL) : base(cartao_JL, data_JL)
        {
            this.categoriaProfissional_JL = categoriaProfissional_JL;
            this.gabinete_JL = gabinete_JL;
        }

        public Docente_JL() : this(new CartaoDoCidadao_JL(), new DateTime(), "000", "Sem gabinete definido") { }

        public string GetCategoriaProfissional_JL()
        {
            return categoriaProfissional_JL;
        }
        public string GetGabinete_JL() { return gabinete_JL; }
        public void SetCategoriaProfissional_JL(string categoriaProfissional_JL) { this.categoriaProfissional_JL = categoriaProfissional_JL; }
        public void SetGabinete_JL(string gabinete_JL) { this.gabinete_JL = gabinete_JL; }

        override
            public string ToString()
        {
            return "Docente: " + categoriaProfissional_JL + " - " + gabinete_JL + " " + base.ToString();
        }
    }
}

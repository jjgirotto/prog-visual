using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02_Slides_JL
{
    public class Cd_JL
    {
        string identificadorUnico_JL;
        string titulo_JL;
        string interprete_JL;
        int duracao_JL;
        decimal preco_JL;
        int existencias_JL;

        public Cd_JL(string identificadorUnico, string titulo, string interprete, int duracao, decimal preco, int existencias)
        {
            identificadorUnico_JL = identificadorUnico;
            titulo_JL = titulo;
            interprete_JL = interprete;
            duracao_JL = duracao;
            preco_JL = preco;
            existencias_JL = existencias;
        }

        public Cd_JL() : this ("UI_000000000", "Sem título atribuído", "Sem interprete definido", 0, 0.0M, 0)
        {
            
        }
        public string GetIdentificadorUnico_JL() { return identificadorUnico_JL; }
        public string GetTitulo_JL() { return titulo_JL; }
        public string GetInterprete_JL() { return interprete_JL; }
        public int GetDuracao_JL() { return duracao_JL; }
        public decimal GetPreco_JL() { return preco_JL; }
        public int GetExistencias_JL() { return existencias_JL; }

        //setters
        public void SetIdentificadorUnico_JL(string identificadorUnico) { identificadorUnico_JL = identificadorUnico; }
        public void SetTitulo_JL(string titulo) { titulo_JL = titulo; }
        public void SetInterprete_JL(string interprete) { interprete_JL = interprete; }
        public void SetDuracao_JL(int duracao) { duracao_JL = duracao; }
        public void SetPreco_JL(decimal preco) { preco_JL = preco; }
        public void SetExistencias_JL(int existencias) { existencias_JL = existencias; }

        override
            public String ToString()
        {
            String tmp = "*** CD: " + identificadorUnico_JL + " | Tit: " + titulo_JL + " | Int: " + interprete_JL +
                " | Dur: " + duracao_JL + " minutos | $$: " + preco_JL + " | Stock: " + existencias_JL;
            return tmp;
        }
    }
}

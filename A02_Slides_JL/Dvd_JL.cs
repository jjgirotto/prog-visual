using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02_Slides_JL
{
    public class Dvd_JL
    {
        string identificadorUnico_JL;
        string titulo_JL;
        string realizador_JL;
        int duracao_JL;
        double preco_JL;
        int existencias_JL;

        public Dvd_JL(string identificadorUnico, string titulo, string realizador, int duracao, double preco, int existencias)
        {
            identificadorUnico_JL = identificadorUnico;
            titulo_JL = titulo;
            realizador_JL = realizador;
            duracao_JL = duracao;
            preco_JL = preco;
            existencias_JL = existencias;
        }

        public Dvd_JL() : this("UI_000000000", "Sem título atribuído", "Sem realizador definido", 0, 0.0, 0)
        {
            
        }

        public string GetIdentificadorUnico_JL() { return identificadorUnico_JL; }
        public string GetTitulo_JL() { return titulo_JL; }
        public string GetRealizador_JL() { return realizador_JL; }
        public int GetDuracao_JL() { return duracao_JL; }
        public double GetPreco_JL() { return preco_JL; }
        public int GetExistencias_JL() { return existencias_JL; }

        public void SetIdentificadorUnico_JL(string identificadorUnico) { identificadorUnico_JL = identificadorUnico; }
        public void SetTitulo_JL(string titulo) { titulo_JL = titulo; }
        public void SetRealizador_JL(string realizador) { realizador_JL = realizador; }
        public void SetDuracao_JL(int duracao) { duracao_JL = duracao; }
        public void SetPreco_JL(double preco) { preco_JL = preco; }
        public void SetExistencias_JL(int existencias) { existencias_JL = existencias; }

        override
            public String ToString()
        {
            String tmp = "*** DVD: " + identificadorUnico_JL + " | Tit: " + titulo_JL + " | Real: " + realizador_JL +
                " | Dur: " + duracao_JL + " minutos | $$: " + preco_JL + " | Stock: " + existencias_JL;
            return tmp;
        }
    }
}

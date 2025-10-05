using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02_Slides_JL
{
    public class Livro_JL
    {
        string identificadorUnico_JL;
        string titulo_JL;
        string autor_JL;
        decimal preco_JL;
        int existencias_JL;

        public Livro_JL(string identificadorUnico, string autor, string titulo, decimal preco, int existencias)
        {
            identificadorUnico_JL = identificadorUnico;
            autor_JL = autor;
            titulo_JL = titulo;
            preco_JL = preco;
            existencias_JL = existencias;
        }

        //Construtor sem parâmetros que invoca o construtor codificado usando a sintaxe : this( ).
        public Livro_JL() : this("IU_000000000", "Sem autor definido", "Sem título atribuído", 0.0M, 0)
        {
            
        }

        //getters
        public string GetIdentificadorUnico_JL() { return identificadorUnico_JL; }
        public string GetAutor_JL() { return autor_JL; }
        public string GetTitulo_JL() { return titulo_JL; }
        public decimal GetPreco_JL() { return preco_JL; }
        public int GetExistencias_JL() { return existencias_JL; }

        //setters
        public void SetIdentificadorUnico_JL(string identificadorUnico) { identificadorUnico_JL = identificadorUnico; }
        public void SetAutor_JL(string autor) { autor_JL = autor; }
        public void SetTitulo_JL(string titulo) { titulo_JL = titulo; }
        public void SetPreco_JL(decimal preco) { preco_JL = preco; }
        public void SetExistencias_JL(int existencias) { existencias_JL = existencias; }

        //toString
        override
            public String ToString()
        {
            String tmp = "*** LIVRO: " + identificadorUnico_JL + " | Tit: " + titulo_JL + " | Aut: " + autor_JL +
                " | $$: " + preco_JL + " | Stock: " + existencias_JL;
            return tmp;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02JGL
{
    internal class Bilhete_JL
    {
        public const decimal PRECO_BILHETE_JL = 2.50M;
        // indentificadores em c#
        // public (ou internal) -> PascalCase
        // tudo o resto -> cameCase

        // MANTRA 1
        // BPP - campos (atributos do java) -> SEMPRE PRIVATE
        static int bilhetesEmitidos_JL;
        int numeroDoBilhete_JL;
        DateTime dataHora_JL;
        string nomeDoCliente_JL;

        // MANTRA 2 Só codificamos UM construtor
        // Porque evitamos a todo o custo a duplicação de código
        public Bilhete_JL(string nomeDoCliente_JL)
        {
            this.nomeDoCliente_JL = nomeDoCliente_JL;
            dataHora_JL = DateTime.Now;
            bilhetesEmitidos_JL++;
            numeroDoBilhete_JL = bilhetesEmitidos_JL;
        }

        public Bilhete_JL() : this("Sem nome")
        {
            
        }
        public DateTime DataHora_JL
        {
            get { return dataHora_JL; }
        }

        public int NumeroDoBilhete_JL
        {
            get { return numeroDoBilhete_JL; }
        }

        public string NomeDoCliente_JL
        {
            get { return nomeDoCliente_JL; }
            set { nomeDoCliente_JL = value; }
        }

        override public String ToString()
        {
            return
            $@"********************************************
            ** Bilhete Número: {numeroDoBilhete_JL} *** {dataHora_JL:yyyy/M/d HH:mm:ss}
            ** {nomeDoCliente_JL}
            ********************************************";
        }


    }
}

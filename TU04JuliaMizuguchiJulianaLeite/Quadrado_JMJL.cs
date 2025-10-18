using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU04JuliaMizuguchiJulianaLeite
{
    internal class Quadrado_JMJL : Retangulo_JMJL
    {
        // NOTE QUE: deslocar um Quadrado, definido por um ponto e um lado que herda de um Retangulo
        // // definido por dois pontos, obriga a que, sempre que a largura do quadrado seja alterada,
        // // alteremos também a altura, por forma a mantê-lo quadrado ;-)
        // // assim sendo o "set" de lado deve redefinir os valores do 2º ponto que definia o retangulo e
        // // por isso temos de usar uma Propriedade com campo explicito (vulgo propriedade explicita)
        // // Para podermos codificar a alteração do segundo ponto do retangulo
        // // Para gerar propriedades explicitas use o snipett/trecho escreva propfull + tab ;-)
        private int lado;

        public int Lado
        {
            get { return lado; }
            set
            {
                lado = value;
                base.X2_JMJL += lado;
                base.Y2_JMJL -= lado;
            }
        }

        public Quadrado_JMJL(int x, int y, int lado) : base(x, y, x + lado, y + lado)
        {
            Lado = lado;
        }

        public Quadrado_JMJL(Ponto_JMJL p_JMJL, int lado_JMJL) : this(p_JMJL.X_JMJL, p_JMJL.Y_JMJL, lado_JMJL)
        {
        }

        public Quadrado_JMJL() : this(0, 0, 0)
        {
        }

        public override string ToString()
        {
            string tmp = "[Q: " + base.ToString().Substring(4);
            return tmp;
        }

        override
            public double CalcularArea_JMJL()
        {
            return lado * lado;
        }
    }
}

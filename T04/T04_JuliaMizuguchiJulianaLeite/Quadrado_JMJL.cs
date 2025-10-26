using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04_JuliaMizuguchiJulianaLeite
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
        private int lado_JMJL;

        public int Lado_JMJL
        {
            get { return lado_JMJL; }
            set
            {
                lado_JMJL = value;
                base.X2_JMJL += lado_JMJL;
                base.Y2_JMJL -= lado_JMJL;
            }
        }

        public Quadrado_JMJL(int x_JMJL, int y_JMJL, int lado_JMJL) : base(x_JMJL, y_JMJL, x_JMJL + lado_JMJL, y_JMJL + lado_JMJL)
        {
            Lado_JMJL = lado_JMJL;
        }

        public Quadrado_JMJL(Ponto_JMJL p_JMJL, int lado_JMJL) : this(p_JMJL.X_JMJL, p_JMJL.Y_JMJL, lado_JMJL)
        {
        }

        public Quadrado_JMJL() : this(0, 0, 0)
        {
        }

        public override string ToString()
        {
            string tmp_JMJL = "[Q: " + base.ToString().Substring(4);
            return tmp_JMJL;
        }

        override
            public double CalcularArea_JMJL()
        {
            return lado_JMJL * lado_JMJL;
        }
    }
}

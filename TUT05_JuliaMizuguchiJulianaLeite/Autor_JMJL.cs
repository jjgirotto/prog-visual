namespace TUT05_JuliaMizuguchiJulianaLeite
{
    public class Autor_JMJL
    {

        public string Nome_JMJL { get; set; }
        public string LinguaOriginal_JMJL { get; set; }

        public Autor_JMJL(string nome_JMJL, string linguaOriginal_JMJL)
        {
            Nome_JMJL = nome_JMJL;
            LinguaOriginal_JMJL = linguaOriginal_JMJL;
        }


        public override string ToString()
        {
            return Nome_JMJL + " | " + LinguaOriginal_JMJL;
        }
    }
}
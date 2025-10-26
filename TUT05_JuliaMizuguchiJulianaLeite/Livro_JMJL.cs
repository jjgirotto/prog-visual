namespace TUT05_JuliaMizuguchiJulianaLeite
{
    public class Livro_JMJL
    {
        public string Titulo_JMJL { get; set; }
        public string Isbn_JMJL { get; set; }
        public Autor_JMJL Autor_JMJL { get; set; }
        public int Stock_JMJL { get; set; }

        public Livro_JMJL(string titulo_JMJL, string isbn_JMJL, Autor_JMJL autor_JMJL, int stock_JMJL)
        {
            Titulo_JMJL = titulo_JMJL;
            Isbn_JMJL = isbn_JMJL;
            Autor_JMJL = autor_JMJL;
            Stock_JMJL = stock_JMJL;
        }

        public override string ToString()
        {
            return "Título: " + Titulo_JMJL + " | ISBN: " + Isbn_JMJL + " | Autor: " + Autor_JMJL + " | Stock: " + Stock_JMJL;
        }
    }
}
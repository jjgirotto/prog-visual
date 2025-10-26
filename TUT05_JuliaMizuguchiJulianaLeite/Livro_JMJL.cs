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

        public override bool Equals(object obj)
        {
            //Is null (como o objeto que invoca não pode ser null)
            if (Object.ReferenceEquals(null, obj))
            {
                return false;
            }
            //Is the same object
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }
            // Not same type
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            //Is the same type -> podemos fazer cast seguro
            Livro_JMJL l = obj as Livro_JMJL;
            return String.Equals(Isbn_JMJL, l.Isbn_JMJL);
        }

        public override int GetHashCode()
        {
            return Isbn_JMJL.GetHashCode();
        }

        public override string ToString()
        {
            return "Título: " + Titulo_JMJL + " | ISBN: " + Isbn_JMJL + " | Autor: " + Autor_JMJL + " | Stock: " + Stock_JMJL;
        }
    }
}
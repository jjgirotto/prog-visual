namespace TUT08_JuliaMizuguchi_JulianaLeite.Models
{
    public class Musica
    {
        public String Titulo { get; set; }
        public String Autor { get; set; }
        public int Duracao { get; set; }
        public String Ficheiro { get; set; }

        public Musica(string titulo, string autor, int duracao, string ficheiro)
        {
            Titulo = titulo;
            Autor = autor;
            Duracao = duracao;
            Ficheiro = ficheiro;
        }

        public override string ToString()
        {
            return $"Título: {Titulo} | Autor: {Autor} | Duração: {Duracao} segundos | Ficheiro: {Ficheiro}";
        }
    }
}

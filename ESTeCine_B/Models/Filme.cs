namespace ESTeCine_B.Models
{
    public class Filme
    {
        public String Titulo { get; set; }
        public String Realizador { get; set; }
        public List<String> Atores { get; set; }
        public int Duracao { get; set; }
        public int Ano { get; set; }
        public bool Estreia { get; set; }
    }
}

namespace GB_Discoteca_JMJL.Models
{
    public class Musica_JMJL
    {
        public int Codigo_JMJL { get; set; }
        public String Titulo_JMJL { get; set; }
        public DateTime DataDaEdicao_JMJL { get; set; }
        public List<String> Executantes_JMJL { get; set; }

        public Musica_JMJL(int codigo, string titulo, DateTime dataDaEdicao)
        {
            Codigo_JMJL = codigo;
            Titulo_JMJL = titulo;
            DataDaEdicao_JMJL = dataDaEdicao;
            Executantes_JMJL = new List<string>();
        }

        public Musica_JMJL() : this(-1, "N/D", DateTime.MinValue)
        {
            
        }
    }
}

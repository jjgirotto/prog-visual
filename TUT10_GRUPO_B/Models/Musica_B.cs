using System.ComponentModel.DataAnnotations;
namespace TUT10_GRUPO_B.Models
{
    public class Musica_B
    {
        public Guid Musica_BId { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        public String Titulo_B { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "Autor")]
        [MaxLength(30, ErrorMessage = "Max 30 caracteres")]
        public String Autor_B { get; set; }

        [Display(Name = "Duração")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [DuracaoValida(10,900)]
        public int Duracao_B { get; set; }

        [Display(Name = "Ficheiro")]
        public String Ficheiro_B { get; set; }

        public Musica_B(Guid id, String titulo, String autor, int duracao)
        {
            Musica_BId = id;
            Titulo_B = titulo;
            Autor_B = autor;
            Duracao_B = duracao;
            Ficheiro_B = "/musicas/" + titulo.ToLower() + ".mp3";
        }

        public Musica_B() : this (Guid.NewGuid(), "Sem título", "Sem autor", 0)
        {
            
        }
    }
}

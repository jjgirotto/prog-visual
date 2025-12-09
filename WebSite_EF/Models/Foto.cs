//importar data annotations
using System;
using System.ComponentModel.DataAnnotations;

namespace WebSite_EF.Models
{
    public class Foto
    {
        public Guid FotoId { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [CheckDigit(6, ErrorMessage = "O {0} é inválido")]
        public int Codigo { get; set; }

        [Display(Name = "Título")]
        [MaxLength(30, ErrorMessage = "Max 30 caracteres")]
        public String Titulo { get; set; }
        
        [MaxLength(30, ErrorMessage = "Max 30 caracteres")]
        public String Autor { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
namespace HospitEST_JuliaMizuguchiJulianaLeite.Models
{
    public class Hospital_JMJL
    {
        [Key]
        [Display(Name = "Id")]
        public Guid Id_JMJL { get; set; }
        
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "Nome")]
        [MaxLength(20, ErrorMessage = "A {0} não pode ter mais de {1} caracteres")]
        public String Name_JMJL { get; set; }

        [Display(Name = "Localidade")]
        [Required(ErrorMessage = "A {0} é obrigatória")]
        public String Location_JMJL { get; set; }

        [Display(Name = "Médicos")]
        public List<Doctor_JMJL>? Doctors_JMJL { get; set; }
    }
}

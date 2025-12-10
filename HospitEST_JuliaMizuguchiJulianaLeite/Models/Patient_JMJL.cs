using System.ComponentModel.DataAnnotations;

namespace HospitEST_JuliaMizuguchiJulianaLeite.Models
{
    public class Patient_JMJL
    {
        [Key]
        [Display(Name = "Id")]
        public Guid Id_JMJL { get; set; }

        [Display(Name = "Médico Id")]
        public Guid? Doctor_JMJLId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        public String Name_JMJL { get; set; }

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        public DateTime DateOfBirth_JMJL { get; set; }

        [Display(Name = "Patologia")]
        public String? Pathology_JMJL { get; set; }

        [Display(Name = "Médico")]
        public Doctor_JMJL? Doctor_JMJL { get; set; }
    }
}

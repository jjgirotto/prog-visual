using System.ComponentModel.DataAnnotations;

namespace HospitEST_JuliaMizuguchiJulianaLeite.Models
{
    public class Doctor_JMJL
    {
        [Key]
        [Display(Name = "Id")]
        public Guid Id_JMJL { get; set; }

        [Display(Name = "Hospital Id")]
        public Guid Hospital_JMJLId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        public String Name_JMJL { get; set; }

        [Display(Name = "Prática")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        public String Practice_JMJL { get; set; }

        [Display(Name = "Anos de prática")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "O {0} não pode ser negativo")]
        public int PracticeYears_JMJL { get; set; }

        [Display(Name = "Pacientes")]
        public List<Patient_JMJL>? Patients_JMJL { get; set; }

        [Display(Name = "Hospital")]
        public Hospital_JMJL? Hospital_JMJL { get; set; }
    }
}

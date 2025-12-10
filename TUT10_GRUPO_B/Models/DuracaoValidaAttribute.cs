using System.ComponentModel.DataAnnotations;

namespace TUT10_GRUPO_B.Models
{
    public class DuracaoValidaAttribute : ValidationAttribute
    {
        private int _min;
        private int _max;
        public DuracaoValidaAttribute(int min, int max)
        {
            _min = min;
            _max = max;
            ErrorMessage = $"A duração deve estar entre {_min} e {_max} segundos.";
        }

        public override bool IsValid(object value)
        {
            if (value == null) return false;
            int duracao = (int)value;
            return duracao >= _min && duracao <= _max;
        }
    }
}


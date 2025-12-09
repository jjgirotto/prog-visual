using System.ComponentModel.DataAnnotations;

namespace WebSite_EF.Models
{
    public class CheckDigitAttribute : ValidationAttribute
    {
        private int _numeroDigitos;
        public CheckDigitAttribute(int numeroDigitos)
        { // recebe 6 como # dígitos
            if (numeroDigitos > 1 && numeroDigitos < 10) _numeroDigitos = numeroDigitos;
        }


        // o 6º digito é um digito de controlo
        // e tem de ser igual ao resto da divisão 
        // por 10 da soma dos primeiros
        // cinco digitos

        public override bool IsValid(object value)
        {
            int numero = (int)value;
            int checkDigit = numero % 10;// get digit 6
            string numeroTxt = (numero / 10).ToString(); // descarta o 6º digito
            if (_numeroDigitos != 0 && numero.ToString().Length != _numeroDigitos)
                return false;
            return numeroTxt.Sum(c => Convert.ToInt32(c - '0')) % 10 == checkDigit;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace APICatalogo.Validations
{
    public class PrimeiraLetraMaisuculaAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,
        ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            var PrimeiraLetra = value.ToString() [0].ToString();
            if (PrimeiraLetra != PrimeiraLetra.ToUpper())
            {
                return new ValidationResult("A primeira letra do produto deve ser maiscula");
            }
            return ValidationResult.Success;
        }   
    }
}
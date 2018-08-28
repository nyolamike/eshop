using eshop.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eshop.Attributes
{
    public class InCountries: ValidationAttribute
    {
        public InCountries(string ErrorMessage)
        {
            this.ErrorMessage = ErrorMessage;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            
            if (Countries.IsCountryName(value.ToString()))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage); 
        }
    }
}

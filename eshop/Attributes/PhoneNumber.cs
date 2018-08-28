
using eshop.Models;
using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eshop.Attributes
{
    public class PhoneNumber : ValidationAttribute
    {
        public PhoneNumber(string ErrorMessage)
        {
            this.ErrorMessage = ErrorMessage;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (Register)validationContext.ObjectInstance;
            if (model == null || String.IsNullOrEmpty(model.PhoneNumber))
            {
                return new ValidationResult(ErrorMessage);
            }

            if (model == null || String.IsNullOrEmpty(model.Country))
            {
                return new ValidationResult("Please provide a valid country");
            }

            

            //phone nnumber formating addopted from
            //https://stackoverflow.com/questions/30434836/how-to-convert-mobile-number-to-international-format-in-c-sharp
            Country country = Countries.GetCountry(model.Country);
            var util = PhoneNumberUtil.GetInstance();
            PhoneNumbers.PhoneNumber pn = util.Parse(model.PhoneNumber, country.ShortName.ToUpper());
            if(util.IsValidNumberForRegion(pn, country.Code.ToLower()))
            {
                return ValidationResult.Success;
            }
            

            return new ValidationResult(ErrorMessage + " For the country " + model.Country);
        }
    }
}

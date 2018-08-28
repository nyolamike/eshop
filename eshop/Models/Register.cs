using eshop.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eshop.Models
{
    public class Register
    {
        /// validation logic inspired from this article
        /// https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-2.1

        [Required(ErrorMessage = "The Name of your shop is required")]
        public string ShopName { get; set; }

        [Required(ErrorMessage = "Your email address is required")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please select a country")]
        [InCountries("Invalid country name")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Your phone number is required")]
        [PhoneNumber("Invalid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "The password is required")]
        [StringLength(12,MinimumLength = 4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "The comfirmation password is required")]
        [Compare("Password",ErrorMessage = "The two passwords do not match")]
        public string ComfirmationPassword { get; set; }
    }
}

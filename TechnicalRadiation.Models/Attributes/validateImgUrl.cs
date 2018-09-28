using System;
using System.ComponentModel.DataAnnotations;

namespace TechnicalRadiation.Models.Attributes
{
    public class validateImgUrl : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext con)
        {
            var text = value.ToString();
            Uri uri;

            if(!string.IsNullOrWhiteSpace(text) && Uri.TryCreate(text, UriKind.Absolute, out uri ))
                return ValidationResult.Success;

            return new ValidationResult("not a valid url");
        }
    }
}
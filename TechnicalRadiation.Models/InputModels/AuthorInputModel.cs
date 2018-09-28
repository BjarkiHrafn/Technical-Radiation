using System;
using System.ComponentModel.DataAnnotations;
using TechnicalRadiation.Models.Attributes;

namespace TechnicalRadiation.Models.InputModels
{
    public class AuthorInputModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [validateImgUrl]
        public string ProfileImgSource { get; set; } //(required and must be a valid URL), 

        public string Bio { get; set; }
    }
}
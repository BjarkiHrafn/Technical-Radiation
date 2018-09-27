using System;
using System.ComponentModel.DataAnnotations;

namespace TechnicalRadiation.Models.InputModels
{
    public class AuthorInputModel
    {
        [Required]
        public string Name { get; set; }

        public string ProfileImgSource { get; set; } //(required and must be a valid URL), 

        public string Bio { get; set; }

        public bool ValidateURL(string uri)
        {
            Uri validatedUri;
            return Uri.TryCreate(uri, UriKind.RelativeOrAbsolute, out validatedUri);
        }
    }
}
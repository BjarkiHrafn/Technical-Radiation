using System;
using System.ComponentModel.DataAnnotations;

namespace TechnicalRadiation.WebApi.Models.InputModels
{
    public class AuthorInputModel
    {
        [Required]
        public string Name {get;set;}
        [Required] 
        public string ProfileImgSource {get;set;} //(required and must be a valid URL), 
        [MaxLength(255)]
        public string Bio {get;set;}

        public bool ValidateURL(string uri)
        {
            Uri validatedUri;
            return Uri.TryCreate(uri, UriKind.RelativeOrAbsolute, out validatedUri);
        }
    }
}
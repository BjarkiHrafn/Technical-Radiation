using System;
using System.ComponentModel.DataAnnotations;

namespace TechnicalRadiation.WebApi.Models.InputModels
{
    public class NewsItemInputModel
    {
        [Required]
        public string Title {get;set;}
        [Required]
        public string ImgSource {get;set;}
        [Required]
        [MaxLength(50)]
        public string ShortDescription {get;set;}
        [MinLength(50), MaxLength(255)]
        public string LongDescription {get;set;}
        [Required]
        public DateTime PublishDate {get;set;}

        public bool ValidateURL(string uri)
        {
            Uri validatedUri;
            return Uri.TryCreate(uri, UriKind.RelativeOrAbsolute, out validatedUri);
        }
    }
}
using template.Models;

namespace TechnicalRadiation.WebApi.Models.DataTransferObjects
{
    public class AuthorDto : HyperMediaModel
    {
        public int Id {get;set;}
        public string Name {get;set;}
    }
}
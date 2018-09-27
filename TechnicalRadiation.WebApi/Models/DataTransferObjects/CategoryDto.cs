using template.Models;

namespace TechnicalRadiation.WebApi.Models.DataTransferObjects
{
    public class CategoryDto : HyperMediaModel
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string Slug {get;set;}
    }
}
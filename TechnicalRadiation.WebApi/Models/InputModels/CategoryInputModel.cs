using System.ComponentModel.DataAnnotations;

namespace TechnicalRadiation.WebApi.Models.InputModels
{
    public class CategoryInputModel
    {
        [Required]
        [MaxLength(60)]
        public string Name {get;set;} //(required and max length 60), 
        public int ParentCategoryId {get;set;}//(defaults to 0)
        public string slug {get;set;}
        //Slug should be generated by making the name lowercase and join the words together with a hyphen (-), e.g. Science Fiction will be science-fiction
    }
}
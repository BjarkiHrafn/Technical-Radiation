using System;

namespace TechnicalRadiation.WebApi.Models.Entities
{
    public class NewsItem
    {
        public int AuthorID {get;set;}
        public int CategoryID {get;set;}
        public int Id {get;set;}
        public string Title {get;set;}
        public string ImgSource {get;set;}
        public string ShortDescription {get;set;}
        public string LongDescription {get;set;}
        public DateTime PublishDate {get;set;}
        public string ModifiedBy {get;set;} // should be code-generated.. no idea what that means rn
        public DateTime CreatedDate {get;set;}
        public DateTime ModifiedDate {get;set;}

    }
}
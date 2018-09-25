using System;

namespace TechnicalRadiation.WebApi.Models.Entities
{
    public class Category
    {
        public int ID {get;set;}
        public string Name {get;set;}
        public string Slug {get;set;}
        public int  ParentCategoryId {get;set;}
        public string ModifiedBy {get;set;} //(code-generated), 
        public DateTime CreatedDate {get;set;} //(code-generated), 
        public DateTime ModifiedDate {get;set;} //(code-generated)
    }
}
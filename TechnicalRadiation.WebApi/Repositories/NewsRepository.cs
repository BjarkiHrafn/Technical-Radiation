using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using TechnicalRadiation.WebApi.Data;
using TechnicalRadiation.WebApi.Models.DataTransferObjects;
using TechnicalRadiation.WebApi.Models.Entities;
using template.Extensions;

namespace TechnicalRadiation.WebApi.Repositories
{
    public class NewsRepository
    {
        public string URL = "http://localhost:5000/";

        public ExpandoObject putHrefinNews(string path, int id) {
            ExpandoObject exp = new ExpandoObject();
            exp.AddReference("href", URL + path + "/" + id.ToString());

            return exp;
        }

        public IEnumerable<NewsItemDto> getAllNews(int pageNumber, int pageSize) {
            var list =  DataContext._news.ToList().OrderByDescending(x => x.PublishDate).Select(x => new NewsItemDto() {
                Id = x.Id,
                Title = x.Title,
                ImgSource = x.ImgSource,
                ShortDescription = x.ShortDescription,
  
            }).Skip((pageNumber-1) * pageSize).Take(pageSize);

            ExpandoObject expando = new ExpandoObject();

            
            foreach(NewsItemDto n in list) {
                
                //n.Links = new ExpandoObject();
                //expando = putHrefinNews("api", n.Id);
                n.Links.AddReference("self", "expando");
                //n.Links.AddReference("edit", new {expando});
                /*n.Links.AddReference("delete", expando = putHrefinNews("api", n.Id));
                n.Links.AddReference("authors", expando = putHrefinNews("api/authors", n.AuthorID));*/
                //setja category seinna
                /*foreach(Category c in _data._categories){
                    if(n.CategoryID == c.ID) {
                        n.Links.AddReference("categories", expando = putHrefinNews("api/categories", c.ID));
                    }
                }*/
            }

            return list;
        }
        
        public NewsItemDetailDto GetNewsByID(int id) {
            
            
            var data = DataContext._news.ToList().Select(x => new NewsItemDetailDto() {
                Id = x.Id,
                ImgSource = x.ImgSource,
                ShortDescription = x.ShortDescription,
                Title = x.Title,
                PublishDate = x.PublishDate,
                LongDescription = x.LongDescription,
            }).FirstOrDefault(x => x.Id == id);

            data.Links.AddReference(data.Id.ToString(), "http://localhost:5000/api/" + data.Id.ToString());
            data.Links.AddReference(data.AuthorID.ToString(),"http://localhost:5000/api/authors" + data.AuthorID.ToString() );
            data.Links.AddReference(data.CategoryID.ToString(),"http://localhost:5000/api/categories" + data.CategoryID.ToString() );

            return data;

        }
    }
}
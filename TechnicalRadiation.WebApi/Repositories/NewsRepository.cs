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

            var temp = list.ToList();
            
            foreach(NewsItemDto n in temp) {
            
                n.Links.AddReference("self", putHrefinNews("api", n.Id));
                n.Links.AddReference("edit", putHrefinNews("api", n.Id));
                n.Links.AddReference("delete", putHrefinNews("api", n.Id));
                n.Links.AddReference("authors", putHrefinNews("api/authors", n.AuthorID));
                //setja category seinna
                /*foreach(Category c in _data._categories){
                    if(n.CategoryID == c.ID) {
                        n.Links.AddReference("categories", expando = putHrefinNews("api/categories", c.ID));
                    }
                }*/
            }

            return temp;
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

            data.Links.AddReference("self", putHrefinNews("api", data.Id));
            data.Links.AddReference("edit", putHrefinNews("api", data.Id));
            data.Links.AddReference("delete", putHrefinNews("api", data.Id));
            data.Links.AddReference("authors", putHrefinNews("api/authors", data.AuthorID));

            return data;

        }
    }
}
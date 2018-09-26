using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.WebApi.Data;
using TechnicalRadiation.WebApi.Models.DataTransferObjects;

namespace TechnicalRadiation.WebApi.Repositories
{
    public class AuthorRepository
    {
        private readonly DataContext _data = new DataContext();
/* 
        public IEnumerable<AuthorDto> getAllNews(int pageNumber, int pageSize) {
            var list =  _data._news.ToList().OrderByDescending(x => x.PublishDate).Select(x => new NewsItemDto() {
                Id = x.Id,
                Title = x.Title,
                ImgSource = x.ImgSource,
                ShortDescription = x.ShortDescription,
  
            }).Skip((pageNumber-1) * pageSize).Take(pageSize);
            
            foreach(NewsItemDto n in list) {
                n.Links.AddReference(n.Id.ToString(), "http://localhost:5000/api/" + n.Id.ToString());
                n.Links.AddReference(n.AuthorID.ToString(),"http://localhost:5000/api/authors" + n.AuthorID.ToString() );
                n.Links.AddReference(n.CategoryID.ToString(),"http://localhost:5000/api/categories" + n.CategoryID.ToString() );
            }

            return list;
        }
        */
    }
}
using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.WebApi.Data;
using TechnicalRadiation.WebApi.Models.DataTransferObjects;
using TechnicalRadiation.WebApi.Models.Entities;
using template.Extensions;

namespace TechnicalRadiation.WebApi.Repositories
{
    public class NewsRepository
    {
        private readonly DataContext _data = new DataContext();

        public IEnumerable<NewsItemDto> getAllNews(int pageNumber, int pageSize) {
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
        
        public NewsItemDetailDto GetNewsByID(int id) {
            
            
            var data = _data._news.ToList().Select(x => new NewsItemDetailDto() {
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
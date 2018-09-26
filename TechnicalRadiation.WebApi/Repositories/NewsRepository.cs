using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.WebApi.Data;
using TechnicalRadiation.WebApi.Models.DataTransferObjects;
using TechnicalRadiation.WebApi.Models.Entities;

namespace TechnicalRadiation.WebApi.Repositories
{
    public class NewsRepository
    {
        private readonly DataContext _data = new DataContext();

        public IEnumerable<NewsItemDetailDto> getAllNews(int pageNumber, int pageSize) {
            return _data._news.ToList().Select(x => new NewsItemDetailDto() {
                Id = x.Id,
                Title = x.Title,
                ImgSource = x.ImgSource,
                ShortDescription = x.ShortDescription,
                PublishDate = x.PublishDate,
                LongDescription = x.LongDescription,
                
            }).Skip((pageNumber-1) * pageSize).Take(pageSize).OrderByDescending(x => x.PublishDate);
        }
        
        public NewsItemDto GetNewsByID(int id) {
            return _data._news.ToList().Select(x => new NewsItemDto() {
                Id = x.Id,
                ImgSource = x.ImgSource,
                ShortDescription = x.ShortDescription,
                Title = x.Title
            }).FirstOrDefault(x => x.Id == id);
        }
    }
}
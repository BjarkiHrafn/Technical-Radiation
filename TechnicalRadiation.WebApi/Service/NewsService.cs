using System.Collections.Generic;
using TechnicalRadiation.WebApi.Models.DataTransferObjects;
using TechnicalRadiation.WebApi.Repositories;

namespace TechnicalRadiation.WebApi.Service
{
    public class NewsService
    {
        public NewsRepository repo = new NewsRepository();
        public IEnumerable<NewsItemDetailDto> getAllNews(int pageNumber, int pageSize) {
            return repo.getAllNews(pageNumber, pageSize);
        }

        public NewsItemDto getNewsByID(int id) {
            return repo.GetNewsByID(id);
        }
    }
}
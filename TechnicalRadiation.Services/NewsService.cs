using System.Collections.Generic;
using TechnicalRadiation.Models.DataTransferObjects;
using TechnicalRadiation.Repositories;

namespace TechnicalRadiation.Services
{
    public class NewsService
    {
        public NewsRepository repo = new NewsRepository();
        public IEnumerable<NewsItemDto> getAllNews(int pageNumber, int pageSize)
        {
            return repo.getAllNews(pageNumber, pageSize);
        }

        public NewsItemDetailDto getNewsByID(int id)
        {
            return repo.GetNewsByID(id);
        }
    }
}
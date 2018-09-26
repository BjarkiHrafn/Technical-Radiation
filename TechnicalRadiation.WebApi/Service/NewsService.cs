using System.Collections.Generic;
using TechnicalRadiation.WebApi.Models.DataTransferObjects;
using TechnicalRadiation.WebApi.Repositories;

namespace TechnicalRadiation.WebApi.Service
{
    public class NewsService
    {
        public NewsRepository repo = new NewsRepository();
        public IEnumerable<NewsItemDto> getAllNews() {
            return repo.getAllNews();
        }
    }
}
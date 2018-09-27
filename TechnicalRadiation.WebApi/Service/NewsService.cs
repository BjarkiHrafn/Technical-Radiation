using System.Collections.Generic;
using TechnicalRadiation.WebApi.Models.DataTransferObjects;
using TechnicalRadiation.WebApi.Models.InputModels;
using TechnicalRadiation.WebApi.Repositories;

namespace TechnicalRadiation.WebApi.Service
{
    public class NewsService
    {
        ///get methods
        public NewsRepository repo = new NewsRepository();
        public IEnumerable<NewsItemDto> getAllNews(int pageNumber, int pageSize) {
            return repo.getAllNews(pageNumber, pageSize);
        }

        public NewsItemDetailDto getNewsByID(int id) {
            return repo.GetNewsByID(id);
        }

        /// all add methods

        public void createNewsItem(NewsItemInputModel model) {
            repo.createNewsItem(model);
        }
    }
}
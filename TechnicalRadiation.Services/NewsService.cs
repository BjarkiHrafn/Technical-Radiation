using System.Collections.Generic;
using TechnicalRadiation.Models.DataTransferObjects;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories;


namespace TechnicalRadiation.Services
{
    public class NewsService
    {
        ///get methods
        public NewsRepository repo = new NewsRepository();
        public IEnumerable<NewsItemDto> getAllNews(int pageNumber, int pageSize)
        {
            return repo.getAllNews(pageNumber, pageSize);
        }

        public NewsItemDetailDto getNewsByID(int id)
        {
            return repo.GetNewsByID(id);
        }

        /// all add methods

        public void createNewsItem(NewsItemInputModel model)
        {
            repo.createNewsItem(model);
        }

        public bool updateNewsItem(NewsItemInputModel model, int id)
        {
            return updateNewsItem(model, id);
        }
    }
}
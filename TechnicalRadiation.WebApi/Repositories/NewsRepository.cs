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

        public IEnumerable<NewsItemDto> getAllNews() {
            return _data._news.ToList().Select(x => new NewsItemDto() {
                Id = x.Id,
                Title = x.Title,
                ImgSource = x.ImgSource,
                ShortDescription = x.ShortDescription
            });
        }
        
        
        
        
        /* 
        public List<Model> _models => DataContext.Models;

        public List<ModelDetailsDTO> retrieveModels(string lang, int pageNumber, int pageSize) {

            List<ModelDetailsDTO> model = new List<ModelDetailsDTO>();
            
            model = ListExtensions.ToDetails(_models, lang).Skip((pageNumber-1) * pageSize).Take(pageSize).ToList();

            foreach(ModelDetailsDTO m in model) {
                m.Links.AddReference(m.Id.ToString(), "http://localhost:5000/api/model/" + m.Id.ToString());
            }

            if(_models.Count() < pageNumber * pageSize) return null;
            
            return model;
        }*/
    }
}
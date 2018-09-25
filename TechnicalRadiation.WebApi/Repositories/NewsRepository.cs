namespace TechnicalRadiation.WebApi.Repositories
{
    public class NewsRepository
    {/* 
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
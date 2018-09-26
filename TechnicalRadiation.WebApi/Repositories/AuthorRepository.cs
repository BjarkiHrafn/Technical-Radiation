using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.WebApi.Data;
using TechnicalRadiation.WebApi.Models.DataTransferObjects;
using template.Extensions;

namespace TechnicalRadiation.WebApi.Repositories
{
    public class AuthorRepository
    {
        private readonly DataContext _data = new DataContext();
 
        public IEnumerable<AuthorDto> getAllNews(int pageNumber, int pageSize) {
            var list =  _data._authors.ToList().Select(x => new AuthorDto() {
                Id = x.Id,
                Name = x.Name,
            });
            
            foreach(AuthorDto n in list) {
                n.Links.AddReference(n.Id.ToString(), "http://localhost:5000/api/authors/" + n.Id.ToString());
                
            }

            return list;
        }
        
    }
}
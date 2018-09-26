using System.Collections.Generic;
using TechnicalRadiation.WebApi.Models.DataTransferObjects;
using TechnicalRadiation.WebApi.Repositories;

namespace TechnicalRadiation.WebApi.Service
{
    public class AuthorService
    {
        public AuthorRepository repo = new AuthorRepository();
       /* public IEnumerable<AuthorDto> getAllNews(int pageNumber, int pageSize) {
            return repo.getAllNews(pageNumber, pageSize);
        }*/
    }
}
using System.Collections.Generic;
using TechnicalRadiation.WebApi.Models.DataTransferObjects;
using TechnicalRadiation.WebApi.Repositories;

namespace TechnicalRadiation.WebApi.Service
{
    public class AuthorService
    {
        public AuthorRepository repo = new AuthorRepository();
        public IEnumerable<AuthorDto> getAllAuthors() {
            return repo.getAllAuthors();
        }

        public AuthorDetailDto getNewsByID(int id) {
            return repo.getAuthorById(id);
        }

        public IEnumerable<NewsItemDto> getAllAuthorsById(int id) {
            return repo.getAllAuthorsById(id);
        }
    }
}
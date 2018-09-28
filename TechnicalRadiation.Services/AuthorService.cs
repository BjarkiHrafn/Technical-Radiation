using System.Collections.Generic;
using TechnicalRadiation.Models.DataTransferObjects;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories;

namespace TechnicalRadiation.Services
{
    public class AuthorService
    {
        public AuthorRepository repo = new AuthorRepository();
        public IEnumerable<AuthorDto> getAllAuthors()
        {
            return repo.getAllAuthors();
        }

        public AuthorDetailDto getNewsByID(int id)
        {
            return repo.getAuthorById(id);
        }

        public IEnumerable<NewsItemDto> getAllAuthorsById(int id)
        {
            return repo.getAllAuthorsById(id);
        }

        public void createAuthor(AuthorInputModel model)
        {
            repo.createAuthor(model);
        }
    }
}
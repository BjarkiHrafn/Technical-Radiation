using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.WebApi.Models.DataTransferObjects;
using TechnicalRadiation.WebApi.Service;

namespace TechnicalRadiation.WebApi.Controllers
{
    [Route("api/authors")]
    public class AuthorController : Controller
    {
        private AuthorService service = new AuthorService();
        [HttpGet]
        [Route("")]
        public IActionResult GetAllAuthors() {

            IEnumerable<AuthorDto> news = new List<AuthorDto>();
            news = service.getAllAuthors();

            if(news != null)
            return Ok(news);

            return Ok("no news found");
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult getNewsByID(int id) {
            AuthorDetailDto news = new AuthorDetailDto();
            news = service.getNewsByID(id);

            if(news != null)
            return Ok(news);

            return Ok("no authors found");
        }

        [HttpGet]
        [Route("{id:int}/newsItems")]
        public IActionResult getAllAuthorsById(int id) {
            IEnumerable<NewsItemDto> news = new List<NewsItemDto>();
            news = service.getAllAuthorsById(id);

            if(news != null)
            return Ok(news);

            return Ok("no news found");
        }
    }
}
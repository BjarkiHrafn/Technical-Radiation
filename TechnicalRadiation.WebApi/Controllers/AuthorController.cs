using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Models.DataTransferObjects;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Services;

namespace TechnicalRadiation.WebApi.Controllers
{
    [Route("api/authors")]
    public class AuthorController : Controller
    {
        private AuthorService service = new AuthorService();
        [HttpGet]
        [Route("")]
        public IActionResult GetAllAuthors()
        {

            IEnumerable<AuthorDto> news = new List<AuthorDto>();
            news = service.getAllAuthors();

            if (news != null)
                return Ok(news);

            return Ok("no news found");
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult getNewsByID(int id)
        {
            AuthorDetailDto news = new AuthorDetailDto();
            news = service.getNewsByID(id);

            if (news != null)
                return Ok(news);

            return Ok("no authors found");
        }

        [HttpGet]
        [Route("{id:int}/newsItems")]
        public IActionResult getAllAuthorsById(int id)
        {
            IEnumerable<NewsItemDto> news = new List<NewsItemDto>();
            news = service.getAllAuthorsById(id);

            if (news != null)
                return Ok(news);

            return Ok("no news found");
        }

        [HttpPatch]
        [Route("")]
        public IActionResult createAuthor([FromBody] AuthorInputModel model)
        {
            if (ModelState.IsValid)
            {
                service.createAuthor(model);
                return Ok(model);
            }
            else
            {
                service.createAuthor(model);
                return StatusCode(412, "invalid modelstate");
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult updateAuthorByID(int id, [FromBody] AuthorInputModel model)
        {
            if (ModelState.IsValid)
            {
                service.updateAuthorByID(model, id);
            }
            else
            {
                return StatusCode(412, model);
            }
            return NoContent();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult deleteAuthorByID(int id)
        {
            service.deleteAuthorByID(id);
            return StatusCode(204);
        }
    }
}
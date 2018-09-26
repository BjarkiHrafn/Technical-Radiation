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
        public IActionResult GetAllAuthors([FromQuery] int pageNumber, [FromQuery]int pageSize) {

            if(pageNumber == 0) pageNumber = 1;
            if(pageSize == 0) pageSize = 10;

            IEnumerable<AuthorDto> news = new List<AuthorDto>();
            //news = service.getAllNews(pageNumber, pageSize);

            if(news != null)
            return Ok(news);

            return Ok("no news found");
        }
    }
}
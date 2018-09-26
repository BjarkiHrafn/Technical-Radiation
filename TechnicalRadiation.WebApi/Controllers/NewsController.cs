using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.WebApi.Models.DataTransferObjects;
using TechnicalRadiation.WebApi.Service;

namespace TechnicalRadiation.WebApi.Controllers
{
    [Route("api")]
    public class NewsController : Controller
    {
        private NewsService service = new NewsService();
        [HttpGet]
        [Route("")]
        public IActionResult GetAllNews([FromQuery] int pageNumber, [FromQuery]int pageSize) {

            if(pageNumber == 0) pageNumber = 1;
            if(pageSize == 0) pageSize = 10;

            IEnumerable<NewsItemDto> news = new List<NewsItemDto>();
            news = service.getAllNews(pageNumber, pageSize);

            if(news != null)
            return Ok(news);

            return Ok("no news found");
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult getNewsByID(int id) {
            NewsItemDetailDto news = new NewsItemDetailDto();
            news = service.getNewsByID(id);

            if(news != null)
            return Ok(news);

            return Ok("no news found");
        }
    }
}
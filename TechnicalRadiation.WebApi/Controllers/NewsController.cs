using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Models.DataTransferObjects;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Services;

namespace TechnicalRadiation.WebApi.Controllers
{
    [Route("api")]
    public class NewsController : Controller
    {
        public string key = "k";
        private NewsService service = new NewsService();
        [HttpGet]
        [Route("")]
        public IActionResult GetAllNews([FromQuery] int pageNumber, [FromQuery]int pageSize)
        {

            if (pageNumber == 0) pageNumber = 1;
            if (pageSize == 0) pageSize = 10;

            IEnumerable<NewsItemDto> news = new List<NewsItemDto>();
            news = service.getAllNews(pageNumber, pageSize);

            if (news != null)
                return Ok(news);

            return Ok("no news found");
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult getNewsByID(int id)
        {
            NewsItemDetailDto news = new NewsItemDetailDto();
            news = service.getNewsByID(id);

            if (news != null)
                return Ok(news);

            return Ok("no news found");
        }

        ///add methods
        [HttpPatch]
        [Route("")]
        public IActionResult addNews([FromBody] NewsItemInputModel model)
        {

            //if(!model.ValidateURL(model.ImgSource))
            //  return Ok("Image source is incorrect");
            var key = Request.Headers.Keys.Contains("Authorization");
            var zelPass = Request.Headers.Values.Contains("k");

            if (key && zelPass)
            {
                service.createNewsItem(model);
                return Ok(model);
            }
            return Ok("incorrect password sukkah");

        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult updateNewsByID(int id)
        {
            // 204 statuscode for both PUT and DELETE ef allt gekk upp
            // 400/412 ef módelið er ekki rétt set upp
            // 404 ef það er verið að reyna að deleta resource sem er ekki til
            return StatusCode(204);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult deleteNewsByID(int id)
        {
            return StatusCode(204);
        }
    }
}
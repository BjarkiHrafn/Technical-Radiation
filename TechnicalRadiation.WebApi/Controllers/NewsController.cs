using Microsoft.AspNetCore.Mvc;

namespace TechnicalRadiation.WebApi.Controllers
{
    [Route("/api")]
    public class NewsController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetAllNews([FromQuery] int pageNumber, [FromQuery]int pageSize) {

           // string lang = "en-US";
            /* 
            Envelope<ModelDetailsDTO> envMod = new Envelope<ModelDetailsDTO>();
            var type = Request.Headers.Keys.Contains("Accept-Language"); 
            var typeV = Request.Headers.Values.Contains("de-DE");
            _server = new modelService();

            if(pageNumber == 0) pageNumber = 1;
            if(pageSize == 0) pageSize = 10;

            envMod.PageNumber = pageNumber;
            envMod.PageSize = pageSize;

            if(type&&typeV)lang = "de-DE";
            envMod.Items = _server.retrieveModels(lang, pageNumber, pageSize);

            if(envMod.Items != null)
            return Ok(envMod);*/

            return Ok(418);
        }
    }
}
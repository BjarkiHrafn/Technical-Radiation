using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Models.DataTransferObjects;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Services;

namespace TechnicalRadiation.WebApi.Controllers
{
    [Route("api/categories")]
    public class CategoryController : Controller
    {
        private CategoryService service = new CategoryService();
        [HttpGet]
        [Route("")]
        public IActionResult getAllCategories()
        {

            IEnumerable<CategoryDto> cat = new List<CategoryDto>();
            cat = service.getAllCategories();

            if (cat != null)
                return Ok(cat);

            return Ok("no categories found");
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult getCategoryById(int id)
        {
            CategoryDetailsDto cat = new CategoryDetailsDto();
            cat = service.getCategoryById(id);

            if (cat != null)
                return Ok(cat);

            return Ok("no categories found");
        }

        [HttpPatch]
        [Route("")]
        public IActionResult addCategory([FromBody] CategoryInputModel model)
        {
            var key = Request.Headers.Keys.Contains("Authorization");
            var zelPass = Request.Headers.Values.Contains("k");

            if (key && zelPass)
            {
                return Ok();
            }
            return Ok();
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult updateCategoryByID(int id)
        {
            return StatusCode(204);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult deleteCategoryByID(int id)
        {
            return StatusCode(204);
        }
/* 
        [HttpPatch] // patch for one to many and one to one link
        [Route("{int:categoryId}/newsItems/{int:newsItemId}")]
        public IActionResult linkNewsItemToCategory(int categoryId, int newsItemId)
        {
            return Ok();
        }*/
    }
}
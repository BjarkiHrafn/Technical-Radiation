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

            model.slug = model.Name.Replace(' ', '-').ToLower();

            if (ModelState.IsValid)
            {
                service.createCategory(model);
                return Ok(model);
            }
            else
            {
                return StatusCode(400, "invalid modelstate");
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult updateCategoryByID(int id, [FromBody] CategoryInputModel model)
        {
            if (ModelState.IsValid)
            {
                service.updateCategoryById(model, id);
            }
            else
            {
                return StatusCode(412, model);
            }
            return NoContent();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult deleteCategoryByID(int id)
        {
            service.deleteCategoryByID(id);
            return StatusCode(204);
        }


        [HttpPatch] // patch for one to many and one to one link
        [Route("{categoryId:int}/newsItems/{newsItemId:int}")]
        public IActionResult linkNewsItemToCategory(int categoryId, int newsItemId)
        {
            var ret = service.linkNewsItemToCategory(categoryId, newsItemId);
            return Ok(ret);
        }
    }
}
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Models.DataTransferObjects;
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
    }
}
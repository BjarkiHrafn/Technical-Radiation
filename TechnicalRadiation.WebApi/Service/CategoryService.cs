using System.Collections.Generic;
using TechnicalRadiation.WebApi.Models.DataTransferObjects;
using TechnicalRadiation.WebApi.Repositories;

namespace TechnicalRadiation.WebApi.Service
{
    public class CategoryService
    {
        public CategoryRepository repo = new CategoryRepository();
        public IEnumerable<CategoryDto> getAllCategories() {
            return repo.getAllCategories();
        }

        public CategoryDetailsDto getCategoryById(int id) {
            return repo.getCategoryById(id);
        }
    }
}
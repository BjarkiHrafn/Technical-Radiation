using System.Collections.Generic;
using TechnicalRadiation.Models.DataTransferObjects;
using TechnicalRadiation.Repositories;

namespace TechnicalRadiation.Services
{
    public class CategoryService
    {
        public CategoryRepository repo = new CategoryRepository();
        public IEnumerable<CategoryDto> getAllCategories()
        {
            return repo.getAllCategories();
        }

        public CategoryDetailsDto getCategoryById(int id)
        {
            return repo.getCategoryById(id);
        }
    }
}
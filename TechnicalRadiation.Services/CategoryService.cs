using System.Collections.Generic;
using TechnicalRadiation.Models.DataTransferObjects;
using TechnicalRadiation.Models.InputModels;
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

        /// all add methods

        public void createCategory(CategoryInputModel model)
        {
            repo.createCategory(model);
        }
    }
}
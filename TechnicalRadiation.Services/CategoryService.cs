using System;
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

        public bool linkNewsItemToCategory(int categoryId, int newsItemId)
        {
            return repo.linkNewsItemToCategory(categoryId, newsItemId);
        }

        public void updateCategoryById(CategoryInputModel model, int id)
        {
            var category = repo.getCategoryById(id);
            if (category == null) { throw new Exception($"Category with id {id} was not found"); }
            repo.updateCategoryByID(model, id);
        }

        public void deleteCategoryByID(int id)
        {
            var category = repo.getCategoryById(id);
            if (category == null) { throw new Exception($"Category with id {id} was not found"); }
            repo.deleteCategoryById(id);
        }
    }
}
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using TechnicalRadiation.Models.DataTransferObjects;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories.Data;
using TechnicalRadiation.Repositories.Extensions;
using TechnicalRadiation.Models.Entities;

namespace TechnicalRadiation.Repositories
{
    public class CategoryRepository
    {
        public string URL = "http://localhost:5000/";

        public ExpandoObject putHrefinNews(string path, int id)
        {
            ExpandoObject exp = new ExpandoObject();
            exp.AddReference("href", URL + path + "/" + id.ToString());

            return exp;
        }

        public IEnumerable<CategoryDto> getAllCategories()
        {
            var list = DataContext._categories.ToList().Select(x => new CategoryDto()
            {
                Id = x.Id,
                Name = x.Name,
                Slug = x.Slug

            });

            var temp = list.ToList();

            foreach (CategoryDto n in temp)
            {

                n.Links.AddReference("self", putHrefinNews("api/categories", n.Id));
                n.Links.AddReference("edit", putHrefinNews("api/categories", n.Id));
                n.Links.AddReference("delete", putHrefinNews("api/categories", n.Id));
            }

            return temp;
        }

        public CategoryDetailsDto getCategoryById(int id)
        {

            var data = (from c in DataContext._categories
                        join n in DataContext._news
                        on c.Id equals n.CategoryID
                        join a in DataContext._author
                        on n.AuthorID equals a.Id
                        where n.CategoryID == id
                        select new CategoryDetailsDto
                        {
                            Id = c.Id,
                            Name = c.Name,
                            Slug = c.Slug,
                            NumberOfNewsItems = DataContext._news.Count(n => n.CategoryID == c.Id),
                            ParentCategoryId = c.ParentCategoryId
                        }).FirstOrDefault();


            data.Links.AddReference("self", putHrefinNews("api", data.Id));
            data.Links.AddReference("edit", putHrefinNews("api", data.Id));
            data.Links.AddReference("delete", putHrefinNews("api", data.Id));


            return data;

        }


        /// here come the post actions

        public void createCategory(CategoryInputModel model)
        {


            DataContext._categories.Add(new Category()
            {
                Id = DataContext._categories.Max(x => x.Id) + 1,
                Name = model.Name,
                ParentCategoryId = model.ParentCategoryId,
                Slug = model.slug

            });
        }
        public bool linkNewsItemToCategory(int categoryId, int newsItemId)
        {

            var NewsItem = (from news in DataContext._news
                            where news.Id == newsItemId
                            select news).FirstOrDefault();


            if (NewsItem != null)
            {
                NewsItem.CategoryID = categoryId;
                DataContext._news.Add(NewsItem);

                return true;
            }

            return false;

        }
    }
}
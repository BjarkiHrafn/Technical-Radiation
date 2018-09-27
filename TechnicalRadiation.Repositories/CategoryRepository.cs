using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using TechnicalRadiation.Models.DataTransferObjects;
using TechnicalRadiation.Repositories.Data;
using TechnicalRadiation.Repositories.Extensions;

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


            var data = DataContext._categories.ToList().Select(x => new CategoryDetailsDto()
            {
                Id = x.Id,
                Name = x.Name,
                Slug = x.Slug,
                NumberOfNewsItems = DataContext._news.Count(n => n.CategoryID == x.Id),
                ParentCategoryId = x.ParentCategoryId
            }).FirstOrDefault(x => x.Id == id);

            data.Links.AddReference("self", putHrefinNews("api", data.Id));
            data.Links.AddReference("edit", putHrefinNews("api", data.Id));
            data.Links.AddReference("delete", putHrefinNews("api", data.Id));


            return data;

        }
    }
}
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using TechnicalRadiation.Models.DataTransferObjects;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Repositories.Data;
using TechnicalRadiation.Repositories.Extensions;

namespace TechnicalRadiation.Repositories
{
    public class AuthorRepository
    {
        public string URL = "http://localhost:5000/";

        public ExpandoObject putHrefinAuthors(string path, int id)
        {
            ExpandoObject exp = new ExpandoObject();
            exp.AddReference("href", URL + path + "/" + id.ToString());

            return exp;
        }

        public ExpandoObject putHrefinNewsItems(string path, string id)
        {
            ExpandoObject exp = new ExpandoObject();
            exp.AddReference("href", URL + path + "/" + id);

            return exp;
        }

        public ExpandoObject putHrefinNewsItemsDetails(string path, int id)
        {
            ExpandoObject exp = new ExpandoObject();
            exp.AddReference("href", URL + path + "/" + id);

            return exp;
        }

        public IEnumerable<AuthorDto> getAllAuthors()
        {
            var list = DataContext._author.ToList().Select(x => new AuthorDto()
            {
                Id = x.Id,
                Name = x.Name,
            });

            List<ExpandoObject> expando = new List<ExpandoObject>();
            var listList = list.ToList();

            foreach (AuthorDto n in listList)
            {
                n.Links.AddReference("self", putHrefinAuthors("api/authors", n.Id));
                n.Links.AddReference("edit", putHrefinAuthors("api/authors", n.Id));
                n.Links.AddReference("delete", putHrefinAuthors("api/authors", n.Id));
                n.Links.AddReference("newsItems", putHrefinNewsItems("api/authors/" + n.Id.ToString(), n.Name));



                foreach (NewsItem news in DataContext._news.ToList())
                {
                    if (n.Id == news.AuthorID)
                        expando.Add(putHrefinNewsItemsDetails("api", n.Id));
                }

                n.Links.AddReference("newsItemsDetailed", expando);


            }

            return listList;
        }

        public AuthorDetailDto getAuthorById(int id)
        {

            var data = DataContext._author.ToList().Select(x => new AuthorDetailDto()
            {
                Id = x.Id,
                Name = x.Name,
                ProfileImgSource = x.ProfileImgSource,
                Bio = x.Bio
            }).FirstOrDefault(x => x.Id == id);

            data.Links.AddReference("self", putHrefinNewsItemsDetails("api/authors", data.Id));
            data.Links.AddReference("edit", putHrefinNewsItemsDetails("api/authors", data.Id));
            data.Links.AddReference("delete", putHrefinNewsItemsDetails("api/authors", data.Id));
            data.Links.AddReference("newsItems", putHrefinNewsItems("api/authors/" + data.Id.ToString(), data.Name));

            List<ExpandoObject> expando = new List<ExpandoObject>();

            foreach (NewsItem news in DataContext._news.ToList())
            {
                if (data.Id == news.AuthorID)
                    expando.Add(putHrefinNewsItemsDetails("api", data.Id));
            }

            data.Links.AddReference("newsItemsDetailed", expando);

            return data;
        }

        public IEnumerable<NewsItemDto> getAllAuthorsById(int id)
        {

            var combined = (from n in DataContext._news
                            join a in DataContext._author
                            on n.AuthorID equals a.Id
                            where n.AuthorID == id
                            select new NewsItemDto
                            {
                                Id = n.Id,
                                Title = n.Title,
                                ImgSource = n.ImgSource,
                                ShortDescription = n.ShortDescription
                            }).ToList();

            List<ExpandoObject> authors = new List<ExpandoObject>();
            List<ExpandoObject> categories = new List<ExpandoObject>();
            var listList = combined.ToList();

            foreach (NewsItemDto n in listList)
            {
                n.Links.AddReference("self", putHrefinAuthors("api", n.Id));
                n.Links.AddReference("edit", putHrefinAuthors("api", n.Id));
                n.Links.AddReference("delete", putHrefinAuthors("api", n.Id));



                foreach (Author news in DataContext._author.ToList())
                {
                    if (n.AuthorID == news.Id)
                        authors.Add(putHrefinNewsItemsDetails("api/authors", n.AuthorID));
                }
                n.Links.AddReference("authors", authors);

                foreach (Category cat in DataContext._categories.ToList())
                {
                    if (n.CategoryID == cat.Id)
                        categories.Add(putHrefinNewsItemsDetails("api/categories", n.CategoryID));
                }
                n.Links.AddReference("categories", categories);
            }

            return listList;
        }
    }
}
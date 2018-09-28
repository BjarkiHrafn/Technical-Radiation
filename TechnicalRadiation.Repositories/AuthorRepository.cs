using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using TechnicalRadiation.Models.DataTransferObjects;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
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
            var data = (from a in DataContext._author
                        where a.Id == id
                        select new AuthorDetailDto
                        {
                            Id = a.Id,
                            Name = a.Name,
                            ProfileImgSource = a.ProfileImgSource,
                            Bio = a.Bio
                        }).FirstOrDefault();

            data.Links.AddReference("self", putHrefinNewsItemsDetails("api/authors", data.Id));
            data.Links.AddReference("edit", putHrefinNewsItemsDetails("api/authors", data.Id));
            data.Links.AddReference("delete", putHrefinNewsItemsDetails("api/authors", data.Id));
            data.Links.AddReference("newsItems", putHrefinNewsItems("api/authors" + data.Id.ToString(), data.Name));

            List<ExpandoObject> expando = new List<ExpandoObject>();

            foreach (NewsItem news in DataContext._news)
            {
                if (data.Id == news.AuthorID)
                    expando.Add(putHrefinNewsItemsDetails("api", news.Id));
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
                                ShortDescription = n.ShortDescription,
                                AuthorID = n.AuthorID,
                                CategoryID = n.CategoryID
                            }).ToList();



            var listList = combined.ToList();

            foreach (NewsItemDto n in listList)
            {
                List<ExpandoObject> categories = new List<ExpandoObject>();
                n.Links.AddReference("self", putHrefinAuthors("api", n.Id));
                n.Links.AddReference("edit", putHrefinAuthors("api", n.Id));
                n.Links.AddReference("delete", putHrefinAuthors("api", n.Id));

                if (n.AuthorID == id)
                {
                    List<ExpandoObject> authors = new List<ExpandoObject>();
                    authors.Add(putHrefinNewsItemsDetails("api/authors", n.AuthorID));
                    n.Links.AddReference("authors", authors);
                }

                foreach (Category cat in DataContext._categories)
                {
                    if (n.CategoryID == cat.Id && n.AuthorID == id)
                    {

                        categories.Add(putHrefinNewsItemsDetails("api/categories", n.CategoryID));
                        n.Links.AddReference("categories", categories);
                    }

                }

            }


            return listList;
        }

        /// here come post actions
        public void createAuthor(AuthorInputModel model)
        {
            DataContext._author.Add(new Author()
            {
                Id = DataContext._author.Max(x => x.Id) + 1,
                Name = model.Name,
                ProfileImgSource = model.ProfileImgSource,
                Bio = model.Bio
            });
        }

        public void updateAuthorByID(AuthorInputModel model, int id)
        {
            var updateAuthor = DataContext._author.FirstOrDefault(x => x.Id == id);

            if (updateAuthor != null)
            {
                updateAuthor.Bio = model.Bio;
                updateAuthor.ModifiedBy = "SystemAdmin";
                updateAuthor.ModifiedDate = DateTime.Now;
                updateAuthor.Name = model.Name;
                updateAuthor.ProfileImgSource = model.ProfileImgSource;
            }
        }

        public void deleteAuthorByID(int id)
        {
            var deleteAuthor = DataContext._author.FirstOrDefault(x => x.Id == id);

            if (deleteAuthor != null)
            {
                DataContext._author.Remove(deleteAuthor);
            }
        }
    }
}
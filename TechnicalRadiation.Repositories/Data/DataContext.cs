using System;
using System.Collections.Generic;
using TechnicalRadiation.Models.Entities;

namespace TechnicalRadiation.Repositories.Data
{
    public class DataContext
    {
        public static List<NewsItem> _news = new List<NewsItem>
        {

            new NewsItem
            {
                AuthorID = 1,
                CategoryID = 1,
                Id = 1,
                Title = "Hey here's some big news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate = DateTime.Parse("08/12/2016 10:00:07")
            },
            new NewsItem
            {
                AuthorID = 2,
                CategoryID = 2,
                Id = 2,
                Title = "Hey here's some news again",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate = DateTime.Parse("08/12/2016 10:00:07")
            },
            new NewsItem
            {
                AuthorID = 3,
                CategoryID = 3,
                Id = 3,
                Title = "Hey here's some news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate =DateTime.Parse("08/12/2016 10:00:07")
            },
            new NewsItem
            {
                AuthorID = 4,
                CategoryID = 4,
                Id = 4,
                Title = "Hey here's some news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate = DateTime.Parse("08/12/2016 10:00:07")
            },
            new NewsItem
            {
                AuthorID = 5,
                CategoryID = 5,
                Id = 5,
                Title = "Hey here's some news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate = DateTime.Parse("08/12/2016 10:00:07")
            },
            new NewsItem
            {
                AuthorID = 6,
                CategoryID = 6,
                Id = 6,
                Title = "Hey here's some news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate = DateTime.Parse("08/12/2016 10:00:07")
            },
            new NewsItem
            {
                AuthorID = 7,
                CategoryID = 7,
                Id = 7,
                Title = "Hey here's some news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate = DateTime.Parse("08/12/2016 10:00:07")
            },
            new NewsItem
            {
                AuthorID = 8,
                CategoryID = 8,
                Id = 8,
                Title = "Hey here's some news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate = DateTime.Parse("08/12/2016 10:00:07")
            },
            new NewsItem
            {
                AuthorID = 8,
                CategoryID = 8,
                Id = 8,
                Title = "Hey here's some news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate = DateTime.Parse("08/12/2016 10:00:07")
            },
            new NewsItem
            {
                AuthorID = 9,
                CategoryID = 9,
                Id = 9,
                Title = "Hey here's some news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate = DateTime.Parse("08/12/2016 10:00:07")
            },
            new NewsItem
            {
                AuthorID = 10,
                CategoryID = 10,
                Id = 10,
                Title = "Hey here's some news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate = DateTime.Parse("08/12/2016 10:00:07")
            },
            new NewsItem
            {
                AuthorID = 11,
                CategoryID = 11,
                Id = 11,
                Title = "Hey here's some news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate = DateTime.Parse("08/12/2016 10:00:07")
            },
            new NewsItem
            {
                AuthorID = 12,
                CategoryID = 12,
                Id = 12,
                Title = "Hey here's some news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate = DateTime.Parse("08/12/2016 10:00:07")
            },
            new NewsItem
            {
                AuthorID = 13,
                CategoryID = 13,
                Id = 13,
                Title = "Hey here's some news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate = DateTime.Parse("08/12/2016 10:00:07")
            },
            new NewsItem
            {
                AuthorID = 14,
                CategoryID = 14,
                Id = 14,
                Title = "Hey here's some news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate = DateTime.Parse("08/12/2016 10:00:07")
            },
            new NewsItem
            {
                AuthorID = 15,
                CategoryID = 15,
                Id = 15,
                Title = "Hey here's some news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
                PublishDate = DateTime.Parse("08/12/2016 10:00:07")
            }

        };
        public static List<NewsItem> _news_items { get => _news; set => _news = value; }
        public static List<Author> _author = new List<Author>
        {

            new Author
            {
                Bio = "Eg elska bio og popp",
                CreatedDate = DateTime.Parse("08/12/2016 10:00:07"),
                Id = 0,
                Name = "Bleller feller",
                ModifiedDate = DateTime.Parse("08/12/2016 10:00:07"),
                ProfileImgSource = "blalalla.jpg"
            },
            new Author
            {
                Bio = "Eg elska bio og popp",
                CreatedDate = DateTime.Parse("08/12/2016 10:00:07"),
                Id = 1,
                Name = "Blexxller feller",
                ModifiedDate = DateTime.Parse("08/12/2016 10:00:07"),
                ProfileImgSource = "blalalla.jpg"
            },
            new Author
            {
                Bio = "Eg elska bio og popp",
                CreatedDate = DateTime.Parse("08/12/2016 10:00:07"),
                Id = 2,
                Name = "Blevcller feller",
                ModifiedDate = DateTime.Parse("08/12/2016 10:00:07"),
                ProfileImgSource = "blalalla.jpg"
            },
            new Author
            {
                Bio = "Eg elska bio og popp",
                CreatedDate = DateTime.Parse("08/12/2016 10:00:07"),
                Id = 3,
                Name = "Ble4ller feller",
                ModifiedDate = DateTime.Parse("08/12/2016 10:00:07"),
                ProfileImgSource = "blalalla.jpg"
            },
            new Author
            {
                Bio = "Eg elska bio og popp",
                CreatedDate = DateTime.Parse("08/12/2016 10:00:07"),
                Id = 4,
                Name = "Ble3ller feller",
                ModifiedDate = DateTime.Parse("08/12/2016 10:00:07"),
                ProfileImgSource = "blalalla.jpg"
            },
            new Author
            {
                Bio = "Eg elska bio og popp",
                CreatedDate = DateTime.Parse("08/12/2016 10:00:07"),
                Id = 5,
                Name = "Blel2ler feller",
                ModifiedDate = DateTime.Parse("08/12/2016 10:00:07"),
                ProfileImgSource = "blalalla.jpg"
            },
            new Author
            {
                Bio = "Eg elska bio og popp",
                CreatedDate = DateTime.Parse("08/12/2016 10:00:07"),
                Id = 6,
                Name = "Blelsler feller",
                ModifiedDate = DateTime.Parse("08/12/2016 10:00:07"),
                ProfileImgSource = "blalalla.jpg"
            }

        };
        public static List<Category> _categories = new List<Category>
        {
            new Category
            {
                Name = "Gadgets",
                Slug = "gadgets",
                Id = 0,
                ModifiedBy ="",
                CreatedDate = DateTime.Parse("08/12/2016 10:00:07"),
                ModifiedDate = DateTime.Parse("08/12/2016 10:00:07"),
            },
            new Category
            {
                Name = "Weapons",
                Slug = "weapons",
                Id = 1,
                ModifiedBy ="",
                CreatedDate = DateTime.Parse("08/12/2016 10:00:07"),
                ModifiedDate = DateTime.Parse("08/12/2016 10:00:07"),
            },
            new Category
            {
                Name = "Clothes",
                Slug = "clothes",
                Id = 2,
                ModifiedBy ="",
                CreatedDate = DateTime.Parse("08/12/2016 10:00:07"),
                ModifiedDate = DateTime.Parse("08/12/2016 10:00:07"),
            },
            new Category
            {
                Name = "Cars",
                Slug = "cars",
                Id = 3,
                ModifiedBy ="",
                CreatedDate = DateTime.Parse("08/12/2016 10:00:07"),
                ModifiedDate = DateTime.Parse("08/12/2016 10:00:07"),
            }
        };
    }
}
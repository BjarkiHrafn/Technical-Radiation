using System;
using System.Collections.Generic;
using TechnicalRadiation.WebApi.Models.Entities;

namespace TechnicalRadiation.WebApi.Data
{
    public class DataContext
    {
        public IEnumerable<NewsItem> _news
        {
            get{
                return new List<NewsItem> {
            
            new NewsItem
            {
                AuthorID = 1,
                CategoryID = 1,
                Id = 1,
                Title = "Hey here's some news",
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
            }
            
        }
    }
}
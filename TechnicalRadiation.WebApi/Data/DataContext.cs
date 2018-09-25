using System.Collections.Generic;
using TechnicalRadiation.WebApi.Models.Entities;

namespace TechnicalRadiation.WebApi.Data
{
    public static class DataContext
    {
        private static List<NewsItem> _news = new List<NewsItem>
        {
            new NewsItem
            {
                AuthorID = 1,
                CategoryID = 1,
                Id = 1,
                Title = "Hey here's some news",
                ImgSource = "whatevah.jpg",
                ShortDescription = "bla",
                LongDescription = "bla bla",
            }
        };
    }
}
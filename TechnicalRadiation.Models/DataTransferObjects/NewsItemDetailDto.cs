using System;

namespace TechnicalRadiation.Models.DataTransferObjects
{
    public class NewsItemDetailDto : HyperMediaModel
    {
        public int AuthorID { get; set; }
        public int CategoryID { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImgSource { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
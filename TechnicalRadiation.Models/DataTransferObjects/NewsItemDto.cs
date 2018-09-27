namespace TechnicalRadiation.Models.DataTransferObjects
{
    public class NewsItemDto : HyperMediaModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImgSource { get; set; }
        public string ShortDescription { get; set; }
        public int AuthorID { get; set; }
        public int CategoryID { get; set; }
    }
}
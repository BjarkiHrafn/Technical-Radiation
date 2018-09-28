using System;
using System.ComponentModel.DataAnnotations;
using TechnicalRadiation.Models.Attributes;

namespace TechnicalRadiation.Models.InputModels
{
    public class NewsItemInputModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [validateImgUrl]
        public string ImgSource { get; set; }
        [Required]
        [MaxLength(50)]
        public string ShortDescription { get; set; }
        [MinLength(50), MaxLength(255)]
        public string LongDescription { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }

    }
}
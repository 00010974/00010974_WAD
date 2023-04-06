using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using _00010974.Data.Enums;
using Microsoft.AspNetCore.Routing;

namespace _00010974.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Img Url")]
        public string ImgUrl { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "AuthorName")]
        public string AuthorName { get; set; }
        [Display(Name = "Series")]
        public Series Series { get; set; }
        [Display(Name = "Price")]
        public int Price { get; set; }
        [Display(Name = "Genre")]
        public Genre Genre { get; set; }
        [Display(Name = "PublishingHouse")]
        public string PublishingHouse { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationships

        public List<Books_Publishers> Books_Publishers { get; set; }

        //Authors
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Authors Authors { get; set; }
    }
}

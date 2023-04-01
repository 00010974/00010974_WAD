using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _00010974.Data.Enums;
using Microsoft.AspNetCore.Routing;

namespace _00010974.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string Series { get; set; }
        public int Price { get; set; }
        public Genre Genre { get; set; }
        public string Description { get; set; }

        //Relationships

        public List<Books_Publishers> Books_Publishers { get; set; }

        //Authors

        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public  Authors Authors { get; set; }
    }
}

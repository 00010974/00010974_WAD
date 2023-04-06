using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _00010974.Models
{
    public class Authors
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Author Picture")]
        public string AuthorPicture { get; set; }
        [DisplayName("Author Name")]
        public string FullName { get; set; }
        [DisplayName("Author Books")]
        public string AuthorBooks { get; set; }

        //Relationships

        public List<Books> Books { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _00010974.Data.Base;

namespace _00010974.Models
{
    public class Authors: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Author Picture")]
        [Required(ErrorMessage = "Author Picture in empty")]
        public string AuthorPicture { get; set; }
        [DisplayName("Author Name")]
        [Required(ErrorMessage = "Author Name in empty")]

        public string FullName { get; set; }
        [DisplayName("Author Books")]
        [Required(ErrorMessage = "Author Books in empty")]

        public string AuthorBooks { get; set; }

        //Relationships

        public List<Books> Books { get; set; }
    }
}

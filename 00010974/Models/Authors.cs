using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _00010974.Models
{
    public class Authors
    {
        [Key]
        public int Id { get; set; }
        public string AuthorPicture { get; set; }
        public string FullName { get; set; }  
        public string AuthorBooks { get; set; }

        //Relationships

        public List<Books> Books { get; set; }
    }
}

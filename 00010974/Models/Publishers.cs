using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _00010974.Models
{
    public class Publishers
    {
        [Key] public int Id { get; set; }
        public string Title { get; set; }
        public string Bio { get; set; }

        //Relationships

        public  List<Books_Publishers> Books_Publishers { get; set; }
    }
}

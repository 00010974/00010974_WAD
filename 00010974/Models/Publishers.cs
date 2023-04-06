using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _00010974.Models
{
    public class Publishers
    {
        [Key] 
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }
        private int PublishersId { get; set; }

        //Relationships

        public  List<Books_Publishers> Books_Publishers { get; set; }
    }
}

 namespace _00010974.Models
{
    public class Books_Publishers
    {
        public int BooksId { get; set; }
        public Books Books { get; set; }
        public int PublishersId { get; set; }
        public Publishers Publishers { get; set; }

    }
}

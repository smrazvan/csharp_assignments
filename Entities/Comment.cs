namespace Blogger_server.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public string Author { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime Date { get; set; }
    }
}

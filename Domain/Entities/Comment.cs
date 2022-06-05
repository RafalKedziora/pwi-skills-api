namespace Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Author { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
    }
}

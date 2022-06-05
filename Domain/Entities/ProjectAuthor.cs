namespace Domain.Entities
{
    public class ProjectAuthor
    {
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
    }
}

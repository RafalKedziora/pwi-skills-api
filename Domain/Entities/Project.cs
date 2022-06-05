namespace Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public ICollection<ProjectDetails> Details { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<Technology> Technologies { get; set; }
    }
}

namespace Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public bool isActive { get; set; }
        public ICollection<ProjectDetails> Details { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public IList<Author> Authors { get; set; }
        public IList<TechStack> TechStacks { get; set; }
    }
}

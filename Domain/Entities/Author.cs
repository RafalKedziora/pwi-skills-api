namespace Domain.Entities
{
    public class Author
    {
        public Guid Id { get; set; }
        public string NickName { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}

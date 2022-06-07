namespace Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public IList<ProjectAuthor> projectAuthors { get; set; }
    }
}

namespace Application.Dto
{
    public class AuthorDto
    {
        public Guid Id { get; set; }
        public string NickName { get; set; }
        public ICollection<ProjectDto> Projects { get; set; }
    }
}

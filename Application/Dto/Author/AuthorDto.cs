namespace Application.Dto
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public ICollection<ProjectDto> Projects { get; set; }
    }
}

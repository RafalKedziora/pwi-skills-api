using Domain.Entities;

namespace Application.Dto
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public IList<ProjectDto> Projects { get; set; }
    }
}

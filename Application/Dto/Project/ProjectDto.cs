using Domain.Entities;

namespace Application.Dto
{
    public class ProjectDto
    {
        public int Id { get; set; }
        public bool isActive { get; set; }
        public ICollection<ProjectDetails> Details { get; set; }
        public ICollection<CommentDto> Comments { get; set; }
        public ICollection<ProjectAuthor> Authors { get; set; }
        public ICollection<ProjectTechnology> Technologies { get; set; }
    }
}

using Domain.Entities;

namespace Application.Dto
{
    public class ProjectDto
    {
        public int Id { get; set; }
        public bool isActive { get; set; }
        public ICollection<ProjectDetailsDto> Details { get; set; }
        public ICollection<CommentDto> Comments { get; set; }
        public IList<AuthorProjectDto> Authors { get; set; }
        public IList<TechStackProjectDto> TechStacks { get; set; }        
    }
}

using Domain.Entities;

namespace Application.Dto
{
    public class TechStackDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ProjectDto> Projects { get; set; }
    }
}

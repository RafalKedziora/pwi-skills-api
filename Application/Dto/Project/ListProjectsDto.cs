namespace Application.Dto
{
    public class ListProjectsDto
    {
        public int Count { get; set; }
        public IEnumerable<ProjectDto> Projects { get; set; }
    }
}

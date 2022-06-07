namespace Application.Dto
{
    public class ListTechStacksDto
    {
        public int Count { get; set; }
        public IEnumerable<TechStackDto> TechStacks { get; set; }
    }
}

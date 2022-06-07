namespace Application.Dto
{
    public class CreateProjectDetailsDto
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
    }
}

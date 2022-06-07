namespace Application.Dto
{
    public class UpdateProjectDetailsDto
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Description { get; set; }
    }
}

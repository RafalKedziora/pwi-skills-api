namespace Domain.Entities
{
    public class ProjectDetails
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Description { get; set; }

        public Project Project { get; set; }
        public int ProjectId { get; set; }
    }
}
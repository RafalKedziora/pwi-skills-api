namespace Domain.Entities
{
    public class ProjectTechnology
    {
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public TechStack Technology { get; set; }
        public int TechnologyId { get; set; }
    }
}

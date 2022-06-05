namespace Domain.Entities
{
    public class ProjectTechnology
    {
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public Technology Technology { get; set; }
        public int TechnologyId { get; set; }
    }
}

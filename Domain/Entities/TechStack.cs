namespace Domain.Entities
{
    public class TechStack
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public IList<ProjectTechnology> projectTechnologies { get; set; }
        public IList<Project> Projects { get; set; }
    }
}

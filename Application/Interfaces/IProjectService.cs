using Domain.Entities;

namespace Application.Interfaces
{
    public interface IProjectService
    {
        IQueryable<Project> GetAllProjects();
        Project GetProjectById(int id);
        Project AddProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(Project project);
    }
}

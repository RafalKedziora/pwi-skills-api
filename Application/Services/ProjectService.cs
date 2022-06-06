using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class ProjectService : IProjectService
    {
        public IQueryable<Project> GetAllProjects()
        {
            throw new NotImplementedException();
        }

        public Project GetProjectById(int id)
        {
            throw new NotImplementedException();
        }

        public Project AddProject(Project project)
        {
            throw new NotImplementedException();
        }

        public void UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public void DeleteProject(Project project)
        {
            throw new NotImplementedException();
        }
    }
}

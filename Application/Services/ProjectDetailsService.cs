using Application.Dto;
using Application.Interfaces;

namespace Application.Services
{
    public class ProjectDetailsService : IProjectDetailsService
    {
        public ProjectDetailsDto GetProjectDetailsById(int id)
        {
            throw new NotImplementedException();
        }
        
        public ProjectDetailsDto AddProjectDetails(CreateProjectDetailsDto newProjectDetails)
        {
            throw new NotImplementedException();
        }

        public void UpdateProject(int id, UpdateProjectDetailsDto projectDetails)
        {
            throw new NotImplementedException();
        }

        public void DeleteProject(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using Application.Dto;

namespace Application.Interfaces
{
    public interface IProjectDetailsService
    {
        ProjectDetailsDto GetProjectDetailsById(int id);
        ProjectDetailsDto AddProjectDetails(CreateProjectDetailsDto newProjectDetails);
        void UpdateProject(int id, UpdateProjectDetailsDto projectDetails);
        void DeleteProject(int id);
    }
}

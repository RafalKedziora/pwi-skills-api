using Application.Dto;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IProjectService
    {
        ListProjectsDto GetAllProjects();
        ProjectDto GetProjectById(int id);
        ProjectDto AddProject(CreateProjectDto newProject);
        void UpdateProject(int id, UpdateProjectDto project);
        void DeleteProject(int id);
    }
}

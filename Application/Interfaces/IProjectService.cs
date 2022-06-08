using Application.Dto;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IProjectService
    {
        ListProjectsDto GetAllProjects(string languageCode);
        ProjectDto GetProjectById(int id);
        ProjectDto GetProjectByIdByLanguage(int id, string languageCode);
        ProjectDto AddProject(CreateProjectDto newProject);
        void UpdateProject(int id, UpdateProjectDto project);
        void DeleteProject(int id);
    }
}

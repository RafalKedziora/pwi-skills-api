using Application.Dto;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public ProjectService(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }

        public ListProjectsDto GetAllProjects()
        {
            var projects = _projectRepository.GetAll();
            return _mapper.Map<ListProjectsDto>(projects);
        }

        public ProjectDto GetProjectById(int id)
        {
            var project = _projectRepository.GetById(id);
            return _mapper.Map<ProjectDto>(project);
        }

        public ProjectDto AddProject(CreateProjectDto newProject)
        {
            var project = _mapper.Map<Project>(newProject);
            _projectRepository.Add(project);
            return _mapper.Map<ProjectDto>(project);
        }

        public void UpdateProject(int id, UpdateProjectDto project)
        {
            var existingProject = _projectRepository.GetById(project.Id);
            var updatedProject = _mapper.Map(project, existingProject);
            _projectRepository.Update(updatedProject);
        }

        public void DeleteProject(int id)
        {
            var project = _projectRepository.GetById(id);
            _projectRepository.Delete(project);
        }
    }
}

using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IProjectRepository
    {
        IQueryable<Project> GetAll();
        Project GetById(int id);
        Project Add(Project project);
        void Update(Project project);
        void Delete(Project project);
    }
}

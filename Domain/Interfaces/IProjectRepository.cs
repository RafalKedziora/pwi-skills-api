using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IProjectRepository
    {
        IQueryable<Project> GetAll(string languageCode);
        Project GetById(int id);
        Project GetByIdByLanguage(int id, string languageCode);
        Project Add(Project project);
        void Update(Project project);
        void Delete(Project project);
    }
}

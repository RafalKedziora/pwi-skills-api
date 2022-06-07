using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IProjectDetailsRepository
    {
        ProjectDetails GetById(int id);
        ProjectDetails Add(ProjectDetails project);
        void Update(ProjectDetails project);
        void Delete(ProjectDetails project);
    }
}

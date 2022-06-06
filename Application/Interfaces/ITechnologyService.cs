using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITechnologyService
    {
        IQueryable<Technology> GetAllTechnologies();
        Technology GetTechnologyById(int id);
        Technology AddTechnology(Technology technology);
        void UpdateTechnology(Technology technology);
        void DeleteTechnology(Technology technology);
    }
}

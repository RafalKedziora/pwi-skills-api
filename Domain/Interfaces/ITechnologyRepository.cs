using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ITechnologyRepository
    {
        IQueryable<Technology> GetAll();
        Technology GetById(int id);
        Technology Add(Technology technology);
        void Update(Technology technology);
        void Delete(Technology technology);
    }
}

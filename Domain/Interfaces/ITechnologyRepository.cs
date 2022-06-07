using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ITechnologyRepository
    {
        IQueryable<TechStack> GetAll();
        TechStack GetById(int id);
        TechStack Add(TechStack technology);
        void Update(TechStack technology);
        void Delete(TechStack technology);
    }
}

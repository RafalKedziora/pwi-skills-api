using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ILanguageRepository
    {
        IQueryable<Language> GetAll();
        Language GetById(int id);
        Language Add(Language language);
        void Update(Language language);
        void Delete(Language language);
    }
}

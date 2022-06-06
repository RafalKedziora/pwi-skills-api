using Domain.Entities;

namespace Application.Interfaces
{
    public interface ILanguageService
    {
        IQueryable<Language> GetAllLanguages();
        Language GetLanguageById(int id);
        Language AddLanguage(Language language);
        void UpdateLanguage(Language language);
        void DeleteLanguage(Language language);
    }
}

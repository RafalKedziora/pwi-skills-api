using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class LanguageService : ILanguageService
    {
        public IQueryable<Language> GetAllLanguages()
        {
            throw new NotImplementedException();
        }

        public Language GetLanguageById(int id)
        {
            throw new NotImplementedException();
        }

        public Language AddLanguage(Language language)
        {
            throw new NotImplementedException();
        }
        
        public void UpdateLanguage(Language language)
        {
            throw new NotImplementedException();
        }

        public void DeleteLanguage(Language language)
        {
            throw new NotImplementedException();
        }
    }
}

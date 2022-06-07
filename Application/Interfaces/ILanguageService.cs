using Application.Dto;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ILanguageService
    {
        ListLanguagesDto GetAllLanguages();
        LanguageDto GetLanguageById(int id);
        LanguageDto AddLanguage(CreateLanguageDto newLanguage);
        void UpdateLanguage(UpdateLanguageDto language);
        void DeleteLanguage(int id);
    }
}

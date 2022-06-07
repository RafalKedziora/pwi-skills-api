using Application.Dto;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly IMapper _mapper;
        private readonly ILanguageRepository _languageRepository;

        public LanguageService(IMapper mapper, ILanguageRepository languageRepository)
        {
            _mapper = mapper;
            _languageRepository = languageRepository;
        }

        public ListLanguagesDto GetAllLanguages()
        {
            var languages = _languageRepository.GetAll();
            return _mapper.Map<ListLanguagesDto>(languages);
        }

        public LanguageDto GetLanguageById(int id)
        {
            var language = _languageRepository.GetById(id);
            return _mapper.Map<LanguageDto>(language);
        }

        public LanguageDto AddLanguage(CreateLanguageDto newLanguage)
        {
            var language = _mapper.Map<Language>(newLanguage);
            _languageRepository.Add(language);
            return _mapper.Map<LanguageDto>(language);
        }

        public void UpdateLanguage(UpdateLanguageDto language)
        {
            var existingLanguage = _languageRepository.GetById(language.Id);
            var updatedLanguage = _mapper.Map(language, existingLanguage);
            _languageRepository.Update(updatedLanguage);
        }

        public void DeleteLanguage(int id)
        {
            var language = _languageRepository.GetById(id);
            _languageRepository.Delete(language);
        }
    }
}

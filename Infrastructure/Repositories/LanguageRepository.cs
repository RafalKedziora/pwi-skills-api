using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly SkillContext _context;
        public LanguageRepository(SkillContext context)
        {
            _context = context;
        }

        public IQueryable<Language> GetAll()
        {
            return _context.Languages;
        }

        public Language GetById(int id)
        {
            return _context.Languages
                .FirstOrDefault(x => x.Id == id);
        }

        public Language Add(Language language)
        {
            _context.Languages.Add(language);
            _context.SaveChanges();
            return language;
        }
        
        public void Update(Language language)
        {
            _context.Languages.Update(language);
            _context.SaveChanges();
        }

        public void Delete(Language language)
        {
            _context.Languages.Remove(language);
            _context.SaveChanges();
        }
    }
}

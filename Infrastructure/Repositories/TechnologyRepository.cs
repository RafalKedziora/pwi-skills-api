using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class TechnologyRepository : ITechnologyRepository
    {
        private readonly SkillContext _context;
        public TechnologyRepository(SkillContext context)
        {
            _context = context;
        }

        public IQueryable<TechStack> GetAll()
        {
            return _context.TechStacks;
        }

        public TechStack GetById(int id)
        {
            return _context.TechStacks
                .FirstOrDefault(t => t.Id == id);
        }

        public TechStack Add(TechStack technology)
        {
            _context.TechStacks.Add(technology);
            _context.SaveChanges();
            return technology;
        }

        public void Update(TechStack technology)
        {
            _context.TechStacks.Update(technology);
            _context.SaveChanges();
        }

        public void Delete(TechStack technology)
        {
            _context.TechStacks.Remove(technology);
            _context.SaveChanges();
        }
    }
}

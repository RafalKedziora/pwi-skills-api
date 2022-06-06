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

        public IQueryable<Technology> GetAll()
        {
            return _context.Technologies;
        }

        public Technology GetById(int id)
        {
            return _context.Technologies
                .FirstOrDefault(t => t.Id == id);
        }

        public Technology Add(Technology technology)
        {
            _context.Technologies.Add(technology);
            _context.SaveChanges();
            return technology;
        }

        public void Update(Technology technology)
        {
            _context.Technologies.Update(technology);
            _context.SaveChanges();
        }

        public void Delete(Technology technology)
        {
            _context.Technologies.Remove(technology);
            _context.SaveChanges();
        }
    }
}

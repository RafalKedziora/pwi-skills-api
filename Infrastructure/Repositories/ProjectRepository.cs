using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly SkillContext _context;
        public ProjectRepository(SkillContext context)
        {
            _context = context;
        }

        public IQueryable<Project> GetAll()
        {
            return _context.Projects
                .Include(x => x.Details)
                .Include(x => x.Comments)
                .Include(x => x.Authors)
                .Include(x => x.Technologies);
        }

        public Project GetById(int id)
        {
            return _context.Projects
                .Include(x => x.Details)
                .Include(x => x.Comments)
                .Include(x => x.Authors)
                .Include(x => x.Technologies)
                .FirstOrDefault(x => x.Id == id);
        }

        public Project Add(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
            return project;
        }

        public void Update(Project project)
        {
            _context.Projects.Update(project);
            _context.SaveChanges();
        }

        public void Delete(Project project)
        {
            _context.Projects.Remove(project);
            _context.SaveChanges();
        }
    }
}

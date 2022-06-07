using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class ProjectDetailsRepository : IProjectDetailsRepository
    {
        private readonly SkillContext _context;
        public ProjectDetailsRepository(SkillContext context)
        {
            _context = context;
        }

        public ProjectDetails GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ProjectDetails Add(ProjectDetails project)
        {
            throw new NotImplementedException();
        }

        public void Update(ProjectDetails project)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProjectDetails project)
        {
            throw new NotImplementedException();
        }
    }
}

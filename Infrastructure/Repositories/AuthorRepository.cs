using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly SkillContext _context;
        public AuthorRepository(SkillContext context)
        {
            _context = context;
        }

        public IQueryable<Author> GetAll()
        {
            return _context.Authors
                .Include(x => x.Projects);
        }

        public Author GetById(Guid id)
        {
            return _context.Authors
                .Include(x => x.Projects)
                .FirstOrDefault(x => x.Id == id);
        }

        public Author GetByNickName(string nickName)
        {
            return _context.Authors
                .Include(x => x.Projects)
                .FirstOrDefault(x => x.NickName == nickName);
        }

        public Author Add(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
            return author;
        }

        public void Update(Author author)
        {
            _context.Authors.Update(author);
            _context.SaveChanges();
        }

        public void Delete(Author author)
        {
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
    }
}

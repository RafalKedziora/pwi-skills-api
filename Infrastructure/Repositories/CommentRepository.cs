using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly SkillContext _context;
        public CommentRepository(SkillContext context)
        {
            _context = context;
        }

        public IQueryable<Comment> GetAll()
        {
            return _context.Comments
                .Include(x => x.Project);
        }

        public Comment GetById(int id)
        {
            return _context.Comments
                .Include(x => x.Project)
                .FirstOrDefault(x => x.Id == id);
        }

        public Comment Add(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
            return comment;
        }

        public void Update(Comment comment)
        {
            _context.Comments.Update(comment);
            _context.SaveChanges();
        }

        public void Delete(Comment comment)
        {
            _context.Comments.Remove(comment);
            _context.SaveChanges();
        }
    }
}

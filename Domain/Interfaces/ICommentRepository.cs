using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ICommentRepository
    {
        IQueryable<Comment> GetAll();
        Comment GetById(int id);
        Comment Add(Comment comment);
        void Update(Comment comment);
        void Delete(Comment comment);
    }
}

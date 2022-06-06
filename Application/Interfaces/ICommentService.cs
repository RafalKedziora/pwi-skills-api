using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICommentService
    {
        IQueryable<Comment> GetAllComments();
        Comment GetCommentById(int id);
        Comment AddComment(Comment comment);
        void UpdateComment(Comment comment);
        void DeleteComment(Comment comment);
    }
}

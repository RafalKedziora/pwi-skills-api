using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class CommentService : ICommentService
    {
        public IQueryable<Comment> GetAllComments()
        {
            throw new NotImplementedException();
        }

        public Comment GetCommentById(int id)
        {
            throw new NotImplementedException();
        }

        public Comment AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}

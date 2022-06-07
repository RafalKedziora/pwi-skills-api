using Application.Dto;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICommentService
    {
        ListCommentsDto GetAllComments();
        CommentDto GetCommentById(int id);
        CommentDto AddComment(CreateCommentDto newComment);
        void UpdateComment(int id, UpdateCommentDto comment);
        void DeleteComment(int id);
    }
}

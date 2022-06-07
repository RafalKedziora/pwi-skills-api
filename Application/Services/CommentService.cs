using Application.Dto;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentService(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }

        public ListCommentsDto GetAllComments()
        {
            var comments = _commentRepository.GetAll();
            return _mapper.Map<ListCommentsDto>(comments);
        }

        public CommentDto GetCommentById(int id)
        {
            var comment = _commentRepository.GetById(id);
            return _mapper.Map<CommentDto>(comment);
        }
        public CommentDto AddComment(CreateCommentDto newComment)
        {
            var comment = _mapper.Map<Comment>(newComment);
            _commentRepository.Add(comment);
            return _mapper.Map<CommentDto>(comment);
        }

        public void UpdateComment(int id, UpdateCommentDto comment)
        {
            var existingComment = _commentRepository.GetById(id);
            var updatedComment = _mapper.Map(comment, existingComment);
            _commentRepository.Update(updatedComment);
        }        

        public void DeleteComment(int id)
        {
            var comment = _commentRepository.GetById(id);
            _commentRepository.Delete(comment);
        }
    }
}

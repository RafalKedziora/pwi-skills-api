using Domain.Entities;

namespace Application.Dto
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Author { get; set; }
        public int ProjectId { get; set; }
    }
}

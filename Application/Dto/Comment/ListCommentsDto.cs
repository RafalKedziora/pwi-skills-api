namespace Application.Dto
{
    public class ListCommentsDto
    {
        public int Count { get; set; }
        public IEnumerable<CommentDto> Comments { get; set; }
    }
}

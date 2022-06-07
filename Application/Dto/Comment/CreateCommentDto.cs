namespace Application.Dto
{
    public class CreateCommentDto
    {
        public string Message { get; set; }
        public string Author { get; set; }
        public int ProjectId { get; set; }
    }
}

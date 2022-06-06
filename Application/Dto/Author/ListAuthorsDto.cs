namespace Application.Dto
{
    public class ListAuthorsDto
    {
        public int Count { get; set; }
        public IEnumerable<AuthorDto> Authors { get; set; }
    }
}

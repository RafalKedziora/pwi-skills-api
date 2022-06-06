namespace Application.Dto
{
    public class ListLanguagesDto
    {
        public int Count { get; set; }
        public IEnumerable<LanguageDto> Languages { get; set; }
    }
}

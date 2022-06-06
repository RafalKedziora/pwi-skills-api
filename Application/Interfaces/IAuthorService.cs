using Domain.Entities;

namespace Application.Interfaces
{
    public interface IAuthorService
    {
        IQueryable<Author> GetAllAuthors();
        Author GetAuthorById(Guid id);
        Author GetAuthorByNickName(string nickName);
        Author AddNewAuthor(Author author);
        void UpdateAuthor(Author comment);
        void DeleteAuthor(Author comment);
    }
}

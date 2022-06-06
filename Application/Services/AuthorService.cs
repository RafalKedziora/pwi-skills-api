using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class AuthorService : IAuthorService
    {
        public IQueryable<Author> GetAllAuthors()
        {
            throw new NotImplementedException();
        }

        public Author GetAuthorById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Author GetAuthorByNickName(string nickName)
        {
            throw new NotImplementedException();
        }
        
        public Author AddNewAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void UpdateAuthor(Author comment)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuthor(Author comment)
        {
            throw new NotImplementedException();
        }
    }
}

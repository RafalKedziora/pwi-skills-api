using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IAuthorRepository
    {
        IQueryable<Author> GetAll();
        Author GetById(Guid id);
        Author GetByNickName(string nickName);
        Author Add(Author author);
        void Update(Author comment);
        void Delete(Author comment);
    }
}

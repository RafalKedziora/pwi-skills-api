using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IAuthorRepository
    {
        IQueryable<Author> GetAll();
        IQueryable<Author> GetAllConnectedToTheProject(Project project);
        Author GetById(int id);
        Author GetByNickName(string nickName);
        Author Add(Author author);
        void Update(Author comment);
        void Delete(Author comment);
    }
}

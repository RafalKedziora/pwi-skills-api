using Application.Dto;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IAuthorService
    {
        ListAuthorsDto GetAllAuthors();
        ListAuthorsDto GetAllAuthorsConnectedToTheProject(int projectId);
        AuthorDto GetAuthorById(int id);
        AuthorDto GetAuthorByNickName(string nickName);
        AuthorDto AddNewAuthor(CreateAuthorDto newAuthor);
        void UpdateAuthor(int id, UpdateAuthorDto author);
        void DeleteAuthor(int id);
    }
}

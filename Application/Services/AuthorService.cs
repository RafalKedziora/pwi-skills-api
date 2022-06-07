using Application.Dto;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;
        public AuthorService(IAuthorRepository authorRepository, IProjectRepository projectRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _projectRepository = projectRepository;
            _mapper = mapper;
        }

        public ListAuthorsDto GetAllAuthors()
        {
            var authors = _authorRepository.GetAll();
            return _mapper.Map<ListAuthorsDto>(authors);
        }

        public ListAuthorsDto GetAllAuthorsConnectedToTheProject(int projectId)
        {
            var project = _projectRepository.GetById(projectId);
            var authors = _authorRepository.GetAllConnectedToTheProject(project);
            return _mapper.Map<ListAuthorsDto>(authors);
        }

        public AuthorDto GetAuthorById(int id)
        {
            var author = _authorRepository.GetById(id);
            return _mapper.Map<AuthorDto>(author);
        }

        public AuthorDto GetAuthorByNickName(string nickName)
        {
            var author = _authorRepository.GetByNickName(nickName);
            return _mapper.Map<AuthorDto>(author);
        }

        public AuthorDto AddNewAuthor(CreateAuthorDto newAuthor)
        {
            var author = _mapper.Map<Author>(newAuthor);
            _authorRepository.Add(author);
            return _mapper.Map<AuthorDto>(author);
        }

        public void UpdateAuthor(int id, UpdateAuthorDto author)
        {
            var existingAuthor = _authorRepository.GetById(id);
            var updatedAuthor = _mapper.Map(author, existingAuthor);
            _authorRepository.Update(updatedAuthor);
        }

        public void DeleteAuthor(int id)
        {
            var author = _authorRepository.GetById(id);
            _authorRepository.Delete(author);
        }
    }
}

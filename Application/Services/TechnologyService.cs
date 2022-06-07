using Application.Dto;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class TechnologyService : ITechnologyService
    {
        private readonly ITechnologyRepository _techStackRepository;
        private readonly IMapper _mapper;

        public TechnologyService(ITechnologyRepository techStackRepository, IMapper mapper)
        {
            _techStackRepository = techStackRepository;
            _mapper = mapper;
        }

        public ListTechStacksDto GetAllTechStacks()
        {
            var techStacks = _techStackRepository.GetAll();
            return _mapper.Map<ListTechStacksDto>(techStacks);
        }

        public TechStackDto GetTechStackById(int id)
        {
            var techStack = _techStackRepository.GetById(id);
            return _mapper.Map<TechStackDto>(techStack);
        }

        public TechStackDto AddTechStack(CreateTechStackDto newTechStack)
        {
            var techStack = _mapper.Map<TechStack>(newTechStack);
            _techStackRepository.Add(techStack);
            return _mapper.Map<TechStackDto>(techStack);
        }

        public void UpdateTechStack(UpdateTechStackDto techStack)
        {
            var existingTechStack = _techStackRepository.GetById(techStack.Id);
            var updatedTechStack = _mapper.Map(techStack, existingTechStack);
            _techStackRepository.Update(updatedTechStack);
        }

        public void DeleteTechStack(int id)
        {
            var techStack = _techStackRepository.GetById(id);
            _techStackRepository.Delete(techStack);
        }
    }
}
